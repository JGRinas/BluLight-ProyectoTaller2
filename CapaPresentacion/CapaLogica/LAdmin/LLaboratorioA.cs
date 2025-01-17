﻿using CapaLogica.Libreria;
using CapaPresentacion.CapaData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.CapaLogica.LAdmin
{
    public class LLaboratorioA : Librerias
    {
        public void rellenarDataGridLab(DataGridView dataGrid)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                List<Laboratorio> laboratorios = new List<Laboratorio>();

                laboratorios = db.Laboratorio.ToList();

                if (laboratorios.Count > 0)
                {
                    foreach (Laboratorio laboratorio in laboratorios)
                    {
                        int fila = dataGrid.Rows.Add();

                        dataGrid.Rows[fila].Cells["ColumnId"].Value = laboratorio.idLab;
                        dataGrid.Rows[fila].Cells["ColumnNombre"].Value = laboratorio.nombre;

                    }
                }

            }
        }

        public void registrarLaboratorio(TextBox textBox)
        {
            bool validate = true;
            if (textBox.Text.Equals("")) validate = false;

            if (validate)
            {
                using (bd_blulightEntities db = new bd_blulightEntities())
                {

                    var nombreLab = textBox.Text.ToString();
                    var laboratorios = from p in db.Laboratorio where p.nombre == nombreLab select p;
                    if (laboratorios.ToArray().Length > 0)
                    {
                        MessageBox.Show("Laboratorio ya registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        Laboratorio nuevoLab = new Laboratorio();
                        nuevoLab.nombre = nombreLab;
                        db.Laboratorio.Add(nuevoLab);
                        db.SaveChanges();

                        MessageBox.Show("Laboratorio registrado con éxito", "Registrar laboratorio", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        textBox.Text = "";
                    }
                }
                    
            }
            else
            {
                MessageBox.Show("Ingrese el nombre del laboratorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private int idLabo;
        private string nombreLab;
        public void obtenerLaboratorio(TextBox textBox, DataGridView dataGrid)
        {
            textBox.Text = (dataGrid.CurrentRow.Cells[1].Value.ToString());
            idLabo = Int32.Parse(dataGrid.CurrentRow.Cells[0].Value.ToString());
            nombreLab = textBox.Text;

        }
        public void modificarLaboratorio(TextBox textBox)
        {
            bool validate = true;
            if (textBox.Text.Equals("")) validate = false;

            if (validate)
            {
                using (bd_blulightEntities db = new bd_blulightEntities())
                {

                    var lab = textBox.Text.ToString();
                    var laboratorios = from p in db.Laboratorio where p.nombre == lab select p;
                    if (nombreLab.Equals(lab) || laboratorios.ToArray().Length <= 0)
                    {
                        var laboratorio = db.Laboratorio.SingleOrDefault(e => e.idLab.Equals(idLabo));
                        laboratorio.nombre = lab;
                        db.SaveChanges();

                        MessageBox.Show("Laboratorio modificado con éxito", "Modificar laboratorio", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        textBox.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Laboratorio ya registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }

            else
            {
                MessageBox.Show("Ingrese el nombre del laboratorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
