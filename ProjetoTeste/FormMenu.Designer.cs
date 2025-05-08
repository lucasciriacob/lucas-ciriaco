namespace ProjetoTeste
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mnsCadEstoque = new ToolStripMenuItem();
            mnsCadUser = new ToolStripMenuItem();
            mnsEstoque = new ToolStripMenuItem();
            mnsUsuarios = new ToolStripMenuItem();
            mnsSair = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            mnsEspaco = new ToolStripMenuItem();
            mnsEspaco2 = new ToolStripMenuItem();
            mnsEspaco3 = new ToolStripMenuItem();
            mnsEspaco4 = new ToolStripMenuItem();
            mnsAtualizar = new ToolStripMenuItem();
            mnsEspaco5 = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            vScrollBar1 = new VScrollBar();
            panel1 = new Panel();
            dataGridView2 = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // mnsCadEstoque
            // 
            mnsCadEstoque.Name = "mnsCadEstoque";
            mnsCadEstoque.Size = new Size(107, 19);
            mnsCadEstoque.Text = "Cadastro Estoque";
            mnsCadEstoque.Click += mnsCadEstoque_Click;
            // 
            // mnsCadUser
            // 
            mnsCadUser.Name = "mnsCadUser";
            mnsCadUser.Size = new Size(107, 19);
            mnsCadUser.Text = "Cadastro Usuarios";
            mnsCadUser.Click += mnsCadUser_Click;
            // 
            // mnsEstoque
            // 
            mnsEstoque.Name = "mnsEstoque";
            mnsEstoque.Size = new Size(107, 19);
            mnsEstoque.Text = "Lista Estoque";
            mnsEstoque.Click += mnsEstoque_Click;
            // 
            // mnsUsuarios
            // 
            mnsUsuarios.Name = "mnsUsuarios";
            mnsUsuarios.Size = new Size(107, 19);
            mnsUsuarios.Text = "Lista Usuarios";
            mnsUsuarios.Click += mnsUsuarios_Click;
            // 
            // mnsSair
            // 
            mnsSair.Name = "mnsSair";
            mnsSair.Size = new Size(107, 19);
            mnsSair.Text = "Sair";
            mnsSair.Click += mnsSair_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Right;
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnsCadEstoque, mnsEspaco, mnsCadUser, mnsEspaco2, mnsEstoque, mnsEspaco3, mnsUsuarios, mnsEspaco4, mnsAtualizar, mnsEspaco5, mnsSair });
            menuStrip1.Location = new Point(551, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(120, 501);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnsEspaco
            // 
            mnsEspaco.Enabled = false;
            mnsEspaco.Name = "mnsEspaco";
            mnsEspaco.Size = new Size(107, 19);
            mnsEspaco.Text = "ㅤㅤㅤㅤㅤㅤㅤ";
            // 
            // mnsEspaco2
            // 
            mnsEspaco2.Enabled = false;
            mnsEspaco2.Name = "mnsEspaco2";
            mnsEspaco2.Size = new Size(107, 19);
            mnsEspaco2.Text = "ㅤ";
            // 
            // mnsEspaco3
            // 
            mnsEspaco3.Enabled = false;
            mnsEspaco3.Name = "mnsEspaco3";
            mnsEspaco3.Size = new Size(107, 19);
            mnsEspaco3.Text = "ㅤ";
            // 
            // mnsEspaco4
            // 
            mnsEspaco4.Enabled = false;
            mnsEspaco4.Name = "mnsEspaco4";
            mnsEspaco4.Size = new Size(107, 19);
            mnsEspaco4.Text = "ㅤ";
            // 
            // mnsAtualizar
            // 
            mnsAtualizar.Name = "mnsAtualizar";
            mnsAtualizar.Size = new Size(107, 19);
            mnsAtualizar.Text = "Atualizar Página";
            mnsAtualizar.Click += mnsAtualizar_Click;
            // 
            // mnsEspaco5
            // 
            mnsEspaco5.Enabled = false;
            mnsEspaco5.Name = "mnsEspaco5";
            mnsEspaco5.Size = new Size(107, 19);
            mnsEspaco5.Text = "             ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-3, -1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(522, 289);
            dataGridView1.TabIndex = 2;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(529, -1);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(20, 501);
            vScrollBar1.TabIndex = 5;
            vScrollBar1.Scroll += vScrollBar1_Scroll;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView2);
            panel1.Controls.Add(vScrollBar1);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(546, 565);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(3, 307);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(516, 283);
            dataGridView2.TabIndex = 3;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 501);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMenu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStripMenuItem mnsCadEstoque;
        private ToolStripMenuItem mnsCadUser;
        private ToolStripMenuItem mnsEstoque;
        private ToolStripMenuItem mnsUsuarios;
        private ToolStripMenuItem mnsSair;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnsEspaco;
        private ToolStripMenuItem mnsEspaco2;
        private ToolStripMenuItem mnsEspaco3;
        private ToolStripMenuItem mnsEspaco4;
        private DataGridView dataGridView1;
        private VScrollBar vScrollBar1;
        private Panel panel1;
        private DataGridView dataGridView2;
        private ToolStripMenuItem mnsEspaco5;
        private ToolStripMenuItem mnsAtualizar;
    }
}