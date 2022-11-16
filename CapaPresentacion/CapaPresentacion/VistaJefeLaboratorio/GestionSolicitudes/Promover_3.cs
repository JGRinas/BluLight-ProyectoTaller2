using CapaPresentacion.CapaLogica.LJefeLab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.CapaPresentacion.VistaJefeLaboratorio.GestionSolicitudes
{
    public partial class Promover_3 : Form
    {
        LSolicitud solicitud1;
        string idSolicitud;

        public Promover_3(string pidSolicitud)
        {
            InitializeComponent();
            idSolicitud = pidSolicitud;
            solicitud1 = new LSolicitud();
            solicitud1.rellenarComboBoxEmpSeleccionado(comboBoxEmpleados, idSolicitud);
        }


        private void btnRevertirPendiente_Click(object sender, EventArgs e)
        {
            solicitud1.revertirPendiente(this.idSolicitud);
        }

        private void btnRevertirFinalizado_Click(object sender, EventArgs e)
        {
            if (comboBoxEmpleados.SelectedIndex != -1)
            {
                int idEmpleado = Int32.Parse(solicitud1.filtrarIdEmpleado(comboBoxEmpleados.SelectedItem.ToString()));
                solicitud1.revertirFinalizado(this.idSolicitud, idEmpleado);
            }
            else
            {
                MessageBox.Show("Seleccione un empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (comboBoxEmpleados.SelectedIndex != -1)
            {
                comboBoxEmpleados.Items.Clear();
                solicitud1.rellenarComboBoxEmpleados(comboBoxEmpleados);
                comboBoxEmpleados.SelectedIndex = 0;
                comboBoxEmpleados.SelectedItem = 0;
                comboBoxEmpleados.Enabled = true;
                bunifuButton1.Enabled = false;
            }
            else
            {
                MessageBox.Show("Seleccione un empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
