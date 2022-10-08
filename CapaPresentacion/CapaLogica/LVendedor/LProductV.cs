using CapaPresentacion.CapaData.Model;
using CapaLogica.Libreria;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaLogica.LVendedor
{
    public class LProductV : Librerias
    {
        /*private PictureBox image;
        private int _num_pag = 1, _reg_pag = 2;
        public void searchProducts(DataGridView dataGrid, string campo)
        {
            List<Product> query = new List<Product>();
            int inicio = (_num_pag - 1) * _reg_pag;
            if (campo.Equals(""))
            {
                query = _Product.ToList();
            }
            else
            {
                query = _Product.Where(c => c.codProd.ToString().StartsWith(campo) || c.stock.ToString().StartsWith(campo) || c.title.ToString().StartsWith(campo) || c.category.ToString().StartsWith(campo)).ToList();
            }
            if (query.Count > 0)
            {


                for (int i = 0; i < query.Count; i++)
                {
                    int fila = dataGrid.Rows.Add();
                    dataGrid.Rows[fila].Cells["ColumnId"].Value = query[i].id;
                    dataGrid.Rows[fila].Cells["ColumnTitle"].Value = query[i].title;
                    dataGrid.Rows[fila].Cells["ColumnCategory"].Value = query[i].category;
                    dataGrid.Rows[fila].Cells["ColumnCodProd"].Value = query[i].codProd;
                    dataGrid.Rows[fila].Cells["ColumnStock"].Value = query[i].stock;
                    Image thumb = uploadImage.byteToImage(query[i].image).GetThumbnailImage(100, 100, null, IntPtr.Zero);
                    dataGrid.Rows[fila].Height = 100;
                    dataGrid.Rows[fila].Cells["ColumnImage"].Value = thumb;
                }

            }
        }*/
    }
}
