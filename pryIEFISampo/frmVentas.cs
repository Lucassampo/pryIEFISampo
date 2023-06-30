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

    public partial class frmVentas : Form
    {
        frmListado listado = new frmListado();
        int f = 0;
        public frmVentas()
        {
            InitializeComponent();
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            if (dtpFecha.Value != DateTime.Today)
            {
                
                MessageBox.Show("Se ha grabado correctamente");
                int i = dtvRegistro.Rows.Add();

                dtvRegistro.Rows[i].Cells[0].Value = dtpFecha.Text;
                dtvRegistro.Rows[i].Cells[1].Value = txtProducto.Text;
                dtvRegistro.Rows[i].Cells[2].Value = txtCantidad.Text;
                dtvRegistro.Rows[i].Cells[3].Value = txtID.Text;

                listado.matrizVentas[f, 0] = dtpFecha.Text;
                listado.matrizVentas[f, 1] = txtProducto.Text;
                listado.matrizVentas[f, 2] = txtCantidad.Text;
                listado.matrizVentas[f, 3] = txtID.Text;
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
