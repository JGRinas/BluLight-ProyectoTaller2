using CapaLogica.Libreria;
using CapaPresentacion.CapaData.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.CapaLogica.LAdmin
{
    internal class LServicioA : Librerias
    {
        public void rellenarComboBoxCategorias(ComboBox comboBox)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                foreach (var item in db.Categoria_servicio)
                {
                    comboBox.Items.Add(item.idCategoriaServ + " - " + item.categoria);
                }
            }
        }

        public void rellenarDataGridServicio(DataGridView dataGrid)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                List<Servicio> Servicios = new List<Servicio>();

                Servicios = db.Servicio.ToList();

                if (Servicios.Count > 0)
                {

                    foreach (Servicio servicio in Servicios)
                    {
                        int fila = dataGrid.Rows.Add();
                        var estado = "Si";
                        if (!servicio.activo)
                        {
                            dataGrid.Rows[fila].DefaultCellStyle.BackColor = Color.Gray;
                            estado = "No";
                        }

                        dataGrid.Rows[fila].Cells["ColumnId"].Value = servicio.idServicio;
                        dataGrid.Rows[fila].Cells["ColumnNombre"].Value = servicio.nombre;
                        dataGrid.Rows[fila].Cells["ColumnCategoria"].Value = servicio.Categoria_servicio.categoria;
                        dataGrid.Rows[fila].Cells["ColumnPrecio"].Value = servicio.precio;
                        dataGrid.Rows[fila].Cells["ColumnActivo"].Value = estado;
                    }

                }
            }
        }

        public void registrarServicio(List<TextBox> textBoxes, ComboBox comboBox)
        {
            bool validation = true;

            foreach (TextBox textBox in textBoxes)
            {
                if (textBox.Text.Equals(""))
                {
                    validation = false;
                }
            }

            if (comboBox.SelectedIndex == -1)
            {
                validation = false;
            }

            if (validation)
            {
                using (bd_blulightEntities db = new bd_blulightEntities())
                {
                    var nombre = textBoxes[0].Text.ToString();
                    var valNombre = db.Servicio.Where(s => s.nombre.Equals(nombre));
                    if (valNombre.ToArray().Length > 0)
                    {
                        MessageBox.Show("Nombre ya registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        Servicio nuevoServicio = new Servicio();
                        nuevoServicio.nombre = nombre;
                        nuevoServicio.precio = decimal.Parse(textBoxes[1].Text);
                        nuevoServicio.activo = true;
                        nuevoServicio.idCategoriaServ = comboBox.SelectedIndex+1;
                        db.Servicio.Add(nuevoServicio);
                        db.SaveChanges();
                        MessageBox.Show("Servicio agregado", "Agregar Servicio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Ingrese todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private int idServicio;
        private string nombreS;
        public void obtenerServicio(int id, List<TextBox> textBoxes, ComboBox comboBox, DataGridView dataGrid, Button buttonEliminar)
        {
            textBoxes[0].Text = (dataGrid.CurrentRow.Cells[1].Value.ToString());
            textBoxes[1].Text = (dataGrid.CurrentRow.Cells[2].Value.ToString());
            idServicio = id;
            nombreS = textBoxes[0].Text;
            using (bd_blulightEntities db = new bd_blulightEntities())
            {

                var servicio = db.Servicio.SingleOrDefault(e => e.idServicio.Equals(id));

                if (servicio.activo) buttonEliminar.Text = "Eliminar";
                else buttonEliminar.Text = "Restaurar";

                int idCategoria = servicio.idCategoriaServ;

                comboBox.SelectedIndex = idCategoria - 1;

            }
        }

        public void restablecerCampos(List<TextBox> textBoxes, ComboBox comboBox)
        {
            foreach(TextBox textBox in textBoxes)
            {
                textBox.Text = "";
            }
            comboBox.SelectedIndex = -1;
        }

        public void modificarServicio(List<TextBox> textBoxes, ComboBox comboBox)
        {
            bool validation = true;

            foreach (TextBox textBox in textBoxes)
            {
                if (textBox.Text.Equals(""))
                {
                    validation = false;
                }
            }

            if (comboBox.SelectedIndex == -1)
            {
                validation = false;
            }

            if (validation)
            {
                using (bd_blulightEntities db = new bd_blulightEntities())
                {
                    var nombre = textBoxes[0].Text.ToString();
                    var valNombre = db.Servicio.Where(s => s.nombre.Equals(nombre));
                    if (nombreS.Equals(nombre) || valNombre.ToArray().Length == 0)
                    {
                        var servicioModif = db.Servicio.SingleOrDefault(s => s.idServicio.Equals(idServicio));

                        servicioModif.nombre = nombre;
                        servicioModif.precio = decimal.Parse(textBoxes[1].Text);
                        servicioModif.activo = true;
                        servicioModif.idCategoriaServ = comboBox.SelectedIndex + 1;
                        db.SaveChanges();
                        MessageBox.Show("Servicio modificado", "Modificar Servicio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Nombre ya registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                MessageBox.Show("Ingrese todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void eliminarServicio()
        {
            if (MessageBox.Show("Estas seguro de que desea eliminar el servicio?", "Eliminar servicio", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (bd_blulightEntities db = new bd_blulightEntities())
                {
                    var servicioModif = db.Servicio.SingleOrDefault(s => s.idServicio.Equals(idServicio));

                    servicioModif.activo = false;

                    db.SaveChanges();

                    MessageBox.Show("Servicio eliminado", "Eliminar Servicio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void restaurarServicio()
        {
            if (MessageBox.Show("Estas seguro de que desea restaurar el servicio?", "Restaurar servicio", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (bd_blulightEntities db = new bd_blulightEntities())
                {
                    var servicioModif = db.Servicio.SingleOrDefault(s => s.idServicio.Equals(idServicio));

                    servicioModif.activo = true;

                    db.SaveChanges();

                    MessageBox.Show("Servicio restaurado", "Restaurar Servicio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
