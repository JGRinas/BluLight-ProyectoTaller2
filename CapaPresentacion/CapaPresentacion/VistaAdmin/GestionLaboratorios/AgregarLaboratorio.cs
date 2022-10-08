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
            }

                dataGridLaboratorio.Rows.Clear();
            lab.rellenarDataGridLab(dataGridLaboratorio);
        }

        private void dataGridLaboratorio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lab.obtenerLaboratorio(textBoxNombreLaboratorio, dataGridLaboratorio);
            buttonRegistrarLaboratorio.Text = "Restaurar";
            buttonModificarLaboratorio.Enabled = true;
        }

        private void buttonModificarLaboratorio_Click(object sender, EventArgs e)
        {
            lab.modificarLaboratorio(textBoxNombreLaboratorio);
            dataGridLaboratorio.Rows.Clear();
            lab.rellenarDataGridLab(dataGridLaboratorio);
        }
    }
}
