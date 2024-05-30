using EmpresaX.Data.Entities;

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
