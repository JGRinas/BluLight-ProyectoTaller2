using CapaPresentacion.CapaData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Libreria
{
    public class Librerias
    {
        public TextBoxEvent textBoxEvent = new TextBoxEvent();
        public UploadImage uploadImage = new UploadImage();

        public bool validarFecha(DateTime fecha)
        {
            DateTime fechaActual = DateTime.Now;

            if (fecha < fechaActual)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
