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
    public partial class AltaCliente : Form
    {
        public AltaCliente()
        {
            InitializeComponent();
        }

        private void load_clientes()
        {
            dgwClientes.DataSource = ClienteABM.list_clientes();
        }

        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Cli_Dni = txtDni.Text;
            cliente.Cli_Apellido = txtApellido.Text;
            cliente.Cli_Nombre = txtNombre.Text;
            cliente.Cli_Direccion = txtDireccion.Text;
            cliente.Cli_Cuit = txtCuit.Text;
            cliente.Cli_NroCarnet = txtNroCarnet.Text;

            if (String.IsNullOrEmpty(txtDni.Text) || String.IsNullOrEmpty(txtApellido.Text) || String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtDireccion.Text) || String.IsNullOrEmpty(txtCuit.Text) || String.IsNullOrEmpty(txtNroCarnet.Text))
            {
                MessageBox.Show("Debe completar todos los campos antes de registrar un nuevo cliente", "Error al registrar");
            }
            else
            {
                ClienteABM.insert_cliente(cliente);
                load_clientes();
                txtDni.Text = null;
                txtApellido.Text = null;
                txtNombre.Text = null;
                txtDireccion.Text = null;
                txtCuit.Text = null;
                txtNroCarnet.Text = null;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Cli_Dni = txtDni.Text;
            cliente.Cli_Apellido = txtApellido.Text;
            cliente.Cli_Nombre = txtNombre.Text;
            cliente.Cli_Direccion = txtDireccion.Text;
            cliente.Cli_Cuit = txtCuit.Text;
            cliente.Cli_NroCarnet = txtNroCarnet.Text;

            if (String.IsNullOrEmpty(txtDni.Text) || String.IsNullOrEmpty(txtApellido.Text) || String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtDireccion.Text) || String.IsNullOrEmpty(txtCuit.Text) || String.IsNullOrEmpty(txtNroCarnet.Text))
            {
                MessageBox.Show("Debe completar todos los campos antes de modificar un cliente", "Error al modificar");
            }
            else
            {
                var respuesta = MessageBox.Show("¿Está seguro que desea modificar los datos?", "Advertencia", MessageBoxButtons.YesNo);
                if (respuesta == DialogResult.Yes)
                {
                    ClienteABM.modify_cliente(cliente);
                    MessageBox.Show("Datos modificados exitosamente");
                    load_clientes();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if ((String.IsNullOrEmpty(txtDniSearch.Text)) || (String.IsNullOrEmpty(txtCarnetSearch.Text)))
            {
                MessageBox.Show("Todos los campos de buqsueda son obligatorios", "Error al buscar");
                load_clientes();
            }
            else
            {
                dgwClientes.DataSource = ClienteABM.search_clientes(txtDniSearch.Text, txtCarnetSearch.Text);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("¿Está seguro que desea eliminar el cliente?", "Advertencia", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                ClienteABM.delete_cliente(txtDni.Text);
                MessageBox.Show("Datos del cliente eliminados exitosamente", "Eliminacion exitosa");
                load_clientes();
                txtDni.Text = null;
                txtApellido.Text = null;
                txtNombre.Text = null;
                txtDireccion.Text = null;
                txtCuit.Text = null;
                txtNroCarnet.Text = null;
            }
        }

        private void dgwClientes_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgwClientes.CurrentRow != null)
            {
                txtDni.Text = dgwClientes.CurrentRow.Cells["DNI"].Value.ToString();
                txtApellido.Text = dgwClientes.CurrentRow.Cells["Apellido"].Value.ToString();
                txtNombre.Text = dgwClientes.CurrentRow.Cells["Nombre"].Value.ToString();
                txtDireccion.Text = dgwClientes.CurrentRow.Cells["Direccion"].Value.ToString();
                txtCuit.Text = dgwClientes.CurrentRow.Cells["CUIT"].Value.ToString();
                txtNroCarnet.Text = dgwClientes.CurrentRow.Cells["N° Carnet"].Value.ToString();
            }
        }

        private void AltaCliente_Load(object sender, EventArgs e)
        {
            load_clientes();
        }

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblDniSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            AltaCliente.ActiveForm.Hide();
            FormMain.ActiveForm.Activate();
            FormMain.ActiveForm.Show();
            this.Close();
        }
       
    }
}
