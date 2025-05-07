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

        private void FormMenu_Load(object sender, EventArgs e)
        {

            vScrollBar1.Minimum = 0;
            vScrollBar1.Maximum = dataGridView1.Height + dataGridView2.Height;
            vScrollBar1.LargeChange = 50;
            vScrollBar1.SmallChange = 10;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int offset = -vScrollBar1.Value;
            dataGridView1.Top = offset;
            dataGridView2.Top = offset + dataGridView1.Height + 10; // 10 = espaçamento
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            string connectionString = "dataSource = localhost; username = root; password =; database = bd_Estoque";
            string query = "SELECT * FROM usuario";


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar os dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            string select = "SELECT * FROM estoque";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(select, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView2.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar os dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void mnsAtualizar_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel1.Visible = true;
        }
    }
}

