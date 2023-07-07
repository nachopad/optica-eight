namespace Vistas
{
    partial class AltaCliente
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNroCarnet = new System.Windows.Forms.TextBox();
            this.BotonGuardar = new System.Windows.Forms.Button();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.cmbCuit = new System.Windows.Forms.ComboBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgwClientes = new System.Windows.Forms.DataGridView();
            this.lblDniSearch = new System.Windows.Forms.Label();
            this.lblCarnetSearch = new System.Windows.Forms.Label();
            this.gbBusqueda = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtCarnetSearch = new System.Windows.Forms.TextBox();
            this.txtDniSearch = new System.Windows.Forms.TextBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.gbOrdenar = new System.Windows.Forms.GroupBox();
            this.nuevo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwClientes)).BeginInit();
            this.gbBusqueda.SuspendLayout();
            this.gbOrdenar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "CUIT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "N° Carnet";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(105, 46);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(113, 20);
            this.txtApellido.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(105, 71);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(113, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(105, 97);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(113, 20);
            this.txtDireccion.TabIndex = 3;
            // 
            // txtNroCarnet
            // 
            this.txtNroCarnet.Location = new System.Drawing.Point(105, 149);
            this.txtNroCarnet.Name = "txtNroCarnet";
            this.txtNroCarnet.Size = new System.Drawing.Size(113, 20);
            this.txtNroCarnet.TabIndex = 5;
            this.txtNroCarnet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroCarnet_KeyPress);
            // 
            // BotonGuardar
            // 
            this.BotonGuardar.Location = new System.Drawing.Point(31, 186);
            this.BotonGuardar.Name = "BotonGuardar";
            this.BotonGuardar.Size = new System.Drawing.Size(75, 23);
            this.BotonGuardar.TabIndex = 6;
            this.BotonGuardar.Text = "Registrar";
            this.BotonGuardar.UseVisualStyleBackColor = true;
            this.BotonGuardar.Click += new System.EventHandler(this.BotonGuardar_Click);
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(105, 21);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(113, 20);
            this.txtDni.TabIndex = 0;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(35, 24);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 9;
            this.lblDni.Text = "DNI";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.cmbCuit);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.txtDni);
            this.groupBox1.Controls.Add(this.lblDni);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BotonGuardar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNroCarnet);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Location = new System.Drawing.Point(8, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(271, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Cliente";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(228, 21);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(31, 20);
            this.txtId.TabIndex = 5;
            this.txtId.Visible = false;
            // 
            // cmbCuit
            // 
            this.cmbCuit.FormattingEnabled = true;
            this.cmbCuit.Location = new System.Drawing.Point(105, 122);
            this.cmbCuit.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCuit.Name = "cmbCuit";
            this.cmbCuit.Size = new System.Drawing.Size(113, 21);
            this.cmbCuit.TabIndex = 5;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(111, 186);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(191, 186);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgwClientes
            // 
            this.dgwClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwClientes.Location = new System.Drawing.Point(289, 199);
            this.dgwClientes.Margin = new System.Windows.Forms.Padding(2);
            this.dgwClientes.Name = "dgwClientes";
            this.dgwClientes.RowTemplate.Height = 28;
            this.dgwClientes.Size = new System.Drawing.Size(462, 155);
            this.dgwClientes.TabIndex = 2;
            this.dgwClientes.CurrentCellChanged += new System.EventHandler(this.dgwClientes_CurrentCellChanged);
            // 
            // lblDniSearch
            // 
            this.lblDniSearch.AutoSize = true;
            this.lblDniSearch.Location = new System.Drawing.Point(153, 19);
            this.lblDniSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDniSearch.Name = "lblDniSearch";
            this.lblDniSearch.Size = new System.Drawing.Size(26, 13);
            this.lblDniSearch.TabIndex = 3;
            this.lblDniSearch.Text = "DNI";
            // 
            // lblCarnetSearch
            // 
            this.lblCarnetSearch.AutoSize = true;
            this.lblCarnetSearch.Location = new System.Drawing.Point(140, 44);
            this.lblCarnetSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCarnetSearch.Name = "lblCarnetSearch";
            this.lblCarnetSearch.Size = new System.Drawing.Size(53, 13);
            this.lblCarnetSearch.TabIndex = 4;
            this.lblCarnetSearch.Text = "N° Carnet";
            // 
            // gbBusqueda
            // 
            this.gbBusqueda.BackColor = System.Drawing.Color.Transparent;
            this.gbBusqueda.Controls.Add(this.btnSearch);
            this.gbBusqueda.Controls.Add(this.txtCarnetSearch);
            this.gbBusqueda.Controls.Add(this.txtDniSearch);
            this.gbBusqueda.Controls.Add(this.lblDniSearch);
            this.gbBusqueda.Controls.Add(this.lblCarnetSearch);
            this.gbBusqueda.Location = new System.Drawing.Point(289, 29);
            this.gbBusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.gbBusqueda.Name = "gbBusqueda";
            this.gbBusqueda.Padding = new System.Windows.Forms.Padding(2);
            this.gbBusqueda.Size = new System.Drawing.Size(462, 103);
            this.gbBusqueda.TabIndex = 17;
            this.gbBusqueda.TabStop = false;
            this.gbBusqueda.Text = "Busqueda";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(231, 65);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtCarnetSearch
            // 
            this.txtCarnetSearch.Location = new System.Drawing.Point(209, 42);
            this.txtCarnetSearch.Name = "txtCarnetSearch";
            this.txtCarnetSearch.Size = new System.Drawing.Size(114, 20);
            this.txtCarnetSearch.TabIndex = 1;
            this.txtCarnetSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCarnetSearch_KeyPress);
            // 
            // txtDniSearch
            // 
            this.txtDniSearch.Location = new System.Drawing.Point(209, 15);
            this.txtDniSearch.Name = "txtDniSearch";
            this.txtDniSearch.Size = new System.Drawing.Size(114, 20);
            this.txtDniSearch.TabIndex = 0;
            this.txtDniSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDniSearch_KeyPress);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(8, 1);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(95, 23);
            this.btnRegresar.TabIndex = 18;
            this.btnRegresar.Text = "Volver al Menu";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // gbOrdenar
            // 
            this.gbOrdenar.BackColor = System.Drawing.Color.Transparent;
            this.gbOrdenar.Controls.Add(this.nuevo);
            this.gbOrdenar.Location = new System.Drawing.Point(289, 136);
            this.gbOrdenar.Margin = new System.Windows.Forms.Padding(2);
            this.gbOrdenar.Name = "gbOrdenar";
            this.gbOrdenar.Padding = new System.Windows.Forms.Padding(2);
            this.gbOrdenar.Size = new System.Drawing.Size(462, 47);
            this.gbOrdenar.TabIndex = 19;
            this.gbOrdenar.TabStop = false;
            this.gbOrdenar.Text = "Ordenar por apellido";
            // 
            // nuevo
            // 
            this.nuevo.Location = new System.Drawing.Point(191, 13);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(75, 23);
            this.nuevo.TabIndex = 20;
            this.nuevo.Text = "Ordenar";
            this.nuevo.UseVisualStyleBackColor = true;
            this.nuevo.Click += new System.EventHandler(this.nuevo_Click);
            // 
            // AltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 379);
            this.Controls.Add(this.gbOrdenar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.gbBusqueda);
            this.Controls.Add(this.dgwClientes);
            this.Controls.Add(this.groupBox1);
            this.Name = "AltaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Cliente";
            this.Load += new System.EventHandler(this.AltaCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwClientes)).EndInit();
            this.gbBusqueda.ResumeLayout(false);
            this.gbBusqueda.PerformLayout();
            this.gbOrdenar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNroCarnet;
        private System.Windows.Forms.Button BotonGuardar;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgwClientes;
        private System.Windows.Forms.Label lblDniSearch;
        private System.Windows.Forms.Label lblCarnetSearch;
        private System.Windows.Forms.GroupBox gbBusqueda;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtCarnetSearch;
        private System.Windows.Forms.TextBox txtDniSearch;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.ComboBox cmbCuit;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.GroupBox gbOrdenar;
        private System.Windows.Forms.Button nuevo;
    }
}