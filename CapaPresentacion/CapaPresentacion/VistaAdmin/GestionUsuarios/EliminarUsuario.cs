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
    public partial class EliminarUsuario : Form
    {
        LUsuariosA user;
        public EliminarUsuario()
        {
            InitializeComponent();
            user = new LUsuariosA();
            user.rellenarDataGridEmpleadoEliminar(dataGridViewEmpleados);
            textBoxDniBuscar.MaxLength = 9;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxDniBuscar.Text.Equals(""))
            {
                MessageBox.Show("Ingrese un dni", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                List<Label> listsLabels = new List<Label>();
                listsLabels.Add(labelNombreYApellido);
                listsLabels.Add(labelDni);
                listsLabels.Add(labelUsuario);
                listsLabels.Add(labelTipoDeUsuario);

                int dni = Int32.Parse(textBoxDniBuscar.Text);

                user.buscarUsuario(listsLabels, dni, buttonEliminarUsuario);

                buttonEliminarUsuario.Enabled = true;

                dataGridViewEmpleados.Rows.Clear();
                user.rellenarDataGridEmpleadoEliminar(dataGridViewEmpleados);
            }
        }

        private void buttonEliminarUsuario_Click(object sender, EventArgs e)
        {
            List<Label> listLabels = new List<Label>();
            listLabels.Add(labelNombreYApellido);
            listLabels.Add(labelDni);
            listLabels.Add(labelUsuario);
            listLabels.Add(labelTipoDeUsuario);

            int dni = Int32.Parse(labelDni.Text);

            if (buttonEliminarUsuario.Text.Equals("Eliminar"))
            {
                user.eliminarUsuario(dni, listLabels);  
            }
            else
            {
                user.restaurarUsuario(dni, listLabels);
            }

            buttonEliminarUsuario.Enabled = false;

            dataGridViewEmpleados.Rows.Clear();
            user.rellenarDataGridEmpleadoEliminar(dataGridViewEmpleados);
        }

        private void textBoxDniBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            user.textBoxEvent.numberKeyPress(e);
        }
    }
}
