using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.CapaLogica.LJefeLab;

namespace CapaPresentacion.CapaPresentacion.VistaJefeLaboratorio.GestionSolicitudes
{
    public partial class Promover_2 : Form
    {
        LSolicitud solicitud1;
        string idSolicitud;

        public Promover_2(string pidSolicitud)
        {
            InitializeComponent();
            idSolicitud = pidSolicitud;
            solicitud1 = new LSolicitud();
            solicitud1.rellenarComboBoxEmpSeleccionado(comboBoxEmpleados, idSolicitud);
        }

        private void btnEntregado_Click(object sender, EventArgs e)
        {
            string textoEmpleado = comboBoxEmpleados.Text;
            solicitud1.estadoEntregado(this.idSolicitud, textoEmpleado);
        }

        private void btnRevertirPendiente_Click(object sender, EventArgs e)
        {
            solicitud1.revertirPendiente(this.idSolicitud);
        }

        private void Promover_2_Load(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            comboBoxEmpleados.Items.Clear();
            solicitud1.rellenarComboBoxEmpleados(comboBoxEmpleados);
            comboBoxEmpleados.Enabled = true;
            bunifuButton1.Enabled = false;
        }
    }//finclase
}
