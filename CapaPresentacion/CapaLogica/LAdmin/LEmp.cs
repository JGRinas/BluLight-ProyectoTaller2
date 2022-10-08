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

namespace CapaLogica.LAdmin
{
    public class LEmp : Librerias
    {
        
        public void comboBoxLaboratorio(ComboBox comboBox)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                foreach (var item in db.Laboratorio)
                {
                    comboBox.Items.Add(item.idLab + " - " + item.nombre);
                }
            }
                
        }
        public void registerEmp(List<TextBox> listTextBoxes, List<Label> listLabels, ComboBox comboBoxLaboratorio)
        {
            bool validation = true;

            for (int i = 0; i < listTextBoxes.Count; i++)
            {
                if (listTextBoxes[i].Text.Equals(""))
                {
                    validation = false;
                }
            }

            bool valEmail = textBoxEvent.validateEmail(listTextBoxes[5].Text);

            if (validation && valEmail)
            {
                using (bd_blulightEntities db = new bd_blulightEntities())
                {

                    var dni = Int32.Parse(listTextBoxes[2].Text);
                    var dniValidate = from p in db.Empleado where p.Persona.dni == dni select p;

                    if (dniValidate.ToArray().Length > 0)
                    {
                        listLabels[2].Text = "DNI: ya registrado";
                        listLabels[2].ForeColor = Color.Red;
                    }
                    else
                    {
                        Persona persona = new Persona();
                        persona.nombre = listTextBoxes[0].Text;
                        persona.apellido = listTextBoxes[1].Text;
                        persona.dni = Int32.Parse(listTextBoxes[2].Text);
                        persona.telefono = Int32.Parse(listTextBoxes[4].Text);
                        persona.email = listTextBoxes[5].Text;

                        db.Persona.Add(persona);
                        db.SaveChanges();

                        var personaE = db.Persona.Where(b => b.dni.Equals(dni)).ToList();
                        Empleado empleado = new Empleado();

                        empleado.maxTitulo = listTextBoxes[3].Text;
                        empleado.idPersona = personaE[0].idPersona;

                        if (comboBoxLaboratorio.SelectedIndex == -1) empleado.idLab = null;
                        else empleado.idLab = Int32.Parse(comboBoxLaboratorio.SelectedIndex.ToString()) + 1;

                        empleado.activo = true;
                        db.Empleado.Add(empleado);
                        db.SaveChanges();

                        MessageBox.Show("Empleado " + listTextBoxes[0].Text + " " + listTextBoxes[1].Text + " agregado!", "Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                        listLabels[2].Text = "DNI";
                        listLabels[2].ForeColor = Color.White;
                        for (int i = 0; i < listTextBoxes.Count; i++)
                        {
                            listTextBoxes[i].Text = "";
                        }
                        comboBoxLaboratorio.SelectedIndex = -1;
                    }
                }
            }
            else
            {
                if (!validation) MessageBox.Show("Ingrese todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (!valEmail) MessageBox.Show("Email inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        public void modificarEmpleado(List<TextBox> listTextBox, ComboBox comboBoxLaboratorio, Button buttonModificar)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                bool validation = true;

                for (int i = 0; i < listTextBox.Count; i++)
                {
                    if (listTextBox[i].Text.Equals(""))
                    {
                        validation = false;
                    }
                }

                bool valEmail = textBoxEvent.validateEmail(listTextBox[5].Text);

                if (validation && valEmail) 
                {
                    int dniIngresado = Int32.Parse(listTextBox[2].Text);
                    var dniValidate = from p in db.Empleado where p.Persona.dni == dniIngresado select p;
                    if (dniEmpleadoBuscar == dniIngresado || dniValidate.ToArray().Length <= 0)
                    {
                        var empleado = db.Empleado.SingleOrDefault(e => e.Persona.dni.Equals(dniEmpleadoBuscar));

                        if (comboBoxLaboratorio.SelectedIndex == -1) empleado.idLab = null;
                        else empleado.idLab = Int32.Parse(comboBoxLaboratorio.SelectedIndex.ToString()) + 1;

                        empleado.Persona.nombre = listTextBox[0].Text;
                        empleado.Persona.apellido = listTextBox[1].Text;
                        empleado.Persona.dni = Int32.Parse(listTextBox[2].Text);
                        empleado.maxTitulo = listTextBox[3].Text;
                        empleado.Persona.telefono = Int32.Parse(listTextBox[4].Text);
                        empleado.Persona.email = listTextBox[5].Text;
                        db.SaveChanges();
                        MessageBox.Show("Empleado modificado", "Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        for (int i = 0; i < listTextBox.Count; i++)
                        {
                            listTextBox[i].Text = "";
                        }
                        comboBoxLaboratorio.SelectedIndex = -1;
                        buttonModificar.Enabled = false;
                        
                    }
                    else if(dniValidate.ToArray().Length > 0)
                    {
                        MessageBox.Show("Dni ya registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    if(!validation) MessageBox.Show("Ingrese todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if(!valEmail) MessageBox.Show("Email inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

            }
        }

        public void searchEmp(DataGridView dataGrid)
        {
           using (bd_blulightEntities db = new bd_blulightEntities())
           {
                List<Empleado> empleados = new List<Empleado>();

                empleados = db.Empleado.ToList();

              if (empleados.Count > 0)
              {
                 foreach (Empleado empleado in empleados)
                 {
                        var activo = "";
                        int fila = dataGrid.Rows.Add();
                        if (empleado.activo)
                        {
                            activo = "Si";
                            dataGrid.Rows[fila].DefaultCellStyle.BackColor = Color.White;
                        }
                        else
                        {
                            activo = "No";
                            dataGrid.Rows[fila].DefaultCellStyle.BackColor = Color.Gray;
                        }

                        var lab = "No corresponde";
                        if(empleado.idLab != null) lab = empleado.Laboratorio.nombre;


                        dataGrid.Rows[fila].Cells["ColumnActivo"].Value = activo;
                        dataGrid.Rows[fila].Cells["ColumnName"].Value = empleado.Persona.nombre;
                        dataGrid.Rows[fila].Cells["ColumnSurname"].Value = empleado.Persona.apellido;
                        dataGrid.Rows[fila].Cells["ColumnDni"].Value = empleado.Persona.dni;
                        dataGrid.Rows[fila].Cells["ColumnTelefono"].Value = empleado.Persona.telefono;
                        dataGrid.Rows[fila].Cells["ColumnEmail"].Value = empleado.Persona.email;
                        dataGrid.Rows[fila].Cells["ColumnTitulo"].Value = empleado.maxTitulo;
                        dataGrid.Rows[fila].Cells["ColumnLaboratorio"].Value = lab ;
                 }
              }
           }
        }

        public void buscarEmpleado(List<Label> listLabels, int dni, Button buttonEliminar)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                foreach (Label label in listLabels)
                {
                    label.Text = "";
                }

                Empleado empleados = new Empleado();

                var personaE = db.Empleado.Where(b => b.Persona.dni.Equals(dni)).ToList();

                if (personaE.Count > 0)
                {
                    var idP = Int32.Parse(personaE[0].idPersona.ToString());
                    empleados = db.Empleado.Where(e => e.idPersona.Equals(idP)).First();

                    var lab = "No corresponde";
                    if (empleados.idLab != null) lab = empleados.Laboratorio.nombre;

                    listLabels[0].Text += empleados.Persona.nombre + " " + empleados.Persona.apellido;
                    listLabels[1].Text += empleados.Persona.email;
                    listLabels[2].Text += empleados.Persona.dni.ToString();
                    listLabels[3].Text += lab;

                    if (empleados.activo) buttonEliminar.Text = "Eliminar";
                    else buttonEliminar.Text = "Restaurar";

                }
                else
                {
                    MessageBox.Show("Empleado inexistente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private int dniEmpleadoBuscar;
        public void buscarEmpleadoModificar(List<TextBox> listTextBox, ComboBox comboBoxLaboratorio, Button buttonModificar, int dni)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                foreach (TextBox textBox in listTextBox)
                {
                    textBox.Text = "";
                }

                comboBoxLaboratorio.SelectedIndex = -1;
                Empleado empleados = new Empleado();

                var personaE = db.Empleado.Where(b => b.Persona.dni.Equals(dni)).ToList();

                if (personaE.Count > 0)
                {
                    dniEmpleadoBuscar = dni;
                    var idP = Int32.Parse(personaE[0].idPersona.ToString());
                    empleados = db.Empleado.Where(e => e.idPersona.Equals(idP)).First();
                    listTextBox[0].Text = empleados.Persona.nombre;
                    listTextBox[1].Text = empleados.Persona.apellido;
                    listTextBox[2].Text = empleados.Persona.dni.ToString();
                    listTextBox[3].Text = empleados.maxTitulo;
                    listTextBox[4].Text = empleados.Persona.telefono.ToString();
                    listTextBox[5].Text = empleados.Persona.email;

                    int lab = -1;
                    if (empleados.idLab != null) lab = Int32.Parse(empleados.idLab.ToString()) - 1;

                    comboBoxLaboratorio.SelectedIndex = lab;

                    buttonModificar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Empleado inexistente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
        public void deleteUser(int dni)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                if (MessageBox.Show("Estas seguro de que desea eliminar al empleado?", "Eliminar empleado", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    
                    if (db.Empleado.Where(e => e.Persona.dni.Equals(dni)).ToList().Count > 0)
                    {
                        var activo = db.Empleado.SingleOrDefault(e => e.Persona.dni.Equals(dni));

                            activo.activo = false;
                            MessageBox.Show("Empleado eliminado", "Eliminar Empleado", MessageBoxButtons.OK);

                        db.SaveChanges();

                    }
                    else
                    {
                        MessageBox.Show("El empleado No Existe", "Error", MessageBoxButtons.OK);
                    }
                }
            }
        }

        public void restoreUser(int dni)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                if (MessageBox.Show("Estas seguro de que desea restaurar al empleado?", "Resaturar empleado", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    if (db.Empleado.Where(e => e.Persona.dni.Equals(dni)).ToList().Count > 0)
                    {
                        var activo = db.Empleado.SingleOrDefault(e => e.Persona.dni.Equals(dni));

                            activo.activo = true;
                            MessageBox.Show("Empleado restaurado", "Restaurar Empleado", MessageBoxButtons.OK);

                        db.SaveChanges();

                    }
                    else
                    {
                        MessageBox.Show("El empleado No Existe", "Error", MessageBoxButtons.OK);
                    }
                }
            }
        }
    }
}
