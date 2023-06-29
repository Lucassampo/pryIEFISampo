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
            this.label1 = new System.Windows.Forms.Label();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtProductos = new System.Windows.Forms.TextBox();
            this.lblFechaDeCarga = new System.Windows.Forms.Label();
            this.lblProductos = new System.Windows.Forms.Label();
            this.dtvRegistro = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbLogoGrande = new System.Windows.Forms.PictureBox();
            this.gbProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvRegistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoGrande)).BeginInit();
            this.SuspendLayout();
            // 
            // gbProductos
            // 
            this.gbProductos.Controls.Add(this.txtID);
            this.gbProductos.Controls.Add(this.label1);
            this.gbProductos.Controls.Add(this.cmdCargar);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID de producto";
            // 
            // cmdCargar
            // 
            this.cmdCargar.BackColor = System.Drawing.SystemColors.Desktop;
            this.cmdCargar.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmdCargar.Location = new System.Drawing.Point(55, 184);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(203, 51);
            this.cmdCargar.TabIndex = 4;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = false;
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
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
            this.Fecha.Width = 125;
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
            // pbLogoGrande
            // 
            this.pbLogoGrande.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoGrande.Image")));
            this.pbLogoGrande.Location = new System.Drawing.Point(385, 48);
            this.pbLogoGrande.Margin = new System.Windows.Forms.Padding(4);
            this.pbLogoGrande.Name = "pbLogoGrande";
            this.pbLogoGrande.Size = new System.Drawing.Size(196, 165);
            this.pbLogoGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoGrande.TabIndex = 13;
            this.pbLogoGrande.TabStop = false;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(594, 423);
            this.Controls.Add(this.pbLogoGrande);
            this.Controls.Add(this.dtvRegistro);
            this.Controls.Add(this.gbProductos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProductos";
            this.Text = "Productos";
            this.gbProductos.ResumeLayout(false);
            this.gbProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvRegistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoGrande)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProductos;
        private System.Windows.Forms.Button cmdCargar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtProductos;
        private System.Windows.Forms.Label lblFechaDeCarga;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.DataGridView dtvRegistro;
        private System.Windows.Forms.PictureBox pbLogoGrande;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}