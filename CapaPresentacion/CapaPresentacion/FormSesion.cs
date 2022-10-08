using Proyecto2022.CapaPresentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Bunifu.UI.WinForms;
using CapaLogica.LAdmin;

namespace Proyecto2022
{
    public partial class FormSesion : Form
    {
        LUser user;
        public FormSesion()
        {
            InitializeComponent();
            user = new LUser();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void buttonInicioSesion_Click(object sender, EventArgs e)
        {
            List<BunifuTextBox> textBoxLoing = new List<BunifuTextBox>();
            textBoxLoing.Add(textBoxUsuarioInicio);
            textBoxLoing.Add(textBoxContrasenaInicio);

            if (textBoxUsuarioInicio.Text.Equals("") || textBoxContrasenaInicio.Text.Equals(""))
            {
                MessageBox.Show("Ingrese todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (user.iniciarSesion(textBoxLoing))
                {
                    FormWelcome welcome = new FormWelcome();
                    welcome.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
