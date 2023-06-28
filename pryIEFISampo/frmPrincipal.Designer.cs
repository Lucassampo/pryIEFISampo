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
            this.pbLogoGrande = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoGrande)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdProductos
            // 
            this.cmdProductos.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdProductos.Location = new System.Drawing.Point(12, 257);
            this.cmdProductos.Name = "cmdProductos";
            this.cmdProductos.Size = new System.Drawing.Size(155, 93);
            this.cmdProductos.TabIndex = 0;
            this.cmdProductos.Text = "Productos";
            this.cmdProductos.UseVisualStyleBackColor = false;
            this.cmdProductos.Click += new System.EventHandler(this.cmdProductos_Click);
            // 
            // cmdVentas
            // 
            this.cmdVentas.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdVentas.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdVentas.Location = new System.Drawing.Point(222, 255);
            this.cmdVentas.Name = "cmdVentas";
            this.cmdVentas.Size = new System.Drawing.Size(162, 95);
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
            this.lblRegistro.Location = new System.Drawing.Point(165, 109);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(184, 38);
            this.lblRegistro.TabIndex = 2;
            this.lblRegistro.Text = "REGISTROS";
            // 
            // pbLogoGrande
            // 
            this.pbLogoGrande.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoGrande.Image")));
            this.pbLogoGrande.Location = new System.Drawing.Point(23, 81);
            this.pbLogoGrande.Margin = new System.Windows.Forms.Padding(4);
            this.pbLogoGrande.Name = "pbLogoGrande";
            this.pbLogoGrande.Size = new System.Drawing.Size(101, 97);
            this.pbLogoGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoGrande.TabIndex = 3;
            this.pbLogoGrande.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(411, 450);
            this.Controls.Add(this.pbLogoGrande);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.cmdVentas);
            this.Controls.Add(this.cmdProductos);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Text = "Registros";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoGrande)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdProductos;
        private System.Windows.Forms.Button cmdVentas;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.PictureBox pbLogoGrande;
    }
}

