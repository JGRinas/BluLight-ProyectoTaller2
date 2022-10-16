﻿using Bunifu.UI.WinForms;
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
                        if (jornada.activo)
                        {
                            var activo = "-";
                            int fila = dataGrid.Rows.Add();



                            dataGrid.Rows[fila].Cells["ColumnId"].Value = jornada.idJornada;
                            dataGrid.Rows[fila].Cells["ColumnNombre"].Value = jornada.nombre;
                            dataGrid.Rows[fila].Cells["ColumnCupo"].Value = jornada.inscriptos.ToString() + "/" + jornada.cupo.ToString();
                            dataGrid.Rows[fila].Cells["ColumnFecha"].Value = jornada.fecha;
                            dataGrid.Rows[fila].Cells["ColumnHora"].Value = jornada.hora;
                            dataGrid.Rows[fila].Cells["ColumnJefeLab"].Value = jornada.Jefe_laboratorio.Empleado.Persona.nombre + " " + jornada.Jefe_laboratorio.Empleado.Persona.apellido;
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

                        

                        MessageBox.Show("Jornada " + textBoxes[0].Text + " " + textBoxes[1].Text + " agregada!", "Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        public void eliminarJornada()
        {

        }

        public void modificarJornada()
        {

        }


        //Al clickear en una fila del DataGrid, este método rellena los campos de textBoxes y demás elementos con los
        // datos de tal fila del DataGrid
        public void obtenerJornada(List<TextBox> textBoxes, ComboBox comboBox, DataGridView dataGridView)
        {
            textBoxes[0].Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            textBoxes[1].Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            //

            using (bd_blulightEntities bd = new bd_blulightEntities())
            {
                List<Salon_auditorio> auditorios = new List<Salon_auditorio>();
                auditorios = bd.Salon_auditorio.ToList();

                int idAuditorio = 0;

                foreach (Salon_auditorio auditorio in auditorios)
                {
                    if (auditorio.nombre.Equals(dataGridView.CurrentRow.Cells[6].Value.ToString()))
                    {
                        idAuditorio = auditorio.idAuditorio;
                    }
                }
                comboBox.SelectedIndex = idAuditorio - 1;
            }

        }
    }
}
