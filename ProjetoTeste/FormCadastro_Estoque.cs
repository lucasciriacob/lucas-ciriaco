using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTeste
{
    public partial class FormCadastro_Estoque : Form
    {
        MySqlConnection conexao;
        private string data_source = "dataSource=localhost;username=root;password=;database=bd_Estoque";

        public void LimparCampos()
        {
            txtNome.Clear();
            mskId.Clear();
            txtQTD.Clear();
            txtDescricao.Clear();
            cbxCategoria.SelectedIndex = -1;
            dtpVencimento.Value = DateTime.Now;
            chkVencimento.Checked = false;
            dtpVencimento.Enabled = true;
        }
        public FormCadastro_Estoque()
        {
            InitializeComponent();
        }


        private void chkVencimento_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVencimento.Checked)
            {
                dtpVencimento.Enabled = false;
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtQTD.Text)
                || string.IsNullOrWhiteSpace(txtDescricao.Text) || cbxCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.");
                return;
            }

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(data_source))
                {
                    string sql = @"INSERT INTO estoque 
                          (nome, categoria, descricao, quantidade, vencimento, idUser)
                          VALUES 
                          (@nome, @categoria, @descricao, @quantidade, @vencimento, @idUser)";

                    using (MySqlCommand insert = new MySqlCommand(sql, conexao))
                    {
                        insert.Parameters.AddWithValue("@nome", txtNome.Text.Trim());
                        insert.Parameters.AddWithValue("@categoria", cbxCategoria.Text.Trim());
                        insert.Parameters.AddWithValue("@descricao", txtDescricao.Text.Trim());
                        insert.Parameters.AddWithValue("@quantidade", int.Parse(txtQTD.Text.Trim()));
                        insert.Parameters.AddWithValue("@vencimento", dtpVencimento.Value.Date);
                        insert.Parameters.AddWithValue("@idUser", Sessao.UsuarioId); 

                        conexao.Open();
                        insert.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Cadastro realizado com sucesso!");
                LimparCampos();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
            }
        }


        private void chkDescricao_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDescricao.Checked)
            {
                txtDescricao.Enabled = false;
                txtDescricao.Text = "Sem Descrição...";
            }
        }
    }
}
