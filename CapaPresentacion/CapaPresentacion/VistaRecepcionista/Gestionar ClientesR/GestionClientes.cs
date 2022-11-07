using CapaLogica.LVendedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.VistaRecepcionista.Gestionar_ClientesR
{
    public partial class GestionClientes : Form
    {
        LClient client;
        public GestionClientes()
        {
            InitializeComponent();

            textBoxName.MaxLength = 49;
            textBoxDni.MaxLength = 9;
            textBoxDniBuscar.MaxLength = 9;
            textBoxEmail.MaxLength = 49;
            textBoxSurname.MaxLength = 49;
            textBoxPhone.MaxLength = 49;
            textBoxAddress.MaxLength = 49;

            client = new LClient();
            client.rellenarDataGridCliente(dataGridViewClientes);
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            List<TextBox> TextBoxClient = new List<TextBox>();
            TextBoxClient.Add(textBoxName);
            TextBoxClient.Add(textBoxSurname);
            TextBoxClient.Add(textBoxDni);
            TextBoxClient.Add(textBoxAddress);
            TextBoxClient.Add(textBoxEmail);
            TextBoxClient.Add(textBoxPhone);

            List<Button> buttons = new List<Button>();
            buttons.Add(buttonRegistrar);
            buttons.Add(buttonModificarCliente);
            buttons.Add(buttonEliminarCliente);

            if (buttonRegistrar.Text.Equals("Registrar"))
            {
                client.registrarCliente(TextBoxClient, buttons);
            }
            else
            {
                client.reestablecerCampos(TextBoxClient, buttons);
            }

            dataGridViewClientes.Rows.Clear();
            client.rellenarDataGridCliente(dataGridViewClientes);
        }

        private void buttonModificarCliente_Click(object sender, EventArgs e)
        {
            List<TextBox> TextBoxClient = new List<TextBox>();
            TextBoxClient.Add(textBoxName);
            TextBoxClient.Add(textBoxSurname);
            TextBoxClient.Add(textBoxDni);
            TextBoxClient.Add(textBoxAddress);
            TextBoxClient.Add(textBoxEmail);
            TextBoxClient.Add(textBoxPhone);

            List<Button> buttons = new List<Button>();
            buttons.Add(buttonRegistrar);
            buttons.Add(buttonModificarCliente);
            buttons.Add(buttonEliminarCliente);

            client.modificarCliente(TextBoxClient, buttons);

            dataGridViewClientes.Rows.Clear();
            client.rellenarDataGridCliente(dataGridViewClientes);
        }

        private void buttonEliminarCliente_Click(object sender, EventArgs e)
        {
            if (buttonEliminarCliente.Text.Equals("Eliminar"))
            {
                client.eliminarCliente();
            }
            else
            {
                client.restaurarCliente();
            }

            List<TextBox> TextBoxClient = new List<TextBox>();
            TextBoxClient.Add(textBoxName);
            TextBoxClient.Add(textBoxSurname);
            TextBoxClient.Add(textBoxDni);
            TextBoxClient.Add(textBoxAddress);
            TextBoxClient.Add(textBoxEmail);
            TextBoxClient.Add(textBoxPhone);

            List<Button> buttons = new List<Button>();
            buttons.Add(buttonRegistrar);
            buttons.Add(buttonModificarCliente);
            buttons.Add(buttonEliminarCliente);

            client.reestablecerCampos(TextBoxClient, buttons);

            dataGridViewClientes.Rows.Clear();
            client.rellenarDataGridCliente(dataGridViewClientes);
        }

        private void buttonBuscarCliente_Click(object sender, EventArgs e)
        {
            List<TextBox> TextBoxClient = new List<TextBox>();
            TextBoxClient.Add(textBoxName);
            TextBoxClient.Add(textBoxSurname);
            TextBoxClient.Add(textBoxDni);
            TextBoxClient.Add(textBoxAddress);
            TextBoxClient.Add(textBoxEmail);
            TextBoxClient.Add(textBoxPhone);
            TextBoxClient.Add(textBoxDniBuscar);

            List<Button> buttons = new List<Button>();
            buttons.Add(buttonRegistrar);
            buttons.Add(buttonModificarCliente);
            buttons.Add(buttonEliminarCliente);

            client.obtenerClienteEnButton(TextBoxClient, buttons);
        }

        private void dataGridViewClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<TextBox> TextBoxClient = new List<TextBox>();
            TextBoxClient.Add(textBoxName);
            TextBoxClient.Add(textBoxSurname);
            TextBoxClient.Add(textBoxDni);
            TextBoxClient.Add(textBoxAddress);
            TextBoxClient.Add(textBoxEmail);
            TextBoxClient.Add(textBoxPhone);
            TextBoxClient.Add(textBoxDniBuscar);

            List<Button> buttons = new List<Button>();
            buttons.Add(buttonRegistrar);
            buttons.Add(buttonModificarCliente);
            buttons.Add(buttonEliminarCliente);

            client.obtenerClienteEnDataGrid(TextBoxClient, buttons, dataGridViewClientes);
        }

        private void textBoxDniBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            client.textBoxEvent.numberKeyPress(e);
        }

        private void textBoxDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            client.textBoxEvent.numberKeyPress(e);
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            client.textBoxEvent.textKeyPress(e);
        }

        private void textBoxSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            client.textBoxEvent.textKeyPress(e);
        }
    }
}

