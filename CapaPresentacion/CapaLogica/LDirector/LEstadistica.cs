using CapaLogica;
using CapaLogica.Libreria;
using CapaPresentacion.CapaData.Model;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Text.RegularExpressions;

namespace CapaPresentacion.CapaLogica.LDirector
{
    internal class LEstadistica : Librerias
    {

        public void rellenarComboBoxProductos(ComboBox productos)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                List<Producto> productosDB = new List<Producto>();
                productosDB = db.Producto.ToList();

  
                productos.Items.Add("Todos");
                foreach (Producto product in productosDB)
                {
                    productos.Items.Add(product.nombre);
                }
            }
        }
        /*Ver la cantidad de productos que se vendieron por día desde una fecha de inicio hasta una cierta fecha*/
        public void inicializarChartProductos(List<DateTimePicker> dateTime, Chart chartProductos)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {

                //total de días entre los timespiker
                TimeSpan totalDias = dateTime[1].Value - dateTime[0].Value;
                int dias = (int) totalDias.TotalDays;
                int[] diasEntre = new int[dias];
                for (int i = 0; i < dias; i++)
                {
                    diasEntre[i] = i+1;
                }
                //---------------------------------
                int[] cantProductos = new int[dias];

                DateTimePicker tiempoDesde = new DateTimePicker();

                tiempoDesde.Value = dateTime[0].Value;
                for (int i = 0; i < dias; i++)
                {
                    cantProductos[i] = 0;
                }

                for (int i = 0; i<dias; i++)
                    {
                        var productosFecha = (from det in db.Detalle_factura_producto
                                              join fact in db.Factura_producto on det.idFacturaProd equals fact.idFacturaProd
                                              where fact.fecha == tiempoDesde.Value.Date
                                              select det).ToList();

                        foreach (var prod in productosFecha)
                        {
                            cantProductos[i] += prod.cantidad;
                        }

                    tiempoDesde.Value = tiempoDesde.Value.AddDays(1);
                    }
                chartProductos.Series[0].Points.Clear();
                for (int i=0; i<dias;  i++)
                {
                    chartProductos.Series[0].Points.AddXY(diasEntre[i], cantProductos[i]);
                
                }

              
                
            }
        }

        public void inicializarChartProductosConFiltro(List<DateTimePicker> dateTime, Chart chartProductos, ComboBox comboBoxProducto)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
              

                //total de días entre los timespiker
                TimeSpan totalDias = dateTime[1].Value - dateTime[0].Value;
                int dias = (int)totalDias.TotalDays;
                int[] diasEntre = new int[dias];
                for (int i = 0; i < dias; i++)
                {
                    diasEntre[i] = i + 1;
                }
                //---------------------------------
                int[] cantProductos = new int[dias];

                for (int i = 0; i<dias; i++)
                {
                    cantProductos[i] = 0;
                }

                DateTimePicker tiempoDesde = new DateTimePicker();

                tiempoDesde.Value = dateTime[0].Value;
            

                for (int i = 0; i < dias; i++)
                {
                    var productosFecha = (from det in db.Detalle_factura_producto
                                          join fact in db.Factura_producto on det.idFacturaProd equals fact.idFacturaProd
                                          join prod in db.Producto on det.idProducto equals prod.idProducto
                                          where fact.fecha == tiempoDesde.Value.Date && prod.nombre.Equals(comboBoxProducto.SelectedItem.ToString())
                                          select det).ToList();

                    foreach (var prod in productosFecha)
                    {
                        cantProductos[i] += prod.cantidad;
                    }

                   

                    tiempoDesde.Value = tiempoDesde.Value.AddDays(1);
                }

                chartProductos.Series[0].Points.Clear();
                for (int i = 0; i < dias; i++)
                {
                    chartProductos.Series[0].Points.AddXY(diasEntre[i], cantProductos[i]);

                }

            }
        }

        public void generarInformeProductos()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string date = Regex.Replace(System.DateTime.Now.ToString(), @"\s", "");
            string date2 = System.DateTime.Now.ToString();
            date = Regex.Replace(date, @"/", "");
            date = Regex.Replace(date, @":", "");

            //MessageBox.Show(path + @"\venta" + date + ".pdf");
            FileStream fs = new FileStream(@"" + path + @"\venta" + date + ".pdf", FileMode.Create);

            Document doc = new Document(PageSize.A4, 50f, 40f, 30f, 30f);
            PdfWriter pw = PdfWriter.GetInstance(doc, fs);

            doc.Open();
            Chunk linea = new Chunk(new iTextSharp.text.pdf.draw.LineSeparator());
            //titulo y autor
            doc.AddAuthor("BluLight");
            doc.AddTitle("PDF Generado");

            //Tipo de fuente
            iTextSharp.text.Font standarFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            //encabezado
            doc.Add(new Paragraph("Informe de Ventas de Productos - Fecha:  " + date2));
            //SALTO DE LINEA
            doc.Add(iTextSharp.text.Chunk.NEWLINE);

            doc.Add(new Paragraph("Punto de venta: BluLight"));
            doc.Add(iTextSharp.text.Chunk.NEWLINE);

            //Gráficos
            for (int i = 0; i < MyGlobals.imagenChartProductos.Count(); i++)
            {
                doc.Add(linea);
                doc.Add(new Paragraph(MyGlobals.titulosImagenChartProductos[i]));
                doc.Add(linea);
                doc.Add(MyGlobals.imagenChartProductos[i]);
                doc.Add(linea);
                doc.Add(iTextSharp.text.Chunk.NEXTPAGE);
              
            }

            MyGlobals.imagenChartProductos.Clear();
            MyGlobals.titulosImagenChartProductos.Clear();

            doc.Close();
            pw.Close();

            MessageBox.Show("Informe de Ventas de Productos generado.", "Informe de Ventas de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
