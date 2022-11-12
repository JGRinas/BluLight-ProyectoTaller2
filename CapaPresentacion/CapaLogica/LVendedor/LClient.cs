using CapaPresentacion.CapaData.Model;
using CapaLogica.Libreria;
using LinqToDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Bunifu.UI.WinForms;

namespace CapaLogica.LVendedor
{
    public class LClient : Librerias
    {

        private int dniClienteB;
        public void rellenarDataGridCliente(DataGridView dataGrid)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                List<Persona> personas = new List<Persona>();
                personas = db.Persona.ToList();

                foreach (Persona persona in personas)
                {
                    int dni = persona.dni;
                    var empleado = db.Empleado.Where(e => e.Persona.dni.Equals(dni));

                    if (empleado.ToList().Count == 0 && persona.dni != 0)
                    {

                        int fila = dataGrid.Rows.Add();
                        var activo = "No";
                        dataGrid.Rows[fila].DefaultCellStyle.BackColor = Color.Gray;
                        if (persona.activo == true)
                        {
                            activo = "Si";
                            dataGrid.Rows[fila].DefaultCellStyle.BackColor = Color.White;
                        }

                        dataGrid.Rows[fila].Cells["ColumnNombre"].Value = persona.nombre;
                        dataGrid.Rows[fila].Cells["ColumnApellido"].Value = persona.apellido;
                        dataGrid.Rows[fila].Cells["ColumnDni"].Value = persona.dni;
                        dataGrid.Rows[fila].Cells["ColumnTelefono"].Value = persona.telefono;
                        dataGrid.Rows[fila].Cells["ColumnEmail"].Value = persona.email;
                        dataGrid.Rows[fila].Cells["ColumnDireccion"].Value = persona.direccion;
                        dataGrid.Rows[fila].Cells["ColumnActivo"].Value = activo;

                    }
                }
            }
        }


        public void registrarCliente(List<TextBox> textBoxes, List<Button> buttons)
        {
            bool validation = true;

            foreach (TextBox textBox in textBoxes)
            {
                if (textBox.Text.Equals(""))
                {
                    validation = false;
                }
            }

            bool valEmail = textBoxEvent.validateEmail(textBoxes[4].Text);
            if (validation && valEmail)
            {
                using (bd_blulightEntities db = new bd_blulightEntities())
                {
                    int dni = Int32.Parse(textBoxes[2].Text);
                    var valPersona = db.Persona.Where(p => p.dni.Equals(dni)).ToList();
                    if (valPersona.Count == 0)
                    {
                        Persona persona = new Persona();
                        persona.dni = dni;
                        persona.nombre = textBoxes[0].Text.ToString();
                        persona.apellido = textBoxes[1].Text.ToString();
                        persona.email = textBoxes[4].Text.ToString();
                        persona.telefono = textBoxes[5].Text.ToString();
                        persona.direccion = textBoxes[3].Text.ToString();
                        persona.activo = true;

                        db.Persona.Add(persona);
                        db.SaveChanges();

                        MessageBox.Show("Cliente agregado correctamente!", "Agregar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        reestablecerCampos(textBoxes, buttons);
                    }
                    else
                    {
                        MessageBox.Show("DNI ya registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                if (!validation) MessageBox.Show("Ingrese todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (!valEmail) MessageBox.Show("Email inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        public void reestablecerCampos(List<TextBox> textBoxes, List<Button> buttons)
        {
            foreach (TextBox textBox in textBoxes)
            {
                textBox.Text = "";
            }

            buttons[0].Text = "Registrar";
            buttons[1].Enabled = false;
            buttons[2].Enabled = false;
            buttons[2].Text = "Eliminar";
        }

        public void obtenerClienteEnDataGrid(List<TextBox> textBoxes, List<Button> buttons, DataGridView dataGrid)
        {
            textBoxes[0].Text = dataGrid.CurrentRow.Cells[0].Value.ToString();
            textBoxes[1].Text = dataGrid.CurrentRow.Cells[1].Value.ToString();
            textBoxes[2].Text = dataGrid.CurrentRow.Cells[2].Value.ToString();
            textBoxes[3].Text = dataGrid.CurrentRow.Cells[3].Value.ToString();
            textBoxes[4].Text = dataGrid.CurrentRow.Cells[4].Value.ToString();
            textBoxes[5].Text = dataGrid.CurrentRow.Cells[5].Value.ToString();
            textBoxes[6].Text = dataGrid.CurrentRow.Cells[2].Value.ToString();
            dniClienteB = Int32.Parse(dataGrid.CurrentRow.Cells[2].Value.ToString());
            var activo = dataGrid.CurrentRow.Cells[6].Value.ToString();

            buttons[0].Text = "Restablecer";
            buttons[1].Enabled = true;
            buttons[2].Enabled = true;
            buttons[2].Text = "Eliminar";
            if (activo.Equals("No")) buttons[2].Text = "Restaurar";
        }

        public void obtenerClienteEnButton(List<TextBox> textBoxes, List<Button> buttons)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                int dni = Int32.Parse(textBoxes[6].Text);
                var cliente = db.Persona.Where(p => p.dni.Equals(dni)).ToList();
                var empleado = db.Empleado.Where(p => p.Persona.dni.Equals(dni)).ToList();
                if (cliente.Count > 0 && empleado.Count == 0 && cliente[0].dni != 0)
                {

                    textBoxes[0].Text = cliente[0].nombre;
                    textBoxes[1].Text = cliente[0].apellido;
                    textBoxes[2].Text = cliente[0].dni.ToString();
                    textBoxes[4].Text = cliente[0].email;
                    textBoxes[5].Text = cliente[0].telefono;
                    textBoxes[3].Text = cliente[0].direccion;
                    dniClienteB = dni;

                    buttons[0].Text = "Restablecer";
                    buttons[1].Enabled = true;
                    buttons[2].Enabled = true;
                    buttons[2].Text = "Eliminar";
                    
                    if (!(cliente[0].activo == true)){ buttons[2].Text = "Restaurar"; }

                }
                else
                {
                    MessageBox.Show("El DNI ingresado no corresponde a ningún cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void modificarCliente(List<TextBox> textBoxes, List<Button> buttons)
        {
            bool validation = true;

            foreach (TextBox textBox in textBoxes)
            {
                if (textBox.Text.Equals(""))
                {
                    validation = false;
                }
            }

            bool valEmail = textBoxEvent.validateEmail(textBoxes[4].Text);

            if (validation && valEmail)
            {
                using (bd_blulightEntities db = new bd_blulightEntities())
                {
                    int dni = Int32.Parse(textBoxes[2].Text);
                    var valPersona = db.Persona.Where(p => p.dni.Equals(dni)).ToList();
                    if (dniClienteB == dni || valPersona.Count == 0)
                    {
                        Persona persona = db.Persona.Where(p => p.dni.Equals(dni)).FirstOrDefault();

                        persona.dni = dni;
                        persona.nombre = textBoxes[0].Text.ToString();
                        persona.apellido = textBoxes[1].Text.ToString();
                        persona.email = textBoxes[4].Text.ToString();
                        persona.telefono = textBoxes[5].Text.ToString();
                        persona.direccion = textBoxes[3].Text.ToString();

                        db.SaveChanges();

                        MessageBox.Show("Cliente modificado correctamente!", "Modificar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        reestablecerCampos(textBoxes, buttons);
                    }
                    else
                    {
                        MessageBox.Show("DNI ya registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (!validation) MessageBox.Show("Ingrese todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (!valEmail) MessageBox.Show("Email inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        public void eliminarCliente()
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                if (MessageBox.Show("Estas seguro de que desea eliminar al Cliente?", "Eliminar Cliente", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    if (db.Persona.Where(e => e.dni.Equals(dniClienteB)).ToList().Count > 0)
                    {
                        var activo = db.Persona.SingleOrDefault(e => e.dni.Equals(dniClienteB));

                        activo.activo = false;
                        MessageBox.Show("Cliente eliminado", "Eliminar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        db.SaveChanges();

                    }
                    else
                    {
                        MessageBox.Show("El Cliente No Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        public void restaurarCliente()
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                if (MessageBox.Show("Estas seguro de que desea restaurar al Cliente?", "Restaurar Cliente", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    if (db.Persona.Where(e => e.dni.Equals(dniClienteB)).ToList().Count > 0)
                    {
                        var activo = db.Persona.SingleOrDefault(e => e.dni.Equals(dniClienteB));

                        activo.activo = true;
                        MessageBox.Show("Cliente restaurado", "Restaurar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        db.SaveChanges();

                    }
                    else
                    {
                        MessageBox.Show("El Cliente No Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}

