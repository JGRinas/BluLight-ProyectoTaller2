using CapaLogica;
using CapaLogica.Libreria;
using CapaPresentacion.CapaData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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


    }
}
