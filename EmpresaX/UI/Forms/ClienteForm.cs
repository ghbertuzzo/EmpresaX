using EmpresaX.Data.Entities;
using EmpresaX.UI.Controls;

namespace EmpresaX
{
    public partial class ClienteForm : Form
    {
        private readonly ClienteControl _clienteControl;

        public ClienteForm(ClienteControl clienteControl)
        {
            _clienteControl = clienteControl;
            InitializeComponent();
        }

        private void ClienteForm_Load(object sender, EventArgs e)
        {
            LoadClientes();
        }

        private void LoadClientes()
        {
            var clientes = _clienteControl.GetAllClientes();
            dgvClientes.DataSource = clientes;
            if (dgvClientes.Columns.Count > 0)
            {
                dgvClientes.Columns[0].Width = 50; // Largura para a coluna ID
                dgvClientes.Columns[1].Width = 125; // Largura para a coluna Nome
                dgvClientes.Columns[2].Width = 175; // Largura para a coluna Endereco
                dgvClientes.Columns[3].Width = 100; // Largura para a coluna Telefone
                dgvClientes.Columns[4].Width = 200; // Largura para a coluna Email
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente(txtNome.Text, txtEndereco.Text, txtTelefone.Text, txtEmail.Text);

            _clienteControl.AddCliente(cliente);
            LoadClientes();
            MessageBox.Show("Cliente adicionado com sucesso!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                var cliente = (Cliente)dgvClientes.SelectedRows[0].DataBoundItem;
                cliente.Nome = txtNome.Text;
                cliente.Endereco = txtEndereco.Text;
                cliente.Telefone = txtTelefone.Text;
                cliente.Email = txtEmail.Text;

                _clienteControl.UpdateCliente(cliente);
                LoadClientes();
                MessageBox.Show("Cliente atualizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Selecione um cliente para atualizar.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                var cliente = (Cliente)dgvClientes.SelectedRows[0].DataBoundItem;
                _clienteControl.DeleteCliente(cliente.Id);
                LoadClientes();
                MessageBox.Show("Cliente removido com sucesso!");
            }
            else
            {
                MessageBox.Show("Selecione um cliente para remover.");
            }
        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                var cliente = (Cliente)dgvClientes.SelectedRows[0].DataBoundItem;
                txtNome.Text = cliente.Nome;
                txtEndereco.Text = cliente.Endereco;
                txtTelefone.Text = cliente.Telefone;
                txtEmail.Text = cliente.Email;
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtNome.Text = String.Empty;
            txtEndereco.Text = String.Empty;
            txtTelefone.Text = String.Empty;
            txtEmail.Text = String.Empty;
        }
    }
}
