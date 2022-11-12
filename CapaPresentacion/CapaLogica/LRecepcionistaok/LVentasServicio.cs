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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Drawing.Printing;
using System.Xml.Linq;

namespace CapaPresentacion.CapaLogica.LRecepcionistaok
{
    public class LVentasServicio : Librerias
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

        public void buscarClienteEnVentas(TextBox dniC, List<Label> labels, Button button)
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
        public void buscarClienteEnVentasDataGrid(TextBox dniC, List<Label> labels, Button button, DataGridView dataGrid)
        {
            labels[0].Text = dataGrid.CurrentRow.Cells[1].Value.ToString();
            labels[0].Visible = true;
            labels[1].Text = dataGrid.CurrentRow.Cells[2].Value.ToString();
            labels[1].Visible = true;
            labels[2].Text = dataGrid.CurrentRow.Cells[0].Value.ToString();
            labels[2].Visible = true;
            dniC.Text = dataGrid.CurrentRow.Cells[0].Value.ToString();
            button.Enabled = true;
        }


        public void refrescarClienteCarritoServ(List<Label> labels)
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

                MyGlobals.servicioVentas.Clear(); //se limpia dado que se ha elegido un nuevo cliente
                MyGlobals.cantidadServicio.Clear();

                MessageBox.Show("¡Cliente agregado!", "Nueva venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        //AGREGAR PRODUCTO

        public void rellenarDataGridServicios(DataGridView dataGrid)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                List<Servicio_laboratorio> Servicios = new List<Servicio_laboratorio>();

                Servicios = db.Servicio_laboratorio.ToList();

                if (Servicios.Count > 0)
                {
                    foreach (Servicio_laboratorio servicio in Servicios)
                    {
                        if (servicio.activo)
                        {


                            Servicio_laboratorio serv = MyGlobals.servicioVentas.Where(p => p.idServicio.Equals(servicio.idServicio)).FirstOrDefault();
                            var existe = MyGlobals.servicioVentas.IndexOf(serv);
                            int cantidad = 0;
                            if (existe != -1)
                            {
                                cantidad = MyGlobals.cantidadServicio[existe];
                            }

                            int fila = dataGrid.Rows.Add();

                            dataGrid.Rows[fila].Cells["ColumnId"].Value = servicio.idServicio + " - " + servicio.idLab;
                            dataGrid.Rows[fila].Cells["ColumnNombre"].Value = servicio.Servicio.nombre;
                            dataGrid.Rows[fila].Cells["ColumnLab"].Value = servicio.Laboratorio.nombre;
                            dataGrid.Rows[fila].Cells["ColumnPrecio"].Value = servicio.Servicio.precio;
                            dataGrid.Rows[fila].Cells["ColumnCategoria"].Value = servicio.Servicio.Categoria_servicio.categoria;

                        }
                    }
                }
            }
        }

        public void buscarServicio(List<Label> labels, TextBox textBox, Button button)
        {
            if (textBox.Text.Equals(""))
            {
                MessageBox.Show("Ingrese el nombre del servicio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                using (bd_blulightEntities db = new bd_blulightEntities())
                {
                    var servicio = db.Servicio_laboratorio.Where(s => s.Servicio.nombre.Contains(textBox.Text));
                    if (servicio.ToList().Count > 0 && servicio.FirstOrDefault().activo)
                    {
                        labels[0].Text = servicio.FirstOrDefault().Servicio.nombre;
                        labels[1].Text = servicio.FirstOrDefault().idServicio.ToString();
                        MyGlobals.idServSelecc = servicio.FirstOrDefault().idServicio;
                        MyGlobals.idLabSelecc = servicio.FirstOrDefault().idLab;

                        button.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("El servicio no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        public void obtenerServicioDelDataGrid(List<Label> labels, List<ComboBox> comboBoxes, TextBox textBox, Button button, DataGridView dataGrid)
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


            button.Enabled = true;
        }

        public void agregarServicioCarrito(int idS, TextBox cantidadS, int idLab)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                var servicioV = db.Servicio_laboratorio.Where(s => s.idServicio.Equals(idS) && s.idLab.Equals(idLab));
                int cantidad = Int32.Parse(cantidadS.Text);
                if (servicioV.ToList().Count > 0)
                {
                    //    Servicio_laboratorio servicio = db.Servicio_laboratorio.Where(s => s.idServicio.Equals(idS) && s.idLab.Equals(idLab)).FirstOrDefault();
                    //    Servicio_laboratorio serv = MyGlobals.servicioVentas.Where(s => s.idServicio.Equals(idS) && s.idLab.Equals(idLab)).FirstOrDefault();
                    //    var existe = MyGlobals.servicioVentas.IndexOf(serv);

                    //    if (existe != -1)
                    //    {
                    //           MyGlobals.cantidadProducto[existe] += cantidad;
                    //           MessageBox.Show("El servicio fue agregado!", "Agregar servicio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    }
                    //    }
                    //    else
                    //{
                    Servicio_laboratorio servicio = new Servicio_laboratorio();
                    servicio = servicioV.FirstOrDefault();
                    MyGlobals.servicioVentas.Add(servicio);
                    MyGlobals.servicioVentas2.Add(servicio.Servicio);
                    MyGlobals.cantidadServicio.Add(cantidad);
                    MyGlobals.dataGridServiciosVentas.Rows.Clear();
                    rellenarDataGridCarritoServicios(MyGlobals.dataGridProductosVentas);
                    MessageBox.Show("El Servicio fue agregado!", "Agregar servicio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}

                }
            }
        }
            
        
        public void rellenarDataGridCarritoServicios(DataGridView dataGrid)
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
            doc.Add(iTextSharp.text.Chunk.NEWLINE);


            doc.Add(new Paragraph("Punto de venta: BluLight"));
            doc.Add(iTextSharp.text.Chunk.NEWLINE);

            doc.Add(new Paragraph("Vendor: " + MyGlobals.persona.nombre + " " + MyGlobals.persona.apellido));
            doc.Add(iTextSharp.text.Chunk.NEWLINE);

            doc.Add(new Paragraph("Cliente: " + MyGlobals.clienteVentas[0].nombre + " " + MyGlobals.clienteVentas[0].apellido));
            doc.Add(iTextSharp.text.Chunk.NEWLINE);


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
            for (int i = 0; i < MyGlobals.servicioVentas2.Count; i++)
            {
                clNombre = new PdfPCell(new Phrase(MyGlobals.servicioVentas2[i].nombre, standarFont));
                clNombre.BorderWidth = 0;

                clPrecio = new PdfPCell(new Phrase(MyGlobals.servicioVentas2[i].precio.ToString(), standarFont));
                clPrecio.BorderWidth = 0;

                clCantidad = new PdfPCell(new Phrase(MyGlobals.cantidadServicio[i].ToString(), standarFont));
                clCantidad.BorderWidth = 0;

                decimal subtotal = MyGlobals.cantidadServicio[i] * MyGlobals.servicioVentas2[i].precio;

                clSubtotal = new PdfPCell(new Phrase(subtotal.ToString(), standarFont));
                clSubtotal.BorderWidth = 0;

                total += float.Parse(MyGlobals.cantidadServicio[i].ToString()) * float.Parse(MyGlobals.servicioVentas2[i].precio.ToString());

                tbl.AddCell(clNombre);
                tbl.AddCell(clPrecio);
                tbl.AddCell(clCantidad);
                tbl.AddCell(clSubtotal);

            }

            doc.Add(tbl);

            doc.Add(iTextSharp.text.Chunk.NEWLINE);
            doc.Add(iTextSharp.text.Chunk.NEWLINE);
            doc.Add(iTextSharp.text.Chunk.NEWLINE);

            doc.Add(new Paragraph("Total: " + total.ToString()));
            doc.Add(iTextSharp.text.Chunk.NEWLINE);

            doc.Close();
            pw.Close();

            MessageBox.Show("Comprobante generado", "Finalizar venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void finalizarCompra(ComboBox metodoPago)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                //for (int i = 0; i < MyGlobals.servicioVentas.Count; i++)
                //{
                //    int idServicio = MyGlobals.servicioVentas[i].Servicio.idServicio;
                //    var servicio = db.Servicio.Where(s => s.idServicio.Equals(idServicio) && s.activo == true).FirstOrDefault();

                //    producto.stock -= MyGlobals.cantidadProducto[i];
                //    db.SaveChanges();
                //}

                Factura_servicio facturaServ = new Factura_servicio();
                facturaServ.activo = true;
                facturaServ.fecha = DateTime.Now.Date;
                facturaServ.hora = DateTime.Now.TimeOfDay;
                facturaServ.idMetodoPago = metodoPago.SelectedIndex + 1;
                facturaServ.idPersona = MyGlobals.clienteVentas[0].idPersona;
                facturaServ.idEmpleado = MyGlobals.empleado.idEmpleado;

                db.Factura_servicio.Add(facturaServ);
                db.SaveChanges();

                for (int i = 0; i < MyGlobals.servicioVentas.Count; i++)
                {
                    Detalle_factura_servicio detalleFactura = new Detalle_factura_servicio();
                    detalleFactura.idFacturaServ = facturaServ.idFacturaServ;
                    detalleFactura.idServicio = MyGlobals.servicioVentas[i].idServicio;
                    detalleFactura.idLab = MyGlobals.servicioVentas[i].idLab;
                    detalleFactura.cantidad = MyGlobals.cantidadServicio[i];
                    detalleFactura.precio = MyGlobals.servicioVentas2[i].precio;
                    detalleFactura.idEstado = 1;
                    detalleFactura.activo = true;
                    //el idEmpleado no se especifica en esta instancia, dado que dicho campo se refiere
                    // al empleado que realizó el servicio, no a aquel que realizó la venta. Dicho campo se 
                    // va especificar en una instancia posterior.
                    // El empleado que realizó la venta va en la tabla Factura.
                    db.Detalle_factura_servicio.Add(detalleFactura);
                }

                db.SaveChanges();

                MyGlobals.clienteLabels.Clear();
                MyGlobals.clienteVentas.Clear();
                MyGlobals.servicioVentas.Clear();
                MyGlobals.cantidadServicio.Clear();
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
                        if (MyGlobals.cantidadProducto[existe] + cantidad <= MyGlobals.productoVentas[existe].stock)
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
