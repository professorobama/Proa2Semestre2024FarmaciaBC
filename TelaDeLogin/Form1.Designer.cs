namespace TelaDeLogin
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblUsuario;
        private TextBox txtUsuario;
        private Label lblSenha;
        private TextBox txtSenha;
        private Button btnLogin;
        private Button btnCadastro;
        private Label lblMensagem;

        private void InitializeComponent()
        {
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            lblSenha = new Label();
            txtSenha = new TextBox();
            btnLogin = new Button();
            btnCadastro = new Button();
            lblMensagem = new Label();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(30, 30);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(50, 15);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuário:";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.LightBlue;
            txtUsuario.Location = new Point(100, 27);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(200, 23);
            txtUsuario.TabIndex = 1;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(30, 70);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(42, 15);
            lblSenha.TabIndex = 2;
            lblSenha.Text = "Senha:";
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.LightBlue;
            txtSenha.Location = new Point(100, 67);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(200, 23);
            txtSenha.TabIndex = 3;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Salmon;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(100, 111);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(100, 30);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCadastro
            // 
            btnCadastro.BackColor = Color.Salmon;
            btnCadastro.ForeColor = Color.White;
            btnCadastro.Location = new Point(206, 111);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(100, 30);
            btnCadastro.TabIndex = 4;
            btnCadastro.Text = "Cadasto";
            btnCadastro.UseVisualStyleBackColor = false;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Location = new Point(30, 160);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(0, 15);
            lblMensagem.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(350, 200);
            Controls.Add(lblMensagem);
            Controls.Add(btnLogin);
            Controls.Add(btnCadastro);
            Controls.Add(txtSenha);
            Controls.Add(lblSenha);
            Controls.Add(txtUsuario);
            Controls.Add(lblUsuario);
            Name = "Form1";
            Text = "Farmácia Braço Curto";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
