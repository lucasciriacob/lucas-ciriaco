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
        public FormCadastro_Estoque()
        {
            InitializeComponent();
        }


        private void chkVencimento_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVencimento.Checked)
            {
                dtpVencimento.Enabled = true;
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(mskQtd.Text)
                || string.IsNullOrWhiteSpace(txtDescricao.Text) || cbxCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.");
                return;
            }

        }

        private void chkDescricao_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDescricao.Checked)
            {
                txtDescricao.Enabled = true;
                txtDescricao.Text = "Sem Descrição...";
            }
        }
    }
}
