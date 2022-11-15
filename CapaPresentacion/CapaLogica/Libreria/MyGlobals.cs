using CapaPresentacion.CapaData.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using CapaLogica;
using CapaPresentacion.CapaData.Model;
using iTextSharp.text.pdf;
using iTextSharp.text;
using LinqToDB.Tools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CapaLogica
{
    public static class MyGlobals
    {

        public static Usuario usuario;
        public static Empleado empleado;
        public static Persona persona;

        public static List<Persona> clienteVentas = new List<Persona>(); //es el cliente seleccionado
        public static List<Label> clienteLabels = new List<Label>(); //nombre, apellido, email, dni del cliente en Label

        public static List<Producto> productoVentas = new List<Producto>();
        public static List<int> cantidadProducto = new List<int>();
        public static DataGridView dataGridProductosVentas = new DataGridView();

        public static Producto productoSeleccionado = new Producto();
        public static int indexProducto = new int();

        public static List<Servicio_laboratorio> servicioVentas = new List<Servicio_laboratorio>(); //servicios del carrito
        public static List<Servicio> servicioVentas2 = new List<Servicio>();
        public static DataGridView dataGridServiciosVentas = new DataGridView();
        public static List<int> cantidadServicio = new List<int>(); //cantidad
        public static int idServSelecc; //id servicio del servicio seleccionado
        public static int idLabSelecc; //lab del servicio seleccionado

        //informe de servicios
        public static List<iTextSharp.text.Image> imagenChartGlobales = new List<iTextSharp.text.Image>();
        public static List<iTextSharp.text.Image> imagenChartTorta = new List<iTextSharp.text.Image>();
    }
}
