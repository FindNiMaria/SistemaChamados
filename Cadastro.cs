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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }
        public  void attListView()
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            connection.OpenConnection();
            sqlCommand.Connection = connection.ReturnConnection();

            sqlCommand.CommandText = "SELET * FROM funcionrio";


        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            connection.OpenConnection();

            sqlCommand.Connection = connection.ReturnConnection();

            sqlCommand.CommandText = "INSERT INTO funcionario (login_funcionario, nome_funcionario, telefone_funcionario, email_funcionario, senha_funcionario) VALUES (@login ,@nome , @Telefone, @Email, @Senha)";  
            sqlCommand.Parameters.AddWithValue("@login", txbLoginFunc.Text);
            sqlCommand.Parameters.AddWithValue("@nome", txbNomeFunc.Text);
            sqlCommand.Parameters.AddWithValue("@telefone", txbTelFunc.Text);
            sqlCommand.Parameters.AddWithValue("@email", txbEmailFunc.Text);
            sqlCommand.Parameters.AddWithValue("@senha", txbSenhaFunc.Text);
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


             }
        }

        private void btnSairFunc_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaInicial Inicio = new TelaInicial();
            Inicio.ShowDialog();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
