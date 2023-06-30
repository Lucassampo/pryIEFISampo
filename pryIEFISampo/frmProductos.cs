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
        frmListado listado = new frmListado();
        
        int f = 0;
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
                MessageBox.Show("Se ha grabado correctamente");

                int i = dtvRegistro.Rows.Add();
                
                dtvRegistro.Rows[i].Cells[0].Value = dtpFecha.Text;
                dtvRegistro.Rows[i].Cells[1].Value = txtProductos.Text;
                dtvRegistro.Rows[i].Cells[2].Value = txtID.Text;
                dtvRegistro.Rows[i].Cells[3].Value = txtCantidad.Text;

                listado.matrizProducto[f,0] = dtpFecha.Text;
                listado.matrizProducto[f,1] = txtProductos.Text;
                listado.matrizProducto[f,2] = txtID.Text;
                listado.matrizProducto[f,3] = txtCantidad.Text;
                f++;
            }
           
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
           
            
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            listado.ShowDialog();
        }
    }
}
