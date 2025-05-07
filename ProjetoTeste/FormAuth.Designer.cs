namespace ProjetoTeste
{
    partial class FormAuth
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUser = new TextBox();
            txtSenha = new TextBox();
            btnSalvar = new Button();
            chkSenha = new CheckBox();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.Location = new Point(27, 46);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "Usuario...";
            txtUser.Size = new Size(227, 23);
            txtUser.TabIndex = 0;
            txtUser.KeyDown += txtUser_KeyDown;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(27, 102);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "Senha...";
            txtSenha.Size = new Size(227, 23);
            txtSenha.TabIndex = 1;
            txtSenha.KeyDown += txtSenha_KeyDown;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(27, 192);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(227, 23);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Entrar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // chkSenha
            // 
            chkSenha.AutoSize = true;
            chkSenha.Location = new Point(82, 131);
            chkSenha.Name = "chkSenha";
            chkSenha.Size = new Size(102, 19);
            chkSenha.TabIndex = 3;
            chkSenha.Text = "Mostrar Senha";
            chkSenha.UseVisualStyleBackColor = true;
            chkSenha.CheckedChanged += cbxSenha_CheckedChanged;
            // 
            // FormAuth
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 239);
            Controls.Add(chkSenha);
            Controls.Add(btnSalvar);
            Controls.Add(txtSenha);
            Controls.Add(txtUser);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAuth";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Autenticação";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUser;
        private TextBox txtSenha;
        private Button btnSalvar;
        private CheckBox chkSenha;
    }
}
