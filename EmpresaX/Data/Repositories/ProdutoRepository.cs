using EmpresaX.Data.Context;
using EmpresaX.Data.Entities;
using Dapper;

namespace EmpresaX.Data.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDbContext _context;

        public ProdutoRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Produto> GetAll()
        {
            using (var connection = _context.GetConnection())
            {
                return connection.Query<Produto>("SELECT * FROM Produtos");
            }
        }

        public Produto GetById(int id)
        {
            using (var connection = _context.GetConnection())
            {
                var Produto = connection.QuerySingleOrDefault<Produto>("SELECT * FROM Produtos WHERE id = @Id", new { Id = id });
                if (Produto == null)
                {
                    throw new KeyNotFoundException("Produto não encontrado.");
                }

                return Produto;
            }
        }

        public void Add(Produto Produto)
        {
            using (var connection = _context.GetConnection())
            {
                var sql = "INSERT INTO Produtos (nome, descricao, preco, estoque) VALUES (@Nome, @Descricao, @Preco, @Estoque)";
                connection.Execute(sql, Produto);
            }
        }

        public void Update(Produto Produto)
        {
            using (var connection = _context.GetConnection())
            {
                var sql = "UPDATE Produtos SET nome = @Nome, descricao = @Descricao, preco = @Preco, estoque = @Estoque WHERE id = @Id";
                connection.Execute(sql, Produto);
            }
        }

        public void Delete(int id)
        {
            using (var connection = _context.GetConnection())
            {
                var sql = "DELETE FROM Produtos WHERE id = @Id";
                connection.Execute(sql, new { Id = id });
            }
        }
    }
}
