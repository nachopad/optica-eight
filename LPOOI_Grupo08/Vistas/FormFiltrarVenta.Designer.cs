namespace Vistas
{
    partial class FormFiltrarVenta
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
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.tablaFechas = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fechaFinal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.fechaInicio = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.tablaFechas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(110, 206);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(130, 43);
            this.btnFiltrar.TabIndex = 0;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // tablaFechas
            // 
            this.tablaFechas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaFechas.Location = new System.Drawing.Point(18, 18);
            this.tablaFechas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tablaFechas.Name = "tablaFechas";
            this.tablaFechas.Size = new System.Drawing.Size(524, 288);
            this.tablaFechas.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.fechaFinal);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.fechaInicio);
            this.groupBox1.Controls.Add(this.btnFiltrar);
            this.groupBox1.Location = new System.Drawing.Point(550, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(249, 288);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha Final";
            // 
            // fechaFinal
            // 
            this.fechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaFinal.Location = new System.Drawing.Point(44, 142);
            this.fechaFinal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fechaFinal.Name = "fechaFinal";
            this.fechaFinal.Size = new System.Drawing.Size(164, 26);
            this.fechaFinal.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha Inicio";
            // 
            // fechaInicio
            // 
            this.fechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaInicio.Location = new System.Drawing.Point(45, 58);
            this.fechaInicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.Size = new System.Drawing.Size(162, 26);
            this.fechaInicio.TabIndex = 1;
            // 
            // FormFiltrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 402);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tablaFechas);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormFiltrarVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtro de venta por fecha";
            this.Load += new System.EventHandler(this.FormFiltrarVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaFechas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DataGridView tablaFechas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fechaFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fechaInicio;
    }
}