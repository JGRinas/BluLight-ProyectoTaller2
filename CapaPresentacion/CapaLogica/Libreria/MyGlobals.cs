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

    }
}
