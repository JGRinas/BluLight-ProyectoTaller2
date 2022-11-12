using CapaPresentacion.CapaData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CapaPresentacion.CapaLogica.LDirector
{
    internal class LStatServicios
    {
        public void cargarCheckedListBoxCategorias(CheckedListBox checkedListBoxCategorias) {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                var categorias = db.Categoria_servicio.ToList();

                foreach (var c in categorias) {
                    checkedListBoxCategorias.Items.Add(c.categoria);
                
                }
            }
        }

        public void generarGraficoGlobales(Chart chartGlobales, CheckedListBox checkedListBoxCategorias,
        CheckedListBox checkedListAnio)
        {
            string[] serieMeses = { "", "", "", "", "", "", "", "", "", "", "" };
        }

    }//finclase
}
