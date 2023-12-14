namespace SistemaChamados
{
    partial class ExcChamado
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
            this.LvExcCham = new System.Windows.Forms.ListView();
            this.BtnExcCham = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // LvExcCham
            // 
            this.LvExcCham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.LvExcCham.FullRowSelect = true;
            this.LvExcCham.HideSelection = false;
            this.LvExcCham.Location = new System.Drawing.Point(12, 12);
            this.LvExcCham.Name = "LvExcCham";
            this.LvExcCham.Size = new System.Drawing.Size(776, 259);
            this.LvExcCham.TabIndex = 0;
            this.LvExcCham.UseCompatibleStateImageBehavior = false;
            this.LvExcCham.View = System.Windows.Forms.View.Details;
            this.LvExcCham.SelectedIndexChanged += new System.EventHandler(this.LvExcCham_SelectedIndexChanged);
            // 
            // BtnExcCham
            // 
            this.BtnExcCham.Location = new System.Drawing.Point(713, 346);
            this.BtnExcCham.Name = "BtnExcCham";
            this.BtnExcCham.Size = new System.Drawing.Size(75, 23);
            this.BtnExcCham.TabIndex = 1;
            this.BtnExcCham.Text = "Excluir";
            this.BtnExcCham.UseVisualStyleBackColor = true;
            this.BtnExcCham.Click += new System.EventHandler(this.BtnExcCham_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Descrição";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prioridade";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Data de Abertura";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Usuario de abertura";
            // 
            // ExcChamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnExcCham);
            this.Controls.Add(this.LvExcCham);
            this.Name = "ExcChamado";
            this.Text = "ExcChamado";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LvExcCham;
        private System.Windows.Forms.Button BtnExcCham;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}