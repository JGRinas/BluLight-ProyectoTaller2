using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms.Helpers.Transitions;
using CapaPresentacion.CapaData.Model;
using CapaPresentacion.CapaLogica.LJefeLab;
using CapaPresentacion.CapaPresentacion.VistaJefeLaboratorio.GestionSolicitudes;

namespace Proyecto2022.CapaPresentacion.VistaJefeLaboratorio.GestionSolicitudes
{
    public partial class SolicitudesPendientes : Form
    {
        LSolicitud solicitud1;

        //constructor
        public SolicitudesPendientes()
        {
            InitializeComponent();
            solicitud1 = new LSolicitud();
            textBoxBuscarId.MaxLength = 100000;
            textBoxBuscarDni.MaxLength = 8;
            solicitud1.rellenarComboBoxServicios(comboBoxServicios);
            solicitud1.rellenarDataGridSolicitudes(dataGridSolicitudes);
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                Form promover = new Promover(senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                //promover.FormBorderStyle = FormBorderStyle.None;
                promover.BringToFront();
                promover.Show();
                //promover.Parent = this;
            }
        }

        private void SolicitudesActivas_Load(object sender, EventArgs e)
        {

        }

        private void textBoxBuscarId_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solicitud1.textBoxEvent.numberKeyPress(e);
        }

        private void textBoxBuscarDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            solicitud1.textBoxEvent.numberKeyPress(e);
        }

        private void btnBuscarId_Click(object sender, EventArgs e)
        {
            if (solicitud1.formatoIdSolicitud(textBoxBuscarId.Text)) //validación del formato
            {
                solicitud1.filtrarId(dataGridSolicitudes, textBoxBuscarId.Text);
                dataGridSolicitudes.Rows.Clear();
                solicitud1.rellenarDataGridSolicitudes(dataGridSolicitudes);
            }
            else
            {
                MessageBox.Show("El formato ingresado es incorrecto", "Formato incorrecto", MessageBoxButtons.OK);
            }
            
        }

        private void btnBuscarDni_Click(object sender, EventArgs e)
        {
            
            solicitud1.filtrarDni(dataGridSolicitudes, Int32.Parse(textBoxBuscarDni.Text));
            dataGridSolicitudes.Rows.Clear();
        }

        private void btnFiltrarServicio_Click(object sender, EventArgs e)
        {
            int idServicio = comboBoxServicios.SelectedIndex - 1;
            dataGridSolicitudes.Rows.Clear();
            solicitud1.filtrarServicio(dataGridSolicitudes, idServicio);
     
            
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            dataGridSolicitudes.Rows.Clear();
            solicitud1.rellenarDataGridSolicitudes(dataGridSolicitudes);
        }
    }
}
