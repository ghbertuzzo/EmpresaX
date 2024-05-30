using EmpresaX.Data.Entities;

namespace EmpresaX.Business.Services
{
    public interface IClienteService
    {
        IEnumerable<Cliente> GetAllClientes();
        Cliente GetClienteById(int id);
        void AddCliente(Cliente cliente);
        void UpdateCliente(Cliente cliente);
        void DeleteCliente(int id);
    }
}
