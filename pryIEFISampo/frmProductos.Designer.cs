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
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbProducto = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnListado = new System.Windows.Forms.Button();
            this.gbProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvRegistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // gbProductos
            // 
            this.gbProductos.Controls.Add(this.txtID);
            this.gbProductos.Controls.Add(this.lblID);
            this.gbProductos.Controls.Add(this.btnCargar);
            this.gbProductos.Controls.Add(this.dtpFecha);
            this.gbProductos.Controls.Add(this.txtProductos);
            this.gbProductos.Controls.Add(this.lblFechaDeCarga);
            this.gbProductos.Controls.Add(this.lblProductos);
            this.gbProductos.Location = new System.Drawing.Point(12, 12);
            this.gbProductos.Name = "gbProductos";
            this.gbProductos.Size = new System.Drawing.Size(339, 263);
            this.gbProductos.TabIndex = 0;
            this.gbProductos.TabStop = false;
            this.gbProductos.Text = "Productos";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(161, 143);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(162, 22);
            this.txtID.TabIndex = 6;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(6, 143);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(132, 23);
            this.lblID.TabIndex = 5;
            this.lblID.Text = "ID de producto";
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnCargar.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCargar.Location = new System.Drawing.Point(55, 184);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(203, 51);
            this.btnCargar.TabIndex = 4;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(6, 62);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(265, 22);
            this.dtpFecha.TabIndex = 3;
            // 
            // txtProductos
            // 
            this.txtProductos.Location = new System.Drawing.Point(103, 103);
            this.txtProductos.Name = "txtProductos";
            this.txtProductos.Size = new System.Drawing.Size(207, 22);
            this.txtProductos.TabIndex = 2;
            this.txtProductos.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblFechaDeCarga
            // 
            this.lblFechaDeCarga.AutoSize = true;
            this.lblFechaDeCarga.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDeCarga.Location = new System.Drawing.Point(6, 36);
            this.lblFechaDeCarga.Name = "lblFechaDeCarga";
            this.lblFechaDeCarga.Size = new System.Drawing.Size(133, 23);
            this.lblFechaDeCarga.TabIndex = 1;
            this.lblFechaDeCarga.Text = "Fecha De Carga";
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.Location = new System.Drawing.Point(6, 102);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(91, 23);
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
            this.ID});
            this.dtvRegistro.Location = new System.Drawing.Point(12, 298);
            this.dtvRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.dtvRegistro.Name = "dtvRegistro";
            this.dtvRegistro.ReadOnly = true;
            this.dtvRegistro.RowHeadersWidth = 51;
            this.dtvRegistro.Size = new System.Drawing.Size(569, 112);
            this.dtvRegistro.TabIndex = 12;
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
            // pbProducto
            // 
            this.pbProducto.Image = ((System.Drawing.Image)(resources.GetObject("pbProducto.Image")));
            this.pbProducto.Location = new System.Drawing.Point(385, 13);
            this.pbProducto.Margin = new System.Windows.Forms.Padding(4);
            this.pbProducto.Name = "pbProducto";
            this.pbProducto.Size = new System.Drawing.Size(196, 146);
            this.pbProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProducto.TabIndex = 13;
            this.pbProducto.TabStop = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVolver.Location = new System.Drawing.Point(396, 240);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(163, 51);
            this.btnVolver.TabIndex = 14;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnListado
            // 
            this.btnListado.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnListado.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnListado.Location = new System.Drawing.Point(396, 183);
            this.btnListado.Name = "btnListado";
            this.btnListado.Size = new System.Drawing.Size(163, 51);
            this.btnListado.TabIndex = 15;
            this.btnListado.Text = "Listado";
            this.btnListado.UseVisualStyleBackColor = false;
            this.btnListado.Click += new System.EventHandler(this.btnListado_Click);
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(594, 423);
            this.Controls.Add(this.btnListado);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.pbProducto);
            this.Controls.Add(this.dtvRegistro);
            this.Controls.Add(this.gbProductos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnListado;
    }
}