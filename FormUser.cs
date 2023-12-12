using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaChamados
{
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void llbsair_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string usuario = txblogin.Text;
            string senha = txbsenha.Text;

            if (AutUser(usuario, senha))
            {
                MessageBox.Show("Login bem-sucedido!");
                this.Hide();
                TelaInicial Inicio = new TelaInicial(usuario);
                
                Inicio.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nome de usuário ou senha incorretos.");
            }
            
            

        }
        private bool AutUser(string usuario, string senha)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            connection.OpenConnection();


            sqlCommand.Connection = connection.ReturnConnection();


            sqlCommand.CommandText = "SELECT * FROM funcionario WHERE login_funcionario = @Usuario AND senha_funcionario = @Senha";

            sqlCommand.Parameters.AddWithValue("@Usuario", usuario);
            sqlCommand.Parameters.AddWithValue("@Senha", senha);
                
                try
                    {
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    return reader.HasRows;
                    }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }

        private void txblogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
