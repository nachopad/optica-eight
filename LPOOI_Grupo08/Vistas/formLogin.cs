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
            Rectangle Forma = new Rectangle(new Point(0, 0), this.ClientSize);
            LinearGradientBrush Gradiente = new LinearGradientBrush(Forma,
            Color.Cyan, Color.Blue,

           LinearGradientMode.Vertical);
            e.Graphics.FillRegion(Gradiente, new Region(Forma));
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {   //El punto 1 se ha comentado, ya que con la implementación del punto 11
            //se utiliza la Base de Datos para la verificacion del acceso al sistema.

            /*
            Roles administrador= new Roles(1,"Administrador");
            Roles operador= new Roles(2,"Operador");
            Roles auditor= new Roles(3, "Auditor");
            List<Roles> listRoles = new List<Roles>();
            listRoles.Add(administrador);
            listRoles.Add(operador);
            listRoles.Add(auditor);

            Usuario juan= new Usuario(administrador.Rol_Codigo,"Perez Juan","juan","123");
            Usuario pepe= new Usuario(operador.Rol_Codigo,"Argento Pepe","pepe","456");
            Usuario bart= new Usuario(auditor.Rol_Codigo,"Simpson Bart","el barto","789");

            List<Usuario>listUsers=new List<Usuario>();
            listUsers.Add(juan);
            listUsers.Add(pepe);
            listUsers.Add(bart);
           
            Usuario buscarUsu= listUsers.Find(p => p.Usu_NombreUsuario.Equals(IngUsu.Text));
            
            if (buscarUsu != null && buscarUsu.Usu_Contrasena.Equals(IngContra.Text))
            {
               Roles tipoUsu = listRoles.Find(b => b.Rol_Codigo.Equals(buscarUsu.Rol_Id));
               FormMain formMain = new FormMain(buscarUsu, tipoUsu.Rol_Descripcion);
               formLogin.ActiveForm.Hide();
               formMain.Show();

            }
            else{
                 MessageBox.Show("Usuario o Contraseña no son validos");   
            }
            */

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

        private void IngContra_TextChanged(object sender, EventArgs e)
        {

        }

        private void IngUsu_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
    }
}
