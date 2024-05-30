using EmpresaX.Data.Entities;
using EmpresaX.UI.Controls;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaX.UI.Forms
{
    public partial class RelatorioVendasForm : Form
    {
        private readonly ProdutoControl _produtoControl;
        private readonly ClienteControl _clienteControl;
        private readonly VendaControl _vendaControl;
        public RelatorioVendasForm(ProdutoControl produtoControl, ClienteControl clienteControl, VendaControl vendaControl)
        {
            _produtoControl = produtoControl;
            _clienteControl = clienteControl;
            _vendaControl = vendaControl;
            InitializeComponent();
        }

        private void RelatorioVendasForm_Load(object sender, EventArgs e)
        {
            var vendas = _vendaControl.GetAllVendasReport();

            var reportDataSource = new ReportDataSource("VendasDataSet", vendas);

            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EmpresaX.UI.Relatorios.RelatorioVendas.rdlc";
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
