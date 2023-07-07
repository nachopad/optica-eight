namespace Vistas
{
    partial class FormVerVentas
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFechaVenta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNVenta = new System.Windows.Forms.TextBox();
            this.dgwVenta = new System.Windows.Forms.DataGridView();
            this.gpbVenta = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gpbFiltro = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtDniSearch = new System.Windows.Forms.TextBox();
            this.btnFecha = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblCliCompra = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwVenta)).BeginInit();
            this.gpbVenta.SuspendLayout();
            this.gpbFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(533, 549);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(242, 35);
            this.btnCerrar.TabIndex = 17;
            this.btnCerrar.Text = "Volver al Menú";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(40, 212);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "DNI del Cliente";
            // 
            // txtDNI
            // 
            this.txtDNI.Enabled = false;
            this.txtDNI.Location = new System.Drawing.Point(27, 235);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(240, 26);
            this.txtDNI.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(40, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Fecha de Venta";
            // 
            // txtFechaVenta
            // 
            this.txtFechaVenta.Enabled = false;
            this.txtFechaVenta.Location = new System.Drawing.Point(27, 155);
            this.txtFechaVenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFechaVenta.Name = "txtFechaVenta";
            this.txtFechaVenta.Size = new System.Drawing.Size(240, 26);
            this.txtFechaVenta.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(40, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Numero de Venta";
            // 
            // txtNVenta
            // 
            this.txtNVenta.Enabled = false;
            this.txtNVenta.Location = new System.Drawing.Point(27, 75);
            this.txtNVenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNVenta.Name = "txtNVenta";
            this.txtNVenta.Size = new System.Drawing.Size(240, 26);
            this.txtNVenta.TabIndex = 11;
            // 
            // dgwVenta
            // 
            this.dgwVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwVenta.Location = new System.Drawing.Point(36, 14);
            this.dgwVenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgwVenta.Name = "dgwVenta";
            this.dgwVenta.Size = new System.Drawing.Size(460, 528);
            this.dgwVenta.TabIndex = 10;
            this.dgwVenta.CurrentCellChanged += new System.EventHandler(this.dgwVenta_CurrentCellChanged);
            // 
            // gpbVenta
            // 
            this.gpbVenta.BackColor = System.Drawing.Color.Transparent;
            this.gpbVenta.Controls.Add(this.btnEliminar);
            this.gpbVenta.Controls.Add(this.label4);
            this.gpbVenta.Controls.Add(this.txtNVenta);
            this.gpbVenta.Controls.Add(this.label2);
            this.gpbVenta.Controls.Add(this.txtFechaVenta);
            this.gpbVenta.Controls.Add(this.txtDNI);
            this.gpbVenta.Controls.Add(this.label1);
            this.gpbVenta.Location = new System.Drawing.Point(508, 14);
            this.gpbVenta.Name = "gpbVenta";
            this.gpbVenta.Size = new System.Drawing.Size(296, 357);
            this.gpbVenta.TabIndex = 18;
            this.gpbVenta.TabStop = false;
            this.gpbVenta.Text = "Datos de Venta";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(75, 294);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(144, 35);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar Venta";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // gpbFiltro
            // 
            this.gpbFiltro.BackColor = System.Drawing.Color.Transparent;
            this.gpbFiltro.Controls.Add(this.btnSearch);
            this.gpbFiltro.Controls.Add(this.txtDniSearch);
            this.gpbFiltro.Controls.Add(this.btnFecha);
            this.gpbFiltro.Controls.Add(this.btnMostrar);
            this.gpbFiltro.Controls.Add(this.lblCliente);
            this.gpbFiltro.Location = new System.Drawing.Point(502, 367);
            this.gpbFiltro.Name = "gpbFiltro";
            this.gpbFiltro.Size = new System.Drawing.Size(296, 174);
            this.gpbFiltro.TabIndex = 19;
            this.gpbFiltro.TabStop = false;
            this.gpbFiltro.Text = "Filtro";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(82, 77);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(130, 31);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtDniSearch
            // 
            this.txtDniSearch.Location = new System.Drawing.Point(82, 45);
            this.txtDniSearch.Name = "txtDniSearch";
            this.txtDniSearch.Size = new System.Drawing.Size(132, 26);
            this.txtDniSearch.TabIndex = 4;
            this.txtDniSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDniSearch_KeyPress);
            // 
            // btnFecha
            // 
            this.btnFecha.Location = new System.Drawing.Point(159, 129);
            this.btnFecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFecha.Name = "btnFecha";
            this.btnFecha.Size = new System.Drawing.Size(130, 37);
            this.btnFecha.TabIndex = 3;
            this.btnFecha.Text = "Filtro por fecha";
            this.btnFecha.UseVisualStyleBackColor = true;
            this.btnFecha.Click += new System.EventHandler(this.btnFecha_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(15, 129);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(136, 37);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar Todo";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(80, 22);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(94, 20);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Cliente DNI:";
            // 
            // lblCliCompra
            // 
            this.lblCliCompra.AutoSize = true;
            this.lblCliCompra.BackColor = System.Drawing.Color.Transparent;
            this.lblCliCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliCompra.Location = new System.Drawing.Point(105, 263);
            this.lblCliCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliCompra.Name = "lblCliCompra";
            this.lblCliCompra.Size = new System.Drawing.Size(330, 29);
            this.lblCliCompra.TabIndex = 24;
            this.lblCliCompra.Text = "El cliente no tiene compras";
            this.lblCliCompra.Visible = false;
            // 
            // FormVerVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 591);
            this.Controls.Add(this.lblCliCompra);
            this.Controls.Add(this.gpbFiltro);
            this.Controls.Add(this.gpbVenta);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgwVenta);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormVerVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas Realizadas";
            this.Load += new System.EventHandler(this.FormVerVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwVenta)).EndInit();
            this.gpbVenta.ResumeLayout(false);
            this.gpbVenta.PerformLayout();
            this.gpbFiltro.ResumeLayout(false);
            this.gpbFiltro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFechaVenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNVenta;
        private System.Windows.Forms.DataGridView dgwVenta;
        private System.Windows.Forms.GroupBox gpbVenta;
        private System.Windows.Forms.GroupBox gpbFiltro;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnFecha;
        private System.Windows.Forms.TextBox txtDniSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblCliCompra;

    }
}