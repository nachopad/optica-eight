namespace Vistas
{
    partial class FormMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nomUsu = new System.Windows.Forms.Label();
            this.tipoUsu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.navCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.navProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.navObraSocial = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nomUsu);
            this.groupBox1.Controls.Add(this.tipoUsu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bienvenido";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Usted tiene privelegios de: ";
            // 
            // nomUsu
            // 
            this.nomUsu.AutoSize = true;
            this.nomUsu.Location = new System.Drawing.Point(134, 31);
            this.nomUsu.Name = "nomUsu";
            this.nomUsu.Size = new System.Drawing.Size(0, 13);
            this.nomUsu.TabIndex = 2;
            this.nomUsu.Click += new System.EventHandler(this.nomUsu_Click);
            // 
            // tipoUsu
            // 
            this.tipoUsu.AutoSize = true;
            this.tipoUsu.Location = new System.Drawing.Point(134, 55);
            this.tipoUsu.Name = "tipoUsu";
            this.tipoUsu.Size = new System.Drawing.Size(0, 13);
            this.tipoUsu.TabIndex = 1;
            this.tipoUsu.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navCliente,
            this.navProducto,
            this.navObraSocial});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // navCliente
            // 
            this.navCliente.Name = "navCliente";
            this.navCliente.Size = new System.Drawing.Size(61, 20);
            this.navCliente.Text = "Clientes";
            this.navCliente.Click += new System.EventHandler(this.navCliente_Click);
            // 
            // navProducto
            // 
            this.navProducto.Name = "navProducto";
            this.navProducto.Size = new System.Drawing.Size(73, 20);
            this.navProducto.Text = "Productos";
            this.navProducto.Click += new System.EventHandler(this.navProducto_Click);
            // 
            // navObraSocial
            // 
            this.navObraSocial.Name = "navObraSocial";
            this.navObraSocial.Size = new System.Drawing.Size(79, 20);
            this.navObraSocial.Text = "Obra Social";
            this.navObraSocial.Click += new System.EventHandler(this.navObraSocial_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label nomUsu;
        private System.Windows.Forms.Label tipoUsu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem navCliente;
        private System.Windows.Forms.ToolStripMenuItem navProducto;
        private System.Windows.Forms.ToolStripMenuItem navObraSocial;
    }
}