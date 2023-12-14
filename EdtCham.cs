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
    public partial class EdtCham : Form
    {
        public EdtCham()
        {
            InitializeComponent();
            LvEdtCham.MouseDoubleClick += LvEdtCham_MouseDoubleClick;
            AttListViewCham();
            
        }
        private void LvEdtCham_MouseDoubleClick(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            connection.OpenConnection();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"SELECT * FROM chamados WHERE id_chamado = @id";

            sqlCommand.Parameters.AddWithValue("@id", int.Parse(LvEdtCham.SelectedItems[0].Text));
            try
            {
                SqlDataReader dr = sqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    int id = (int)dr["id_chamado"];
                    string descricao = (string)dr["descricao_chamado"];
                    string prioridade = (string)dr["prioridade_chamado"];

                    txbDesCham.Text = descricao;
                    CbxPrioridade.Text = prioridade;
                    

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void lvEdtCham_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void AttListViewCham()
        {
            LvEdtCham.Items.Clear();
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
                    LvEdtCham.Items.Add(lv);
                    lv.SubItems.Add(descricao);
                    lv.SubItems.Add(prioridade);
                    lv.SubItems.Add(data.ToString());
                    lv.SubItems.Add(usuario);

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

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            connection.OpenConnection();

            sqlCommand.Connection = connection.ReturnConnection();

            sqlCommand.CommandText = @"UPDATE CHAMADOS SET descricao_chamado = @descricao,
                                              prioridade_chamado = @prioridade
                                    WHERE id_chamado = @id";
            sqlCommand.Parameters.AddWithValue("@id", int.Parse(LvEdtCham.SelectedItems[0].Text));
            sqlCommand.Parameters.AddWithValue("@descricao", txbDesCham.Text);
            sqlCommand.Parameters.AddWithValue("@prioridade", CbxPrioridade.Text);
            
           

            try
            {
                sqlCommand.ExecuteNonQuery();

                AttListViewCham();

                MessageBox.Show("Atualizado com Sucesso", "CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.CloseConnection();
            }
        }
    }
}
