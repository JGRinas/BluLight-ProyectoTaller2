using CapaLogica.LAdmin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto2022.CapaPresentacion.VistaAdmin.GestionarUsuario
{
    public partial class ModificarEmpleado : Form
    {
        LEmp emp;
        public ModificarEmpleado()
        {
            InitializeComponent();
            emp = new LEmp();
            emp.comboBoxLaboratorio(comboBoxLaboratorio);
            emp.searchEmp(dataGridViewEmpleados);
            textBoxDniBuscar.MaxLength = 9;
            textBoxDni.MaxLength = 9;
            textBoxTelefono.MaxLength = 9;
        }
        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            emp.textBoxEvent.textKeyPress(e);
        }

        private void textBoxDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            emp.textBoxEvent.numberKeyPress(e);
        } 

        private void textBoxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            emp.textBoxEvent.textKeyPress(e);
        }

        private void textBoxTitulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            emp.textBoxEvent.textKeyPress(e);
        }

        private void textBoxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            emp.textBoxEvent.numberKeyPress(e);
        }

        private void textBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void textBoxDniBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            emp.textBoxEvent.numberKeyPress(e);
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (textBoxDniBuscar.Text.Equals("")) MessageBox.Show("Ingrese un DNI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                var listTextBoxModify = new List<TextBox>();
                listTextBoxModify.Add(textBoxNombre);
                listTextBoxModify.Add(textBoxApellido);
                listTextBoxModify.Add(textBoxDni);
                listTextBoxModify.Add(textBoxTitulo);
                listTextBoxModify.Add(textBoxTelefono);
                listTextBoxModify.Add(textBoxEmail);
                int dni = Int32.Parse(textBoxDniBuscar.Text);
                emp.buscarEmpleadoModificar(listTextBoxModify, comboBoxLaboratorio, buttonModificar, dni);
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
                var listTextBoxModify = new List<TextBox>();
                listTextBoxModify.Add(textBoxNombre);
                listTextBoxModify.Add(textBoxApellido);
                listTextBoxModify.Add(textBoxDni);
                listTextBoxModify.Add(textBoxTitulo);
                listTextBoxModify.Add(textBoxTelefono);
                listTextBoxModify.Add(textBoxEmail);

                emp.modificarEmpleado(listTextBoxModify, comboBoxLaboratorio, buttonModificar);
                dataGridViewEmpleados.Rows.Clear();
                emp.searchEmp(dataGridViewEmpleados);
        }
    }
}
