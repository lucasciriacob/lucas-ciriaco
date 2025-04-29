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
            mskQtd = new MaskedTextBox();
            txtDescricao = new TextBox();
            cbxCategoria = new ComboBox();
            mskId = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dtpVencimento = new DateTimePicker();
            chkVencimento = new CheckBox();
            btnSalvar = new Button();
            btnVoltar = new Button();
            chkDescricao = new CheckBox();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(27, 90);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome...";
            txtNome.Size = new Size(172, 23);
            txtNome.TabIndex = 1;
            txtNome.TextAlign = HorizontalAlignment.Center;
            // 
            // mskQtd
            // 
            mskQtd.Location = new Point(27, 134);
            mskQtd.Mask = "00000";
            mskQtd.Name = "mskQtd";
            mskQtd.Size = new Size(172, 23);
            mskQtd.TabIndex = 3;
            mskQtd.TextAlign = HorizontalAlignment.Center;
            mskQtd.ValidatingType = typeof(int);
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(27, 176);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.PlaceholderText = "Descrição...";
            txtDescricao.Size = new Size(328, 105);
            txtDescricao.TabIndex = 4;
            // 
            // cbxCategoria
            // 
            cbxCategoria.FormattingEnabled = true;
            cbxCategoria.Items.AddRange(new object[] { "Açougue", "Bebidas", "Congelados", "Eletrônicos", "Higiene Pessoal", "Hortifruti", "Laticínios", "Limpeza", "Mercearia", "Padaria", "Pet Shop", "" });
            cbxCategoria.Location = new Point(221, 44);
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(134, 23);
            cbxCategoria.TabIndex = 5;
            // 
            // mskId
            // 
            mskId.Location = new Point(27, 44);
            mskId.Mask = "00000";
            mskId.Name = "mskId";
            mskId.Size = new Size(172, 23);
            mskId.TabIndex = 6;
            mskId.TextAlign = HorizontalAlignment.Center;
            mskId.ValidatingType = typeof(int);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 25);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 7;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 116);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 8;
            label2.Text = "Quantidade:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(256, 25);
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
            dtpVencimento.Size = new Size(134, 23);
            dtpVencimento.TabIndex = 10;
            // 
            // chkVencimento
            // 
            chkVencimento.AutoSize = true;
            chkVencimento.Location = new Point(232, 115);
            chkVencimento.Name = "chkVencimento";
            chkVencimento.Size = new Size(115, 19);
            chkVencimento.TabIndex = 11;
            chkVencimento.Text = "Sem Vencimento";
            chkVencimento.UseVisualStyleBackColor = true;
            chkVencimento.CheckedChanged += chkVencimento_CheckedChanged;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(272, 326);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(83, 36);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(183, 326);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(83, 36);
            btnVoltar.TabIndex = 13;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            // 
            // chkDescricao
            // 
            chkDescricao.AutoSize = true;
            chkDescricao.Location = new Point(27, 287);
            chkDescricao.Name = "chkDescricao";
            chkDescricao.Size = new Size(103, 19);
            chkDescricao.TabIndex = 14;
            chkDescricao.Text = "Sem Descrição";
            chkDescricao.UseVisualStyleBackColor = true;
            chkDescricao.CheckedChanged += chkDescricao_CheckedChanged;
            // 
            // FormCadastro_Estoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 390);
            Controls.Add(chkDescricao);
            Controls.Add(btnVoltar);
            Controls.Add(btnSalvar);
            Controls.Add(chkVencimento);
            Controls.Add(dtpVencimento);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(mskId);
            Controls.Add(cbxCategoria);
            Controls.Add(txtDescricao);
            Controls.Add(mskQtd);
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
        private MaskedTextBox mskQtd;
        private TextBox txtDescricao;
        private ComboBox cbxCategoria;
        private MaskedTextBox mskId;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpVencimento;
        private CheckBox chkVencimento;
        private Button btnSalvar;
        private Button btnVoltar;
        private CheckBox chkDescricao;
    }
}