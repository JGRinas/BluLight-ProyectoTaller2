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
    public partial class Activar_Desact : Form
    {
        LSolicitud solicitud1;

        public Activar_Desact()
        {
            InitializeComponent();
            solicitud1 = new LSolicitud();
            textBoxBuscarId.MaxLength = 100000;
            textBoxBuscarDni.MaxLength = 8;
            solicitud1.rellenarComboBoxServicios(comboBoxServicios);
            solicitud1.rellenarDataGridSolicitudesFull(dataGridSolicitudes);
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int idFactura = Int32.Parse(solicitud1.filtrarIdSolicitud(senderGrid.Rows[e.RowIndex].Cells["columnIdSolicitud"].Value.ToString())[0]);
                int idServicio = Int32.Parse(solicitud1.filtrarIdSolicitud(senderGrid.Rows[e.RowIndex].Cells["columnIdSolicitud"].Value.ToString())[1]);
                if (senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Baja") {
                    if (MessageBox.Show("¿Está seguro que desea dar de BAJA la solicitud?", "Baja de solicitud", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    { 
                        solicitud1.altaBaja(dataGridSolicitudes, idFactura, idServicio);
                        dataGridSolicitudes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "Alta";
                    }
                }
                else
                {
                    if (MessageBox.Show("¿Está seguro que desea dar de ALTA la solicitud?", "Alta de solicitud", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    { 
                        dataGridSolicitudes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "Baja";
                        solicitud1.altaBaja(dataGridSolicitudes, idFactura, idServicio);
                    }
                }
                dataGridSolicitudes.Rows.Clear();
                solicitud1.rellenarDataGridSolicitudesFull(dataGridSolicitudes);

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
                dataGridSolicitudes.Rows.Clear();
                solicitud1.filtrarIdBaja(dataGridSolicitudes, textBoxBuscarId.Text, btnMostrarTodos, 1);
            }
            else
            {
                MessageBox.Show("El formato ingresado es incorrecto", "Formato incorrecto", MessageBoxButtons.OK);
            }

        }

        private void btnBuscarDni_Click(object sender, EventArgs e)
        {
            dataGridSolicitudes.Rows.Clear();
            solicitud1.filtrarDni(dataGridSolicitudes, Int32.Parse(textBoxBuscarDni.Text), btnMostrarTodos, 1);
        }

        private void btnFiltrarServicio_Click(object sender, EventArgs e)
        {
            if (comboBoxServicios.SelectedIndex > -1)
            {
                string nombreServicio = comboBoxServicios.SelectedItem.ToString();
                dataGridSolicitudes.Rows.Clear();
                solicitud1.filtrarServicio(dataGridSolicitudes, nombreServicio, btnMostrarTodos, 1);
            }
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            dataGridSolicitudes.Rows.Clear();
            solicitud1.rellenarDataGridSolicitudes(dataGridSolicitudes);
            btnMostrarTodos.Enabled = false;
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("La id de solicitud a ingresar debe respetar el formato 1-1-1, esto es: tres números, con un guión medio entre ellos, sin espacios.", "Información de formato", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
