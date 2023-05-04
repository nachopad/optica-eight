using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void btnIngresar_Click(object sender, EventArgs e)
        {
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
                string rolCodigo = usuarioABM.verificar_loginBD(txtUsername.Text, txtPassword.Text);
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

        private void IngContra_TextChanged(object sender, EventArgs e)
        {

        }

        private void IngUsu_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void IngUsu_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
        }

        private void IngContra_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
        }
    }
}
