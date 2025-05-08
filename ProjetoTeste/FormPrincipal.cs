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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;username=root;password=;database=bd_Estoque";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM estoque WHERE idUser = @idUser";
                using (MySqlCommand cmdSelect = new MySqlCommand(query, connection))
                {
                    cmdSelect.Parameters.AddWithValue("@idUser", Sessao.UsuarioId);

                    try
                    {
                        connection.Open();

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmdSelect)) 
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
            }
        }
        private void mnsListaBD_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel1.Visible = true;   
        }
        private void mnsCadastro_Click(object sender, EventArgs e)
        {
            FormCadastro_Estoque formCadastro = new FormCadastro_Estoque();
            formCadastro.Show();
        }
        private void mnsSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
