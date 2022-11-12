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

namespace CapaPresentacion.VistaAdmin.GestionUsuarios
{
    public partial class AgregarUsuario : Form
    {
        LUsuariosA user;
        public AgregarUsuario()
        {
            InitializeComponent();
            user = new LUsuariosA();
            user.rellenarDataGridEmpleado(dataGridViewEmpleados);
            user.comboBoxTiposUsuario(comboBoxTiposUsuario);
            textBoxDniBuscar.MaxLength = 9;
            
        }

        private void textBoxDniBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            user.textBoxEvent.numberKeyPress(e);
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (textBoxDniBuscar.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar un dni", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                List<Label> listLabels = new List<Label>();
                listLabels.Add(labelNombreYApellido);
                listLabels.Add(labelDni);
                listLabels.Add(labelTitulo);
                listLabels.Add(labelLaboratorio);
                listLabels.Add(labelTelefono);
                listLabels.Add(labelEmail);
                List<TextBox> textBoxes = new List<TextBox>();
                textBoxes.Add(textBoxUsuario);
                textBoxes.Add(textBoxContrasena);
                List<Button> buttons = new List<Button>();
                buttons.Add(buttonRegistrarUsuario);
                buttons.Add(buttonModificar);
                buttons.Add(buttonEliminar);
                int dni = Int32.Parse(textBoxDniBuscar.Text);
                user.buscarEmpleado(listLabels, dni, buttons, textBoxes, comboBoxTiposUsuario);
            }
            
        }

        private void buttonRegistrarUsuario_Click(object sender, EventArgs e)
        {
            List<TextBox> textBoxes = new List<TextBox>();
            textBoxes.Add(textBoxUsuario);
            textBoxes.Add(textBoxContrasena);
            List<Label> listLabels = new List<Label>();
            listLabels.Add(labelNombreYApellido);
            listLabels.Add(labelDni);
            listLabels.Add(labelTitulo);
            listLabels.Add(labelLaboratorio);
            listLabels.Add(labelTelefono);
            listLabels.Add(labelEmail);
            List<Button> buttons = new List<Button>();
            buttons.Add(buttonRegistrarUsuario);
            buttons.Add(buttonModificar);
            buttons.Add(buttonEliminar);
         
            if (buttonRegistrarUsuario.Text.Equals("Registrar"))
            {
                user.registrarUsuario(textBoxes, comboBoxTiposUsuario, listLabels, buttonRegistrarUsuario);
            }
            else
            {
                user.restablecerCampos(textBoxes, listLabels, buttons, comboBoxTiposUsuario);
            }

            dataGridViewEmpleados.Rows.Clear();
            user.rellenarDataGridEmpleado(dataGridViewEmpleados);
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            List<TextBox> textBoxes = new List<TextBox>();
            textBoxes.Add(textBoxUsuario);
            textBoxes.Add(textBoxContrasena);
            List<Label> listLabels = new List<Label>();
            listLabels.Add(labelNombreYApellido);
            listLabels.Add(labelDni);
            listLabels.Add(labelTitulo);
            listLabels.Add(labelLaboratorio);
            listLabels.Add(labelTelefono);
            listLabels.Add(labelEmail);
            List<Button> buttons = new List<Button>();
            buttons.Add(buttonRegistrarUsuario);
            buttons.Add(buttonModificar);
            buttons.Add(buttonEliminar);
           
            int dni = Int32.Parse(labelDni.Text);

            if (buttonEliminar.Text.Equals("Eliminar"))
            {
                user.eliminarUsuario(dni);
                user.restablecerCampos(textBoxes, listLabels, buttons, comboBoxTiposUsuario);
            }
            else
            {
                user.restaurarUsuario(dni);
                user.restablecerCampos(textBoxes, listLabels, buttons, comboBoxTiposUsuario);
            }

            dataGridViewEmpleados.Rows.Clear();
            user.rellenarDataGridEmpleado(dataGridViewEmpleados);
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            List<TextBox> textBoxes = new List<TextBox>();
            textBoxes.Add(textBoxUsuario);
            textBoxes.Add(textBoxContrasena);
            List<Label> listLabels = new List<Label>();
            listLabels.Add(labelNombreYApellido);
            listLabels.Add(labelDni);
            listLabels.Add(labelTitulo);
            listLabels.Add(labelLaboratorio);
            listLabels.Add(labelTelefono);
            listLabels.Add(labelEmail);
            List<Button> buttons = new List<Button>();
            buttons.Add(buttonRegistrarUsuario);
            buttons.Add(buttonModificar);
            buttons.Add(buttonEliminar);

            if (!textBoxUsuario.Text.Equals("") && !textBoxContrasena.Text.Equals("") && comboBoxTiposUsuario.SelectedIndex != -1)
            {
                user.modificarUsuario(textBoxes, comboBoxTiposUsuario, listLabels);
                user.restablecerCampos(textBoxes, listLabels, buttons, comboBoxTiposUsuario);
            }
            else
            {
                MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

            
            dataGridViewEmpleados.Rows.Clear();
            user.rellenarDataGridEmpleado(dataGridViewEmpleados);
        }
    }
}
