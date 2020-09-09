namespace AguaAraras {
    partial class frmPessoas {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lablTomadas;
            System.Windows.Forms.Label labelObservacoes;
            System.Windows.Forms.Label labelNome;
            System.Windows.Forms.Label labelCobranca;
            System.Windows.Forms.Label labelEMail;
            System.Windows.Forms.Label labelPendente;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.bsPessoas = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxSobrenome = new System.Windows.Forms.TextBox();
            this.dgvEnderecos = new System.Windows.Forms.DataGridView();
            this.Logradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEPformattedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Residencia = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Correspondencia = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bsEnderecos = new System.Windows.Forms.BindingSource(this.components);
            this.dgvTelefones = new System.Windows.Forms.DataGridView();
            this.colTipo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dDDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsTelefones = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxEMail = new System.Windows.Forms.TextBox();
            this.textBoxObservacoes = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelTomadasNumero = new System.Windows.Forms.Label();
            this.cobrancaComboBox = new System.Windows.Forms.ComboBox();
            this.tratamentoComboBox = new System.Windows.Forms.ComboBox();
            this.checkBoxRecibo = new System.Windows.Forms.CheckBox();
            this.checkBoxAtualizar = new System.Windows.Forms.CheckBox();
            this.checkBoxAtivo = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labelPendenteValor = new System.Windows.Forms.Label();
            this.dgvPagamentos = new System.Windows.Forms.DataGridView();
            this.ReciboAnoNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsCotas = new System.Windows.Forms.BindingSource(this.components);
            this.enderecoArarasLabel1 = new System.Windows.Forms.Label();
            this.nomeCompletoLabel1 = new System.Windows.Forms.Label();
            this.iDLabel = new System.Windows.Forms.Label();
            this.dgvPessoas = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUndo = new System.Windows.Forms.ToolStripButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.valorDescricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorExtensoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cobrancaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tratamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobrenomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCompletoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tomadasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tomadasExtensoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoArarasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gerarReciboDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.depositoIdentificadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reciboNumeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reciboNumeroAnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reciboAnoNumeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reciboEmissaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reciboVencimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reciboCotaValorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reciboMesesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reciboMesesExtensoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reciboDescricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reciboObservacoesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reciboIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pessoaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacoesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pessoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reciboDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lablTomadas = new System.Windows.Forms.Label();
            labelObservacoes = new System.Windows.Forms.Label();
            labelNome = new System.Windows.Forms.Label();
            labelCobranca = new System.Windows.Forms.Label();
            labelEMail = new System.Windows.Forms.Label();
            labelPendente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsPessoas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnderecos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEnderecos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTelefones)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoas)).BeginInit();
            this.toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lablTomadas
            // 
            lablTomadas.BackColor = System.Drawing.Color.Maroon;
            lablTomadas.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lablTomadas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            lablTomadas.Location = new System.Drawing.Point(782, 14);
            lablTomadas.Name = "lablTomadas";
            lablTomadas.Size = new System.Drawing.Size(114, 34);
            lablTomadas.TabIndex = 39;
            lablTomadas.Text = "Tomadas";
            lablTomadas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelObservacoes
            // 
            labelObservacoes.AutoSize = true;
            labelObservacoes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelObservacoes.Location = new System.Drawing.Point(6, 139);
            labelObservacoes.Name = "labelObservacoes";
            labelObservacoes.Size = new System.Drawing.Size(127, 28);
            labelObservacoes.TabIndex = 43;
            labelObservacoes.Text = "Observações:";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelNome.Location = new System.Drawing.Point(7, 18);
            labelNome.Name = "labelNome";
            labelNome.Size = new System.Drawing.Size(70, 28);
            labelNome.TabIndex = 42;
            labelNome.Text = "Nome:";
            // 
            // labelCobranca
            // 
            labelCobranca.AutoSize = true;
            labelCobranca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelCobranca.Location = new System.Drawing.Point(649, 159);
            labelCobranca.Name = "labelCobranca";
            labelCobranca.Size = new System.Drawing.Size(99, 28);
            labelCobranca.TabIndex = 44;
            labelCobranca.Text = "Cobrança:";
            // 
            // labelEMail
            // 
            labelEMail.AutoSize = true;
            labelEMail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelEMail.Location = new System.Drawing.Point(6, 52);
            labelEMail.Name = "labelEMail";
            labelEMail.Size = new System.Drawing.Size(72, 28);
            labelEMail.TabIndex = 41;
            labelEMail.Text = "E-Mail:";
            // 
            // labelPendente
            // 
            labelPendente.BackColor = System.Drawing.Color.Maroon;
            labelPendente.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelPendente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            labelPendente.Location = new System.Drawing.Point(684, 81);
            labelPendente.Name = "labelPendente";
            labelPendente.Size = new System.Drawing.Size(186, 34);
            labelPendente.TabIndex = 41;
            labelPendente.Text = "Pendente";
            labelPendente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNome
            // 
            this.textBoxNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPessoas, "Nome", true));
            this.textBoxNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.Location = new System.Drawing.Point(153, 14);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(202, 34);
            this.textBoxNome.TabIndex = 1;
            // 
            // bsPessoas
            // 
            this.bsPessoas.DataSource = typeof(DataLayer.Pessoa);
            // 
            // textBoxSobrenome
            // 
            this.textBoxSobrenome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPessoas, "Sobrenome", true));
            this.textBoxSobrenome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSobrenome.Location = new System.Drawing.Point(361, 14);
            this.textBoxSobrenome.Name = "textBoxSobrenome";
            this.textBoxSobrenome.Size = new System.Drawing.Size(252, 34);
            this.textBoxSobrenome.TabIndex = 2;
            // 
            // dgvEnderecos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvEnderecos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEnderecos.AutoGenerateColumns = false;
            this.dgvEnderecos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnderecos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Logradouro,
            this.Bairro,
            this.Cidade,
            this.Estado,
            this.cEPformattedDataGridViewTextBoxColumn,
            this.Residencia,
            this.Correspondencia});
            this.dgvEnderecos.DataSource = this.bsEnderecos;
            this.dgvEnderecos.Location = new System.Drawing.Point(13, 6);
            this.dgvEnderecos.Name = "dgvEnderecos";
            this.dgvEnderecos.RowHeadersWidth = 25;
            this.dgvEnderecos.RowTemplate.Height = 26;
            this.dgvEnderecos.Size = new System.Drawing.Size(885, 116);
            this.dgvEnderecos.TabIndex = 3;
            this.dgvEnderecos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEnderecos_CellEndEdit);
            this.dgvEnderecos.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvEnderecos_CellValidating);
            // 
            // Logradouro
            // 
            this.Logradouro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Logradouro.DataPropertyName = "Logradouro";
            this.Logradouro.HeaderText = "Logradouro";
            this.Logradouro.Name = "Logradouro";
            // 
            // Bairro
            // 
            this.Bairro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Bairro.DataPropertyName = "Bairro";
            this.Bairro.HeaderText = "Bairro";
            this.Bairro.Name = "Bairro";
            this.Bairro.Width = 93;
            // 
            // Cidade
            // 
            this.Cidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Cidade.DataPropertyName = "Cidade";
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            this.Cidade.Width = 102;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "UF";
            this.Estado.Name = "Estado";
            this.Estado.Width = 50;
            // 
            // cEPformattedDataGridViewTextBoxColumn
            // 
            this.cEPformattedDataGridViewTextBoxColumn.DataPropertyName = "CEPformatted";
            this.cEPformattedDataGridViewTextBoxColumn.HeaderText = "CEP";
            this.cEPformattedDataGridViewTextBoxColumn.Name = "cEPformattedDataGridViewTextBoxColumn";
            // 
            // Residencia
            // 
            this.Residencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Residencia.DataPropertyName = "Residencia";
            this.Residencia.HeaderText = "Res.";
            this.Residencia.Name = "Residencia";
            this.Residencia.Width = 51;
            // 
            // Correspondencia
            // 
            this.Correspondencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Correspondencia.DataPropertyName = "Correspondencia";
            this.Correspondencia.HeaderText = "Corr.";
            this.Correspondencia.Name = "Correspondencia";
            this.Correspondencia.Width = 60;
            // 
            // bsEnderecos
            // 
            this.bsEnderecos.DataMember = "Enderecos";
            this.bsEnderecos.DataSource = this.bsPessoas;
            // 
            // dgvTelefones
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvTelefones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTelefones.AutoGenerateColumns = false;
            this.dgvTelefones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelefones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTipo,
            this.dDDDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn});
            this.dgvTelefones.DataSource = this.bsTelefones;
            this.dgvTelefones.Location = new System.Drawing.Point(13, 128);
            this.dgvTelefones.Name = "dgvTelefones";
            this.dgvTelefones.RowHeadersWidth = 25;
            this.dgvTelefones.RowTemplate.Height = 26;
            this.dgvTelefones.Size = new System.Drawing.Size(328, 118);
            this.dgvTelefones.TabIndex = 4;
            this.dgvTelefones.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTelefones_CellEndEdit);
            this.dgvTelefones.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvTelefones_CellValidating);
            this.dgvTelefones.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvTelefones_DataError);
            // 
            // colTipo
            // 
            this.colTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colTipo.DataPropertyName = "Tipo";
            this.colTipo.HeaderText = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colTipo.Width = 80;
            // 
            // dDDDataGridViewTextBoxColumn
            // 
            this.dDDDataGridViewTextBoxColumn.DataPropertyName = "DDD";
            this.dDDDataGridViewTextBoxColumn.HeaderText = "DDD";
            this.dDDDataGridViewTextBoxColumn.Name = "dDDDataGridViewTextBoxColumn";
            this.dDDDataGridViewTextBoxColumn.Width = 50;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            // 
            // bsTelefones
            // 
            this.bsTelefones.DataMember = "Telefones";
            this.bsTelefones.DataSource = this.bsPessoas;
            // 
            // textBoxEMail
            // 
            this.textBoxEMail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPessoas, "EMail", true));
            this.textBoxEMail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEMail.Location = new System.Drawing.Point(108, 49);
            this.textBoxEMail.Multiline = true;
            this.textBoxEMail.Name = "textBoxEMail";
            this.textBoxEMail.Size = new System.Drawing.Size(505, 81);
            this.textBoxEMail.TabIndex = 6;
            this.textBoxEMail.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEMail_Validating);
            // 
            // textBoxObservacoes
            // 
            this.textBoxObservacoes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPessoas, "Observacoes", true));
            this.textBoxObservacoes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxObservacoes.Location = new System.Drawing.Point(108, 136);
            this.textBoxObservacoes.Multiline = true;
            this.textBoxObservacoes.Name = "textBoxObservacoes";
            this.textBoxObservacoes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxObservacoes.Size = new System.Drawing.Size(505, 125);
            this.textBoxObservacoes.TabIndex = 7;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(223, 161);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(912, 297);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(labelObservacoes);
            this.tabPage1.Controls.Add(labelNome);
            this.tabPage1.Controls.Add(labelCobranca);
            this.tabPage1.Controls.Add(labelEMail);
            this.tabPage1.Controls.Add(this.labelTomadasNumero);
            this.tabPage1.Controls.Add(lablTomadas);
            this.tabPage1.Controls.Add(this.cobrancaComboBox);
            this.tabPage1.Controls.Add(this.tratamentoComboBox);
            this.tabPage1.Controls.Add(this.checkBoxRecibo);
            this.tabPage1.Controls.Add(this.checkBoxAtualizar);
            this.tabPage1.Controls.Add(this.checkBoxAtivo);
            this.tabPage1.Controls.Add(this.textBoxNome);
            this.tabPage1.Controls.Add(this.textBoxSobrenome);
            this.tabPage1.Controls.Add(this.textBoxEMail);
            this.tabPage1.Controls.Add(this.textBoxObservacoes);
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(904, 256);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelTomadasNumero
            // 
            this.labelTomadasNumero.BackColor = System.Drawing.Color.Black;
            this.labelTomadasNumero.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPessoas, "Tomadas", true));
            this.labelTomadasNumero.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTomadasNumero.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTomadasNumero.Location = new System.Drawing.Point(782, 48);
            this.labelTomadasNumero.Name = "labelTomadasNumero";
            this.labelTomadasNumero.Size = new System.Drawing.Size(114, 66);
            this.labelTomadasNumero.TabIndex = 40;
            this.labelTomadasNumero.Text = "X";
            this.labelTomadasNumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cobrancaComboBox
            // 
            this.cobrancaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsPessoas, "Cobranca", true));
            this.cobrancaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobrancaComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobrancaComboBox.FormattingEnabled = true;
            this.cobrancaComboBox.Location = new System.Drawing.Point(653, 183);
            this.cobrancaComboBox.Name = "cobrancaComboBox";
            this.cobrancaComboBox.Size = new System.Drawing.Size(112, 36);
            this.cobrancaComboBox.TabIndex = 12;
            // 
            // tratamentoComboBox
            // 
            this.tratamentoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPessoas, "Tratamento", true));
            this.tratamentoComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tratamentoComboBox.FormattingEnabled = true;
            this.tratamentoComboBox.Items.AddRange(new object[] {
            "a",
            "o",
            "x"});
            this.tratamentoComboBox.Location = new System.Drawing.Point(108, 14);
            this.tratamentoComboBox.Name = "tratamentoComboBox";
            this.tratamentoComboBox.Size = new System.Drawing.Size(39, 36);
            this.tratamentoComboBox.TabIndex = 11;
            // 
            // checkBoxRecibo
            // 
            this.checkBoxRecibo.AutoSize = true;
            this.checkBoxRecibo.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bsPessoas, "Recibo", true));
            this.checkBoxRecibo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRecibo.Location = new System.Drawing.Point(653, 218);
            this.checkBoxRecibo.Name = "checkBoxRecibo";
            this.checkBoxRecibo.Size = new System.Drawing.Size(149, 32);
            this.checkBoxRecibo.TabIndex = 10;
            this.checkBoxRecibo.Text = "Emitir Recibo";
            this.checkBoxRecibo.UseVisualStyleBackColor = true;
            // 
            // checkBoxAtualizar
            // 
            this.checkBoxAtualizar.AutoSize = true;
            this.checkBoxAtualizar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAtualizar.Location = new System.Drawing.Point(653, 76);
            this.checkBoxAtualizar.Name = "checkBoxAtualizar";
            this.checkBoxAtualizar.Size = new System.Drawing.Size(111, 32);
            this.checkBoxAtualizar.TabIndex = 9;
            this.checkBoxAtualizar.Text = "Atualizar";
            this.checkBoxAtualizar.UseVisualStyleBackColor = true;
            // 
            // checkBoxAtivo
            // 
            this.checkBoxAtivo.AutoSize = true;
            this.checkBoxAtivo.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bsPessoas, "Ativo", true));
            this.checkBoxAtivo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAtivo.Location = new System.Drawing.Point(653, 48);
            this.checkBoxAtivo.Name = "checkBoxAtivo";
            this.checkBoxAtivo.Size = new System.Drawing.Size(81, 32);
            this.checkBoxAtivo.TabIndex = 8;
            this.checkBoxAtivo.Text = "Ativo";
            this.checkBoxAtivo.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.dgvEnderecos);
            this.tabPage2.Controls.Add(this.dgvTelefones);
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(904, 256);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Endereços e Telefones";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.labelPendenteValor);
            this.tabPage3.Controls.Add(labelPendente);
            this.tabPage3.Controls.Add(this.dgvPagamentos);
            this.tabPage3.Location = new System.Drawing.Point(4, 37);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(904, 256);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pagamentos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // labelPendenteValor
            // 
            this.labelPendenteValor.BackColor = System.Drawing.Color.Black;
            this.labelPendenteValor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPessoas, "PendenteAsString", true));
            this.labelPendenteValor.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPendenteValor.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPendenteValor.Location = new System.Drawing.Point(684, 115);
            this.labelPendenteValor.Name = "labelPendenteValor";
            this.labelPendenteValor.Size = new System.Drawing.Size(186, 66);
            this.labelPendenteValor.TabIndex = 42;
            this.labelPendenteValor.Text = "X";
            this.labelPendenteValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvPagamentos
            // 
            this.dgvPagamentos.AllowUserToAddRows = false;
            this.dgvPagamentos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPagamentos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPagamentos.AutoGenerateColumns = false;
            this.dgvPagamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReciboAnoNumero,
            this.Data,
            this.Valor,
            this.Observacoes,
            this.valorDescricaoDataGridViewTextBoxColumn,
            this.valorExtensoDataGridViewTextBoxColumn,
            this.cobrancaDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn1,
            this.tratamentoDataGridViewTextBoxColumn,
            this.sobrenomeDataGridViewTextBoxColumn,
            this.nomeCompletoDataGridViewTextBoxColumn,
            this.eMailDataGridViewTextBoxColumn,
            this.tomadasDataGridViewTextBoxColumn,
            this.tomadasExtensoDataGridViewTextBoxColumn,
            this.enderecoArarasDataGridViewTextBoxColumn,
            this.gerarReciboDataGridViewCheckBoxColumn,
            this.depositoIdentificadoDataGridViewTextBoxColumn,
            this.reciboNumeroDataGridViewTextBoxColumn,
            this.reciboNumeroAnoDataGridViewTextBoxColumn,
            this.reciboAnoNumeroDataGridViewTextBoxColumn,
            this.reciboEmissaoDataGridViewTextBoxColumn,
            this.reciboVencimentoDataGridViewTextBoxColumn,
            this.reciboCotaValorDataGridViewTextBoxColumn,
            this.reciboMesesDataGridViewTextBoxColumn,
            this.reciboMesesExtensoDataGridViewTextBoxColumn,
            this.reciboDescricaoDataGridViewTextBoxColumn,
            this.reciboObservacoesDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn1,
            this.reciboIDDataGridViewTextBoxColumn,
            this.pessoaIDDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.observacoesDataGridViewTextBoxColumn,
            this.pessoaDataGridViewTextBoxColumn,
            this.reciboDataGridViewTextBoxColumn});
            this.dgvPagamentos.DataSource = this.bsCotas;
            this.dgvPagamentos.Location = new System.Drawing.Point(10, 17);
            this.dgvPagamentos.Name = "dgvPagamentos";
            this.dgvPagamentos.ReadOnly = true;
            this.dgvPagamentos.RowHeadersVisible = false;
            this.dgvPagamentos.RowTemplate.Height = 26;
            this.dgvPagamentos.Size = new System.Drawing.Size(565, 209);
            this.dgvPagamentos.TabIndex = 0;
            // 
            // ReciboAnoNumero
            // 
            this.ReciboAnoNumero.DataPropertyName = "ReciboAnoNumero";
            this.ReciboAnoNumero.HeaderText = "Recibo";
            this.ReciboAnoNumero.Name = "ReciboAnoNumero";
            this.ReciboAnoNumero.ReadOnly = true;
            this.ReciboAnoNumero.Width = 80;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.Valor.DefaultCellStyle = dataGridViewCellStyle4;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Observacoes
            // 
            this.Observacoes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Observacoes.DataPropertyName = "Observacoes";
            this.Observacoes.HeaderText = "Observações";
            this.Observacoes.Name = "Observacoes";
            this.Observacoes.ReadOnly = true;
            // 
            // bsCotas
            // 
            this.bsCotas.DataMember = "Cotas";
            this.bsCotas.DataSource = this.bsPessoas;
            // 
            // enderecoArarasLabel1
            // 
            this.enderecoArarasLabel1.BackColor = System.Drawing.Color.Black;
            this.enderecoArarasLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPessoas, "EnderecoAraras", true));
            this.enderecoArarasLabel1.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enderecoArarasLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.enderecoArarasLabel1.Location = new System.Drawing.Point(227, 106);
            this.enderecoArarasLabel1.Name = "enderecoArarasLabel1";
            this.enderecoArarasLabel1.Size = new System.Drawing.Size(771, 41);
            this.enderecoArarasLabel1.TabIndex = 40;
            this.enderecoArarasLabel1.Text = "Endereço Araras";
            this.enderecoArarasLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nomeCompletoLabel1
            // 
            this.nomeCompletoLabel1.BackColor = System.Drawing.Color.Black;
            this.nomeCompletoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPessoas, "NomeCompleto", true));
            this.nomeCompletoLabel1.Font = new System.Drawing.Font("Segoe UI Light", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeCompletoLabel1.ForeColor = System.Drawing.Color.White;
            this.nomeCompletoLabel1.Location = new System.Drawing.Point(227, 40);
            this.nomeCompletoLabel1.Name = "nomeCompletoLabel1";
            this.nomeCompletoLabel1.Size = new System.Drawing.Size(771, 66);
            this.nomeCompletoLabel1.TabIndex = 39;
            this.nomeCompletoLabel1.Text = "Nome Completo";
            this.nomeCompletoLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // iDLabel
            // 
            this.iDLabel.BackColor = System.Drawing.Color.Black;
            this.iDLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPessoas, "ID", true));
            this.iDLabel.Font = new System.Drawing.Font("Segoe UI Light", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.iDLabel.Location = new System.Drawing.Point(1004, 40);
            this.iDLabel.Name = "iDLabel";
            this.iDLabel.Size = new System.Drawing.Size(131, 107);
            this.iDLabel.TabIndex = 38;
            this.iDLabel.Text = "15";
            this.iDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvPessoas
            // 
            this.dgvPessoas.AllowUserToAddRows = false;
            this.dgvPessoas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPessoas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPessoas.AutoGenerateColumns = false;
            this.dgvPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPessoas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn});
            this.dgvPessoas.DataSource = this.bsPessoas;
            this.dgvPessoas.Location = new System.Drawing.Point(13, 40);
            this.dgvPessoas.Name = "dgvPessoas";
            this.dgvPessoas.ReadOnly = true;
            this.dgvPessoas.RowHeadersVisible = false;
            this.dgvPessoas.RowTemplate.Height = 26;
            this.dgvPessoas.Size = new System.Drawing.Size(204, 418);
            this.dgvPessoas.TabIndex = 41;
            this.dgvPessoas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPessoas_CellFormatting);
            this.dgvPessoas.SelectionChanged += new System.EventHandler(this.dgvPessoas_SelectionChanged);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = null;
            this.iDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 56;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSave,
            this.toolStripButtonUndo});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(1144, 30);
            this.toolStripMenu.TabIndex = 42;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.Enabled = false;
            this.toolStripButtonSave.Image = global::AguaAraras.Properties.Resources.Document_save_icon;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(79, 27);
            this.toolStripButtonSave.Text = "Salvar";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripButtonUndo
            // 
            this.toolStripButtonUndo.Enabled = false;
            this.toolStripButtonUndo.Image = global::AguaAraras.Properties.Resources.Edit_delete_icon;
            this.toolStripButtonUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUndo.Name = "toolStripButtonUndo";
            this.toolStripButtonUndo.Size = new System.Drawing.Size(99, 27);
            this.toolStripButtonUndo.Text = "Desfazer";
            this.toolStripButtonUndo.Click += new System.EventHandler(this.toolStripButtonUndo_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // valorDescricaoDataGridViewTextBoxColumn
            // 
            this.valorDescricaoDataGridViewTextBoxColumn.DataPropertyName = "ValorDescricao";
            this.valorDescricaoDataGridViewTextBoxColumn.HeaderText = "ValorDescricao";
            this.valorDescricaoDataGridViewTextBoxColumn.Name = "valorDescricaoDataGridViewTextBoxColumn";
            this.valorDescricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorExtensoDataGridViewTextBoxColumn
            // 
            this.valorExtensoDataGridViewTextBoxColumn.DataPropertyName = "ValorExtenso";
            this.valorExtensoDataGridViewTextBoxColumn.HeaderText = "ValorExtenso";
            this.valorExtensoDataGridViewTextBoxColumn.Name = "valorExtensoDataGridViewTextBoxColumn";
            this.valorExtensoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cobrancaDataGridViewTextBoxColumn
            // 
            this.cobrancaDataGridViewTextBoxColumn.DataPropertyName = "Cobranca";
            this.cobrancaDataGridViewTextBoxColumn.HeaderText = "Cobranca";
            this.cobrancaDataGridViewTextBoxColumn.Name = "cobrancaDataGridViewTextBoxColumn";
            this.cobrancaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn1
            // 
            this.nomeDataGridViewTextBoxColumn1.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn1.Name = "nomeDataGridViewTextBoxColumn1";
            this.nomeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tratamentoDataGridViewTextBoxColumn
            // 
            this.tratamentoDataGridViewTextBoxColumn.DataPropertyName = "Tratamento";
            this.tratamentoDataGridViewTextBoxColumn.HeaderText = "Tratamento";
            this.tratamentoDataGridViewTextBoxColumn.Name = "tratamentoDataGridViewTextBoxColumn";
            this.tratamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sobrenomeDataGridViewTextBoxColumn
            // 
            this.sobrenomeDataGridViewTextBoxColumn.DataPropertyName = "Sobrenome";
            this.sobrenomeDataGridViewTextBoxColumn.HeaderText = "Sobrenome";
            this.sobrenomeDataGridViewTextBoxColumn.Name = "sobrenomeDataGridViewTextBoxColumn";
            this.sobrenomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeCompletoDataGridViewTextBoxColumn
            // 
            this.nomeCompletoDataGridViewTextBoxColumn.DataPropertyName = "NomeCompleto";
            this.nomeCompletoDataGridViewTextBoxColumn.HeaderText = "NomeCompleto";
            this.nomeCompletoDataGridViewTextBoxColumn.Name = "nomeCompletoDataGridViewTextBoxColumn";
            this.nomeCompletoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eMailDataGridViewTextBoxColumn
            // 
            this.eMailDataGridViewTextBoxColumn.DataPropertyName = "EMail";
            this.eMailDataGridViewTextBoxColumn.HeaderText = "EMail";
            this.eMailDataGridViewTextBoxColumn.Name = "eMailDataGridViewTextBoxColumn";
            this.eMailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tomadasDataGridViewTextBoxColumn
            // 
            this.tomadasDataGridViewTextBoxColumn.DataPropertyName = "Tomadas";
            this.tomadasDataGridViewTextBoxColumn.HeaderText = "Tomadas";
            this.tomadasDataGridViewTextBoxColumn.Name = "tomadasDataGridViewTextBoxColumn";
            this.tomadasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tomadasExtensoDataGridViewTextBoxColumn
            // 
            this.tomadasExtensoDataGridViewTextBoxColumn.DataPropertyName = "TomadasExtenso";
            this.tomadasExtensoDataGridViewTextBoxColumn.HeaderText = "TomadasExtenso";
            this.tomadasExtensoDataGridViewTextBoxColumn.Name = "tomadasExtensoDataGridViewTextBoxColumn";
            this.tomadasExtensoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enderecoArarasDataGridViewTextBoxColumn
            // 
            this.enderecoArarasDataGridViewTextBoxColumn.DataPropertyName = "EnderecoAraras";
            this.enderecoArarasDataGridViewTextBoxColumn.HeaderText = "EnderecoAraras";
            this.enderecoArarasDataGridViewTextBoxColumn.Name = "enderecoArarasDataGridViewTextBoxColumn";
            this.enderecoArarasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gerarReciboDataGridViewCheckBoxColumn
            // 
            this.gerarReciboDataGridViewCheckBoxColumn.DataPropertyName = "GerarRecibo";
            this.gerarReciboDataGridViewCheckBoxColumn.HeaderText = "GerarRecibo";
            this.gerarReciboDataGridViewCheckBoxColumn.Name = "gerarReciboDataGridViewCheckBoxColumn";
            this.gerarReciboDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // depositoIdentificadoDataGridViewTextBoxColumn
            // 
            this.depositoIdentificadoDataGridViewTextBoxColumn.DataPropertyName = "DepositoIdentificado";
            this.depositoIdentificadoDataGridViewTextBoxColumn.HeaderText = "DepositoIdentificado";
            this.depositoIdentificadoDataGridViewTextBoxColumn.Name = "depositoIdentificadoDataGridViewTextBoxColumn";
            this.depositoIdentificadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reciboNumeroDataGridViewTextBoxColumn
            // 
            this.reciboNumeroDataGridViewTextBoxColumn.DataPropertyName = "ReciboNumero";
            this.reciboNumeroDataGridViewTextBoxColumn.HeaderText = "ReciboNumero";
            this.reciboNumeroDataGridViewTextBoxColumn.Name = "reciboNumeroDataGridViewTextBoxColumn";
            this.reciboNumeroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reciboNumeroAnoDataGridViewTextBoxColumn
            // 
            this.reciboNumeroAnoDataGridViewTextBoxColumn.DataPropertyName = "ReciboNumeroAno";
            this.reciboNumeroAnoDataGridViewTextBoxColumn.HeaderText = "ReciboNumeroAno";
            this.reciboNumeroAnoDataGridViewTextBoxColumn.Name = "reciboNumeroAnoDataGridViewTextBoxColumn";
            this.reciboNumeroAnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reciboAnoNumeroDataGridViewTextBoxColumn
            // 
            this.reciboAnoNumeroDataGridViewTextBoxColumn.DataPropertyName = "ReciboAnoNumero";
            this.reciboAnoNumeroDataGridViewTextBoxColumn.HeaderText = "ReciboAnoNumero";
            this.reciboAnoNumeroDataGridViewTextBoxColumn.Name = "reciboAnoNumeroDataGridViewTextBoxColumn";
            this.reciboAnoNumeroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reciboEmissaoDataGridViewTextBoxColumn
            // 
            this.reciboEmissaoDataGridViewTextBoxColumn.DataPropertyName = "ReciboEmissao";
            this.reciboEmissaoDataGridViewTextBoxColumn.HeaderText = "ReciboEmissao";
            this.reciboEmissaoDataGridViewTextBoxColumn.Name = "reciboEmissaoDataGridViewTextBoxColumn";
            this.reciboEmissaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reciboVencimentoDataGridViewTextBoxColumn
            // 
            this.reciboVencimentoDataGridViewTextBoxColumn.DataPropertyName = "ReciboVencimento";
            this.reciboVencimentoDataGridViewTextBoxColumn.HeaderText = "ReciboVencimento";
            this.reciboVencimentoDataGridViewTextBoxColumn.Name = "reciboVencimentoDataGridViewTextBoxColumn";
            this.reciboVencimentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reciboCotaValorDataGridViewTextBoxColumn
            // 
            this.reciboCotaValorDataGridViewTextBoxColumn.DataPropertyName = "ReciboCotaValor";
            this.reciboCotaValorDataGridViewTextBoxColumn.HeaderText = "ReciboCotaValor";
            this.reciboCotaValorDataGridViewTextBoxColumn.Name = "reciboCotaValorDataGridViewTextBoxColumn";
            this.reciboCotaValorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reciboMesesDataGridViewTextBoxColumn
            // 
            this.reciboMesesDataGridViewTextBoxColumn.DataPropertyName = "ReciboMeses";
            this.reciboMesesDataGridViewTextBoxColumn.HeaderText = "ReciboMeses";
            this.reciboMesesDataGridViewTextBoxColumn.Name = "reciboMesesDataGridViewTextBoxColumn";
            this.reciboMesesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reciboMesesExtensoDataGridViewTextBoxColumn
            // 
            this.reciboMesesExtensoDataGridViewTextBoxColumn.DataPropertyName = "ReciboMesesExtenso";
            this.reciboMesesExtensoDataGridViewTextBoxColumn.HeaderText = "ReciboMesesExtenso";
            this.reciboMesesExtensoDataGridViewTextBoxColumn.Name = "reciboMesesExtensoDataGridViewTextBoxColumn";
            this.reciboMesesExtensoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reciboDescricaoDataGridViewTextBoxColumn
            // 
            this.reciboDescricaoDataGridViewTextBoxColumn.DataPropertyName = "ReciboDescricao";
            this.reciboDescricaoDataGridViewTextBoxColumn.HeaderText = "ReciboDescricao";
            this.reciboDescricaoDataGridViewTextBoxColumn.Name = "reciboDescricaoDataGridViewTextBoxColumn";
            this.reciboDescricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reciboObservacoesDataGridViewTextBoxColumn
            // 
            this.reciboObservacoesDataGridViewTextBoxColumn.DataPropertyName = "ReciboObservacoes";
            this.reciboObservacoesDataGridViewTextBoxColumn.HeaderText = "ReciboObservacoes";
            this.reciboObservacoesDataGridViewTextBoxColumn.Name = "reciboObservacoesDataGridViewTextBoxColumn";
            this.reciboObservacoesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // reciboIDDataGridViewTextBoxColumn
            // 
            this.reciboIDDataGridViewTextBoxColumn.DataPropertyName = "ReciboID";
            this.reciboIDDataGridViewTextBoxColumn.HeaderText = "ReciboID";
            this.reciboIDDataGridViewTextBoxColumn.Name = "reciboIDDataGridViewTextBoxColumn";
            this.reciboIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pessoaIDDataGridViewTextBoxColumn
            // 
            this.pessoaIDDataGridViewTextBoxColumn.DataPropertyName = "PessoaID";
            this.pessoaIDDataGridViewTextBoxColumn.HeaderText = "PessoaID";
            this.pessoaIDDataGridViewTextBoxColumn.Name = "pessoaIDDataGridViewTextBoxColumn";
            this.pessoaIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // observacoesDataGridViewTextBoxColumn
            // 
            this.observacoesDataGridViewTextBoxColumn.DataPropertyName = "Observacoes";
            this.observacoesDataGridViewTextBoxColumn.HeaderText = "Observacoes";
            this.observacoesDataGridViewTextBoxColumn.Name = "observacoesDataGridViewTextBoxColumn";
            this.observacoesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pessoaDataGridViewTextBoxColumn
            // 
            this.pessoaDataGridViewTextBoxColumn.DataPropertyName = "Pessoa";
            this.pessoaDataGridViewTextBoxColumn.HeaderText = "Pessoa";
            this.pessoaDataGridViewTextBoxColumn.Name = "pessoaDataGridViewTextBoxColumn";
            this.pessoaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reciboDataGridViewTextBoxColumn
            // 
            this.reciboDataGridViewTextBoxColumn.DataPropertyName = "Recibo";
            this.reciboDataGridViewTextBoxColumn.HeaderText = "Recibo";
            this.reciboDataGridViewTextBoxColumn.Name = "reciboDataGridViewTextBoxColumn";
            this.reciboDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1144, 472);
            this.Controls.Add(this.toolStripMenu);
            this.Controls.Add(this.dgvPessoas);
            this.Controls.Add(this.enderecoArarasLabel1);
            this.Controls.Add(this.nomeCompletoLabel1);
            this.Controls.Add(this.iDLabel);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPessoas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pessoas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPessoas_FormClosing);
            this.Load += new System.EventHandler(this.frmPessoas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsPessoas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnderecos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEnderecos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTelefones)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoas)).EndInit();
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxSobrenome;
        private System.Windows.Forms.DataGridView dgvEnderecos;
        private System.Windows.Forms.DataGridView dgvTelefones;
        private System.Windows.Forms.TextBox textBoxEMail;
        private System.Windows.Forms.TextBox textBoxObservacoes;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkBoxRecibo;
        private System.Windows.Forms.CheckBox checkBoxAtualizar;
        private System.Windows.Forms.CheckBox checkBoxAtivo;
        private System.Windows.Forms.Label enderecoArarasLabel1;
        private System.Windows.Forms.Label nomeCompletoLabel1;
        private System.Windows.Forms.Label iDLabel;
        private System.Windows.Forms.ComboBox tratamentoComboBox;
        private System.Windows.Forms.ComboBox cobrancaComboBox;
        private System.Windows.Forms.Label labelTomadasNumero;
        private System.Windows.Forms.DataGridView dgvPessoas;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonUndo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvPagamentos;
        private System.Windows.Forms.Label labelPendenteValor;
        private System.Windows.Forms.BindingSource bsPessoas;
        private System.Windows.Forms.BindingSource bsCotas;
        private System.Windows.Forms.BindingSource bsEnderecos;
        private System.Windows.Forms.BindingSource bsTelefones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Logradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEPformattedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Residencia;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Correspondencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReciboAnoNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDescricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorExtensoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cobrancaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tratamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobrenomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCompletoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tomadasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tomadasExtensoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoArarasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gerarReciboDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depositoIdentificadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reciboNumeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reciboNumeroAnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reciboAnoNumeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reciboEmissaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reciboVencimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reciboCotaValorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reciboMesesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reciboMesesExtensoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reciboDescricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reciboObservacoesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn reciboIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pessoaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacoesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pessoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reciboDataGridViewTextBoxColumn;
    }
}