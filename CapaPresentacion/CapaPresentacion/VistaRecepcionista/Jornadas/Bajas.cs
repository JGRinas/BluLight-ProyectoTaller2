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
            textBoxBuscarDni.MaxLength = 8;
            textBoxJornada.MaxLength = 30;
        }

        private void datagridJornadas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            jornada1.buscarJornadaDatagrid(labelJornada, datagridJornadas);
        }

        private void btnBuscarDni_Click(object sender, EventArgs e)
        {
            List<Label> LabelsPersona = new List<Label>();
            LabelsPersona.Add(labelDni);
            LabelsPersona.Add(labelNombre);



            persona1.obtenerClienteEnButton(LabelsPersona, textBoxBuscarDni);
        }
    }
}
