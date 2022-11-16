using System;
using CapaLogica.LVendedor;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.VistaVendedor.Gestionar_Clientes
{
    public partial class GestionClientesRecepcionista : Form
    {
        LClient client;
        public GestionClientesRecepcionista()
        {
            InitializeComponent();

            textBoxName.MaxLength = 49;
            textBoxDni.MaxLength = 9;
            textBoxDniBuscar.MaxLength = 9;
            textBoxEmail.MaxLength = 49;
            textBoxSurname.MaxLength = 49;
            textBoxPhone.MaxLength = 49;
            textBoxAddress.MaxLength = 49;
            textBoxDniBuscar.MaxLength = 9;

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
            if (!textBoxDniBuscar.Text.Equals(""))
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
            else
            {
                MessageBox.Show("Ingrese un DNI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
        }

        private void dataGridViewClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewClientes.CurrentRow != null)
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
           
        }

        private void btnRestaurarCliente_Click(object sender, EventArgs e)
        {
            client.restaurarCliente();
        }

        private void textBoxDniBuscar_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            client.textBoxEvent.numberKeyPress(e);
        }

        private void textBoxName_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            client.textBoxEvent.textKeyPress(e);
        }

        private void textBoxSurname_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            client.textBoxEvent.textKeyPress(e);
        }

        private void textBoxDni_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            client.textBoxEvent.numberKeyPress(e);
        }
    }
}

