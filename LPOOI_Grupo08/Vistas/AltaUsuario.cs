﻿using System;
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
            //Se decidió utilizar un try/catch en este metodo ya que al borrar el cmbRol, no puede
            //realizar la conversión correctamente y tira un error en tiempo de ejecución. De esta manera se soluciona.
            try 
            {
                Usuario oUser = new Usuario();
                oUser.Rol_Id = (int)cmbRol.SelectedValue;
                oUser.Usu_ApellidoNombre = txtApellidoNombre.Text;
                oUser.Usu_NombreUsuario = txtUsername.Text;
                oUser.Usu_Contrasena = txtPassword.Text;

                if (String.IsNullOrEmpty(cmbRol.Text) || String.IsNullOrEmpty(txtApellidoNombre.Text) || String.IsNullOrEmpty(txtUsername.Text) || String.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Debe completar todos los campos antes de registrar un nuevo usuario", "Error al registrar");
                }
                else
                {
                    var respuesta = MessageBox.Show("¿Está seguro que desea registrar los datos?", "Advertencia", MessageBoxButtons.YesNo);
                    if (respuesta == DialogResult.Yes)
                    {
                        UsuarioABM.insert_usuario(oUser);
                        load_usuarios();
                        cmbRol.Text = null;
                        txtApellidoNombre.Text = null;
                        txtUsername.Text = null;
                        txtPassword.Text = null;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Debe completar todos los campos antes de registrar un nuevo usuario", "Error al registrar");
            }
            
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
            usuario.Usu_ID = Int32.Parse(txtId.Text);
            usuario.Rol_Id = (int)cmbRol.SelectedValue;
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
                    UsuarioABM.modify_cliente(usuario);
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