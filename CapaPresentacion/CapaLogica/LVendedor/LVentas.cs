using Bunifu.UI.WinForms;
using CapaLogica;
using CapaLogica.Libreria;
using CapaPresentacion.CapaData.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDev.HtmlRenderer.Adapters.Entities;

namespace CapaPresentacion.CapaLogica.LVendedor
{
    public class LVentas : Librerias
    {
        //AGREGAR CLIENTE
        public void rellenarDataGridBuscarClienteVentas(DataGridView dataGrid)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                List<Persona> personas = new List<Persona>();
                personas = db.Persona.ToList();

                foreach (Persona persona in personas)
                {
                    int dni = persona.dni;
                    var empleado = db.Empleado.Where(e => e.Persona.dni.Equals(dni));

                    if (empleado.ToList().Count == 0 && (bool)persona.activo)
                    {

                        int fila = dataGrid.Rows.Add();
                        dataGrid.Rows[fila].Cells["ColumnNombre"].Value = persona.nombre;
                        dataGrid.Rows[fila].Cells["ColumnApellido"].Value = persona.apellido;
                        dataGrid.Rows[fila].Cells["ColumnDni"].Value = persona.dni;
                    }
                }
            }
        }

        public void buscarClienteEnVentas(BunifuTextBox dniC, List<Label> labels, Button button)
        {
            if (dniC.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un DNI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (bd_blulightEntities db = new bd_blulightEntities())
                {
                    int dni = Int32.Parse(dniC.Text);
                    var cliente = db.Persona.Where(p => p.dni.Equals(dni)).ToList();
                    var empleado = db.Empleado.Where(p => p.Persona.dni.Equals(dni)).ToList();
                    if (cliente.Count > 0 && empleado.Count == 0)
                    {

                        labels[0].Text = cliente[0].nombre;
                        labels[1].Text = cliente[0].apellido;
                        labels[2].Text = cliente[0].dni.ToString();

                        button.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("El DNI ingresado no corresponde a ningún cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
        public void buscarClienteEnVentasDataGrid(BunifuTextBox dniC, List<Label> labels, Button button, DataGridView dataGrid)
        {
            labels[0].Text = dataGrid.CurrentRow.Cells[1].Value.ToString();
            labels[1].Text = dataGrid.CurrentRow.Cells[2].Value.ToString();
            labels[2].Text = dataGrid.CurrentRow.Cells[0].Value.ToString();
            dniC.Text = dataGrid.CurrentRow.Cells[0].Value.ToString();
            button.Enabled = true;
        }

   
        public void refrescarClienteCarrito(List<Label> labels)
        {
            MyGlobals.clienteLabels = labels;
        }
        public void agregarClienteCarrito(Label label)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                MyGlobals.clienteVentas.Clear();
                int dni = Int32.Parse(label.Text);
                Persona persona = db.Persona.Where(p => p.dni.Equals(dni)).FirstOrDefault();
                MyGlobals.clienteVentas.Add(persona);
                MyGlobals.clienteLabels[0].Text = persona.nombre.ToString();
                MyGlobals.clienteLabels[1].Text = persona.apellido.ToString();
                MyGlobals.clienteLabels[2].Text = persona.dni.ToString();
                MyGlobals.clienteLabels[3].Text = persona.email.ToString();
                MessageBox.Show("Cliente agregado!", "Nueva venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        //AGREGAR PRODUCTO

        public void rellenarDataGridProductos(DataGridView dataGrid)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                List<Producto> Products = new List<Producto>();

                Products = db.Producto.ToList();

                if (Products.Count > 0)
                {
                    foreach (Producto product in Products)
                    {
                        if (product.activo && product.stock > 0)
                        {
                            int fila = dataGrid.Rows.Add();

                            dataGrid.Rows[fila].Cells["ColumnId"].Value = product.idProducto;
                            dataGrid.Rows[fila].Cells["ColumnTitulo"].Value = product.nombre;
                            dataGrid.Rows[fila].Cells["ColumnCategoria"].Value = product.Categoria_producto.categoria;
                            dataGrid.Rows[fila].Cells["ColumnColor"].Value = product.Color_producto.color;
                            dataGrid.Rows[fila].Cells["ColumnStock"].Value = product.stock;
                            dataGrid.Rows[fila].Cells["ColumnPrecio"].Value = product.precio;

                            Image thumb = uploadImage.byteToImage(product.imagen).GetThumbnailImage(70, 70, null, IntPtr.Zero);
                            dataGrid.Rows[fila].Height = 70;
                            dataGrid.Rows[fila].Cells["ColumnImagen"].Value = thumb;
                        }
                    }
                }
            }
        }

        public void buscarProducto(List<Label> labels, TextBox textBox, Button button, PictureBox imagen)
        {
            if (textBox.Text.Equals(""))
            {
                MessageBox.Show("Ingrese el nombre del producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                using (bd_blulightEntities db = new bd_blulightEntities())
                {
                    var product = db.Producto.Where(p => p.nombre.Equals(textBox.Text));
                    if (product.ToList().Count > 0 && product.FirstOrDefault().activo && product.FirstOrDefault().stock > 0)
                    {
                        labels[0].Text = product.FirstOrDefault().nombre;
                        labels[1].Text = product.FirstOrDefault().idProducto.ToString();

                        imagen.Image = uploadImage.byteToImage(product.FirstOrDefault().imagen);

                        button.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("El producto no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
           
        }

        public void buscarProductoCateYColor(List<ComboBox> comboBoxes, DataGridView dataGrid)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                List<Producto> Products = new List<Producto>();
                int idCategoria = comboBoxes[1].SelectedIndex + 1;
                int idColor = comboBoxes[0].SelectedIndex + 1;
                Products = db.Producto.ToList();

                int tamano = 60;

                if (Products.Count > 0)
                {

                    foreach (Producto product in Products)
                    {
                        if (product.Categoria_producto.idCategoriaProd == idCategoria && product.Color_producto.idColor == idColor)
                        {
                            int fila = dataGrid.Rows.Add();

                            dataGrid.Rows[fila].Cells["ColumnId"].Value = product.idProducto;
                            dataGrid.Rows[fila].Cells["ColumnTitulo"].Value = product.nombre;
                            dataGrid.Rows[fila].Cells["ColumnCategorIA"].Value = product.Categoria_producto.categoria;
                            dataGrid.Rows[fila].Cells["ColumnColor"].Value = product.Color_producto.color;
                            dataGrid.Rows[fila].Cells["ColumnStock"].Value = product.stock;
                            dataGrid.Rows[fila].Cells["ColumnPrecio"].Value = product.precio;

                            Image thumb = uploadImage.byteToImage(product.imagen).GetThumbnailImage(tamano, tamano, null, IntPtr.Zero);
                            dataGrid.Rows[fila].Height = tamano;
                            dataGrid.Rows[fila].Cells["ColumnImagen"].Value = thumb;
                        }

                        if (product.Categoria_producto.idCategoriaProd == idCategoria && idColor == 0)
                        {
                            int fila = dataGrid.Rows.Add();

                            dataGrid.Rows[fila].Cells["ColumnId"].Value = product.idProducto;
                            dataGrid.Rows[fila].Cells["ColumnTitulo"].Value = product.nombre;
                            dataGrid.Rows[fila].Cells["ColumnCategorIA"].Value = product.Categoria_producto.categoria;
                            dataGrid.Rows[fila].Cells["ColumnColor"].Value = product.Color_producto.color;
                            dataGrid.Rows[fila].Cells["ColumnStock"].Value = product.stock;
                            dataGrid.Rows[fila].Cells["ColumnPrecio"].Value = product.precio;

                            Image thumb = uploadImage.byteToImage(product.imagen).GetThumbnailImage(tamano, tamano, null, IntPtr.Zero);
                            dataGrid.Rows[fila].Height = tamano;
                            dataGrid.Rows[fila].Cells["ColumnImagen"].Value = thumb;
                        }

                        if (idCategoria == 0 && product.Color_producto.idColor == idColor)
                        {
                            int fila = dataGrid.Rows.Add();

                            dataGrid.Rows[fila].Cells["ColumnId"].Value = product.idProducto;
                            dataGrid.Rows[fila].Cells["ColumnTitulo"].Value = product.nombre;
                            dataGrid.Rows[fila].Cells["ColumnCategorIA"].Value = product.Categoria_producto.categoria;
                            dataGrid.Rows[fila].Cells["ColumnColor"].Value = product.Color_producto.color;
                            dataGrid.Rows[fila].Cells["ColumnStock"].Value = product.stock;
                            dataGrid.Rows[fila].Cells["ColumnPrecio"].Value = product.precio;

                            Image thumb = uploadImage.byteToImage(product.imagen).GetThumbnailImage(tamano, tamano, null, IntPtr.Zero);
                            dataGrid.Rows[fila].Height = tamano;
                            dataGrid.Rows[fila].Cells["ColumnImagen"].Value = thumb;
                        }
                    }
                }
            }
        }

        public void obtenerProductoDelDataGrid(List<Label> labels, List<ComboBox> comboBoxes, TextBox textBox, Button button, PictureBox imagen, DataGridView dataGrid)
        {
            textBox.Text = dataGrid.CurrentRow.Cells[1].Value.ToString();
            labels[0].Text = dataGrid.CurrentRow.Cells[1].Value.ToString();
            labels[1].Text = dataGrid.CurrentRow.Cells[0].Value.ToString();

            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                var prod = dataGrid.CurrentRow.Cells[5].Value.ToString();
               Categoria_producto categoria = db.Categoria_producto.Where(c => c.categoria.Equals(prod)).FirstOrDefault();

                prod = dataGrid.CurrentRow.Cells[6].Value.ToString();
                Color_producto color = db.Color_producto.Where(c => c.color.Equals(prod)).FirstOrDefault();

                comboBoxes[0].SelectedIndex = color.idColor - 1;
                comboBoxes[1].SelectedIndex = categoria.idCategoriaProd - 1;
            }
                
            imagen.Image = (Image)dataGrid.CurrentRow.Cells[2].Value;

            button.Enabled = true;
        }

        public void agregarProductoCarrito(int idP)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                var productoV = db.Producto.Where(p => p.idProducto.Equals(idP));

                if (productoV.ToList().Count > 0)
                {
                    Producto producto = new Producto();
                    producto = productoV.FirstOrDefault();
                    MyGlobals.productoVentas.Add(producto);

                    MyGlobals.dataGridProductosVentas.Rows.Clear();
                    rellenarDataGridCarritoProductos(MyGlobals.dataGridProductosVentas);
                    MessageBox.Show("El producto fue agregado!", "Agregar producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public void rellenarDataGridCarritoProductos(DataGridView dataGrid)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {

                if (MyGlobals.productoVentas.Count > 0)
                {
                    ((DataGridViewTextBoxColumn)dataGrid.Columns["ColumnCantidad"]).MaxInputLength = 9;
                
                    foreach (Producto product in MyGlobals.productoVentas)
                    {
                        if (product.activo && product.stock > 0)
                        {
                            int fila = dataGrid.Rows.Add();
                            dataGrid.Rows[fila].Cells["ColumnId"].ReadOnly = true;
                            dataGrid.Rows[fila].Cells["ColumnId"].Value = fila.ToString();
                            dataGrid.Rows[fila].Cells["ColumnTitulo"].ReadOnly = true;
                            dataGrid.Rows[fila].Cells["ColumnTitulo"].Value = product.nombre;
                            dataGrid.Rows[fila].Cells["ColumnCantidad"].ValueType = typeof(int);
                            dataGrid.Rows[fila].Cells["ColumnCantidad"].Value = 1;
                            dataGrid.Rows[fila].Cells["ColumnSubtotal"].ReadOnly = true;
                            dataGrid.Rows[fila].Cells["ColumnSubtotal"].Value = product.precio * Int32.Parse(dataGrid.Rows[fila].Cells["ColumnCantidad"].Value.ToString());
                            Image thumb = uploadImage.byteToImage(product.imagen).GetThumbnailImage(70, 70, null, IntPtr.Zero);
                            dataGrid.Rows[fila].Height = 70;
                            dataGrid.Rows[fila].Cells["ColumnImagen"].ReadOnly = true;
                            dataGrid.Rows[fila].Cells["ColumnImagen"].Value = thumb;
                            dataGrid.Rows[fila].Cells["ColumnAccion"].ReadOnly = true;
                            dataGrid.Rows[fila].Cells["ColumnAccion"].Value = "Eliminar";
                        }
                    }
                }
            }
        }

        public void cancelarVenta(List<Button> buttons, List<Label> labels)
        {
            if (DialogResult.Yes == MessageBox.Show("Está seguro de cancelar la venta?","Cancelar venta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) 
            {

                MyGlobals.clienteLabels.Clear();
                MyGlobals.clienteVentas.Clear();
                MyGlobals.productoVentas.Clear();

                foreach (Label label in labels)
                {
                    label.Text = "";
                }

                foreach (Button button in buttons)
                {
                    button.Enabled = false;
                }
            }
            
        }

        public void borrarProductoCarrito(DataGridView dataGrid)
        {
            if (DialogResult.Yes == MessageBox.Show("Seguro que desea eliminar el producto?", "Eliminar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                int id = Int32.Parse(dataGrid.CurrentRow.Cells["ColumnId"].Value.ToString());
                MyGlobals.productoVentas.RemoveAt(id);
            }
            
        }

    }
}
