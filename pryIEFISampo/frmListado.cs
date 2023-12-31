﻿using System;
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
    public partial class frmListado : Form
    {
        public string[,] matrizProducto = new string[10, 4];
        public string[,] matrizVentas = new string[10, 4];
        public frmListado()
        {
            InitializeComponent();
        }

        private void frmListado_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            dtvListado.Rows.Clear();

            if (rbProducto.Checked)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (matrizProducto[i, 0] != null)
                    {
                        dtvListado.Rows.Add(matrizProducto[i, 1], matrizProducto[i, 2], matrizProducto[i,3], matrizProducto[i, 0]);
                    }
                }
            }
            else if(rbVenta.Checked)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (matrizVentas[i, 1] != null)
                    {
                        dtvListado.Rows.Add(matrizVentas[i, 1], matrizVentas[i, 3], matrizVentas[i, 2], matrizVentas[i, 0]);
                            
                    }
                } 
            }
        }

        private void rbProducto_CheckedChanged(object sender, EventArgs e)
        {

        }
    }   
}
