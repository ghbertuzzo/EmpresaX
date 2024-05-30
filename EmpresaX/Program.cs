using EmpresaX.Business.Services;
using EmpresaX.Data.Context;
using EmpresaX.Data.Repositories;
using EmpresaX.UI.Controls;
using EmpresaX.UI.Forms;

namespace EmpresaX
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            Application.ThreadException += Application_ThreadException;

            var dbContext = new AppDbContext();

            var clienteRepository = new ClienteRepository(dbContext);
            var clienteService = new ClienteService(clienteRepository);
            var clienteControl = new ClienteControl(clienteService);

            var produtoRepository = new ProdutoRepository(dbContext);
            var produtoService = new ProdutoService(produtoRepository);
            var produtoControl = new ProdutoControl(produtoService);

            var vendaRepository = new VendaRepository(dbContext);
            var vendaService = new VendaService(vendaRepository, produtoRepository);
            var vendaControl = new VendaControl(vendaService);

            var mainFrame = new MainForm(clienteControl,produtoControl,vendaControl);
            Application.Run(mainFrame);

        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var exception = e.ExceptionObject as Exception;
            MessageBox.Show($"Erro inesperado: {exception?.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            MessageBox.Show($"Erro inesperado: {e.Exception.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}