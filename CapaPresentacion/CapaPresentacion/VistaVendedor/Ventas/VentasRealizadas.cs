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
            dateTimePickerFiltro.Value = DateTime.Now;
            labelNombre.Text = MyGlobals.persona.nombre;
            labelApellido.Text = MyGlobals.persona.apellido;
            labelDni.Text = MyGlobals.persona.dni.ToString();
            ventasR = new LVentasRealizadas();
            ventasR.rellenarDataGridClientesAtendidos(dataGridViewClientesAtendidos, dateTimePickerFiltro, labelClientesAtendidosEn);
            labelTotalVentas.Text = ventasR.calcularTotalVentas().ToString();
        }

        private void dataGridViewClientesAtendidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int nroVenta = Int32.Parse(dataGridViewClientesAtendidos.CurrentRow.Cells["ColumnId"].Value.ToString());
            List<Label> labels = new List<Label>();
            labels.Add(labelTotalVenta);
            labels.Add(labelCliente);
            labels.Add(labelDniCliente);
            labels.Add(labelCorreoCliente);
            labels.Add(labelFormaDePago);
            
            ventasR.buscarVentaDataGrid(nroVenta, labels, textBoxProductos);
        }

        private void dateTimePickerFiltro_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonBuscarProducto_Click(object sender, EventArgs e)
        {
            dataGridViewClientesAtendidos.Rows.Clear();
            ventasR.rellenarDataGridClientesAtendidos(dataGridViewClientesAtendidos, dateTimePickerFiltro, labelClientesAtendidosEn);
        }
    }
}
