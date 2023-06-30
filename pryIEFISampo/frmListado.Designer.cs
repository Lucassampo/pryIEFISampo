namespace pryIEFISampo
{
    partial class frmListado
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
            this.dtvListado = new System.Windows.Forms.DataGridView();
            this.lblListadoDeProducto = new System.Windows.Forms.Label();
            this.rbProducto = new System.Windows.Forms.RadioButton();
            this.rbVenta = new System.Windows.Forms.RadioButton();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // dtvListado
            // 
            this.dtvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.ID,
            this.Cantidad,
            this.Fecha});
            this.dtvListado.Location = new System.Drawing.Point(9, 135);
            this.dtvListado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtvListado.Name = "dtvListado";
            this.dtvListado.RowHeadersWidth = 51;
            this.dtvListado.RowTemplate.Height = 24;
            this.dtvListado.Size = new System.Drawing.Size(509, 141);
            this.dtvListado.TabIndex = 0;
            // 
            // lblListadoDeProducto
            // 
            this.lblListadoDeProducto.AutoSize = true;
            this.lblListadoDeProducto.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoDeProducto.Location = new System.Drawing.Point(9, 23);
            this.lblListadoDeProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblListadoDeProducto.Name = "lblListadoDeProducto";
            this.lblListadoDeProducto.Size = new System.Drawing.Size(206, 25);
            this.lblListadoDeProducto.TabIndex = 1;
            this.lblListadoDeProducto.Text = "Listado de Productos";
            // 
            // rbProducto
            // 
            this.rbProducto.AutoSize = true;
            this.rbProducto.Location = new System.Drawing.Point(368, 31);
            this.rbProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbProducto.Name = "rbProducto";
            this.rbProducto.Size = new System.Drawing.Size(68, 17);
            this.rbProducto.TabIndex = 3;
            this.rbProducto.TabStop = true;
            this.rbProducto.Text = "Producto";
            this.rbProducto.UseVisualStyleBackColor = true;
            this.rbProducto.CheckedChanged += new System.EventHandler(this.rbProducto_CheckedChanged);
            // 
            // rbVenta
            // 
            this.rbVenta.AutoSize = true;
            this.rbVenta.Checked = true;
            this.rbVenta.Location = new System.Drawing.Point(272, 31);
            this.rbVenta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbVenta.Name = "rbVenta";
            this.rbVenta.Size = new System.Drawing.Size(53, 17);
            this.rbVenta.TabIndex = 4;
            this.rbVenta.TabStop = true;
            this.rbVenta.Text = "Venta";
            this.rbVenta.UseVisualStyleBackColor = true;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnFiltrar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFiltrar.Location = new System.Drawing.Point(272, 74);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(158, 40);
            this.btnFiltrar.TabIndex = 5;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.Width = 125;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 125;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 125;
            // 
            // frmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(527, 366);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.rbVenta);
            this.Controls.Add(this.rbProducto);
            this.Controls.Add(this.lblListadoDeProducto);
            this.Controls.Add(this.dtvListado);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmListado";
            this.Text = "Listado";
            this.Load += new System.EventHandler(this.frmListado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvListado;
        private System.Windows.Forms.Label lblListadoDeProducto;
        private System.Windows.Forms.RadioButton rbProducto;
        private System.Windows.Forms.RadioButton rbVenta;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
    }
}