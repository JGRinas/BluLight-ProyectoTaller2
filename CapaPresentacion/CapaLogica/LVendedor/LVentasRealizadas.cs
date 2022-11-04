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
        public int calcularTotalVentas()
        {
            int cantidadProductosV = 0;
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
                                cantidadProductosV += detalle.cantidad;
                            }
                        }
                    }
                }

                
            }
            return cantidadProductosV;
        }
        public void rellenarDataGridClientesAtendidos(DataGridView dataGrid)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                
                int idVendedor = MyGlobals.empleado.idEmpleado;

                List<Factura_producto> facturas = db.Factura_producto.ToList();
                foreach (Factura_producto factura in facturas)
                {
                    if (factura.idEmpleado.Equals(idVendedor))
                    {
                        int cantidadProductosV = 0;
                        List<Detalle_factura_producto> detallesFacturas = db.Detalle_factura_producto.ToList();
                        foreach (Detalle_factura_producto detalle in detallesFacturas)
                        {
                            if (detalle.idFacturaProd.Equals(factura.idFacturaProd))
                            {
                                cantidadProductosV += detalle.cantidad;
                            }
                        }

                        int fila = dataGrid.Rows.Add();
                        dataGrid.Rows[fila].Cells["ColumnFecha"].Value = factura.fecha.ToString();
                        dataGrid.Rows[fila].Cells["ColumnCliente"].Value = factura.Persona.nombre;
                        dataGrid.Rows[fila].Cells["ColumnProductos"].Value = cantidadProductosV.ToString();
                    }
                }
            }

        }

        public void inicializarChart(Chart chartVentas)
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
        }


    }
}
