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
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.dtvRegistro = new System.Windows.Forms.DataGridView();
            this.pbVentas = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnListado = new System.Windows.Forms.Button();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvRegistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(90, 23);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(130, 20);
            this.txtProducto.TabIndex = 0;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(90, 57);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(130, 20);
            this.txtCantidad.TabIndex = 1;
            // 
            // cmdCargar
            // 
            this.cmdCargar.BackColor = System.Drawing.SystemColors.ControlText;
            this.cmdCargar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdCargar.Location = new System.Drawing.Point(149, 157);
            this.cmdCargar.Margin = new System.Windows.Forms.Padding(2);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(116, 45);
            this.cmdCargar.TabIndex = 2;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = false;
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(8, 133);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(219, 20);
            this.dtpFecha.TabIndex = 3;
            // 
            // gpVentas
            // 
            this.gpVentas.Controls.Add(this.txtID);
            this.gpVentas.Controls.Add(this.label1);
            this.gpVentas.Controls.Add(this.lblFecha);
            this.gpVentas.Controls.Add(this.lblCantidad);
            this.gpVentas.Controls.Add(this.lblProducto);
            this.gpVentas.Controls.Add(this.txtProducto);
            this.gpVentas.Controls.Add(this.txtCantidad);
            this.gpVentas.Controls.Add(this.cmdCargar);
            this.gpVentas.Controls.Add(this.dtpFecha);
            this.gpVentas.Location = new System.Drawing.Point(9, 10);
            this.gpVentas.Margin = new System.Windows.Forms.Padding(2);
            this.gpVentas.Name = "gpVentas";
            this.gpVentas.Padding = new System.Windows.Forms.Padding(2);
            this.gpVentas.Size = new System.Drawing.Size(415, 206);
            this.gpVentas.TabIndex = 4;
            this.gpVentas.TabStop = false;
            this.gpVentas.Text = "Ventas";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(90, 88);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(130, 20);
            this.txtID.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(5, 110);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(128, 21);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha De Venta";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(5, 56);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(69, 19);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(4, 23);
            this.lblProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(73, 21);
            this.lblProducto.TabIndex = 4;
            this.lblProducto.Text = "Producto";
            // 
            // dtvRegistro
            // 
            this.dtvRegistro.AllowUserToAddRows = false;
            this.dtvRegistro.AllowUserToDeleteRows = false;
            this.dtvRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvRegistro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Producto,
            this.Cantidad,
            this.ID});
            this.dtvRegistro.Location = new System.Drawing.Point(9, 239);
            this.dtvRegistro.Margin = new System.Windows.Forms.Padding(2);
            this.dtvRegistro.Name = "dtvRegistro";
            this.dtvRegistro.ReadOnly = true;
            this.dtvRegistro.RowHeadersWidth = 51;
            this.dtvRegistro.RowTemplate.Height = 24;
            this.dtvRegistro.Size = new System.Drawing.Size(574, 107);
            this.dtvRegistro.TabIndex = 5;
            // 
            // pbVentas
            // 
            this.pbVentas.Image = ((System.Drawing.Image)(resources.GetObject("pbVentas.Image")));
            this.pbVentas.Location = new System.Drawing.Point(428, 5);
            this.pbVentas.Margin = new System.Windows.Forms.Padding(2);
            this.pbVentas.Name = "pbVentas";
            this.pbVentas.Size = new System.Drawing.Size(142, 115);
            this.pbVentas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVentas.TabIndex = 6;
            this.pbVentas.TabStop = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVolver.Location = new System.Drawing.Point(445, 171);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(116, 45);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnListado
            // 
            this.btnListado.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnListado.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnListado.Location = new System.Drawing.Point(445, 124);
            this.btnListado.Margin = new System.Windows.Forms.Padding(2);
            this.btnListado.Name = "btnListado";
            this.btnListado.Size = new System.Drawing.Size(116, 42);
            this.btnListado.TabIndex = 16;
            this.btnListado.Text = "Listado";
            this.btnListado.UseVisualStyleBackColor = false;
            this.btnListado.Click += new System.EventHandler(this.btnListado_Click);
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 125;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 125;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(581, 366);
            this.Controls.Add(this.btnListado);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.pbVentas);
            this.Controls.Add(this.dtvRegistro);
            this.Controls.Add(this.gpVentas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.PictureBox pbVentas;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnListado;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}