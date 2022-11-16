﻿using CapaLogica;
using CapaPresentacion.CapaData.Model;
using CapaPresentacion.CapaLogica.LVendedor;
using CapaPresentacion.CapaPresentacion.VistaVendedor.Ventas.NuevaVentaSubForms;
using iTextSharp.text.pdf.parser;
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
                    decimal total = 0;
                    for (int i = 0; i < MyGlobals.productoVentas.Count; i++)
                    {
                        total += MyGlobals.productoVentas[i].precio * MyGlobals.cantidadProducto[i];
                        labelTotal.Text = total.ToString();
                    }
                   
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
            dataGridViewCarrito.Rows.Clear();
            venta.rellenarDataGridCarritoProductos(dataGridViewCarrito);
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

                decimal total = 0;
                for (int i = 0; i < MyGlobals.productoVentas.Count; i++)
                {
                    total += MyGlobals.productoVentas[i].precio * MyGlobals.cantidadProducto[i];
                    labelTotal.Text = total.ToString();
                }
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

            if (DialogResult.Yes == MessageBox.Show("Está seguro de cancelar la venta?", "Cancelar venta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                venta.cancelarVenta(buttons, labels);

                dataGridViewCarrito.Rows.Clear();
            }
        }

        private void dataGridViewCarrito_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCarrito.CurrentRow != null)
            {
                if (e.ColumnIndex == 5)
                {
                    venta.borrarProductoCarrito(dataGridViewCarrito);

                    dataGridViewCarrito.Rows.Clear();
                    venta.rellenarDataGridCarritoProductos(dataGridViewCarrito);
                    decimal total = 0;
                    for (int i = 0; i < MyGlobals.productoVentas.Count; i++)
                    {
                        total += MyGlobals.productoVentas[i].precio * MyGlobals.cantidadProducto[i];
                        labelTotal.Text = total.ToString();
                    }
                }
                if (e.ColumnIndex == 6)
                {
                    MyGlobals.productoSeleccionado = MyGlobals.productoVentas[e.RowIndex];
                    MyGlobals.indexProducto = e.RowIndex;

                    EditarProducto editarProducto = new EditarProducto();
                    editarProducto.ShowDialog();
                    dataGridViewCarrito.Rows.Clear();
                    venta.rellenarDataGridCarritoProductos(dataGridViewCarrito);
                    decimal total = 0;
                    for (int i = 0; i < MyGlobals.productoVentas.Count; i++)
                    {
                        total += MyGlobals.productoVentas[i].precio * MyGlobals.cantidadProducto[i];
                        labelTotal.Text = total.ToString();
                    }
                }
            }
          
        }

        private void buttonFinalizarCompra_Click(object sender, EventArgs e)
        {
            FinalizarCompra finalizarCompra = new FinalizarCompra();
            finalizarCompra.ShowDialog();
            if (MyGlobals.productoVentas.Count == 0)
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
                venta.rellenarDataGridCarritoProductos(dataGridViewCarrito);
            }
        }

 
    }
}
