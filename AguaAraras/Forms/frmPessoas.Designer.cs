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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.entityDataSourcePessoas = new EFWinforms.EntityDataSource(this.components);
            this.textBoxSobrenome = new System.Windows.Forms.TextBox();
            this.dgvEnderecos = new System.Windows.Forms.DataGridView();
            this.colLogradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResidencia = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colCorrespondencia = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvTelefones = new System.Windows.Forms.DataGridView();
            this.colDDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewComboBoxColumn();
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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacoesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lablTomadas = new System.Windows.Forms.Label();
            labelObservacoes = new System.Windows.Forms.Label();
            labelNome = new System.Windows.Forms.Label();
            labelCobranca = new System.Windows.Forms.Label();
            labelEMail = new System.Windows.Forms.Label();
            labelPendente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnderecos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefones)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamentos)).BeginInit();
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
            labelObservacoes.Size = new System.Drawing.Size(102, 21);
            labelObservacoes.TabIndex = 43;
            labelObservacoes.Text = "Observações:";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelNome.Location = new System.Drawing.Point(7, 18);
            labelNome.Name = "labelNome";
            labelNome.Size = new System.Drawing.Size(56, 21);
            labelNome.TabIndex = 42;
            labelNome.Text = "Nome:";
            // 
            // labelCobranca
            // 
            labelCobranca.AutoSize = true;
            labelCobranca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelCobranca.Location = new System.Drawing.Point(649, 159);
            labelCobranca.Name = "labelCobranca";
            labelCobranca.Size = new System.Drawing.Size(79, 21);
            labelCobranca.TabIndex = 44;
            labelCobranca.Text = "Cobrança:";
            // 
            // labelEMail
            // 
            labelEMail.AutoSize = true;
            labelEMail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelEMail.Location = new System.Drawing.Point(6, 52);
            labelEMail.Name = "labelEMail";
            labelEMail.Size = new System.Drawing.Size(57, 21);
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
            this.textBoxNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.entityDataSourcePessoas, "Pessoas.Nome", true));
            this.textBoxNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.Location = new System.Drawing.Point(153, 14);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(202, 29);
            this.textBoxNome.TabIndex = 1;
            // 
            // entityDataSourcePessoas
            // 
            this.entityDataSourcePessoas.DbContextType = typeof(DataLayer.AguaArarasEntities);
            this.entityDataSourcePessoas.DataError += new System.EventHandler<EFWinforms.DataErrorEventArgs>(this.entityDataSourcePessoas_DataError);
            // 
            // textBoxSobrenome
            // 
            this.textBoxSobrenome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.entityDataSourcePessoas, "Pessoas.Sobrenome", true));
            this.textBoxSobrenome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSobrenome.Location = new System.Drawing.Point(361, 14);
            this.textBoxSobrenome.Name = "textBoxSobrenome";
            this.textBoxSobrenome.Size = new System.Drawing.Size(252, 29);
            this.textBoxSobrenome.TabIndex = 2;
            // 
            // dgvEnderecos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvEnderecos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEnderecos.AutoGenerateColumns = false;
            this.dgvEnderecos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnderecos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLogradouro,
            this.colBairro,
            this.colCidade,
            this.colEstado,
            this.colCEP,
            this.colResidencia,
            this.colCorrespondencia});
            this.dgvEnderecos.DataMember = "Pessoas.Enderecos";
            this.dgvEnderecos.DataSource = this.entityDataSourcePessoas;
            this.dgvEnderecos.Location = new System.Drawing.Point(13, 6);
            this.dgvEnderecos.Name = "dgvEnderecos";
            this.dgvEnderecos.RowHeadersWidth = 25;
            this.dgvEnderecos.RowTemplate.Height = 26;
            this.dgvEnderecos.Size = new System.Drawing.Size(885, 116);
            this.dgvEnderecos.TabIndex = 3;
            this.dgvEnderecos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEnderecos_CellEndEdit);
            this.dgvEnderecos.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvEnderecos_CellValidating);
            this.dgvEnderecos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvEnderecos_KeyDown);
            // 
            // colLogradouro
            // 
            this.colLogradouro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLogradouro.DataPropertyName = "Logradouro";
            this.colLogradouro.HeaderText = "Logradouro";
            this.colLogradouro.Name = "colLogradouro";
            // 
            // colBairro
            // 
            this.colBairro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colBairro.DataPropertyName = "Bairro";
            this.colBairro.HeaderText = "Bairro";
            this.colBairro.Name = "colBairro";
            this.colBairro.Width = 77;
            // 
            // colCidade
            // 
            this.colCidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colCidade.DataPropertyName = "Cidade";
            this.colCidade.HeaderText = "Cidade";
            this.colCidade.Name = "colCidade";
            this.colCidade.Width = 83;
            // 
            // colEstado
            // 
            this.colEstado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.colEstado.DataPropertyName = "Estado";
            this.colEstado.HeaderText = "UF";
            this.colEstado.Name = "colEstado";
            this.colEstado.Width = 5;
            // 
            // colCEP
            // 
            this.colCEP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.colCEP.DataPropertyName = "CEPformatted";
            this.colCEP.HeaderText = "CEP";
            this.colCEP.Name = "colCEP";
            this.colCEP.Width = 5;
            // 
            // colResidencia
            // 
            this.colResidencia.DataPropertyName = "Residencia";
            this.colResidencia.HeaderText = "Res";
            this.colResidencia.Name = "colResidencia";
            this.colResidencia.ToolTipText = "Endereço residencial?";
            this.colResidencia.Width = 30;
            // 
            // colCorrespondencia
            // 
            this.colCorrespondencia.DataPropertyName = "Correspondencia";
            this.colCorrespondencia.HeaderText = "Cor";
            this.colCorrespondencia.Name = "colCorrespondencia";
            this.colCorrespondencia.ToolTipText = "Endereço correspondência?";
            this.colCorrespondencia.Width = 30;
            // 
            // dgvTelefones
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvTelefones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTelefones.AutoGenerateColumns = false;
            this.dgvTelefones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelefones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDDD,
            this.colNumero,
            this.colTipo});
            this.dgvTelefones.DataMember = "Pessoas.Telefones";
            this.dgvTelefones.DataSource = this.entityDataSourcePessoas;
            this.dgvTelefones.Location = new System.Drawing.Point(13, 128);
            this.dgvTelefones.Name = "dgvTelefones";
            this.dgvTelefones.RowHeadersWidth = 25;
            this.dgvTelefones.RowTemplate.Height = 26;
            this.dgvTelefones.Size = new System.Drawing.Size(304, 118);
            this.dgvTelefones.TabIndex = 4;
            this.dgvTelefones.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTelefones_CellEndEdit);
            this.dgvTelefones.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvTelefones_CellValidating);
            this.dgvTelefones.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvTelefones_KeyDown);
            // 
            // colDDD
            // 
            this.colDDD.DataPropertyName = "DDD";
            this.colDDD.HeaderText = "DDD";
            this.colDDD.Name = "colDDD";
            this.colDDD.Width = 45;
            // 
            // colNumero
            // 
            this.colNumero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNumero.DataPropertyName = "Numero";
            this.colNumero.HeaderText = "Telefone";
            this.colNumero.Name = "colNumero";
            // 
            // colTipo
            // 
            this.colTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colTipo.DataPropertyName = "Tipo";
            this.colTipo.HeaderText = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colTipo.Width = 65;
            // 
            // textBoxEMail
            // 
            this.textBoxEMail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.entityDataSourcePessoas, "Pessoas.EMail", true));
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
            this.textBoxObservacoes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.entityDataSourcePessoas, "Pessoas.Observacoes", true));
            this.textBoxObservacoes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxObservacoes.Location = new System.Drawing.Point(108, 136);
            this.textBoxObservacoes.Multiline = true;
            this.textBoxObservacoes.Name = "textBoxObservacoes";
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
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(904, 263);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelTomadasNumero
            // 
            this.labelTomadasNumero.BackColor = System.Drawing.Color.Black;
            this.labelTomadasNumero.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.entityDataSourcePessoas, "Pessoas.Tomadas", true));
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
            this.cobrancaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.entityDataSourcePessoas, "Pessoas.Cobranca", true));
            this.cobrancaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobrancaComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobrancaComboBox.FormattingEnabled = true;
            this.cobrancaComboBox.Location = new System.Drawing.Point(653, 183);
            this.cobrancaComboBox.Name = "cobrancaComboBox";
            this.cobrancaComboBox.Size = new System.Drawing.Size(112, 29);
            this.cobrancaComboBox.TabIndex = 12;
            // 
            // tratamentoComboBox
            // 
            this.tratamentoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.entityDataSourcePessoas, "Pessoas.Tratamento", true));
            this.tratamentoComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tratamentoComboBox.FormattingEnabled = true;
            this.tratamentoComboBox.Items.AddRange(new object[] {
            "a",
            "o",
            "x"});
            this.tratamentoComboBox.Location = new System.Drawing.Point(108, 14);
            this.tratamentoComboBox.Name = "tratamentoComboBox";
            this.tratamentoComboBox.Size = new System.Drawing.Size(39, 29);
            this.tratamentoComboBox.TabIndex = 11;
            // 
            // checkBoxRecibo
            // 
            this.checkBoxRecibo.AutoSize = true;
            this.checkBoxRecibo.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.entityDataSourcePessoas, "Pessoas.Recibo", true));
            this.checkBoxRecibo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRecibo.Location = new System.Drawing.Point(653, 218);
            this.checkBoxRecibo.Name = "checkBoxRecibo";
            this.checkBoxRecibo.Size = new System.Drawing.Size(121, 25);
            this.checkBoxRecibo.TabIndex = 10;
            this.checkBoxRecibo.Text = "Emitir Recibo";
            this.checkBoxRecibo.UseVisualStyleBackColor = true;
            // 
            // checkBoxAtualizar
            // 
            this.checkBoxAtualizar.AutoSize = true;
            this.checkBoxAtualizar.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.entityDataSourcePessoas, "Pessoas.Atualizar", true));
            this.checkBoxAtualizar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAtualizar.Location = new System.Drawing.Point(653, 76);
            this.checkBoxAtualizar.Name = "checkBoxAtualizar";
            this.checkBoxAtualizar.Size = new System.Drawing.Size(90, 25);
            this.checkBoxAtualizar.TabIndex = 9;
            this.checkBoxAtualizar.Text = "Atualizar";
            this.checkBoxAtualizar.UseVisualStyleBackColor = true;
            // 
            // checkBoxAtivo
            // 
            this.checkBoxAtivo.AutoSize = true;
            this.checkBoxAtivo.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.entityDataSourcePessoas, "Pessoas.Ativo", true));
            this.checkBoxAtivo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAtivo.Location = new System.Drawing.Point(653, 48);
            this.checkBoxAtivo.Name = "checkBoxAtivo";
            this.checkBoxAtivo.Size = new System.Drawing.Size(65, 25);
            this.checkBoxAtivo.TabIndex = 8;
            this.checkBoxAtivo.Text = "Ativo";
            this.checkBoxAtivo.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvEnderecos);
            this.tabPage2.Controls.Add(this.dgvTelefones);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(904, 263);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Endereços e Telefones";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.labelPendenteValor);
            this.tabPage3.Controls.Add(labelPendente);
            this.tabPage3.Controls.Add(this.dgvPagamentos);
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(904, 263);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pagamentos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // labelPendenteValor
            // 
            this.labelPendenteValor.BackColor = System.Drawing.Color.Black;
            this.labelPendenteValor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.entityDataSourcePessoas, "Pessoas.PendenteAsString", true));
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
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPagamentos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPagamentos.AutoGenerateColumns = false;
            this.dgvPagamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dataDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.observacoesDataGridViewTextBoxColumn});
            this.dgvPagamentos.DataMember = "Pessoas.Cotas";
            this.dgvPagamentos.DataSource = this.entityDataSourcePessoas;
            this.dgvPagamentos.Location = new System.Drawing.Point(10, 17);
            this.dgvPagamentos.Name = "dgvPagamentos";
            this.dgvPagamentos.RowHeadersVisible = false;
            this.dgvPagamentos.RowTemplate.Height = 26;
            this.dgvPagamentos.Size = new System.Drawing.Size(634, 229);
            this.dgvPagamentos.TabIndex = 0;
            // 
            // enderecoArarasLabel1
            // 
            this.enderecoArarasLabel1.BackColor = System.Drawing.Color.Black;
            this.enderecoArarasLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.entityDataSourcePessoas, "Pessoas.EnderecoAraras", true));
            this.enderecoArarasLabel1.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enderecoArarasLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.enderecoArarasLabel1.Location = new System.Drawing.Point(227, 106);
            this.enderecoArarasLabel1.Name = "enderecoArarasLabel1";
            this.enderecoArarasLabel1.Size = new System.Drawing.Size(771, 41);
            this.enderecoArarasLabel1.TabIndex = 40;
            this.enderecoArarasLabel1.Text = "label1";
            this.enderecoArarasLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nomeCompletoLabel1
            // 
            this.nomeCompletoLabel1.BackColor = System.Drawing.Color.Black;
            this.nomeCompletoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.entityDataSourcePessoas, "Pessoas.NomeCompleto", true));
            this.nomeCompletoLabel1.Font = new System.Drawing.Font("Segoe UI Light", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeCompletoLabel1.ForeColor = System.Drawing.Color.White;
            this.nomeCompletoLabel1.Location = new System.Drawing.Point(227, 40);
            this.nomeCompletoLabel1.Name = "nomeCompletoLabel1";
            this.nomeCompletoLabel1.Size = new System.Drawing.Size(771, 66);
            this.nomeCompletoLabel1.TabIndex = 39;
            this.nomeCompletoLabel1.Text = "label1";
            this.nomeCompletoLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // iDLabel
            // 
            this.iDLabel.BackColor = System.Drawing.Color.Black;
            this.iDLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.entityDataSourcePessoas, "Pessoas.ID", true));
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
            this.dgvPessoas.DataMember = "Pessoas";
            this.dgvPessoas.DataSource = this.entityDataSourcePessoas;
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
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 45;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSave,
            this.toolStripButtonUndo});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(1144, 25);
            this.toolStripMenu.TabIndex = 42;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.Enabled = false;
            this.toolStripButtonSave.Image = global::AguaAraras.Properties.Resources.Document_save_icon;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(63, 22);
            this.toolStripButtonSave.Text = "Salvar";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripButtonUndo
            // 
            this.toolStripButtonUndo.Enabled = false;
            this.toolStripButtonUndo.Image = global::AguaAraras.Properties.Resources.Edit_delete_icon;
            this.toolStripButtonUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUndo.Name = "toolStripButtonUndo";
            this.toolStripButtonUndo.Size = new System.Drawing.Size(79, 22);
            this.toolStripButtonUndo.Text = "Desfazer";
            this.toolStripButtonUndo.Click += new System.EventHandler(this.toolStripButtonUndo_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ReciboAnoNumero";
            this.Column1.HeaderText = "Recibo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            this.valorDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            // 
            // observacoesDataGridViewTextBoxColumn
            // 
            this.observacoesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.observacoesDataGridViewTextBoxColumn.DataPropertyName = "Observacoes";
            this.observacoesDataGridViewTextBoxColumn.HeaderText = "Observações";
            this.observacoesDataGridViewTextBoxColumn.Name = "observacoesDataGridViewTextBoxColumn";
            // 
            // frmPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnderecos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefones)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoas)).EndInit();
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EFWinforms.EntityDataSource entityDataSourcePessoas;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colDDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumero;
        private System.Windows.Forms.DataGridViewComboBoxColumn colTipo;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonUndo;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLogradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCEP;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colResidencia;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCorrespondencia;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvPagamentos;
        private System.Windows.Forms.Label labelPendenteValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacoesDataGridViewTextBoxColumn;
    }
}