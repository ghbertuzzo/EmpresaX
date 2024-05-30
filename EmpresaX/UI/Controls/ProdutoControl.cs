using EmpresaX.Business.Services;
using EmpresaX.Data.Entities;

namespace EmpresaX.UI.Controls
{
    public class ProdutoControl
    {
        private readonly IProdutoService _ProdutoService;

        public ProdutoControl(IProdutoService ProdutoService)
        {
            _ProdutoService = ProdutoService;
        }

        public IEnumerable<Produto> GetAllProdutos()
        {
            return _ProdutoService.GetAllProdutos();
        }

        public Produto GetProdutoById(int id)
        {
            return _ProdutoService.GetProdutoById(id);
        }

        public void AddProduto(Produto Produto)
        {
            _ProdutoService.AddProduto(Produto);
        }

        public void UpdateProduto(Produto Produto)
        {
            _ProdutoService.UpdateProduto(Produto);
        }

        public void DeleteProduto(int id)
        {
            _ProdutoService.DeleteProduto(id);
        }
    }
}
