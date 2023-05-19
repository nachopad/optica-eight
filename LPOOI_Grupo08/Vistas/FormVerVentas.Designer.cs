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
            this.gpbFiltro = new System.Windows.Forms.GroupBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cmbFiltroCliente = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwVenta)).BeginInit();
            this.gpbVenta.SuspendLayout();
            this.gpbFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(355, 371);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(161, 23);
            this.btnCerrar.TabIndex = 17;
            this.btnCerrar.Text = "Cerrar Ventana";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(27, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "DNI del Cliente";
            // 
            // txtDNI
            // 
            this.txtDNI.Enabled = false;
            this.txtDNI.Location = new System.Drawing.Point(18, 153);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(161, 20);
            this.txtDNI.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(27, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Fecha de Venta";
            // 
            // txtFechaVenta
            // 
            this.txtFechaVenta.Enabled = false;
            this.txtFechaVenta.Location = new System.Drawing.Point(18, 101);
            this.txtFechaVenta.Name = "txtFechaVenta";
            this.txtFechaVenta.Size = new System.Drawing.Size(161, 20);
            this.txtFechaVenta.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(27, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Numero de Venta";
            // 
            // txtNVenta
            // 
            this.txtNVenta.Enabled = false;
            this.txtNVenta.Location = new System.Drawing.Point(18, 49);
            this.txtNVenta.Name = "txtNVenta";
            this.txtNVenta.Size = new System.Drawing.Size(161, 20);
            this.txtNVenta.TabIndex = 11;
            // 
            // dgwVenta
            // 
            this.dgwVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwVenta.Location = new System.Drawing.Point(24, 40);
            this.dgwVenta.Name = "dgwVenta";
            this.dgwVenta.Size = new System.Drawing.Size(307, 325);
            this.dgwVenta.TabIndex = 10;
            this.dgwVenta.CurrentCellChanged += new System.EventHandler(this.dgwVenta_CurrentCellChanged);
            // 
            // gpbVenta
            // 
            this.gpbVenta.BackColor = System.Drawing.Color.Transparent;
            this.gpbVenta.Controls.Add(this.label4);
            this.gpbVenta.Controls.Add(this.txtNVenta);
            this.gpbVenta.Controls.Add(this.label2);
            this.gpbVenta.Controls.Add(this.txtFechaVenta);
            this.gpbVenta.Controls.Add(this.txtDNI);
            this.gpbVenta.Controls.Add(this.label1);
            this.gpbVenta.Location = new System.Drawing.Point(335, 34);
            this.gpbVenta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbVenta.Name = "gpbVenta";
            this.gpbVenta.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbVenta.Size = new System.Drawing.Size(197, 205);
            this.gpbVenta.TabIndex = 18;
            this.gpbVenta.TabStop = false;
            this.gpbVenta.Text = "Datos de Venta";
            // 
            // gpbFiltro
            // 
            this.gpbFiltro.BackColor = System.Drawing.Color.Transparent;
            this.gpbFiltro.Controls.Add(this.button1);
            this.gpbFiltro.Controls.Add(this.btnMostrar);
            this.gpbFiltro.Controls.Add(this.lblCliente);
            this.gpbFiltro.Controls.Add(this.cmbFiltroCliente);
            this.gpbFiltro.Location = new System.Drawing.Point(335, 253);
            this.gpbFiltro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbFiltro.Name = "gpbFiltro";
            this.gpbFiltro.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbFiltro.Size = new System.Drawing.Size(197, 113);
            this.gpbFiltro.TabIndex = 19;
            this.gpbFiltro.TabStop = false;
            this.gpbFiltro.Text = "Filtro";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(55, 58);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(88, 21);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar Todo";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(53, 14);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(64, 13);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Cliente DNI:";
            // 
            // cmbFiltroCliente
            // 
            this.cmbFiltroCliente.FormattingEnabled = true;
            this.cmbFiltroCliente.Location = new System.Drawing.Point(55, 29);
            this.cmbFiltroCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbFiltroCliente.Name = "cmbFiltroCliente";
            this.cmbFiltroCliente.Size = new System.Drawing.Size(89, 21);
            this.cmbFiltroCliente.TabIndex = 0;
            this.cmbFiltroCliente.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroCliente_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 24);
            this.button1.TabIndex = 3;
            this.button1.Text = "Filtro por fecha";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FormVerVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 421);
            this.Controls.Add(this.gpbFiltro);
            this.Controls.Add(this.gpbVenta);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgwVenta);
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
        private System.Windows.Forms.ComboBox cmbFiltroCliente;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button button1;

    }
}