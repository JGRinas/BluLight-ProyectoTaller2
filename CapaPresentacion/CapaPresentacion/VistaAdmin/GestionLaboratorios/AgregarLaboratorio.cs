using CapaPresentacion.CapaLogica.LAdmin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto2022.CapaPresentacion.VistaAdmin.GestionLaboratorios
{
    public partial class AgregarLaboratorio : Form
    {
        LLaboratorioA lab;
        public AgregarLaboratorio()
        {
            InitializeComponent();
            lab = new LLaboratorioA();
            lab.rellenarDataGridLab(dataGridLaboratorio);
        }

        private void textBoxNombreLaboratorio_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void buttonRegistrarLaboratorio_Click(object sender, EventArgs e)
        {
            if (buttonRegistrarLaboratorio.Text.Equals("Registrar")) lab.registrarLaboratorio(textBoxNombreLaboratorio);
            else
            {
                textBoxNombreLaboratorio.Text = "";
                buttonRegistrarLaboratorio.Text = "Registrar";
                buttonModificarLaboratorio.Enabled = false;
                buttonEliminar.Enabled = false;
                buttonEliminar.Text = "Eliminar";
            }

                dataGridLaboratorio.Rows.Clear();
            lab.rellenarDataGridLab(dataGridLaboratorio);
        }

        private void dataGridLaboratorio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridLaboratorio.CurrentRow != null)
            {
                lab.obtenerLaboratorio(textBoxNombreLaboratorio, dataGridLaboratorio);
                buttonRegistrarLaboratorio.Text = "Restablecer";
                buttonModificarLaboratorio.Enabled = true;
                buttonEliminar.Enabled = true;
                if (dataGridLaboratorio.CurrentRow.Cells["columnActivo"].Value.ToString().Equals("No"))
                {
                    buttonEliminar.Text = "Restaurar";
                }
                else
                {
                    buttonEliminar.Text = "Eliminar";
                }
            }
            
        }

        private void buttonModificarLaboratorio_Click(object sender, EventArgs e)
        {
            lab.modificarLaboratorio(textBoxNombreLaboratorio);
            dataGridLaboratorio.Rows.Clear();
            lab.rellenarDataGridLab(dataGridLaboratorio);
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (buttonEliminar.Text.Equals("Restaurar"))
            {
                lab.restaurarLaboratorio();
            }
            else
            {
                lab.eliminarLaboratorio();
            }
            dataGridLaboratorio.Rows.Clear();
            lab.rellenarDataGridLab(dataGridLaboratorio);
        }
    }
}
