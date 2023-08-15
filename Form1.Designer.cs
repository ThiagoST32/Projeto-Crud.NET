namespace Crud_Adm_Root_C_
{
    partial class Form1
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
            Salvar = new Button();
            textNome = new TextBox();
            Nome = new Label();
            Telefone = new Label();
            Email = new Label();
            Senha = new Label();
            textEmail = new TextBox();
            textTelefone = new TextBox();
            textSenha = new TextBox();
            ListViewBuscarDados = new ListView();
            BuscarDadosLabel = new Label();
            textBuscarDados = new TextBox();
            BtnBuscarDados = new Button();
            AtualizarBtn = new Button();
            ExcluirBtn = new Button();
            SuspendLayout();
            // 
            // Salvar
            // 
            Salvar.Location = new Point(67, 194);
            Salvar.Name = "Salvar";
            Salvar.RightToLeft = RightToLeft.No;
            Salvar.Size = new Size(75, 23);
            Salvar.TabIndex = 0;
            Salvar.Text = "Salvar";
            Salvar.UseVisualStyleBackColor = true;
            Salvar.Click += Salvar_Click;
            // 
            // textNome
            // 
            textNome.Location = new Point(25, 33);
            textNome.Name = "textNome";
            textNome.Size = new Size(117, 23);
            textNome.TabIndex = 1;
            textNome.TextChanged += textBox1_TextChanged;
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.CausesValidation = false;
            Nome.Location = new Point(25, 15);
            Nome.Name = "Nome";
            Nome.Size = new Size(40, 15);
            Nome.TabIndex = 2;
            Nome.Text = "Nome";
            Nome.Click += label1_Click;
            // 
            // Telefone
            // 
            Telefone.AutoSize = true;
            Telefone.Location = new Point(25, 59);
            Telefone.Name = "Telefone";
            Telefone.Size = new Size(51, 15);
            Telefone.TabIndex = 3;
            Telefone.Text = "Telefone";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(25, 103);
            Email.Name = "Email";
            Email.Size = new Size(36, 15);
            Email.TabIndex = 4;
            Email.Text = "Email";
            // 
            // Senha
            // 
            Senha.AutoSize = true;
            Senha.Location = new Point(25, 147);
            Senha.Name = "Senha";
            Senha.Size = new Size(39, 15);
            Senha.TabIndex = 5;
            Senha.Text = "Senha";
            // 
            // textEmail
            // 
            textEmail.Location = new Point(25, 121);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(117, 23);
            textEmail.TabIndex = 6;
            // 
            // textTelefone
            // 
            textTelefone.Location = new Point(25, 77);
            textTelefone.Name = "textTelefone";
            textTelefone.Size = new Size(117, 23);
            textTelefone.TabIndex = 7;
            // 
            // textSenha
            // 
            textSenha.Location = new Point(25, 165);
            textSenha.Name = "textSenha";
            textSenha.Size = new Size(117, 23);
            textSenha.TabIndex = 8;
            // 
            // ListViewBuscarDados
            // 
            ListViewBuscarDados.Location = new Point(148, 59);
            ListViewBuscarDados.MultiSelect = false;
            ListViewBuscarDados.Name = "ListViewBuscarDados";
            ListViewBuscarDados.Size = new Size(430, 274);
            ListViewBuscarDados.TabIndex = 9;
            ListViewBuscarDados.UseCompatibleStateImageBehavior = false;
            ListViewBuscarDados.ItemSelectionChanged += lst_contatos_ItemChanged;
            // 
            // BuscarDadosLabel
            // 
            BuscarDadosLabel.AutoSize = true;
            BuscarDadosLabel.Location = new Point(148, 9);
            BuscarDadosLabel.Name = "BuscarDadosLabel";
            BuscarDadosLabel.Size = new Size(42, 15);
            BuscarDadosLabel.TabIndex = 10;
            BuscarDadosLabel.Text = "Buscar";
            BuscarDadosLabel.Click += label1_Click_1;
            // 
            // textBuscarDados
            // 
            textBuscarDados.Location = new Point(148, 30);
            textBuscarDados.Name = "textBuscarDados";
            textBuscarDados.Size = new Size(349, 23);
            textBuscarDados.TabIndex = 11;
            // 
            // BtnBuscarDados
            // 
            BtnBuscarDados.Location = new Point(503, 30);
            BtnBuscarDados.Name = "BtnBuscarDados";
            BtnBuscarDados.Size = new Size(75, 23);
            BtnBuscarDados.TabIndex = 0;
            BtnBuscarDados.Text = "Buscar";
            BtnBuscarDados.Click += BtnBuscarDados_Click;
            // 
            // AtualizarBtn
            // 
            AtualizarBtn.Location = new Point(67, 223);
            AtualizarBtn.Name = "AtualizarBtn";
            AtualizarBtn.Size = new Size(75, 23);
            AtualizarBtn.TabIndex = 12;
            AtualizarBtn.Text = "Atualizar";
            AtualizarBtn.UseVisualStyleBackColor = true;
            AtualizarBtn.Click += AtualizarBtn_Click;
            // 
            // ExcluirBtn
            // 
            ExcluirBtn.Location = new Point(67, 252);
            ExcluirBtn.Name = "ExcluirBtn";
            ExcluirBtn.Size = new Size(75, 23);
            ExcluirBtn.TabIndex = 13;
            ExcluirBtn.Text = "Excluir";
            ExcluirBtn.UseVisualStyleBackColor = true;
            ExcluirBtn.Click += ExcluirBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 359);
            Controls.Add(ExcluirBtn);
            Controls.Add(AtualizarBtn);
            Controls.Add(BtnBuscarDados);
            Controls.Add(textBuscarDados);
            Controls.Add(BuscarDadosLabel);
            Controls.Add(ListViewBuscarDados);
            Controls.Add(textSenha);
            Controls.Add(textTelefone);
            Controls.Add(textEmail);
            Controls.Add(Senha);
            Controls.Add(Email);
            Controls.Add(Telefone);
            Controls.Add(Nome);
            Controls.Add(textNome);
            Controls.Add(Salvar);
            Location = new Point(50, 50);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Salvar;
        private TextBox textNome;
        private Label Nome;
        private Label Telefone;
        private Label Email;
        private Label Senha;
        private TextBox textEmail;
        private TextBox textTelefone;
        private TextBox textSenha;
        private ListView ListViewBuscarDados;
        private Label BuscarDadosLabel;
        private TextBox textBuscarDados;
        private Button BtnBuscarDados;
        private Button AtualizarBtn;
        private Button ExcluirBtn;
    }
}