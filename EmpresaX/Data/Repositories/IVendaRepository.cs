using EmpresaX.Data.Entities;

namespace EmpresaX.Data.Repositories
{
    public interface IVendaRepository
    {
        void AddVenda(Venda venda);
        Venda GetVendaById(int id);
        IEnumerable<Venda> GetAllVendas();
        IEnumerable<VendaDetalhada> GetAllVendasReport();
    }
}
