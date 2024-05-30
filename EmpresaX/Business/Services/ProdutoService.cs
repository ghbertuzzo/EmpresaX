using EmpresaX.Business.Validators;
using EmpresaX.Data.Entities;
using EmpresaX.Data.Repositories;

namespace EmpresaX.Business.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _ProdutoRepository;
        private readonly ProdutoValidator _validator;

        public ProdutoService(IProdutoRepository ProdutoRepository)
        {
            _ProdutoRepository = ProdutoRepository;
            _validator = new ProdutoValidator();
        }

        public IEnumerable<Produto> GetAllProdutos()
        {
            return _ProdutoRepository.GetAll();
        }

        public Produto GetProdutoById(int id)
        {
            return _ProdutoRepository.GetById(id);
        }

        public void AddProduto(Produto Produto)
        {
            _validator.Validate(Produto);
            _ProdutoRepository.Add(Produto);
        }

        public void UpdateProduto(Produto Produto)
        {
            _validator.Validate(Produto);
            _ProdutoRepository.Update(Produto);
        }

        public void DeleteProduto(int id)
        {
            _ProdutoRepository.Delete(id);
        }
    }
}
