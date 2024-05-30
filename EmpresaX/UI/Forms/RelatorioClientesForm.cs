using EmpresaX.UI.Controls;
using Microsoft.Reporting.WinForms;

namespace EmpresaX.UI.Forms
{
    public partial class RelatorioClientesForm : Form
    {
        private readonly ClienteControl _clienteControl;
        public RelatorioClientesForm(ClienteControl clienteControl)
        {
            InitializeComponent();
            _clienteControl = clienteControl;

        }

        private void RelatorioClientesForm_Load(object sender, EventArgs e)
        {
            var clientes = _clienteControl.GetAllClientes();

            var reportDataSource = new ReportDataSource("ClientesDataSet", clientes);

            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EmpresaX.UI.Relatorios.RelatorioClientes.rdlc";
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
