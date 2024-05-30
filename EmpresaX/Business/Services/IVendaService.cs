using EmpresaX.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaX.Business.Services
{
    public interface IVendaService
    {
        void AddVenda(Venda venda);
        Venda GetVendaById(int id);
        IEnumerable<Venda> GetAllVendas();
        IEnumerable<VendaDetalhada> GetAllVendasReport();
    }
    
}
