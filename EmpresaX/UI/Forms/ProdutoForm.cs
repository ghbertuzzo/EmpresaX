using EmpresaX.Data.Entities;
using EmpresaX.UI.Controls;

namespace EmpresaX.UI.Forms
{
    public partial class ProdutoForm : Form
    {
        private readonly ProdutoControl _ProdutoControl;

        public ProdutoForm(ProdutoControl ProdutoControl)
        {
            _ProdutoControl = ProdutoControl;
            InitializeComponent();
        }

        private void ProdutoForm_Load(object sender, EventArgs e)
        {
            LoadProdutos();
        }

        private void LoadProdutos()
        {
            var Produtos = _ProdutoControl.GetAllProdutos();
            dgvProdutos.DataSource = Produtos;
            if (dgvProdutos.Columns.Count > 0)
            {
                dgvProdutos.Columns[0].Width = 50; // Largura para a coluna ID
                dgvProdutos.Columns[1].Width = 150; // Largura para a coluna Nome
                dgvProdutos.Columns[2].Width = 250; // Largura para a coluna Descrição
                dgvProdutos.Columns[3].Width = 100; // Largura para a coluna Preço
                dgvProdutos.Columns[4].Width = 100; // Largura para a coluna Estoque
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var Produto = new Produto(txtNome.Text, txtDescricao.Text, Double.Parse(txtPreco.Text), int.Parse(txtEstoque.Text));

            _ProdutoControl.AddProduto(Produto);
            LoadProdutos();
            MessageBox.Show("Produto adicionado com sucesso!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count > 0)
            {
                var Produto = (Produto)dgvProdutos.SelectedRows[0].DataBoundItem;
                Produto.Nome = txtNome.Text;
                Produto.Descricao = txtDescricao.Text;
                Produto.Preco = Double.Parse(txtPreco.Text);
                Produto.Estoque = int.Parse(txtEstoque.Text);

                _ProdutoControl.UpdateProduto(Produto);
                LoadProdutos();
                MessageBox.Show("Produto atualizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Selecione um Produto para atualizar.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count > 0)
            {
                var Produto = (Produto)dgvProdutos.SelectedRows[0].DataBoundItem;
                _ProdutoControl.DeleteProduto(Produto.Id);
                LoadProdutos();
                MessageBox.Show("Produto removido com sucesso!");
            }
            else
            {
                MessageBox.Show("Selecione um Produto para remover.");
            }
        }

        private void dgvProdutos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count > 0)
            {
                var Produto = (Produto)dgvProdutos.SelectedRows[0].DataBoundItem;
                txtNome.Text = Produto.Nome;
                txtDescricao.Text = Produto.Descricao;
                txtPreco.Text = Produto.Preco?.ToString("N2");
                txtEstoque.Text = Produto.Estoque.ToString();
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtNome.Text = String.Empty;
            txtDescricao.Text = String.Empty;
            txtPreco.Text = String.Empty;
            txtEstoque.Text = String.Empty;
        }

    }
}
