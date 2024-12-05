using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaDeLogin
{
    public partial class CadastroUsuario : Form
    {
        public CadastroUsuario()
        {
            InitializeComponent();
            // Centralizar a tela no centro da tela do usuário
            this.StartPosition = FormStartPosition.CenterScreen;

            // Impedir o redimensionamento da tela
            this.MaximizeBox = false;  // Desabilita o botão de maximizar
            this.FormBorderStyle = FormBorderStyle.FixedDialog;  // Torna o formulário com borda fixa
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Login = new Form1();
            
        }
    }
}
