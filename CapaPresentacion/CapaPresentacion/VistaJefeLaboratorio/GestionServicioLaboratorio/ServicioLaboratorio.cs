using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using CapaLogica.Libreria;
using CapaPresentacion.CapaPresentacion.VistaJefeLaboratorio.GestionSolicitudes;

namespace Proyecto2022.CapaPresentacion.VistaJefeLaboratorio.GestionServicios
{
    public partial class ServicioLaboratorio : Form
    {
        LServicio servicio;

        //constructor
        public ServicioLaboratorio()
        {
            InitializeComponent();
            servicio = new LServicio();
            servicio.rellenarDataGridServicioDelLab(DataGridServicioDelLab);
            servicio.rellenarComboBoxServicios(comboBoxServicios);
            servicio.rellenarComboBoxCategoria(comboBoxCategoria);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
           
            int idCategoria = Int16.Parse(comboBoxCategoria.SelectedItem.ToString().Substring(0, 1));

            if (idCategoria == 0) {
                comboBoxServicios.Items.Clear();
                servicio.rellenarComboBoxServicios(comboBoxServicios);
            }
            else
            {
                servicio.rellenarComboBoxServiciosFiltro(comboBoxServicios, idCategoria);
            }
            
            
        }

        private void btnRegistrarServicio_Click(object sender, EventArgs e)
        {
            int idServicio = Int32.Parse(comboBoxServicios.SelectedItem.ToString().Substring(0, 1));
            int idLaboratorio = (int)MyGlobals.empleado.idLab;
            servicio.agregarServicioLaboratorio(idServicio,idLaboratorio);
            DataGridServicioDelLab.Rows.Clear();
            servicio.rellenarDataGridServicioDelLab(DataGridServicioDelLab);
        }

        private void DataGridServicioDelLab_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewButtonCell &&
                e.RowIndex >= 0)
            {
                
                int idServicio = Int32.Parse(senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                servicio.eliminarServicio(idServicio);
                DataGridServicioDelLab.Rows.Clear();
                servicio.rellenarDataGridServicioDelLab(DataGridServicioDelLab);
            }
        }
    }
}
