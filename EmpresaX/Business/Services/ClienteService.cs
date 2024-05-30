using EmpresaX.Business.Validators;
using EmpresaX.Data.Entities;
using EmpresaX.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaX.Business.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly ClienteValidator _validator;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
            _validator = new ClienteValidator();
        }

        public IEnumerable<Cliente> GetAllClientes()
        {
            return _clienteRepository.GetAll();
        }

        public Cliente GetClienteById(int id)
        {
            return _clienteRepository.GetById(id);
        }

        public void AddCliente(Cliente cliente)
        {
            _validator.Validate(cliente);
            _clienteRepository.Add(cliente);
        }

        public void UpdateCliente(Cliente cliente)
        {
            _validator.Validate(cliente);
            _clienteRepository.Update(cliente);
        }

        public void DeleteCliente(int id)
        {
            _clienteRepository.Delete(id);
        }
    }
}
