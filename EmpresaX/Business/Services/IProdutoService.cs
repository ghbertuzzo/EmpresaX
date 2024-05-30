using EmpresaX.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
