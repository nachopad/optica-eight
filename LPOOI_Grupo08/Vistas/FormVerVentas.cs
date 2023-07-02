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
    public partial class FormVerVentas : Form
    {
        public FormVerVentas()
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

        private void load_venta()
        {
            dgwVenta.DataSource = ABMVentas.list_venta();
        }

        private void FormVerVentas_Load(object sender, EventArgs e)
        {
            load_venta();
        }

        private void dgwVenta_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgwVenta.CurrentRow != null)
            {
                txtNVenta.Text = dgwVenta.CurrentRow.Cells["N°"].Value.ToString();
                txtFechaVenta.Text = dgwVenta.CurrentRow.Cells["Fecha"].Value.ToString();
                txtDNI.Text = dgwVenta.CurrentRow.Cells["Cliente"].Value.ToString();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            load_venta();
        }

        private void btnFecha_Click(object sender, EventArgs e)
        {
            FormFiltrarVenta filtrar = new FormFiltrarVenta();
            filtrar.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if ((String.IsNullOrEmpty(txtDniSearch.Text)))
            {
                load_venta();
            }
            else
            {
                dgwVenta.DataSource = ABMVentas.list_ventasByCliente(txtDniSearch.Text);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("¿Está seguro que desea dar de baja la venta?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                ABMVentas.delete_venta(txtNVenta.Text);
                MessageBox.Show("La venta fue dada de baja exitosamente", "Baja exitosa");
                load_venta();
            }
            else
            {
                MessageBox.Show("Operacion cancelada", "Baja cancelada");
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


    }
}
