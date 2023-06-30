namespace pryIEFISampo
{
    partial class frmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            this.gbProductos = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtProductos = new System.Windows.Forms.TextBox();
            this.lblFechaDeCarga = new System.Windows.Forms.Label();
            this.lblProductos = new System.Windows.Forms.Label();
            this.dtvRegistro = new System.Windows.Forms.DataGridView();
            this.pbProducto = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnListado = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvRegistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // gbProductos
            // 
            this.gbProductos.Controls.Add(this.btnVolver);
            this.gbProductos.Controls.Add(this.btnListado);
            this.gbProductos.Controls.Add(this.txtCantidad);
            this.gbProductos.Controls.Add(this.lblCantidad);
            this.gbProductos.Controls.Add(this.txtID);
            this.gbProductos.Controls.Add(this.lblID);
            this.gbProductos.Controls.Add(this.btnCargar);
            this.gbProductos.Controls.Add(this.dtpFecha);
            this.gbProductos.Controls.Add(this.txtProductos);
            this.gbProductos.Controls.Add(this.lblFechaDeCarga);
            this.gbProductos.Controls.Add(this.lblProductos);
            this.gbProductos.Location = new System.Drawing.Point(9, 10);
            this.gbProductos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbProductos.Name = "gbProductos";
            this.gbProductos.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbProductos.Size = new System.Drawing.Size(417, 189);
            this.gbProductos.TabIndex = 0;
            this.gbProductos.TabStop = false;
            this.gbProductos.Text = "Productos";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(121, 116);
            this.txtID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(122, 20);
            this.txtID.TabIndex = 6;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(4, 116);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(110, 19);
            this.lblID.TabIndex = 5;
            this.lblID.Text = "ID de producto";
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnCargar.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCargar.Location = new System.Drawing.Point(280, 71);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(122, 41);
            this.btnCargar.TabIndex = 4;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(4, 50);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 3;
            // 
            // txtProductos
            // 
            this.txtProductos.Location = new System.Drawing.Point(121, 82);
            this.txtProductos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProductos.Name = "txtProductos";
            this.txtProductos.Size = new System.Drawing.Size(122, 20);
            this.txtProductos.TabIndex = 2;
            this.txtProductos.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblFechaDeCarga
            // 
            this.lblFechaDeCarga.AutoSize = true;
            this.lblFechaDeCarga.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDeCarga.Location = new System.Drawing.Point(4, 29);
            this.lblFechaDeCarga.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaDeCarga.Name = "lblFechaDeCarga";
            this.lblFechaDeCarga.Size = new System.Drawing.Size(113, 19);
            this.lblFechaDeCarga.TabIndex = 1;
            this.lblFechaDeCarga.Text = "Fecha De Carga";
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.Location = new System.Drawing.Point(4, 83);
            this.lblProductos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(75, 19);
            this.lblProductos.TabIndex = 0;
            this.lblProductos.Text = "Productos";
            // 
            // dtvRegistro
            // 
            this.dtvRegistro.AllowUserToAddRows = false;
            this.dtvRegistro.AllowUserToDeleteRows = false;
            this.dtvRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvRegistro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Producto,
            this.ID,
            this.Cantidad});
            this.dtvRegistro.Location = new System.Drawing.Point(9, 223);
            this.dtvRegistro.Name = "dtvRegistro";
            this.dtvRegistro.ReadOnly = true;
            this.dtvRegistro.RowHeadersWidth = 51;
            this.dtvRegistro.Size = new System.Drawing.Size(582, 91);
            this.dtvRegistro.TabIndex = 12;
            // 
            // pbProducto
            // 
            this.pbProducto.Image = ((System.Drawing.Image)(resources.GetObject("pbProducto.Image")));
            this.pbProducto.Location = new System.Drawing.Point(431, 10);
            this.pbProducto.Name = "pbProducto";
            this.pbProducto.Size = new System.Drawing.Size(147, 119);
            this.pbProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProducto.TabIndex = 13;
            this.pbProducto.TabStop = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVolver.Location = new System.Drawing.Point(280, 127);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(122, 41);
            this.btnVolver.TabIndex = 14;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnListado
            // 
            this.btnListado.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnListado.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnListado.Location = new System.Drawing.Point(280, 17);
            this.btnListado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListado.Name = "btnListado";
            this.btnListado.Size = new System.Drawing.Size(122, 41);
            this.btnListado.TabIndex = 15;
            this.btnListado.Text = "Listado";
            this.btnListado.UseVisualStyleBackColor = false;
            this.btnListado.Click += new System.EventHandler(this.btnListado_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(4, 149);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(69, 19);
            this.lblCantidad.TabIndex = 7;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(121, 148);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(122, 20);
            this.txtCantidad.TabIndex = 8;
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
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(590, 344);
            this.Controls.Add(this.pbProducto);
            this.Controls.Add(this.dtvRegistro);
            this.Controls.Add(this.gbProductos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmProductos";
            this.Text = "Productos";
            this.gbProductos.ResumeLayout(false);
            this.gbProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvRegistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProductos;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtProductos;
        private System.Windows.Forms.Label lblFechaDeCarga;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.DataGridView dtvRegistro;
        private System.Windows.Forms.PictureBox pbProducto;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnListado;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
    }
}