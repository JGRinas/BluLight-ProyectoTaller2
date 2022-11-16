using CapaLogica;
using CapaPresentacion.VistaRecepcionista.Jornadas;
using CapaPresentacion.VistaRecepcionista.Servicios;
using CapaPresentacion.VistaVendedor.Gestionar_Clientes;
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

namespace CapaPresentacion.VistaRecepcionista
{
    public partial class FormRecepcionistaInicio : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public FormRecepcionistaInicio()
        {
            InitializeComponent();
            customizarDiseno();
            labelNombre.Text = MyGlobals.persona.nombre;
            labelApellido.Text = MyGlobals.persona.apellido;
        }

        private void customizarDiseno()
        {
            panelServicios.Visible = false;
            panelJornada.Visible = false;
            panelClientes.Visible = false;
        }

        private void esconderSubMenu()
        {
            if (panelServicios.Visible == true)
                panelServicios.Visible = false;

            if (panelClientes.Visible == true)
                panelClientes.Visible = false;

            if (panelJornada.Visible == true)
                panelJornada.Visible = false;
        }

        private void verSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                esconderSubMenu();
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

        private void buttonJornada_Click(object sender, EventArgs e)
        {
            verSubMenu(panelJornada);
        }

        private void buttonInscribir_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Inscribir());
            esconderSubMenu();
        }

        private void buttonBaja_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Bajas());
            esconderSubMenu();
        }

        private void buttonServicios_Click(object sender, EventArgs e)
        {
            verSubMenu(panelServicios);
        }

        private void buttonNuevaSolicitud_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new NuevaSolicitud());
            esconderSubMenu();
        }

        private void buttonSolicitudes_Click(object sender, EventArgs e)
        {
           
            esconderSubMenu();
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            verSubMenu(panelClientes);
        }
        private void buttonGestionarClientes_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new GestionClientesRecepcionista());
            esconderSubMenu();
        }
  
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
