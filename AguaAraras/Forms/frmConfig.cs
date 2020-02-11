using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.Entity.Core.EntityClient;
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace AguaAraras {
    public partial class frmConfig : Form {

        private string ConnName => comboBoxStrings.SelectedItem.ToString();
        private bool IsConnEntity => ConnName.EndsWith("Entities");
        private bool IsConnADO => ConnName.EndsWith("ADO");
        private bool IsConnServer => IsConnEntity || IsConnADO;

        public frmConfig() {
            InitializeComponent();
        }

        private void frmConfig_Load(object sender, EventArgs e) {
            listBoxSQLServers.Items.AddRange(GetSQLInstances());

            var connNames = ConfigurationManager.ConnectionStrings
                .Cast<ConnectionStringSettings>().Select(i => i.Name).OrderBy(i => i).ToArray();
            comboBoxStrings.Items.AddRange(connNames);
            comboBoxStrings.SelectedIndex = 0;
            buttonSave.Enabled = false;
        }

        private void comboBoxStrings_SelectedIndexChanged(object sender, EventArgs e) {
            AskIfSave();
            var str = ConfigurationManager.ConnectionStrings[ConnName].ToString();
            textBoxString.Text = str;

            if (IsConnEntity) {
                propertyGridConn.SelectedObject = new EntityConnectionStringBuilder(str);
                listBoxSQLServers.SelectedIndex = listBoxSQLServers.Items.IndexOf(EntityDataSource());
            }
            else if (IsConnADO) {
                var csb = new SqlConnectionStringBuilder(str);
                propertyGridConn.SelectedObject = csb;
                var ds = csb.DataSource;
                listBoxSQLServers.SelectedIndex = listBoxSQLServers.Items.IndexOf(ds);
            }
            else {
                propertyGridConn.SelectedObject = new OleDbConnectionStringBuilder(str);
            }
            buttonTestConnection.Enabled = IsConnServer;
            listBoxSQLServers.Enabled = IsConnServer;
        }

        private void propertyGridConn_PropertyValueChanged(object s, PropertyValueChangedEventArgs e) {
            var connectionStringBuilder = (DbConnectionStringBuilder)propertyGridConn.SelectedObject;
            textBoxString.Text = connectionStringBuilder.ConnectionString;
            buttonSave.Enabled = true;
        }

        private void buttonSave_Click(object sender, EventArgs e) {
            Save();
        }

        private void Save() {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (comboBoxStrings.SelectedItem != null) {
                var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                connectionStringsSection.ConnectionStrings[ConnName].ConnectionString = textBoxString.Text;
            }
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("connectionStrings");
            ConfigurationManager.RefreshSection("appSettings");
            buttonSave.Enabled = false;
        }

        private void frmConfig_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = AskIfSave();
        }

        private bool AskIfSave() {
            if (!buttonSave.Enabled) {
                return false;
            }

            var resp = MessageBox.Show($@"Salvar alterações em {ConnName}?", @"Configuração", MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);
            if (resp == DialogResult.Yes) {
                Save();
            }
            buttonSave.Enabled = false;
            return resp == DialogResult.Cancel;
        }

        private void buttonTestConnection_Click(object sender, EventArgs e) {
            string cs;
            if (IsConnEntity) {
                var csb = new SqlConnectionStringBuilder(); ;
                csb.DataSource = EntityDataSource();
                csb.InitialCatalog = EntityDatabase();
                csb.IntegratedSecurity = true;
                cs = csb.ToString();
            }
            else {
                var csb = (DbConnectionStringBuilder)propertyGridConn.SelectedObject;
                cs = csb.ToString();
            }

            try {
                var conn = new SqlConnection(cs);
                conn.Open();
                if (conn.State == ConnectionState.Open) {
                    MessageBox.Show(@"Conexão completada com sucesso!", @"Configuração", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    conn.Close();
                }
                else {
                    MessageBox.Show(@"Conexão não completada. Verifique os parâmetros.", @"Configuração",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"Conexão não completada. Verifique os parâmetros.\n\n{cs}\n\n{ex.Message}",
                    @"Configuração",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void listBoxSQLServers_SelectedIndexChanged(object sender, EventArgs e) {
            if (listBoxSQLServers.SelectedIndex == -1) {
                return;
            }

            var server = listBoxSQLServers.SelectedItem.ToString();
            if (IsConnEntity) {
                if (server == EntityDataSource()) {
                    return;
                }

                var csArray = EntityConnectionStringAsArray();
                for (var i = 0; i < csArray.Count(); i++) {
                    if (!csArray[i].StartsWith("data source")) {
                        continue;
                    }
                    csArray[i] = $"data source={server}";
                    break;
                }

                var conn = (EntityConnectionStringBuilder)propertyGridConn.SelectedObject;
                conn.ProviderConnectionString = string.Join(";", csArray);
                textBoxString.Text = conn.ToString();
            }
            else if (IsConnADO) {
                var conn = (SqlConnectionStringBuilder)propertyGridConn.SelectedObject;
                if (conn.DataSource == server) {
                    return;
                }

                conn.DataSource = server;
                textBoxString.Text = conn.ToString();
            }
            propertyGridConn.Refresh();
            buttonSave.Enabled = true;
        }

        private string[] EntityConnectionStringAsArray() {
            var conn = (EntityConnectionStringBuilder)propertyGridConn.SelectedObject;
            var cs = conn.ProviderConnectionString;
            return cs.Split(new char[] { ';' });
        }

        private string EntityDataSource() {
            return EntityConnectionStringInfo("data source");
        }

        private string EntityDatabase() {
            return EntityConnectionStringInfo("initial catalog");
        }

        private string EntityConnectionStringInfo(string info) {
            return EntityConnectionStringAsArray()
                .First(s => s.StartsWith(info)).Substring(info.Length + 1);
        }

        private static string[] GetSQLInstances() {
            //var myServer = Environment.MachineName;
            var servers = SqlDataSourceEnumerator.Instance.GetDataSources();
            var instances = new List<string>();
            for (var i = 0; i < servers.Rows.Count; i++) {
                var server = servers.Rows[i]["ServerName"].ToString();
                //if (myServer != server) {
                //    continue;
                //}
                if ((servers.Rows[i]["InstanceName"] as string) != null) {
                    server += "\\" + servers.Rows[i]["InstanceName"];
                }
                instances.Add(server);
            }
            return instances.ToArray();
        }
    }
}