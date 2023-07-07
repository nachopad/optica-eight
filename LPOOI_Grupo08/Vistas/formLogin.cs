using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using ClasesBase;

namespace Vistas
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);
            if (this.ClientSize.Width > 0 && this.ClientSize.Height > 0)
            {
                Rectangle forma = new Rectangle(new Point(0, 0), this.ClientSize);
                LinearGradientBrush gradiente = new LinearGradientBrush(forma,
                    Color.Cyan, Color.Blue, LinearGradientMode.Vertical);
                e.Graphics.FillRegion(gradiente, new Region(forma));
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {   
            try
            {
                UsuarioABM usuarioABM = new UsuarioABM();
                string rolCodigo = usuarioABM.verificar_loginBD_sp(txtUsername.Text, txtPassword.Text);
                MessageBox.Show("Bienvenido de nuevo " + txtUsername.Text, "Acceso al Sistema");
                formLogin.ActiveForm.Hide();
                FormMain principal = new FormMain();
                principal.verificar_login(txtUsername.Text , rolCodigo);
                principal.Show();
            }
            catch
            {
                MessageBox.Show("Acceso denegado. Verifique los datos colocados.");
            }
            
        }

        private void btnIngresar_MouseHover(object sender, EventArgs e)
        {
            btnIngresar.BackColor = Color.Red;
            btnIngresar.Font = new Font(btnIngresar.Font, FontStyle.Bold);
        }

        private void btnIngresar_MouseLeave(object sender, EventArgs e)
        {
            btnIngresar.BackColor = SystemColors.Control;
            btnIngresar.ForeColor = SystemColors.ControlText;
        }

        private void IngUsu_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
        }

        private void IngContra_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
    }
}
