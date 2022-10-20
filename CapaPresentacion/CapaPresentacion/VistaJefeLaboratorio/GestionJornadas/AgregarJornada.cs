using CapaLogica.LAdmin;
using CapaPresentacion.CapaLogica.LJefeLab;
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
    public partial class AgregarJornada : Form
    {
        LJornada jornada1;

        //constructor
        public AgregarJornada()
        {
            InitializeComponent();
            jornada1 = new LJornada();
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
            }
            else
            {
                textBoxNombre.Text = "";
                textBoxCupo.Text = "";
                comboBoxAuditorios.SelectedIndex = -1;
                btnModificarJornada.Enabled = false;
                btnEliminarJornada.Enabled = false;
                btnRegistrarJornada.Text = "Registrar";

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

            jornada1.obtenerJornada(textBoxes, comboBoxAuditorios, dataGridJornadas, labelIdJornada);

            btnModificarJornada.Enabled = true;
            btnEliminarJornada.Enabled = true;
            btnRegistrarJornada.Text = "Restaurar";
            
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
        }
    }
}
