using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TelaDeLogin
{
    public partial class Form1 : Form
    {
        private string connectionString = "Server=TIT0676404W10-1\\SQLEXPRESS;Database=FarmaciaBc;Trusted_Connection=True;";

        public Form1()
        {
            InitializeComponent();

            // Centralizar a tela no centro da tela do usuário
            this.StartPosition = FormStartPosition.CenterScreen;

            // Impedir o redimensionamento da tela
            this.MaximizeBox = false;  // Desabilita o botão de maximizar
            this.FormBorderStyle = FormBorderStyle.FixedDialog;  // Torna o formulário com borda fixa
        }

        // Evento do botão Login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            // Validação simples
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(senha))
            {
                lblMensagem.Text = "Por favor, preencha todos os campos.";
                lblMensagem.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                // Conectar ao banco de dados
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        // Consulta SQL para verificar o usuário e senha
                        string query = "SELECT COUNT(*) FROM usuario WHERE nome = @usuario AND senha = @senha";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            // Adiciona os parâmetros para evitar SQL Injection
                            cmd.Parameters.AddWithValue("@usuario", usuario);
                            cmd.Parameters.AddWithValue("@senha", senha);

                            // Executa a consulta e obtém o resultado
                            int result = (int)cmd.ExecuteScalar();

                            if (result > 0) // Usuário e senha válido
                            {
                                lblMensagem.Text = "Login realizado com sucesso!";
                                lblMensagem.ForeColor = System.Drawing.Color.Green;

                                // Abre o Menu Principal e fecha o formulário de login
                                MenuPrincipal menu = new MenuPrincipal();
                                menu.Show();
                                this.Hide(); // Esconde o formulário de login

                                // Aqui você pode redirecionar para outra janela, se necessário.
                                MessageBox.Show("Bem-vindo ao sistema!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else // Usuário ou senha inválidos
                            {
                                lblMensagem.Text = "Usuário ou senha inválidos.";
                                lblMensagem.ForeColor = System.Drawing.Color.Red;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    lblMensagem.Text = "Erro ao conectar ao banco de dados: " + ex.Message;
                    lblMensagem.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        //Evento do botão Cadastro
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            CadastroUsuario cadastroUsuario = new CadastroUsuario();
            cadastroUsuario.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
