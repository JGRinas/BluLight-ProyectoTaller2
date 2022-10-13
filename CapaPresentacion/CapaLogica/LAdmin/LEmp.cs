using CapaLogica.Libreria;
using CapaPresentacion.CapaData.Model;
using LinqToDB;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaLogica.LAdmin
{
    public class LEmp : Librerias
    {
        private int dniEmpleadoBuscar;
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
        public void registerEmp(List<TextBox> listTextBoxes, ComboBox comboBoxLaboratorio)
        {
            bool validation = true;

            foreach(TextBox textBox in listTextBoxes)
            {
                if (textBox.Text.Equals(""))
                {
                    validation = false;
                }
            }

            bool valEmail = textBoxEvent.validateEmail(listTextBoxes[3].Text);

            if (validation && valEmail)
            {
                using (bd_blulightEntities db = new bd_blulightEntities())
                {

                    int dni = Int32.Parse(listTextBoxes[2].Text.ToString());
                    var dniValidate = from p in db.Empleado where p.Persona.dni == dni select p;

                    if (dniValidate.ToArray().Length > 0)
                    {
                        MessageBox.Show("DNI ya registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Persona persona = new Persona();
                        persona.nombre = listTextBoxes[0].Text.ToString();
                        persona.apellido = listTextBoxes[1].Text.ToString();
                        persona.dni = Int32.Parse(listTextBoxes[2].Text.ToString());
                        persona.telefono = Int32.Parse(listTextBoxes[4].Text.ToString());
                        persona.email = listTextBoxes[3].Text.ToString();

                        db.Persona.Add(persona);
                        db.SaveChanges();

                        var personaE = db.Persona.Where(b => b.dni.Equals(dni)).ToList();
                        Empleado empleado = new Empleado();

                        empleado.maxTitulo = listTextBoxes[5].Text.ToString();
                        empleado.idPersona = personaE[0].idPersona;

                        if (comboBoxLaboratorio.SelectedIndex == -1) empleado.idLab = null;
                        else empleado.idLab = Int32.Parse(comboBoxLaboratorio.SelectedIndex.ToString()) + 1;

                        empleado.activo = true;
                        db.Empleado.Add(empleado);
                        db.SaveChanges();

                        MessageBox.Show("Empleado " + listTextBoxes[0].Text + " " + listTextBoxes[1].Text + " agregado!", "Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
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

        public void restaurarCampos(List<TextBox> listTextBox, ComboBox comboBoxLaboratorio, List<Button> buttons)
        {
            foreach (TextBox empleado in listTextBox)
            {
                empleado.Text = "";
            }
            comboBoxLaboratorio.SelectedIndex = -1;

            buttons[0].Enabled = false;
            buttons[0].Text = "Modificar";

            buttons[1].Enabled = false;
            buttons[1].Text = "Eliminar";

            buttons[2].Text = "Registrar";
        }
        public void modificarEmpleado(List<TextBox> listTextBox, ComboBox comboBoxLaboratorio)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                bool validation = true;

                foreach (TextBox textBox in listTextBox)
                {
                    if (textBox.Text.Equals(""))
                    {
                        validation = false;
                    }
                }

                bool valEmail = textBoxEvent.validateEmail(listTextBox[2].Text);

                if (validation && valEmail) 
                {
                    int dniIngresado = Int32.Parse(listTextBox[3].Text);
                    var dniValidate = from p in db.Empleado where p.Persona.dni == dniIngresado select p;
                    if (dniEmpleadoBuscar == dniIngresado || dniValidate.ToArray().Length <= 0)
                    {
                        var empleado = db.Empleado.SingleOrDefault(e => e.Persona.dni.Equals(dniEmpleadoBuscar));

                        if (comboBoxLaboratorio.SelectedIndex == -1) empleado.idLab = null;
                        else empleado.idLab = Int32.Parse(comboBoxLaboratorio.SelectedIndex.ToString()) + 1;

                        empleado.Persona.nombre = listTextBox[0].Text;
                        empleado.Persona.apellido = listTextBox[1].Text;
                        empleado.Persona.dni = Int32.Parse(listTextBox[3].Text);
                        empleado.maxTitulo = listTextBox[5].Text;
                        empleado.Persona.telefono = Int32.Parse(listTextBox[4].Text);
                        empleado.Persona.email = listTextBox[2].Text;
                        db.SaveChanges();
                        MessageBox.Show("Empleado modificado", "Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        for (int i = 0; i < listTextBox.Count; i++)
                        {
                            listTextBox[i].Text = "";
                        }
                        comboBoxLaboratorio.SelectedIndex = -1;
                        
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

        public void obtenerEmpleado(List<TextBox> textBoxes, ComboBox comboBox, DataGridView dataGridView, List<Button> buttons)
        {
            textBoxes[0].Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            textBoxes[1].Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            textBoxes[2].Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
            textBoxes[3].Text = dataGridView.CurrentRow.Cells[4].Value.ToString();
            textBoxes[4].Text = dataGridView.CurrentRow.Cells[5].Value.ToString();
            textBoxes[5].Text = dataGridView.CurrentRow.Cells[6].Value.ToString();
            textBoxes[6].Text = dataGridView.CurrentRow.Cells[3].Value.ToString();

            using (bd_blulightEntities bd = new bd_blulightEntities())
            {
                List<Laboratorio> laboratorios = new List<Laboratorio>();
                laboratorios = bd.Laboratorio.ToList();

                int idlabo = 0;
                foreach(Laboratorio laboratorio in laboratorios)
                {
                    if (laboratorio.nombre.Equals(dataGridView.CurrentRow.Cells[7].Value.ToString()))
                    {
                        idlabo = laboratorio.idLab;
                    }
                }
                comboBox.SelectedIndex = idlabo - 1;
            }

            dniEmpleadoBuscar = Int32.Parse(dataGridView.CurrentRow.Cells[3].Value.ToString());

            buttons[0].Enabled = true;
            buttons[1].Enabled = true;
            buttons[1].Text = "Eliminar";
            if (dataGridView.CurrentRow.Cells[0].Value.ToString().Equals("No")) buttons[1].Text = "Restaurar";
            buttons[2].Text = "Restablecer";
        }
        public void buscarEmpleado(List<TextBox> textBoxes, ComboBox comboBox, List<Button> buttons)
        {
            if (textBoxes[6].Text.Equals(""))
            {
                MessageBox.Show("Ingrese un dni", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (bd_blulightEntities db = new bd_blulightEntities())
                {
                    Empleado empleados = new Empleado();
                    int dniB = Int32.Parse(textBoxes[6].Text);
                    var personaE = db.Empleado.Where(b => b.Persona.dni.Equals(dniB)).ToList();

                    if (personaE.Count > 0)
                    {
                        empleados = db.Empleado.Where(b => b.Persona.dni.Equals(dniB)).FirstOrDefault();
                        var lab = 0;
                        if (empleados.idLab != null) lab = empleados.Laboratorio.idLab;
                        dniEmpleadoBuscar = dniB;
                        textBoxes[0].Text = empleados.Persona.nombre;
                        textBoxes[1].Text = empleados.Persona.apellido;
                        textBoxes[2].Text = empleados.Persona.email;
                        textBoxes[3].Text = empleados.Persona.dni.ToString(); 
                        textBoxes[4].Text = empleados.Persona.telefono.ToString();
                        textBoxes[5].Text = empleados.maxTitulo;

                        comboBox.SelectedIndex = lab;

                        buttons[0].Enabled = true;
                       

                        if (empleados.activo) buttons[1].Text = "Eliminar";
                        else buttons[1].Text = "Restaurar";

                        buttons[1].Enabled = true;

                        buttons[2].Text = "Restablecer";
                    }
                    else
                    {
                        MessageBox.Show("Empleado inexistente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } 
        }
        public void deleteUser()
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                if (MessageBox.Show("Estas seguro de que desea eliminar al empleado?", "Eliminar empleado", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    
                    if (db.Empleado.Where(e => e.Persona.dni.Equals(dniEmpleadoBuscar)).ToList().Count > 0)
                    {
                        var activo = db.Empleado.SingleOrDefault(e => e.Persona.dni.Equals(dniEmpleadoBuscar));

                            activo.activo = false;
                            MessageBox.Show("Empleado eliminado", "Eliminar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        db.SaveChanges();

                    }
                    else
                    {
                        MessageBox.Show("El empleado No Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        public void restoreUser()
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                if (MessageBox.Show("Estas seguro de que desea restaurar al empleado?", "Resaturar empleado", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    if (db.Empleado.Where(e => e.Persona.dni.Equals(dniEmpleadoBuscar)).ToList().Count > 0)
                    {
                        var activo = db.Empleado.SingleOrDefault(e => e.Persona.dni.Equals(dniEmpleadoBuscar));

                            activo.activo = true;
                            MessageBox.Show("Empleado restaurado", "Restaurar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        db.SaveChanges();

                    }
                    else
                    {
                        MessageBox.Show("El empleado No Existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }
    }
}
