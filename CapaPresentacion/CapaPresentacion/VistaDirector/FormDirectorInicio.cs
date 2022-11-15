using CapaLogica;
using CapaPresentacion.VistaDirector.Estadisticas;
using Proyecto2022.CapaPresentacion.VistaAdmin.Estadisticas;
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

namespace CapaPresentacion.VistaDirector
{
    public partial class FormDirectorInicio : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public FormDirectorInicio()
        {
            InitializeComponent();
           /* labelNombre.Text = MyGlobals.persona.nombre;
            labelApellido.Text = MyGlobals.persona.apellido;*/
        }

        private void verSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private Form formActivo = null;
        private void abrirFormHijo(Form formHijo)
        {
            if (formActivo != null) formActivo.Close();
            formActivo = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panelss.Controls.Add(formHijo);
            panelss.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }

        private void buttonEstadistica_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new EstadisticasProductos());
        }
        private void buttonJornadas_Click_1(object sender, EventArgs e)
        {
            abrirFormHijo(new EstadisticasCursos());
        }

        private void buttonServicios_Click_1(object sender, EventArgs e)
        {
            abrirFormHijo(new EstadisticasServicios());
        }

        private void buttonEmpleados_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new EstadisticaEmpleados());
        }

        private void buttonClientes_Click_1(object sender, EventArgs e)
        {
            abrirFormHijo(new EstadisticaClientes());
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
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

        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buttonCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que quierre cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                FormLogout formLogout = new FormLogout();
                formLogout.Show();
                this.Close();
            }
        }


    }
}
