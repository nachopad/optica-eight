namespace Vistas
{
    partial class FormBuscarCliente
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.dgwCliente = new System.Windows.Forms.DataGridView();
            this.labelBusqueda = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioDni = new System.Windows.Forms.RadioButton();
            this.radioApellido = new System.Windows.Forms.RadioButton();
            this.radioNombre = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCliente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(10, 36);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(154, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(167, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(170, 36);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(154, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(327, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "DNI";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(330, 36);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(154, 20);
            this.txtDni.TabIndex = 5;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // dgwCliente
            // 
            this.dgwCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCliente.Location = new System.Drawing.Point(12, 138);
            this.dgwCliente.Name = "dgwCliente";
            this.dgwCliente.Size = new System.Drawing.Size(647, 237);
            this.dgwCliente.TabIndex = 8;
            // 
            // labelBusqueda
            // 
            this.labelBusqueda.AutoSize = true;
            this.labelBusqueda.BackColor = System.Drawing.Color.Transparent;
            this.labelBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBusqueda.Location = new System.Drawing.Point(218, 246);
            this.labelBusqueda.Name = "labelBusqueda";
            this.labelBusqueda.Size = new System.Drawing.Size(235, 20);
            this.labelBusqueda.TabIndex = 9;
            this.labelBusqueda.Text = "Debe realizar una busqueda";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.radioDni);
            this.groupBox1.Controls.Add(this.radioApellido);
            this.groupBox1.Controls.Add(this.radioNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDni);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Location = new System.Drawing.Point(13, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 96);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar por";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(82, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ordenar por:";
            // 
            // radioDni
            // 
            this.radioDni.AutoSize = true;
            this.radioDni.Location = new System.Drawing.Point(299, 62);
            this.radioDni.Name = "radioDni";
            this.radioDni.Size = new System.Drawing.Size(44, 17);
            this.radioDni.TabIndex = 9;
            this.radioDni.Text = "DNI";
            this.radioDni.UseVisualStyleBackColor = true;
            // 
            // radioApellido
            // 
            this.radioApellido.AutoSize = true;
            this.radioApellido.Location = new System.Drawing.Point(231, 62);
            this.radioApellido.Name = "radioApellido";
            this.radioApellido.Size = new System.Drawing.Size(62, 17);
            this.radioApellido.TabIndex = 8;
            this.radioApellido.Text = "Apellido";
            this.radioApellido.UseVisualStyleBackColor = true;
            // 
            // radioNombre
            // 
            this.radioNombre.AutoSize = true;
            this.radioNombre.Checked = true;
            this.radioNombre.Location = new System.Drawing.Point(163, 62);
            this.radioNombre.Name = "radioNombre";
            this.radioNombre.Size = new System.Drawing.Size(62, 17);
            this.radioNombre.TabIndex = 7;
            this.radioNombre.TabStop = true;
            this.radioNombre.Text = "Nombre";
            this.radioNombre.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(292, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Clientes";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(514, 48);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(145, 23);
            this.btnFiltrar.TabIndex = 12;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(514, 77);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(145, 23);
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.Text = "Volver al Menú";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormBuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 394);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelBusqueda);
            this.Controls.Add(this.dgwCliente);
            this.Name = "FormBuscarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Clientes";
            this.Load += new System.EventHandler(this.FormBuscarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCliente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.DataGridView dgwCliente;
        private System.Windows.Forms.Label labelBusqueda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioDni;
        private System.Windows.Forms.RadioButton radioApellido;
        private System.Windows.Forms.RadioButton radioNombre;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label5;
    }
}