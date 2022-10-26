using CapaLogica;
using CapaPresentacion.CapaData.Model;
using CapaPresentacion.CapaLogica.LVendedor;
using CapaPresentacion.CapaPresentacion.VistaVendedor.Ventas.NuevaVentaSubForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.VistaVendedor.Ventas
{
    public partial class NuevaVenta : Form
    {
        LVentas venta;
        public NuevaVenta()
        {
            InitializeComponent();
            venta = new LVentas();

            if (MyGlobals.clienteVentas.Count > 0)
            {
                labelApellidoC.Text = MyGlobals.clienteVentas[0].apellido.ToString();
                labelDniC.Text = MyGlobals.clienteVentas[0].dni.ToString();
                labelNombreC.Text = MyGlobals.clienteVentas[0].nombre.ToString();
                labelEmailC.Text = MyGlobals.clienteVentas[0].email.ToString();
                buttonBuscarProducto.Enabled = true;
                buttonCancelarCompra.Enabled = true;
                if (MyGlobals.productoVentas.Count > 0)
                {
                    dataGridViewCarrito.Rows.Clear();
                    venta.rellenarDataGridCarritoProductos(dataGridViewCarrito);
                    buttonFinalizarCompra.Enabled = true;
                }
            }
        }

        private void buttonBuscarCliente_Click(object sender, EventArgs e)
        {
            List<Label> labels = new List<Label>();
            labels.Add(labelNombreC);
            labels.Add(labelApellidoC);
            labels.Add(labelDniC);
            labels.Add(labelEmailC);
            venta.refrescarClienteCarrito(labels);
            BuscarClienteVenta cliente = new BuscarClienteVenta();
            cliente.ShowDialog();
            if (MyGlobals.clienteVentas.Count > 0)
            {
                labelApellidoC.Text = MyGlobals.clienteVentas[0].apellido.ToString();
                labelDniC.Text = MyGlobals.clienteVentas[0].dni.ToString();
                labelNombreC.Text = MyGlobals.clienteVentas[0].nombre.ToString();
                labelEmailC.Text = MyGlobals.clienteVentas[0].email.ToString();
                buttonBuscarProducto.Enabled = true;
                buttonCancelarCompra.Enabled = true;
            }
        }

        private void buttonBuscarProducto_Click(object sender, EventArgs e)
        {
            MyGlobals.dataGridProductosVentas = dataGridViewCarrito;
            BuscarProductoVenta producto = new BuscarProductoVenta();
            producto.ShowDialog();

            

            if (MyGlobals.productoVentas.Count > 0)
            {
                dataGridViewCarrito.Rows.Clear();
                venta.rellenarDataGridCarritoProductos(dataGridViewCarrito);
                buttonFinalizarCompra.Enabled = true;
            }
        }

        private void dataGridViewCarrito_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(dataGridViewCarrito_KeyPress);
            if (dataGridViewCarrito.CurrentCell.ColumnIndex == 2)
            {
                if (Int32.Parse(dataGridViewCarrito.CurrentRow.Cells[2].Value.ToString()) > 500)
                {
                    dataGridViewCarrito.CurrentRow.Cells[2].Value = 500;
                }
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(dataGridViewCarrito_KeyPress);
                }
            }
        }

        private void dataGridViewCarrito_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
        }

        private void buttonCancelarCompra_Click(object sender, EventArgs e)
        {
            List<Button> buttons = new List<Button>();
            buttons.Add(buttonBuscarProducto);
            buttons.Add(buttonFinalizarCompra);
            buttons.Add(buttonCancelarCompra);

            List<Label> labels = new List<Label>();
            labels.Add(labelApellidoC);
            labels.Add(labelDniC);
            labels.Add(labelEmailC);
            labels.Add(labelNombreC);
            labels.Add(labelTotal);
            venta.cancelarVenta(buttons, labels);

            dataGridViewCarrito.Rows.Clear();
           
        }

        private void dataGridViewCarrito_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                venta.borrarProductoCarrito(dataGridViewCarrito);
                
                dataGridViewCarrito.Rows.Clear();
                venta.rellenarDataGridCarritoProductos(dataGridViewCarrito);
            }
        }

        private void dataGridViewCarrito_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if ()
            {

            }
        }
    }
}
