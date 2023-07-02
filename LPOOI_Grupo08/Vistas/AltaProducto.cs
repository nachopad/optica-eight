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
    public partial class AltaProducto : Form
    {
        public AltaProducto()
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

        
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            AltaProducto.ActiveForm.Hide();
            FormMain.ActiveForm.Activate();
            FormMain.ActiveForm.Show();
            this.Close();
        }

        private void radioDescripcion_CheckedChanged(object sender, EventArgs e)
        {
            dgwProductos.DataSource = ProductoABM.list_producto_order_by_Descripcion();
        }

        private void radioCategoria_CheckedChanged(object sender, EventArgs e)
        {
            dgwProductos.DataSource = ProductoABM.list_producto_order_by_Categoria();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormFiltroProducto tablaFiltro = new FormFiltroProducto();
            tablaFiltro.Show();
        }

        private void btnProductosVendidosByCliente_Click(object sender, EventArgs e)
        {
            FormProductosVendidosByCliente producto = new FormProductosVendidosByCliente();
            producto.Show();
        }

        private void btnCodProdSearch_Click(object sender, EventArgs e)
        {
            if ((String.IsNullOrEmpty(txtCodigo.Text)))
            {
                load_productos();
            }
            else
            {
                dgwProductos.DataSource = ProductoABM.search_product_sp(txtCodProdSearch.Text);
            }
        }

        private void load_productos()
        {
            dgwProductos.DataSource = ProductoABM.list_productos_sp();
        }

        private void btnAltaProducto_Click_1(object sender, EventArgs e)
        {

            Producto producto = new Producto();
            producto.Prod_Codigo = txtCodigo.Text;
            producto.Prod_Categoria = txtCategoria.Text;
            producto.Prod_Descripcion = txtDescripcion.Text;
            decimal precio;
            bool success = decimal.TryParse(txtPrecio.Text, out precio);
            producto.Prod_Precio = precio;


            if (String.IsNullOrEmpty(txtCodigo.Text) || String.IsNullOrEmpty(txtCategoria.Text) || String.IsNullOrEmpty(txtDescripcion.Text) || String.IsNullOrEmpty(txtPrecio.Text))
            {
                MessageBox.Show("Debe completar todos los campos antes de registrar un nuevo Producto", "Error al registrar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var respuesta = MessageBox.Show("¿Está seguro que desea registrar los datos?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    if (ProductoABM.search_codigo_sp(producto.Prod_Codigo) == true)
                    {
                        ProductoABM.insert_producto_sp(producto);
                        load_productos();
                        txtCodigo.Text = null;
                        txtCategoria.Text = null;
                        txtDescripcion.Text = null;
                        txtPrecio.Text = null;
                    }
                    else
                    {
                        MessageBox.Show("Ya existe un producto registrado con el CODIGO DE PRODUCTO ingresado", "Errror al registrar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }

            /*string codigo = txtCodigo.Text;
                string categoria = txtCategoria.Text;
                string descripcion = txtDescripcion.Text;
                decimal precio;
                bool success = decimal.TryParse(txtPrecio.Text, out precio);

                if (string.IsNullOrEmpty(codigo) || string.IsNullOrEmpty(categoria) || string.IsNullOrEmpty(descripcion) || !success)
                    MessageBox.Show("Todos los campos son obligatorios");
                else if (MessageBox.Show("¿Está seguro que desea continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Producto producto = new Producto(codigo, categoria, descripcion, precio);
                    MessageBox.Show("Producto Guardado: " + producto.ToString());
                }*/
        }

        

        private void AltaProducto_Load(object sender, EventArgs e)
        {
            load_productos();
        }

        private void btnModificarProducto_Click_1(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Equals(""))
            {
                MessageBox.Show("Debe seleccionar un Producto antes de realizar una modificacion", "Error al modificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Producto producto = new Producto();
                producto.Prod_Codigo = txtCodigo.Text;
                producto.Prod_Categoria = txtCategoria.Text;
                producto.Prod_Descripcion = txtDescripcion.Text;
                decimal precio;
                bool success = decimal.TryParse(txtPrecio.Text, out precio);
                producto.Prod_Precio = precio;

                if (String.IsNullOrEmpty(txtCodigo.Text) || String.IsNullOrEmpty(txtCategoria.Text) || String.IsNullOrEmpty(txtDescripcion.Text) || String.IsNullOrEmpty(txtPrecio.Text))
                {
                    MessageBox.Show("Debe completar todos los campos antes de modificar un producto", "Error al modificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    var respuesta = MessageBox.Show("¿Está seguro que desea modificar los datos?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        try
                        {
                            ProductoABM.modify_producto_sp(producto);
                            MessageBox.Show("Datos modificados exitosamente");
                            load_productos();
                        }
                        catch
                        {
                            MessageBox.Show("Ya existe un producto registrado con el codigo a modificar", "Errror al modificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
            }
        }

        private void dgwProductos_CurrentCellChanged_1(object sender, EventArgs e)
        {
            if (dgwProductos.CurrentRow != null)
            {
               
                txtCodigo.Text = dgwProductos.CurrentRow.Cells["Codigo Producto"].Value.ToString();
                txtCategoria.Text = dgwProductos.CurrentRow.Cells["Categoria"].Value.ToString();
                txtDescripcion.Text = dgwProductos.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtPrecio.Text = dgwProductos.CurrentRow.Cells["Precio"].Value.ToString();
                
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("¿Está seguro que desea eliminar el producto?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                ProductoABM.delete_product_sp(txtCodigo.Text);
                MessageBox.Show("Datos del producto eliminados exitosamente", "Eliminacion exitosa");
                load_productos();
                txtCodigo.Text = null;
                txtCategoria.Text = null;
                txtDescripcion.Text = null;
                txtPrecio.Text = null;
                
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("El codigo debe ser numérico.", "Validación codigo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("El precio debe ser numérico.", "Validación precio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCodProdSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("El codigo debe ser numérico.", "Validación codigo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

      
        }
}


 

   
       
    
