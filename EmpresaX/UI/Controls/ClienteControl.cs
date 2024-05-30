using EmpresaX.Business.Services;
using EmpresaX.Data.Entities;

namespace EmpresaX.UI.Controls
{
    public class ClienteControl
    {
        private readonly IClienteService _clienteService;

        public ClienteControl(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        public IEnumerable<Cliente> GetAllClientes()
        {
            return _clienteService.GetAllClientes();
        }

        public Cliente GetClienteById(int id)
        {
            return _clienteService.GetClienteById(id);
        }

        public void AddCliente(Cliente cliente)
        {
            _clienteService.AddCliente(cliente);
        }

        public void UpdateCliente(Cliente cliente)
        {
            _clienteService.UpdateCliente(cliente);
        }

        public void DeleteCliente(int id)
        {
            _clienteService.DeleteCliente(id);
        }
    }
}
