using EmpresaX.Data.Entities;
using EmpresaX.Data.Repositories;
using EmpresaX.Business.Validators;

namespace EmpresaX.Business.Services
{
    public class VendaService : IVendaService
    {
        private readonly IVendaRepository _vendaRepository;
        private readonly IProdutoRepository _produtoRepository;
        private readonly VendaValidator _vendaValidator;

        public VendaService(IVendaRepository vendaRepository, IProdutoRepository produtoRepository)
        {
            _vendaRepository = vendaRepository;
            _produtoRepository = produtoRepository;
            _vendaValidator = new VendaValidator();
        }

        public void AddVenda(Venda venda)
        {
            _vendaValidator.Validate(venda);
            ValidateEstoque(venda);
            _vendaRepository.AddVenda(venda);
        }

        public Venda GetVendaById(int id)
        {
            return _vendaRepository.GetVendaById(id);
        }

        public IEnumerable<Venda> GetAllVendas()
        {
            return _vendaRepository.GetAllVendas();
        }

        public IEnumerable<VendaDetalhada> GetAllVendasReport()
        {
            return _vendaRepository.GetAllVendasReport();
        }

        //ajustar validação para que caso o usuário adicione o mesmo produto mais de uma vez, seja feita a soma das quantidades do mesmo produto antes da validação
        private void ValidateEstoque(Venda venda)
        {
            foreach (var item in venda.Itens)
            {
                var produto = _produtoRepository.GetById(item.ProdutoId);
                if (produto == null)
                {
                    throw new Exception($"Produto com ID {item.ProdutoId} não encontrado.");
                }

                if (produto.Estoque < item.Quantidade)
                {
                    throw new Exception($"Quantidade solicitada para o produto {produto.Nome} excede o estoque disponível.");
                }
            }
        }
    }
}
