        using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data.MySqlClient;

namespace ProjetoTeste
{
    public partial class FormCadastro_User : Form
    {
        MySqlConnection conexao;
        private string data_source = "dataSource=localhost;username=root;password=;database=bd_Estoque";


        public void LimparCampos()
        {
            txtUsuario.Clear();
            txtSenha.Clear();
            txtEmail.Clear();
            mskCEP.Clear();
            mskCPF.Clear();
            mskTelefone.Clear();
            rdbPessoal.Checked = false;
            rdbComercial.Checked = false;
            rdbRecado.Checked = false;
            rdbAdmin.Checked = false;
            rdbComum.Checked = false;
        }

        public FormCadastro_User()
        {
            InitializeComponent();


        }

        private void chkSenha_CheckedChanged(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = chkSenha.Checked ? '\0' : '*';

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtSenha.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(mskCEP.Text) || string.IsNullOrWhiteSpace(mskCPF.Text))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.");
                return;
            }
            ETipoTelefone tipoTelefone;
            if (rdbComercial.Checked)
                tipoTelefone = ETipoTelefone.Comercial;
            else if (rdbPessoal.Checked)
                tipoTelefone = ETipoTelefone.Pessoal;
            else
                tipoTelefone = ETipoTelefone.Recado;
            ETipoUsuario tipoUsuario;
            if (rdbAdmin.Checked)
                tipoUsuario = ETipoUsuario.Admin;
            else
                tipoUsuario = ETipoUsuario.Funcionario;
            try
            {
                conexao = new MySqlConnection(data_source);

                string sql = "INSERT INTO usuario (nomeUsuario , senha , email , cpf , cep , telefone, tipo_telefone, tipo_usuario)" + "VALUES" + "" +
                    "(' " + txtUsuario.Text + " ' , ' " + txtSenha.Text + "', '"
                    + txtEmail.Text + " ' , ' " + mskCPF.Text + " ' , ' " + mskCEP.Text + " ',' "
                    + mskTelefone.Text + " ',' "+ tipoTelefone+" ','"+ tipoUsuario+"')";

                MySqlCommand insert = new MySqlCommand(sql, conexao);
                conexao.Open();
                insert.ExecuteNonQuery();
                MessageBox.Show("Cadastro realizado com sucesso!");
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }


    }
}
