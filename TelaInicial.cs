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
                    string data = (string)dr["data_chamado"];
                    int id = (int)dr["id_chamado"];




                    ListViewItem lv = new ListViewItem(id.ToString());
                    LvlAbertos.Items.Add(lv);

                    lv.SubItems.Add(descricao);
                    lv.SubItems.Add(usuario);
                    lv.SubItems.Add(prioridade);
                    lv.SubItems.Add(data);  


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
                    string data = (string)dr["data_chamado"];
                    int id = (int)dr["id_chamado"];


                    ListViewItem lv = new ListViewItem(id.ToString());
                    LvlAbertos.Items.Add(lv);
                    lv.SubItems.Add(descricao);
                    lv.SubItems.Add(usuario);
                    lv.SubItems.Add(prioridade);
                    lv.SubItems.Add(data);


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
    }
}
