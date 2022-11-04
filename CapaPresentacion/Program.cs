using CapaPresentacion;
using Proyecto2022;
using Proyecto2022.CapaPresentacion;
using Proyecto2022.CapaPresentacion.VistaJefeLaboratorio;
using Proyecto2022.CapaPresentacion.VistaVendedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

         // FormOpen formOpen = new FormOpen();
            // FormVendedorInicio formOpen = new FormVendedorInicio();
            FormSesion formOpen = new FormSesion();
            formOpen.Show();

           
           
            Application.Run();
        }
    }
}
