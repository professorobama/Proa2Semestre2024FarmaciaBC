namespace TelaDeLogin
{
    partial class MenuPrincipal
    {
        private System.ComponentModel.IContainer components = null;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem medicamentosToolStripMenuItem;
        private ToolStripMenuItem fornecedoresToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem pagamentosToolStripMenuItem;
        private ToolStripMenuItem usuarioToolStripMenuItem;
        private ToolStripMenuItem relatoriosToolStripMenuItem;
        private ToolStripMenuItem vendasToolStripMenuItem;
        private ToolStripMenuItem estoqueToolStripMenuItem;
        private ToolStripMenuItem financeiroToolStripMenuItem;
        private ToolStripMenuItem ferramentasToolStripMenuItem;
        private ToolStripMenuItem configuracoesToolStripMenuItem;
        private ToolStripMenuItem backupToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private Button btnSair;

        private void InitializeComponent()
        {
            this.menuStrip1 = new MenuStrip();
            this.cadastroToolStripMenuItem = new ToolStripMenuItem();
            this.medicamentosToolStripMenuItem = new ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new ToolStripMenuItem();
            this.clientesToolStripMenuItem = new ToolStripMenuItem();
            this.pagamentosToolStripMenuItem = new ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new ToolStripMenuItem();
            this.vendasToolStripMenuItem = new ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new ToolStripMenuItem();
            this.ferramentasToolStripMenuItem = new ToolStripMenuItem();
            this.configuracoesToolStripMenuItem = new ToolStripMenuItem();
            this.backupToolStripMenuItem = new ToolStripMenuItem();
            this.sobreToolStripMenuItem = new ToolStripMenuItem();
            this.btnSair = new Button();

            // MenuStrip
            this.menuStrip1.Items.AddRange(new ToolStripItem[] {
        this.cadastroToolStripMenuItem,
        this.relatoriosToolStripMenuItem,
        this.ferramentasToolStripMenuItem,
        this.sobreToolStripMenuItem
    });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);

            // Cadastro
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            this.medicamentosToolStripMenuItem,
            this.fornecedoresToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.pagamentosToolStripMenuItem,
            this.usuarioToolStripMenuItem
    });
            this.cadastroToolStripMenuItem.Text = "Cadastro";

            // Medicamentos
            this.medicamentosToolStripMenuItem.Text = "Medicamentos";

            // Fornecedores
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";

            // Clientes
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new EventHandler(this.clientesToolStripMenuItem_Click);

            // Meio de Pagamento
            this.pagamentosToolStripMenuItem.Text = "Meio de Pagamento";

            // Usuário
            this.usuarioToolStripMenuItem.Text = "Usuário";
            this.usuarioToolStripMenuItem.Click += new EventHandler(this.usuarioToolStripMenuItem_Click);


            // Relatórios
            this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
        this.vendasToolStripMenuItem,
        this.estoqueToolStripMenuItem,
        this.financeiroToolStripMenuItem
    });
            this.relatoriosToolStripMenuItem.Text = "Relatórios";

            // Vendas
            this.vendasToolStripMenuItem.Text = "Vendas";

            // Estoque
            this.estoqueToolStripMenuItem.Text = "Estoque";

            // Financeiro
            this.financeiroToolStripMenuItem.Text = "Financeiro";

            // Ferramentas
            this.ferramentasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
        this.configuracoesToolStripMenuItem,
        this.backupToolStripMenuItem
    });
            this.ferramentasToolStripMenuItem.Text = "Ferramentas";

            // Configurações
            this.configuracoesToolStripMenuItem.Text = "Configurações";

            // Backup
            this.backupToolStripMenuItem.Text = "Backup";

            // Sobre
            this.sobreToolStripMenuItem.Text = "Sobre";

            // Botão Sair
            this.btnSair.Location = new System.Drawing.Point(10, 400);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 30);
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new EventHandler(this.btnSair_Click);

            // MenuPrincipal
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnSair);
            this.MainMenuStrip = this.menuStrip1;
            this.Text = "Menu Principal";
            this.ClientSize = new System.Drawing.Size(800, 450);
        }

    }
}
