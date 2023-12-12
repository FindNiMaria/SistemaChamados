using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaChamados
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
             LtvList.MouseDoubleClick += LtvList_MouseDoubleClick;
        }
        public void AttListView()
        {
            LtvList.Items.Clear();
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();
            
            connection.OpenConnection();
            sqlCommand.Connection = connection.ReturnConnection();

            sqlCommand.CommandText = "SELECT * FROM funcionario";

            try
            {
                SqlDataReader dr = sqlCommand.ExecuteReader();

                while (dr.Read())
                {
                    int id = (int)dr["id_funcionario"];
                    string login = (string)dr["login_funcionario"];
                    string nome = (string)dr["nome_funcionario"];
                    string telefone = (string)dr["telefone_funcionario"];
                    string email = (string)dr["email_funcionario"];


                    ListViewItem lv = new ListViewItem(id.ToString());
                    LtvList.Items.Add(lv);
                    
                    lv.SubItems.Add(login);
                    lv.SubItems.Add(nome);
                    lv.SubItems.Add(telefone);
                    lv.SubItems.Add(email);

                    
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
                AttListView();
                connection.CloseConnection();


            }
        }

        private void btnSairFunc_Click(object sender, EventArgs e)
        {
            this.Close();
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            AttListView();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            connection.OpenConnection();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"DELETE FROM funcionario WHERE id_funcionario = @id";
            
            sqlCommand.Parameters.AddWithValue("@id", int.Parse(LtvList.SelectedItems[0].Text));

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

            AttListView();
        }

        private void LtvList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPesqFunc_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            connection.OpenConnection();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"SELECT * FROM funcionario WHERE nome_funcionario = @nome";

            sqlCommand.Parameters.AddWithValue("@nome", txbNomeFunc.Text);

            try
            {
                LtvList.Items.Clear();
                SqlDataReader dr = sqlCommand.ExecuteReader();

                while (dr.Read())
                {
                    int id = (int)dr["id_funcionario"];
                    string login = (string)dr["login_funcionario"];
                    string nome = (string)dr["nome_funcionario"];
                    string telefone = (string)dr["telefone_funcionario"];
                    string email = (string)dr["email_funcionario"];


                    ListViewItem lv = new ListViewItem(id.ToString());
                    LtvList.Items.Add(lv);
                    lv.SubItems.Add(login);
                    lv.SubItems.Add(nome);
                    lv.SubItems.Add(telefone);
                    lv.SubItems.Add(email);


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
        
        private void LtvList_MouseDoubleClick(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            connection.OpenConnection();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"SELECT * FROM funcionario WHERE id_funcionario = @id";

            sqlCommand.Parameters.AddWithValue("@id", int.Parse(LtvList.SelectedItems[0].Text));
            try
            {
                SqlDataReader dr = sqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    int id = (int)dr["id_funcionario"];
                    string login = (string)dr["login_funcionario"];
                    string nome = (string)dr["nome_funcionario"];
                    string telefone = (string)dr["telefone_funcionario"];
                    string email = (string)dr["email_funcionario"];
                    string senha = (string)dr["senha_funcionario"];
                    txbLoginFunc.Text = login;
                    txbNomeFunc.Text = nome;
                    txbTelFunc.Text = telefone;
                    txbEmailFunc.Text = email;
                    txbSenhaFunc.Text = senha;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnEditFunc_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            connection.OpenConnection();

            sqlCommand.Connection = connection.ReturnConnection();

            sqlCommand.CommandText = @"UPDATE funcionario SET login_funcionario = @login,
                                              nome_funcionario = @nome, 
                                              telefone_funcionario = @Telefone, 
                                              email_funcionario = @Email, 
                                              senha_funcionario = @Senha
                                     WHERE id_funcionario = @id";


            sqlCommand.Parameters.AddWithValue("@id", int.Parse(LtvList.SelectedItems[0].Text));
            sqlCommand.Parameters.AddWithValue("@nome", txbNomeFunc.Text);
            sqlCommand.Parameters.AddWithValue("@login", txbLoginFunc.Text);
            sqlCommand.Parameters.AddWithValue("@telefone", txbTelFunc.Text);
            sqlCommand.Parameters.AddWithValue("@email", txbEmailFunc.Text);
            sqlCommand.Parameters.AddWithValue("@senha", txbSenhaFunc.Text);

            try
            {
                sqlCommand.ExecuteNonQuery();

                AttListView();

                MessageBox.Show("Atualizado com Sucesso","CADASTRO",MessageBoxButtons.OK,MessageBoxIcon.Information);


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

