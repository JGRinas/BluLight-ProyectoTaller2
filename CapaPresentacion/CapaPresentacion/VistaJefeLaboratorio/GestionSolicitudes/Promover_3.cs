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
            solicitud1.rellenarComboBoxEmpSeleccionado(comboBoxEmpleados, idSolicitud);
            InitializeComponent();
        }
    }
}
