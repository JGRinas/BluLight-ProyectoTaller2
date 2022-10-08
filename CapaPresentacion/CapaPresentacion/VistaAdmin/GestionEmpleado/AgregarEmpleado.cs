using System;
using CapaLogica.LAdmin;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto2022.CapaPresentacion.VistaAdmin
{
    public partial class AgregarEmpleado : Form
    {
        LEmp emp;
        public AgregarEmpleado()
        {
            InitializeComponent();
            emp = new LEmp();
            emp.searchEmp(dataGridViewEmpleados);
            emp.comboBoxLaboratorio(comboBoxLaboratorio);
            textBoxDni.MaxLength = 9;
            textBoxTelefono.MaxLength = 9;
        }

        private void textBoxNombre_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            emp.textBoxEvent.textKeyPress(e);
        }

        private void textBoxApellido_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            emp.textBoxEvent.textKeyPress(e);
        }
        private void textBoxDni_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            emp.textBoxEvent.numberKeyPress(e);
        }
        private void textBoxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            emp.textBoxEvent.numberKeyPress(e);
        }

        private void textBoxTitulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            emp.textBoxEvent.textKeyPress(e);
        }


        private void buttonRegistrarEmpleado_Click(object sender, EventArgs e)
        {
            List<TextBox> textBoxes = new List<TextBox>();
            textBoxes.Add(textBoxNombre);
            textBoxes.Add(textBoxApellido);
            textBoxes.Add(textBoxDni);
            textBoxes.Add(textBoxTitulo);
            textBoxes.Add(textBoxTelefono);
            textBoxes.Add(textBoxEmail);

            List<Label> labels = new List<Label>();
            labels.Add(labelNombre);
            labels.Add(labelApellido);
            labels.Add(labelDni);
            labels.Add(labelTitulo);
            labels.Add(labelTelefono);
            labels.Add(labelEmail);

            emp.registerEmp(textBoxes, labels, comboBoxLaboratorio);
            dataGridViewEmpleados.Rows.Clear();
            emp.searchEmp(dataGridViewEmpleados);
        }


    }
}
