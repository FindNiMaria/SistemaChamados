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
    public partial class ExcChamado : Form
    {
        public ExcChamado()
        {
            InitializeComponent();
            AttListViewCham();
        }
        private void AttListViewCham()
        {
            LvExcCham.Items.Clear();
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
                    int id = (int)dr["id_chamado"];
                    string descricao = (string)dr["descricao_chamado"];
                    string usuario = (string)dr["usuario_chamado"];
                    string prioridade = (string)dr["prioridade_chamado"];
                    DateTime data;
                    DateTime.TryParse(dr["data_chamado"].ToString(), out data);
                    


                    ListViewItem lv = new ListViewItem(id.ToString());
                    LvExcCham.Items.Add(lv);
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
        private void LvExcCham_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnExcCham_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            connection.OpenConnection();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"DELETE FROM CHAMADOS WHERE id_chamado = @id";

            sqlCommand.Parameters.AddWithValue("@id", int.Parse(LvExcCham.SelectedItems[0].Text));

            try
            {
                //Excluir o cliente
                sqlCommand.ExecuteNonQuery();


                MessageBox.Show(
                "Excluído com Sucesso",
                "CADASTRO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro: Problemas ao excluir usuário no banco.\n"
                    + error.Message);
            }
            finally
            {
                connection.CloseConnection();
            }

            AttListViewCham();
        }
    }
}

