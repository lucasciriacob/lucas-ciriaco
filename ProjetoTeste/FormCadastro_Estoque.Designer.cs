namespace ProjetoTeste
{
    partial class FormCadastro_Estoque
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
            txtNome = new TextBox();
            txtDescricao = new TextBox();
            cbxCategoria = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            dtpVencimento = new DateTimePicker();
            chkVencimento = new CheckBox();
            btnSalvar = new Button();
            btnVoltar = new Button();
            chkDescricao = new CheckBox();
            mskId = new MaskedTextBox();
            txtQTD = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(27, 46);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome...";
            txtNome.Size = new Size(172, 23);
            txtNome.TabIndex = 1;
            txtNome.TextAlign = HorizontalAlignment.Center;
            txtNome.KeyDown += txtNome_KeyDown;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(27, 176);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.PlaceholderText = "Descrição...";
            txtDescricao.Size = new Size(366, 105);
            txtDescricao.TabIndex = 4;
            txtDescricao.KeyDown += txtDescricao_KeyDown;
            // 
            // cbxCategoria
            // 
            cbxCategoria.FormattingEnabled = true;
            cbxCategoria.Items.AddRange(new object[] { "Açougue", "Bebidas", "Congelados", "Eletrônicos", "Higiene Pessoal", "Hortifruti", "Laticínios", "Limpeza", "Mercearia", "Padaria", "Pet Shop", "" });
            cbxCategoria.Location = new Point(27, 93);
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(172, 23);
            cbxCategoria.TabIndex = 5;
            cbxCategoria.KeyDown += cbxCategoria_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(297, 29);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 7;
            label1.Text = "ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 74);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 9;
            label3.Text = "Categoria:";
            // 
            // dtpVencimento
            // 
            dtpVencimento.Format = DateTimePickerFormat.Short;
            dtpVencimento.Location = new Point(221, 90);
            dtpVencimento.Name = "dtpVencimento";
            dtpVencimento.Size = new Size(172, 23);
            dtpVencimento.TabIndex = 10;
            // 
            // chkVencimento
            // 
            chkVencimento.AutoSize = true;
            chkVencimento.Location = new Point(252, 113);
            chkVencimento.Name = "chkVencimento";
            chkVencimento.Size = new Size(115, 19);
            chkVencimento.TabIndex = 11;
            chkVencimento.Text = "Sem Vencimento";
            chkVencimento.UseVisualStyleBackColor = true;
            chkVencimento.CheckedChanged += chkVencimento_CheckedChanged;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(310, 326);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(83, 36);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(221, 326);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(83, 36);
            btnVoltar.TabIndex = 13;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // chkDescricao
            // 
            chkDescricao.AutoSize = true;
            chkDescricao.Location = new Point(154, 284);
            chkDescricao.Name = "chkDescricao";
            chkDescricao.Size = new Size(103, 19);
            chkDescricao.TabIndex = 14;
            chkDescricao.Text = "Sem Descrição";
            chkDescricao.UseVisualStyleBackColor = true;
            chkDescricao.CheckedChanged += chkDescricao_CheckedChanged;
            // 
            // mskId
            // 
            mskId.Location = new Point(221, 46);
            mskId.Mask = "00000";
            mskId.Name = "mskId";
            mskId.Size = new Size(172, 23);
            mskId.TabIndex = 6;
            mskId.TextAlign = HorizontalAlignment.Center;
            mskId.ValidatingType = typeof(int);
            mskId.KeyDown += mskId_KeyDown;
            // 
            // txtQTD
            // 
            txtQTD.Location = new Point(27, 135);
            txtQTD.Name = "txtQTD";
            txtQTD.PlaceholderText = "Quantidade...";
            txtQTD.Size = new Size(172, 23);
            txtQTD.TabIndex = 15;
            txtQTD.KeyDown += txtQTD_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(183, 50);
            label4.Name = "label4";
            label4.Size = new Size(12, 15);
            label4.TabIndex = 16;
            label4.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(29, 97);
            label2.Name = "label2";
            label2.Size = new Size(12, 15);
            label2.TabIndex = 17;
            label2.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(183, 139);
            label5.Name = "label5";
            label5.Size = new Size(12, 15);
            label5.TabIndex = 18;
            label5.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(91, 179);
            label6.Name = "label6";
            label6.Size = new Size(12, 15);
            label6.TabIndex = 19;
            label6.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(377, 50);
            label7.Name = "label7";
            label7.Size = new Size(12, 15);
            label7.TabIndex = 20;
            label7.Text = "*";
            // 
            // FormCadastro_Estoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 390);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(txtQTD);
            Controls.Add(chkDescricao);
            Controls.Add(btnVoltar);
            Controls.Add(btnSalvar);
            Controls.Add(chkVencimento);
            Controls.Add(dtpVencimento);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(mskId);
            Controls.Add(cbxCategoria);
            Controls.Add(txtDescricao);
            Controls.Add(txtNome);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastro_Estoque";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de Produtos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNome;
        private TextBox txtDescricao;
        private ComboBox cbxCategoria;
        private Label label1;
        private Label label3;
        private DateTimePicker dtpVencimento;
        private CheckBox chkVencimento;
        private Button btnSalvar;
        private Button btnVoltar;
        private CheckBox chkDescricao;
        private MaskedTextBox mskId;
        private TextBox txtQTD;
        private Label label4;
        private Label label2;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}