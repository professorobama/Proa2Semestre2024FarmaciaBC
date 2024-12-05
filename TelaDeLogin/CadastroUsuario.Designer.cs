namespace TelaDeLogin
{
    partial class CadastroUsuario
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblUsuario;
        private TextBox txtUsuario;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblSenha;
        private TextBox txtSenha;
        private Label lblSenhaCon;
        private TextBox txtSenhaCon;
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
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblSenha = new Label();
            txtSenha = new TextBox();
            lblSenhaCon = new Label();
            txtSenhaCon = new TextBox();
            btnSalvar = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(30, 30);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(43, 15);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Nome:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(162, 27);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(200, 23);
            txtUsuario.TabIndex = 12;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(30, 70);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(31, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "CPF:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(162, 67);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 3;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(30, 110);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(59, 15);
            lblSenha.TabIndex = 4;
            lblSenha.Text = "Endereço:";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(162, 107);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(200, 23);
            txtSenha.TabIndex = 5;
            // 
            // lblSenhaCon
            // 
            lblSenhaCon.AutoSize = true;
            lblSenhaCon.Location = new Point(30, 150);
            lblSenhaCon.Name = "lblSenhaCon";
            lblSenhaCon.Size = new Size(54, 15);
            lblSenhaCon.TabIndex = 6;
            lblSenhaCon.Text = "Telefone:";
            // 
            // txtSenhaCon
            // 
            txtSenhaCon.Location = new Point(162, 147);
            txtSenhaCon.Name = "txtSenhaCon";
            txtSenhaCon.Size = new Size(200, 23);
            txtSenhaCon.TabIndex = 7;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(120, 230);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 29);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
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
            // CadastroUsuario
            // 
            ClientSize = new Size(384, 311);
            Controls.Add(button1);
            Controls.Add(lblUsuario);
            Controls.Add(txtUsuario);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblSenha);
            Controls.Add(txtSenha);
            Controls.Add(lblSenhaCon);
            Controls.Add(txtSenhaCon);
            Controls.Add(btnSalvar);
            Name = "CadastroUsuario";
            Text = "Cadastro de Usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button button1;
    }
}
