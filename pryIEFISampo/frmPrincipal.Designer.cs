﻿namespace pryIEFISampo
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdProductos = new System.Windows.Forms.Button();
            this.cmdVentas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdProductos
            // 
            this.cmdProductos.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdProductos.Location = new System.Drawing.Point(12, 306);
            this.cmdProductos.Name = "cmdProductos";
            this.cmdProductos.Size = new System.Drawing.Size(155, 93);
            this.cmdProductos.TabIndex = 0;
            this.cmdProductos.Text = "Productos";
            this.cmdProductos.UseVisualStyleBackColor = false;
            // 
            // cmdVentas
            // 
            this.cmdVentas.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdVentas.Location = new System.Drawing.Point(237, 304);
            this.cmdVentas.Name = "cmdVentas";
            this.cmdVentas.Size = new System.Drawing.Size(162, 95);
            this.cmdVentas.TabIndex = 1;
            this.cmdVentas.Text = "Ventas";
            this.cmdVentas.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(107, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "REGISTROS";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(411, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdVentas);
            this.Controls.Add(this.cmdProductos);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "frmPrincipal";
            this.Text = "Registros";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdProductos;
        private System.Windows.Forms.Button cmdVentas;
        private System.Windows.Forms.Label label1;
    }
}
