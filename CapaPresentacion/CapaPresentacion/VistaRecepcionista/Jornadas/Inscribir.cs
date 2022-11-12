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
            textBoxNombre.MaxLength = 30;
            textBoxApellido.MaxLength = 30;
        }

        private void btnBuscarDni_Click(object sender, EventArgs e)
        {
            List<Label> LabelsPersona = new List<Label>();
            LabelsPersona.Add(labelDni);
            LabelsPersona.Add(labelNombre);

            

            persona1.obtenerClienteEnButton(LabelsPersona, textBoxBuscarDni);
        }

        private void datagridJornadas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            jornada1.buscarJornadaDatagrid(labelJornada, datagridJornadas);
        }

        private void btnInscribirJornada_Click(object sender, EventArgs e)
        {
            jornada1.inscribirAJornada(labelDni, labelJornada);
            datagridJornadas.Rows.Clear();
            jornada1.rellenarDataGridJornadas(datagridJornadas);
        }
    }
}
