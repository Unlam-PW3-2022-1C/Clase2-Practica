using Clase2_Practica.Servicios;
using Clase2_Practica.Servicios.Implementaciones;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase2_Practica.Winforms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var services = new ServiceCollection();
            ConfigureServices(services);
            using (var serviceProvider = services.BuildServiceProvider())
            {
                var calculadorIMCForm = serviceProvider.GetRequiredService<CalculadorIMCForm>();
                Application.Run(calculadorIMCForm);
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<ICalculadorIMCService, CalculadorIMCService>()
                .AddScoped<CalculadorIMCForm>();
        }
    }
}
