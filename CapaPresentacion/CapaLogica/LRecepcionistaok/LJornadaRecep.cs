using Bunifu.UI.WinForms;
using CapaLogica;
using CapaPresentacion.CapaData.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.CapaLogica.LRecepcionistaok
{
    internal class LJornadaRecep
    {
        public void rellenarDataGridJornadas(BunifuDataGridView dataGrid)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                List<Jornada> jornadas = new List<Jornada>();

                jornadas = db.Jornada.ToList();

                if (jornadas.Count > 0)
                {
                    foreach (Jornada jornada in jornadas)
                    {
                        if (jornada.activo)
                        {

                            int fila = dataGrid.Rows.Add();
                            dataGrid.Rows[fila].DefaultCellStyle.BackColor = Color.White;



                            dataGrid.Rows[fila].Cells["ColumnId"].Value = jornada.idJornada;
                            dataGrid.Rows[fila].Cells["ColumnNombre"].Value = jornada.nombre;
                            dataGrid.Rows[fila].Cells["ColumnCupo"].Value = jornada.inscriptos.ToString() + "/" + jornada.cupo.ToString();
                            dataGrid.Rows[fila].Cells["ColumnFecha"].Value = jornada.fecha.ToShortDateString();
                            dataGrid.Rows[fila].Cells["ColumnHora"].Value = string.Format("{0:00}:{1:00}", jornada.hora.Hours, jornada.hora.Minutes);
                            dataGrid.Rows[fila].Cells["ColumnJefeLab"].Value = jornada.Empleado.Persona.nombre + " " + jornada.Empleado.Persona.apellido;
                            dataGrid.Rows[fila].Cells["ColumnAuditorio"].Value = jornada.Salon_auditorio.nombre;
                        }

                    }
                }
            }
        }

        public void buscarJornadaDatagrid(Label labelJornada, BunifuDataGridView datagridJornadas) {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                string nombreJornada = datagridJornadas.CurrentRow.Cells[1].Value.ToString();
                //var jornada = db.Jornada.Where(j => j.nombre.Equals(nombreJornada)).FirstOrDefault();

                labelJornada.Text = nombreJornada;
                labelJornada.Visible = true;
            }
        }

        public void inscribirAJornada(Label labelDni, Label labelJornada) {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                Jornada jornada = db.Jornada.Where(j => j.nombre.Equals(labelJornada.Text)).FirstOrDefault();
                int dniPersona = Int32.Parse(labelDni.Text);
                Persona persona = db.Persona.Where(p => p.dni.Equals(dniPersona)).FirstOrDefault();

                if (jornada != null && persona != null && jornada.inscriptos < jornada.cupo)
                {
                    jornada.inscriptos += 1;
                    db.SaveChanges();
                    Inscripto_jornada inscripcion = new Inscripto_jornada();
                    inscripcion.idJornada = jornada.idJornada;
                    inscripcion.idPersona = persona.idPersona;
                    inscripcion.fechaInscripcion = DateTime.Now.Date;
                    inscripcion.horaInscripcion = DateTime.Now.TimeOfDay;
                    inscripcion.activo = true;
                    db.Inscripto_jornada.Add(inscripcion);
                    db.SaveChanges();
                    MessageBox.Show("¡Inscripción a jornada realizada con éxito!", "Inscribir a jornada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("No es posible inscribir a la jornada. ¡Cupo lleno!", "Inscribir a jornada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        public void buscarJornadaNombre(TextBox textBoxNombre, Label labelJornada) {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                if (textBoxNombre.Text == "")
                {
                    MessageBox.Show("Ingrese el nombre de la jornada.", "Baja a jornada", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else { 
                    var jornada = db.Jornada.Where(j => j.nombre.Contains(textBoxNombre.Text)).FirstOrDefault();

                    if (jornada != null)
                    {
                        labelJornada.Text = jornada.nombre;
                        labelJornada.Visible = true;
                    }
                    else {
                        MessageBox.Show("Jornada no encontrada.", "Baja a jornada", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
            }
        }

        public void bajaJornada(Label LabelDni, Label labelNombreJornada) {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                int dni = Int32.Parse(LabelDni.Text);
                var persona = db.Persona.Where(p => p.dni == dni).FirstOrDefault();
                var jornada = db.Jornada.Where(j => j.nombre.Equals(labelNombreJornada.Text)).FirstOrDefault();
                var inscripcion = db.Inscripto_jornada.Where(ins => ins.idPersona == persona.idPersona
                    && ins.idJornada == jornada.idJornada).FirstOrDefault();

                if (persona != null && jornada != null && inscripcion != null)
                {
                    jornada.inscriptos -= 1;
                    inscripcion.activo = false;
                    db.SaveChanges();
                    
                }
                else {
                    MessageBox.Show("Error al dar de baja. La persona seleccionada no se " +
                        "encuentra inscripta a la jornada seleccionada.",
                        "Error al dar debaja", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }//fin clase
}
