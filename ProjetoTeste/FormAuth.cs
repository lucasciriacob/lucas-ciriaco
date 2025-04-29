using MySql.Data.MySqlClient;
using System.Net.NetworkInformation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProjetoTeste
{
    public partial class FormAuth : Form
    {
        public void Erro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Sucesso(string mensagem)
        {
            MessageBox.Show(mensagem, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void LimparCampos()
        {
            txtUser.Clear();
            txtSenha.Clear();
            chkSenha.Checked = false;
        }
        public FormAuth()
        {
            InitializeComponent();
        }
        

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=localhost;username=root;password=;database=bd_Estoque";

            string usuario = txtUser.Text.Trim();
            string senha = txtSenha.Text.Trim();

            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                conexao.Open();

                // Primeiro passo: verificar se existe usuário e senha válidos
                string queryVerificar = "SELECT COUNT(*) FROM usuario WHERE TRIM(nomeUsuario) = @nomeUsuario AND TRIM(senha) = @senha";

                using (MySqlCommand cmdVerificar = new MySqlCommand(queryVerificar, conexao))
                {
                    cmdVerificar.Parameters.AddWithValue("@nomeUsuario", usuario);
                    cmdVerificar.Parameters.AddWithValue("@senha", senha);

                    int count = Convert.ToInt32(cmdVerificar.ExecuteScalar());

                    if (count > 0)
                    {
                        // Segundo passo: buscar o tipo do usuário
                        string queryTipo = "SELECT tipo_usuario FROM usuario WHERE TRIM(nomeUsuario) = @nomeUsuario AND TRIM(senha) = @senha";

                        using (MySqlCommand cmdTipo = new MySqlCommand(queryTipo, conexao))
                        {
                            cmdTipo.Parameters.AddWithValue("@nomeUsuario", usuario);
                            cmdTipo.Parameters.AddWithValue("@senha", senha);
                            object result = cmdTipo.ExecuteScalar();

                            if (result != null)
                            {
                                string tipoUsuario = result.ToString();

                                if (tipoUsuario == "Admin")
                                {
                                    LimparCampos();
                                    FormMenu formAdmin = new FormMenu();
                                    formAdmin.Show();
                                }
                                else
                                {
                                    LimparCampos();
                                    FormMenu2 formFuncionario = new FormMenu2();
                                    formFuncionario.Show();
                                }

                                
                            }
                            else
                            {
                                LimparCampos();
                                MessageBox.Show("Erro ao buscar tipo de usuário.");
                            }
                        }
                    }
                    else
                    {   
                        MessageBox.Show("Usuário ou senha incorretos.");
                    }
                }
            }
        }


        private void cbxSenha_CheckedChanged(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = chkSenha.Checked ? '\0' : '*';
        }
    }



}
        

