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


    }
}
