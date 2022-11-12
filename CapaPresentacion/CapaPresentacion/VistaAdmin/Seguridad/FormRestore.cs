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
    public partial class FormRestore : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        LSeguridad restore;
        public FormRestore()
        {
            InitializeComponent();
            restore = new LSeguridad();
            MyGlobals.confirmacionContrasena = false;
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

        private void buttonBuscarRuta_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL Server backups |*.bak";
            dlg.Title = "Database restore";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBoxRuta.Text = dlg.FileName;
                buttonRestaurarBackup.Enabled = true;
            }
        }

        private void buttonRestaurarBackup_Click(object sender, EventArgs e)
        {
            if (!textBoxRuta.Text.Equals(""))
            {

                if (DialogResult.Yes == MessageBox.Show("Seguro que quiere restaurar la base de datos " + textBoxRuta.Text + "?", "Primera confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    restore.restaurarBackup(textBoxRuta);
                }
               
            }
            else
            {
                MessageBox.Show("Debe ingresar una ruta");
            }
        }
    }
}
