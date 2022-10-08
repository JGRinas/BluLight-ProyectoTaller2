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

namespace Proyecto2022.CapaPresentacion.VistaAdmin.GestionarProductos
{
    public partial class GestionProductos : Form
    {
        LProduct producto;
        
        public GestionProductos()
        {
            InitializeComponent();
            producto = new LProduct();
            producto.searchProducts(dataGridViewProduct);
            producto.rellenarComboBoxCategoria(comboBoxCategoria);
            producto.rellenarComboBoxColor(comboBoxColor);
            textBoxStock.MaxLength = 9;
            textBoxPrecio.MaxLength = 9;
        }

        private void pictureBoxProductA_Click(object sender, EventArgs e)
        {
            producto.uploadImage.LoadImage(pictureBoxProductA);
        }

        private void textBoxTitleProductA_KeyPress(object sender, KeyPressEventArgs e)
        {
            producto.textBoxEvent.textKeyPress(e);
        }

        private void textBoxStockProductA_KeyPress(object sender, KeyPressEventArgs e)
        {
            producto.textBoxEvent.numberKeyPress(e);
        }

        private void textBoxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            producto.textBoxEvent.numberDecimalKeyPress(e);
        }

        private void buttonRegistrarProducto_Click(object sender, EventArgs e)
        {
            var listTextBoxProductAdd = new List<TextBox>();
            listTextBoxProductAdd.Add(textBoxTitulo);
            listTextBoxProductAdd.Add(textBoxStock);
            listTextBoxProductAdd.Add(textBoxPrecio);

            var comboBox = new List<ComboBox>();
            comboBox.Add(comboBoxCategoria);
            comboBox.Add(comboBoxColor);

            if (buttonRegistrarProducto.Text.Equals("Registrar"))
            {
                producto.registerProduct(listTextBoxProductAdd, comboBox, pictureBoxProductA);
                dataGridViewProduct.Rows.Clear();
                producto.searchProducts(dataGridViewProduct);
            }
            else
            {
                producto.reestablecerCampos(listTextBoxProductAdd, comboBox, pictureBoxProductA);
                restablecerBotones();
            }
            
        }

        private void dataGridViewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var listTextBoxProductAdd = new List<TextBox>();
            listTextBoxProductAdd.Add(textBoxTitulo);
            listTextBoxProductAdd.Add(textBoxStock);
            listTextBoxProductAdd.Add(textBoxPrecio);

            var comboBox = new List<ComboBox>();
            comboBox.Add(comboBoxCategoria);
            comboBox.Add(comboBoxColor);

            int id = Int32.Parse(dataGridViewProduct.CurrentRow.Cells[0].Value.ToString());

            producto.obtenerProducto(id, listTextBoxProductAdd, pictureBoxProductA, comboBox, dataGridViewProduct, buttonEliminar);
            buttonModificar.Enabled = true;
            buttonEliminar.Enabled = true;
            buttonRegistrarProducto.Text = "Restablecer";
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            var listTextBoxProductAdd = new List<TextBox>();
            listTextBoxProductAdd.Add(textBoxTitulo);
            listTextBoxProductAdd.Add(textBoxStock);
            listTextBoxProductAdd.Add(textBoxPrecio);

            var comboBox = new List<ComboBox>();
            comboBox.Add(comboBoxCategoria);
            comboBox.Add(comboBoxColor);

            if (buttonEliminar.Text.Equals("Eliminar")) producto.DeleteProduct();
            else producto.restoreProduct();
            
            restablecerBotones();
            producto.reestablecerCampos(listTextBoxProductAdd, comboBox, pictureBoxProductA);
            dataGridViewProduct.Rows.Clear();
            producto.searchProducts(dataGridViewProduct);
        }
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            var listTextBoxProductAdd = new List<TextBox>();
            listTextBoxProductAdd.Add(textBoxTitulo);
            listTextBoxProductAdd.Add(textBoxStock);
            listTextBoxProductAdd.Add(textBoxPrecio);

            var comboBox = new List<ComboBox>();
            comboBox.Add(comboBoxCategoria);
            comboBox.Add(comboBoxColor);

            producto.updateProduct(listTextBoxProductAdd, comboBox, pictureBoxProductA);
            dataGridViewProduct.Rows.Clear();
            producto.searchProducts(dataGridViewProduct);
        }
        private void restablecerBotones()
        {
            buttonRegistrarProducto.Text = "Registrar";
            buttonEliminar.Enabled = false;
            buttonModificar.Enabled = false;
        }
       
    }
}
