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
    public partial class AltaProducto : Form
    {
        public AltaProducto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                string codigo = txtCodigo.Text;
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
                }
        }

       
    }
}
