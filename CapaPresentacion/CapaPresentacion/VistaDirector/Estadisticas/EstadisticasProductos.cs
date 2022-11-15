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

namespace Proyecto2022.CapaPresentacion.VistaAdmin.Estadisticas
{
    public partial class EstadisticasProductos : Form
    {
        LEstadistica estadistica;
        public EstadisticasProductos()
        {
            InitializeComponent();
            estadistica = new LEstadistica();
            dateTimePickerDesde.Value = DateTime.Now.AddMonths(-1);
            dateTimePickerHasta.Value = DateTime.Now;
            List<DateTimePicker> dateTime = new List<DateTimePicker>();
            dateTime.Add(dateTimePickerDesde);
            dateTime.Add(dateTimePickerHasta);
            estadistica.rellenarComboBoxProductos(comboBoxProductos);
            estadistica.inicializarChartProductos(dateTime, chartProductosVendidos);
        }


        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            List<DateTimePicker> dateTime = new List<DateTimePicker>();
            dateTime.Add(dateTimePickerDesde);
            dateTime.Add(dateTimePickerHasta);
            if (dateTime[0].Value < dateTime[1].Value && comboBoxProductos.SelectedIndex != -1)
            {
                if (comboBoxProductos.SelectedIndex == 0)
                    estadistica.inicializarChartProductos(dateTime, chartProductosVendidos);
                
                else
                    estadistica.inicializarChartProductosConFiltro(dateTime, chartProductosVendidos, comboBoxProductos);
                
            }
            else
            {
                if(dateTime[0].Value >= dateTime[1].Value)
                MessageBox.Show("la fecha 'Desde' debe ser menor que la fecha 'Hasta'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                if (comboBoxProductos.SelectedIndex == -1)
                    MessageBox.Show("Seleccione un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var chartImage = new MemoryStream();
            chartProductosVendidos.SaveImage(chartImage, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
            MyGlobals.imagenChartProductos.Add(iTextSharp.text.Image.GetInstance(chartImage.GetBuffer()));
            if (comboBoxProductos.SelectedIndex != -1)
            {
                MyGlobals.titulosImagenChartProductos.Add(comboBoxProductos.SelectedItem.ToString() + " - Desde:" + dateTimePickerDesde.Value + " - Hasta:" + dateTimePickerHasta.Value);
            }
            else
            {
                MyGlobals.titulosImagenChartProductos.Add("Todos" + " - Desde:" + dateTimePickerDesde.Value + " - Hasta:" + dateTimePickerHasta.Value);
            }
              
            MessageBox.Show("Gráfico anexado al informe", "Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonImprimirInforme_Click_1(object sender, EventArgs e)
        {
            if (MyGlobals.imagenChartProductos.Count() > 0)
            {
                estadistica.generarInformeProductos();
            }
            else
            {
                MessageBox.Show("Debe anexar gráficos al informe antes de imprimir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
    }
}
