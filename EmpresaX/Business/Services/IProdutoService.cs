using EmpresaX.Data.Entities;

namespace EmpresaX.Business.Services
{
    public interface IProdutoService
    {
        IEnumerable<Produto> GetAllProdutos();
        Produto GetProdutoById(int id);
        void AddProduto(Produto Produto);
        void UpdateProduto(Produto Produto);
        void DeleteProduto(int id);
    }
}
