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
            this.nupMensalidade = new System.Windows.Forms.NumericUpDown();
            this.radioButtonCalculado = new System.Windows.Forms.RadioButton();
            this.radioButtonArredondado = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelCobrancaDesc = new System.Windows.Forms.Label();
            this.labelVergilioDesc = new System.Windows.Forms.Label();
            this.labelTotalDesc = new System.Windows.Forms.Label();
            this.nupSalario = new System.Windows.Forms.NumericUpDown();
            this.labelCalculado = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelAtual = new System.Windows.Forms.Label();
            this.radioButtonAtual = new System.Windows.Forms.RadioButton();
            this.nupTomadas = new System.Windows.Forms.NumericUpDown();
            this.labelTomadas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nupMensalidade)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupSalario)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupTomadas)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSalario
            // 
            this.labelSalario.AutoSize = true;
            this.labelSalario.ForeColor = System.Drawing.Color.LightGray;
            this.labelSalario.Location = new System.Drawing.Point(15, 15);
            this.labelSalario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSalario.Name = "labelSalario";
            this.labelSalario.Size = new System.Drawing.Size(91, 32);
            this.labelSalario.TabIndex = 0;
            this.labelSalario.Text = "Salário:";
            this.labelSalario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSalario.Click += new System.EventHandler(this.labelSalario_Click);
            // 
            // labelVergilio
            // 
            this.labelVergilio.AutoSize = true;
            this.labelVergilio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVergilio.ForeColor = System.Drawing.Color.LightGray;
            this.labelVergilio.Location = new System.Drawing.Point(5, 40);
            this.labelVergilio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVergilio.Name = "labelVergilio";
            this.labelVergilio.Size = new System.Drawing.Size(125, 38);
            this.labelVergilio.TabIndex = 4;
            this.labelVergilio.Text = "Manutenção";
            this.labelVergilio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelVergilioValor
            // 
            this.labelVergilioValor.AutoSize = true;
            this.labelVergilioValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVergilioValor.ForeColor = System.Drawing.Color.LightCoral;
            this.labelVergilioValor.Location = new System.Drawing.Point(358, 40);
            this.labelVergilioValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVergilioValor.Name = "labelVergilioValor";
            this.labelVergilioValor.Size = new System.Drawing.Size(158, 38);
            this.labelVergilioValor.TabIndex = 5;
            this.labelVergilioValor.Text = "VergilioValor";
            this.labelVergilioValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCobranca
            // 
            this.labelCobranca.AutoSize = true;
            this.labelCobranca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCobranca.ForeColor = System.Drawing.Color.LightGray;
            this.labelCobranca.Location = new System.Drawing.Point(5, 79);
            this.labelCobranca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCobranca.Name = "labelCobranca";
            this.labelCobranca.Size = new System.Drawing.Size(125, 38);
            this.labelCobranca.TabIndex = 6;
            this.labelCobranca.Text = "Cobrança";
            this.labelCobranca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCobrancaValor
            // 
            this.labelCobrancaValor.AutoSize = true;
            this.labelCobrancaValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCobrancaValor.ForeColor = System.Drawing.Color.LightCoral;
            this.labelCobrancaValor.Location = new System.Drawing.Point(358, 79);
            this.labelCobrancaValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCobrancaValor.Name = "labelCobrancaValor";
            this.labelCobrancaValor.Size = new System.Drawing.Size(158, 38);
            this.labelCobrancaValor.TabIndex = 7;
            this.labelCobrancaValor.Text = "CobrancaValor";
            this.labelCobrancaValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTotal.ForeColor = System.Drawing.Color.LightGray;
            this.labelTotal.Location = new System.Drawing.Point(5, 1);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(125, 38);
            this.labelTotal.TabIndex = 8;
            this.labelTotal.Text = "Total";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTotalValor
            // 
            this.labelTotalValor.AutoSize = true;
            this.labelTotalValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTotalValor.ForeColor = System.Drawing.Color.LawnGreen;
            this.labelTotalValor.Location = new System.Drawing.Point(358, 1);
            this.labelTotalValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalValor.Name = "labelTotalValor";
            this.labelTotalValor.Size = new System.Drawing.Size(158, 38);
            this.labelTotalValor.TabIndex = 9;
            this.labelTotalValor.Text = "TotalValor";
            this.labelTotalValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelReserva
            // 
            this.labelReserva.AutoSize = true;
            this.labelReserva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelReserva.ForeColor = System.Drawing.Color.LightGray;
            this.labelReserva.Location = new System.Drawing.Point(5, 118);
            this.labelReserva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelReserva.Name = "labelReserva";
            this.labelReserva.Size = new System.Drawing.Size(125, 39);
            this.labelReserva.TabIndex = 10;
            this.labelReserva.Text = "Reserva";
            this.labelReserva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelReservaValor
            // 
            this.labelReservaValor.AutoSize = true;
            this.labelReservaValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelReservaValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReservaValor.ForeColor = System.Drawing.Color.White;
            this.labelReservaValor.Location = new System.Drawing.Point(358, 118);
            this.labelReservaValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelReservaValor.Name = "labelReservaValor";
            this.labelReservaValor.Size = new System.Drawing.Size(158, 39);
            this.labelReservaValor.TabIndex = 11;
            this.labelReservaValor.Text = "ReservaValor";
            this.labelReservaValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nupMensalidade
            // 
            this.nupMensalidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nupMensalidade.DecimalPlaces = 2;
            this.nupMensalidade.ForeColor = System.Drawing.Color.White;
            this.nupMensalidade.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nupMensalidade.Location = new System.Drawing.Point(174, 70);
            this.nupMensalidade.Margin = new System.Windows.Forms.Padding(4);
            this.nupMensalidade.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nupMensalidade.Name = "nupMensalidade";
            this.nupMensalidade.Size = new System.Drawing.Size(99, 39);
            this.nupMensalidade.TabIndex = 12;
            this.nupMensalidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupMensalidade.ValueChanged += new System.EventHandler(this.CalcularDetalhes_Changed);
            // 
            // radioButtonCalculado
            // 
            this.radioButtonCalculado.AutoSize = true;
            this.radioButtonCalculado.ForeColor = System.Drawing.Color.LightGray;
            this.radioButtonCalculado.Location = new System.Drawing.Point(20, 33);
            this.radioButtonCalculado.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonCalculado.Name = "radioButtonCalculado";
            this.radioButtonCalculado.Size = new System.Drawing.Size(140, 36);
            this.radioButtonCalculado.TabIndex = 13;
            this.radioButtonCalculado.Text = "Calculado";
            this.radioButtonCalculado.UseVisualStyleBackColor = true;
            this.radioButtonCalculado.CheckedChanged += new System.EventHandler(this.CalcularDetalhes_Changed);
            // 
            // radioButtonArredondado
            // 
            this.radioButtonArredondado.AutoSize = true;
            this.radioButtonArredondado.Checked = true;
            this.radioButtonArredondado.ForeColor = System.Drawing.Color.LightGray;
            this.radioButtonArredondado.Location = new System.Drawing.Point(20, 70);
            this.radioButtonArredondado.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonArredondado.Name = "radioButtonArredondado";
            this.radioButtonArredondado.Size = new System.Drawing.Size(176, 36);
            this.radioButtonArredondado.TabIndex = 14;
            this.radioButtonArredondado.TabStop = true;
            this.radioButtonArredondado.Text = "Arredondado";
            this.radioButtonArredondado.UseVisualStyleBackColor = true;
            this.radioButtonArredondado.CheckedChanged += new System.EventHandler(this.CalcularDetalhes_Changed);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 218F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166F));
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
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.Silver;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(346, 95);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(520, 158);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // labelCobrancaDesc
            // 
            this.labelCobrancaDesc.AutoSize = true;
            this.labelCobrancaDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCobrancaDesc.ForeColor = System.Drawing.Color.LightCoral;
            this.labelCobrancaDesc.Location = new System.Drawing.Point(139, 79);
            this.labelCobrancaDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCobrancaDesc.Name = "labelCobrancaDesc";
            this.labelCobrancaDesc.Size = new System.Drawing.Size(210, 38);
            this.labelCobrancaDesc.TabIndex = 14;
            this.labelCobrancaDesc.Text = "Cobrança";
            this.labelCobrancaDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelVergilioDesc
            // 
            this.labelVergilioDesc.AutoSize = true;
            this.labelVergilioDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVergilioDesc.ForeColor = System.Drawing.Color.LightCoral;
            this.labelVergilioDesc.Location = new System.Drawing.Point(139, 40);
            this.labelVergilioDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVergilioDesc.Name = "labelVergilioDesc";
            this.labelVergilioDesc.Size = new System.Drawing.Size(210, 38);
            this.labelVergilioDesc.TabIndex = 13;
            this.labelVergilioDesc.Text = "Vergilio";
            this.labelVergilioDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTotalDesc
            // 
            this.labelTotalDesc.AutoSize = true;
            this.labelTotalDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTotalDesc.ForeColor = System.Drawing.Color.White;
            this.labelTotalDesc.Location = new System.Drawing.Point(139, 1);
            this.labelTotalDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalDesc.Name = "labelTotalDesc";
            this.labelTotalDesc.Size = new System.Drawing.Size(210, 38);
            this.labelTotalDesc.TabIndex = 12;
            this.labelTotalDesc.Text = "Total";
            this.labelTotalDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nupSalario
            // 
            this.nupSalario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nupSalario.DecimalPlaces = 2;
            this.nupSalario.ForeColor = System.Drawing.Color.White;
            this.nupSalario.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nupSalario.Location = new System.Drawing.Point(112, 13);
            this.nupSalario.Margin = new System.Windows.Forms.Padding(4);
            this.nupSalario.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nupSalario.Name = "nupSalario";
            this.nupSalario.Size = new System.Drawing.Size(103, 39);
            this.nupSalario.TabIndex = 16;
            this.nupSalario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupSalario.ValueChanged += new System.EventHandler(this.CalcularMensalidade_Changed);
            // 
            // labelCalculado
            // 
            this.labelCalculado.Location = new System.Drawing.Point(159, 36);
            this.labelCalculado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCalculado.Name = "labelCalculado";
            this.labelCalculado.Size = new System.Drawing.Size(99, 25);
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
            this.groupBox1.Controls.Add(this.nupMensalidade);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(22, 106);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(297, 148);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mensalidade";
            // 
            // labelAtual
            // 
            this.labelAtual.Location = new System.Drawing.Point(159, 112);
            this.labelAtual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAtual.Name = "labelAtual";
            this.labelAtual.Size = new System.Drawing.Size(99, 25);
            this.labelAtual.TabIndex = 15;
            this.labelAtual.Text = "Atual";
            this.labelAtual.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radioButtonAtual
            // 
            this.radioButtonAtual.AutoSize = true;
            this.radioButtonAtual.ForeColor = System.Drawing.Color.LightGray;
            this.radioButtonAtual.Location = new System.Drawing.Point(20, 107);
            this.radioButtonAtual.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonAtual.Name = "radioButtonAtual";
            this.radioButtonAtual.Size = new System.Drawing.Size(91, 36);
            this.radioButtonAtual.TabIndex = 15;
            this.radioButtonAtual.Text = "Atual";
            this.radioButtonAtual.UseVisualStyleBackColor = true;
            this.radioButtonAtual.CheckedChanged += new System.EventHandler(this.CalcularDetalhes_Changed);
            // 
            // nupTomadas
            // 
            this.nupTomadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nupTomadas.ForeColor = System.Drawing.Color.White;
            this.nupTomadas.Location = new System.Drawing.Point(112, 55);
            this.nupTomadas.Margin = new System.Windows.Forms.Padding(4);
            this.nupTomadas.Maximum = new decimal(new int[] {
            21,
            0,
            0,
            0});
            this.nupTomadas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupTomadas.Name = "nupTomadas";
            this.nupTomadas.Size = new System.Drawing.Size(103, 39);
            this.nupTomadas.TabIndex = 19;
            this.nupTomadas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupTomadas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupTomadas.ValueChanged += new System.EventHandler(this.CalcularMensalidade_Changed);
            // 
            // labelTomadas
            // 
            this.labelTomadas.AutoSize = true;
            this.labelTomadas.ForeColor = System.Drawing.Color.LightGray;
            this.labelTomadas.Location = new System.Drawing.Point(15, 57);
            this.labelTomadas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTomadas.Name = "labelTomadas";
            this.labelTomadas.Size = new System.Drawing.Size(114, 32);
            this.labelTomadas.TabIndex = 18;
            this.labelTomadas.Text = "Tomadas:";
            this.labelTomadas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTomadas.DoubleClick += new System.EventHandler(this.labelTomadas_DoubleClick);
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(879, 267);
            this.Controls.Add(this.nupTomadas);
            this.Controls.Add(this.labelTomadas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nupSalario);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.labelSalario);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "frmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.frmCalculadora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupMensalidade)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupSalario)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupTomadas)).EndInit();
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
        private System.Windows.Forms.NumericUpDown nupMensalidade;
        private System.Windows.Forms.RadioButton radioButtonCalculado;
        private System.Windows.Forms.RadioButton radioButtonArredondado;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelCobrancaDesc;
        private System.Windows.Forms.Label labelVergilioDesc;
        private System.Windows.Forms.Label labelTotalDesc;
        private System.Windows.Forms.NumericUpDown nupSalario;
        private System.Windows.Forms.Label labelCalculado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nupTomadas;
        private System.Windows.Forms.Label labelTomadas;
        private System.Windows.Forms.RadioButton radioButtonAtual;
        private System.Windows.Forms.Label labelAtual;
    }
}