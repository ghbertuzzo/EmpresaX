using EmpresaX.UI.Controls;

namespace EmpresaX.UI.Forms
{
    public partial class MainForm : Form
    {
        private readonly ClienteControl _clienteControl;
        private readonly ProdutoControl _produtoControl;
        private readonly VendaControl _vendaControl;
        public MainForm(ClienteControl clienteControl, ProdutoControl produtoControl, VendaControl vendaControl)
        {
            _clienteControl = clienteControl;
            _produtoControl = produtoControl;
            _vendaControl = vendaControl;
            InitializeComponent();
        }

        public void openForm(string typeForm)
        {
            if (typeForm.Equals("Clientes"))
            {
                var clienteForm = new ClienteForm(_clienteControl);
                clienteForm.Show();
            }
            else if (typeForm.Equals("Produtos"))
            {
                var produtoForm = new ProdutoForm(_produtoControl);
                produtoForm.Show();
            }
            else if (typeForm.Equals("Vendas"))
            {
                var vendaForm = new VendaForm(_clienteControl, _produtoControl, _vendaControl);
                vendaForm.Show();
            }
            else if (typeForm.Equals("RelClientes"))
            {
                var relClientesForm = new RelatorioClientesForm(_clienteControl);
                relClientesForm.Show();
            }
            else if (typeForm.Equals("RelProdutos"))
            {
                var relProdutosForm = new RelatorioProdutosForm(_produtoControl);
                relProdutosForm.Show();
            }
            else if (typeForm.Equals("RelVendas"))
            {
                var relVendasForm = new RelatorioVendasForm(_produtoControl, _clienteControl, _vendaControl);
                relVendasForm.Show();
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            openForm("Clientes");
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            openForm("Produtos");
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm("Clientes");
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm("Produtos");
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            openForm("Vendas");
        }

        private void novaVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm("Vendas");
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openForm("RelClientes");
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm("RelProdutos");
        }

        private void vendasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openForm("RelVendas");
        }
    }
}
