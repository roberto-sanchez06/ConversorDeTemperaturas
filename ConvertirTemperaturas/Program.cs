using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppCore.Interfaces;
using AppCore.Services;
using Autofac;
using Domain.Interfaces;
using Infraestructure;

namespace ConvertirTemperaturas
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<TemperaturaRepository>().As<ITemperaturaRepository>();
            builder.RegisterType<TemperaturaService>().As<ITemperaturaService>();
            var container = builder.Build();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmTemperaturas(container.Resolve<ITemperaturaService>()));
        }
    }
}
