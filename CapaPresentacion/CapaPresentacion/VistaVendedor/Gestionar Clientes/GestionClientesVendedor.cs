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
    public partial class GestionClientesVendedor : Form
    {
        LClient client;
        public GestionClientesVendedor()
        {
            InitializeComponent();
            client = new LClient();
        }

        private void buttonRegisterClient_Click(object sender, EventArgs e)
        {
            var listTextBoxClientAdd = new List<TextBox>();
            listTextBoxClientAdd.Add(textBoxName);
            listTextBoxClientAdd.Add(textBoxSurname);
            listTextBoxClientAdd.Add(textBoxDni);
            listTextBoxClientAdd.Add(textBoxAddress);
            listTextBoxClientAdd.Add(textBoxMember);
            listTextBoxClientAdd.Add(textBoxPhone);
           // client.registerClient(listTextBoxClientAdd);
        }
    }
}
