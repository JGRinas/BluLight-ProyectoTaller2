using CapaLogica;
using CapaPresentacion.VistaDirector;
using CapaPresentacion.VistaRecepcionista;
using Proyecto2022.CapaPresentacion.VistaJefeLaboratorio;
using Proyecto2022.CapaPresentacion.VistaVendedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto2022.CapaPresentacion
{
    public partial class FormWelcome : Form
    {

        public FormWelcome()
        {
            InitializeComponent();

            labelWelcome.Text = MyGlobals.persona.nombre + " " + MyGlobals.persona.apellido + "!";
 
        }
        private void FormWelcome_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(this.Opacity < 1) this.Opacity += 0.05;
            progressBar1.Value += 1;
            if(progressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
             if(this.Opacity == 0)
            {
                timer2.Stop();

                if (MyGlobals.usuario.idPerfil.Equals(1))
                 {
                     FormAdminInicio formAdminInicio = new FormAdminInicio();
                     formAdminInicio.Show();
                 }
                else if (MyGlobals.usuario.idPerfil.Equals(2))
                {
                    FormJefeLabInicio formJefeLabInicio = new FormJefeLabInicio();
                    formJefeLabInicio.Show();
                }
                else if (MyGlobals.usuario.idPerfil.Equals(3))
                {
                    FormVendedorInicio formVendedorInicio = new FormVendedorInicio();
                    formVendedorInicio.Show();
                }
                else if (MyGlobals.usuario.idPerfil.Equals(4))
                {
                    FormRecepcionistaInicio formRecepcionistaInicio = new FormRecepcionistaInicio();
                    formRecepcionistaInicio.Show();
                }
                else if (MyGlobals.usuario.idPerfil.Equals(5))
                {
                    FormDirectorInicio formDirectorInicio = new FormDirectorInicio();
                    formDirectorInicio.Show();
                }
                this.Close();

            }
        }

 
    }
}
