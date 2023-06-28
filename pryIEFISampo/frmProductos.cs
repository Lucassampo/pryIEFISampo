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
    public partial class frmProductos: Form
    {
        int i = 0;
        public frmProductos()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            if (dtpFecha.Value != DateTime.Today)
            {
                int i = dtvRegistro.Rows.Add();
                
                dtvRegistro.Rows[i].Cells[0].Value = dtpFecha.Text;
                dtvRegistro.Rows[i].Cells[1].Value = txtProductos.Text;
                dtvRegistro.Rows[i].Cells[2].Value = txtID.Text;
                
            }
            else
            {
                MessageBox.Show("Se ha grabado correctamente");
            }
        }   
    }
}
