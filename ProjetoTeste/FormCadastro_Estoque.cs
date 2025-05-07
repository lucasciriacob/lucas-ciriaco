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
        private string data_source = "dataSource=localhost;username=root;password=;database=bd_estoque";

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
                dtpVencimento.Text = "31/12/9998";
            }
            else
            {
                dtpVencimento.Enabled = true;
                dtpVencimento.Value = DateTime.Now;
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
                conexao = new MySqlConnection(data_source);
                string sql = @"INSERT INTO estoque 
                  (id, nome, categoria, descricao, quantidade, vencimento, idUser) 
                  VALUES 
                  (@id, @nome, @categoria, @descricao, @quantidade, @vencimento, @idUser)";

                using (MySqlCommand insert = new MySqlCommand(sql, conexao))
                {
                    insert.Parameters.AddWithValue("@id", mskId.Text);
                    insert.Parameters.AddWithValue("@nome", txtNome.Text);
                    insert.Parameters.AddWithValue("@categoria", cbxCategoria.Text);
                    insert.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                    insert.Parameters.AddWithValue("@quantidade", txtQTD.Text);
                    insert.Parameters.AddWithValue("@vencimento", dtpVencimento.Value);
                    insert.Parameters.AddWithValue("@idUser", Sessao.UsuarioId);

                    conexao.Open();
                    insert.ExecuteNonQuery();
                    MessageBox.Show("Cadastro realizado com sucesso!");
                    LimparCampos();

                }
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
            else
            {
                txtDescricao.Enabled = true;
                txtDescricao.Text = "";
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mskId.Focus();
            }
        }

        private void mskId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbxCategoria.Focus();
            }
        }

        private void cbxCategoria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtQTD.Focus();
            }
        }

        private void txtQTD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDescricao.Focus();
            }
        }

        private void txtDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSalvar.PerformClick();
            }
        }
    }
}
