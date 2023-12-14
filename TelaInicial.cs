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
        public void GerarRelatorio()
        {
            {
                try
                {
                    // Conexão com o banco de dados
                    Connection connection = new Connection();
                    connection.OpenConnection();

                    // Query SQL para obter dados do banco de dados
                    string query = "SELECT * FROM funcionario";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection.ReturnConnection());
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Configurar o ReportViewer
                    ReportViewer reportViewer = new ReportViewer();
                    reportViewer.ProcessingMode = ProcessingMode.Local;
                    reportViewer.LocalReport.ReportPath = "C:/Users/nicol/Downloads/SistemaChamados-20231213T224619Z-001/SistemaChamados/RelatorioUser.rdlc";

                    if (dataTable.Rows.Count > 0)
                    {
                        reportViewer.LocalReport.DataSources.Clear();
                        ReportDataSource source = new ReportDataSource("SIST_CHAMOUDataSet1", dataTable);
                        reportViewer.LocalReport.DataSources.Add(source);

                        // Refresh the ReportViewer
                        reportViewer.RefreshReport();

                        // Render and save the report as PDF
                        using (FileStream file = new FileStream("C:/Users/nicol/Downloads/ReportViewer.pdf", FileMode.Create))
                        {

                            byte[] pdfBytes = reportViewer.LocalReport.Render("PDF", null, out string mimeType, out string encoding, out string extension, out string[] streams, out Warning[] warnings);

                            file.Write(pdfBytes, 0, pdfBytes.Length);
                        }

                        Console.WriteLine("Relatório gerado com sucesso!");


                        connection.CloseConnection();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao gerar relatório: {ex.Message}");
                }
            }
        }
    

        private void rELATORIODEUSERSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GerarRelatorio();
        }
    }
}
    

