using Bunifu.UI.WinForms;
using CapaPresentacion.CapaData.Model;
using CapaLogica.Libreria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaLogica.LAdmin
{

    public class LUser : Librerias
    {

        public bool iniciarSesion(List<BunifuTextBox> listLogin)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                string sPass = Encrypt.GetSHA256(listLogin[1].Text);
                var usuario = listLogin[0].Text.ToString();
                var userValidate = db.Usuario.Where(d => d.usuario1.Equals(usuario) && d.password.Equals(sPass));
                if (userValidate.ToList().Count > 0 && userValidate.FirstOrDefault().activo)
                {
                    MyGlobals.usuario = db.Usuario.Where(d => d.usuario1.Equals(usuario)).FirstOrDefault();

                    MyGlobals.persona = db.Persona.Where(p => p.dni.Equals(MyGlobals.usuario.Empleado.Persona.dni)).FirstOrDefault();

                    MyGlobals.empleado = db.Empleado.Where(e => e.idPersona.Equals(MyGlobals.usuario.Empleado.idPersona)).FirstOrDefault();

                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}