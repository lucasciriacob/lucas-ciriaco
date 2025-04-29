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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            mnsCadEstoque = new ToolStripMenuItem();
            mnsCadUser = new ToolStripMenuItem();
            mnsEstoque = new ToolStripMenuItem();
            mnsUsuarios = new ToolStripMenuItem();
            mnsSair = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnsCadEstoque, mnsCadUser, mnsEstoque, mnsUsuarios, mnsSair });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(472, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnsCadEstoque
            // 
            mnsCadEstoque.Name = "mnsCadEstoque";
            mnsCadEstoque.Size = new Size(111, 20);
            mnsCadEstoque.Text = "Cadastro Estoque";
            mnsCadEstoque.Click += mnsCadEstoque_Click;
            // 
            // mnsCadUser
            // 
            mnsCadUser.Name = "mnsCadUser";
            mnsCadUser.Size = new Size(114, 20);
            mnsCadUser.Text = "Cadastro Usuarios";
            mnsCadUser.Click += mnsCadUser_Click;
            // 
            // mnsEstoque
            // 
            mnsEstoque.Name = "mnsEstoque";
            mnsEstoque.Size = new Size(88, 20);
            mnsEstoque.Text = "Lista Estoque";
            mnsEstoque.Click += mnsEstoque_Click;
            // 
            // mnsUsuarios
            // 
            mnsUsuarios.Name = "mnsUsuarios";
            mnsUsuarios.Size = new Size(91, 20);
            mnsUsuarios.Text = "Lista Usuarios";
            mnsUsuarios.Click += mnsUsuarios_Click;
            // 
            // mnsSair
            // 
            mnsSair.Name = "mnsSair";
            mnsSair.Size = new Size(38, 20);
            mnsSair.Text = "Sair";
            mnsSair.Click += mnsSair_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 184);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMenu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnsCadEstoque;
        private ToolStripMenuItem mnsCadUser;
        private ToolStripMenuItem mnsEstoque;
        private ToolStripMenuItem mnsUsuarios;
        private ToolStripMenuItem mnsSair;
    }
}