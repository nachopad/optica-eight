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
    public partial class AltaCliente : Form
    {
        public AltaCliente()
        {
            InitializeComponent();
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);
            Rectangle Forma = new Rectangle(new Point(0, 0), this.ClientSize);
            LinearGradientBrush Gradiente = new LinearGradientBrush(Forma,
            Color.OrangeRed, Color.Yellow,

           LinearGradientMode.ForwardDiagonal);
            e.Graphics.FillRegion(Gradiente, new Region(Forma));
        }

        private void load_clientes()
        {
            dgwClientes.DataSource = ClienteABM.list_clientes();
        }

        private void load_combo_obrasSocialesCuit()
        {
            cmbCuit.DisplayMember = "os_razon_social";
            cmbCuit.ValueMember = "os_cuit";
            cmbCuit.DataSource = ClienteABM.list_ObrasSocialesCuit();
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
                    ClienteABM.insert_cliente(cliente);
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
                        ClienteABM.modify_cliente(cliente);
                        MessageBox.Show("Datos modificados exitosamente");
                        load_clientes();
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
                dgwClientes.DataSource = ClienteABM.search_clientes(txtDniSearch.Text, txtCarnetSearch.Text);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("¿Está seguro que desea eliminar el cliente?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                ClienteABM.delete_cliente(txtDni.Text);
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
