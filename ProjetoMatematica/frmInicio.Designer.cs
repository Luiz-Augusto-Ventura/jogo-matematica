namespace ProjetoMatematica
{
    partial class frmInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuJogos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMatematica = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuJogos,
            this.mnuSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuJogos
            // 
            this.mnuJogos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMatematica});
            this.mnuJogos.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuJogos.ForeColor = System.Drawing.Color.LimeGreen;
            this.mnuJogos.Name = "mnuJogos";
            this.mnuJogos.Size = new System.Drawing.Size(89, 31);
            this.mnuJogos.Text = "Jogos";
            // 
            // mnuMatematica
            // 
            this.mnuMatematica.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuMatematica.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.mnuMatematica.Name = "mnuMatematica";
            this.mnuMatematica.Size = new System.Drawing.Size(186, 24);
            this.mnuMatematica.Text = "Matemática";
            this.mnuMatematica.Click += new System.EventHandler(this.matemáticaToolStripMenuItem_Click);
            // 
            // mnuSair
            // 
            this.mnuSair.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuSair.ForeColor = System.Drawing.Color.Red;
            this.mnuSair.Name = "mnuSair";
            this.mnuSair.Size = new System.Drawing.Size(69, 31);
            this.mnuSair.Text = "Sair";
            this.mnuSair.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmInicio";
            this.Text = "Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem mnuSair;
        private System.Windows.Forms.ToolStripMenuItem mnuMatematica;
        private System.Windows.Forms.ToolStripMenuItem mnuJogos;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}