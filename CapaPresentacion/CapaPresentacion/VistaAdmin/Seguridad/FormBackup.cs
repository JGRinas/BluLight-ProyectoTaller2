using CapaLogica;
using CapaPresentacion.CapaLogica.LAdmin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.CapaPresentacion.VistaAdmin.Seguridad
{
    public partial class FormBackup : Form
    {


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        LSeguridad backup;
        public FormBackup()
        {
            InitializeComponent();
            backup = new LSeguridad();
            MyGlobals.confirmacionContrasena = false;


        }
        private void buttonBuscarRuta_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxRuta.Text = folderBrowserDialog.SelectedPath;
                buttonRealizarBackup.Enabled = true;
            }
        }


        private void buttonRealizarBackup_Click_1(object sender, EventArgs e)
        {
            if (!textBoxRuta.Text.Equals(""))
            {
                if (DialogResult.Yes == MessageBox.Show("Seguro que desea realizar el backup en la ruta elegida?", "Backup", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                {
                    backup.crearBackup(textBoxRuta);
                }
            }
            else
            {
                MessageBox.Show("Debe elegir una ruta");
            }
        }


        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buttonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
