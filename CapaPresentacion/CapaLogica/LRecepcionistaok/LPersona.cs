using CapaLogica.Libreria;
using CapaPresentacion.CapaData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.CapaLogica.LRecepcionistaok
{
    internal class LPersona : Librerias
    {

        public void obtenerClienteEnButton(List<Label> labelsPersona,TextBox textBoxDni)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                int dni = Int32.Parse(textBoxDni.Text);
                var persona = db.Persona.Where(p => p.dni.Equals(dni)).ToList();

                if (persona.Count > 0)
                {
                    labelsPersona[0].Text = dni.ToString();
                    labelsPersona[0].Visible = true;
                    labelsPersona[1].Text = persona[0].nombre + " " + persona[0].apellido;
                    labelsPersona[1].Visible = true;

                }
                else
                {
                    MessageBox.Show("El DNI ingresado no se encuentra registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
