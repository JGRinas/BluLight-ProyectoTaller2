using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//textsharp
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Text.RegularExpressions;
using CapaLogica;
using CapaPresentacion.CapaLogica.LVendedor;
using System.Runtime.InteropServices;
using CapaPresentacion.CapaLogica.LRecepcionistaok;

namespace CapaPresentacion.CapaPresentacion.VistaRecepcionista.Servicios.Childrenforms
{
    public partial class FinalizarCompra : Form
    {
        LVentasServicio venta;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public FinalizarCompra()
        {
            InitializeComponent();
            venta = new LVentasServicio();
            venta.rellenarComboBoxMetodoPago(comboBox1);

            var servicios = MyGlobals.servicioVentas2;
            var cantidad = MyGlobals.cantidadServicio;

            for (int i = 0; i < servicios.Count; i++)
            {
                textBoxServicios.Text += servicios[i].nombre + " x" + cantidad[i] + ". \n";
            }
            labelCliente.Text = MyGlobals.clienteVentas[0].nombre + " " + MyGlobals.clienteVentas[0].apellido;
            labelDni.Text = MyGlobals.clienteVentas[0].dni.ToString();
            labelVendedor.Text = MyGlobals.persona.nombre + " " + MyGlobals.persona.apellido;
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

        private void buttonFinalizarCompra_Click(object sender, EventArgs e)
        {
            List<Button> buttons = new List<Button>();
            List<Label> labels = new List<Label>();
            if (comboBox1.SelectedIndex != -1)
            {
                if (DialogResult.Yes == MessageBox.Show("Finalizar venta?", "Nueva venta", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                {
                    venta.generarComprobante();
                    venta.finalizarCompra(comboBox1);
                }
            }
            else
            {
                MessageBox.Show("Ingrese el método de pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

