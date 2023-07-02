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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgwCliente = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.textDni = new System.Windows.Forms.TextBox();
            this.radioNombre = new System.Windows.Forms.RadioButton();
            this.radioApellido = new System.Windows.Forms.RadioButton();
            this.radioDni = new System.Windows.Forms.RadioButton();
            this.labelBusqueda = new System.Windows.Forms.Label();
            this.lblCliCompra = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwVenta)).BeginInit();
            this.gpbVenta.SuspendLayout();
            this.gpbFiltro.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(353, 585);
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
            this.dgwVenta.Location = new System.Drawing.Point(24, 237);
            this.dgwVenta.Name = "dgwVenta";
            this.dgwVenta.Size = new System.Drawing.Size(307, 343);
            this.dgwVenta.TabIndex = 10;
            this.dgwVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwVenta_CellContentClick);
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
            this.gpbVenta.Location = new System.Drawing.Point(335, 231);
            this.gpbVenta.Margin = new System.Windows.Forms.Padding(2);
            this.gpbVenta.Name = "gpbVenta";
            this.gpbVenta.Padding = new System.Windows.Forms.Padding(2);
            this.gpbVenta.Size = new System.Drawing.Size(197, 232);
            this.gpbVenta.TabIndex = 18;
            this.gpbVenta.TabStop = false;
            this.gpbVenta.Text = "Datos de Venta";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(50, 191);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(96, 23);
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
            this.gpbFiltro.Location = new System.Drawing.Point(335, 467);
            this.gpbFiltro.Margin = new System.Windows.Forms.Padding(2);
            this.gpbFiltro.Name = "gpbFiltro";
            this.gpbFiltro.Padding = new System.Windows.Forms.Padding(2);
            this.gpbFiltro.Size = new System.Drawing.Size(197, 113);
            this.gpbFiltro.TabIndex = 19;
            this.gpbFiltro.TabStop = false;
            this.gpbFiltro.Text = "Filtro";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(55, 50);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 20);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtDniSearch
            // 
            this.txtDniSearch.Location = new System.Drawing.Point(55, 29);
            this.txtDniSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtDniSearch.Name = "txtDniSearch";
            this.txtDniSearch.Size = new System.Drawing.Size(89, 20);
            this.txtDniSearch.TabIndex = 4;
            this.txtDniSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDniSearch_KeyPress);
            // 
            // btnFecha
            // 
            this.btnFecha.Location = new System.Drawing.Point(106, 84);
            this.btnFecha.Name = "btnFecha";
            this.btnFecha.Size = new System.Drawing.Size(87, 24);
            this.btnFecha.TabIndex = 3;
            this.btnFecha.Text = "Filtro por fecha";
            this.btnFecha.UseVisualStyleBackColor = true;
            this.btnFecha.Click += new System.EventHandler(this.btnFecha_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(10, 84);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(91, 24);
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioDni);
            this.groupBox1.Controls.Add(this.radioApellido);
            this.groupBox1.Controls.Add(this.radioNombre);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.textDni);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(15, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 100);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar Por";
            // 
            // dgwCliente
            // 
            this.dgwCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCliente.Location = new System.Drawing.Point(24, 120);
            this.dgwCliente.Name = "dgwCliente";
            this.dgwCliente.Size = new System.Drawing.Size(508, 95);
            this.dgwCliente.TabIndex = 21;
            this.dgwCliente.Visible = false;
            this.dgwCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCliente_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(421, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 21);
            this.button1.TabIndex = 22;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Apellido:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Dni:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(6, 42);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(110, 20);
            this.txtNombre.TabIndex = 18;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(129, 42);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(112, 20);
            this.txtApellido.TabIndex = 19;
            // 
            // textDni
            // 
            this.textDni.Location = new System.Drawing.Point(260, 42);
            this.textDni.Name = "textDni";
            this.textDni.Size = new System.Drawing.Size(115, 20);
            this.textDni.TabIndex = 20;
            this.textDni.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // radioNombre
            // 
            this.radioNombre.AutoSize = true;
            this.radioNombre.Checked = true;
            this.radioNombre.Location = new System.Drawing.Point(94, 78);
            this.radioNombre.Name = "radioNombre";
            this.radioNombre.Size = new System.Drawing.Size(62, 17);
            this.radioNombre.TabIndex = 21;
            this.radioNombre.TabStop = true;
            this.radioNombre.Text = "Nombre";
            this.radioNombre.UseVisualStyleBackColor = true;
            // 
            // radioApellido
            // 
            this.radioApellido.AutoSize = true;
            this.radioApellido.Location = new System.Drawing.Point(156, 79);
            this.radioApellido.Name = "radioApellido";
            this.radioApellido.Size = new System.Drawing.Size(62, 17);
            this.radioApellido.TabIndex = 22;
            this.radioApellido.Text = "Apellido";
            this.radioApellido.UseVisualStyleBackColor = true;
            // 
            // radioDni
            // 
            this.radioDni.AutoSize = true;
            this.radioDni.Location = new System.Drawing.Point(217, 79);
            this.radioDni.Name = "radioDni";
            this.radioDni.Size = new System.Drawing.Size(41, 17);
            this.radioDni.TabIndex = 23;
            this.radioDni.Text = "Dni";
            this.radioDni.UseVisualStyleBackColor = true;
            // 
            // labelBusqueda
            // 
            this.labelBusqueda.AutoSize = true;
            this.labelBusqueda.BackColor = System.Drawing.Color.Transparent;
            this.labelBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBusqueda.Location = new System.Drawing.Point(135, 157);
            this.labelBusqueda.Name = "labelBusqueda";
            this.labelBusqueda.Size = new System.Drawing.Size(235, 20);
            this.labelBusqueda.TabIndex = 23;
            this.labelBusqueda.Text = "Debe realizar una busqueda";
            // 
            // lblCliCompra
            // 
            this.lblCliCompra.AutoSize = true;
            this.lblCliCompra.BackColor = System.Drawing.Color.Transparent;
            this.lblCliCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliCompra.Location = new System.Drawing.Point(48, 309);
            this.lblCliCompra.Name = "lblCliCompra";
            this.lblCliCompra.Size = new System.Drawing.Size(226, 20);
            this.lblCliCompra.TabIndex = 24;
            this.lblCliCompra.Text = "El cliente no tiene compras";
            this.lblCliCompra.Visible = false;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.BackColor = System.Drawing.Color.Transparent;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.Location = new System.Drawing.Point(403, 56);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(161, 38);
            this.lblMsg.TabIndex = 25;
            this.lblMsg.Text = "Seleccione un cliente\r\npara filtrar sus ventas";
            this.lblMsg.Visible = false;
            // 
            // FormVerVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 620);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.lblCliCompra);
            this.Controls.Add(this.labelBusqueda);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgwCliente);
            this.Controls.Add(this.groupBox1);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCliente)).EndInit();
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
        private System.Windows.Forms.TextBox textDni;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgwCliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioDni;
        private System.Windows.Forms.RadioButton radioApellido;
        private System.Windows.Forms.RadioButton radioNombre;
        private System.Windows.Forms.Label labelBusqueda;
        private System.Windows.Forms.Label lblCliCompra;
        private System.Windows.Forms.Label lblMsg;

    }
}