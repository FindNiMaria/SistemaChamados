namespace SistemaChamados
{
    partial class CadChamado
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
            this.btnSairFunc = new System.Windows.Forms.Button();
            this.lblTelefoneFunc = new System.Windows.Forms.Label();
            this.txbDesCham = new System.Windows.Forms.TextBox();
            this.lblNomeFunc = new System.Windows.Forms.Label();
            this.CbxPrioridade = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSairFunc
            // 
            this.btnSairFunc.Location = new System.Drawing.Point(504, 356);
            this.btnSairFunc.Name = "btnSairFunc";
            this.btnSairFunc.Size = new System.Drawing.Size(86, 25);
            this.btnSairFunc.TabIndex = 23;
            this.btnSairFunc.Text = "Sair";
            this.btnSairFunc.UseVisualStyleBackColor = true;
            this.btnSairFunc.Click += new System.EventHandler(this.btnSairFunc_Click);
            // 
            // lblTelefoneFunc
            // 
            this.lblTelefoneFunc.AutoSize = true;
            this.lblTelefoneFunc.Location = new System.Drawing.Point(46, 183);
            this.lblTelefoneFunc.Name = "lblTelefoneFunc";
            this.lblTelefoneFunc.Size = new System.Drawing.Size(54, 13);
            this.lblTelefoneFunc.TabIndex = 16;
            this.lblTelefoneFunc.Text = "Prioridade";
            this.lblTelefoneFunc.Click += new System.EventHandler(this.lblTelefoneFunc_Click);
            // 
            // txbDesCham
            // 
            this.txbDesCham.Location = new System.Drawing.Point(49, 46);
            this.txbDesCham.Multiline = true;
            this.txbDesCham.Name = "txbDesCham";
            this.txbDesCham.Size = new System.Drawing.Size(541, 123);
            this.txbDesCham.TabIndex = 13;
            // 
            // lblNomeFunc
            // 
            this.lblNomeFunc.AutoSize = true;
            this.lblNomeFunc.Location = new System.Drawing.Point(46, 30);
            this.lblNomeFunc.Name = "lblNomeFunc";
            this.lblNomeFunc.Size = new System.Drawing.Size(58, 13);
            this.lblNomeFunc.TabIndex = 12;
            this.lblNomeFunc.Text = "Descrição ";
            // 
            // CbxPrioridade
            // 
            this.CbxPrioridade.FormattingEnabled = true;
            this.CbxPrioridade.Items.AddRange(new object[] {
            "URGENTE",
            "ALTA",
            "MEDIA",
            "BAIXA"});
            this.CbxPrioridade.Location = new System.Drawing.Point(49, 199);
            this.CbxPrioridade.Name = "CbxPrioridade";
            this.CbxPrioridade.Size = new System.Drawing.Size(215, 21);
            this.CbxPrioridade.TabIndex = 24;
            this.CbxPrioridade.SelectedIndexChanged += new System.EventHandler(this.LvPrioridade_SelectedIndexChanged);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(366, 356);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(86, 25);
            this.btnCadastrar.TabIndex = 25;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // CadChamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 450);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.CbxPrioridade);
            this.Controls.Add(this.btnSairFunc);
            this.Controls.Add(this.lblTelefoneFunc);
            this.Controls.Add(this.txbDesCham);
            this.Controls.Add(this.lblNomeFunc);
            this.Name = "CadChamado";
            this.Text = "CadChamado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSairFunc;
        private System.Windows.Forms.Label lblTelefoneFunc;
        private System.Windows.Forms.TextBox txbDesCham;
        private System.Windows.Forms.Label lblNomeFunc;
        private System.Windows.Forms.ComboBox CbxPrioridade;
        private System.Windows.Forms.Button btnCadastrar;
    }
}