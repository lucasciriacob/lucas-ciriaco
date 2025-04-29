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

                string queryLogin = "SELECT id, tipo_usuario FROM usuario WHERE TRIM(nomeUsuario) = @nomeUsuario AND TRIM(senha) = @senha";

                using (MySqlCommand cmdLogin = new MySqlCommand(queryLogin, conexao))
                {
                    cmdLogin.Parameters.AddWithValue("@nomeUsuario", usuario);
                    cmdLogin.Parameters.AddWithValue("@senha", senha);

                    using (MySqlDataReader reader = cmdLogin.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int idUsuario = reader.GetInt32("id");
                            string tipoUsuario = reader.GetString("tipo_usuario");

                            Sessao.UsuarioId = idUsuario; 

                            LimparCampos();

                            if (tipoUsuario == "Admin")
                            {
                                FormMenu formAdmin = new FormMenu();
                                formAdmin.Show();
                            }
                            else
                            {
                                Principal formFuncionario = new Principal();
                                formFuncionario.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usuário ou senha incorretos.");
                        }
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
        

