﻿namespace AguaAraras {
    partial class frmRecibos {
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
            System.Windows.Forms.Label observacoesLabel;
            System.Windows.Forms.Label emissaoLabel;
            System.Windows.Forms.Label vencimentoLabel;
            System.Windows.Forms.Label cotaLabel;
            System.Windows.Forms.Label mesesLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label numeroLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvRecibos = new System.Windows.Forms.DataGridView();
            this.anoNumeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsRecibos = new System.Windows.Forms.BindingSource(this.components);
            this.tlpRecibo = new System.Windows.Forms.TableLayoutPanel();
            this.numeroNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.observacoesTextBox = new System.Windows.Forms.TextBox();
            this.emissaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.vencimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.mesesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.extraCheckBox = new System.Windows.Forms.CheckBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelPendente = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelRecebido = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRecalc = new System.Windows.Forms.Button();
            this.cotanumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.dgvCotas = new System.Windows.Forms.DataGridView();
            this.pessoaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacoesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsCotas = new System.Windows.Forms.BindingSource(this.components);
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUndo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButtonImpressos = new System.Windows.Forms.ToolStripDropDownButton();
            this.cobrançasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cobrancasImpressasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cobrancasEMailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selecionadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recibosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fichaConferênciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonFind = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonColect = new System.Windows.Forms.ToolStripButton();
            observacoesLabel = new System.Windows.Forms.Label();
            emissaoLabel = new System.Windows.Forms.Label();
            vencimentoLabel = new System.Windows.Forms.Label();
            cotaLabel = new System.Windows.Forms.Label();
            mesesLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            numeroLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecibos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRecibos)).BeginInit();
            this.tlpRecibo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeroNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesesNumericUpDown)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cotanumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCotas)).BeginInit();
            this.tlpMain.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // observacoesLabel
            // 
            observacoesLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            observacoesLabel.AutoSize = true;
            observacoesLabel.Location = new System.Drawing.Point(3, 252);
            observacoesLabel.Name = "observacoesLabel";
            observacoesLabel.Size = new System.Drawing.Size(93, 36);
            observacoesLabel.TabIndex = 17;
            observacoesLabel.Text = "Observações:";
            // 
            // emissaoLabel
            // 
            emissaoLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            emissaoLabel.AutoSize = true;
            emissaoLabel.Location = new System.Drawing.Point(3, 184);
            emissaoLabel.Name = "emissaoLabel";
            emissaoLabel.Size = new System.Drawing.Size(86, 28);
            emissaoLabel.TabIndex = 5;
            emissaoLabel.Text = "Emissão:";
            // 
            // vencimentoLabel
            // 
            vencimentoLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            vencimentoLabel.AutoSize = true;
            vencimentoLabel.Location = new System.Drawing.Point(3, 216);
            vencimentoLabel.Name = "vencimentoLabel";
            vencimentoLabel.Size = new System.Drawing.Size(103, 36);
            vencimentoLabel.TabIndex = 21;
            vencimentoLabel.Text = "Vencimento:";
            // 
            // cotaLabel
            // 
            cotaLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            cotaLabel.AutoSize = true;
            cotaLabel.Location = new System.Drawing.Point(3, 148);
            cotaLabel.Name = "cotaLabel";
            cotaLabel.Size = new System.Drawing.Size(57, 28);
            cotaLabel.TabIndex = 1;
            cotaLabel.Text = "Cota:";
            // 
            // mesesLabel
            // 
            mesesLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            mesesLabel.AutoSize = true;
            mesesLabel.Location = new System.Drawing.Point(3, 76);
            mesesLabel.Name = "mesesLabel";
            mesesLabel.Size = new System.Drawing.Size(70, 28);
            mesesLabel.TabIndex = 23;
            mesesLabel.Text = "Meses:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(3, 112);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(100, 28);
            descricaoLabel.TabIndex = 3;
            descricaoLabel.Text = "Descrição:";
            // 
            // numeroLabel
            // 
            numeroLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            numeroLabel.AutoSize = true;
            numeroLabel.Location = new System.Drawing.Point(3, 40);
            numeroLabel.Name = "numeroLabel";
            numeroLabel.Size = new System.Drawing.Size(88, 28);
            numeroLabel.TabIndex = 24;
            numeroLabel.Text = "Número:";
            // 
            // dgvRecibos
            // 
            this.dgvRecibos.AllowUserToAddRows = false;
            this.dgvRecibos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvRecibos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRecibos.AutoGenerateColumns = false;
            this.dgvRecibos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecibos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.anoNumeroDataGridViewTextBoxColumn});
            this.dgvRecibos.DataSource = this.bsRecibos;
            this.dgvRecibos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecibos.Location = new System.Drawing.Point(3, 3);
            this.dgvRecibos.Name = "dgvRecibos";
            this.dgvRecibos.ReadOnly = true;
            this.dgvRecibos.RowHeadersVisible = false;
            this.dgvRecibos.RowTemplate.Height = 26;
            this.dgvRecibos.Size = new System.Drawing.Size(101, 497);
            this.dgvRecibos.TabIndex = 1;
            this.dgvRecibos.SelectionChanged += new System.EventHandler(this.dgvRecibos_SelectionChanged);
            // 
            // anoNumeroDataGridViewTextBoxColumn
            // 
            this.anoNumeroDataGridViewTextBoxColumn.DataPropertyName = "AnoNumero";
            this.anoNumeroDataGridViewTextBoxColumn.HeaderText = "Recibo";
            this.anoNumeroDataGridViewTextBoxColumn.Name = "anoNumeroDataGridViewTextBoxColumn";
            this.anoNumeroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsRecibos
            // 
            this.bsRecibos.DataSource = typeof(DataLayer.Recibo);
            this.bsRecibos.CurrentChanged += new System.EventHandler(this.bsRecibos_CurrentChanged);
            // 
            // tlpRecibo
            // 
            this.tlpRecibo.ColumnCount = 2;
            this.tlpRecibo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tlpRecibo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRecibo.Controls.Add(this.numeroNumericUpDown, 1, 1);
            this.tlpRecibo.Controls.Add(this.observacoesTextBox, 1, 7);
            this.tlpRecibo.Controls.Add(observacoesLabel, 0, 7);
            this.tlpRecibo.Controls.Add(this.emissaoDateTimePicker, 1, 5);
            this.tlpRecibo.Controls.Add(emissaoLabel, 0, 5);
            this.tlpRecibo.Controls.Add(this.vencimentoDateTimePicker, 1, 6);
            this.tlpRecibo.Controls.Add(vencimentoLabel, 0, 6);
            this.tlpRecibo.Controls.Add(cotaLabel, 0, 4);
            this.tlpRecibo.Controls.Add(this.mesesNumericUpDown, 1, 2);
            this.tlpRecibo.Controls.Add(mesesLabel, 0, 2);
            this.tlpRecibo.Controls.Add(this.descricaoTextBox, 1, 3);
            this.tlpRecibo.Controls.Add(descricaoLabel, 0, 3);
            this.tlpRecibo.Controls.Add(numeroLabel, 0, 1);
            this.tlpRecibo.Controls.Add(this.extraCheckBox, 1, 0);
            this.tlpRecibo.Controls.Add(this.IDLabel, 0, 0);
            this.tlpRecibo.Controls.Add(this.tableLayoutPanel3, 1, 9);
            this.tlpRecibo.Controls.Add(this.panel1, 1, 4);
            this.tlpRecibo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRecibo.Location = new System.Drawing.Point(110, 3);
            this.tlpRecibo.Name = "tlpRecibo";
            this.tlpRecibo.RowCount = 10;
            this.tlpRecibo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpRecibo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpRecibo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpRecibo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpRecibo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpRecibo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpRecibo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpRecibo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpRecibo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tlpRecibo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpRecibo.Size = new System.Drawing.Size(485, 497);
            this.tlpRecibo.TabIndex = 27;
            // 
            // numeroNumericUpDown
            // 
            this.numeroNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsRecibos, "Numero", true));
            this.numeroNumericUpDown.Location = new System.Drawing.Point(112, 39);
            this.numeroNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numeroNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeroNumericUpDown.Name = "numeroNumericUpDown";
            this.numeroNumericUpDown.Size = new System.Drawing.Size(46, 34);
            this.numeroNumericUpDown.TabIndex = 25;
            this.numeroNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numeroNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // observacoesTextBox
            // 
            this.observacoesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRecibos, "Observacoes", true));
            this.observacoesTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.observacoesTextBox.Location = new System.Drawing.Point(112, 255);
            this.observacoesTextBox.Multiline = true;
            this.observacoesTextBox.Name = "observacoesTextBox";
            this.tlpRecibo.SetRowSpan(this.observacoesTextBox, 2);
            this.observacoesTextBox.Size = new System.Drawing.Size(370, 160);
            this.observacoesTextBox.TabIndex = 18;
            // 
            // emissaoDateTimePicker
            // 
            this.emissaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsRecibos, "Emissao", true));
            this.emissaoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.emissaoDateTimePicker.Location = new System.Drawing.Point(112, 183);
            this.emissaoDateTimePicker.Name = "emissaoDateTimePicker";
            this.emissaoDateTimePicker.Size = new System.Drawing.Size(121, 34);
            this.emissaoDateTimePicker.TabIndex = 6;
            // 
            // vencimentoDateTimePicker
            // 
            this.vencimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsRecibos, "Vencimento", true));
            this.vencimentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.vencimentoDateTimePicker.Location = new System.Drawing.Point(112, 219);
            this.vencimentoDateTimePicker.Name = "vencimentoDateTimePicker";
            this.vencimentoDateTimePicker.Size = new System.Drawing.Size(121, 34);
            this.vencimentoDateTimePicker.TabIndex = 22;
            // 
            // mesesNumericUpDown
            // 
            this.mesesNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsRecibos, "Meses", true));
            this.mesesNumericUpDown.Location = new System.Drawing.Point(112, 75);
            this.mesesNumericUpDown.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.mesesNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mesesNumericUpDown.Name = "mesesNumericUpDown";
            this.mesesNumericUpDown.Size = new System.Drawing.Size(46, 34);
            this.mesesNumericUpDown.TabIndex = 24;
            this.mesesNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mesesNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRecibos, "Descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(112, 111);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(370, 34);
            this.descricaoTextBox.TabIndex = 4;
            // 
            // extraCheckBox
            // 
            this.extraCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bsRecibos, "Extra", true));
            this.extraCheckBox.Location = new System.Drawing.Point(112, 3);
            this.extraCheckBox.Name = "extraCheckBox";
            this.extraCheckBox.Size = new System.Drawing.Size(64, 24);
            this.extraCheckBox.TabIndex = 8;
            this.extraCheckBox.Text = "Extra";
            this.extraCheckBox.UseVisualStyleBackColor = true;
            // 
            // IDLabel
            // 
            this.IDLabel.BackColor = System.Drawing.Color.Black;
            this.IDLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRecibos, "ID", true));
            this.IDLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IDLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.IDLabel.Location = new System.Drawing.Point(3, 0);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(103, 36);
            this.IDLabel.TabIndex = 10;
            this.IDLabel.Text = "ID";
            this.IDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel3.Controls.Add(this.labelPendente, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.label5, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.labelRecebido, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.label3, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelTotal, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(112, 421);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(370, 73);
            this.tableLayoutPanel3.TabIndex = 26;
            // 
            // labelPendente
            // 
            this.labelPendente.AutoSize = true;
            this.labelPendente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRecibos, "PendenteAsString", true));
            this.labelPendente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPendente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPendente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelPendente.Location = new System.Drawing.Point(188, 48);
            this.labelPendente.Name = "labelPendente";
            this.labelPendente.Size = new System.Drawing.Size(89, 25);
            this.labelPendente.TabIndex = 5;
            this.labelPendente.Text = "label6";
            this.labelPendente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(93, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pendente:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRecebido
            // 
            this.labelRecebido.AutoSize = true;
            this.labelRecebido.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRecibos, "RecebidoAsString", true));
            this.labelRecebido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRecebido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecebido.ForeColor = System.Drawing.Color.Green;
            this.labelRecebido.Location = new System.Drawing.Point(188, 24);
            this.labelRecebido.Name = "labelRecebido";
            this.labelRecebido.Size = new System.Drawing.Size(89, 24);
            this.labelRecebido.TabIndex = 3;
            this.labelRecebido.Text = "label4";
            this.labelRecebido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(93, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Recebido:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRecibos, "TotalAsString", true));
            this.labelTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.Blue;
            this.labelTotal.Location = new System.Drawing.Point(188, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(89, 24);
            this.labelTotal.TabIndex = 1;
            this.labelTotal.Text = "label2";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(93, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonRecalc);
            this.panel1.Controls.Add(this.cotanumericUpDown);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(112, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 30);
            this.panel1.TabIndex = 27;
            // 
            // buttonRecalc
            // 
            this.buttonRecalc.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonRecalc.FlatAppearance.BorderSize = 0;
            this.buttonRecalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRecalc.Font = new System.Drawing.Font("Webdings", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonRecalc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRecalc.Location = new System.Drawing.Point(81, 2);
            this.buttonRecalc.Name = "buttonRecalc";
            this.buttonRecalc.Size = new System.Drawing.Size(26, 28);
            this.buttonRecalc.TabIndex = 28;
            this.buttonRecalc.Text = "Ë";
            this.buttonRecalc.UseVisualStyleBackColor = false;
            this.buttonRecalc.Click += new System.EventHandler(this.buttonRecalc_Click);
            // 
            // cotanumericUpDown
            // 
            this.cotanumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsRecibos, "Cota", true));
            this.cotanumericUpDown.DecimalPlaces = 2;
            this.cotanumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.cotanumericUpDown.Location = new System.Drawing.Point(0, 3);
            this.cotanumericUpDown.Name = "cotanumericUpDown";
            this.cotanumericUpDown.Size = new System.Drawing.Size(78, 34);
            this.cotanumericUpDown.TabIndex = 23;
            this.cotanumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgvCotas
            // 
            this.dgvCotas.AllowUserToAddRows = false;
            this.dgvCotas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvCotas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCotas.AutoGenerateColumns = false;
            this.dgvCotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pessoaIDDataGridViewTextBoxColumn,
            this.Nome,
            this.dataDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.observacoesDataGridViewTextBoxColumn});
            this.dgvCotas.DataSource = this.bsCotas;
            this.dgvCotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCotas.Location = new System.Drawing.Point(601, 3);
            this.dgvCotas.Name = "dgvCotas";
            this.dgvCotas.RowHeadersWidth = 25;
            this.dgvCotas.RowTemplate.Height = 28;
            this.dgvCotas.Size = new System.Drawing.Size(651, 497);
            this.dgvCotas.TabIndex = 28;
            this.dgvCotas.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCotas_CellEndEdit);
            this.dgvCotas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCotas_CellFormatting);
            this.dgvCotas.SelectionChanged += new System.EventHandler(this.dgvCotas_SelectionChanged);
            // 
            // pessoaIDDataGridViewTextBoxColumn
            // 
            this.pessoaIDDataGridViewTextBoxColumn.DataPropertyName = "PessoaID";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.pessoaIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.pessoaIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.pessoaIDDataGridViewTextBoxColumn.Name = "pessoaIDDataGridViewTextBoxColumn";
            this.pessoaIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pessoaIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 95;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.Width = 82;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.valorDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.Width = 86;
            // 
            // observacoesDataGridViewTextBoxColumn
            // 
            this.observacoesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.observacoesDataGridViewTextBoxColumn.DataPropertyName = "Observacoes";
            this.observacoesDataGridViewTextBoxColumn.HeaderText = "Observações";
            this.observacoesDataGridViewTextBoxColumn.Name = "observacoesDataGridViewTextBoxColumn";
            // 
            // bsCotas
            // 
            this.bsCotas.DataMember = "Cotas";
            this.bsCotas.DataSource = this.bsRecibos;
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 491F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 657F));
            this.tlpMain.Controls.Add(this.dgvRecibos, 0, 0);
            this.tlpMain.Controls.Add(this.dgvCotas, 2, 0);
            this.tlpMain.Controls.Add(this.tlpRecibo, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(1255, 503);
            this.tlpMain.TabIndex = 29;
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tlpMain);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1255, 503);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(1255, 534);
            this.toolStripContainer1.TabIndex = 30;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStripMenu);
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSave,
            this.toolStripButtonUndo,
            this.toolStripSeparator1,
            this.toolStripButtonNew,
            this.toolStripDropDownButtonImpressos,
            this.toolStripButtonFind,
            this.toolStripButtonColect});
            this.toolStripMenu.Location = new System.Drawing.Point(3, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(196, 31);
            this.toolStripMenu.TabIndex = 0;
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Image = global::AguaAraras.Properties.Resources.Document_save_icon;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonSave.Text = "Salvar";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripButtonUndo
            // 
            this.toolStripButtonUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUndo.Image = global::AguaAraras.Properties.Resources.Edit_delete_icon;
            this.toolStripButtonUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUndo.Name = "toolStripButtonUndo";
            this.toolStripButtonUndo.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonUndo.Text = "Desfazer";
            this.toolStripButtonUndo.Click += new System.EventHandler(this.toolStripButtonUndo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButtonNew
            // 
            this.toolStripButtonNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNew.Image = global::AguaAraras.Properties.Resources.Edit_add_icon;
            this.toolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNew.Name = "toolStripButtonNew";
            this.toolStripButtonNew.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonNew.Text = "Novo Recibo";
            this.toolStripButtonNew.Click += new System.EventHandler(this.toolStripButtonNew_Click);
            // 
            // toolStripDropDownButtonImpressos
            // 
            this.toolStripDropDownButtonImpressos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButtonImpressos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cobrançasToolStripMenuItem,
            this.recibosToolStripMenuItem,
            this.fichaConferênciaToolStripMenuItem});
            this.toolStripDropDownButtonImpressos.Image = global::AguaAraras.Properties.Resources.Multiple_documents_icon;
            this.toolStripDropDownButtonImpressos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonImpressos.Name = "toolStripDropDownButtonImpressos";
            this.toolStripDropDownButtonImpressos.Size = new System.Drawing.Size(38, 28);
            this.toolStripDropDownButtonImpressos.Text = "Impressos";
            // 
            // cobrançasToolStripMenuItem
            // 
            this.cobrançasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cobrancasImpressasToolStripMenuItem,
            this.cobrancasEMailToolStripMenuItem,
            this.selecionadasToolStripMenuItem});
            this.cobrançasToolStripMenuItem.Name = "cobrançasToolStripMenuItem";
            this.cobrançasToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.cobrançasToolStripMenuItem.Text = "Cobranças";
            // 
            // cobrancasImpressasToolStripMenuItem
            // 
            this.cobrancasImpressasToolStripMenuItem.Image = global::AguaAraras.Properties.Resources.File_pdf_icon;
            this.cobrancasImpressasToolStripMenuItem.Name = "cobrancasImpressasToolStripMenuItem";
            this.cobrancasImpressasToolStripMenuItem.Size = new System.Drawing.Size(175, 30);
            this.cobrancasImpressasToolStripMenuItem.Text = "Impressas";
            this.cobrancasImpressasToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonCobrancasImpressas_Click);
            // 
            // cobrancasEMailToolStripMenuItem
            // 
            this.cobrancasEMailToolStripMenuItem.Image = global::AguaAraras.Properties.Resources.Mail_icon;
            this.cobrancasEMailToolStripMenuItem.Name = "cobrancasEMailToolStripMenuItem";
            this.cobrancasEMailToolStripMenuItem.Size = new System.Drawing.Size(175, 30);
            this.cobrancasEMailToolStripMenuItem.Text = "E-Mail";
            this.cobrancasEMailToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonCobrancasEMail_Click);
            // 
            // selecionadasToolStripMenuItem
            // 
            this.selecionadasToolStripMenuItem.Image = global::AguaAraras.Properties.Resources.Dialog_ok_icon;
            this.selecionadasToolStripMenuItem.Name = "selecionadasToolStripMenuItem";
            this.selecionadasToolStripMenuItem.Size = new System.Drawing.Size(175, 30);
            this.selecionadasToolStripMenuItem.Text = "Selecionadas";
            this.selecionadasToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonCobrancasSelecionadas_Click);
            // 
            // recibosToolStripMenuItem
            // 
            this.recibosToolStripMenuItem.Name = "recibosToolStripMenuItem";
            this.recibosToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.recibosToolStripMenuItem.Text = "Recibos";
            this.recibosToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonRecibos_Click);
            // 
            // fichaConferênciaToolStripMenuItem
            // 
            this.fichaConferênciaToolStripMenuItem.Name = "fichaConferênciaToolStripMenuItem";
            this.fichaConferênciaToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.fichaConferênciaToolStripMenuItem.Text = "Ficha conferência";
            this.fichaConferênciaToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonFichaConferência_Click);
            // 
            // toolStripButtonFind
            // 
            this.toolStripButtonFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFind.Image = global::AguaAraras.Properties.Resources.Edit_find_icon;
            this.toolStripButtonFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFind.Name = "toolStripButtonFind";
            this.toolStripButtonFind.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonFind.Text = "Localizar Pagamentos";
            this.toolStripButtonFind.Click += new System.EventHandler(this.toolStripButtonFind_Click);
            // 
            // toolStripButtonColect
            // 
            this.toolStripButtonColect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonColect.Image = global::AguaAraras.Properties.Resources.Paper_pen_icon;
            this.toolStripButtonColect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonColect.Name = "toolStripButtonColect";
            this.toolStripButtonColect.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonColect.Text = "Criar pagamento de distribuição e coleta";
            this.toolStripButtonColect.Click += new System.EventHandler(this.toolStripButtonColect_Click);
            // 
            // frmRecibos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 534);
            this.Controls.Add(this.toolStripContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRecibos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recibos";
            this.Load += new System.EventHandler(this.frmRecibos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecibos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRecibos)).EndInit();
            this.tlpRecibo.ResumeLayout(false);
            this.tlpRecibo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeroNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesesNumericUpDown)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cotanumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCotas)).EndInit();
            this.tlpMain.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvRecibos;
        private System.Windows.Forms.TableLayoutPanel tlpRecibo;
        private System.Windows.Forms.NumericUpDown numeroNumericUpDown;
        private System.Windows.Forms.TextBox observacoesTextBox;
        private System.Windows.Forms.DateTimePicker emissaoDateTimePicker;
        private System.Windows.Forms.DateTimePicker vencimentoDateTimePicker;
        private System.Windows.Forms.NumericUpDown cotanumericUpDown;
        private System.Windows.Forms.NumericUpDown mesesNumericUpDown;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.CheckBox extraCheckBox;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labelPendente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelRecebido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCotas;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonNew;
        private System.Windows.Forms.ToolStripButton toolStripButtonFind;
        private System.Windows.Forms.ToolStripButton toolStripButtonUndo;
        private System.Windows.Forms.ToolStripButton toolStripButtonColect;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonImpressos;
        private System.Windows.Forms.ToolStripMenuItem cobrançasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cobrancasImpressasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cobrancasEMailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selecionadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recibosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fichaConferênciaToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRecalc;
        private System.Windows.Forms.BindingSource bsRecibos;
        private System.Windows.Forms.BindingSource bsCotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn anoNumeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pessoaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacoesDataGridViewTextBoxColumn;
    }
}