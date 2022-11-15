using Bunifu.UI.WinForms;
using CapaLogica.Libreria;
using CapaPresentacion.CapaData.Model;
using LinqToDB;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaLogica.Libreria
{
    public class LServicio : Librerias
    {
        public void rellenarDataGridServicioDelLab(BunifuDataGridView dataGrid) {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                List<Servicio_laboratorio> servicios = new List<Servicio_laboratorio>();

                servicios = db.Servicio_laboratorio.ToList();

               /* if (Servicio_laboratorio.Count > 0)
                {*/
                    foreach (Servicio_laboratorio servicio in servicios)
                    {
                        if (servicio.idLab == MyGlobals.empleado.idLab) { 
                            var activo = "";
                            int fila = dataGrid.Rows.Add();
                            if (servicio.activo)
                            {
                                activo = "Si";
                                dataGrid.Rows[fila].DefaultCellStyle.BackColor = Color.White;
                            }
                            else
                            {
                                activo = "No";
                                dataGrid.Rows[fila].DefaultCellStyle.BackColor = Color.Gray;
                            }

                            dataGrid.Rows[fila].Cells["ColumnId"].Value = servicio.idServicio;
                            dataGrid.Rows[fila].Cells["ColumnNombre"].Value = servicio.Servicio.nombre;
                            dataGrid.Rows[fila].Cells["ColumnPrecio"].Value = servicio.Servicio.precio;
                            dataGrid.Rows[fila].Cells["ColumnCategoria"].Value = servicio.Servicio.Categoria_servicio.categoria;
                            dataGrid.Rows[fila].Cells["ColumnActivo"].Value = activo;

                         
                            DataGridViewButtonCell boton = new DataGridViewButtonCell();
                            

                            if (servicio.activo)
                            {
                                boton.Value = "Baja";
                                boton.Style.BackColor = Color.Coral;
                            }
                            else
                            {
                                boton.Value = "Alta";
                                boton.Style.BackColor = Color.Aquamarine;
                             }
                            
                            
                            boton.FlatStyle = FlatStyle.Flat;
                            //boton.UseColumnTextForButtonValue = true;
                            dataGrid.Rows[fila].Cells["ColumnAccion"] = boton;

                    }
                    }
               // }
            }
        }

        public void rellenarComboBoxServicios(ComboBox comboBox) {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                foreach (var item in db.Servicio)
                {
                    comboBox.Items.Add(item.idServicio + " - " + item.nombre);
                }
            }
        }

        public void rellenarComboBoxServiciosFiltro(ComboBox comboBox, int idCategoria)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                comboBox.Items.Clear();
                foreach (var item in db.Servicio)
                {
                    if (item.idCategoriaServ == idCategoria) {
                        comboBox.Items.Add(item.idServicio + " - " + item.nombre);
                    }
                }

            }
        }

        public void rellenarComboBoxCategoria(ComboBox comboBox)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                comboBox.Items.Add("0 - Mostrar todos");
                foreach (var item in db.Categoria_servicio)
                {
                    comboBox.Items.Add(item.idCategoriaServ + " - " + item.categoria);
                }
            }
        }


        public int ServicioLabExiste(int p_idServicio, int p_idLab)
        {

            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                if (db.Servicio_laboratorio.Where(d => d.idServicio.Equals(p_idServicio) && d.activo && d.idLab.Equals(p_idLab)).ToList().Count > 0)
                {
                    return 1; //existe y está activo
                }
                else if (db.Servicio_laboratorio.Where(d => d.idServicio.Equals(p_idServicio) && !d.activo && d.idLab.Equals(p_idLab)).ToList().Count > 0)
                {
                    return 2; //existe y está inactivo
                }
                else
                {
                    return 3; //no existe
                }
            }
        }

        public void agregarServicioLaboratorio(int p_idServicio1, int p_idLab1)
            {
                if (ServicioLabExiste(p_idServicio1, p_idLab1) == 3)
                {
                    using (bd_blulightEntities db = new bd_blulightEntities())
                    {
                        Servicio_laboratorio servlab = new Servicio_laboratorio();
                        servlab.idLab = p_idLab1;
                        servlab.idServicio = p_idServicio1;
                        servlab.activo = true;

                        db.Servicio_laboratorio.Add(servlab);
                        db.SaveChanges();

                        MessageBox.Show("Servicio agregado con exito", "Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (ServicioLabExiste(p_idServicio1, p_idLab1) == 2)
                {
                // cambiar a servicio ACTIVO
                    using (bd_blulightEntities db = new bd_blulightEntities())
                    {
                        var registro = db.Servicio_laboratorio.Where(e => e.idServicio.Equals(p_idServicio1)).Where(e => e.idLab.Equals(p_idLab1)).FirstOrDefault();
                        registro.activo = true;
                        db.SaveChanges();

                }
                    MessageBox.Show("El servicio inactivo se ha vuelto a activar", "Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else { MessageBox.Show("El servicio ya existe", "Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }

        public void eliminarServicio(int idServicio)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                var servicio = db.Servicio_laboratorio.Where(
                    e => e.idServicio == idServicio
                    && e.idLab == MyGlobals.empleado.idLab).ToList();

                if(servicio.Count > 0)
                {
                    MessageBox.Show(idServicio + "", "BIEN");
                    if (servicio.First().activo == true)
                    {
                        servicio.First().activo = false;
                        db.SaveChanges();
                    }
                    else
                    {
                        servicio.First().activo = true;
                        db.SaveChanges();
                    }
                    
                }
            }
        }

    }
}
