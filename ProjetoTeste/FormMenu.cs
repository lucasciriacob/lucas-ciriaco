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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void mnsCadEstoque_Click(object sender, EventArgs e)
        {
            FormCadastro_Estoque estoque = new FormCadastro_Estoque();
            estoque.Show();
        }

        private void mnsCadUser_Click(object sender, EventArgs e)
        {
            FormCadastro_User user = new FormCadastro_User();
            user.Show();
        }

        private void mnsEstoque_Click(object sender, EventArgs e)
        {
            Form_bdEstoque b_estoque = new Form_bdEstoque();
            b_estoque.Show();
        }

        private void mnsUsuarios_Click(object sender, EventArgs e)
        {
            Form_bdUser bdUser = new Form_bdUser();
            bdUser.Show();

        }

        private void mnsSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
