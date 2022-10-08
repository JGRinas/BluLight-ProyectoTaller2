using CapaLogica;
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
    public partial class EliminarEmpleado : Form
    {
        LEmp emp;
        public EliminarEmpleado()
        {
            InitializeComponent();
            emp = new LEmp();
            emp.searchEmp(dataGridViewEmpleados);
            textBoxDni.MaxLength = 9;
        }

        private void textBoxDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            emp.textBoxEvent.numberKeyPress(e);
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            List<Label> listLabels = new List<Label>();
            listLabels.Add(labelNombreApellido);
            listLabels.Add(labelEmail);
            listLabels.Add(labelDniD);
            listLabels.Add(labelLaboratorio);
            if (textBoxDni.Text == "") MessageBox.Show("Ingrese un DNI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int dni = Int32.Parse(textBoxDni.Text);
                emp.buscarEmpleado(listLabels, dni, buttonEliminar);
            }
            
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (labelDniD.Text != "")
            {
                int dni = Int32.Parse(labelDniD.Text);

                if (buttonEliminar.Text.Equals("Eliminar")) emp.deleteUser(dni);
                else emp.restoreUser(dni);

                dataGridViewEmpleados.Rows.Clear();
                emp.searchEmp(dataGridViewEmpleados);

                labelNombreApellido.Text = "";
                labelEmail.Text = "";
                labelDniD.Text = "";
                labelLaboratorio.Text = "";
                textBoxDni.Text = "";
            }
            else
            {
                MessageBox.Show("No buscó ningún empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
