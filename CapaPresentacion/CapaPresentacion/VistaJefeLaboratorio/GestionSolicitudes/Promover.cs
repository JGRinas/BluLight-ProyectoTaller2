using CapaLogica.Libreria;
using CapaPresentacion.CapaData.Model;
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
    public partial class Promover : Form
    {
        LSolicitud solicitud1;
        string idSolicitud;

        public Promover(string pidSolicitud)
        {
            InitializeComponent();
            idSolicitud = pidSolicitud;
            solicitud1 = new LSolicitud();
            solicitud1.rellenarComboBoxEmpleados(comboBoxEmpleados);
        }

        private void Promover_Load(object sender, EventArgs e)
        {

        }


        private void btnPromover_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(this.idSolicitud[1].ToString(), "BIEN AHI", MessageBoxButtons.OK);
            string textoEmpleado = comboBoxEmpleados.Text;
            solicitud1.promoverPendiente(this.idSolicitud, textoEmpleado);
            //this.Parent.Refresh();
            
        }

        private void comboBoxEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEmpleados.SelectedIndex != -1)
            {
                btnPromover.Enabled = true;
                btnEntregado.Enabled = true;
            }
        }

        private void btnEntregado_Click(object sender, EventArgs e)
        {
            string textoEmpleado = comboBoxEmpleados.Text;
            solicitud1.estadoEntregado(this.idSolicitud, textoEmpleado);
        }

    }
}
