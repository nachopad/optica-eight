namespace Vistas
{
    partial class formLogin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IngUsu = new System.Windows.Forms.TextBox();
            this.IngContra = new System.Windows.Forms.TextBox();
            this.btnIngresar_Click = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese Usuario: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese Contraseña: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIngresar_Click);
            this.groupBox1.Controls.Add(this.IngContra);
            this.groupBox1.Controls.Add(this.IngUsu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(30, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 206);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // IngUsu
            // 
            this.IngUsu.Location = new System.Drawing.Point(112, 40);
            this.IngUsu.Name = "IngUsu";
            this.IngUsu.Size = new System.Drawing.Size(100, 20);
            this.IngUsu.TabIndex = 2;
            // 
            // IngContra
            // 
            this.IngContra.Location = new System.Drawing.Point(112, 73);
            this.IngContra.Name = "IngContra";
            this.IngContra.Size = new System.Drawing.Size(100, 20);
            this.IngContra.TabIndex = 3;
            // 
            // btnIngresar_Click
            // 
            this.btnIngresar_Click.Location = new System.Drawing.Point(112, 151);
            this.btnIngresar_Click.Name = "btnIngresar_Click";
            this.btnIngresar_Click.Size = new System.Drawing.Size(98, 28);
            this.btnIngresar_Click.TabIndex = 4;
            this.btnIngresar_Click.Text = "Ingresar";
            this.btnIngresar_Click.UseVisualStyleBackColor = true;
            this.btnIngresar_Click.Click += new System.EventHandler(this.btnIngresar_Click_Click);
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.groupBox1);
            this.Name = "formLogin";
            this.Text = "formLogin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIngresar_Click;
        private System.Windows.Forms.TextBox IngContra;
        private System.Windows.Forms.TextBox IngUsu;
    }
}