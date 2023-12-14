namespace SistemaChamados
{
    partial class FormUser
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUser));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbllogin = new System.Windows.Forms.Label();
            this.txblogin = new System.Windows.Forms.TextBox();
            this.txbsenha = new System.Windows.Forms.TextBox();
            this.lblsenha = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.llbsair = new System.Windows.Forms.LinkLabel();
            this.lblinfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(82, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chamou";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.ForeColor = System.Drawing.Color.Gray;
            this.lbllogin.Location = new System.Drawing.Point(46, 260);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(33, 13);
            this.lbllogin.TabIndex = 3;
            this.lbllogin.Text = "Login";
            // 
            // txblogin
            // 
            this.txblogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txblogin.ForeColor = System.Drawing.Color.Silver;
            this.txblogin.Location = new System.Drawing.Point(49, 276);
            this.txblogin.Name = "txblogin";
            this.txblogin.Size = new System.Drawing.Size(328, 13);
            this.txblogin.TabIndex = 4;
            this.txblogin.TextChanged += new System.EventHandler(this.txblogin_TextChanged);
            // 
            // txbsenha
            // 
            this.txbsenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbsenha.ForeColor = System.Drawing.Color.Silver;
            this.txbsenha.Location = new System.Drawing.Point(49, 329);
            this.txbsenha.Name = "txbsenha";
            this.txbsenha.PasswordChar = '*';
            this.txbsenha.Size = new System.Drawing.Size(328, 13);
            this.txbsenha.TabIndex = 6;
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.ForeColor = System.Drawing.Color.Gray;
            this.lblsenha.Location = new System.Drawing.Point(46, 313);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(38, 13);
            this.lblsenha.TabIndex = 5;
            this.lblsenha.Text = "Senha";
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnlogin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnlogin.Location = new System.Drawing.Point(302, 374);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 33);
            this.btnlogin.TabIndex = 7;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // llbsair
            // 
            this.llbsair.AutoSize = true;
            this.llbsair.LinkColor = System.Drawing.Color.DarkGray;
            this.llbsair.Location = new System.Drawing.Point(54, 384);
            this.llbsair.Name = "llbsair";
            this.llbsair.Size = new System.Drawing.Size(25, 13);
            this.llbsair.TabIndex = 8;
            this.llbsair.TabStop = true;
            this.llbsair.Text = "Sair";
            this.llbsair.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbsair_LinkClicked);
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.ForeColor = System.Drawing.Color.Gray;
            this.lblinfo.Location = new System.Drawing.Point(13, 631);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(212, 13);
            this.lblinfo.TabIndex = 9;
            this.lblinfo.Text = "Nicole Maria da Silva Candido , CJ3001008";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(43, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "______________________________________________________";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(508, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(719, 658);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(43, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(331, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "______________________________________________________";
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1222, 656);
            this.Controls.Add(this.lblinfo);
            this.Controls.Add(this.llbsair);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txbsenha);
            this.Controls.Add(this.lblsenha);
            this.Controls.Add(this.txblogin);
            this.Controls.Add(this.lbllogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.TextBox txblogin;
        private System.Windows.Forms.TextBox txbsenha;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.LinkLabel llbsair;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}

