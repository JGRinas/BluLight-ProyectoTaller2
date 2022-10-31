using CapaLogica;
using CapaPresentacion.CapaLogica.LVendedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.CapaPresentacion.VistaVendedor.Ventas
{
    public partial class VentasRealizadas : Form
    {
        LVentasRealizadas ventasR;
        public VentasRealizadas()
        {
            InitializeComponent();
            labelNombre.Text = MyGlobals.persona.nombre;
            labelApellido.Text = MyGlobals.persona.apellido;
            labelDni.Text = MyGlobals.persona.dni.ToString();
            ventasR = new LVentasRealizadas();
            ventasR.rellenarDataGridClientesAtendidos(dataGridViewClientesAtendidos);
            labelTotalVentas.Text = ventasR.calcularTotalVentas().ToString();
        }
    }
}
