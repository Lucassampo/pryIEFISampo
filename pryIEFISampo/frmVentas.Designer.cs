namespace pryIEFISampo
{
    partial class frmVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.gpVentas = new System.Windows.Forms.GroupBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.dtvRegistro = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbVentas = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnListado = new System.Windows.Forms.Button();
            this.gpVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvRegistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(120, 28);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(172, 22);
            this.txtProducto.TabIndex = 0;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(120, 70);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(172, 22);
            this.txtCantidad.TabIndex = 1;
            // 
            // cmdCargar
            // 
            this.cmdCargar.BackColor = System.Drawing.SystemColors.ControlText;
            this.cmdCargar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdCargar.Location = new System.Drawing.Point(66, 182);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(154, 55);
            this.cmdCargar.TabIndex = 2;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = false;
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(13, 138);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(291, 22);
            this.dtpFecha.TabIndex = 3;
            // 
            // gpVentas
            // 
            this.gpVentas.Controls.Add(this.lblFecha);
            this.gpVentas.Controls.Add(this.lblCantidad);
            this.gpVentas.Controls.Add(this.lblProducto);
            this.gpVentas.Controls.Add(this.txtProducto);
            this.gpVentas.Controls.Add(this.txtCantidad);
            this.gpVentas.Controls.Add(this.cmdCargar);
            this.gpVentas.Controls.Add(this.dtpFecha);
            this.gpVentas.Location = new System.Drawing.Point(12, 12);
            this.gpVentas.Name = "gpVentas";
            this.gpVentas.Size = new System.Drawing.Size(324, 254);
            this.gpVentas.TabIndex = 4;
            this.gpVentas.TabStop = false;
            this.gpVentas.Text = "Ventas";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(8, 109);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(159, 26);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha De Venta";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(7, 69);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(81, 23);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(6, 28);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(93, 25);
            this.lblProducto.TabIndex = 4;
            this.lblProducto.Text = "Producto";
            // 
            // dtvRegistro
            // 
            this.dtvRegistro.AllowUserToAddRows = false;
            this.dtvRegistro.AllowUserToDeleteRows = false;
            this.dtvRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvRegistro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Fecha,
            this.Cantidad});
            this.dtvRegistro.Location = new System.Drawing.Point(12, 291);
            this.dtvRegistro.Name = "dtvRegistro";
            this.dtvRegistro.ReadOnly = true;
            this.dtvRegistro.RowHeadersWidth = 51;
            this.dtvRegistro.RowTemplate.Height = 24;
            this.dtvRegistro.Size = new System.Drawing.Size(511, 132);
            this.dtvRegistro.TabIndex = 5;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 125;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 125;
            // 
            // pbVentas
            // 
            this.pbVentas.Image = ((System.Drawing.Image)(resources.GetObject("pbVentas.Image")));
            this.pbVentas.Location = new System.Drawing.Point(369, 5);
            this.pbVentas.Name = "pbVentas";
            this.pbVentas.Size = new System.Drawing.Size(189, 142);
            this.pbVentas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVentas.TabIndex = 6;
            this.pbVentas.TabStop = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVolver.Location = new System.Drawing.Point(389, 230);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(154, 55);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnListado
            // 
            this.btnListado.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnListado.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnListado.Location = new System.Drawing.Point(389, 153);
            this.btnListado.Name = "btnListado";
            this.btnListado.Size = new System.Drawing.Size(154, 52);
            this.btnListado.TabIndex = 16;
            this.btnListado.Text = "Listado";
            this.btnListado.UseVisualStyleBackColor = false;
            this.btnListado.Click += new System.EventHandler(this.btnListado_Click);
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(588, 450);
            this.Controls.Add(this.btnListado);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.pbVentas);
            this.Controls.Add(this.dtvRegistro);
            this.Controls.Add(this.gpVentas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVentas";
            this.Text = "Ventas";
            this.gpVentas.ResumeLayout(false);
            this.gpVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvRegistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button cmdCargar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.GroupBox gpVentas;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.DataGridView dtvRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.PictureBox pbVentas;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnListado;
    }
}