using Bunifu.UI.WinForms;
using CapaPresentacion.CapaData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaLogica
{
    public static class MyGlobals
    {
        
        public static Usuario usuario;
        public static Empleado empleado;
        public static Persona persona;

        public static List<Persona> clienteVentas = new List<Persona>();
        public static List<Label> clienteLabels = new List<Label>();

        public static List<Producto> productoVentas = new List<Producto>();
        public static DataGridView dataGridProductosVentas = new DataGridView();
    }
}
