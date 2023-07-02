namespace Vistas
{
    partial class AltaProducto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnAltaProducto = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnModificarProducto = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioCategoria = new System.Windows.Forms.RadioButton();
            this.radioDescripcion = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.dgwProductos = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.btnProductosVendidosByCliente = new System.Windows.Forms.Button();
            this.gbBusqueda = new System.Windows.Forms.GroupBox();
            this.btnCodProdSearch = new System.Windows.Forms.Button();
            this.txtCodProdSearch = new System.Windows.Forms.TextBox();
            this.lblCodProdSearch = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProductos)).BeginInit();
            this.gbBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(109, 26);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(109, 62);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(100, 20);
            this.txtCategoria.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(109, 97);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 3;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(109, 133);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 4;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // btnAltaProducto
            // 
            this.btnAltaProducto.Location = new System.Drawing.Point(9, 190);
            this.btnAltaProducto.Name = "btnAltaProducto";
            this.btnAltaProducto.Size = new System.Drawing.Size(75, 23);
            this.btnAltaProducto.TabIndex = 5;
            this.btnAltaProducto.Text = "Registrar";
            this.btnAltaProducto.UseVisualStyleBackColor = true;
            this.btnAltaProducto.Click += new System.EventHandler(this.btnAltaProducto_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnEliminarProducto);
            this.groupBox1.Controls.Add(this.btnModificarProducto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnAltaProducto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCategoria);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Location = new System.Drawing.Point(30, 48);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(255, 222);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Producto";
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Location = new System.Drawing.Point(170, 190);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarProducto.TabIndex = 7;
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.Location = new System.Drawing.Point(90, 190);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnModificarProducto.TabIndex = 6;
            this.btnModificarProducto.Text = "Modificar";
            this.btnModificarProducto.UseVisualStyleBackColor = true;
            this.btnModificarProducto.Click += new System.EventHandler(this.btnModificarProducto_Click_1);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(11, 2);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(93, 26);
            this.btnRegresar.TabIndex = 1;
            this.btnRegresar.Text = "Volver al Menu";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.radioCategoria);
            this.groupBox2.Controls.Add(this.radioDescripcion);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(299, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(497, 53);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consulta";
            // 
            // radioCategoria
            // 
            this.radioCategoria.AutoSize = true;
            this.radioCategoria.Location = new System.Drawing.Point(250, 29);
            this.radioCategoria.Name = "radioCategoria";
            this.radioCategoria.Size = new System.Drawing.Size(70, 17);
            this.radioCategoria.TabIndex = 2;
            this.radioCategoria.TabStop = true;
            this.radioCategoria.Text = "Categoria";
            this.radioCategoria.UseVisualStyleBackColor = true;
            this.radioCategoria.CheckedChanged += new System.EventHandler(this.radioCategoria_CheckedChanged);
            // 
            // radioDescripcion
            // 
            this.radioDescripcion.AutoSize = true;
            this.radioDescripcion.Location = new System.Drawing.Point(154, 29);
            this.radioDescripcion.Name = "radioDescripcion";
            this.radioDescripcion.Size = new System.Drawing.Size(81, 17);
            this.radioDescripcion.TabIndex = 1;
            this.radioDescripcion.TabStop = true;
            this.radioDescripcion.Text = "Descripcion";
            this.radioDescripcion.UseVisualStyleBackColor = true;
            this.radioDescripcion.CheckedChanged += new System.EventHandler(this.radioDescripcion_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ordenar por:";
            // 
            // dgwProductos
            // 
            this.dgwProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProductos.Location = new System.Drawing.Point(299, 153);
            this.dgwProductos.Name = "dgwProductos";
            this.dgwProductos.Size = new System.Drawing.Size(497, 117);
            this.dgwProductos.TabIndex = 3;
            this.dgwProductos.CurrentCellChanged += new System.EventHandler(this.dgwProductos_CurrentCellChanged_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(109, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 26);
            this.button2.TabIndex = 4;
            this.button2.Text = "Ver Productos Vendidos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnProductosVendidosByCliente
            // 
            this.btnProductosVendidosByCliente.Location = new System.Drawing.Point(270, 2);
            this.btnProductosVendidosByCliente.Name = "btnProductosVendidosByCliente";
            this.btnProductosVendidosByCliente.Size = new System.Drawing.Size(208, 26);
            this.btnProductosVendidosByCliente.TabIndex = 5;
            this.btnProductosVendidosByCliente.Text = "Ver Productos Vendidos por Cliente";
            this.btnProductosVendidosByCliente.UseVisualStyleBackColor = true;
            this.btnProductosVendidosByCliente.Click += new System.EventHandler(this.btnProductosVendidosByCliente_Click);
            // 
            // gbBusqueda
            // 
            this.gbBusqueda.BackColor = System.Drawing.Color.Transparent;
            this.gbBusqueda.Controls.Add(this.btnCodProdSearch);
            this.gbBusqueda.Controls.Add(this.txtCodProdSearch);
            this.gbBusqueda.Controls.Add(this.lblCodProdSearch);
            this.gbBusqueda.Location = new System.Drawing.Point(299, 48);
            this.gbBusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.gbBusqueda.Name = "gbBusqueda";
            this.gbBusqueda.Padding = new System.Windows.Forms.Padding(2);
            this.gbBusqueda.Size = new System.Drawing.Size(497, 41);
            this.gbBusqueda.TabIndex = 18;
            this.gbBusqueda.TabStop = false;
            this.gbBusqueda.Text = "Busqueda";
            // 
            // btnCodProdSearch
            // 
            this.btnCodProdSearch.Location = new System.Drawing.Point(305, 13);
            this.btnCodProdSearch.Name = "btnCodProdSearch";
            this.btnCodProdSearch.Size = new System.Drawing.Size(75, 23);
            this.btnCodProdSearch.TabIndex = 2;
            this.btnCodProdSearch.Text = "Buscar";
            this.btnCodProdSearch.UseVisualStyleBackColor = true;
            this.btnCodProdSearch.Click += new System.EventHandler(this.btnCodProdSearch_Click);
            // 
            // txtCodProdSearch
            // 
            this.txtCodProdSearch.Location = new System.Drawing.Point(185, 15);
            this.txtCodProdSearch.Name = "txtCodProdSearch";
            this.txtCodProdSearch.Size = new System.Drawing.Size(114, 20);
            this.txtCodProdSearch.TabIndex = 0;
            this.txtCodProdSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodProdSearch_KeyPress);
            // 
            // lblCodProdSearch
            // 
            this.lblCodProdSearch.AutoSize = true;
            this.lblCodProdSearch.Location = new System.Drawing.Point(107, 18);
            this.lblCodProdSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodProdSearch.Name = "lblCodProdSearch";
            this.lblCodProdSearch.Size = new System.Drawing.Size(72, 13);
            this.lblCodProdSearch.TabIndex = 3;
            this.lblCodProdSearch.Text = "Cod Producto";
            // 
            // AltaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 290);
            this.Controls.Add(this.gbBusqueda);
            this.Controls.Add(this.btnProductosVendidosByCliente);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgwProductos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.groupBox1);
            this.Name = "AltaProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Producto";
            this.Load += new System.EventHandler(this.AltaProducto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProductos)).EndInit();
            this.gbBusqueda.ResumeLayout(false);
            this.gbBusqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnAltaProducto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioCategoria;
        private System.Windows.Forms.RadioButton radioDescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgwProductos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnProductosVendidosByCliente;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnModificarProducto;
        private System.Windows.Forms.GroupBox gbBusqueda;
        private System.Windows.Forms.Button btnCodProdSearch;
        private System.Windows.Forms.TextBox txtCodProdSearch;
        private System.Windows.Forms.Label lblCodProdSearch;
    }
}