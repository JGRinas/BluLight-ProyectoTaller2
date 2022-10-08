using CapaLogica.LVendedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.VistaVendedor
{
    public partial class ListadoProductos : Form
    {
        LProductV products;
        public ListadoProductos()
        {
            InitializeComponent();
            /*products = new LProductV();
            products.searchProducts(dataGridViewProduct, "");*/
        }
    }
}
