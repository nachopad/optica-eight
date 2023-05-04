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
    public partial class AltaUsuario : Form
    {
        public AltaUsuario()
        {
            InitializeComponent();
        }

        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            Usuario oUser = new Usuario();
            oUser.Rol_Id = (int)cmbRol.SelectedValue;
            oUser.Usu_ApellidoNombre = txtApellidoNombre.Text;
            oUser.Usu_NombreUsuario = txtUsername.Text;
            oUser.Usu_Contrasena = txtPassword.Text;

            UsuarioABM.insert_usuario(oUser);

            load_usuarios();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("¿Está seguro que desea eliminar el usuario?", "Advertencia", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                UsuarioABM.delete_usuario(txtId.Text);
                MessageBox.Show("Datos del usuario eliminados exitosamente", "Aviso");
                load_usuarios();
                txtId.Text = null;
                txtRolCodigo.Text = null;
                cmbRol.Text = null;
                txtUsername.Text = null;
                txtPassword.Text = null;
                txtApellidoNombre.Text = null;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Usu_NombreUsuario = txtUsername.Text;
            usuario.Usu_Contrasena = txtPassword.Text;
            usuario.Usu_ApellidoNombre = txtApellidoNombre.Text;

            if (String.IsNullOrEmpty(cmbRol.Text) || String.IsNullOrEmpty(txtUsername.Text) || String.IsNullOrEmpty(txtPassword.Text) || String.IsNullOrEmpty(txtApellidoNombre.Text))
            {
                MessageBox.Show("Debe completar todos los campos antes de modificar un usuario", "Error al modificar");
            }
            else
            {
                var respuesta = MessageBox.Show("¿Está seguro que desea modificar los datos?", "Advertencia", MessageBoxButtons.YesNo);
                if (respuesta == DialogResult.Yes)
                {
                    UsuarioABM.modify_cliente(usuario, txtId.Text, txtRolCodigo.Text);
                    MessageBox.Show("Datos modificados exitosamente", "Aviso");
                    load_usuarios();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtUsuarioSearch.Text != "")
            {
                dgwUsuarios.DataSource = UsuarioABM.search_usuarios(txtUsuarioSearch.Text);
            }
            else
            {
                load_usuarios();
            }
        }

        private void load_combo_roles()
        {
            cmbRol.DisplayMember = "rol_descripcion";
            cmbRol.ValueMember = "rol_codigo";
            cmbRol.DataSource = UsuarioABM.list_roles();
        }

        private void load_usuarios()
        {
            dgwUsuarios.DataSource = UsuarioABM.list_usuarios();
        }

        private void AltaUsuario_Load(object sender, EventArgs e)
        {
            load_combo_roles();

            load_usuarios();
        }

        private void dgwUsuarios_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgwUsuarios.CurrentRow != null)
            {
                txtId.Text = dgwUsuarios.CurrentRow.Cells["usu_id"].Value.ToString();
                txtRolCodigo.Text = dgwUsuarios.CurrentRow.Cells["rol_codigo"].Value.ToString();
                cmbRol.SelectedValue = dgwUsuarios.CurrentRow.Cells["rol_codigo"].Value.ToString();
                txtUsername.Text = dgwUsuarios.CurrentRow.Cells["Usuario"].Value.ToString();
                txtPassword.Text = dgwUsuarios.CurrentRow.Cells["Contraseña"].Value.ToString();
                txtApellidoNombre.Text = dgwUsuarios.CurrentRow.Cells["Apellido y Nombre"].Value.ToString();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            AltaUsuario.ActiveForm.Hide();
            FormMain.ActiveForm.Activate();
            FormMain.ActiveForm.Show();
            this.Close();
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
