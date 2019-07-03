namespace ProjetoMatematica
{
    partial class frmMatematica
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbOperacoes = new System.Windows.Forms.ComboBox();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.lblOperacoes = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.cmdOk = new System.Windows.Forms.Button();
            this.lblstatus = new System.Windows.Forms.Label();
            this.cmdEncerrar = new System.Windows.Forms.Button();
            this.dtHora = new System.Windows.Forms.DateTimePicker();
            this.cmdRanking = new System.Windows.Forms.Button();
            this.cmdFechar = new System.Windows.Forms.Button();
            this.lbRanking = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDificil = new System.Windows.Forms.RadioButton();
            this.rbFacil = new System.Windows.Forms.RadioButton();
            this.cmdJogar = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome: ";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(77, 14);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(588, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selecione a Operação";
            // 
            // cmbOperacoes
            // 
            this.cmbOperacoes.FormattingEnabled = true;
            this.cmbOperacoes.Items.AddRange(new object[] {
            "Adição",
            "Subtração",
            "Multiplicação",
            "Divisão"});
            this.cmbOperacoes.Location = new System.Drawing.Point(132, 71);
            this.cmbOperacoes.Name = "cmbOperacoes";
            this.cmbOperacoes.Size = new System.Drawing.Size(177, 21);
            this.cmbOperacoes.TabIndex = 4;
            // 
            // picFoto
            // 
            this.picFoto.Image = global::ProjetoMatematica.Properties.Resources.matematica;
            this.picFoto.Location = new System.Drawing.Point(395, 91);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(270, 252);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFoto.TabIndex = 6;
            this.picFoto.TabStop = false;
            // 
            // lblOperacoes
            // 
            this.lblOperacoes.AutoSize = true;
            this.lblOperacoes.Location = new System.Drawing.Point(9, 349);
            this.lblOperacoes.Name = "lblOperacoes";
            this.lblOperacoes.Size = new System.Drawing.Size(57, 13);
            this.lblOperacoes.TabIndex = 8;
            this.lblOperacoes.Text = "Operação:";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(74, 345);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 9;
            // 
            // cmdOk
            // 
            this.cmdOk.Location = new System.Drawing.Point(189, 343);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(75, 23);
            this.cmdOk.TabIndex = 10;
            this.cmdOk.Text = "OK";
            this.cmdOk.UseVisualStyleBackColor = true;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Location = new System.Drawing.Point(9, 389);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(37, 13);
            this.lblstatus.TabIndex = 11;
            this.lblstatus.Text = "Status";
            // 
            // cmdEncerrar
            // 
            this.cmdEncerrar.Location = new System.Drawing.Point(12, 419);
            this.cmdEncerrar.Name = "cmdEncerrar";
            this.cmdEncerrar.Size = new System.Drawing.Size(200, 28);
            this.cmdEncerrar.TabIndex = 12;
            this.cmdEncerrar.Text = "Encerrar a partida";
            this.cmdEncerrar.UseVisualStyleBackColor = true;
            this.cmdEncerrar.Click += new System.EventHandler(this.cmdEncerrar_Click);
            // 
            // dtHora
            // 
            this.dtHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHora.Location = new System.Drawing.Point(395, 65);
            this.dtHora.Name = "dtHora";
            this.dtHora.Size = new System.Drawing.Size(270, 20);
            this.dtHora.TabIndex = 13;
            // 
            // cmdRanking
            // 
            this.cmdRanking.Location = new System.Drawing.Point(680, 12);
            this.cmdRanking.Name = "cmdRanking";
            this.cmdRanking.Size = new System.Drawing.Size(203, 23);
            this.cmdRanking.TabIndex = 14;
            this.cmdRanking.Text = "Ranking";
            this.cmdRanking.UseVisualStyleBackColor = true;
            this.cmdRanking.Click += new System.EventHandler(this.cmdRanking_Click);
            // 
            // cmdFechar
            // 
            this.cmdFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFechar.ForeColor = System.Drawing.Color.Maroon;
            this.cmdFechar.Location = new System.Drawing.Point(395, 389);
            this.cmdFechar.Name = "cmdFechar";
            this.cmdFechar.Size = new System.Drawing.Size(270, 58);
            this.cmdFechar.TabIndex = 15;
            this.cmdFechar.Text = "Fechar";
            this.cmdFechar.UseVisualStyleBackColor = true;
            this.cmdFechar.Click += new System.EventHandler(this.cmdFechar_Click);
            // 
            // lbRanking
            // 
            this.lbRanking.FormattingEnabled = true;
            this.lbRanking.Location = new System.Drawing.Point(680, 66);
            this.lbRanking.Name = "lbRanking";
            this.lbRanking.Size = new System.Drawing.Size(203, 381);
            this.lbRanking.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDificil);
            this.groupBox1.Controls.Add(this.rbFacil);
            this.groupBox1.Location = new System.Drawing.Point(12, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dificuldade";
            // 
            // rbDificil
            // 
            this.rbDificil.AutoSize = true;
            this.rbDificil.Location = new System.Drawing.Point(16, 63);
            this.rbDificil.Name = "rbDificil";
            this.rbDificil.Size = new System.Drawing.Size(52, 17);
            this.rbDificil.TabIndex = 1;
            this.rbDificil.Text = "Difícil";
            this.rbDificil.UseVisualStyleBackColor = true;
            // 
            // rbFacil
            // 
            this.rbFacil.AutoSize = true;
            this.rbFacil.Checked = true;
            this.rbFacil.Location = new System.Drawing.Point(16, 30);
            this.rbFacil.Name = "rbFacil";
            this.rbFacil.Size = new System.Drawing.Size(47, 17);
            this.rbFacil.TabIndex = 0;
            this.rbFacil.TabStop = true;
            this.rbFacil.Text = "Fácil";
            this.rbFacil.UseVisualStyleBackColor = true;
            // 
            // cmdJogar
            // 
            this.cmdJogar.Location = new System.Drawing.Point(12, 260);
            this.cmdJogar.Name = "cmdJogar";
            this.cmdJogar.Size = new System.Drawing.Size(200, 45);
            this.cmdJogar.TabIndex = 19;
            this.cmdJogar.Text = "Jogar";
            this.cmdJogar.UseVisualStyleBackColor = true;
            this.cmdJogar.Click += new System.EventHandler(this.cmdJogar_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // frmMatematica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 470);
            this.Controls.Add(this.cmdJogar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbRanking);
            this.Controls.Add(this.cmdFechar);
            this.Controls.Add(this.cmdRanking);
            this.Controls.Add(this.dtHora);
            this.Controls.Add(this.cmdEncerrar);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.cmdOk);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblOperacoes);
            this.Controls.Add(this.picFoto);
            this.Controls.Add(this.cmbOperacoes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "frmMatematica";
            this.Text = "Jogo da Matemática";
            this.Load += new System.EventHandler(this.frmMatematica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbOperacoes;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.Label lblOperacoes;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button cmdOk;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Button cmdEncerrar;
        private System.Windows.Forms.DateTimePicker dtHora;
        private System.Windows.Forms.Button cmdRanking;
        private System.Windows.Forms.Button cmdFechar;
        private System.Windows.Forms.ListBox lbRanking;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDificil;
        private System.Windows.Forms.RadioButton rbFacil;
        private System.Windows.Forms.Button cmdJogar;
        private System.Windows.Forms.Timer timer;
    }
}

