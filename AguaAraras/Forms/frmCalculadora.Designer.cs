namespace AguaAraras {
    partial class frmCalculadora {
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
            this.labelSalario = new System.Windows.Forms.Label();
            this.labelVergilio = new System.Windows.Forms.Label();
            this.labelVergilioValor = new System.Windows.Forms.Label();
            this.labelCobranca = new System.Windows.Forms.Label();
            this.labelCobrancaValor = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelTotalValor = new System.Windows.Forms.Label();
            this.labelReserva = new System.Windows.Forms.Label();
            this.labelReservaValor = new System.Windows.Forms.Label();
            this.numericUpDownMensalidade = new System.Windows.Forms.NumericUpDown();
            this.radioButtonCalculado = new System.Windows.Forms.RadioButton();
            this.radioButtonArredondado = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelCobrancaDesc = new System.Windows.Forms.Label();
            this.labelVergilioDesc = new System.Windows.Forms.Label();
            this.labelTotalDesc = new System.Windows.Forms.Label();
            this.numericUpDownSalario = new System.Windows.Forms.NumericUpDown();
            this.labelCalculado = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownTomadas = new System.Windows.Forms.NumericUpDown();
            this.labelTomadas = new System.Windows.Forms.Label();
            this.radioButtonAtual = new System.Windows.Forms.RadioButton();
            this.labelAtual = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMensalidade)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSalario)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTomadas)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSalario
            // 
            this.labelSalario.AutoSize = true;
            this.labelSalario.Location = new System.Drawing.Point(12, 13);
            this.labelSalario.Name = "labelSalario";
            this.labelSalario.Size = new System.Drawing.Size(61, 21);
            this.labelSalario.TabIndex = 0;
            this.labelSalario.Text = "Salário:";
            this.labelSalario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSalario.Click += new System.EventHandler(this.labelSalario_Click);
            // 
            // labelVergilio
            // 
            this.labelVergilio.AutoSize = true;
            this.labelVergilio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVergilio.Location = new System.Drawing.Point(5, 34);
            this.labelVergilio.Name = "labelVergilio";
            this.labelVergilio.Size = new System.Drawing.Size(84, 30);
            this.labelVergilio.TabIndex = 4;
            this.labelVergilio.Text = "Vergilio";
            this.labelVergilio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelVergilioValor
            // 
            this.labelVergilioValor.AutoSize = true;
            this.labelVergilioValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVergilioValor.ForeColor = System.Drawing.Color.Red;
            this.labelVergilioValor.Location = new System.Drawing.Point(279, 34);
            this.labelVergilioValor.Name = "labelVergilioValor";
            this.labelVergilioValor.Size = new System.Drawing.Size(139, 30);
            this.labelVergilioValor.TabIndex = 5;
            this.labelVergilioValor.Text = "VergilioValor";
            this.labelVergilioValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCobranca
            // 
            this.labelCobranca.AutoSize = true;
            this.labelCobranca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCobranca.Location = new System.Drawing.Point(5, 66);
            this.labelCobranca.Name = "labelCobranca";
            this.labelCobranca.Size = new System.Drawing.Size(84, 30);
            this.labelCobranca.TabIndex = 6;
            this.labelCobranca.Text = "Cobrança";
            this.labelCobranca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCobrancaValor
            // 
            this.labelCobrancaValor.AutoSize = true;
            this.labelCobrancaValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCobrancaValor.ForeColor = System.Drawing.Color.Red;
            this.labelCobrancaValor.Location = new System.Drawing.Point(279, 66);
            this.labelCobrancaValor.Name = "labelCobrancaValor";
            this.labelCobrancaValor.Size = new System.Drawing.Size(139, 30);
            this.labelCobrancaValor.TabIndex = 7;
            this.labelCobrancaValor.Text = "CobrancaValor";
            this.labelCobrancaValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTotal.Location = new System.Drawing.Point(5, 2);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(84, 30);
            this.labelTotal.TabIndex = 8;
            this.labelTotal.Text = "Total";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTotalValor
            // 
            this.labelTotalValor.AutoSize = true;
            this.labelTotalValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTotalValor.Location = new System.Drawing.Point(279, 2);
            this.labelTotalValor.Name = "labelTotalValor";
            this.labelTotalValor.Size = new System.Drawing.Size(139, 30);
            this.labelTotalValor.TabIndex = 9;
            this.labelTotalValor.Text = "TotalValor";
            this.labelTotalValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelReserva
            // 
            this.labelReserva.AutoSize = true;
            this.labelReserva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelReserva.Location = new System.Drawing.Point(5, 98);
            this.labelReserva.Name = "labelReserva";
            this.labelReserva.Size = new System.Drawing.Size(84, 33);
            this.labelReserva.TabIndex = 10;
            this.labelReserva.Text = "Reserva";
            this.labelReserva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelReservaValor
            // 
            this.labelReservaValor.AutoSize = true;
            this.labelReservaValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelReservaValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReservaValor.Location = new System.Drawing.Point(279, 98);
            this.labelReservaValor.Name = "labelReservaValor";
            this.labelReservaValor.Size = new System.Drawing.Size(139, 33);
            this.labelReservaValor.TabIndex = 11;
            this.labelReservaValor.Text = "ReservaValor";
            this.labelReservaValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numericUpDownMensalidade
            // 
            this.numericUpDownMensalidade.DecimalPlaces = 2;
            this.numericUpDownMensalidade.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownMensalidade.Location = new System.Drawing.Point(142, 59);
            this.numericUpDownMensalidade.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMensalidade.Name = "numericUpDownMensalidade";
            this.numericUpDownMensalidade.Size = new System.Drawing.Size(81, 29);
            this.numericUpDownMensalidade.TabIndex = 12;
            this.numericUpDownMensalidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownMensalidade.ValueChanged += new System.EventHandler(this.numericUpDownMensalidade_ValueChanged);
            // 
            // radioButtonCalculado
            // 
            this.radioButtonCalculado.AutoSize = true;
            this.radioButtonCalculado.Location = new System.Drawing.Point(16, 28);
            this.radioButtonCalculado.Name = "radioButtonCalculado";
            this.radioButtonCalculado.Size = new System.Drawing.Size(96, 25);
            this.radioButtonCalculado.TabIndex = 13;
            this.radioButtonCalculado.Text = "Calculado";
            this.radioButtonCalculado.UseVisualStyleBackColor = true;
            this.radioButtonCalculado.CheckedChanged += new System.EventHandler(this.radioButtonCalculado_CheckedChanged);
            // 
            // radioButtonArredondado
            // 
            this.radioButtonArredondado.AutoSize = true;
            this.radioButtonArredondado.Checked = true;
            this.radioButtonArredondado.Location = new System.Drawing.Point(16, 59);
            this.radioButtonArredondado.Name = "radioButtonArredondado";
            this.radioButtonArredondado.Size = new System.Drawing.Size(120, 25);
            this.radioButtonArredondado.TabIndex = 14;
            this.radioButtonArredondado.TabStop = true;
            this.radioButtonArredondado.Text = "Arredondado";
            this.radioButtonArredondado.UseVisualStyleBackColor = true;
            this.radioButtonArredondado.CheckedChanged += new System.EventHandler(this.radioButtonCalculado_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel1.Controls.Add(this.labelCobrancaDesc, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelVergilioDesc, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelTotalDesc, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelTotal, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelTotalValor, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelVergilio, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelVergilioValor, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelReserva, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelReservaValor, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelCobranca, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelCobrancaValor, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(283, 80);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(417, 133);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // labelCobrancaDesc
            // 
            this.labelCobrancaDesc.AutoSize = true;
            this.labelCobrancaDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCobrancaDesc.Location = new System.Drawing.Point(97, 66);
            this.labelCobrancaDesc.Name = "labelCobrancaDesc";
            this.labelCobrancaDesc.Size = new System.Drawing.Size(174, 30);
            this.labelCobrancaDesc.TabIndex = 14;
            this.labelCobrancaDesc.Text = "Cobrança";
            this.labelCobrancaDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelVergilioDesc
            // 
            this.labelVergilioDesc.AutoSize = true;
            this.labelVergilioDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVergilioDesc.Location = new System.Drawing.Point(97, 34);
            this.labelVergilioDesc.Name = "labelVergilioDesc";
            this.labelVergilioDesc.Size = new System.Drawing.Size(174, 30);
            this.labelVergilioDesc.TabIndex = 13;
            this.labelVergilioDesc.Text = "Vergilio";
            this.labelVergilioDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTotalDesc
            // 
            this.labelTotalDesc.AutoSize = true;
            this.labelTotalDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTotalDesc.Location = new System.Drawing.Point(97, 2);
            this.labelTotalDesc.Name = "labelTotalDesc";
            this.labelTotalDesc.Size = new System.Drawing.Size(174, 30);
            this.labelTotalDesc.TabIndex = 12;
            this.labelTotalDesc.Text = "Total";
            this.labelTotalDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numericUpDownSalario
            // 
            this.numericUpDownSalario.DecimalPlaces = 2;
            this.numericUpDownSalario.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownSalario.Location = new System.Drawing.Point(92, 11);
            this.numericUpDownSalario.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownSalario.Name = "numericUpDownSalario";
            this.numericUpDownSalario.Size = new System.Drawing.Size(84, 29);
            this.numericUpDownSalario.TabIndex = 16;
            this.numericUpDownSalario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownSalario.ValueChanged += new System.EventHandler(this.numericUpDownSalario_ValueChanged);
            // 
            // labelCalculado
            // 
            this.labelCalculado.Location = new System.Drawing.Point(130, 30);
            this.labelCalculado.Name = "labelCalculado";
            this.labelCalculado.Size = new System.Drawing.Size(81, 21);
            this.labelCalculado.TabIndex = 2;
            this.labelCalculado.Text = "Calculado";
            this.labelCalculado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelAtual);
            this.groupBox1.Controls.Add(this.radioButtonCalculado);
            this.groupBox1.Controls.Add(this.radioButtonAtual);
            this.groupBox1.Controls.Add(this.labelCalculado);
            this.groupBox1.Controls.Add(this.radioButtonArredondado);
            this.groupBox1.Controls.Add(this.numericUpDownMensalidade);
            this.groupBox1.Location = new System.Drawing.Point(18, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 124);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mensalidade";
            // 
            // numericUpDownTomadas
            // 
            this.numericUpDownTomadas.Location = new System.Drawing.Point(92, 46);
            this.numericUpDownTomadas.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownTomadas.Name = "numericUpDownTomadas";
            this.numericUpDownTomadas.Size = new System.Drawing.Size(84, 29);
            this.numericUpDownTomadas.TabIndex = 19;
            this.numericUpDownTomadas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownTomadas.ValueChanged += new System.EventHandler(this.numericUpDownMensalidade_ValueChanged);
            // 
            // labelTomadas
            // 
            this.labelTomadas.AutoSize = true;
            this.labelTomadas.Location = new System.Drawing.Point(12, 48);
            this.labelTomadas.Name = "labelTomadas";
            this.labelTomadas.Size = new System.Drawing.Size(74, 21);
            this.labelTomadas.TabIndex = 18;
            this.labelTomadas.Text = "Tomadas:";
            this.labelTomadas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTomadas.DoubleClick += new System.EventHandler(this.labelTomadas_DoubleClick);
            // 
            // radioButtonAtual
            // 
            this.radioButtonAtual.AutoSize = true;
            this.radioButtonAtual.Location = new System.Drawing.Point(16, 90);
            this.radioButtonAtual.Name = "radioButtonAtual";
            this.radioButtonAtual.Size = new System.Drawing.Size(64, 25);
            this.radioButtonAtual.TabIndex = 15;
            this.radioButtonAtual.Text = "Atual";
            this.radioButtonAtual.UseVisualStyleBackColor = true;
            this.radioButtonAtual.CheckedChanged += new System.EventHandler(this.radioButtonCalculado_CheckedChanged);
            // 
            // labelAtual
            // 
            this.labelAtual.Location = new System.Drawing.Point(130, 94);
            this.labelAtual.Name = "labelAtual";
            this.labelAtual.Size = new System.Drawing.Size(81, 21);
            this.labelAtual.TabIndex = 15;
            this.labelAtual.Text = "Atual";
            this.labelAtual.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 224);
            this.Controls.Add(this.numericUpDownTomadas);
            this.Controls.Add(this.labelTomadas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numericUpDownSalario);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.labelSalario);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.frmCalculadora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMensalidade)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSalario)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTomadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSalario;
        private System.Windows.Forms.Label labelVergilio;
        private System.Windows.Forms.Label labelVergilioValor;
        private System.Windows.Forms.Label labelCobranca;
        private System.Windows.Forms.Label labelCobrancaValor;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelTotalValor;
        private System.Windows.Forms.Label labelReserva;
        private System.Windows.Forms.Label labelReservaValor;
        private System.Windows.Forms.NumericUpDown numericUpDownMensalidade;
        private System.Windows.Forms.RadioButton radioButtonCalculado;
        private System.Windows.Forms.RadioButton radioButtonArredondado;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelCobrancaDesc;
        private System.Windows.Forms.Label labelVergilioDesc;
        private System.Windows.Forms.Label labelTotalDesc;
        private System.Windows.Forms.NumericUpDown numericUpDownSalario;
        private System.Windows.Forms.Label labelCalculado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownTomadas;
        private System.Windows.Forms.Label labelTomadas;
        private System.Windows.Forms.RadioButton radioButtonAtual;
        private System.Windows.Forms.Label labelAtual;
    }
}