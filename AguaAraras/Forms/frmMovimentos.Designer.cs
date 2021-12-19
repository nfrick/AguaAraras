namespace AguaAraras {
    partial class frmMovimentos {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonNovo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonManutencao = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxErros = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxTipo = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxProcurar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonHistorico = new System.Windows.Forms.ToolStripButton();
            this.dgvMovimentos = new System.Windows.Forms.DataGridView();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumnTipo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.historicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacoesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reciboAnoNumeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsMovimentos = new System.Windows.Forms.BindingSource(this.components);
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMovimentos)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSave,
            this.toolStripButtonDelete,
            this.toolStripButtonNovo,
            this.toolStripButtonManutencao,
            this.toolStripButtonExcel,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.toolStripComboBoxErros,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.toolStripComboBoxTipo,
            this.toolStripSeparator3,
            this.toolStripLabel3,
            this.toolStripTextBoxProcurar,
            this.toolStripButtonHistorico});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1066, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Enabled = false;
            this.toolStripButtonSave.Image = global::AguaAraras.Properties.Resources.Document_save_icon;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonSave.Text = "Salvar";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDelete.Image = global::AguaAraras.Properties.Resources.Edit_delete_icon;
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonDelete.Text = "Deletar";
            // 
            // toolStripButtonNovo
            // 
            this.toolStripButtonNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNovo.Image = global::AguaAraras.Properties.Resources.Edit_add_icon;
            this.toolStripButtonNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNovo.Name = "toolStripButtonNovo";
            this.toolStripButtonNovo.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonNovo.Text = "Novo";
            this.toolStripButtonNovo.Click += new System.EventHandler(this.toolStripButtonNovo_Click);
            // 
            // toolStripButtonManutencao
            // 
            this.toolStripButtonManutencao.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonManutencao.Image = global::AguaAraras.Properties.Resources.Star_icon;
            this.toolStripButtonManutencao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonManutencao.Name = "toolStripButtonManutencao";
            this.toolStripButtonManutencao.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonManutencao.Text = "Manutenção";
            this.toolStripButtonManutencao.Click += new System.EventHandler(this.toolStripButtonManutencao_Click);
            // 
            // toolStripButtonExcel
            // 
            this.toolStripButtonExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExcel.Image = global::AguaAraras.Properties.Resources.Apps_excel_icon;
            this.toolStripButtonExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExcel.Name = "toolStripButtonExcel";
            this.toolStripButtonExcel.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonExcel.Text = "Exportar para Excel";
            this.toolStripButtonExcel.Click += new System.EventHandler(this.toolStripButtonExcel_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(60, 28);
            this.toolStripLabel2.Text = "Mostrar";
            // 
            // toolStripComboBoxErros
            // 
            this.toolStripComboBoxErros.Items.AddRange(new object[] {
            "Todos os registros",
            "Receitas negativas",
            "Despesas positivas",
            "Vergílio duplicado (mês)",
            "Vergílio duplicado (Histórico)",
            "Carlos duplicado (Trimestre)",
            "Carlos duplicado (Histórico)"});
            this.toolStripComboBoxErros.Name = "toolStripComboBoxErros";
            this.toolStripComboBoxErros.Size = new System.Drawing.Size(180, 31);
            this.toolStripComboBoxErros.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxErros_SelectedIndexChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(39, 28);
            this.toolStripLabel1.Text = "Tipo";
            // 
            // toolStripComboBoxTipo
            // 
            this.toolStripComboBoxTipo.Name = "toolStripComboBoxTipo";
            this.toolStripComboBoxTipo.Size = new System.Drawing.Size(121, 31);
            this.toolStripComboBoxTipo.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxTipo_SelectedIndexChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(64, 28);
            this.toolStripLabel3.Text = "Procurar";
            // 
            // toolStripTextBoxProcurar
            // 
            this.toolStripTextBoxProcurar.Name = "toolStripTextBoxProcurar";
            this.toolStripTextBoxProcurar.Size = new System.Drawing.Size(100, 31);
            // 
            // toolStripButtonHistorico
            // 
            this.toolStripButtonHistorico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonHistorico.Image = global::AguaAraras.Properties.Resources.Document_preview_icon;
            this.toolStripButtonHistorico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonHistorico.Name = "toolStripButtonHistorico";
            this.toolStripButtonHistorico.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonHistorico.Text = "Procurar";
            this.toolStripButtonHistorico.Click += new System.EventHandler(this.toolStripButtonProcurar_Click);
            // 
            // dgvMovimentos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvMovimentos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMovimentos.AutoGenerateColumns = false;
            this.dgvMovimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovimentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataDataGridViewTextBoxColumn,
            this.dataGridViewComboBoxColumnTipo,
            this.historicoDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.observacoesDataGridViewTextBoxColumn,
            this.reciboAnoNumeroDataGridViewTextBoxColumn});
            this.dgvMovimentos.DataSource = this.bsMovimentos;
            this.dgvMovimentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMovimentos.Location = new System.Drawing.Point(0, 31);
            this.dgvMovimentos.Name = "dgvMovimentos";
            this.dgvMovimentos.RowHeadersWidth = 25;
            this.dgvMovimentos.RowTemplate.Height = 26;
            this.dgvMovimentos.Size = new System.Drawing.Size(1066, 661);
            this.dgvMovimentos.TabIndex = 1;
            this.dgvMovimentos.DataSourceChanged += new System.EventHandler(this.dgvMovimentos_DataSourceChanged);
            this.dgvMovimentos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovimentos_CellEndEdit);
            this.dgvMovimentos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvMovimentos_CellFormatting);
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // dataGridViewComboBoxColumnTipo
            // 
            this.dataGridViewComboBoxColumnTipo.DataPropertyName = "Tipo";
            this.dataGridViewComboBoxColumnTipo.HeaderText = "Tipo";
            this.dataGridViewComboBoxColumnTipo.Name = "dataGridViewComboBoxColumnTipo";
            this.dataGridViewComboBoxColumnTipo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumnTipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumnTipo.Width = 140;
            // 
            // historicoDataGridViewTextBoxColumn
            // 
            this.historicoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.historicoDataGridViewTextBoxColumn.DataPropertyName = "Historico";
            this.historicoDataGridViewTextBoxColumn.HeaderText = "Histórico";
            this.historicoDataGridViewTextBoxColumn.Name = "historicoDataGridViewTextBoxColumn";
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.valorDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.Width = 70;
            // 
            // observacoesDataGridViewTextBoxColumn
            // 
            this.observacoesDataGridViewTextBoxColumn.DataPropertyName = "Observacoes";
            this.observacoesDataGridViewTextBoxColumn.HeaderText = "Observações";
            this.observacoesDataGridViewTextBoxColumn.Name = "observacoesDataGridViewTextBoxColumn";
            this.observacoesDataGridViewTextBoxColumn.Width = 300;
            // 
            // reciboAnoNumeroDataGridViewTextBoxColumn
            // 
            this.reciboAnoNumeroDataGridViewTextBoxColumn.DataPropertyName = "ReciboAnoNumero";
            this.reciboAnoNumeroDataGridViewTextBoxColumn.HeaderText = "Recibo";
            this.reciboAnoNumeroDataGridViewTextBoxColumn.Name = "reciboAnoNumeroDataGridViewTextBoxColumn";
            this.reciboAnoNumeroDataGridViewTextBoxColumn.ReadOnly = true;
            this.reciboAnoNumeroDataGridViewTextBoxColumn.Width = 70;
            // 
            // bsMovimentos
            // 
            this.bsMovimentos.DataSource = typeof(DataLayer.Movimento);
            // 
            // frmMovimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 692);
            this.Controls.Add(this.dgvMovimentos);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmMovimentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimentos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMovimentos_FormClosing);
            this.Load += new System.EventHandler(this.frmMovimentos_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMovimentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dgvMovimentos;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.ToolStripButton toolStripButtonNovo;
        private System.Windows.Forms.ToolStripButton toolStripButtonManutencao;
        private System.Windows.Forms.ToolStripButton toolStripButtonExcel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxErros;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxTipo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxProcurar;
        private System.Windows.Forms.ToolStripButton toolStripButtonHistorico;
        private System.Windows.Forms.SaveFileDialog SFD;
        private System.Windows.Forms.BindingSource bsMovimentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumnTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn historicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacoesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reciboAnoNumeroDataGridViewTextBoxColumn;
    }
}