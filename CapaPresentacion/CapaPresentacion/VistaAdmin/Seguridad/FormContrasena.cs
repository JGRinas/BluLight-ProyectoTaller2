using CapaLogica;
using CapaPresentacion.CapaLogica.LAdmin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.CapaPresentacion.VistaAdmin.Seguridad
{
    public partial class FormContrasena : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        LSeguridad confirmacion;
        public FormContrasena()
        {
            InitializeComponent();
            textBoxContrasena.MaxLength = 49;
            confirmacion = new LSeguridad();
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int contador = 3;
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (textBoxContrasena.Text.Equals(""))
            {
                MessageBox.Show("Ingrese su contraseña", "Error", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {

                if (contador == 0)
                {
                    MessageBox.Show("Demasiados intentos fallidos, la aplicación se cerrará", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Application.Exit();
                }
                else
                {
                    if (confirmacion.confirmarContrasena(textBoxContrasena))
                    {
                        MyGlobals.confirmacionContrasena = true;
                        this.Close();
                    }
                    else
                    {
                        
                        MessageBox.Show("Contraseña incorrecta, le quedan " + contador + " intentos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        contador--;
                    }
                }
            }
        }
    }
}
