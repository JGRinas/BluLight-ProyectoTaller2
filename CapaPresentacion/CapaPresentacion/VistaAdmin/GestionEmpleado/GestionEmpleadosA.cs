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

namespace CapaPresentacion.CapaPresentacion.VistaAdmin.GestionEmpleado
{
    public partial class GestionEmpleadosA : Form
    {
        LEmp emp;
        public GestionEmpleadosA()
        {
            InitializeComponent();
            emp = new LEmp();
            textBoxDni.MaxLength = 9;
            textBoxDniBuscar.MaxLength = 9;
            textBoxApellido.MaxLength = 49;
            textBoxEmail.MaxLength = 49;
            textBoxNombre.MaxLength = 49;
            textBoxTelefono.MaxLength = 15;
            textBoxTitulo.MaxLength = 49;
            emp.comboBoxLaboratorio(comboBoxLaboratorio);
            emp.searchEmp(dataGridViewEmpleados);
        }

        private void textBoxDniBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            emp.textBoxEvent.numberKeyPress(e);
        }

        private void textBoxDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            emp.textBoxEvent.numberKeyPress(e);
        }

        private void textBoxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxTitulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            emp.textBoxEvent.textKeyPress(e);
        }

        private void textBoxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            emp.textBoxEvent.textKeyPress(e);
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            emp.textBoxEvent.textKeyPress(e);
        }

        private void buttonRegistrarUsuario_Click(object sender, EventArgs e)
        {
            List<TextBox> textBoxes = new List<TextBox>();
            textBoxes.Add(textBoxNombre);
            textBoxes.Add(textBoxApellido);
            textBoxes.Add(textBoxDni);
            textBoxes.Add(textBoxEmail);
            textBoxes.Add(textBoxTelefono);
            textBoxes.Add(textBoxTitulo);

            if (buttonRegistrarUsuario.Text.Equals("Registrar"))
            {
                emp.registerEmp(textBoxes, comboBoxLaboratorio);
            }
            else
            {
                List<Button> buttons = new List<Button>();
                buttons.Add(buttonModificar);
                buttons.Add(buttonEliminar);
                buttons.Add(buttonRegistrarUsuario);
                emp.restaurarCampos(textBoxes, comboBoxLaboratorio, buttons);
                textBoxDniBuscar.Text = "";
            }

            dataGridViewEmpleados.Rows.Clear();
            emp.searchEmp(dataGridViewEmpleados);
        }

        private void dataGridViewEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewEmpleados.CurrentRow != null)
            {
                List<TextBox> textBoxes = new List<TextBox>();
                textBoxes.Add(textBoxNombre);
                textBoxes.Add(textBoxApellido);
                textBoxes.Add(textBoxDni);
                textBoxes.Add(textBoxTelefono);
                textBoxes.Add(textBoxEmail);
                textBoxes.Add(textBoxTitulo);
                textBoxes.Add(textBoxDniBuscar);
                List<Button> buttons = new List<Button>();
                buttons.Add(buttonModificar);
                buttons.Add(buttonEliminar);
                buttons.Add(buttonRegistrarUsuario);

                emp.obtenerEmpleado(textBoxes, comboBoxLaboratorio, dataGridViewEmpleados, buttons);
            }
               

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            List<TextBox> textBoxes = new List<TextBox>();
            textBoxes.Add(textBoxNombre);
            textBoxes.Add(textBoxApellido);
            textBoxes.Add(textBoxDni);
            textBoxes.Add(textBoxTelefono);
            textBoxes.Add(textBoxEmail);
            textBoxes.Add(textBoxTitulo);

            List<Button> buttons = new List<Button>();
            buttons.Add(buttonModificar);
            buttons.Add(buttonEliminar);
            buttons.Add(buttonRegistrarUsuario);
            if (buttonEliminar.Text.Equals("Eliminar"))
            {
                emp.deleteUser();
            }
            else
            {
                emp.restoreUser();
            }
            emp.restaurarCampos(textBoxes, comboBoxLaboratorio, buttons);
            dataGridViewEmpleados.Rows.Clear();
            emp.searchEmp(dataGridViewEmpleados);
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            List<TextBox> textBoxes = new List<TextBox>();
            textBoxes.Add(textBoxNombre);
            textBoxes.Add(textBoxApellido);
            textBoxes.Add(textBoxEmail);
            textBoxes.Add(textBoxDni);
            textBoxes.Add(textBoxTelefono);
            textBoxes.Add(textBoxTitulo);
            List<Button> buttons = new List<Button>();
            buttons.Add(buttonModificar);
            buttons.Add(buttonEliminar);
            buttons.Add(buttonRegistrarUsuario);
           

            emp.modificarEmpleado(textBoxes, comboBoxLaboratorio, buttons);

            dataGridViewEmpleados.Rows.Clear();
            emp.searchEmp(dataGridViewEmpleados);
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            List<TextBox> textBoxes = new List<TextBox>();
            textBoxes.Add(textBoxNombre);
            textBoxes.Add(textBoxApellido);
            textBoxes.Add(textBoxEmail);
            textBoxes.Add(textBoxDni);
            textBoxes.Add(textBoxTelefono);
            textBoxes.Add(textBoxTitulo);
            textBoxes.Add(textBoxDniBuscar);

            List<Button> buttons = new List<Button>();
            buttons.Add(buttonModificar);
            buttons.Add(buttonEliminar);
            buttons.Add(buttonRegistrarUsuario);

            emp.buscarEmpleado(textBoxes, comboBoxLaboratorio, buttons);
        }
    }
}
