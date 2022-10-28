﻿using CapaLogica;
using CapaPresentacion.CapaLogica.LVendedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.CapaPresentacion.VistaVendedor.Ventas.NuevaVentaSubForms
{
    public partial class FinalizarCompra : Form
    {
        LVentas venta;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public FinalizarCompra()
        {
            InitializeComponent();
            venta = new LVentas();
            venta.rellenarComboBoxMetodoPago(comboBox1);

            var productos = MyGlobals.productoVentas;
            var cantidad = MyGlobals.cantidadProducto;

            for (int i = 0; i < productos.Count; i++)
            {
                textBoxProductos.Text += productos[i].nombre + " x" + cantidad[i]+". ";
            }
            labelCliente.Text = MyGlobals.clienteVentas[0].nombre + " " + MyGlobals.clienteVentas[0].apellido;
            //labelVendedor.Text = MyGlobals.persona.nombre + " " + MyGlobals.persona.apellido;
        }

        private void buttonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelBarra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}