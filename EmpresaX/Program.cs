using EmpresaX.Business.Services;
using EmpresaX.Data.Context;
using EmpresaX.Data.Repositories;
using EmpresaX.UI.Controls;
using EmpresaX.UI.Forms;
using Microsoft.Extensions.DependencyInjection;

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

            var services = ConfigureServices();
            var serviceProvider = services.BuildServiceProvider();

            var mainForm = serviceProvider.GetRequiredService<MainForm>();

            Application.Run(mainForm);

        }

        private static IServiceCollection ConfigureServices()
        {
            var services = new ServiceCollection();

            // Register context
            services.AddSingleton<AppDbContext>();

            // Register repositories
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IVendaRepository, VendaRepository>();

            // Register services
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IProdutoService, ProdutoService>();
            services.AddScoped<IVendaService, VendaService>();

            // Register controls
            services.AddScoped<ClienteControl>();
            services.AddScoped<ProdutoControl>();
            services.AddScoped<VendaControl>();

            // Register forms
            services.AddScoped<MainForm>();

            return services;
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