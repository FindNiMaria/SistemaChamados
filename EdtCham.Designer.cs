namespace SistemaChamados
{
    partial class EdtCham
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
            this.LvEdtCham = new System.Windows.Forms.ListView();
            this.CbxPrioridade = new System.Windows.Forms.ComboBox();
            this.lblTelefoneFunc = new System.Windows.Forms.Label();
            this.txbDesCham = new System.Windows.Forms.TextBox();
            this.lblNomeFunc = new System.Windows.Forms.Label();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prioridade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataAbert = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Usuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // LvEdtCham
            // 
            this.LvEdtCham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Descricao,
            this.Prioridade,
            this.DataAbert,
            this.Usuario});
            this.LvEdtCham.FullRowSelect = true;
            this.LvEdtCham.HideSelection = false;
            this.LvEdtCham.Location = new System.Drawing.Point(12, 12);
            this.LvEdtCham.Name = "LvEdtCham";
            this.LvEdtCham.Size = new System.Drawing.Size(776, 247);
            this.LvEdtCham.TabIndex = 0;
            this.LvEdtCham.UseCompatibleStateImageBehavior = false;
            this.LvEdtCham.View = System.Windows.Forms.View.Details;
            this.LvEdtCham.SelectedIndexChanged += new System.EventHandler(this.lvEdtCham_SelectedIndexChanged);
            // 
            // CbxPrioridade
            // 
            this.CbxPrioridade.FormattingEnabled = true;
            this.CbxPrioridade.Items.AddRange(new object[] {
            "URGENTE",
            "ALTA",
            "MEDIA",
            "BAIXA"});
            this.CbxPrioridade.Location = new System.Drawing.Point(12, 437);
            this.CbxPrioridade.Name = "CbxPrioridade";
            this.CbxPrioridade.Size = new System.Drawing.Size(215, 21);
            this.CbxPrioridade.TabIndex = 28;
            // 
            // lblTelefoneFunc
            // 
            this.lblTelefoneFunc.AutoSize = true;
            this.lblTelefoneFunc.Location = new System.Drawing.Point(9, 421);
            this.lblTelefoneFunc.Name = "lblTelefoneFunc";
            this.lblTelefoneFunc.Size = new System.Drawing.Size(54, 13);
            this.lblTelefoneFunc.TabIndex = 27;
            this.lblTelefoneFunc.Text = "Prioridade";
            // 
            // txbDesCham
            // 
            this.txbDesCham.Location = new System.Drawing.Point(12, 284);
            this.txbDesCham.Multiline = true;
            this.txbDesCham.Name = "txbDesCham";
            this.txbDesCham.Size = new System.Drawing.Size(541, 123);
            this.txbDesCham.TabIndex = 26;
            // 
            // lblNomeFunc
            // 
            this.lblNomeFunc.AutoSize = true;
            this.lblNomeFunc.Location = new System.Drawing.Point(9, 268);
            this.lblNomeFunc.Name = "lblNomeFunc";
            this.lblNomeFunc.Size = new System.Drawing.Size(58, 13);
            this.lblNomeFunc.TabIndex = 25;
            this.lblNomeFunc.Text = "Descrição ";
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(713, 456);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(75, 23);
            this.BtnEditar.TabIndex = 29;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Descricao
            // 
            this.Descricao.Text = "Descrição";
            // 
            // Prioridade
            // 
            this.Prioridade.Text = "Prioridade";
            // 
            // DataAbert
            // 
            this.DataAbert.Text = "Data de Abertura";
            // 
            // Usuario
            // 
            this.Usuario.Text = "Usuario";
            // 
            // EdtCham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.CbxPrioridade);
            this.Controls.Add(this.lblTelefoneFunc);
            this.Controls.Add(this.txbDesCham);
            this.Controls.Add(this.lblNomeFunc);
            this.Controls.Add(this.LvEdtCham);
            this.Name = "EdtCham";
            this.Text = "EdtCham";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LvEdtCham;
        private System.Windows.Forms.ComboBox CbxPrioridade;
        private System.Windows.Forms.Label lblTelefoneFunc;
        private System.Windows.Forms.TextBox txbDesCham;
        private System.Windows.Forms.Label lblNomeFunc;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Descricao;
        private System.Windows.Forms.ColumnHeader Prioridade;
        private System.Windows.Forms.ColumnHeader DataAbert;
        private System.Windows.Forms.ColumnHeader Usuario;
    }
}