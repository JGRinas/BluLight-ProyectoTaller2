using CapaLogica;
using CapaLogica.Libreria;
using CapaPresentacion.CapaData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CapaPresentacion.CapaLogica.LVendedor
{
    internal class LVentasRealizadas : Librerias
    {
        public decimal calcularTotalVentas()
        {
            decimal totalRecaudado = 0;
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
               
                int idVendedor = MyGlobals.empleado.idEmpleado;

                List<Factura_producto> facturas = db.Factura_producto.ToList();
                foreach (Factura_producto factura in facturas)
                {
                    if (factura.idEmpleado.Equals(idVendedor))
                    {
                        List<Detalle_factura_producto> detallesFacturas = db.Detalle_factura_producto.ToList();
                        foreach (Detalle_factura_producto detalle in detallesFacturas)
                        {
                            if (detalle.idFacturaProd.Equals(factura.idFacturaProd))
                            {
                                totalRecaudado += detalle.cantidad * detalle.Producto.precio;
                            }
                        }
                    }
                }

                
            }
            return totalRecaudado;
        }

        public void rellenarDataGridClientesAtendidos(DataGridView dataGrid, DateTimePicker dateTime, Label mes)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                string mesV;
                switch (Int32.Parse(dateTime.Value.Month.ToString()))
                {
                    case 1 : mesV = "enero"; break;
                    case 2 : mesV = "febrero"; break;
                    case 3 : mesV = "marzo"; break;
                    case 4 : mesV = "abril"; break;
                    case 5 : mesV = "mayo"; break;
                    case 6 : mesV = "junio"; break;
                    case 7 : mesV = "julio"; break;
                    case 8 : mesV = "agosto"; break;
                    case 9 : mesV = "septiembre"; break;
                    case 10 : mesV = "octubre"; break;
                    case 11 : mesV = "noviembre"; break;
                    case 12 : mesV = "diciembre"; break;
                    default: mesV = ""; break;
                }
                mes.Text = "Clientes atendidos en el mes de " + mesV + ":";

                int idVendedor = MyGlobals.empleado.idEmpleado;

                List<Factura_producto> facturas = db.Factura_producto.ToList();
                foreach (Factura_producto factura in facturas)
                {
                    if (factura.idEmpleado.Equals(idVendedor) && (factura.fecha.Month == dateTime.Value.Month && factura.fecha.Year == dateTime.Value.Year))
                    {
                        decimal totalVenta = 0;
                        List<Detalle_factura_producto> detallesFacturas = db.Detalle_factura_producto.ToList();
                        foreach (Detalle_factura_producto detalle in detallesFacturas)
                        {
                            if (detalle.idFacturaProd.Equals(factura.idFacturaProd))
                            {
                                totalVenta += detalle.precio * detalle.cantidad;
                            }
                        }

                        int fila = dataGrid.Rows.Add();
                        dataGrid.Rows[fila].Cells["ColumnId"].Value = factura.idFacturaProd;
                        dataGrid.Rows[fila].Cells["ColumnFecha"].Value = factura.fecha.Day + "/" + factura.fecha.Month + "/" + factura.fecha.Year;
                        dataGrid.Rows[fila].Cells["ColumnCliente"].Value = factura.Persona.nombre;
                        dataGrid.Rows[fila].Cells["ColumnHora"].Value = factura.hora.ToString() ;
                        dataGrid.Rows[fila].Cells["ColumnTotal"].Value = totalVenta.ToString();
                    }
                }
            }

        }

        public void buscarVentaDataGrid(int nroVenta, List<Label> labels, TextBox textBox)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                Factura_producto factura = new Factura_producto();
                factura = db.Factura_producto.Where(f => f.idFacturaProd.Equals(nroVenta)).FirstOrDefault();

               
                labels[1].Text = factura.Persona.nombre + " " + factura.Persona.apellido;
                labels[2].Text = factura.Persona.dni.ToString();
                labels[3].Text = factura.Persona.email;
                labels[4].Text = factura.Metodo_de_pago.metodo;

                List<Detalle_factura_producto> detallesFacturas = db.Detalle_factura_producto.Where(d => d.idFacturaProd.Equals(nroVenta)).ToList();
                decimal totalVenta = 0;
                textBox.Text = "";
                foreach (Detalle_factura_producto detalle in detallesFacturas)
                {
                        textBox.Text += detalle.Producto.nombre + " x" + detalle.cantidad + " - ";
                        totalVenta += detalle.precio * detalle.cantidad;
                }
                labels[0].Text = totalVenta.ToString();
            }
        }

       /* public void inicializarChart(Chart chartVentas)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                int idVendedor = Int32.Parse(MyGlobals.empleado.idEmpleado.ToString());

             

                var facturas = db.Factura_producto.Where(f => f.Empleado.idEmpleado.Equals(idVendedor)).ToList();

                if (facturas.Count > 0)
                {

                    List<int> diaDelMes = new List<int>();
                    List<int> cantClientes = new List<int>();
                    
                    int mes;
                    for(int i = 0; i < facturas.Count; i++)
                    {
                        int cant = 0;
                        mes = Int32.Parse(facturas[i].fecha.Month.ToString());
                        if (mes == Int32.Parse(DateTime.Now.Month.ToString()))
                        {
                            if (diaDelMes.Count == 0)
                            {
                                diaDelMes.Add(Int32.Parse(facturas[i].fecha.Day.ToString()));
                                cant++;
                            }
                            else
                            {
                                int diaE = diaDelMes.Where(d => d.Equals(Int32.Parse(facturas[i].fecha.Day.ToString()))).FirstOrDefault();
                                var existe = diaDelMes.IndexOf(diaE);
                                if (existe == -1)
                                {
                                    diaDelMes.Add(Int32.Parse(facturas[i].fecha.Day.ToString()));
                                    
                                }
                                else
                                {
                                  
                                }
                                    
                            }
        
                        }
                    }
                    foreach(int dia in diaDelMes)
                    {
                        chartVentas.Series["Ventas"].Points.AddXY(dia, 1);
                       
                    }
                    
                }
            }
        }*/


    }
}
