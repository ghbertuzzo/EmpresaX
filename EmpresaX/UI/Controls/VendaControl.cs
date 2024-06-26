﻿using EmpresaX.Business.Services;
using EmpresaX.Data.Entities;

namespace EmpresaX.UI.Controls
{
    public class VendaControl
    {
        private readonly IVendaService _vendaService;

        public VendaControl(IVendaService vendaService)
        {
            _vendaService = vendaService;
        }

        public void AddVenda(Venda venda)
        {
            _vendaService.AddVenda(venda);
        }

        public Venda GetVendaById(int id)
        {
            return _vendaService.GetVendaById(id);
        }

        public IEnumerable<Venda> GetAllVendas()
        {
            return _vendaService.GetAllVendas();
        }
        public IEnumerable<VendaDetalhada> GetAllVendasReport()
        {
            return _vendaService.GetAllVendasReport();
        }
    }
}
