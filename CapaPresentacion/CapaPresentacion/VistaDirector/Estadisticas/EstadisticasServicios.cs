using CapaPresentacion.CapaLogica.LDirector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Proyecto2022.CapaPresentacion.VistaAdmin.Estadisticas
{
    public partial class EstadisticasServicios : Form
    {
        LStatServicios statServicios1;
        public EstadisticasServicios()
        {
            InitializeComponent();
            statServicios1 = new LStatServicios();
            statServicios1.cargarCheckedListBoxCategorias(checkedListBoxCategorias);
            statServicios1.generarGraficoGlobales(chartGlobales);

        }

        private void checkedListBoxCategoria_SelectedValueChanged(object sender, EventArgs e)
        {
            //checkedListBoxCategorias.
        }

        private void checkBoxTodos_CheckStateChanged(object sender, EventArgs e)
        {
            int i;
            if (checkBoxTodos.Checked)
            {

                for (i = 0; i < checkedListBoxCategorias.Items.Count; i++)
                {
                    checkedListBoxCategorias.SetItemChecked(i, true);
                }
            }
            else
            {
                for (i = 0; i < checkedListBoxCategorias.Items.Count; i++)
                {
                    checkedListBoxCategorias.SetItemChecked(i, false);
                }
            }
        }
    }
}
