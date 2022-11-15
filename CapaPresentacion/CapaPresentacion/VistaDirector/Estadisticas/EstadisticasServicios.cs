using CapaLogica;
using CapaPresentacion.CapaLogica.LDirector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static LinqToDB.Reflection.Methods.LinqToDB.Insert;
using iTextSharp.text.pdf;
using iTextSharp.text;

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
            //checkedListBoxCategorias.SetItemCheckState(0, CheckState.Checked);
            //checkedListBoxCategorias.SetItemCheckState(1, CheckState.Checked);
            //checkedListBoxAnio.SetItemCheckState(0, CheckState.Checked);
            //checkedListBoxAnio.SetItemCheckState(1, CheckState.Checked);
            radioNro.Checked = false;
            //statServicios1.generarGraficoGlobales(chartGlobales, checkedListBoxCategorias, checkedListBoxAnio, radioNro);

            statServicios1.cargarCheckedListBoxCategorias(checkedListBoxCatTorta);
            checkedListBoxCatTorta.SetItemCheckState(0, CheckState.Checked);
            checkedListBoxCatTorta.SetItemCheckState(1, CheckState.Checked);
            checkedListBoxCatTorta.SetItemCheckState(2, CheckState.Checked);
            checkedListBoxCatTorta.SetItemCheckState(3, CheckState.Checked);
            checkedListBoxCatTorta.SetItemCheckState(4, CheckState.Checked);
            checkedListBoxCatTorta.SetItemCheckState(5, CheckState.Checked);
            checkedListBoxCatTorta.SetItemCheckState(6, CheckState.Checked);
            radio2022.Checked = true;

            radioNroTorta.Checked = true;
            chartTorta.Series.Clear();
            chartTorta.Titles.Clear();
            statServicios1.generarGraficoTorta(chartTorta, checkedListBoxCatTorta, radio2022, radioNroTorta);


        }

        private void checkedListBoxCategoria_SelectedValueChanged(object sender, EventArgs e)
        {

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

        private void checkBoxTodosTorta_CheckStateChanged(object sender, EventArgs e)
        {
            int i;
            if (checkBoxTodos.Checked)
            {

                for (i = 0; i < checkedListBoxCategorias.Items.Count; i++)
                {
                    checkedListBoxCatTorta.SetItemChecked(i, true);
                }
            }
            else
            {
                for (i = 0; i < checkedListBoxCategorias.Items.Count; i++)
                {
                    checkedListBoxCatTorta.SetItemChecked(i, false);
                }
            }
        }

        private void checkedListBoxAnio_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void radioNro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBoxAnioTorta_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if ((radio2022.Checked || radio2021.Checked) && checkedListBoxCatTorta.CheckedItems.Count > 0 && (radioDineroTorta.Checked || radioNroTorta.Checked))
            {
                chartTorta.Series.Clear();
                chartTorta.Titles.Clear();

                chartTorta.ChartAreas[0].RecalculateAxesScale();

                statServicios1.generarGraficoTorta(chartTorta, checkedListBoxCatTorta, radio2022, radioNroTorta);
            }
        }

        private void checkedListBoxCatTorta_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }

        private void radioNroTorta_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (checkedListBoxAnio.SelectedItems.Count > 0 && checkedListBoxCategorias.CheckedItems.Count > 0 && (radioDinero.Checked || radioNro.Checked))
            {
                chartGlobales.Series.Clear();
                chartGlobales.Titles.Clear();

                chartGlobales.ChartAreas[0].RecalculateAxesScale();

                statServicios1.generarGraficoGlobales(chartGlobales, checkedListBoxCategorias, checkedListBoxAnio, radioNro);
            }
        }

        private void btnGenerarTorta_Click(object sender, EventArgs e)
        {
            if ((radio2022.Checked || radio2021.Checked) && checkedListBoxCatTorta.CheckedItems.Count > 0 && (radioDineroTorta.Checked || radioNroTorta.Checked))
            {
                chartTorta.Series.Clear();
                chartTorta.Titles.Clear();

                chartTorta.ChartAreas[0].RecalculateAxesScale();

                statServicios1.generarGraficoTorta(chartTorta, checkedListBoxCatTorta, radio2022, radioNroTorta);
            }
        }

        private void btnAnexar1_Click(object sender, EventArgs e)
        {
            var chartImage = new MemoryStream();
            chartGlobales.SaveImage(chartImage, ChartImageFormat.Png);
            MyGlobals.imagenChartGlobales.Add(iTextSharp.text.Image.GetInstance(chartImage.GetBuffer()));
            MessageBox.Show("Gráfico anexado al informe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnAnexar2_Click(object sender, EventArgs e)
        {
            var chartImage = new MemoryStream();
            chartTorta.SaveImage(chartImage, ChartImageFormat.Png);
            MyGlobals.imagenChartTorta.Add(iTextSharp.text.Image.GetInstance(chartImage.GetBuffer()));
            MessageBox.Show("Gráfico anexado al informe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnGenerarInforme_Click(object sender, EventArgs e)
        {
            statServicios1.generarInformeServicios(chartGlobales);
        }
    }
}
