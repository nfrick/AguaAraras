namespace AguaAraras {
    partial class frmCobrancaEmail {
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
            this.listBoxNomes = new System.Windows.Forms.ListBox();
            this.radioButtonTodos = new System.Windows.Forms.RadioButton();
            this.radioButtonSelecionados = new System.Windows.Forms.RadioButton();
            this.buttonGerar = new System.Windows.Forms.Button();
            this.labelFolder = new System.Windows.Forms.Label();
            this.buttonFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonSalvar = new System.Windows.Forms.RadioButton();
            this.radioButtonEnviar = new System.Windows.Forms.RadioButton();
            this.radioButtonEnviarDeletar = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAssunto = new System.Windows.Forms.Label();
            this.textBoxAssunto = new System.Windows.Forms.TextBox();
            this.textBoxBody = new System.Windows.Forms.TextBox();
            this.labelTexto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxIncluirCobrancasAnteriores = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxNomes
            // 
            this.listBoxNomes.Enabled = false;
            this.listBoxNomes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxNomes.FormattingEnabled = true;
            this.listBoxNomes.ItemHeight = 21;
            this.listBoxNomes.Location = new System.Drawing.Point(18, 49);
            this.listBoxNomes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxNomes.Name = "listBoxNomes";
            this.listBoxNomes.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxNomes.Size = new System.Drawing.Size(182, 193);
            this.listBoxNomes.TabIndex = 0;
            // 
            // radioButtonTodos
            // 
            this.radioButtonTodos.AutoSize = true;
            this.radioButtonTodos.Checked = true;
            this.radioButtonTodos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTodos.Location = new System.Drawing.Point(18, 14);
            this.radioButtonTodos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonTodos.Name = "radioButtonTodos";
            this.radioButtonTodos.Size = new System.Drawing.Size(68, 25);
            this.radioButtonTodos.TabIndex = 1;
            this.radioButtonTodos.TabStop = true;
            this.radioButtonTodos.Text = "Todos";
            this.radioButtonTodos.UseVisualStyleBackColor = true;
            this.radioButtonTodos.CheckedChanged += new System.EventHandler(this.radioButtonTodos_CheckedChanged);
            // 
            // radioButtonSelecionados
            // 
            this.radioButtonSelecionados.AutoSize = true;
            this.radioButtonSelecionados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSelecionados.Location = new System.Drawing.Point(100, 14);
            this.radioButtonSelecionados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonSelecionados.Name = "radioButtonSelecionados";
            this.radioButtonSelecionados.Size = new System.Drawing.Size(100, 25);
            this.radioButtonSelecionados.TabIndex = 2;
            this.radioButtonSelecionados.Text = "Selecionar";
            this.radioButtonSelecionados.UseVisualStyleBackColor = true;
            this.radioButtonSelecionados.CheckedChanged += new System.EventHandler(this.radioButtonTodos_CheckedChanged);
            // 
            // buttonGerar
            // 
            this.buttonGerar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGerar.Location = new System.Drawing.Point(512, 57);
            this.buttonGerar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGerar.Name = "buttonGerar";
            this.buttonGerar.Size = new System.Drawing.Size(162, 56);
            this.buttonGerar.TabIndex = 4;
            this.buttonGerar.Text = "Gerar Cobranças";
            this.buttonGerar.UseVisualStyleBackColor = true;
            this.buttonGerar.Click += new System.EventHandler(this.buttonGerar_Click);
            // 
            // labelFolder
            // 
            this.labelFolder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelFolder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFolder.Location = new System.Drawing.Point(217, 181);
            this.labelFolder.Name = "labelFolder";
            this.labelFolder.Size = new System.Drawing.Size(419, 28);
            this.labelFolder.TabIndex = 5;
            this.labelFolder.Text = "label1";
            // 
            // buttonFolder
            // 
            this.buttonFolder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFolder.Location = new System.Drawing.Point(642, 204);
            this.buttonFolder.Name = "buttonFolder";
            this.buttonFolder.Size = new System.Drawing.Size(35, 28);
            this.buttonFolder.TabIndex = 6;
            this.buttonFolder.Text = "...";
            this.buttonFolder.UseVisualStyleBackColor = true;
            this.buttonFolder.Click += new System.EventHandler(this.buttonFolder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonSalvar);
            this.groupBox1.Controls.Add(this.radioButtonEnviar);
            this.groupBox1.Controls.Add(this.radioButtonEnviarDeletar);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(207, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 105);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ação";
            // 
            // radioButtonSalvar
            // 
            this.radioButtonSalvar.AutoSize = true;
            this.radioButtonSalvar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSalvar.Location = new System.Drawing.Point(18, 75);
            this.radioButtonSalvar.Name = "radioButtonSalvar";
            this.radioButtonSalvar.Size = new System.Drawing.Size(71, 25);
            this.radioButtonSalvar.TabIndex = 2;
            this.radioButtonSalvar.TabStop = true;
            this.radioButtonSalvar.Text = "Salvar";
            this.radioButtonSalvar.UseVisualStyleBackColor = true;
            // 
            // radioButtonEnviar
            // 
            this.radioButtonEnviar.AutoSize = true;
            this.radioButtonEnviar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonEnviar.Location = new System.Drawing.Point(18, 50);
            this.radioButtonEnviar.Name = "radioButtonEnviar";
            this.radioButtonEnviar.Size = new System.Drawing.Size(71, 25);
            this.radioButtonEnviar.TabIndex = 1;
            this.radioButtonEnviar.TabStop = true;
            this.radioButtonEnviar.Text = "Enviar";
            this.radioButtonEnviar.UseVisualStyleBackColor = true;
            // 
            // radioButtonEnviarDeletar
            // 
            this.radioButtonEnviarDeletar.AutoSize = true;
            this.radioButtonEnviarDeletar.Checked = true;
            this.radioButtonEnviarDeletar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonEnviarDeletar.Location = new System.Drawing.Point(18, 25);
            this.radioButtonEnviarDeletar.Name = "radioButtonEnviarDeletar";
            this.radioButtonEnviarDeletar.Size = new System.Drawing.Size(135, 25);
            this.radioButtonEnviarDeletar.TabIndex = 0;
            this.radioButtonEnviarDeletar.TabStop = true;
            this.radioButtonEnviarDeletar.Text = "Enviar e deletar";
            this.radioButtonEnviarDeletar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Salvar em:";
            // 
            // labelAssunto
            // 
            this.labelAssunto.AutoSize = true;
            this.labelAssunto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAssunto.Location = new System.Drawing.Point(213, 227);
            this.labelAssunto.Name = "labelAssunto";
            this.labelAssunto.Size = new System.Drawing.Size(69, 21);
            this.labelAssunto.TabIndex = 9;
            this.labelAssunto.Text = "Assunto:";
            // 
            // textBoxAssunto
            // 
            this.textBoxAssunto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAssunto.Location = new System.Drawing.Point(217, 248);
            this.textBoxAssunto.Name = "textBoxAssunto";
            this.textBoxAssunto.Size = new System.Drawing.Size(457, 29);
            this.textBoxAssunto.TabIndex = 10;
            this.textBoxAssunto.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxAssunto_Validating);
            // 
            // textBoxBody
            // 
            this.textBoxBody.AcceptsReturn = true;
            this.textBoxBody.AcceptsTab = true;
            this.textBoxBody.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBody.Location = new System.Drawing.Point(18, 294);
            this.textBoxBody.Multiline = true;
            this.textBoxBody.Name = "textBoxBody";
            this.textBoxBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxBody.Size = new System.Drawing.Size(656, 164);
            this.textBoxBody.TabIndex = 12;
            // 
            // labelTexto
            // 
            this.labelTexto.AutoSize = true;
            this.labelTexto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTexto.Location = new System.Drawing.Point(14, 273);
            this.labelTexto.Name = "labelTexto";
            this.labelTexto.Size = new System.Drawing.Size(48, 21);
            this.labelTexto.TabIndex = 13;
            this.labelTexto.Text = "Texto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 465);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(528, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "[Saudacao]     [Descricao]     [Nome]      [Valor]     [s]   - plural qdo mais de" +
    " 1 recibo";
            // 
            // checkBoxIncluirCobrancasAnteriores
            // 
            this.checkBoxIncluirCobrancasAnteriores.AutoSize = true;
            this.checkBoxIncluirCobrancasAnteriores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIncluirCobrancasAnteriores.Location = new System.Drawing.Point(225, 14);
            this.checkBoxIncluirCobrancasAnteriores.Name = "checkBoxIncluirCobrancasAnteriores";
            this.checkBoxIncluirCobrancasAnteriores.Size = new System.Drawing.Size(220, 25);
            this.checkBoxIncluirCobrancasAnteriores.TabIndex = 15;
            this.checkBoxIncluirCobrancasAnteriores.Text = "Incluir cobranças anteriores";
            this.checkBoxIncluirCobrancasAnteriores.UseVisualStyleBackColor = true;
            this.checkBoxIncluirCobrancasAnteriores.CheckedChanged += new System.EventHandler(this.checkBoxIncluirCobrancasAnteriores_CheckedChanged);
            // 
            // frmCobrancaEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 505);
            this.Controls.Add(this.checkBoxIncluirCobrancasAnteriores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTexto);
            this.Controls.Add(this.textBoxBody);
            this.Controls.Add(this.textBoxAssunto);
            this.Controls.Add(this.labelAssunto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonFolder);
            this.Controls.Add(this.labelFolder);
            this.Controls.Add(this.buttonGerar);
            this.Controls.Add(this.radioButtonSelecionados);
            this.Controls.Add(this.radioButtonTodos);
            this.Controls.Add(this.listBoxNomes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmCobrancaEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cobranças por E-Mail";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCobrancaEmail_FormClosing);
            this.Load += new System.EventHandler(this.frmCobrancaEmail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxNomes;
        private System.Windows.Forms.RadioButton radioButtonTodos;
        private System.Windows.Forms.RadioButton radioButtonSelecionados;
        private System.Windows.Forms.Button buttonGerar;
        private System.Windows.Forms.Label labelFolder;
        private System.Windows.Forms.Button buttonFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonSalvar;
        private System.Windows.Forms.RadioButton radioButtonEnviar;
        private System.Windows.Forms.RadioButton radioButtonEnviarDeletar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAssunto;
        private System.Windows.Forms.TextBox textBoxAssunto;
        private System.Windows.Forms.TextBox textBoxBody;
        private System.Windows.Forms.Label labelTexto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxIncluirCobrancasAnteriores;
    }
}