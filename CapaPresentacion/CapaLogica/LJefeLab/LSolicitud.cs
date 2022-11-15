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
using CapaPresentacion.VistaRecepcionista.Servicios;
using System.Text.RegularExpressions;

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
                    comboBoxServicios.Items.Add(item.Servicio.nombre);
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

        public void rellenarComboBoxEmpSeleccionado(ComboBox comboBoxEmpleados, string idSolicitud)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                int idFacturaServ = Int32.Parse(this.filtrarIdSolicitud(idSolicitud)[0]);
                int idServicio = Int32.Parse(this.filtrarIdSolicitud(idSolicitud)[1]);
                List<Detalle_factura_servicio> solicitudes = db.Detalle_factura_servicio.Where(e => 
                e.idFacturaServ == idFacturaServ
                && e.idServicio == idServicio
                && e.idLab == MyGlobals.empleado.idLab
                ).ToList();

                foreach (var item in solicitudes)
                {
                    comboBoxEmpleados.Items.Add(
                       item.idEmpleado + " - " + item.Empleado.Persona.nombre + " " + item.Empleado.Persona.apellido + " - DNI: " + item.Empleado.Persona.dni);

                }

                comboBoxEmpleados.SelectedIndex = 0;
            }
        }



        public void rellenarDataGridSolicitudesFull(BunifuDataGridView dataGridSolicitudes)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                List<Detalle_factura_servicio> solicitudes = new List<Detalle_factura_servicio>();
                //solicitudes = db.Detalle_factura_servicio.ToList();
                solicitudes = db.Detalle_factura_servicio.Where(e => e.idLab == MyGlobals.empleado.idLab).ToList();

                if (solicitudes.Count > 0)
                {
                    foreach (Detalle_factura_servicio solicitud in solicitudes)
                    {

                        int fila = dataGridSolicitudes.Rows.Add();
                        

                        if (solicitud.activo == true)
                        {
                            dataGridSolicitudes.Rows[fila].Cells["columnActivo"].Value = "Si";
                            dataGridSolicitudes.Rows[fila].DefaultCellStyle.BackColor = Color.White;
                            dataGridSolicitudes.Rows[fila].Cells["columnAltaBaja"].Value = "Baja";
                        }
                        else {
                            dataGridSolicitudes.Rows[fila].Cells["columnActivo"].Value = "No";
                            dataGridSolicitudes.Rows[fila].DefaultCellStyle.BackColor = Color.Gray;
                            dataGridSolicitudes.Rows[fila].Cells["columnAltaBaja"].Value = "Alta";
                        }

                        dataGridSolicitudes.Rows[fila].Cells["columnIdSolicitud"].Value = solicitud.idFacturaServ + "-" + solicitud.idServicio + "-" + solicitud.idLab;
                        dataGridSolicitudes.Rows[fila].Cells["columnNombreServicio"].Value = solicitud.Servicio_laboratorio.Servicio.nombre;
                        dataGridSolicitudes.Rows[fila].Cells["columnCantidad"].Value = solicitud.cantidad;
                        dataGridSolicitudes.Rows[fila].Cells["columnDniCliente"].Value = solicitud.Factura_servicio.Persona.dni;
                        dataGridSolicitudes.Rows[fila].Cells["columnNombreCliente"].Value = solicitud.Factura_servicio.Persona.nombre + " " + solicitud.Factura_servicio.Persona.apellido;
                        
                        
                    }
                }
            }
        }

        public void rellenarDataGridSolicitudes(BunifuDataGridView dataGridSolicitudes)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                List<Detalle_factura_servicio> solicitudes = new List<Detalle_factura_servicio>();
                //solicitudes = db.Detalle_factura_servicio.ToList();
                solicitudes = db.Detalle_factura_servicio.Where(e => e.idLab == MyGlobals.empleado.idLab && e.idEstado == 1 && e.activo == true).ToList();

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
                        dataGridSolicitudes.Rows[fila].Cells["columnAccion"].Value = "Promover";
                    }
                }
            }
        }

        public void rellenarDataGridSolicitudesFinalizadas(BunifuDataGridView dataGridSolicitudes)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                List<Detalle_factura_servicio> solicitudes = new List<Detalle_factura_servicio>();
                //solicitudes = db.Detalle_factura_servicio.ToList();
                solicitudes = db.Detalle_factura_servicio.Where(e => e.idLab == MyGlobals.empleado.idLab && e.idEstado == 2 && e.activo == true).ToList();

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
                        dataGridSolicitudes.Rows[fila].Cells["columnAccion"].Value = "Promover";

                    }
                }
            }
        }

        public void rellenarDataGridSolicitudesEntregadas(BunifuDataGridView dataGridSolicitudes)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                List<Detalle_factura_servicio> solicitudes = new List<Detalle_factura_servicio>();
                //solicitudes = db.Detalle_factura_servicio.ToList();
                solicitudes = db.Detalle_factura_servicio.Where(e => e.idLab == MyGlobals.empleado.idLab && e.idEstado == 3 && e.activo == true).ToList();

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
                        dataGridSolicitudes.Rows[fila].Cells["columnAccion"].Value = "Revertir";

                    }
                }
            }
        }

        //****método para obtener las id independientes a partir de una string con formato 1-1-1
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

        //****método para obtener las id independientes a partir de una string con formato 1-1-1
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
            if (MessageBox.Show("¿Está seguro que desea marcar la solicitud como REALIZADA?", "Marcar solicitud como REALIZADA", MessageBoxButtons.YesNo) == DialogResult.Yes) {

                int idFacturaServ = Int32.Parse(filtrarIdSolicitud(idSolicitud)[0]);
                int idServicio = Int32.Parse(filtrarIdSolicitud(idSolicitud)[1]);
                int idLab = Int32.Parse(filtrarIdSolicitud(idSolicitud)[2]);
                int idEmpleado = Int32.Parse(filtrarIdEmpleado(textoEmpleado));


                using (bd_blulightEntities db = new bd_blulightEntities())
                {
                    var solicitud = db.Detalle_factura_servicio.Where(
                    e => e.idFacturaServ == idFacturaServ
                    && e.idServicio == idServicio
                    && e.idLab == idLab).ToList();

                    if (solicitud.Count > 0)
                    {
                        solicitud.First().idEstado = 2;
                        solicitud.First().fechaFinalizacion = DateTime.Today;
                        solicitud.First().idEmpleado = idEmpleado;
                        //solicitud.First().fechaFinalizacion = dsadasds;
                        db.SaveChanges();
                        MessageBox.Show("El estado de la solicitud ha sido promovida a REALIZADA.", "Solicitud promovida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
        }

        public void estadoEntregado(string idSolicitud, string textoEmpleado)
        {
            if (MessageBox.Show("¿Está seguro que desea marcar la solicitud como ENTREGADA?", "Marcar solicitud como ENTREGADA", MessageBoxButtons.YesNo) == DialogResult.Yes){

                int idFacturaServ = Int32.Parse(filtrarIdSolicitud(idSolicitud)[0]);
                int idServicio = Int32.Parse(filtrarIdSolicitud(idSolicitud)[1]);
                int idLab = Int32.Parse(filtrarIdSolicitud(idSolicitud)[2]);
                int idEmpleado = Int32.Parse(filtrarIdEmpleado(textoEmpleado));

                MessageBox.Show("El estado de la solicitud ha sido promovido a ENTREGADO", "Estado de solicitud promovido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                using (bd_blulightEntities db = new bd_blulightEntities())
                {
                    var solicitud = db.Detalle_factura_servicio.Where(
                    e => e.idFacturaServ == idFacturaServ
                    && e.idServicio == idServicio
                    && e.idLab == idLab).ToList();

                    if (solicitud.Count > 0)
                    {
                        solicitud.First().idEstado = 3;
                        solicitud.First().fechaEntregado = DateTime.Today;
                        solicitud.First().idEmpleado = idEmpleado;
                        //solicitud.First().fechaFinalizacion = dsadasds;
                        db.SaveChanges();
                    }
                }
            }
                
        }

        public bool formatoIdSolicitud(string idSolicitud) {
            int numGuiones = 0;
            int i = 0;
            bool val1 = false;
            bool val2 = false;

            for(i=0;i<idSolicitud.Length;i++)
            {
                if (idSolicitud[i].ToString().Equals("-"))
                {
                    numGuiones++;
                    bool val = false;

                    val = Char.IsDigit(idSolicitud[i+1]);         

                    if (val && numGuiones == 1){
                        val1 = true;
                    }else if(val && numGuiones == 2)
                    {
                        val2 = true;
                    }
                }   
            }
            

            if (val1 & val2 && numGuiones == 2) {

                return true;
            
            } else { return false; }
        }

        public void filtrarIdBaja(BunifuDataGridView datagrid, string idSolicitud, Button boton, int param)
        {

            int idFacturaServ = Int32.Parse(filtrarIdSolicitud(idSolicitud)[0]);
            int idServicio = Int32.Parse(filtrarIdSolicitud(idSolicitud)[1]);

            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                List<Detalle_factura_servicio> solicitudes = new List<Detalle_factura_servicio>();
                solicitudes = db.Detalle_factura_servicio.Where(e => 
                e.idLab == MyGlobals.empleado.idLab 
                && e.idEstado == param
                && e.idServicio == idServicio 
                && e.idFacturaServ == idFacturaServ).ToList();

                if (solicitudes.Count > 0)
                {
                    foreach (Detalle_factura_servicio solicitud in solicitudes)
                    {
                        
                        int fila = datagrid.Rows.Add();
                        datagrid.Rows[fila].DefaultCellStyle.BackColor = Color.White;

                        string activo = "";
                        DataGridViewButtonCell botonAltaBaja = new DataGridViewButtonCell();

                        if (solicitud.activo == true)
                        {
                            datagrid.Rows[fila].Cells["columnActivo"].Value = "Si";
                            datagrid.Rows[fila].DefaultCellStyle.BackColor = Color.White;
                            //datagrid.Rows[fila].Cells["columnAltaBaja"].Value = "Baja";
                            botonAltaBaja.Value = "Baja";
                            botonAltaBaja.Style.BackColor = Color.Coral;

                        }
                        else
                        {
                            datagrid.Rows[fila].Cells["columnActivo"].Value = "No";
                            datagrid.Rows[fila].DefaultCellStyle.BackColor = Color.Gray;
                            //datagrid.Rows[fila].Cells["columnAltaBaja"].Value = "Alta";
                            botonAltaBaja.Value = "Alta";
                            botonAltaBaja.Style.BackColor = Color.Aquamarine;
                        }

                        datagrid.Rows[fila].Cells["columnAltaBaja"] = botonAltaBaja;
                        datagrid.Rows[fila].Cells["columnIdSolicitud"].Value = solicitud.idFacturaServ + "-" + solicitud.idServicio + "-" + solicitud.idLab;
                        datagrid.Rows[fila].Cells["columnNombreServicio"].Value = solicitud.Servicio_laboratorio.Servicio.nombre;
                        datagrid.Rows[fila].Cells["columnCantidad"].Value = solicitud.cantidad;
                        datagrid.Rows[fila].Cells["columnDniCliente"].Value = solicitud.Factura_servicio.Persona.dni;
                        datagrid.Rows[fila].Cells["columnNombreCliente"].Value = solicitud.Factura_servicio.Persona.nombre + " " + solicitud.Factura_servicio.Persona.apellido;
                        datagrid.Rows[fila].Cells["columnActivo"].Value = activo;

                    }
                }
                else
                {
                    MessageBox.Show("No se ha encontrado la solicitud", "Solicitud no encontrada", MessageBoxButtons.OK);
                }
                boton.Enabled = true; //habilita el botón "Mostrar todos"
            }
        }

        public void filtrarId(BunifuDataGridView datagrid, string idSolicitud, Button boton, int param)
        {

            int idFacturaServ = Int32.Parse(filtrarIdSolicitud(idSolicitud)[0]);
            int idServicio = Int32.Parse(filtrarIdSolicitud(idSolicitud)[1]);

            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                List<Detalle_factura_servicio> solicitudes = new List<Detalle_factura_servicio>();
                solicitudes = db.Detalle_factura_servicio.Where(e =>
                e.idLab == MyGlobals.empleado.idLab
                && e.idEstado == param
                && e.idServicio == idServicio
                && e.idFacturaServ == idFacturaServ).ToList();

                if (solicitudes.Count > 0)
                {
                    foreach (Detalle_factura_servicio solicitud in solicitudes)
                    {
                        int fila = datagrid.Rows.Add();
                        datagrid.Rows[fila].DefaultCellStyle.BackColor = Color.White;

                        datagrid.Rows[fila].Cells["columnIdSolicitud"].Value = solicitud.idFacturaServ + "-" + solicitud.idServicio + "-" + solicitud.idLab;
                        datagrid.Rows[fila].Cells["columnNombreServicio"].Value = solicitud.Servicio_laboratorio.Servicio.nombre;
                        datagrid.Rows[fila].Cells["columnCantidad"].Value = solicitud.cantidad;
                        datagrid.Rows[fila].Cells["columnDniCliente"].Value = solicitud.Factura_servicio.Persona.dni;
                        datagrid.Rows[fila].Cells["columnNombreCliente"].Value = solicitud.Factura_servicio.Persona.nombre + " " + solicitud.Factura_servicio.Persona.apellido;
                        datagrid.Rows[fila].Cells["columnMailCliente"].Value = solicitud.Factura_servicio.Persona.email;
                        datagrid.Rows[fila].Cells["columnTelefono"].Value = solicitud.Factura_servicio.Persona.telefono;
                        if (param == 3)
                        {
                            datagrid.Rows[fila].Cells["columnAccion"].Value = "Revertir";
                        }
                        else
                        {
                            datagrid.Rows[fila].Cells["columnAccion"].Value = "Promover";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se ha encontrado la solicitud", "Solicitud no encontrada", MessageBoxButtons.OK);
                }
                boton.Enabled = true; //habilita el botón "Mostrar todos"
            }
        }

        public void filtrarDni(BunifuDataGridView datagrid, int dni, Button boton, int param)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                List<Detalle_factura_servicio> solicitudes = new List<Detalle_factura_servicio>();
                //solicitudes = db.Detalle_factura_servicio.ToList();
                solicitudes = db.Detalle_factura_servicio.Where(e => e.idLab == MyGlobals.empleado.idLab 
                && e.Factura_servicio.Persona.dni == dni 
                && e.idEstado == param).ToList();

                if (solicitudes.Count > 0)
                {
                    foreach (Detalle_factura_servicio solicitud in solicitudes)
                    {
                        int fila = datagrid.Rows.Add();
                        datagrid.Rows[fila].DefaultCellStyle.BackColor = Color.White;
                        datagrid.Rows[fila].Cells["columnIdSolicitud"].Value = solicitud.idFacturaServ + "-" + solicitud.idServicio + "-" + solicitud.idLab;
                        datagrid.Rows[fila].Cells["columnNombreServicio"].Value = solicitud.Servicio_laboratorio.Servicio.nombre;
                        datagrid.Rows[fila].Cells["columnCantidad"].Value = solicitud.cantidad;
                        datagrid.Rows[fila].Cells["columnDniCliente"].Value = solicitud.Factura_servicio.Persona.dni;
                        datagrid.Rows[fila].Cells["columnNombreCliente"].Value = solicitud.Factura_servicio.Persona.nombre + " " + solicitud.Factura_servicio.Persona.apellido;
                        datagrid.Rows[fila].Cells["columnMailCliente"].Value = solicitud.Factura_servicio.Persona.email;
                        datagrid.Rows[fila].Cells["columnTelefono"].Value = solicitud.Factura_servicio.Persona.telefono;
                        if(param == 3)
                        {
                            datagrid.Rows[fila].Cells["columnAccion"].Value = "Revertir";
                        }
                        else
                        {
                            datagrid.Rows[fila].Cells["columnAccion"].Value = "Promover";
                        }

                    }
                }
                else {
                    MessageBox.Show("No se ha encontrado la solicitud", "Solicitud no encontrada", MessageBoxButtons.OK); }
            }
            boton.Enabled = true; //habilita el botón "Mostrar todas"
        }

        public void filtrarServicio(BunifuDataGridView datagrid, string nombreServicio, Button boton, int param)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                List<Detalle_factura_servicio> solicitudes = new List<Detalle_factura_servicio>();
                //solicitudes = db.Detalle_factura_servicio.ToList();
                solicitudes = db.Detalle_factura_servicio.Where(e => e.idLab == MyGlobals.empleado.idLab 
                && e.Servicio_laboratorio.Servicio.nombre == nombreServicio.Trim()
                && e.idEstado == param).ToList();

                if (solicitudes.Count > 0)
                {
                    foreach (Detalle_factura_servicio solicitud in solicitudes)
                    {
                        int fila = datagrid.Rows.Add();
                        datagrid.Rows[fila].DefaultCellStyle.BackColor = Color.White;

                        datagrid.Rows[fila].Cells["columnIdSolicitud"].Value = solicitud.idFacturaServ + "-" + solicitud.idServicio + "-" + solicitud.idLab;
                        datagrid.Rows[fila].Cells["columnNombreServicio"].Value = solicitud.Servicio_laboratorio.Servicio.nombre;
                        datagrid.Rows[fila].Cells["columnCantidad"].Value = solicitud.cantidad;
                        datagrid.Rows[fila].Cells["columnDniCliente"].Value = solicitud.Factura_servicio.Persona.dni;
                        datagrid.Rows[fila].Cells["columnNombreCliente"].Value = solicitud.Factura_servicio.Persona.nombre + " " + solicitud.Factura_servicio.Persona.apellido;
                        datagrid.Rows[fila].Cells["columnMailCliente"].Value = solicitud.Factura_servicio.Persona.email;
                        datagrid.Rows[fila].Cells["columnTelefono"].Value = solicitud.Factura_servicio.Persona.telefono;
                        if (param == 3)
                        {
                            datagrid.Rows[fila].Cells["columnAccion"].Value = "Revertir";
                        }
                        else
                        {
                            datagrid.Rows[fila].Cells["columnAccion"].Value = "Promover";
                        }

                    }
                }
                else
                {
                    MessageBox.Show("No se ha encontraron solicitudes para esa categoría", "Solicitudes no encontradas", MessageBoxButtons.OK);
                }
                boton.Enabled = true; //habilita el botón "Mostrar todas"
            }
        }

        public void revertirPendiente(string idSolicitud) {
            if (MessageBox.Show("¿Está seguro que desea revertir el estado de la solicitud a PENDIENTE?", "Revertir estado de solicitud", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int idFacturaServ = Int32.Parse(filtrarIdSolicitud(idSolicitud)[0]);
                int idServicio = Int32.Parse(filtrarIdSolicitud(idSolicitud)[1]);
                int idLab = Int32.Parse(filtrarIdSolicitud(idSolicitud)[2]);

                using (bd_blulightEntities db = new bd_blulightEntities())
                {
                    var solicitud = db.Detalle_factura_servicio.Where(
                    e => e.idFacturaServ == idFacturaServ
                    && e.idServicio == idServicio
                    && e.idLab == idLab).ToList();

                    if (solicitud.Count > 0)
                    {
                        solicitud.First().idEstado = 1;
                        solicitud.First().fechaFinalizacion = DateTime.Today;
                        solicitud.First().idEmpleado = null;
                        solicitud.First().fechaFinalizacion = null;
                        solicitud.First().fechaEntregado = null;
                        db.SaveChanges();
                        MessageBox.Show("El estado de solicitud se ha revertido a PENDIENTE", "Estado de solicitud revertido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        public void revertirFinalizado(string idSolicitud, int idEmpleado)
        {
            if (MessageBox.Show("¿Está seguro que desea revertir el estado de la solicitud a FINALIZADO?", "Revertir estado de solicitud", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int idFacturaServ = Int32.Parse(filtrarIdSolicitud(idSolicitud)[0]);
                int idServicio = Int32.Parse(filtrarIdSolicitud(idSolicitud)[1]);
                int idLab = Int32.Parse(filtrarIdSolicitud(idSolicitud)[2]);

                using (bd_blulightEntities db = new bd_blulightEntities())
                {
                    var solicitud = db.Detalle_factura_servicio.Where(
                    e => e.idFacturaServ == idFacturaServ
                    && e.idServicio == idServicio
                    && e.idLab == idLab).ToList();

                    if (solicitud.Count > 0)
                    {
                        solicitud.First().idEstado = 2;
                        solicitud.First().fechaFinalizacion = DateTime.Today;
                        solicitud.First().idEmpleado = idEmpleado;
                        solicitud.First().fechaEntregado = null;
                        db.SaveChanges();
                        MessageBox.Show("El estado de solicitud se ha revertido a FINALIZADO", "Estado de solicitud revertido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        public void altaBaja(BunifuDataGridView datagrid, int idFactura, int idServicio)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                var solicitud = db.Detalle_factura_servicio.Where(
                e => e.idFacturaServ == idFactura
                && e.idServicio == idServicio
                && e.idLab == MyGlobals.empleado.idLab).ToList();

                if (solicitud.Count > 0)
                {
                    if (solicitud.First().activo == true)
                    {
                        solicitud.First().activo = false;
                        db.SaveChanges();
                        MessageBox.Show("La solicitud ha sido dada de BAJA.", "Baja de solicitud", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        solicitud.First().activo = true;
                        db.SaveChanges();
                        MessageBox.Show("La solicitud se ha vuelto a dar de ALTA.", "Alta de solicitud", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }


                }
            }
        }

    }//fin clase
}
