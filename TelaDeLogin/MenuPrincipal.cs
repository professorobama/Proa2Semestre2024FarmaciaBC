using System;
using System.Windows.Forms;

namespace TelaDeLogin
{
    public partial class MenuPrincipal : Form
    {

        public MenuPrincipal()
        {
            InitializeComponent();
        }
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abre a tela de cadastro de clientes
            CadastroClientes cadastroClientes = new CadastroClientes();
            cadastroClientes.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abre a tela de cadastro de clientes
        }

        // Evento do botão "Sair"
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Fecha o aplicativo
        }
    }
}
