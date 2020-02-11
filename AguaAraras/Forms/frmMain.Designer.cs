namespace AguaAraras {
    partial class frmMain {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonPessoas = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRecibos = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonMovimentos = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBalanco = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCalculadora = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonConfig = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonPessoas,
            this.toolStripButtonRecibos,
            this.toolStripButtonMovimentos,
            this.toolStripButtonBalanco,
            this.toolStripButtonCalculadora,
            this.toolStripButtonConfig});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1164, 43);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonPessoas
            // 
            this.toolStripButtonPessoas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPessoas.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPessoas.Image")));
            this.toolStripButtonPessoas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPessoas.Name = "toolStripButtonPessoas";
            this.toolStripButtonPessoas.Size = new System.Drawing.Size(40, 40);
            this.toolStripButtonPessoas.Text = "Pessoas";
            this.toolStripButtonPessoas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonPessoas.Click += new System.EventHandler(this.toolStripButtonPessoas_Click);
            // 
            // toolStripButtonRecibos
            // 
            this.toolStripButtonRecibos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRecibos.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRecibos.Image")));
            this.toolStripButtonRecibos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRecibos.Name = "toolStripButtonRecibos";
            this.toolStripButtonRecibos.Size = new System.Drawing.Size(40, 40);
            this.toolStripButtonRecibos.Text = "Recibos";
            this.toolStripButtonRecibos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonRecibos.Click += new System.EventHandler(this.toolStripButtonRecibos_Click);
            // 
            // toolStripButtonMovimentos
            // 
            this.toolStripButtonMovimentos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonMovimentos.Image = global::AguaAraras.Properties.Resources.File_spreadsheet_icon;
            this.toolStripButtonMovimentos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMovimentos.Name = "toolStripButtonMovimentos";
            this.toolStripButtonMovimentos.Size = new System.Drawing.Size(40, 40);
            this.toolStripButtonMovimentos.Text = "Movimentos";
            this.toolStripButtonMovimentos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonMovimentos.Click += new System.EventHandler(this.toolStripButtonMovimentos_Click);
            // 
            // toolStripButtonBalanco
            // 
            this.toolStripButtonBalanco.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBalanco.Image = global::AguaAraras.Properties.Resources.Chart_icon;
            this.toolStripButtonBalanco.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBalanco.Name = "toolStripButtonBalanco";
            this.toolStripButtonBalanco.Size = new System.Drawing.Size(40, 40);
            this.toolStripButtonBalanco.Text = "Balanço";
            this.toolStripButtonBalanco.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonBalanco.Click += new System.EventHandler(this.toolStripButtonExtrato_Click);
            // 
            // toolStripButtonCalculadora
            // 
            this.toolStripButtonCalculadora.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCalculadora.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCalculadora.Image")));
            this.toolStripButtonCalculadora.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCalculadora.Name = "toolStripButtonCalculadora";
            this.toolStripButtonCalculadora.Size = new System.Drawing.Size(40, 40);
            this.toolStripButtonCalculadora.Text = "Calculadora";
            this.toolStripButtonCalculadora.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonCalculadora.Click += new System.EventHandler(this.toolStripButtonCalculadora_Click);
            // 
            // toolStripButtonConfig
            // 
            this.toolStripButtonConfig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonConfig.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonConfig.Image")));
            this.toolStripButtonConfig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonConfig.Name = "toolStripButtonConfig";
            this.toolStripButtonConfig.Size = new System.Drawing.Size(40, 40);
            this.toolStripButtonConfig.Text = "Configuração";
            this.toolStripButtonConfig.Click += new System.EventHandler(this.toolStripButtonConfig_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1164, 681);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Text = "Água Araras";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonPessoas;
        private System.Windows.Forms.ToolStripButton toolStripButtonRecibos;
        private System.Windows.Forms.ToolStripButton toolStripButtonMovimentos;
        private System.Windows.Forms.ToolStripButton toolStripButtonBalanco;
        private System.Windows.Forms.ToolStripButton toolStripButtonCalculadora;
        private System.Windows.Forms.ToolStripButton toolStripButtonConfig;
    }
}

