using CapaLogica.LAdmin;
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

namespace Proyecto2022.CapaPresentacion.VistaJefeLaboratorio.GestionCursos
{
    public partial class GestionJornadas : Form
    {
        LJornadaJefeLab jornada1;

        //constructor
        public GestionJornadas()
        {
            InitializeComponent();
            jornada1 = new LJornadaJefeLab();
            jornada1.rellenarDataGridJornadas(dataGridJornadas);
            jornada1.rellenarComboBoxAuditorios(comboBoxAuditorios);
            textBoxNombre.MaxLength = 150;
            textBoxCupo.MaxLength = 3;
            labelIdJornada.Text = "";
        }

        private void btnRegistrarJornada_Click(object sender, EventArgs e)
        {
            List<TextBox> textBoxes = new List<TextBox>();
            textBoxes.Add(textBoxNombre);
            textBoxes.Add(textBoxCupo);

            List<DateTimePicker> fechaHora = new List<DateTimePicker>();
            fechaHora.Add(dateTimePickerFecha);
            fechaHora.Add(dateTimePickerHora);


            if (btnRegistrarJornada.Text.Equals("Registrar"))
            {
                jornada1.agregarJornada(textBoxes, fechaHora, comboBoxAuditorios);
                dataGridJornadas.Rows.Clear();
                jornada1.rellenarDataGridJornadasInactivas(dataGridJornadas);
            }
            else
            {
                textBoxNombre.Text = "";
                textBoxCupo.Text = "";
                comboBoxAuditorios.SelectedIndex = -1;
                btnModificarJornada.Enabled = false;
                btnEliminarJornada.Enabled = false;
                btnRegistrarJornada.Text = "Registrar";
                btnActivarJornada.Enabled = false;

            }

            dataGridJornadas.Rows.Clear();
            jornada1.rellenarDataGridJornadas(dataGridJornadas);
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //puede tener tanto números como letras, dejar así
        }

        private void textBoxCupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            jornada1.textBoxEvent.numberKeyPress(e);
        }

        private void dataGridJornadas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridJornadas.CurrentRow != null)
            {
                List<TextBox> textBoxes = new List<TextBox>();
                textBoxes.Add(textBoxNombre);
                textBoxes.Add(textBoxCupo);

                List<DateTimePicker> fechaHora = new List<DateTimePicker>();
                fechaHora.Add(dateTimePickerFecha);
                fechaHora.Add(dateTimePickerHora);

                List<Button> botones = new List<Button>();
                botones.Add(btnRegistrarJornada);
                botones.Add(btnModificarJornada);
                botones.Add(btnEliminarJornada);
                botones.Add(btnActivarJornada);

                jornada1.obtenerJornada(textBoxes, comboBoxAuditorios, dataGridJornadas, labelIdJornada, botones);


                btnRegistrarJornada.Text = "Restaurar campos";
            }
           
            
        }

        private void btnEliminarJornada_Click(object sender, EventArgs e)
        {
            List<TextBox> listTextBoxes = new List<TextBox>();
            listTextBoxes.Add(textBoxNombre);
            listTextBoxes.Add(textBoxCupo);

            List<DateTimePicker> listDateTime = new List<DateTimePicker>();
            listDateTime.Add(dateTimePickerFecha);
            listDateTime.Add(dateTimePickerHora);
           
            jornada1.eliminarJornada(Int32.Parse(labelIdJornada.Text), listTextBoxes, listDateTime, comboBoxAuditorios);
            dataGridJornadas.Rows.Clear();
            jornada1.rellenarDataGridJornadasInactivas(dataGridJornadas);
        }

        private void labelIdJornada_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarJornada_Click(object sender, EventArgs e)
        {
            List<TextBox> listTextBoxes = new List<TextBox>();
            listTextBoxes.Add(textBoxNombre);
            listTextBoxes.Add(textBoxCupo);

            List<DateTimePicker> listDateTime = new List<DateTimePicker>();
            listDateTime.Add(dateTimePickerFecha);
            listDateTime.Add(dateTimePickerHora);

            jornada1.modificarJornada(Int32.Parse(labelIdJornada.Text), listTextBoxes, listDateTime, comboBoxAuditorios);
            dataGridJornadas.Rows.Clear();
            jornada1.rellenarDataGridJornadasInactivas(dataGridJornadas);
        }

        private void dataGridJornadas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelIdJornada_Click_1(object sender, EventArgs e)
        {

        }

        private void btnMostrarInactivas_Click(object sender, EventArgs e)
        {
            if (btnMostrarInactivas.Text == "Mostrar Inactivas")
            {
                btnMostrarInactivas.Text = "Mostrar Activas";
                dataGridJornadas.Rows.Clear();
                jornada1.rellenarDataGridJornadasInactivas(dataGridJornadas);
            }
            else
            {
                btnMostrarInactivas.Text = "Mostrar Inactivas";
                dataGridJornadas.Rows.Clear();
                jornada1.rellenarDataGridJornadas(dataGridJornadas);
            }
        }

        private void btnActivarJornada_Click(object sender, EventArgs e)
        {
             int idJornadaSeleccionada = Int32.Parse(labelIdJornada.Text);
             jornada1.activarJornada(idJornadaSeleccionada);
             dataGridJornadas.Rows.Clear();
             jornada1.rellenarDataGridJornadasInactivas(dataGridJornadas);

        }
    }
}
