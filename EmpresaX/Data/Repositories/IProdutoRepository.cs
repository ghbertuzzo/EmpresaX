using EmpresaX.Data.Entities;

namespace EmpresaX.Data.Repositories
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> GetAll();
        Produto GetById(int id);
        void Add(Produto Produto);
        void Update(Produto Produto);
        void Delete(int id);
    }
}
