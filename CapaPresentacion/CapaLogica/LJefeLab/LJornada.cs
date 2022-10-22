using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica.Libreria;
using CapaPresentacion.CapaData.Model;
using System.Drawing;
using CapaLogica;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion.CapaLogica.LJefeLab
{
    internal class LJornada : Librerias
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
                        if (jornada.activo && jornada.idJefeLab == MyGlobals.empleado.idEmpleado)
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


        public void rellenarDataGridJornadasInactivas(BunifuDataGridView dataGrid)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                List<Jornada> jornadas = new List<Jornada>();

                jornadas = db.Jornada.ToList();

                if (jornadas.Count > 0)
                {
                    foreach (Jornada jornada in jornadas)
                    {
                        if (!jornada.activo && jornada.idJefeLab == MyGlobals.empleado.idEmpleado)
                        {
                            
                            int fila = dataGrid.Rows.Add();
                            dataGrid.Rows[fila].DefaultCellStyle.BackColor = Color.Gray;


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


        public void rellenarComboBoxAuditorios(ComboBox comboBox)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                foreach (var item in db.Salon_auditorio)
                {
                    comboBox.Items.Add(item.idAuditorio + " - " + item.nombre);
                }
            }

        }

        public void agregarJornada(List<TextBox> textBoxes, List<DateTimePicker> fechaHora, ComboBox comboBox)
        {
            bool validacionTextBox = true;
            bool validacionFecha = this.validarFecha(fechaHora[0].Value);
            bool validacionComboBox = true;

            if (comboBox.SelectedIndex == -1) { validacionComboBox = false; }

            foreach (TextBox textBox in textBoxes)
            {
                if (textBox.Text.Equals(""))
                {
                    validacionTextBox = false;
                }
            }

            if (validacionTextBox && validacionFecha && validacionComboBox)
            {
                using (bd_blulightEntities db = new bd_blulightEntities())
                {

                    Jornada jornada = new Jornada();
                    jornada.nombre = textBoxes[0].Text.ToString();
                    jornada.cupo = Int32.Parse(textBoxes[1].Text);
                    jornada.fecha = fechaHora[0].Value;
                    jornada.hora = fechaHora[1].Value.TimeOfDay;
                    jornada.idJefeLab = MyGlobals.empleado.idEmpleado;
                    jornada.idAuditorio = comboBox.SelectedIndex + 1;
                    jornada.activo = true;
                    jornada.inscriptos = 0;

                    db.Jornada.Add(jornada);
                    db.SaveChanges();



                    MessageBox.Show("Jornada " + textBoxes[0].Text + " " + " agregada!", "Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    for (int i = 0; i < textBoxes.Count; i++)
                    {
                        textBoxes[i].Text = "";
                    }
                    comboBox.SelectedIndex = -1;

                }
            }
            else
            {
                if (!validacionTextBox) MessageBox.Show("Ingrese todos los campos de texto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (!validacionFecha) MessageBox.Show("La fecha ingresada es anterior a la fecha actual!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (!validacionComboBox) MessageBox.Show("Debe seleccionar un auditorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void eliminarJornada(int pIdJornada, List<TextBox> listTextBoxes, List<DateTimePicker> listDateTime, ComboBox comboBoxAuditorios)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                if (MessageBox.Show("Estas seguro de que desea eliminar la jornada?", "Eliminar jornada", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {

                    if (db.Jornada.Where(e => e.idJornada.Equals(pIdJornada)).ToList().Count > 0)
                    {
                        var activo = db.Jornada.SingleOrDefault(e => e.idJornada.Equals(pIdJornada));

                        activo.activo = false;
                        MessageBox.Show("Jornada eliminada", "Eliminar Jornada", MessageBoxButtons.OK);

                        db.SaveChanges();

                        foreach (TextBox tbox in listTextBoxes)
                        {
                            tbox.Text = "";
                        }


                        listDateTime[0].Value = DateTime.Now;
                        listDateTime[1].Value = DateTime.Now;



                        comboBoxAuditorios.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show("La Jornada ingresada no existe", "Error", MessageBoxButtons.OK);
                    }
                }
            }
        }

        public void modificarJornada(int pIdJornada, List<System.Windows.Forms.TextBox> listTextBoxes, List<DateTimePicker> listDateTime, System.Windows.Forms.ComboBox comboBoxAuditorios)
        {
            bool validacionTextBoxes = true;
            bool validacionFecha = this.validarFecha(listDateTime[0].Value);
            bool validacionComboBox = true;
           

            if (comboBoxAuditorios.SelectedIndex == -1) { validacionComboBox = false; }

            for (int i = 0; i < listTextBoxes.Count; i++)
            {
                if (listTextBoxes[i].Text.Equals(""))
                {
                    validacionTextBoxes = false;
                }
            }


            if (validacionTextBoxes && validacionFecha && validacionComboBox)
            {

                using (bd_blulightEntities db = new bd_blulightEntities())
                {
                    if (Int32.Parse(listTextBoxes[1].Text) >= db.Jornada.SingleOrDefault(c => c.idJornada.Equals(pIdJornada)).inscriptos) { 
                        if (MessageBox.Show("Estas seguro de que desea Modificar la jornada?", "Modificar jornada", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            if (db.Jornada.Where(c => c.idJornada.Equals(pIdJornada)).ToList().Count > 0)
                            {
                                var jornada = db.Jornada.SingleOrDefault(c => c.idJornada.Equals(pIdJornada));
                                jornada.nombre = listTextBoxes[0].Text;
                                jornada.cupo = Int32.Parse(listTextBoxes[1].Text);
                                jornada.fecha = listDateTime[0].Value;
                                jornada.hora = listDateTime[1].Value.TimeOfDay;
                                jornada.idAuditorio = comboBoxAuditorios.SelectedIndex + 1;

                                db.SaveChanges();
                                MessageBox.Show("Jornada modificada", "Modificar jornada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("La jornada no existe", "Error", MessageBoxButtons.OK);
                            }
                        }
                    }
                    else { 
                        var diferencia = db.Jornada.SingleOrDefault(c => c.idJornada.Equals(pIdJornada)).inscriptos - Int32.Parse(listTextBoxes[1].Text);
                        string mensaje = "La cantidad de inscriptos a la jornada excede el cupo ingresado. Para disminuir el cupo deberá dar de baja a " + diferencia + " inscriptos.";
                        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
            else
            {
                if (!validacionTextBoxes) { MessageBox.Show("Ingrese todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                if (!validacionFecha) { MessageBox.Show("La fecha ingresada es anterior a la fecha actual. Imposible viajar al pasado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }




        //Al clickear en una fila del DataGrid, este método rellena los campos de textBoxes y demás elementos con los
        // datos de tal fila del DataGrid
        public void obtenerJornada(List<System.Windows.Forms.TextBox> textBoxes, System.Windows.Forms.ComboBox comboBox, DataGridView dataGridView, Label labelIdJornada, List<Button> botones)
        {
            textBoxes[0].Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            //textBoxes[1].Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            //

            using (bd_blulightEntities bd = new bd_blulightEntities())
            {
                List<Salon_auditorio> auditorios = new List<Salon_auditorio>();
                auditorios = bd.Salon_auditorio.ToList();
                int idAuditorio = 0;

                //obtiene el idAuditorio 
                foreach (Salon_auditorio auditorio in auditorios)
                {
                    if (auditorio.nombre.Equals(dataGridView.CurrentRow.Cells[6].Value.ToString()))
                    {
                        idAuditorio = auditorio.idAuditorio;
                    }
                }
                
                comboBox.SelectedIndex = idAuditorio - 1;
                string idJornada = dataGridView.CurrentRow.Cells[0].Value.ToString();
                int idJornadaInt = Int32.Parse(idJornada);
                var jornada = bd.Jornada.SingleOrDefault(c => c.idJornada.Equals(idJornadaInt));
                textBoxes[1].Text = jornada.cupo.ToString();
                labelIdJornada.Text = idJornada;

                //btnActivarJornada
                if (jornada.activo)
                {
                    botones[3].Enabled = false; //boton ActivarJornada se desactiva
                    botones[2].Enabled = true; //boton EliminarJornada se activa
                }
                else
                {
                    botones[3].Enabled = true; //boton ActivarJornada se activa
                    botones[2].Enabled = false; //boton EliminarJornada se desactiva
                }

                botones[1].Enabled = true; //boton ModificarJornada se activa
                
            }
        }

        public void activarJornada(int idJornadaSeleccionada)
        {
            using (bd_blulightEntities bd = new bd_blulightEntities()) { 
                var jornada = bd.Jornada.SingleOrDefault(c => c.idJornada.Equals(idJornadaSeleccionada));

                if (!jornada.activo)
                {
                    if (MessageBox.Show("Está seguro de que desea activar la jornada?", "Activar jornada", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        jornada.activo = true;
                        bd.SaveChanges();
                        MessageBox.Show("La jornada ha vuelto a activarse.", "Realizado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

    } //fin clase
} //fin namespace
