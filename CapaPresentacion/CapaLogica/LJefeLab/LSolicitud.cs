using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaLogica;
using System.Windows.Forms;
using CapaLogica.Libreria;
using CapaPresentacion.CapaData.Model;
using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using System.Data;

namespace CapaPresentacion.CapaLogica.LJefeLab
{
    internal class LSolicitud : Librerias
    {
        public void rellenarComboBoxServicios(ComboBox comboBoxServicios)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                //lista de servicios -del laboratorio-
                List<Servicio_laboratorio> servicios = db.Servicio_laboratorio.Where(e => e.idLab == MyGlobals.empleado.idLab).ToList();
                //List<Servicio> servicios = db.Servicio.ToList();
                foreach (var item in servicios)
                {
                    comboBoxServicios.Items.Add(item.idServicio + " - " + item.Servicio.nombre);
                }
            }

        }

        public void rellenarComboBoxEmpleados(ComboBox comboBoxServicios)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {

                List<Empleado> empleados = db.Empleado.Where(e => e.idLab == MyGlobals.empleado.idLab).ToList();

                foreach (var item in empleados)
                {
                    comboBoxServicios.Items.Add(
                       item.idEmpleado + " - " + item.Persona.nombre + " " + item.Persona.apellido + " - DNI: " + item.Persona.dni);

                }
            }
        }

        public void rellenarDataGridSolicitudes(BunifuDataGridView dataGridSolicitudes)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                List<Detalle_factura_servicio> solicitudes = new List<Detalle_factura_servicio>();
                //solicitudes = db.Detalle_factura_servicio.ToList();
                solicitudes = db.Detalle_factura_servicio.Where(e => e.idLab == MyGlobals.empleado.idLab && e.idEstado == 1).ToList();

                if (solicitudes.Count > 0)
                {
                    foreach (Detalle_factura_servicio solicitud in solicitudes)
                    {
                        int fila = dataGridSolicitudes.Rows.Add();
                        dataGridSolicitudes.Rows[fila].DefaultCellStyle.BackColor = Color.White;

                        dataGridSolicitudes.Rows[fila].Cells["columnIdSolicitud"].Value = solicitud.idFacturaServ + "-" + solicitud.idServicio + "-" + solicitud.idLab;
                        dataGridSolicitudes.Rows[fila].Cells["columnNombreServicio"].Value = solicitud.Servicio_laboratorio.Servicio.nombre;
                        dataGridSolicitudes.Rows[fila].Cells["columnCantidad"].Value = solicitud.cantidad;
                        dataGridSolicitudes.Rows[fila].Cells["columnDniCliente"].Value = solicitud.Factura_servicio.Persona.dni;
                        dataGridSolicitudes.Rows[fila].Cells["columnNombreCliente"].Value = solicitud.Factura_servicio.Persona.nombre + " " + solicitud.Factura_servicio.Persona.apellido;
                        dataGridSolicitudes.Rows[fila].Cells["columnMailCliente"].Value = solicitud.Factura_servicio.Persona.email;
                        dataGridSolicitudes.Rows[fila].Cells["columnTelefono"].Value = solicitud.Factura_servicio.Persona.telefono;

                        DataGridViewButtonColumn boton = new DataGridViewButtonColumn();

                        boton.Text = "Promover";
                        boton.Name = "btnAccion";
                        boton.HeaderText = "Acción";
                        boton.FlatStyle = FlatStyle.Flat;
                        boton.DefaultCellStyle.BackColor = Color.Red;
                        boton.UseColumnTextForButtonValue = true;
                        dataGridSolicitudes.Columns.Add(boton);
                        //dataGridSolicitudes.Rows[fila].Cells["columnAccion"].Value.;



                    }
                }
            }
        }

        public List<String> filtrarIdSolicitud(string idSolicitud)
        {
            //int posicionBarra1 = 0;
            //int posicionBarra2 = 0;
            int i = 0;
            string idFacturaServ = "";
            string idServicio = "";
            string idLab = "";
            List<String> stringsId = new List<string>();

            while (!(idSolicitud[i].ToString().Equals("-")))
            {
                idFacturaServ = idFacturaServ + (idSolicitud[i]);
                i++;
            }

            i++; //saltear caracter "-"

            while (!(idSolicitud[i].ToString().Equals("-")))
            {
                idServicio = idServicio + (idSolicitud[i]);
                i++;
            }

            i++; //saltear caracter "-"

            while (i < idSolicitud.Length)
            {
                idLab = idLab + (idSolicitud[i]);
                i++;
            }

            stringsId.Add(idFacturaServ.Trim());
            stringsId.Add(idServicio.Trim());
            stringsId.Add(idLab.Trim());

            return stringsId;

        }

        public string filtrarIdEmpleado(string textoEmpleado)
        {
            string idEmpleado = "";
            int i = 0;

            while (!(textoEmpleado[i].ToString().Equals("-")))
            {
                idEmpleado = idEmpleado + (textoEmpleado[i]);
                i++;
            }

            return idEmpleado.Trim();
        }

        public void promoverPendiente(string idSolicitud, string textoEmpleado)
        {
            
            int idFacturaServ = Int32.Parse(filtrarIdSolicitud(idSolicitud)[0]);
            int idServicio = Int32.Parse(filtrarIdSolicitud(idSolicitud)[1]);
            int idLab = Int32.Parse(filtrarIdSolicitud(idSolicitud)[2]);
            int idEmpleado = Int32.Parse(filtrarIdEmpleado(textoEmpleado));

            MessageBox.Show(idEmpleado + "bien", "BIEN AHI", MessageBoxButtons.OK);

            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                var solicitud = db.Detalle_factura_servicio.Where(
                e => e.idFacturaServ == idFacturaServ 
                && e.idServicio == idServicio 
                && e.idLab == idLab).ToList();

                if(solicitud.Count > 0)
                {
                    solicitud.First().idEstado = 2;
                    solicitud.First().idEmpleado = idEmpleado;
                    db.SaveChanges();
                }
            }
        }

    }//fin clase
}
