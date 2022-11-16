using CapaLogica.Libreria;
using CapaPresentacion.CapaData.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.CapaLogica.LRecepcionistaok
{
    public class LServiciosR : Librerias
    {
        public void rellenarComboBoxCategoría(ComboBox comboBox)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                foreach (var item in db.Categoria_servicio)
                {
                    comboBox.Items.Add(item.idCategoriaServ + " - " + item.categoria);
                }
            }
        }

        public void rellenarComboBoxLab(ComboBox comboBox)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                foreach (var item in db.Laboratorio)
                {
                    comboBox.Items.Add(item.idLab + " - " + item.nombre);
                }
            }
        }

        public void rellenarDataGridServicios(DataGridView dataGrid)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                List<Servicio_laboratorio> servicios = new List<Servicio_laboratorio>();

                servicios = db.Servicio_laboratorio.ToList();

                if (servicios.Count > 0)
                {
                    foreach (Servicio_laboratorio servicio in servicios)
                    {
                        
                        if (servicio.activo)
                        {
                        int fila = dataGrid.Rows.Add();
                        dataGrid.Rows[fila].Cells["ColumnId"].Value = servicio.idServicio + "-" + servicio.idLab;
                        dataGrid.Rows[fila].Cells["ColumnNombre"].Value = servicio.Servicio.nombre;
                        dataGrid.Rows[fila].Cells["ColumnLab"].Value = servicio.Laboratorio.nombre;
                        dataGrid.Rows[fila].Cells["ColumnPrecio"].Value = servicio.Servicio.precio;
                        dataGrid.Rows[fila].Cells["ColumnCategoria"].Value = servicio.Servicio.Categoria_servicio.categoria;
                        }
                    }
                }
            }
        }
        public void buscarServicioNombre(TextBox textBox, DataGridView dataGrid)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                List<Producto> Products = new List<Producto>();

                if (db.Producto.Where(p => p.nombre.Equals(textBox.Text.ToString())).ToList().Count > 0)
                    Products.Add(db.Producto.Where(p => p.nombre.Equals(textBox.Text.ToString())).FirstOrDefault());

                if (Products.Count > 0)
                {

                    foreach (Producto product in Products)
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
                }
            }
        }

        public void buscarProductoCateYColor(List<ComboBox> comboBoxes, DataGridView dataGrid)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                List<Producto> Products = new List<Producto>();
                Products = db.Producto.ToList();
                int idCategoria = comboBoxes[1].SelectedIndex + 1;
                int idColor = comboBoxes[0].SelectedIndex + 1;

                if (Products.Count > 0)
                {

                    foreach (Producto product in Products)
                    {
                        if (product.Categoria_producto.idCategoriaProd == idCategoria && product.Color_producto.idColor == idColor)
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

                        if (product.Categoria_producto.idCategoriaProd == idCategoria && idColor == 0)
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

                        if (idCategoria == 0 && product.Color_producto.idColor == idColor)
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
                    }
                }
            }
        }

    }
}
