using CapaPresentacion.CapaData.Model;
using CapaPresentacion.CapaLogica.LRecepcionistaok;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.VistaRecepcionista.Jornadas
{
    public partial class Bajas : Form
    {
        LJornadaRecep jornada1;
        LPersona persona1;

        public Bajas()
        {
            InitializeComponent();
            jornada1 = new LJornadaRecep();
            persona1 = new LPersona();
            jornada1.rellenarDataGridJornadas(datagridJornadas);
            textBoxBuscarDni.MaxLength = 9;
            textBoxJornada.MaxLength = 30;
        }

        private void datagridJornadas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagridJornadas.CurrentRow != null)
            {
                jornada1.buscarJornadaDatagrid(labelJornada, datagridJornadas);
                btnBajaJornada.Enabled = true;
            }
                
        }

        private void btnBuscarDni_Click(object sender, EventArgs e)
        {
            if (!textBoxBuscarDni.Text.Equals(""))
            {
                List<Label> LabelsPersona = new List<Label>();
                LabelsPersona.Add(labelDni);
                LabelsPersona.Add(labelNombre);

                persona1.obtenerClienteEnButton(LabelsPersona, textBoxBuscarDni);
                btnBajaJornada.Enabled = true;
            }
            else
            {
                MessageBox.Show("Ingrese un DNI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void btnBuscarJornada_Click(object sender, EventArgs e)
        {
            if (!textBoxJornada.Text.Equals(""))
            {
                jornada1.buscarJornadaNombre(textBoxJornada, labelJornada);
                btnBajaJornada.Enabled = true;
            }
            else
            {
                MessageBox.Show("Ingrese una jornada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void btnBajaJornada_Click(object sender, EventArgs e)
        {
            jornada1.bajaJornada(labelDni, labelJornada);
        }

        private void textBoxBuscarDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            jornada1.textBoxEvent.numberKeyPress(e);
        }
    }
}
