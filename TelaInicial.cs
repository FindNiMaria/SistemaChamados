using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.IO;
using System.Drawing.Printing;


namespace SistemaChamados
{
    public partial class TelaInicial : Form
    {
        private string usuario;
        public TelaInicial(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            AttListViewCham();
        }

        private void uSUÁRIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Cadastro cad = new Cadastro();
            cad.ShowDialog();
            this.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nOVOCHAMADOToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CadChamado cadch = new CadChamado(usuario);
            cadch.ShowDialog();
        }

        private void LvlAbertos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void AttListViewCham()
        {
            LvlAbertos.Items.Clear();
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            connection.OpenConnection();
            sqlCommand.Connection = connection.ReturnConnection();

            sqlCommand.CommandText = "SELECT * FROM CHAMADOS";

            try
            {
                SqlDataReader dr = sqlCommand.ExecuteReader();

                while (dr.Read())
                {

                    string descricao = (string)dr["descricao_chamado"];
                    string usuario = (string)dr["usuario_chamado"];
                    string prioridade = (string)dr["prioridade_chamado"];
                    DateTime data;
                    DateTime.TryParse(dr["data_chamado"].ToString(), out data);
                    int id = (int)dr["id_chamado"];




                    ListViewItem lv = new ListViewItem(id.ToString());
                    LvlAbertos.Items.Add(lv);

                    lv.SubItems.Add(descricao);
                    lv.SubItems.Add(usuario);
                    lv.SubItems.Add(prioridade);
                    lv.SubItems.Add(data.ToString());


                }
                dr.Close();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                connection.CloseConnection();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void eDITARCHAMADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            EdtCham editar = new EdtCham();
            editar.ShowDialog();

        }

        private void eXCLUIRCHAMADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExcChamado excluir = new ExcChamado();
            excluir.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            connection.OpenConnection();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"SELECT * FROM chamados WHERE usuario_chamado = @usuario";

            sqlCommand.Parameters.AddWithValue("@usuario", TxbNomeUser.Text);

            try
            {
                LvlAbertos.Items.Clear();
                SqlDataReader dr = sqlCommand.ExecuteReader();

                while (dr.Read())
                {
                    string descricao = (string)dr["descricao_chamado"];
                    string usuario = (string)dr["usuario_chamado"];
                    string prioridade = (string)dr["prioridade_chamado"];
                    DateTime data;
                    DateTime.TryParse(dr["data_chamado"].ToString(), out data);
                    int id = (int)dr["id_chamado"];


                    ListViewItem lv = new ListViewItem(id.ToString());
                    LvlAbertos.Items.Add(lv);
                    lv.SubItems.Add(descricao);
                    lv.SubItems.Add(usuario);
                    lv.SubItems.Add(prioridade);
                    lv.SubItems.Add(data.ToString());


                }
                dr.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                connection.CloseConnection();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rELATORIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void DesenharRelatorio(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font fonte = new Font("Arial", 12);
            float linhaAtual = 20;
            DataTable dados = null;

            Connection connection = new Connection();
            connection.OpenConnection();
            string query = "SELECT * FROM funcionario";

            
            dados = ExecuteQueryAndGetDataTable(query);

            if (dados != null && dados.Rows.Count > 0)
            {
                foreach (DataRow row in dados.Rows)
                {
                    g.DrawString($"Nome: {row["nome_funcionario"]}", fonte, Brushes.Black, new PointF(100, linhaAtual));
                    linhaAtual += 20;

                    g.DrawString($"UserName: {row["login_funcionario"]}", fonte, Brushes.Black, new PointF(100, linhaAtual));
                    linhaAtual += 20;

                    g.DrawString($"Email: {row["email_funcionario"]}", fonte, Brushes.Black, new PointF(100, linhaAtual));
                    linhaAtual += 20;

                    g.DrawString($"telefone: {row["telefone_funcionario"]}", fonte, Brushes.Black, new PointF(100, linhaAtual));
                    linhaAtual += 20;
                }
            }
            else
            {
                MessageBox.Show(
                    "Nenhum dado encontrado na tabela funcionario", "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }

            connection.CloseConnection(); 
        }

        private DataTable ExecuteQueryAndGetDataTable(string query)
        {
            
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection("Data Source=NICOLE-PC;Initial Catalog=SIST_CHAMOU;Integrated Security=True;Encrypt=False"))
            {
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

        private void rELATORIODEUSERSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(this.DesenharRelatorio);

            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            previewDialog.Document = pd;
            previewDialog.ShowDialog();
        }
    }
}
    

