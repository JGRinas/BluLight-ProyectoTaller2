using CapaPresentacion.CapaLogica.LRecepcionistaok;
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

namespace CapaPresentacion.CapaPresentacion.VistaRecepcionista.Servicios.Childrenforms
{
    public partial class BuscarClienteVenta : Form
    {
        LVentasServicio venta;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public BuscarClienteVenta()
        {
            InitializeComponent();
            venta = new LVentasServicio();
            textBoxBuscarCliente.MaxLength = 9;
            venta.rellenarDataGridBuscarClienteVentas(datagridClientes);
        }

        private void textBoxClienteBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            venta.textBoxEvent.numberKeyPress(e);
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

        private void buttonBuscarCliente_Click(object sender, EventArgs e)
        {
            if (!textBoxBuscarCliente.Text.Equals(""))
            {
                List<Label> labels = new List<Label>();

                labels.Add(labelNombreC);
                labels.Add(labelApellidoC);
                labels.Add(labelDniC);

                venta.buscarClienteEnVentas(textBoxBuscarCliente, labels, btnAgregarCliente);
            }
            else
            {
                MessageBox.Show("Ingrese un DNI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
        }
        private void dataGridViewClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagridClientes.CurrentRow != null)
            {
                List<Label> labels = new List<Label>();

                labels.Add(labelNombreC);
                labels.Add(labelApellidoC);
                labels.Add(labelDniC);

                venta.buscarClienteEnVentasDataGrid(textBoxBuscarCliente, labels, btnAgregarCliente, datagridClientes);
            }
             
        }
        private void buttonAgregarCliente_Click(object sender, EventArgs e)
        {
            venta.agregarClienteCarrito(labelDniC);
        }

        private void datagridClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxBuscarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            venta.textBoxEvent.numberKeyPress(e);
        }
    }
}
