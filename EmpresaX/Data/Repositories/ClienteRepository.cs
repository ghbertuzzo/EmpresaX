using EmpresaX.Data.Context;
using EmpresaX.Data.Entities;
using Dapper;

namespace EmpresaX.Data.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly AppDbContext _context;

        public ClienteRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Cliente> GetAll()
        {
            using (var connection = _context.GetConnection())
            {
                return connection.Query<Cliente>("SELECT * FROM clientes");
            }
        }

        public Cliente GetById(int id)
        {
            using (var connection = _context.GetConnection())
            {
                var cliente = connection.QuerySingleOrDefault<Cliente>("SELECT * FROM clientes WHERE id = @Id", new { Id = id });
                if (cliente == null)
                {
                    throw new KeyNotFoundException("Cliente não encontrado.");
                }

                return cliente;
            }
        }

        public void Add(Cliente cliente)
        {
            using (var connection = _context.GetConnection())
            {
                var sql = "INSERT INTO clientes (nome, endereco, telefone, email) VALUES (@Nome, @Endereco, @Telefone, @Email)";
                connection.Execute(sql, cliente);
            }
        }

        public void Update(Cliente cliente)
        {
            using (var connection = _context.GetConnection())
            {
                var sql = "UPDATE clientes SET nome = @Nome, endereco = @Endereco, telefone = @Telefone, email = @Email WHERE id = @Id";
                connection.Execute(sql, cliente);
            }
        }

        public void Delete(int id)
        {
            using (var connection = _context.GetConnection())
            {
                var sql = "DELETE FROM clientes WHERE id = @Id";
                connection.Execute(sql, new { Id = id });
            }
        }
    }
}
