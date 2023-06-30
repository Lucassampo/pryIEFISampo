namespace pryIEFISampo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.cmdProductos = new System.Windows.Forms.Button();
            this.cmdVentas = new System.Windows.Forms.Button();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.pbRegistro = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdProductos
            // 
            this.cmdProductos.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdProductos.Location = new System.Drawing.Point(9, 206);
            this.cmdProductos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdProductos.Name = "cmdProductos";
            this.cmdProductos.Size = new System.Drawing.Size(102, 76);
            this.cmdProductos.TabIndex = 0;
            this.cmdProductos.Text = "Productos";
            this.cmdProductos.UseVisualStyleBackColor = false;
            this.cmdProductos.Click += new System.EventHandler(this.cmdProductos_Click);
            // 
            // cmdVentas
            // 
            this.cmdVentas.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdVentas.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdVentas.Location = new System.Drawing.Point(178, 206);
            this.cmdVentas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdVentas.Name = "cmdVentas";
            this.cmdVentas.Size = new System.Drawing.Size(111, 77);
            this.cmdVentas.TabIndex = 1;
            this.cmdVentas.Text = "Ventas";
            this.cmdVentas.UseVisualStyleBackColor = false;
            this.cmdVentas.Click += new System.EventHandler(this.cmdVentas_Click);
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRegistro.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRegistro.Location = new System.Drawing.Point(151, 93);
            this.lblRegistro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(143, 29);
            this.lblRegistro.TabIndex = 2;
            this.lblRegistro.Text = "REGISTROS";
            // 
            // pbRegistro
            // 
            this.pbRegistro.Image = ((System.Drawing.Image)(resources.GetObject("pbRegistro.Image")));
            this.pbRegistro.Location = new System.Drawing.Point(16, 53);
            this.pbRegistro.Name = "pbRegistro";
            this.pbRegistro.Size = new System.Drawing.Size(94, 105);
            this.pbRegistro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRegistro.TabIndex = 3;
            this.pbRegistro.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(308, 366);
            this.Controls.Add(this.pbRegistro);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.cmdVentas);
            this.Controls.Add(this.cmdProductos);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPrincipal";
            this.Text = "Registros";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbRegistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdProductos;
        private System.Windows.Forms.Button cmdVentas;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.PictureBox pbRegistro;
    }
}

