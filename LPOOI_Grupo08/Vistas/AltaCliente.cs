﻿using System;
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
    public partial class AltaCliente : Form
    {
        public AltaCliente()
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
                    Color.OrangeRed, Color.Yellow, LinearGradientMode.ForwardDiagonal);
                e.Graphics.FillRegion(gradiente, new Region(forma));
            }
        }

        private void load_clientes()
        {
            dgwClientes.DataSource = ClienteABM.list_clientes_sp();
        }

        private void load_combo_obrasSocialesCuit()
        {
            cmbCuit.DisplayMember = "os_razon_social";
            cmbCuit.ValueMember = "os_cuit";
            cmbCuit.DataSource = ClienteABM.list_ObrasSocialesCuit_sp();
        }

        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Cli_Dni = txtDni.Text;
            cliente.Cli_Apellido = txtApellido.Text;
            cliente.Cli_Nombre = txtNombre.Text;
            cliente.Cli_Direccion = txtDireccion.Text;
            cliente.Cli_Cuit = (string)cmbCuit.SelectedValue;
            cliente.Cli_NroCarnet = txtNroCarnet.Text;

            if (String.IsNullOrEmpty(txtDni.Text) || String.IsNullOrEmpty(txtApellido.Text) || String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtDireccion.Text) || String.IsNullOrEmpty(cmbCuit.Text) || String.IsNullOrEmpty(txtNroCarnet.Text))
            {
                MessageBox.Show("Debe completar todos los campos antes de registrar un nuevo cliente", "Error al registrar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var respuesta = MessageBox.Show("¿Está seguro que desea registrar los datos?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    if (ClienteABM.search_dni_sp(cliente.Cli_Dni) == true)
                    {
                        ClienteABM.insert_cliente_sp(cliente);
                        load_clientes();
                        txtId.Text = null;
                        txtDni.Text = null;
                        txtApellido.Text = null;
                        txtNombre.Text = null;
                        txtDireccion.Text = null;
                        cmbCuit.Text = null;
                        txtNroCarnet.Text = null;
                    }
                    else
                    {
                        MessageBox.Show("Ya existe un cliente registrado con el DNI aplicado","Errror al registrar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Equals(""))
            {
                MessageBox.Show("Debe seleccionar un cliente antes de realizar una modificacion", "Error al modificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {      
                Cliente cliente = new Cliente();
                cliente.Cli_Id = Int32.Parse(txtId.Text);
                cliente.Cli_Dni = txtDni.Text;
                cliente.Cli_Apellido = txtApellido.Text;
                cliente.Cli_Nombre = txtNombre.Text;
                cliente.Cli_Direccion = txtDireccion.Text;
                cliente.Cli_Cuit = (string)cmbCuit.SelectedValue;
                cliente.Cli_NroCarnet = txtNroCarnet.Text;

                if (String.IsNullOrEmpty(txtDni.Text) || String.IsNullOrEmpty(txtApellido.Text) || String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtDireccion.Text) || String.IsNullOrEmpty(cmbCuit.Text) || String.IsNullOrEmpty(txtNroCarnet.Text))
                {
                    MessageBox.Show("Debe completar todos los campos antes de modificar un cliente", "Error al modificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    var respuesta = MessageBox.Show("¿Está seguro que desea modificar los datos?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        try
                        {
                            ClienteABM.modify_cliente_sp(cliente);
                            MessageBox.Show("Datos modificados exitosamente");
                            load_clientes();
                        }
                        catch
                        {
                            MessageBox.Show("Ya existe un cliente registrado con el DNI a modificar", "Errror al modificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if ((String.IsNullOrEmpty(txtDniSearch.Text)) || (String.IsNullOrEmpty(txtCarnetSearch.Text)))
            {
                load_clientes();
            }
            else
            {
                dgwClientes.DataSource = ClienteABM.search_clientes_sp(txtDniSearch.Text, txtCarnetSearch.Text);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("¿Está seguro que desea eliminar el cliente?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                ClienteABM.delete_cliente_sp(txtDni.Text);
                MessageBox.Show("Datos del cliente eliminados exitosamente", "Eliminacion exitosa");
                load_clientes();
                txtId.Text = null;
                txtDni.Text = null;
                txtApellido.Text = null;
                txtNombre.Text = null;
                txtDireccion.Text = null;
                cmbCuit.Text = null;
                txtNroCarnet.Text = null;
            }
        }

        private void dgwClientes_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgwClientes.CurrentRow != null)
            {
                if (dgwClientes.CurrentRow.Cells["CUIT"].Value.ToString() == null)
                {
                    cmbCuit.SelectedValue = dgwClientes.CurrentRow.Cells["CUIT"].Value.ToString();
                }
                txtId.Text = dgwClientes.CurrentRow.Cells["cli_id"].Value.ToString();
                txtDni.Text = dgwClientes.CurrentRow.Cells["DNI"].Value.ToString();
                txtApellido.Text = dgwClientes.CurrentRow.Cells["Apellido"].Value.ToString();
                txtNombre.Text = dgwClientes.CurrentRow.Cells["Nombre"].Value.ToString();
                txtDireccion.Text = dgwClientes.CurrentRow.Cells["Direccion"].Value.ToString();
                cmbCuit.SelectedValue = dgwClientes.CurrentRow.Cells["CUIT"].Value.ToString();
                txtNroCarnet.Text = dgwClientes.CurrentRow.Cells["N° Carnet"].Value.ToString();
            }
        }

        private void AltaCliente_Load(object sender, EventArgs e)
        {
            load_clientes();
            load_combo_obrasSocialesCuit();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            AltaCliente.ActiveForm.Hide();
            FormMain.ActiveForm.Activate();
            FormMain.ActiveForm.Show();
            this.Close();
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            dgwClientes.DataSource = ClienteABM.ordenar_clientes_apellidos_sp();
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("El DNI debe ser numérico.", "Validación DNI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

            string currentText = txtDni.Text;

            if (currentText.Length >= 8 && e.KeyChar != '\b')
            {
                MessageBox.Show("El DNI debe tener máximo 8 caracteres.", "Validación DNI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void txtNroCarnet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("El Carnet debe ser numérico.", "Validación Carnet", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtDniSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("El DNI debe ser numérico.", "Validación DNI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

            string currentText = txtDniSearch.Text;

            if (currentText.Length >= 8 && e.KeyChar != '\b')
            {
                MessageBox.Show("El DNI debe tener máximo 8 caracteres.", "Validación DNI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void txtCarnetSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("El Carnet debe ser numérico.", "Validación Carnet", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
       
    }
}
