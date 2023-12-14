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
    public partial class CadChamado : Form
    {
        private string usuario;
        public CadChamado(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            
        }

        private void lblTelefoneFunc_Click(object sender, EventArgs e)
        {

        }

        private void btnSairFunc_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
        private bool ValidaCampos()
        {
            if (string.IsNullOrEmpty(txbDesCham.Text) || string.IsNullOrEmpty(CbxPrioridade.Text))
                {
                MessageBox.Show("Por Favor preencha todos os campos.");
                return false;
            }
            return true;
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(!ValidaCampos())
            {
                return;
            }

            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            connection.OpenConnection();

            sqlCommand.Connection = connection.ReturnConnection();

            sqlCommand.CommandText = "INSERT INTO CHAMADOS (descricao_chamado, prioridade_chamado, usuario_chamado, data_chamado) VALUES (@descricao, @prioridade, @usuario, @data)";
            sqlCommand.Parameters.AddWithValue("@descricao", txbDesCham.Text);
            sqlCommand.Parameters.AddWithValue("@usuario", usuario);
            sqlCommand.Parameters.AddWithValue("@prioridade", CbxPrioridade.Text);
            sqlCommand.Parameters.AddWithValue("@data", DateTime.Now);
            
            try
            {

                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Inserção realizada com sucesso!");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro" + ex.Message);
            }
            finally
            {
                connection.CloseConnection();
                txbDesCham.Clear();
                CbxPrioridade.SelectedIndex = -1;
            }
        }

        private void LvPrioridade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
