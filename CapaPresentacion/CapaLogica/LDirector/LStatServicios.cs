using CapaLogica;
using CapaPresentacion.CapaData.Model;
using iTextSharp.text.pdf;
using iTextSharp.text;
using LinqToDB.Tools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CapaPresentacion.CapaLogica.LDirector
{
    internal class LStatServicios
    {
        public void cargarCheckedListBoxCategorias(CheckedListBox checkedListBoxCategorias) {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                var categorias = db.Categoria_servicio.ToList();

                foreach (var c in categorias) {
                    checkedListBoxCategorias.Items.Add(c.categoria);
                
                }
            }
        }

        public void generarGraficoGlobales(Chart chartGlobales, CheckedListBox checkedListBoxCategorias,
        CheckedListBox checkedListAnio, RadioButton radioNro)
        {
            string[] serieMeses = { "Ene", "Feb", "Mar", "Abr", "May", "Jun", "Jul", "Ago", "Sept", "Oct", "Nov", "Dic" };
            int[] puntos = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };//= { 20, 10, 30, 20, 25, 22, 20, 10, 10, 50, 60, 55 };
            Decimal[] puntosDecimal = {0,0,0,0,0,0,0,0,0,0,0,0 };
            Color[] colores = { Color.Green, Color.Blue };
            string stringCategorias = "";

            foreach (string cat in checkedListBoxCategorias.CheckedItems) {
                stringCategorias += cat + " "; 
            }
            

            int[] idCategorias = { 1, 2, 3, 4, 5, 6, 7 };
            this.establecerTituloGraficoGlobal(chartGlobales, checkedListBoxCategorias, checkedListAnio, radioNro);

            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                for (int j = 0; j < checkedListAnio.CheckedItems.Count; j++)
                {
                    int anioSeleccionado = Int32.Parse(checkedListAnio.CheckedItems[j].ToString());
                    //var servicios = db.Detalle_factura_servicio.Where(s => s.activo == true 
                    //&& s.Servicio_laboratorio.Servicio.Categoria_servicio.categoria.In("Microscopía", "Citología")
                    //&& s.Factura_servicio.fecha.Year == aniosSeleccionados[j]);

                    if (radioNro.Checked)
                    {
                        Series serie = new Series();

                        for (int i = 0; i < serieMeses.Length; i++)
                        {
                            //var serviciosMes = db.Detalle_factura_servicio.Where
                            //(s => s.activo == true
                            //&& s.Servicio_laboratorio.Servicio.Categoria_servicio.categoria.In("Microscopía", "Citología")
                            //&& s.Factura_servicio.fecha.Year == anioSeleccionado
                            //&& s.Factura_servicio.fecha.Month == (i + 1)
                            //&& s.Servicio_laboratorio.Servicio.Categoria_servicio.categoria.Any(categoria => idCategorias.Contains(categoria))).ToList();

                            var serviciosMes = (from det in db.Detalle_factura_servicio
                                                join fact in db.Factura_servicio on det.idFacturaServ equals fact.idFacturaServ
                                                join serv in db.Servicio on det.idServicio equals serv.idServicio
                                                join cat in db.Categoria_servicio on serv.idCategoriaServ equals cat.idCategoriaServ
                                                where fact.fecha.Year == anioSeleccionado &&
                                                fact.fecha.Month == (i + 1) &&
                                                stringCategorias.Contains(cat.categoria)
                                                select det
                                                ).ToList();

                            foreach (var serv in serviciosMes) {
                                puntos[i] += serv.cantidad;
                            }
                           
                            serie.Points.AddXY(serieMeses[i], puntos[i]);
                            //serie.Points[i].Color = Color.Green;
                        }

                        serie.Name = checkedListAnio.CheckedItems[j].ToString();
                        serie.Color = colores[j];
                        chartGlobales.Series.Add(serie);
                    }
                    else
                    {
                        Series serie = new Series();

                        for (int i = 0; i < serieMeses.Length; i++)
                        {
                           // var serviciosMes = db.Detalle_factura_servicio.Where(s => s.activo == true
                           ////&& s.Servicio_laboratorio.Servicio.Categoria_servicio.categoria.In("Microscopía", "Citología")
                           //&& s.Factura_servicio.fecha.Year == anioSeleccionado
                           //&& s.Factura_servicio.fecha.Month == (i + 1)
                           //&& s.Servicio_laboratorio.Servicio.Categoria_servicio.categoria.Any(categoria => idCategorias.Contains(categoria))).ToList();

                            var serviciosMes = (from det in db.Detalle_factura_servicio
                                                join fact in db.Factura_servicio on det.idFacturaServ equals fact.idFacturaServ
                                                join serv in db.Servicio on det.idServicio equals serv.idServicio
                                                join cat in db.Categoria_servicio on serv.idCategoriaServ equals cat.idCategoriaServ
                                                where fact.fecha.Year == anioSeleccionado &&
                                                fact.fecha.Month == (i + 1) &&
                                                stringCategorias.Contains(cat.categoria)
                                                select det
                                                ).ToList();

                            foreach (var serv in serviciosMes)
                            {
                                puntosDecimal[i] += (serv.precio * serv.cantidad);
                            }

                            serie.Points.AddXY(serieMeses[i], puntosDecimal[i]);
                        }

                        serie.Name = checkedListAnio.CheckedItems[j].ToString();
                        serie.Color = colores[j];
                        chartGlobales.Series.Add(serie);
                    }
                }
            }
        }

        public void establecerTituloGraficoGlobal(Chart chartGlobales, CheckedListBox checkedListBoxCategorias,
        CheckedListBox checkedListAnio, RadioButton radioNro) {
            string titulo = "";
            
            
            if (radioNro.Checked)
            {
                titulo = "Nro. de ventas anuales, año";
            }
            else {
                titulo = "Monto (AR$) recaudado en ventas, año";
            }

            
            if (checkedListAnio.CheckedItems.Count == 1)
            {
                titulo = titulo + " " + checkedListAnio.CheckedItems[0].ToString();
                if (checkedListBoxCategorias.CheckedItems.Count < 3)
                {
                    titulo = titulo + ", categorías ";
                    for (int i = 0; i < checkedListBoxCategorias.CheckedItems.Count; i++)
                    {
                        titulo = titulo + checkedListBoxCategorias.CheckedItems[i].ToString();
                        titulo = titulo + ", ";
                    }

                }
                else
                {
                    titulo = titulo + ", múltiples categorías ";
                }
            }
            else {
                titulo = titulo + "s " + checkedListAnio.CheckedItems[0].ToString() + " y " 
                + checkedListAnio.CheckedItems[1].ToString();

                if (checkedListBoxCategorias.CheckedItems.Count < 3)
                {
                    titulo = titulo + ", categorías ";
                    for (int i = 0; i < checkedListBoxCategorias.CheckedItems.Count; i++)
                    {
                        titulo = titulo + checkedListBoxCategorias.CheckedItems[i].ToString();
                        titulo = titulo + ", ";
                    }

                }
                else
                {
                    titulo = titulo + ", múltiples categorías ";
                }

            }

            chartGlobales.Titles.Add(titulo);
        }


        public void generarGraficoTorta(Chart chartTorta, CheckedListBox checkedListBoxCategorias,
        RadioButton radio2022, RadioButton radioNro)
        {
            List<String> serieCategorias = new List<String>();
            int[] puntos = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            Decimal[] puntosDecimal = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            Color[] colores = { Color.Green, Color.Blue };
            string stringCategorias = "";

            foreach (string cat in checkedListBoxCategorias.CheckedItems)
            {
                stringCategorias += cat + " ";
            }

            foreach (string cat in checkedListBoxCategorias.CheckedItems)
            {
                serieCategorias.Add(cat);
            }


            int[] idCategorias = { 1, 2, 3, 4, 5, 6, 7 };
            this.establecerTituloGraficoTorta(chartTorta, checkedListBoxCategorias, radio2022, radioNro);

            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                int anioSeleccionado = 0;

                if (radio2022.Checked)
                {
                    anioSeleccionado = 2022;
                }
                else {
                    anioSeleccionado = 2021;
                }

                if (radioNro.Checked)
                    {
                        Series serie = new Series();
                        serie.ChartType = SeriesChartType.Pie;

                        for (int i = 0; i < serieCategorias.Count; i++)
                        {
                            string tempCategoria = serieCategorias[i];

                            var serviciosCategoria = (from det in db.Detalle_factura_servicio
                                                join fact in db.Factura_servicio on det.idFacturaServ equals fact.idFacturaServ
                                                join serv in db.Servicio on det.idServicio equals serv.idServicio
                                                join cat in db.Categoria_servicio on serv.idCategoriaServ equals cat.idCategoriaServ
                                                where fact.fecha.Year == anioSeleccionado &&
                                                tempCategoria.Contains(cat.categoria)
                                                select det
                                                ).ToList();

                            foreach (var serv in serviciosCategoria)
                            {
                                puntos[i] += serv.cantidad;
                            }

                            if (puntos[i] > 0)
                            {
                                serie.Points.AddXY(serieCategorias[i], puntos[i]);
                            }
                        }

                        serie.Name = "año" + anioSeleccionado.ToString();
                        serie.Palette = ChartColorPalette.EarthTones;
                        chartTorta.Series.Add(serie);
                    }
                    else
                    {
                        Series serie = new Series();
                        serie.ChartType = SeriesChartType.Pie;

                        for (int i = 0; i < serieCategorias.Count; i++)
                        {
                            string tempCategoria = serieCategorias[i];

                            var serviciosCategoria = (from det in db.Detalle_factura_servicio
                                                join fact in db.Factura_servicio on det.idFacturaServ equals fact.idFacturaServ
                                                join serv in db.Servicio on det.idServicio equals serv.idServicio
                                                join cat in db.Categoria_servicio on serv.idCategoriaServ equals cat.idCategoriaServ
                                                where fact.fecha.Year == anioSeleccionado &&
                                                tempCategoria.Contains(cat.categoria)
                                                select det
                                                ).ToList();

                            foreach (var serv in serviciosCategoria)
                            {
                                puntosDecimal[i] += (serv.precio * serv.cantidad);
                            }
                            
                            if (puntosDecimal[i] > 0) {
                                serie.Points.AddXY(serieCategorias[i], puntosDecimal[i]);
                            }
                           
                        }

                        serie.Name = "año" + anioSeleccionado.ToString();
                        serie.Palette = ChartColorPalette.SeaGreen;
                        chartTorta.Series.Add(serie);
                    }
                
            }
        }

        public void establecerTituloGraficoTorta(Chart chartTorta, CheckedListBox checkedListBoxCategorias,
        RadioButton radio2022, RadioButton radioNro)
        {
            string titulo = "";


            if (radioNro.Checked)
            {
                titulo = "Proporción Nro. de ventas anuales, año";
            }
            else
            {
                titulo = "Proporción Monto (AR$) recaudado en ventas, año";
            }


            if (radio2022.Checked)
            {
                titulo = titulo + " 2022";
                if (checkedListBoxCategorias.CheckedItems.Count < 3)
                {
                    titulo = titulo + ", categorías ";
                    for (int i = 0; i < checkedListBoxCategorias.CheckedItems.Count; i++)
                    {
                        titulo = titulo + checkedListBoxCategorias.CheckedItems[i].ToString();
                        titulo = titulo + ", ";
                    }

                }
                else
                {
                    titulo = titulo + ", múltiples categorías ";
                }
            }
            else
            {
                titulo = titulo + "2021";

                if (checkedListBoxCategorias.CheckedItems.Count < 3)
                {
                    titulo = titulo + ", categorías ";
                    for (int i = 0; i < checkedListBoxCategorias.CheckedItems.Count; i++)
                    {
                        titulo = titulo + checkedListBoxCategorias.CheckedItems[i].ToString();
                        titulo = titulo + ", ";
                    }

                }
                else
                {
                    titulo = titulo + ", múltiples categorías ";
                }

            }

            chartTorta.Titles.Add(titulo);
        }

        public void generarInformeServicios(Chart chart1)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string date = Regex.Replace(System.DateTime.Now.ToString(), @"\s", "");
            date = Regex.Replace(date, @"/", "");
            date = Regex.Replace(date, @":", "");

            //MessageBox.Show(path + @"\venta" + date + ".pdf");
            FileStream fs = new FileStream(@"" + path + @"\venta" + date + ".pdf", FileMode.Create);

            Document doc = new Document(PageSize.A4, 50f, 40f, 30f, 30f);
            PdfWriter pw = PdfWriter.GetInstance(doc, fs);

            doc.Open();

            //titulo y autor
            doc.AddAuthor("BluLight");
            doc.AddTitle("PDF Generado");

            //Tipo de fuente
            iTextSharp.text.Font standarFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            //encabezado
            doc.Add(new Paragraph("Informe de Ventas de Servicios - Fecha:  " + date));
            //SALTO DE LINEA
            doc.Add(iTextSharp.text.Chunk.NEWLINE);


            //doc.Add(new Paragraph("Punto de venta: BluLight"));
            //doc.Add(iTextSharp.text.Chunk.NEWLINE);

            //doc.Add(new Paragraph("Vendor: " + MyGlobals.persona.nombre + " " + MyGlobals.persona.apellido));
            //doc.Add(iTextSharp.text.Chunk.NEWLINE);

            //doc.Add(new Paragraph("Cliente: " + MyGlobals.clienteVentas[0].nombre + " " + MyGlobals.clienteVentas[0].apellido));
            //doc.Add(iTextSharp.text.Chunk.NEWLINE);

            //Gráficos
            var chartImage = new MemoryStream();
            chart1.SaveImage(chartImage, ChartImageFormat.Png);
            iTextSharp.text.Image Chart_image = iTextSharp.text.Image.GetInstance(chartImage.GetBuffer());
            doc.Add(Chart_image);

            //Encabezado de columna
            //PdfPTable tbl = new PdfPTable(4);
            //tbl.WidthPercentage = 100;
            ////configuracion del titulo de las columnas
            //PdfPCell clNombre = new PdfPCell(new Phrase("Nombre", standarFont));
            //clNombre.BorderWidth = 0;
            //clNombre.BorderWidthBottom = 0.75f;

            //PdfPCell clCantidad = new PdfPCell(new Phrase("Cantidad", standarFont));
            //clCantidad.BorderWidth = 0;
            //clCantidad.BorderWidthBottom = 0.75f;

            //PdfPCell clPrecio = new PdfPCell(new Phrase("Precio c/u", standarFont));
            //clPrecio.BorderWidth = 0;
            //clPrecio.BorderWidthBottom = 0.75f;

            //PdfPCell clSubtotal = new PdfPCell(new Phrase("Subtotal", standarFont));
            //clSubtotal.BorderWidth = 0;
            //clSubtotal.BorderWidthBottom = 0.75f;

            //tbl.AddCell(clNombre);
            //tbl.AddCell(clCantidad);
            //tbl.AddCell(clPrecio);
            //tbl.AddCell(clSubtotal);
            ////agregar datos
            //float total = 0;
            //for (int i = 0; i < MyGlobals.servicioVentas2.Count; i++)
            //{
            //    clNombre = new PdfPCell(new Phrase(MyGlobals.servicioVentas2[i].nombre, standarFont));
            //    clNombre.BorderWidth = 0;

            //    clPrecio = new PdfPCell(new Phrase(MyGlobals.servicioVentas2[i].precio.ToString(), standarFont));
            //    clPrecio.BorderWidth = 0;

            //    clCantidad = new PdfPCell(new Phrase(MyGlobals.cantidadServicio[i].ToString(), standarFont));
            //    clCantidad.BorderWidth = 0;

            //    decimal subtotal = MyGlobals.cantidadServicio[i] * MyGlobals.servicioVentas2[i].precio;

            //    clSubtotal = new PdfPCell(new Phrase(subtotal.ToString(), standarFont));
            //    clSubtotal.BorderWidth = 0;

            //    total += float.Parse(MyGlobals.cantidadServicio[i].ToString()) * float.Parse(MyGlobals.servicioVentas2[i].precio.ToString());

            //    tbl.AddCell(clNombre);
            //    tbl.AddCell(clPrecio);
            //    tbl.AddCell(clCantidad);
            //    tbl.AddCell(clSubtotal);

            //}

            //doc.Add(tbl);

            //doc.Add(iTextSharp.text.Chunk.NEWLINE);
            //doc.Add(iTextSharp.text.Chunk.NEWLINE);
            //doc.Add(iTextSharp.text.Chunk.NEWLINE);

            //doc.Add(new Paragraph("Total: " + total.ToString()));
            //doc.Add(iTextSharp.text.Chunk.NEWLINE);

            doc.Close();
            pw.Close();

            MessageBox.Show("Informe de Ventas de Servicios generado.", "Informe de Ventas de Servicios", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }//finclase
}
