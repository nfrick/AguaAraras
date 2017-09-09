﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AguaAraras {
    public partial class frmPessoas : Form {
        public List<Pessoa> Pessoas;
        private BindingSource _sourcePessoas;

        private BindingSource _sourceEnderecos;
        public List<Endereco> EnderecosAll;
        public List<Endereco> Enderecos;
        public List<Endereco> EnderecosDeleted = new List<Endereco>();

        private BindingSource _sourceTelefones;
        public List<Telefone> TelefonesAll;
        public List<Telefone> Telefones;
        public List<Telefone> TelefonesDeleted = new List<Telefone>();

        //private CurrencyManager myCurrencyManager;

        private bool _loading = true;
        public frmPessoas() {
            InitializeComponent();
        }

        private void frmPessoas_Load(object sender, EventArgs e) {
            Pessoas = Database.PessoasGet();
            foreach (var p in Pessoas)
                listBoxPessoas.Items.Add(p.Nome);
            _sourcePessoas = new BindingSource {DataSource = Pessoas};
            bindingSourcePessoas.DataSource = _sourcePessoas;

            EnderecosAll = Database.EnderecosGet();
            _sourceEnderecos = new BindingSource {DataSource = Enderecos};
            bindingSourceEnderecos.DataSource = _sourceEnderecos;

            TelefonesAll = Database.TelefonesGet();
            _sourceTelefones = new BindingSource {DataSource = TelefonesAll};
            bindingSourceTelefones.DataSource = _sourceTelefones;

            //myCurrencyManager = (CurrencyManager)this.BindingContext[bindingSourcePessoas];
            //myCurrencyManager.ItemChanged += new ItemChangedEventHandler(CurrencyManager_ItemChanged);
            //bindingSourcePessoas.CurrentChanged += new EventHandler(CheckChanged);

            var cobrancaTipos = new Dictionary<byte, string> {{0, "Não enviar"}, {1, "Impressa"}, {2, "E-Mail"}};
            cobrancaComboBox.ValueMember = "Key";
            cobrancaComboBox.DisplayMember = "Value";
            cobrancaComboBox.DataSource = new BindingSource(cobrancaTipos, null);

            var telefoneTipos =
                new Dictionary<byte, string> {{1, "Residência"}, {2, "Araras"}, {3, "Trabalho"}, {4, "Celular"}};

            var theColumn = (DataGridViewComboBoxColumn)this.dataGridViewTelefones.Columns["dataGridViewTextBoxColumnTipo"];
            theColumn.ValueMember = "Key";
            theColumn.DisplayMember = "Value";
            theColumn.DataSource = new BindingSource(telefoneTipos, null);

            _loading = false;
            SetChildren();
            listBoxPessoas.SelectedIndex = bindingSourcePessoas.Position;
        }

        private void listBoxPessoas_SelectedIndexChanged(object sender, EventArgs e) {
            bindingSourcePessoas.Position = listBoxPessoas.SelectedIndex;
        }

        private void bindingNavigatorMove_Click(object sender, EventArgs e) {
            if (!_loading)
                listBoxPessoas.SelectedIndex = bindingSourcePessoas.Position;
        }

        //private void CurrencyManager_ItemChanged(object sender, System.Windows.Forms.ItemChangedEventArgs e) {
        //    CurrencyManager myCurrencyManager = (CurrencyManager)sender;
        //    MessageBox.Show("Item Changed " + myCurrencyManager.Position);
        //}

        private void toolStripButtonSave_Click(object sender, EventArgs e) {
            var pessoa = (Pessoa)bindingSourcePessoas.Current;
            var endUpdated = Enderecos.Where(end => end.Updated).ToList();
            var telUpdated = Telefones.Where(tel => tel.Updated).ToList();
            if (Database.PessoaUpdate(pessoa, endUpdated, EnderecosDeleted, telUpdated, TelefonesDeleted)) {
                pessoa.Updated = false;
                foreach (var end in endUpdated) {
                    end.Updated = false;
                    if (EnderecosAll.All(endAll => endAll.ID != end.ID))
                        EnderecosAll.Add(end);
                }
                EnderecosDeleted.Clear(); // = EnderecosDeleted.Except(End_Deleted).ToList();

                foreach (var tel in telUpdated) {
                    tel.Updated = false;
                    if (TelefonesAll.All(telAll => telAll.ID != tel.ID))
                        TelefonesAll.Add(tel);
                }
                TelefonesDeleted.Clear(); // = TelefonesDeleted.Except(Tel_Deleted).ToList();
            }

            listBoxPessoas.Items[listBoxPessoas.SelectedIndex] = pessoa.Nome;
            _sourceEnderecos.ResetBindings(false);
            _sourceTelefones.ResetBindings(false);
            //RaiseUpdated();
            //RaiseDeleted();

        }

        private void bindingSourcePessoas_CurrentChanged(object sender, EventArgs e) {
            if (!_loading)
                SetChildren();
        }

        private void SetChildren() {
            int pessoaID = ((Pessoa)bindingSourcePessoas.Current).ID;

            Enderecos?.Clear();
            Enderecos = EnderecosAll.Where(end => end.PessoaID == pessoaID).ToList();
            _sourceEnderecos.DataSource = Enderecos;

            Telefones?.Clear();
            Telefones = TelefonesAll.Where(tel => tel.PessoaID == pessoaID).ToList();
            _sourceTelefones.DataSource = Telefones;
        }

        private void frmPessoas_FormClosing(object sender, FormClosingEventArgs e) {
            //dataGridViewEnderecos.EndEdit();
            //this.BindingContext[dataGridViewEnderecos.DataSource].EndCurrentEdit();
        }

        private void dataGridViewEnderecos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (!Enderecos.Any() || Enderecos.Count <= e.RowIndex)
                return;
            if (Enderecos[e.RowIndex].IsNew)
                e.CellStyle.BackColor = Color.Khaki;
            else if (Enderecos[e.RowIndex].Updated)
                e.CellStyle.BackColor = Color.Bisque;
        }

        private void dataGridViewEnderecos_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex == -1) return;
            Enderecos[e.RowIndex].PessoaID = ((Pessoa)bindingSourcePessoas.Current).ID;
            Enderecos[e.RowIndex].Updated = true;
            _sourceEnderecos.ResetBindings(false);
            //RaiseUpdated();
        }

        private void dataGridViewEnderecos_UserAddedRow(object sender, DataGridViewRowEventArgs e) {
            //RaiseAdded();
        }

        private void dataGridViewEnderecos_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e) {
            var row = e.Row.Index;
            if (!Enderecos[row].IsNew)
                EnderecosDeleted.Add(Enderecos[row]);
        }

        private void dataGridViewEnderecos_UserDeletedRow(object sender, DataGridViewRowEventArgs e) {
            _sourceEnderecos.ResetBindings(false);
            //RaiseDeleted();
        }

        private void dataGridViewEnderecos_DataError(object sender, DataGridViewDataErrorEventArgs e) {
            MessageBox.Show($@"Endereço: Data error in row {e.RowIndex} column {e.ColumnIndex}");
        }

        private void dataGridViewTelefones_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (!Telefones.Any() || Telefones.Count <= e.RowIndex)
                return;
            if (Telefones[e.RowIndex].IsNew)
                e.CellStyle.BackColor = Color.Khaki;
            else if (Telefones[e.RowIndex].Updated)
                e.CellStyle.BackColor = Color.Bisque;
        }

        private void dataGridViewTelefones_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex == -1) return;
            Telefones[e.RowIndex].PessoaID = ((Pessoa)bindingSourcePessoas.Current).ID;
            Telefones[e.RowIndex].Updated = true;
            _sourceTelefones.ResetBindings(false);
            //RaiseUpdated();
        }

        private void dataGridViewTelefones_UserAddedRow(object sender, DataGridViewRowEventArgs e) {

        }

        private void dataGridViewTelefones_UserDeletedRow(object sender, DataGridViewRowEventArgs e) {
            _sourceTelefones.ResetBindings(false);
        }

        private void dataGridViewTelefones_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e) {
            int row = e.Row.Index;
            if (!Telefones[row].IsNew)
                TelefonesDeleted.Add(Telefones[row]);
        }

        private void dataGridViewTelefones_DataError(object sender, DataGridViewDataErrorEventArgs e) {
            MessageBox.Show($@"Telefone: Data error in row {e.RowIndex} column {e.ColumnIndex}");
        }
    }
}