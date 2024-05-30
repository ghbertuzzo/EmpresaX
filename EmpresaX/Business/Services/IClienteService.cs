using EmpresaX.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
