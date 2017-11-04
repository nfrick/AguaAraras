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
            System.Windows.Forms.Label eMailLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label observacoesLabel;
            System.Windows.Forms.Label cobrancaLabel;
            System.Windows.Forms.Label tomadasLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listBoxPessoas = new System.Windows.Forms.ListBox();
            this.atualizarCheckBox = new System.Windows.Forms.CheckBox();
            this.eMailTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.observacoesTextBox = new System.Windows.Forms.TextBox();
            this.reciboCheckBox = new System.Windows.Forms.CheckBox();
            this.sobrenomeTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorPessoas = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cobrancaComboBox = new System.Windows.Forms.ComboBox();
            this.tratamentoComboBox = new System.Windows.Forms.ComboBox();
            this.iDLabel = new System.Windows.Forms.Label();
            this.nomeCompletoLabel1 = new System.Windows.Forms.Label();
            this.enderecoArarasLabel1 = new System.Windows.Forms.Label();
            this.dgvTelefones = new System.Windows.Forms.DataGridView();
            this.dgvEnderecos = new System.Windows.Forms.DataGridView();
            this.tomadasLabel1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ativoCheckBox = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bindingSourcePessoas = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceEnderecos = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceTelefones = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnTipo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            eMailLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            observacoesLabel = new System.Windows.Forms.Label();
            cobrancaLabel = new System.Windows.Forms.Label();
            tomadasLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorPessoas)).BeginInit();
            this.bindingNavigatorPessoas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnderecos)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePessoas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEnderecos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTelefones)).BeginInit();
            this.SuspendLayout();
            // 
            // eMailLabel
            // 
            eMailLabel.AutoSize = true;
            eMailLabel.Location = new System.Drawing.Point(14, 85);
            eMailLabel.Name = "eMailLabel";
            eMailLabel.Size = new System.Drawing.Size(72, 28);
            eMailLabel.TabIndex = 5;
            eMailLabel.Text = "E-Mail:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(14, 15);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(70, 28);
            nomeLabel.TabIndex = 11;
            nomeLabel.Text = "Nome:";
            // 
            // observacoesLabel
            // 
            observacoesLabel.AutoSize = true;
            observacoesLabel.Location = new System.Drawing.Point(14, 174);
            observacoesLabel.Name = "observacoesLabel";
            observacoesLabel.Size = new System.Drawing.Size(127, 28);
            observacoesLabel.TabIndex = 15;
            observacoesLabel.Text = "Observações:";
            // 
            // cobrancaLabel
            // 
            cobrancaLabel.AutoSize = true;
            cobrancaLabel.Location = new System.Drawing.Point(14, 50);
            cobrancaLabel.Name = "cobrancaLabel";
            cobrancaLabel.Size = new System.Drawing.Size(99, 28);
            cobrancaLabel.TabIndex = 33;
            cobrancaLabel.Text = "Cobrança:";
            // 
            // tomadasLabel
            // 
            tomadasLabel.AutoSize = true;
            tomadasLabel.Location = new System.Drawing.Point(707, 15);
            tomadasLabel.Name = "tomadasLabel";
            tomadasLabel.Size = new System.Drawing.Size(93, 28);
            tomadasLabel.TabIndex = 37;
            tomadasLabel.Text = "Tomadas:";
            // 
            // listBoxPessoas
            // 
            this.listBoxPessoas.FormattingEnabled = true;
            this.listBoxPessoas.ItemHeight = 28;
            this.listBoxPessoas.Location = new System.Drawing.Point(13, 31);
            this.listBoxPessoas.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxPessoas.Name = "listBoxPessoas";
            this.listBoxPessoas.Size = new System.Drawing.Size(180, 340);
            this.listBoxPessoas.TabIndex = 0;
            this.listBoxPessoas.SelectedIndexChanged += new System.EventHandler(this.listBoxPessoas_SelectedIndexChanged);
            // 
            // atualizarCheckBox
            // 
            this.atualizarCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bindingSourcePessoas, "Atualizar", true));
            this.atualizarCheckBox.Location = new System.Drawing.Point(518, 90);
            this.atualizarCheckBox.Name = "atualizarCheckBox";
            this.atualizarCheckBox.Size = new System.Drawing.Size(104, 24);
            this.atualizarCheckBox.TabIndex = 8;
            this.atualizarCheckBox.Text = "Atualizar";
            this.atualizarCheckBox.UseVisualStyleBackColor = true;
            // 
            // eMailTextBox
            // 
            this.eMailTextBox.AcceptsReturn = true;
            this.eMailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourcePessoas, "EMail", true));
            this.eMailTextBox.Location = new System.Drawing.Point(125, 82);
            this.eMailTextBox.Multiline = true;
            this.eMailTextBox.Name = "eMailTextBox";
            this.eMailTextBox.Size = new System.Drawing.Size(371, 86);
            this.eMailTextBox.TabIndex = 6;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourcePessoas, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(171, 12);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(164, 34);
            this.nomeTextBox.TabIndex = 1;
            // 
            // observacoesTextBox
            // 
            this.observacoesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourcePessoas, "Observacoes", true));
            this.observacoesTextBox.Location = new System.Drawing.Point(125, 174);
            this.observacoesTextBox.Multiline = true;
            this.observacoesTextBox.Name = "observacoesTextBox";
            this.observacoesTextBox.Size = new System.Drawing.Size(515, 103);
            this.observacoesTextBox.TabIndex = 7;
            // 
            // reciboCheckBox
            // 
            this.reciboCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bindingSourcePessoas, "Recibo", true));
            this.reciboCheckBox.Location = new System.Drawing.Point(518, 126);
            this.reciboCheckBox.Name = "reciboCheckBox";
            this.reciboCheckBox.Size = new System.Drawing.Size(122, 24);
            this.reciboCheckBox.TabIndex = 9;
            this.reciboCheckBox.Text = "Emitir Recibo";
            this.reciboCheckBox.UseVisualStyleBackColor = true;
            // 
            // sobrenomeTextBox
            // 
            this.sobrenomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourcePessoas, "Sobrenome", true));
            this.sobrenomeTextBox.Location = new System.Drawing.Point(341, 12);
            this.sobrenomeTextBox.Name = "sobrenomeTextBox";
            this.sobrenomeTextBox.Size = new System.Drawing.Size(299, 34);
            this.sobrenomeTextBox.TabIndex = 2;
            // 
            // bindingNavigatorPessoas
            // 
            this.bindingNavigatorPessoas.AddNewItem = null;
            this.bindingNavigatorPessoas.BindingSource = this.bindingSourcePessoas;
            this.bindingNavigatorPessoas.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorPessoas.DeleteItem = null;
            this.bindingNavigatorPessoas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigatorPessoas.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigatorPessoas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripButtonSave,
            this.toolStripSeparator1});
            this.bindingNavigatorPessoas.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorPessoas.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorPessoas.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorPessoas.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorPessoas.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorPessoas.Name = "bindingNavigatorPessoas";
            this.bindingNavigatorPessoas.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorPessoas.Size = new System.Drawing.Size(1123, 31);
            this.bindingNavigatorPessoas.TabIndex = 29;
            this.bindingNavigatorPessoas.Text = "bindingNavigatorPessoas";
            this.bindingNavigatorPessoas.Click += new System.EventHandler(this.bindingNavigatorMove_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(58, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = global::AguaAraras.Properties.Resources.Actions_go_first_view_icon;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = global::AguaAraras.Properties.Resources.Actions_go_previous_view_icon;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMove_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            this.bindingNavigatorPositionItem.TextChanged += new System.EventHandler(this.bindingNavigatorMove_Click);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = global::AguaAraras.Properties.Resources.Actions_go_next_view_icon;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMove_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = global::AguaAraras.Properties.Resources.Actions_go_last_view_icon;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigatorMove_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Image = global::AguaAraras.Properties.Resources.Actions_document_save_icon;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonSave.Text = "Save";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // cobrancaComboBox
            // 
            this.cobrancaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSourcePessoas, "Cobranca", true));
            this.cobrancaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobrancaComboBox.FormattingEnabled = true;
            this.cobrancaComboBox.Location = new System.Drawing.Point(125, 47);
            this.cobrancaComboBox.Name = "cobrancaComboBox";
            this.cobrancaComboBox.Size = new System.Drawing.Size(121, 36);
            this.cobrancaComboBox.TabIndex = 5;
            // 
            // tratamentoComboBox
            // 
            this.tratamentoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourcePessoas, "Tratamento", true));
            this.tratamentoComboBox.FormattingEnabled = true;
            this.tratamentoComboBox.Items.AddRange(new object[] {
            "a",
            "o",
            "x"});
            this.tratamentoComboBox.Location = new System.Drawing.Point(125, 12);
            this.tratamentoComboBox.Name = "tratamentoComboBox";
            this.tratamentoComboBox.Size = new System.Drawing.Size(39, 36);
            this.tratamentoComboBox.TabIndex = 3;
            // 
            // iDLabel
            // 
            this.iDLabel.BackColor = System.Drawing.Color.Black;
            this.iDLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourcePessoas, "ID", true));
            this.iDLabel.Font = new System.Drawing.Font("Segoe UI Light", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.iDLabel.Location = new System.Drawing.Point(979, 31);
            this.iDLabel.Name = "iDLabel";
            this.iDLabel.Size = new System.Drawing.Size(131, 107);
            this.iDLabel.TabIndex = 35;
            this.iDLabel.Text = "15";
            this.iDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nomeCompletoLabel1
            // 
            this.nomeCompletoLabel1.BackColor = System.Drawing.Color.Black;
            this.nomeCompletoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourcePessoas, "NomeCompleto", true));
            this.nomeCompletoLabel1.Font = new System.Drawing.Font("Segoe UI Light", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeCompletoLabel1.ForeColor = System.Drawing.Color.White;
            this.nomeCompletoLabel1.Location = new System.Drawing.Point(202, 31);
            this.nomeCompletoLabel1.Name = "nomeCompletoLabel1";
            this.nomeCompletoLabel1.Size = new System.Drawing.Size(771, 66);
            this.nomeCompletoLabel1.TabIndex = 36;
            this.nomeCompletoLabel1.Text = "label1";
            this.nomeCompletoLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // enderecoArarasLabel1
            // 
            this.enderecoArarasLabel1.BackColor = System.Drawing.Color.Black;
            this.enderecoArarasLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourcePessoas, "EnderecoAraras", true));
            this.enderecoArarasLabel1.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enderecoArarasLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.enderecoArarasLabel1.Location = new System.Drawing.Point(202, 97);
            this.enderecoArarasLabel1.Name = "enderecoArarasLabel1";
            this.enderecoArarasLabel1.Size = new System.Drawing.Size(771, 41);
            this.enderecoArarasLabel1.TabIndex = 37;
            this.enderecoArarasLabel1.Text = "label1";
            this.enderecoArarasLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvTelefones
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvTelefones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTelefones.AutoGenerateColumns = false;
            this.dgvTelefones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelefones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumnTipo});
            this.dgvTelefones.DataSource = this.bindingSourceTelefones;
            this.dgvTelefones.Location = new System.Drawing.Point(9, 138);
            this.dgvTelefones.Name = "dgvTelefones";
            this.dgvTelefones.RowHeadersWidth = 25;
            this.dgvTelefones.RowTemplate.Height = 25;
            this.dgvTelefones.Size = new System.Drawing.Size(307, 139);
            this.dgvTelefones.TabIndex = 37;
            this.dgvTelefones.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewTelefones_CellFormatting);
            this.dgvTelefones.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTelefones_CellValueChanged);
            this.dgvTelefones.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewTelefones_DataError);
            this.dgvTelefones.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridViewTelefones_UserAddedRow);
            this.dgvTelefones.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridViewTelefones_UserDeletedRow);
            this.dgvTelefones.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewTelefones_UserDeletingRow);
            // 
            // dgvEnderecos
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvEnderecos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEnderecos.AutoGenerateColumns = false;
            this.dgvEnderecos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnderecos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2});
            this.dgvEnderecos.DataSource = this.bindingSourceEnderecos;
            this.dgvEnderecos.Location = new System.Drawing.Point(9, 6);
            this.dgvEnderecos.Name = "dgvEnderecos";
            this.dgvEnderecos.RowHeadersWidth = 25;
            this.dgvEnderecos.RowTemplate.Height = 25;
            this.dgvEnderecos.Size = new System.Drawing.Size(891, 126);
            this.dgvEnderecos.TabIndex = 37;
            this.dgvEnderecos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewEnderecos_CellFormatting);
            this.dgvEnderecos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEnderecos_CellValueChanged);
            this.dgvEnderecos.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewEnderecos_DataError);
            this.dgvEnderecos.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridViewEnderecos_UserAddedRow);
            this.dgvEnderecos.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridViewEnderecos_UserDeletedRow);
            this.dgvEnderecos.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewEnderecos_UserDeletingRow);
            // 
            // tomadasLabel1
            // 
            this.tomadasLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourcePessoas, "Tomadas", true));
            this.tomadasLabel1.Location = new System.Drawing.Point(789, 15);
            this.tomadasLabel1.Name = "tomadasLabel1";
            this.tomadasLabel1.Size = new System.Drawing.Size(54, 23);
            this.tomadasLabel1.TabIndex = 38;
            this.tomadasLabel1.Text = "label1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(200, 141);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(914, 317);
            this.tabControl1.TabIndex = 39;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ativoCheckBox);
            this.tabPage1.Controls.Add(this.observacoesTextBox);
            this.tabPage1.Controls.Add(this.tomadasLabel1);
            this.tabPage1.Controls.Add(tomadasLabel);
            this.tabPage1.Controls.Add(this.sobrenomeTextBox);
            this.tabPage1.Controls.Add(this.reciboCheckBox);
            this.tabPage1.Controls.Add(observacoesLabel);
            this.tabPage1.Controls.Add(this.nomeTextBox);
            this.tabPage1.Controls.Add(nomeLabel);
            this.tabPage1.Controls.Add(this.tratamentoComboBox);
            this.tabPage1.Controls.Add(this.eMailTextBox);
            this.tabPage1.Controls.Add(cobrancaLabel);
            this.tabPage1.Controls.Add(eMailLabel);
            this.tabPage1.Controls.Add(this.cobrancaComboBox);
            this.tabPage1.Controls.Add(this.atualizarCheckBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(906, 276);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ativoCheckBox
            // 
            this.ativoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bindingSourcePessoas, "Ativo", true));
            this.ativoCheckBox.Location = new System.Drawing.Point(518, 52);
            this.ativoCheckBox.Name = "ativoCheckBox";
            this.ativoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.ativoCheckBox.TabIndex = 39;
            this.ativoCheckBox.Text = "Ativo";
            this.ativoCheckBox.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvEnderecos);
            this.tabPage2.Controls.Add(this.dgvTelefones);
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(906, 276);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Endereços e Telefones";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bindingSourcePessoas
            // 
            this.bindingSourcePessoas.AllowNew = false;
            this.bindingSourcePessoas.DataSource = typeof(AguaAraras.Pessoa);
            this.bindingSourcePessoas.CurrentChanged += new System.EventHandler(this.bindingSourcePessoas_CurrentChanged);
            // 
            // bindingSourceEnderecos
            // 
            this.bindingSourceEnderecos.AllowNew = true;
            this.bindingSourceEnderecos.DataSource = typeof(AguaAraras.Endereco);
            // 
            // bindingSourceTelefones
            // 
            this.bindingSourceTelefones.AllowNew = true;
            this.bindingSourceTelefones.DataSource = typeof(AguaAraras.Telefone);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PessoaID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PessoaID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Logradouro";
            this.dataGridViewTextBoxColumn2.HeaderText = "Logradouro";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Bairro";
            this.dataGridViewTextBoxColumn3.HeaderText = "Bairro";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 130;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cidade";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cidade";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 130;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Estado";
            this.dataGridViewTextBoxColumn5.HeaderText = "UF";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 30;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CEP";
            this.dataGridViewTextBoxColumn6.HeaderText = "CEP";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Residencia";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Res";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ToolTipText = "Residencia";
            this.dataGridViewCheckBoxColumn1.Width = 35;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Correspondencia";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Cor";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ToolTipText = "Correspondência";
            this.dataGridViewCheckBoxColumn2.Width = 35;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PessoaID";
            this.dataGridViewTextBoxColumn8.HeaderText = "PessoaID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            this.dataGridViewTextBoxColumn8.Width = 130;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "DDD";
            this.dataGridViewTextBoxColumn9.HeaderText = "DDD";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 55;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Numero";
            this.dataGridViewTextBoxColumn10.HeaderText = "Número";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumnTipo
            // 
            this.dataGridViewTextBoxColumnTipo.DataPropertyName = "Tipo";
            this.dataGridViewTextBoxColumnTipo.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumnTipo.Name = "dataGridViewTextBoxColumnTipo";
            this.dataGridViewTextBoxColumnTipo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumnTipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumnTipo.Width = 120;
            // 
            // frmPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1123, 468);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.enderecoArarasLabel1);
            this.Controls.Add(this.nomeCompletoLabel1);
            this.Controls.Add(this.iDLabel);
            this.Controls.Add(this.bindingNavigatorPessoas);
            this.Controls.Add(this.listBoxPessoas);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmPessoas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pessoas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPessoas_FormClosing);
            this.Load += new System.EventHandler(this.frmPessoas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorPessoas)).EndInit();
            this.bindingNavigatorPessoas.ResumeLayout(false);
            this.bindingNavigatorPessoas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnderecos)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePessoas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEnderecos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTelefones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPessoas;
        private System.Windows.Forms.BindingSource bindingSourcePessoas;
        private System.Windows.Forms.CheckBox atualizarCheckBox;
        private System.Windows.Forms.TextBox eMailTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox observacoesTextBox;
        private System.Windows.Forms.CheckBox reciboCheckBox;
        private System.Windows.Forms.TextBox sobrenomeTextBox;
        private System.Windows.Forms.BindingNavigator bindingNavigatorPessoas;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ComboBox cobrancaComboBox;
        private System.Windows.Forms.ComboBox tratamentoComboBox;
        private System.Windows.Forms.Label iDLabel;
        private System.Windows.Forms.Label nomeCompletoLabel1;
        private System.Windows.Forms.Label enderecoArarasLabel1;
        private System.Windows.Forms.BindingSource bindingSourceTelefones;
        private System.Windows.Forms.DataGridView dgvTelefones;
        private System.Windows.Forms.BindingSource bindingSourceEnderecos;
        private System.Windows.Forms.DataGridView dgvEnderecos;
        private System.Windows.Forms.Label tomadasLabel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox ativoCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumnTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
    }
}