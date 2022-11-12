using CapaLogica;
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
    public partial class BuscarServicioVenta : Form
    {
        LVentasServicio venta;
        LServiciosR servicio;


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        
        
        public BuscarServicioVenta()
        {
            InitializeComponent();
            venta = new LVentasServicio();
            servicio = new LServiciosR();
            servicio.rellenarComboBoxCategoría(comboBoxCategoria);
            servicio.rellenarComboBoxLab(comboBoxLab);
            textBoxNombreServicio.MaxLength = 49;
            textBoxCantidad.MaxLength = 9;
            datagridServicios.Rows.Clear();
            venta.rellenarDataGridServicios(datagridServicios);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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

        private void datagridServicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Label> labels = new List<Label>();
            labels.Add(labelNombreServicio);
            labels.Add(labelIdServicio);
            List<ComboBox> comboBoxes = new List<ComboBox>();
            comboBoxes.Add(comboBoxLab);
            comboBoxes.Add(comboBoxCategoria);
            textBoxCantidad.Enabled = true;
            venta.obtenerServicioDelDataGrid(labels, comboBoxes, textBoxNombreServicio, btnAgregarServicio, datagridServicios);
        }

        private void buttonBuscarServicioNombre_Click(object sender, EventArgs e)
        {
            List<Label> labels = new List<Label>();
            labels.Add(labelNombreServ);
            labels.Add(labelIdServicio);
            textBoxCantidad.Enabled = true;
            venta.buscarServicio(labels, textBoxNombreServicio, btnAgregarServicio);
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            List<ComboBox> comboBoxes = new List<ComboBox>();
            comboBoxes.Add(comboBoxLab);
            comboBoxes.Add(comboBoxCategoria);

            datagridServicios.Rows.Clear();
            venta.buscarProductoCateYColor(comboBoxes, datagridServicios);
        }

        private void buttonMostrarTodos_Click(object sender, EventArgs e)
        {
            datagridServicios.Rows.Clear();
            servicio.rellenarDataGridServicios(datagridServicios);
        }

        private void buttonAgregarServicio_Click(object sender, EventArgs e)
        {
            //int idP = Int32.Parse(labelIdServicio.Text);

            venta.agregarServicioCarrito(MyGlobals.idServSelecc, textBoxCantidad, MyGlobals.idLabSelecc);

            datagridServicios.Rows.Clear();
            venta.rellenarDataGridServicios(datagridServicios);
        }

        private void textBoxCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            venta.textBoxEvent.numberKeyPress(e);
        }

        private void textBoxNombreServicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            venta.textBoxEvent.textKeyPress(e);
        }
    }
}
