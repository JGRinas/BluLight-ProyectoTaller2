using CapaLogica.LVendedor;
using CapaPresentacion.CapaLogica.LJefeLab;
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
    public partial class Inscribir : Form
    {
        LJornadaRecep jornada1;
        LPersona persona1;

        //constructor
        public Inscribir()
        {
            InitializeComponent();
            jornada1 = new LJornadaRecep();
            persona1 = new LPersona();
            jornada1.rellenarDataGridJornadas(datagridJornadas);
           
            textBoxBuscarDni.MaxLength = 9;
        }

        private void btnBuscarDni_Click(object sender, EventArgs e)
        {
            if (!textBoxBuscarDni.Text.Equals(""))
            {
                List<Label> LabelsPersona = new List<Label>();
                LabelsPersona.Add(labelDni);
                LabelsPersona.Add(labelNombre);

                persona1.obtenerClienteEnButton(LabelsPersona, textBoxBuscarDni);
            }
            else
            {
                MessageBox.Show("Ingrese un DNI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
        }

        private void datagridJornadas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagridJornadas.CurrentRow != null)
            {
                jornada1.buscarJornadaDatagrid(labelJornada, datagridJornadas);
            }
          
        }

        private void btnInscribirJornada_Click(object sender, EventArgs e)
        {
            if (!labelDni.Text.Equals("") && !labelJornada.Text.Equals(""))
            {
                jornada1.inscribirAJornada(labelDni, labelJornada);
                datagridJornadas.Rows.Clear();
                jornada1.rellenarDataGridJornadas(datagridJornadas);
            }
            else
            {
                if(labelDni.Text.Equals(""))
                MessageBox.Show("Ingrese un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                if(labelJornada.Text.Equals(""))
                    MessageBox.Show("Ingrese una jornada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBoxBuscarDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            jornada1.textBoxEvent.numberKeyPress(e);
        }

        private void textBoxDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            jornada1.textBoxEvent.numberKeyPress(e);
        }

        private void btnAgregarPersona_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            jornada1.textBoxEvent.textKeyPress(e);
        }

        private void textBoxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            jornada1.textBoxEvent.textKeyPress(e);
        }
    }
}
