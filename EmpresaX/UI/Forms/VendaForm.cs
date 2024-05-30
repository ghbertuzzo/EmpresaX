using EmpresaX.Data.Entities;
using EmpresaX.UI.Controls;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaX.UI.Forms
{
    public partial class VendaForm : Form
    {
        private readonly ClienteControl _clienteControl;
        private readonly ProdutoControl _produtoControl;
        private readonly VendaControl _vendaControl;

        private Double? totalValue = 0;
        public VendaForm(ClienteControl clienteControl, ProdutoControl produtoControl, VendaControl vendaControl)
        {
            _clienteControl = clienteControl;
            _produtoControl = produtoControl;
            _vendaControl = vendaControl;
            InitializeComponent();
        }

        private void VendaForm_Load(object sender, EventArgs e)
        {
            LoadClientes();
            LoadProdutos();
            InitializeDataGridView();
        }

        private void LoadClientes()
        {
            var clientes = _clienteControl.GetAllClientes();
            cmbClientes.DataSource = clientes;
            cmbClientes.DisplayMember = "Nome";
            cmbClientes.ValueMember = "Id";
        }

        private void LoadProdutos()
        {
            var produtos = _produtoControl.GetAllProdutos();
            cmbProdutos.DataSource = produtos;
            cmbProdutos.DisplayMember = "Nome";
            cmbProdutos.ValueMember = "Id";
        }

        private void InitializeDataGridView()
        {
            dgvItensVenda.Columns.Add("ProdutoId", "ID do Produto");
            dgvItensVenda.Columns.Add("NomeProduto", "Nome do Produto");
            dgvItensVenda.Columns.Add("Quantidade", "Quantidade");
            dgvItensVenda.Columns.Add("Preco", "Preço");
            dgvItensVenda.Columns.Add("SubTotal", "SubTotal");
            dgvItensVenda.Columns["ProdutoId"].Visible = false;

            var removeButtonColumn = new DataGridViewImageColumn
            {
                Name = "Remove",
                HeaderText = "Ações",
                Image = Properties.Resources.delete64,
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };
            dgvItensVenda.Columns.Add(removeButtonColumn);
            dgvItensVenda.CellClick += DgvItens_CellClick;

            if (dgvItensVenda.Columns.Count > 0)
            {
                dgvItensVenda.Columns[1].Width = 200; // Largura para a coluna Nome
                dgvItensVenda.Columns[2].Width = 100;  // Largura para a coluna Quantidade
                dgvItensVenda.Columns[3].Width = 100; // Largura para a coluna Preço
                dgvItensVenda.Columns[4].Width = 100; // Largura para a coluna SubTotal
            }
        }

        private void DgvItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvItensVenda.Columns["Remove"].Index)
                {
                    RemoverItem(e.RowIndex);
                }
            }
        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            if (cmbProdutos.SelectedItem != null && int.TryParse(txtQuantidade.Text, out int quantidade) && quantidade > 0)
            {
                var produto = (Produto)cmbProdutos.SelectedItem;
                Double? subTotal = produto.Preco > 0 ? produto.Preco * quantidade : 0;
                totalValue += subTotal;

                dgvItensVenda.Rows.Add(produto.Id, produto.Nome, quantidade, produto.Preco?.ToString("N2"), subTotal?.ToString("N2"));

                lblTotalValue.Text = totalValue?.ToString("N2");
            }
            else
            {
                MessageBox.Show("Selecione um produto e insira uma quantidade válida.");
            }
        }

        private void RemoverItem(int rowIndex)
        {
            try
            {
                var subtotal = Convert.ToDouble(dgvItensVenda.Rows[rowIndex].Cells[4].Value);
                dgvItensVenda.Rows.RemoveAt(rowIndex);
                totalValue -= subtotal;
                lblTotalValue.Text = totalValue?.ToString("N2");
            } catch (Exception ex)
            {

            }
        }

        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbClientes.SelectedItem != null && dgvItensVenda.Rows.Count > 0)
                {
                    var cliente = (Cliente)cmbClientes.SelectedItem;
                    var venda = new Venda { ClienteId = cliente.Id, DataVenda = DateTime.Now };

                    foreach (DataGridViewRow row in dgvItensVenda.Rows)
                    {
                        if (row.Cells["ProdutoId"].Value != null)
                        {
                            var vendaItem = new VendaItem
                            {
                                ProdutoId = (int)row.Cells["ProdutoId"].Value,
                                Quantidade = int.Parse(row.Cells["Quantidade"].Value.ToString()),
                                Preco = decimal.Parse(row.Cells["Preco"].Value.ToString(), NumberStyles.Currency)
                            };

                            venda.Itens.Add(vendaItem);
                        }
                    }

                    _vendaControl.AddVenda(venda);

                    MessageBox.Show("Venda registrada com sucesso!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Selecione um cliente e adicione produtos à venda.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao realizar a venda: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
