using CapaLogica;
using CapaPresentacion;
using CapaPresentacion.CapaPresentacion.VistaVendedor.Ventas;
using CapaPresentacion.VistaVendedor;
using CapaPresentacion.VistaVendedor.Gestionar_Clientes;
using CapaPresentacion.VistaVendedor.Ventas;
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

namespace Proyecto2022.CapaPresentacion.VistaVendedor
{
    public partial class FormVendedorInicio : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public FormVendedorInicio()
        {
            InitializeComponent();
            customizarDiseno();
            /*labelNombre.Text = MyGlobals.persona.nombre;
            labelApellido.Text = MyGlobals.persona.apellido;*/
        }

        private void customizarDiseno()
        {
            panelUsuarios.Visible = false;
            panelVentas.Visible = false;
        }

        private void esconderSubMenu()
        {
            if (panelUsuarios.Visible == true)
                panelUsuarios.Visible = false;

            if (panelVentas.Visible == true)
                panelVentas.Visible = false;

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

        private void buttonVentas_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new NuevaVenta());
            verSubMenu(panelVentas);
        }

        private void buttonListaProductos_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new ListadoProductos());
            esconderSubMenu();
        }
        private void buttonClientes_Click(object sender, EventArgs e)
        {
            verSubMenu(panelUsuarios);
        }

        private void buttonGestionClientes_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new GestionClientesVendedor());
            esconderSubMenu();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void buttonCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que quierre cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                FormLogout formLogout = new FormLogout();
                formLogout.Show();
                this.Close();
            }
        }

        private void buttonVentasRealizadas_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new VentasRealizadas());
            esconderSubMenu();
        }
    }
}
