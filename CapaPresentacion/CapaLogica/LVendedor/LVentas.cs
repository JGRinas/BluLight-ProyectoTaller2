using Bunifu.UI.WinForms;
using CapaLogica;
using CapaLogica.Libreria;
using CapaPresentacion.CapaData.Model;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDev.HtmlRenderer.Adapters.Entities;
using Image = System.Drawing.Image;

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

                    if (empleado.ToList().Count == 0 && (bool)persona.activo && persona.dni != 0)
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
                int dni = Int32.Parse(label.Text);
                MyGlobals.clienteVentas.Clear();
               
                Persona persona = db.Persona.Where(p => p.dni.Equals(dni)).FirstOrDefault();
                MyGlobals.clienteVentas.Add(persona);
                MyGlobals.clienteLabels[0].Text = persona.nombre.ToString();
                MyGlobals.clienteLabels[1].Text = persona.apellido.ToString();
                MyGlobals.clienteLabels[2].Text = persona.dni.ToString();
                MyGlobals.clienteLabels[3].Text = persona.email.ToString();

                MyGlobals.productoVentas.Clear();
                MyGlobals.cantidadProducto.Clear();

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

                            
                            Producto pro = MyGlobals.productoVentas.Where(p => p.idProducto.Equals(product.idProducto)).FirstOrDefault();
                            var existe = MyGlobals.productoVentas.IndexOf(pro);
                            int cantidad = 0;
                            if (existe != -1)
                            {   
                                cantidad = MyGlobals.cantidadProducto[existe];
                            }
                           
                            int fila = dataGrid.Rows.Add();

                            dataGrid.Rows[fila].Cells["ColumnId"].Value = product.idProducto;
                            dataGrid.Rows[fila].Cells["ColumnTitulo"].Value = product.nombre;
                            dataGrid.Rows[fila].Cells["ColumnCategoria"].Value = product.Categoria_producto.categoria;
                            dataGrid.Rows[fila].Cells["ColumnColor"].Value = product.Color_producto.color;
                            dataGrid.Rows[fila].Cells["ColumnStock"].Value = product.stock - cantidad;
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

        public void agregarProductoCarrito(int idP, TextBox cantidadP)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                var productoV = db.Producto.Where(p => p.idProducto.Equals(idP));
                int cantidad = Int32.Parse(cantidadP.Text);
                if (productoV.ToList().Count > 0)
                {
                    Producto product = db.Producto.Where(p => p.idProducto.Equals(idP)).FirstOrDefault();
                    Producto pro = MyGlobals.productoVentas.Where(p => p.idProducto.Equals(idP)).FirstOrDefault();
                    var existe = MyGlobals.productoVentas.IndexOf(pro);
                   
                        if (existe != -1)
                        {
                            if (cantidad <= pro.stock - MyGlobals.cantidadProducto[existe])
                            {
                            MyGlobals.cantidadProducto[existe] += cantidad;
                            MessageBox.Show("El producto fue agregado!", "Agregar producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            
                        else MessageBox.Show("Cantidad ingresada mayor al stock del producto", "Agregar producto", MessageBoxButtons.OK, MessageBoxIcon.Error);

                         }
                        else
                        {
                             if (cantidad <= Int32.Parse(product.stock.ToString()))
                            {
                            Producto producto = new Producto();
                            producto = productoV.FirstOrDefault();
                            MyGlobals.productoVentas.Add(producto);
                            MyGlobals.cantidadProducto.Add(cantidad);
                            MyGlobals.dataGridProductosVentas.Rows.Clear();
                            rellenarDataGridCarritoProductos(MyGlobals.dataGridProductosVentas);
                            MessageBox.Show("El producto fue agregado!", "Agregar producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                              MessageBox.Show("Cantidad ingresada mayor al stock del producto", "Agregar producto", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
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
                            dataGrid.Rows[fila].Cells["ColumnId"].Value = fila.ToString();
                            dataGrid.Rows[fila].Cells["ColumnTitulo"].Value = product.nombre;
                            dataGrid.Rows[fila].Cells["ColumnCantidad"].Value = MyGlobals.cantidadProducto[fila];
                            dataGrid.Rows[fila].Cells["ColumnSubtotal"].Value = product.precio * Int32.Parse(dataGrid.Rows[fila].Cells["ColumnCantidad"].Value.ToString());
                            Image thumb = uploadImage.byteToImage(product.imagen).GetThumbnailImage(70, 70, null, IntPtr.Zero);
                            dataGrid.Rows[fila].Height = 70;
                            dataGrid.Rows[fila].Cells["ColumnImagen"].Value = thumb;          
                            dataGrid.Rows[fila].Cells["ColumnAccion"].Value = "Eliminar";
                            dataGrid.Rows[fila].Cells["ColumnEditar"].Value = "Editar";
                        }
                    }
                }
            }
        }

        public void cancelarVenta(List<Button> buttons, List<Label> labels)
        {
 

                MyGlobals.clienteLabels.Clear();
                MyGlobals.clienteVentas.Clear();
                MyGlobals.productoVentas.Clear();
                MyGlobals.cantidadProducto.Clear();
                foreach (Label label in labels)
                {
                    label.Text = "";
                }

                foreach (Button button in buttons)
                {
                    button.Enabled = false;
                }
            
            
        }

        public void borrarProductoCarrito(DataGridView dataGrid)
        {
            if (DialogResult.Yes == MessageBox.Show("Seguro que desea eliminar el producto?", "Eliminar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                int id = Int32.Parse(dataGrid.CurrentRow.Cells["ColumnId"].Value.ToString());
                MyGlobals.productoVentas.RemoveAt(id);
                MyGlobals.cantidadProducto.RemoveAt(id);
            }
            
        }

        /*FINALIZAR COMPRA*/

        public void rellenarComboBoxMetodoPago(ComboBox comboBox)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                foreach (var item in db.Metodo_de_pago)
                {
                    comboBox.Items.Add(item.idMetodoPago + " - " + item.metodo);
                }
            }
        }

        
        public void generarComprobante()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string date = Regex.Replace(System.DateTime.Now.ToString(), @"\s", "");
            date = Regex.Replace(date, @"/", "");
            date = Regex.Replace(date, @":", "");

            //MessageBox.Show(path + @"\venta" + date + ".pdf");
            FileStream fs = new FileStream(@"" + path + @"\venta" + date + ".pdf", FileMode.Create);

            Document doc = new Document(PageSize.LETTER, 5, 5, 7, 7);
            PdfWriter pw = PdfWriter.GetInstance(doc, fs);

            doc.Open();

            //titulo y autor
            doc.AddAuthor("BluLight");
            doc.AddTitle("PDF Generado");

            //Tipo de fuente
            iTextSharp.text.Font standarFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            //encabezado
            doc.Add(new Paragraph("Comprobante de venta " + date));
            //SALTO DE LINEA
            doc.Add(Chunk.NEWLINE);


            doc.Add(new Paragraph("Punto de venta: BluLight"));
            doc.Add(Chunk.NEWLINE);

            doc.Add(new Paragraph("Vendor: " + MyGlobals.persona.nombre + " " + MyGlobals.persona.apellido));
            doc.Add(Chunk.NEWLINE);

            doc.Add(new Paragraph("Cliente: " + MyGlobals.clienteVentas[0].nombre + " " + MyGlobals.clienteVentas[0].apellido));
            doc.Add(Chunk.NEWLINE);


            //Encabezado de columna
            PdfPTable tbl = new PdfPTable(4);
            tbl.WidthPercentage = 100;
            //configuracion del titulo de las columnas
            PdfPCell clNombre = new PdfPCell(new Phrase("Nombre", standarFont));
            clNombre.BorderWidth = 0;
            clNombre.BorderWidthBottom = 0.75f;

            PdfPCell clCantidad = new PdfPCell(new Phrase("Cantidad", standarFont));
            clCantidad.BorderWidth = 0;
            clCantidad.BorderWidthBottom = 0.75f;

            PdfPCell clPrecio = new PdfPCell(new Phrase("Precio c/u", standarFont));
            clPrecio.BorderWidth = 0;
            clPrecio.BorderWidthBottom = 0.75f;

            PdfPCell clSubtotal = new PdfPCell(new Phrase("Subtotal", standarFont));
            clSubtotal.BorderWidth = 0;
            clSubtotal.BorderWidthBottom = 0.75f;

            tbl.AddCell(clNombre);
            tbl.AddCell(clCantidad);
            tbl.AddCell(clPrecio);
            tbl.AddCell(clSubtotal);
            //agregar datos
            float total = 0;
            for (int i = 0; i < MyGlobals.productoVentas.Count; i++)
            {
                clNombre = new PdfPCell(new Phrase(MyGlobals.productoVentas[i].nombre, standarFont));
                clNombre.BorderWidth = 0;

                clPrecio = new PdfPCell(new Phrase(MyGlobals.productoVentas[i].precio.ToString(), standarFont));
                clPrecio.BorderWidth = 0;

                clCantidad = new PdfPCell(new Phrase(MyGlobals.cantidadProducto[i].ToString(), standarFont));
                clCantidad.BorderWidth = 0;

                decimal subtotal = MyGlobals.cantidadProducto[i] * MyGlobals.productoVentas[i].precio;

                clSubtotal = new PdfPCell(new Phrase(subtotal.ToString(), standarFont));
                clSubtotal.BorderWidth = 0;

                total += float.Parse(MyGlobals.cantidadProducto[i].ToString()) * float.Parse(MyGlobals.productoVentas[i].precio.ToString());

                tbl.AddCell(clNombre);
                tbl.AddCell(clPrecio);
                tbl.AddCell(clCantidad);
                tbl.AddCell(clSubtotal);
                
            }

            doc.Add(tbl);

            doc.Add(Chunk.NEWLINE);
            doc.Add(Chunk.NEWLINE);
            doc.Add(Chunk.NEWLINE);

            doc.Add(new Paragraph("Total: " + total.ToString()));
            doc.Add(Chunk.NEWLINE);

            doc.Close();
            pw.Close();

            MessageBox.Show("Comprobante generado", "Finalizar venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void finalizarCompra(ComboBox metodoPago)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                for (int i=0; i<MyGlobals.productoVentas.Count; i++)
                {
                    int idP = MyGlobals.productoVentas[i].idProducto;
                    var producto = db.Producto.Where(p => p.idProducto.Equals(idP)).FirstOrDefault();

                    producto.stock -= MyGlobals.cantidadProducto[i];
                    db.SaveChanges();
                }

                Factura_producto facturaProducto = new Factura_producto();
                facturaProducto.activo = true;
                facturaProducto.fecha = DateTime.Now;
                facturaProducto.idMetodoPago = metodoPago.SelectedIndex+1;
                facturaProducto.idPersona = MyGlobals.clienteVentas[0].idPersona;
                facturaProducto.idEmpleado = MyGlobals.empleado.idEmpleado;

                db.Factura_producto.Add(facturaProducto);
                db.SaveChanges();

                for (int i = 0; i<MyGlobals.productoVentas.Count; i++)
                {
                    Detalle_factura_producto detalleFactura = new Detalle_factura_producto();
                    detalleFactura.idFacturaProd = facturaProducto.idFacturaProd;
                    detalleFactura.idProducto = MyGlobals.productoVentas[i].idProducto;
                    detalleFactura.cantidad = MyGlobals.cantidadProducto[i];
                    detalleFactura.precio = MyGlobals.productoVentas[i].precio;
                    db.Detalle_factura_producto.Add(detalleFactura);
                }

                db.SaveChanges();

                MyGlobals.clienteLabels.Clear();
                MyGlobals.clienteVentas.Clear();
                MyGlobals.productoVentas.Clear();
                MyGlobals.cantidadProducto.Clear();
            }
        }

        public void editarProducto(TextBox cantidadP)
        {
            int cantidad = Int32.Parse(cantidadP.Text);
            if (MyGlobals.productoSeleccionado.stock >= cantidad)
            {
                MyGlobals.cantidadProducto[MyGlobals.indexProducto] = cantidad;

                MessageBox.Show("Producto editado", "Editar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("La cantidad es más alta que el stock del producto", "Editar Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void cambiarProducto(int idP, TextBox cantidadP)
        {
            int cantidad = Int32.Parse(cantidadP.Text);
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                var producto = db.Producto.Where(p => p.idProducto.Equals(idP));
                if (producto.ToList().Count > 0)
                {
                    Producto pro = MyGlobals.productoVentas.Where(p => p.idProducto.Equals(idP)).FirstOrDefault();
                    var existe = MyGlobals.productoVentas.IndexOf(pro);
                    if (existe != -1)
                    {
                        if (MyGlobals.cantidadProducto[existe]+cantidad <= MyGlobals.productoVentas[existe].stock)
                        {
                            MyGlobals.cantidadProducto[existe] += cantidad;
                            MyGlobals.cantidadProducto.RemoveAt(MyGlobals.indexProducto);
                            MyGlobals.productoVentas.RemoveAt(MyGlobals.indexProducto);
                           
                            MessageBox.Show("Producto cambiado", "Cambiar producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("La cantidad ingresada, más la cantidad en el carrito es más alta que el stock del producto", "Cambiar Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        if (producto.FirstOrDefault().stock >= cantidad)
                        {
                            MyGlobals.cantidadProducto[MyGlobals.indexProducto] = cantidad;
                            MyGlobals.productoVentas[MyGlobals.indexProducto] = producto.FirstOrDefault();

                            MessageBox.Show("Producto editado", "Editar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("La cantidad es más alta que el stock del producto", "Editar Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                else
                {
                    MessageBox.Show("El producto no existe", "Editar Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
                
        }
    }
}
