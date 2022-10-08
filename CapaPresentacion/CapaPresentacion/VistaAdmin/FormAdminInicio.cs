using CapaLogica;
using CapaLogica.LAdmin;
using CapaPresentacion;
using CapaPresentacion.CapaPresentacion.VistaAdmin.GestionServicioA;
using CapaPresentacion.VistaAdmin.GestionUsuarios;
using Proyecto2022.CapaPresentacion.VistaAdmin;
using Proyecto2022.CapaPresentacion.VistaAdmin.GestionarProductos;
using Proyecto2022.CapaPresentacion.VistaAdmin.GestionarUsuario;
using Proyecto2022.CapaPresentacion.VistaAdmin.GestionLaboratorios;
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

namespace Proyecto2022.CapaPresentacion
{
    public partial class FormAdminInicio : Form
    {
        LUser user;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public FormAdminInicio()
        {
            
            InitializeComponent();
            customizarDiseno();
            user = new LUser();
            //labelNombre.Text = MyGlobals.persona.nombre;
            //labelApellido.Text = MyGlobals.persona.apellido;
        }

        private void customizarDiseno()
        {
            panelProductos.Visible = false;
            panelUsuarios.Visible = false;
            panelLaboratorio.Visible = false;
            panelUsuariosE.Visible = false;
            panelServicios.Visible = false;
        }

        private void esconderSubMenu()
        {
            if (panelProductos.Visible == true)
                panelProductos.Visible = false;

            if (panelLaboratorio.Visible == true)
                panelLaboratorio.Visible = false;

            if (panelUsuarios.Visible == true)
                panelUsuarios.Visible = false; 

            if (panelUsuariosE.Visible == true)
                panelUsuariosE.Visible = false;

            if (panelServicios.Visible == true)
                panelServicios.Visible = false;
        }

        private void verSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
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
        private void panelDesplegable_Paint(object sender, PaintEventArgs e)
        {

        }


        private void buttonUsuarios_Click(object sender, EventArgs e)
        {
            verSubMenu(panelUsuarios);
        }
        private void buttonModificarUsuario_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new ModificarEmpleado());
            esconderSubMenu();
        }

        private void buttonEliminarUsuario_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new EliminarEmpleado());
            esconderSubMenu();
        }

        private void buttonAgregarUsuario_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new AgregarEmpleado());
            esconderSubMenu();
        }

        private void buttonProductos_Click(object sender, EventArgs e)
        {
            verSubMenu(panelProductos);
        }
        private void buttonAgregarProducto_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new GestionProductos());
            esconderSubMenu();
        }

        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            }else{
                this.WindowState = FormWindowState.Normal;
            }
               
            
        }

        private void buttonLaboratorios_Click(object sender, EventArgs e)
        {

            verSubMenu(panelLaboratorio);
        }

        private void buttonAgregarLaboratorio_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new AgregarLaboratorio());
            esconderSubMenu();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que quierre cerrar sesión?", "Cerrar Sesión",MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                FormLogout formLogout = new FormLogout();
                formLogout.Show();
                this.Close();
            }
            
        }

        private void buttonUsuario_Click(object sender, EventArgs e)
        {
            verSubMenu(panelUsuariosE);
        }

        private void buttonAgregarUsuario_Click_1(object sender, EventArgs e)
        {
            abrirFormHijo(new AgregarUsuario());
            esconderSubMenu();
        }

        private void buttonEliminarUsuario_Click_1(object sender, EventArgs e)
        {
            abrirFormHijo(new EliminarUsuario());
            esconderSubMenu();
        }

        private void buttonServicios_Click(object sender, EventArgs e)
        {
            verSubMenu(panelServicios);
        }

        private void buttonGestionServicios_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new GestionServiciosA());
            esconderSubMenu();
        }

    }
}
