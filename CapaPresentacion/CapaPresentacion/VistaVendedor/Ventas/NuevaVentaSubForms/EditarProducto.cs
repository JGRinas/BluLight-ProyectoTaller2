using CapaLogica;
using CapaLogica.LVendedor;
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
    public partial class EditarProducto : Form
    {
        LVentas venta;
        LProductV product;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public EditarProducto()
        {
            InitializeComponent();
            textBoxNombreProducto.MaxLength = 49;
            textBoxCantidad.MaxLength = 9;
            venta = new LVentas();
            product = new LProductV();
            product.rellenarComboBoxColor(comboBoxColor);
            product.rellenarComboBoxCategoría(comboBoxCategoria);
            dataGridViewProductos.Rows.Clear();
            venta.rellenarDataGridProductos(dataGridViewProductos);
            pictureBoxProduct.Image = venta.uploadImage.byteToImage(MyGlobals.productoSeleccionado.imagen);
            labelNombreP.Text = MyGlobals.productoSeleccionado.nombre;
            labelCodigoP.Text = MyGlobals.productoSeleccionado.idProducto.ToString();
            textBoxCantidad.Text = MyGlobals.cantidadProducto[MyGlobals.indexProducto].ToString();
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

        private void textBoxNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            venta.textBoxEvent.textKeyPress(e);
        }

        private void textBoxCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            venta.textBoxEvent.numberKeyPress(e);
        }

        private void buttonBuscarProductoNombre_Click(object sender, EventArgs e)
        {
            List<Label> labels = new List<Label>();
            labels.Add(labelNombreP);
            labels.Add(labelCodigoP);
            textBoxCantidad.Enabled = true;
            venta.buscarProducto(labels, textBoxNombreProducto, buttonEditarProducto, pictureBoxProduct);
        }

        private void buttonFiltro_Click(object sender, EventArgs e)
        {
            List<ComboBox> comboBoxes = new List<ComboBox>();
            comboBoxes.Add(comboBoxColor);
            comboBoxes.Add(comboBoxCategoria);

            dataGridViewProductos.Rows.Clear();
            venta.buscarProductoCateYColor(comboBoxes, dataGridViewProductos);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewProductos.Rows.Clear();
            venta.rellenarDataGridProductos(dataGridViewProductos);
        }

        private void dataGridViewProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Label> labels = new List<Label>();
            labels.Add(labelNombreP);
            labels.Add(labelCodigoP);
            List<ComboBox> comboBoxes = new List<ComboBox>();
            comboBoxes.Add(comboBoxColor);
            comboBoxes.Add(comboBoxCategoria);
            buttonEditarProducto.Text = "Cambiar producto";
            venta.obtenerProductoDelDataGrid(labels, comboBoxes, textBoxNombreProducto, buttonEditarProducto, pictureBoxProduct, dataGridViewProductos);
        }

        private void buttonEditarProducto_Click(object sender, EventArgs e)
        {
            if (textBoxCantidad.Text.Equals(""))
            {
                MessageBox.Show("Ingrese cantidad del producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (buttonEditarProducto.Text.Equals("Editar"))
                {
                    venta.editarProducto(textBoxCantidad);
                }
                else
                {
                    int idP = Int32.Parse(labelCodigoP.Text);
                    venta.cambiarProducto(idP, textBoxCantidad);
                }
            }
            dataGridViewProductos.Rows.Clear();
            venta.rellenarDataGridProductos(dataGridViewProductos);
        }
    }
}
