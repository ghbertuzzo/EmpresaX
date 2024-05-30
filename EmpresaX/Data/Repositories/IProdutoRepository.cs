using EmpresaX.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
