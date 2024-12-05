namespace TelaDeLogin
{
    partial class CadastroClientes
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblNome;
        private TextBox txtNome;
        private Label lblCPF;
        private TextBox txtCPF;
        private Label lblEndereco;
        private TextBox txtEndereco;
        private Label lblTelefone;
        private TextBox txtTelefone;
        private Label lblDataNascimento;
        private TextBox txtDataNascimento;
        private Button btnSalvar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblNome = new Label();
            txtNome = new TextBox();
            lblCPF = new Label();
            txtCPF = new TextBox();
            lblEndereco = new Label();
            txtEndereco = new TextBox();
            lblTelefone = new Label();
            txtTelefone = new TextBox();
            lblDataNascimento = new Label();
            txtDataNascimento = new TextBox();
            btnSalvar = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(30, 30);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(53, 20);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(162, 27);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(200, 27);
            txtNome.TabIndex = 1;
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(30, 70);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(36, 20);
            lblCPF.TabIndex = 2;
            lblCPF.Text = "CPF:";
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(162, 67);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(200, 27);
            txtCPF.TabIndex = 3;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Location = new Point(30, 110);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(74, 20);
            lblEndereco.TabIndex = 4;
            lblEndereco.Text = "Endereço:";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(162, 107);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(200, 27);
            txtEndereco.TabIndex = 5;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(30, 150);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(69, 20);
            lblTelefone.TabIndex = 6;
            lblTelefone.Text = "Telefone:";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(162, 147);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(200, 27);
            txtTelefone.TabIndex = 7;
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.Location = new Point(30, 190);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(127, 20);
            lblDataNascimento.TabIndex = 8;
            lblDataNascimento.Text = "Data Nascimento:";
            // 
            // txtDataNascimento
            // 
            txtDataNascimento.Location = new Point(162, 187);
            txtDataNascimento.Name = "txtDataNascimento";
            txtDataNascimento.Size = new Size(200, 27);
            txtDataNascimento.TabIndex = 9;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(120, 230);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 29);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(210, 230);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 11;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CadastroClientes
            // 
            ClientSize = new Size(384, 311);
            Controls.Add(button1);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(lblCPF);
            Controls.Add(txtCPF);
            Controls.Add(lblEndereco);
            Controls.Add(txtEndereco);
            Controls.Add(lblTelefone);
            Controls.Add(txtTelefone);
            Controls.Add(lblDataNascimento);
            Controls.Add(txtDataNascimento);
            Controls.Add(btnSalvar);
            Name = "CadastroClientes";
            Text = "Cadastro de Clientes";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button button1;
    }
}
