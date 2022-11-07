﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.CapaLogica.LJefeLab;
using CapaPresentacion.CapaPresentacion.VistaJefeLaboratorio.GestionSolicitudes;

namespace Proyecto2022.CapaPresentacion.VistaJefeLaboratorio.GestionSolicitudes
{
    public partial class SolicitudesEntregadas : Form
    {
        LSolicitud solicitud1;

        public SolicitudesEntregadas()
        {
            InitializeComponent();
            solicitud1 = new LSolicitud();
            textBoxBuscarId.MaxLength = 100000;
            textBoxBuscarDni.MaxLength = 8;
            solicitud1.rellenarComboBoxServicios(comboBoxServicios);
            solicitud1.rellenarDataGridSolicitudesEntregadas(dataGridSolicitudes);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La id de solicitud a ingresar debe respetar el formato 1-1-1, esto es: tres números, con un guión medio entre ellos, sin espacios.", "Información de formato", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridSolicitudes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                Form promover_3 = new Promover_3(senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString());

                //promover_3.BringToFront();
                promover_3.ShowDialog();
            }
            dataGridSolicitudes.Rows.Clear();
            solicitud1.rellenarDataGridSolicitudesEntregadas(dataGridSolicitudes);
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
                solicitud1.filtrarId(dataGridSolicitudes, textBoxBuscarId.Text, btnMostrarTodos, 3);
            }
            else
            {
                MessageBox.Show("El formato ingresado es incorrecto", "Formato incorrecto", MessageBoxButtons.OK);
            }

        }

        private void btnBuscarDni_Click(object sender, EventArgs e)
        {
            dataGridSolicitudes.Rows.Clear();
            solicitud1.filtrarDni(dataGridSolicitudes, Int32.Parse(textBoxBuscarDni.Text), btnMostrarTodos, 3);
            
        }

        private void btnFiltrarServicio_Click(object sender, EventArgs e)
        {
            if (comboBoxServicios.SelectedIndex > -1)
            {
                string nombreServicio = comboBoxServicios.SelectedItem.ToString();
                dataGridSolicitudes.Rows.Clear();
                solicitud1.filtrarServicio(dataGridSolicitudes, nombreServicio, btnMostrarTodos, 3);
            }
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            dataGridSolicitudes.Rows.Clear();
            solicitud1.rellenarDataGridSolicitudesEntregadas(dataGridSolicitudes);
            btnMostrarTodos.Enabled = false;
        }

    }//finclase
}
