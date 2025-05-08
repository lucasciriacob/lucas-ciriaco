namespace ProjetoTeste
{
    partial class FormCadastro_User
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
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            txtEmail = new TextBox();
            mskCEP = new MaskedTextBox();
            mskCPF = new MaskedTextBox();
            gbxTipoFuncionario = new GroupBox();
            rdbComum = new RadioButton();
            rdbAdmin = new RadioButton();
            gbxTipoTelefone = new GroupBox();
            rdbRecado = new RadioButton();
            rdbComercial = new RadioButton();
            rdbPessoal = new RadioButton();
            chkSenha = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            btnRegistro = new Button();
            mskTelefone = new MaskedTextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            gbxTipoFuncionario.SuspendLayout();
            gbxTipoTelefone.SuspendLayout();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(37, 36);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario...";
            txtUsuario.Size = new Size(194, 23);
            txtUsuario.TabIndex = 0;
            txtUsuario.KeyDown += txtUsuario_KeyDown;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(37, 75);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "Senha...";
            txtSenha.Size = new Size(194, 23);
            txtSenha.TabIndex = 1;
            txtSenha.KeyDown += txtSenha_KeyDown;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(37, 124);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email...";
            txtEmail.Size = new Size(194, 23);
            txtEmail.TabIndex = 2;
            txtEmail.KeyDown += txtEmail_KeyDown;
            // 
            // mskCEP
            // 
            mskCEP.Location = new Point(37, 168);
            mskCEP.Mask = "00000-000";
            mskCEP.Name = "mskCEP";
            mskCEP.Size = new Size(194, 23);
            mskCEP.TabIndex = 3;
            mskCEP.KeyDown += mskCEP_KeyDown;
            // 
            // mskCPF
            // 
            mskCPF.Location = new Point(37, 212);
            mskCPF.Mask = "000000000-00";
            mskCPF.Name = "mskCPF";
            mskCPF.Size = new Size(194, 23);
            mskCPF.TabIndex = 4;
            mskCPF.KeyDown += mskCPF_KeyDown;
            // 
            // gbxTipoFuncionario
            // 
            gbxTipoFuncionario.Controls.Add(rdbComum);
            gbxTipoFuncionario.Controls.Add(rdbAdmin);
            gbxTipoFuncionario.Location = new Point(272, 163);
            gbxTipoFuncionario.Name = "gbxTipoFuncionario";
            gbxTipoFuncionario.Size = new Size(200, 100);
            gbxTipoFuncionario.TabIndex = 5;
            gbxTipoFuncionario.TabStop = false;
            gbxTipoFuncionario.Text = "Funcionario";
            // 
            // rdbComum
            // 
            rdbComum.AutoSize = true;
            rdbComum.Location = new Point(14, 66);
            rdbComum.Name = "rdbComum";
            rdbComum.Size = new Size(69, 19);
            rdbComum.TabIndex = 1;
            rdbComum.TabStop = true;
            rdbComum.Text = "Comum";
            rdbComum.UseVisualStyleBackColor = true;
            // 
            // rdbAdmin
            // 
            rdbAdmin.AutoSize = true;
            rdbAdmin.Location = new Point(15, 31);
            rdbAdmin.Name = "rdbAdmin";
            rdbAdmin.Size = new Size(61, 19);
            rdbAdmin.TabIndex = 0;
            rdbAdmin.TabStop = true;
            rdbAdmin.Text = "Admin";
            rdbAdmin.UseVisualStyleBackColor = true;
            // 
            // gbxTipoTelefone
            // 
            gbxTipoTelefone.Controls.Add(rdbRecado);
            gbxTipoTelefone.Controls.Add(rdbComercial);
            gbxTipoTelefone.Controls.Add(rdbPessoal);
            gbxTipoTelefone.Location = new Point(272, 46);
            gbxTipoTelefone.Name = "gbxTipoTelefone";
            gbxTipoTelefone.Size = new Size(200, 100);
            gbxTipoTelefone.TabIndex = 6;
            gbxTipoTelefone.TabStop = false;
            gbxTipoTelefone.Text = "Tipo de Telefone";
            // 
            // rdbRecado
            // 
            rdbRecado.AutoSize = true;
            rdbRecado.Location = new Point(10, 72);
            rdbRecado.Name = "rdbRecado";
            rdbRecado.Size = new Size(64, 19);
            rdbRecado.TabIndex = 2;
            rdbRecado.TabStop = true;
            rdbRecado.Text = "Recado";
            rdbRecado.UseVisualStyleBackColor = true;
            // 
            // rdbComercial
            // 
            rdbComercial.AutoSize = true;
            rdbComercial.Location = new Point(9, 45);
            rdbComercial.Name = "rdbComercial";
            rdbComercial.Size = new Size(79, 19);
            rdbComercial.TabIndex = 1;
            rdbComercial.TabStop = true;
            rdbComercial.Text = "Comercial";
            rdbComercial.UseVisualStyleBackColor = true;
            // 
            // rdbPessoal
            // 
            rdbPessoal.AutoSize = true;
            rdbPessoal.Location = new Point(9, 20);
            rdbPessoal.Name = "rdbPessoal";
            rdbPessoal.Size = new Size(64, 19);
            rdbPessoal.TabIndex = 0;
            rdbPessoal.TabStop = true;
            rdbPessoal.Text = "Pessoal";
            rdbPessoal.UseVisualStyleBackColor = true;
            // 
            // chkSenha
            // 
            chkSenha.AutoSize = true;
            chkSenha.Location = new Point(37, 99);
            chkSenha.Name = "chkSenha";
            chkSenha.Size = new Size(102, 19);
            chkSenha.TabIndex = 7;
            chkSenha.Text = "Mostrar Senha";
            chkSenha.UseVisualStyleBackColor = true;
            chkSenha.CheckedChanged += chkSenha_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 150);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 8;
            label1.Text = "CEP:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 194);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 9;
            label2.Text = "CPF:";
            // 
            // btnRegistro
            // 
            btnRegistro.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRegistro.Location = new Point(40, 294);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(432, 33);
            btnRegistro.TabIndex = 10;
            btnRegistro.Text = "REGISTRAR";
            btnRegistro.UseVisualStyleBackColor = true;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // mskTelefone
            // 
            mskTelefone.Location = new Point(40, 256);
            mskTelefone.Mask = "(00) 00000-0000";
            mskTelefone.Name = "mskTelefone";
            mskTelefone.Size = new Size(191, 23);
            mskTelefone.TabIndex = 11;
            mskTelefone.KeyDown += mskTelefone_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(108, 238);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 12;
            label3.Text = "Telefone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(214, 40);
            label4.Name = "label4";
            label4.Size = new Size(12, 15);
            label4.TabIndex = 13;
            label4.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(214, 80);
            label5.Name = "label5";
            label5.Size = new Size(12, 15);
            label5.TabIndex = 14;
            label5.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(214, 129);
            label6.Name = "label6";
            label6.Size = new Size(12, 15);
            label6.TabIndex = 15;
            label6.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(214, 173);
            label7.Name = "label7";
            label7.Size = new Size(12, 15);
            label7.TabIndex = 16;
            label7.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(214, 216);
            label8.Name = "label8";
            label8.Size = new Size(12, 15);
            label8.TabIndex = 17;
            label8.Text = "*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.ForeColor = Color.Red;
            label9.Location = new Point(214, 259);
            label9.Name = "label9";
            label9.Size = new Size(12, 15);
            label9.TabIndex = 18;
            label9.Text = "*";
            // 
            // FormCadastro_User
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 355);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(mskTelefone);
            Controls.Add(btnRegistro);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(chkSenha);
            Controls.Add(gbxTipoTelefone);
            Controls.Add(gbxTipoFuncionario);
            Controls.Add(mskCPF);
            Controls.Add(mskCEP);
            Controls.Add(txtEmail);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastro_User";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Usuario";
            gbxTipoFuncionario.ResumeLayout(false);
            gbxTipoFuncionario.PerformLayout();
            gbxTipoTelefone.ResumeLayout(false);
            gbxTipoTelefone.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtSenha;
        private TextBox txtEmail;
        private MaskedTextBox mskCEP;
        private MaskedTextBox mskCPF;
        private GroupBox gbxTipoFuncionario;
        private GroupBox gbxTipoTelefone;
        private CheckBox chkSenha;
        private Label label1;
        private Label label2;
        private Button btnRegistro;
        private MaskedTextBox mskTelefone;
        private Label label3;
        private RadioButton rdbComum;
        private RadioButton rdbAdmin;
        private RadioButton rdbRecado;
        private RadioButton rdbComercial;
        private RadioButton rdbPessoal;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}