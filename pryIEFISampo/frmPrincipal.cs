using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryIEFISampo
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void cmdProductos_Click(object sender, EventArgs e)
        {
            frmProductos productos = new frmProductos();
            productos.ShowDialog();
        }

        private void cmdVentas_Click(object sender, EventArgs e)
        {
            frmVentas ventas = new frmVentas();
            ventas.ShowDialog();
        }

        
    }
}
