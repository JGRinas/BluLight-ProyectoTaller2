using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica.LVendedor;
using CapaPresentacion.CapaPresentacion.VistaRecepcionista.Servicios.Childrenforms;
using CapaPresentacion.CapaLogica.LRecepcionistaok;

namespace CapaPresentacion.VistaRecepcionista.Servicios
{
    public partial class NuevaSolicitud : Form
    {
        LVentasServicio venta;
        public NuevaSolicitud()
        {
            InitializeComponent();
            venta = new LVentasServicio();

            if (MyGlobals.clienteVentas.Count > 0)
            {
                labelApellidoC.Text = MyGlobals.clienteVentas[0].apellido.ToString();
                labelDniC.Text = MyGlobals.clienteVentas[0].dni.ToString();
                labelNombreC.Text = MyGlobals.clienteVentas[0].nombre.ToString();
                labelEmailC.Text = MyGlobals.clienteVentas[0].email.ToString();
                labelApellidoC.Visible = true;
                labelDniC.Visible = true;
                labelNombreC.Visible = true;
                labelEmailC.Visible = true;
                btnBuscarServicio.Enabled = true;
                //buttonCancelarCompra.Enabled = true;
                if (MyGlobals.servicioVentas.Count > 0)
                {
                    datagridCarrito.Rows.Clear();
                    venta.rellenarDataGridCarritoServicios(datagridCarrito);
                    btnFinalizarCompra.Enabled = true;
                    decimal total = 0;
                    for (int i = 0; i < MyGlobals.productoVentas.Count; i++)
                    {
                        total = MyGlobals.productoVentas[i].precio * MyGlobals.cantidadProducto[i];
                        labelTotal.Text = total.ToString();
                    }
                }
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            List<Label> labels = new List<Label>();
            labels.Add(labelNombreC);
            labels.Add(labelApellidoC);
            labels.Add(labelDniC);
            labels.Add(labelEmailC);
            venta.refrescarClienteCarritoServ(labels);
            BuscarClienteVenta cliente = new BuscarClienteVenta();
            cliente.ShowDialog();
            datagridCarrito.Rows.Clear();
            venta.rellenarDataGridCarritoServicios(datagridCarrito);
            if (MyGlobals.clienteVentas.Count > 0)
            {
                labelApellidoC.Text = MyGlobals.clienteVentas[0].apellido.ToString();
                labelApellidoC.Visible = true;
                labelDniC.Text = MyGlobals.clienteVentas[0].dni.ToString();
                labelDniC.Visible = true;
                labelNombreC.Text = MyGlobals.clienteVentas[0].nombre.ToString();
                labelNombreC.Visible = true;
                labelEmailC.Text = MyGlobals.clienteVentas[0].email.ToString();
                labelEmailC.Visible = true;
                btnBuscarServicio.Enabled = true;
                //btnCancelarCompra.Enabled = true;
            }
        }

        private void btnBuscarServicio_Click(object sender, EventArgs e)
        {
            MyGlobals.dataGridServiciosVentas = datagridCarrito;
            BuscarServicioVenta servicio = new BuscarServicioVenta();
            servicio.ShowDialog();

            if (MyGlobals.servicioVentas.Count > 0)
            {
                datagridCarrito.Rows.Clear();
                venta.rellenarDataGridCarritoServicios(datagridCarrito);
                btnFinalizarCompra.Enabled = true;

                decimal total = 0;
                for (int i = 0; i < MyGlobals.servicioVentas.Count; i++)
                {
                    total = MyGlobals.servicioVentas2[i].precio * MyGlobals.cantidadServicio[i];
                    labelTotal.Text = "Total: $" + total.ToString();
                }
            }
        }

        private void btnFinalizarCompra_Click(object sender, EventArgs e)
        {
            FinalizarCompra finalizarCompra = new FinalizarCompra();
            finalizarCompra.ShowDialog();
            if (MyGlobals.servicioVentas.Count == 0)
            {
                List<Button> buttons = new List<Button>();
                buttons.Add(btnBuscarServicio);
                buttons.Add(btnFinalizarCompra);
                //buttons.Add(btnCancelarCompra);

                List<Label> labels = new List<Label>();
                labels.Add(labelApellidoC);
                labels.Add(labelDniC);
                labels.Add(labelEmailC);
                labels.Add(labelNombreC);
                labels.Add(labelTotal);

                venta.cancelarVenta(buttons, labels);
                datagridCarrito.Rows.Clear();
                venta.rellenarDataGridCarritoServicios(datagridCarrito);
            }
        }

        private void datagridCarrito_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                venta.borrarProductoCarrito(datagridCarrito);

                datagridCarrito.Rows.Clear();
                venta.rellenarDataGridCarritoServicios(datagridCarrito);
                decimal total = 0;
                for (int i = 0; i < MyGlobals.productoVentas.Count; i++)
                {
                    total = MyGlobals.productoVentas[i].stock * MyGlobals.cantidadProducto[i];
                    labelTotal.Text = total.ToString();
                }
            }
            //if (e.ColumnIndex == 6)
            //{
            //    MyGlobals.productoSeleccionado = MyGlobals.productoVentas[e.RowIndex];
            //    MyGlobals.indexProducto = e.RowIndex;

            //    EditarProducto editarProducto = new EditarProducto();
            //    editarProducto.ShowDialog();
            //    dataGridViewCarrito.Rows.Clear();
            //    venta.rellenarDataGridCarritoProductos(dataGridViewCarrito);
            //    decimal total = 0;
            //    for (int i = 0; i < MyGlobals.productoVentas.Count; i++)
            //    {
            //        total = MyGlobals.productoVentas[i].precio * MyGlobals.cantidadProducto[i];
            //        labelTotal.Text = total.ToString();
            //    }
            //}

        }

    }
}
