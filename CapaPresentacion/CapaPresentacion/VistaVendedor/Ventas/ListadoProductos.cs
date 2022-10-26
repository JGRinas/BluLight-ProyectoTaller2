using CapaLogica.LVendedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.VistaVendedor
{
    public partial class ListadoProductos : Form
    {
        LProductV products;
        public ListadoProductos()
        {
            InitializeComponent();
            products = new LProductV();
            textBoxNombreProducto.MaxLength = 49;
            products.rellenarDataGridProductos(dataGridViewProduct);
            products.rellenarComboBoxColor(comboBoxColor);
            products.rellenarComboBoxCategoría(comboBoxCategoria);
        }

        private void buttonBuscarProductoNombre_Click(object sender, EventArgs e)
        {
            if (textBoxNombreProducto.Text.Equals(""))
            {
                dataGridViewProduct.Rows.Clear();
                products.rellenarDataGridProductos(dataGridViewProduct);
            }
            else
            {
                dataGridViewProduct.Rows.Clear();
                products.buscarProductoNombre(textBoxNombreProducto, dataGridViewProduct);
            }
        }

        private void buttonBuscarProductoCateYColor_Click(object sender, EventArgs e)
        {
            if (comboBoxCategoria.SelectedIndex == -1 && comboBoxColor.SelectedIndex == -1)
            {
                dataGridViewProduct.Rows.Clear();
                products.rellenarDataGridProductos(dataGridViewProduct);
            }
            else
            {
                List<ComboBox> comboBoxes = new List<ComboBox>();
                comboBoxes.Add(comboBoxColor);
                comboBoxes.Add(comboBoxCategoria);

                dataGridViewProduct.Rows.Clear();
                products.buscarProductoCateYColor(comboBoxes, dataGridViewProduct);
            }
        }
    }
}
