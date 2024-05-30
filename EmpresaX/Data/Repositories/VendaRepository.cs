using Dapper;
using EmpresaX.Data.Context;
using EmpresaX.Data.Entities;

namespace EmpresaX.Data.Repositories
{
    public class VendaRepository : IVendaRepository
    {
        private readonly AppDbContext _context;

        public VendaRepository(AppDbContext context)
        {
            _context = context;
        }

        public void AddVenda(Venda venda)
        {
            using (var connection = _context.GetConnection())
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        var vendaId = connection.QuerySingle<int>(
                            "INSERT INTO vendas (cliente_id, data_venda) VALUES (@ClienteId, @DataVenda) RETURNING id",
                            new { venda.ClienteId, venda.DataVenda }, transaction);

                        foreach (var item in venda.Itens)
                        {
                            connection.Execute(
                                "INSERT INTO itens_venda (venda_id, produto_id, quantidade, preco_unitario) VALUES (@VendaId, @ProdutoId, @Quantidade, @Preco)",
                                new { VendaId = vendaId, item.ProdutoId, item.Quantidade, item.Preco }, transaction);

                            connection.Execute(
                                "UPDATE produtos SET estoque = estoque - @Quantidade WHERE id = @ProdutoId",
                                new { item.Quantidade, item.ProdutoId }, transaction);
                        }

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public Venda GetVendaById(int id)
        {
            using (var connection = _context.GetConnection())
            {
                var venda = connection.QuerySingleOrDefault<Venda>(
                    "SELECT * FROM vendas WHERE id = @Id", new { Id = id });

                if (venda != null)
                {
                    venda.Itens = connection.Query<VendaItem>(
                        "SELECT * FROM itens_venda WHERE venda_id = @VendaId", new { VendaId = id }).ToList();
                }

                return venda;
            }
        }

        public IEnumerable<Venda> GetAllVendas()
        {
            using (var connection = _context.GetConnection())
            {
                var vendas = connection.Query<Venda>("SELECT * FROM vendas").ToList();

                foreach (var venda in vendas)
                {
                    venda.Itens = connection.Query<VendaItem>(
                        "SELECT * FROM itens_venda WHERE venda_id = @VendaId", new { VendaId = venda.Id }).ToList();
                }

                return vendas;
            }
        }

        public IEnumerable<VendaDetalhada> GetAllVendasReport()
        {
            using (var connection = _context.GetConnection())
            {
                string sql = @"
                SELECT 
                    v.id AS VendaId,
                    c.nome AS NomeCliente,
                    v.data_venda AS DataVenda,
                    p.nome AS NomeProduto,
                    iv.quantidade AS Quantidade,
                    iv.preco_unitario AS PrecoUnitario,
                    iv.quantidade * iv.preco_unitario AS Subtotal
                FROM vendas v
                JOIN clientes c ON v.cliente_id = c.id
                JOIN itens_venda iv ON v.id = iv.venda_id
                JOIN produtos p ON iv.produto_id = p.id
                ORDER BY v.id;";

                var result = connection.Query<VendaDetalhada>(sql).ToList();
                return result;
            }
        }
    }
}
