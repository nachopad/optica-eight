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
    public partial class FormVenta : Form
    {
        public FormVenta()
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

        private void FormVenta_Load(object sender, EventArgs e)
        {
            load_comboProductos();
        }

        private void load_comboProductos()
        {
            cmbProducto.DisplayMember = "prod_descripcion";
            cmbProducto.ValueMember = "prod_codigo";
            cmbProducto.DataSource = ProductoABM.list_productos();
        }

        private void btnRealizarVenta_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCantidad.Text) || String.IsNullOrEmpty(txtDni.Text))
            {
                MessageBox.Show("Debe ingresar todos los campos", "Venta", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }else{
                var respuesta = MessageBox.Show("¿Desea realizar la venta?", "Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                // Venta
                ABMVentas.insert_venta(dtpFechaVenta.Value, txtDni.Text);

                // Me permite obtener el nro de venta
                int nro = ABMVentas.get_NroVenta(txtDni.Text);
                decimal precio = ProductoABM.get_Precio_sp(cmbProducto.SelectedValue.ToString());

                //Detalle Venta
                decimal total = precio * Convert.ToDecimal(txtCantidad.Text);
                txtTotal.Text = total.ToString();
                ABMVentas.insert_ventaDetalle(nro, cmbProducto.SelectedValue.ToString(), precio, Convert.ToDecimal(txtCantidad.Text), total);
                MessageBox.Show("La venta se ha concretado exitosamente", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            }
            
        }

        private void btnVerVentas_Click(object sender, EventArgs e)
        {
            FormVerVentas ver = new FormVerVentas();
            ver.Show();
        }

        private void load_precio()
        {
           decimal precio = ProductoABM.get_Precio_sp(cmbProducto.SelectedValue.ToString());
           txtPrecio.Text = "$" + precio.ToString();
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_precio();
            txtCantidad_TextChanged(sender, e);
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!txtCantidad.Text.Equals(""))
                {
                    if (txtCantidad.Text.Equals("0"))
                    {
                        MessageBox.Show("La cantidad no puede ser 0");
                        txtCantidad.Text = "";
                    }
                    else
                    {
                        decimal precio = ProductoABM.get_Precio_sp(cmbProducto.SelectedValue.ToString());
                        decimal total = precio * Convert.ToDecimal(txtCantidad.Text);
                        txtTotal.Text = "$"+total.ToString();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Debe ingresar valores numericos");
                txtCantidad.Text = "";
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormMain.ActiveForm.Activate();
            FormMain.ActiveForm.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string busqueda = "";
            if (radioApellido.Checked)
            {
                busqueda = "Apellido";
            }
            if (radioNombre.Checked)
            {
                busqueda = "Nombre";
            }
            if (radioDni.Checked)
            {
                busqueda = "Dni";
            }
            this.dgwCliente.DataSource = ClienteABM.search_clientes_nombreApellidoDni_sp(txtDniSearch.Text, txtNombre.Text, txtApellido.Text, busqueda);
            if (dgwCliente.RowCount == 1)
            {
                MessageBox.Show("No existen clientes registrados con los datos ingresados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dgwCliente.Visible = false;
                labelBusqueda.Visible = true;
            }
            else
            {
                dgwCliente.Visible = true;
                labelBusqueda.Visible = false;
                txtDni.Text = dgwCliente.CurrentRow.Cells["DNI"].Value.ToString();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        
    }
}
