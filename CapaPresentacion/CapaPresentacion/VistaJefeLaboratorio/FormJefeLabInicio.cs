using CapaLogica;
using CapaPresentacion;
using Proyecto2022.CapaPresentacion.VistaJefeLaboratorio.GestionCursos;
using Proyecto2022.CapaPresentacion.VistaJefeLaboratorio.GestionReportes;
using Proyecto2022.CapaPresentacion.VistaJefeLaboratorio.GestionServicios;
using Proyecto2022.CapaPresentacion.VistaJefeLaboratorio.GestionSolicitudes;
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

namespace Proyecto2022.CapaPresentacion.VistaJefeLaboratorio
{
    public partial class FormJefeLabInicio : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public FormJefeLabInicio()
        {
            InitializeComponent();
            customizarDiseno();
            labelNombre.Text = MyGlobals.persona.nombre;
            labelApellido.Text = MyGlobals.persona.apellido;
        }
        private void customizarDiseno()
        {
            panelSolicitudes.Visible = false;
            panelServicios.Visible = false;
            panelCursos.Visible = false;
            panelReportes.Visible = false;
        }

        private void esconderSubMenu()
        {

            if (panelSolicitudes.Visible == true)
                panelSolicitudes.Visible = false;

            if (panelServicios.Visible == true)
                panelServicios.Visible = false;

            if (panelReportes.Visible == true)
                panelReportes.Visible = false;

            if (panelCursos.Visible == true)
                panelCursos.Visible = false;
        }

        private Form formActivo = null;
        private void abrirFormHijo(Form formHijo)
        {
            if (formActivo != null) formActivo.Close();
            formActivo = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panelHijoJ.Controls.Add(formHijo);
            panelHijoJ.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
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
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void buttonSolicitudes_Click(object sender, EventArgs e)
        {
            verSubMenu(panelSolicitudes);
        }
        private void buttonSolicitudesPendientes_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new SolicitudesPendientes());
            esconderSubMenu();
        }

        private void buttonSolicitudesActivas_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new SolicitudesFinalizadas());
            esconderSubMenu();
        }

        private void buttonSolicitudesFinalizadas_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new SolicitudesEntregadas());
            esconderSubMenu();
        }

        private void buttonReportes_Click(object sender, EventArgs e)
        {
            verSubMenu(panelReportes);
        }
        private void buttonNuevoReporte_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new NuevoReporte());
            esconderSubMenu();
        }

        private void buttonListaReportes_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new ListaReportes());
            esconderSubMenu();
        }
        private void buttonCurso_Click(object sender, EventArgs e)
        {
            verSubMenu(panelCursos);
        }
        private void buttonAgregarCurso_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new AgregarJornada());
            esconderSubMenu();
        }

        private void buttonServicio_Click(object sender, EventArgs e)
        {
            verSubMenu(panelServicios);
        }
        private void buttonNuevoServicio_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new ServicioLaboratorio());
            esconderSubMenu();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void buttonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
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
