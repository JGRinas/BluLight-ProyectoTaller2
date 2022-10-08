using CapaPresentacion.CapaData.Model;
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

namespace CapaPresentacion.CapaPresentacion.VistaAdmin.GestionServicioA
{
    public partial class GestionServiciosA : Form
    {
        LServicioA servicio;
        public GestionServiciosA()
        {
            InitializeComponent();
            servicio = new LServicioA();
            textBoxPrecio.MaxLength = 9;
            textBoxNombre.MaxLength = 20;
            servicio.rellenarComboBoxCategorias(comboBoxCategoria);
            servicio.rellenarDataGridServicio(bunifuDataGridViewServicio);
        }

        private void textBoxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            servicio.textBoxEvent.numberKeyPress(e);
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            servicio.textBoxEvent.textKeyPress(e);
        }

        private void buttonRegistrarAuditorio_Click(object sender, EventArgs e)
        {
            List<TextBox> textBoxes = new List<TextBox>();
            textBoxes.Add(textBoxNombre);
            textBoxes.Add(textBoxPrecio);
            if (buttonRegistrar.Text.Equals("Restablecer"))
            {
                this.restablecerCampos();
            }
            else
            {
                servicio.registrarServicio(textBoxes, comboBoxCategoria);
            }
            bunifuDataGridViewServicio.Rows.Clear();
            servicio.rellenarDataGridServicio(bunifuDataGridViewServicio);
        }

        private void bunifuDataGridViewServicio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var textBoxes = new List<TextBox>();
            textBoxes.Add(textBoxNombre);
            textBoxes.Add(textBoxPrecio);

            int id = Int32.Parse(bunifuDataGridViewServicio.CurrentRow.Cells[0].Value.ToString());

            servicio.obtenerServicio(id, textBoxes, comboBoxCategoria, bunifuDataGridViewServicio, buttonEliminar);
            buttonModificar.Enabled = true;
            buttonEliminar.Enabled = true;
            buttonRegistrar.Text = "Restablecer";
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            List<TextBox> textBoxes = new List<TextBox>();
            textBoxes.Add(textBoxNombre);
            textBoxes.Add(textBoxPrecio);
            servicio.modificarServicio(textBoxes, comboBoxCategoria);
            bunifuDataGridViewServicio.Rows.Clear();
            servicio.rellenarDataGridServicio(bunifuDataGridViewServicio);
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (buttonEliminar.Text.Equals("Eliminar"))
            {
                servicio.eliminarServicio();
            }
            else
            {
                servicio.restaurarServicio();
            }

            this.restablecerCampos();

        }

        private void restablecerCampos()
        {
            List<TextBox> textBoxes = new List<TextBox>();
            textBoxes.Add(textBoxNombre);
            textBoxes.Add(textBoxPrecio);
            servicio.restablecerCampos(textBoxes, comboBoxCategoria);
            buttonRegistrar.Text = "Registrar";
            buttonModificar.Enabled = false;
            buttonEliminar.Enabled = false;
            bunifuDataGridViewServicio.Rows.Clear();
            servicio.rellenarDataGridServicio(bunifuDataGridViewServicio);
        }

    }
}
