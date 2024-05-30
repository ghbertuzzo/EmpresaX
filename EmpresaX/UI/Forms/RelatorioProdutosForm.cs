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
    public partial class RelatorioProdutosForm : Form
    {
        private readonly ProdutoControl _produtoControl;
        public RelatorioProdutosForm(ProdutoControl produtoControl)
        {
            InitializeComponent();
            _produtoControl = produtoControl;

        }

        private void RelatorioProdutosForm_Load_1(object sender, EventArgs e)
        {
            var produtos = _produtoControl.GetAllProdutos();

            var reportDataSource = new ReportDataSource("ProdutosDataSet", produtos);

            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EmpresaX.UI.Relatorios.RelatorioProdutos.rdlc";
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
