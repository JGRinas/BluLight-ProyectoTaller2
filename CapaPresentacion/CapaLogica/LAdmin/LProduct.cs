using CapaLogica.Libreria;
using CapaPresentacion.CapaData.Model;
using LinqToDB;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaLogica 
{
    public class LProduct : Librerias
    {
        private PictureBox image;

        public void rellenarComboBoxCategoria(ComboBox comboBox)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                foreach (var item in db.Categoria_producto)
                {
                    comboBox.Items.Add(item.idCategoriaProd + " - " + item.categoria);
                }
            }
        }

        public void rellenarComboBoxColor(ComboBox comboBox)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                foreach (var item in db.Color_producto)
                {
                    comboBox.Items.Add(item.idColor + " - " + item.color);
                }
            }
        }
        public void searchProducts(DataGridView dataGrid)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                List<Producto> Products = new List<Producto>();

                Products = db.Producto.ToList();

                if (Products.Count > 0)
                {

                    foreach(Producto product in Products)
                    {
                        int fila = dataGrid.Rows.Add();
                        var estado = "Si";
                        if (!product.activo)
                        {
                            dataGrid.Rows[fila].DefaultCellStyle.BackColor = Color.Gray;
                            estado = "No";
                        }

                        dataGrid.Rows[fila].Cells["ColumnId"].Value = product.idProducto;
                        dataGrid.Rows[fila].Cells["ColumnTitulo"].Value = product.nombre;
                        dataGrid.Rows[fila].Cells["ColumnCategorIA"].Value = product.Categoria_producto.categoria;
                        dataGrid.Rows[fila].Cells["ColumnColor"].Value = product.Color_producto.color;
                        dataGrid.Rows[fila].Cells["ColumnStock"].Value = product.stock;
                        dataGrid.Rows[fila].Cells["ColumnPrecio"].Value = product.precio; 
                        dataGrid.Rows[fila].Cells["ColumnEstado"].Value = estado;

                        Image thumb = uploadImage.byteToImage(product.imagen).GetThumbnailImage(100, 100, null, IntPtr.Zero);
                        dataGrid.Rows[fila].Height = 100;
                        dataGrid.Rows[fila].Cells["ColumnImagen"].Value = thumb;
                    }

                    /*dataGrid.DataSource = query.Select(c => new
                    {
                        c.id,
                        c.title,
                        c.stock,
                        c.codProd,
                        c.category,
                        c.image,
                    }).Skip(inicio).Take(10).ToList();*/
                }
            }
        }

        public void reestablecerCampos(List<TextBox> listTextBoxProductAdd, List<ComboBox> comboBox, PictureBox image)
        {
            foreach (TextBox textBox in listTextBoxProductAdd)
            {
                textBox.Text = "";
            }

            comboBox[0].SelectedIndex = -1;
            comboBox[1].SelectedIndex = -1;

            image.Image = null;
        }
        public void registerProduct(List<TextBox> listProduct, List<ComboBox> comboBoxes, PictureBox image)
        {
            bool validation = true;

            for (int i=0; i<listProduct.Count; i++)
            {
                if (listProduct[i].Text.Equals(""))
                {
                    validation = false;
                }
            }

            if (image.Image == null || comboBoxes[0].SelectedIndex == -1 || comboBoxes[1].SelectedIndex == -1)
            {
                validation = false;
            }
            
      
                if (validation)
                {
                    using (bd_blulightEntities db = new bd_blulightEntities())
                    {
                   
                    Producto product = new Producto();

                    product.nombre = listProduct[0].Text;
                    product.stock = Int32.Parse(listProduct[1].Text);
                    product.precio = decimal.Parse(listProduct[2].Text);
                    product.idCategoriaProd = Int32.Parse(comboBoxes[0].SelectedIndex.ToString()) + 1;
                    product.idColor = Int32.Parse(comboBoxes[1].SelectedIndex.ToString()) + 1;
                    product.imagen = uploadImage.ImageToByte(image.Image);
                    product.activo = true;

                    db.Producto.Add(product);
                    db.SaveChanges();

                    MessageBox.Show("Producto registrado correctamente!", "Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    foreach (TextBox textBox in listProduct)
                    {
                        textBox.Text = "";
                    }
                    image.Image = null;
                    comboBoxes[0].SelectedIndex = -1;
                    comboBoxes[1].SelectedIndex = -1;
                    }
                } 
                else
                {
                MessageBox.Show("Ingrese todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private int idProducto;
        public void obtenerProducto(int idP, List<TextBox> listTextBox, PictureBox image, List<ComboBox> comboBox, DataGridView dataGrid, Button buttonEliminar)
        {
            listTextBox[0].Text = (dataGrid.CurrentRow.Cells[2].Value.ToString());
            listTextBox[1].Text = (dataGrid.CurrentRow.Cells[3].Value.ToString());
            listTextBox[2].Text = (dataGrid.CurrentRow.Cells[4].Value.ToString());
            idProducto = Int32.Parse(dataGrid.CurrentRow.Cells[0].Value.ToString());
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                List<Color_producto> colores = new List<Color_producto>();
                colores = db.Color_producto.ToList();
                int idColor = -1;
                foreach (Color_producto color in colores)
                {
                    if (color.color.Equals(dataGrid.CurrentRow.Cells[6].Value.ToString()))
                    {
                        idColor = color.idColor;
                    }
                }
                
                var producto = db.Producto.SingleOrDefault(e => e.idProducto.Equals(idProducto));
                if (producto.activo)
                {
                    buttonEliminar.Text = "Eliminar";
                }
                else
                {
                    buttonEliminar.Text = "Restaurar";
                }

                List<Categoria_producto> categorias = new List<Categoria_producto>();
                categorias = db.Categoria_producto.ToList();
                int idCategoria = -1;
                foreach (Categoria_producto categoria in categorias)
                {
                    if (categoria.categoria.Equals(dataGrid.CurrentRow.Cells[5].Value.ToString()))
                    {
                        idCategoria = categoria.idCategoriaProd;
                    }
                }
                comboBox[0].SelectedIndex = idCategoria - 1;
                comboBox[1].SelectedIndex = idColor - 1;
            }
    
            try
            {
                image.Image = (Image)dataGrid.CurrentRow.Cells[1].Value;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void DeleteProduct()
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {

                if (MessageBox.Show("Estas seguro de que desea eliminar el producto?", "Eliminar producto", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (db.Producto.Where(c => c.idProducto.Equals(idProducto)).ToList().Count > 0)
                    {
                        var producto = db.Producto.SingleOrDefault(c => c.idProducto.Equals(idProducto));
                        producto.activo = false;
                        db.SaveChanges();
                        MessageBox.Show("Producto eliminado", "Eliminar producto", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("El Producto No Existe", "Error", MessageBoxButtons.OK);
                    }
                }
            }
        }
        public void restoreProduct()
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {

                if (MessageBox.Show("Estas seguro de que desea restaurar el producto?", "Restaurar producto", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (db.Producto.Where(c => c.idProducto.Equals(idProducto)).ToList().Count > 0)
                    {
                        var producto = db.Producto.SingleOrDefault(c => c.idProducto.Equals(idProducto));
                        producto.activo = true;
                        db.SaveChanges();
                        MessageBox.Show("Producto restaurado", "Restaurar producto", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("El Producto No Existe", "Error", MessageBoxButtons.OK);
                    }
                }
            }
        }



        public void updateProduct(List<TextBox> listTextBox, List<ComboBox> comboBox, PictureBox image)
        {
            bool validation = true;

            for (int i = 0; i < listTextBox.Count; i++)
            {
                if (listTextBox[i].Text.Equals(""))
                {
                    validation = false;
                }
            }

            if (image.Image == null || comboBox[0].SelectedIndex == -1 || comboBox[1].SelectedIndex == -1)
            {
                validation = false;
            }

            if (validation)
            {
           
              using (bd_blulightEntities db = new bd_blulightEntities())
              {
                if (MessageBox.Show("Estas seguro de que desea Modificar el producto?", "Modificar producto", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (db.Producto.Where(c => c.idProducto.Equals(idProducto)).ToList().Count > 0)
                    {
                        var producto = db.Producto.SingleOrDefault(c => c.idProducto.Equals(idProducto));
                            producto.nombre = listTextBox[0].Text;
                            producto.stock = Int32.Parse(listTextBox[1].Text);
                            producto.precio = decimal.Parse(listTextBox[2].Text);
                            producto.idCategoriaProd = comboBox[0].SelectedIndex + 1;
                            producto.idColor = comboBox[1].SelectedIndex + 1;
                            producto.imagen = uploadImage.ImageToByte(image.Image);
                            
                            db.SaveChanges();
                        MessageBox.Show("Producto modificado", "Modificar producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("El Producto No Existe", "Error", MessageBoxButtons.OK);
                    }
                }
              }
            }
            else
            {
                MessageBox.Show("Ingrese todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
