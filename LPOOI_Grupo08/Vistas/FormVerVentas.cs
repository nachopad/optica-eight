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

        //agregue yo
        private void load_combo_clientes()
        {
            cmbFiltroCliente.DisplayMember = "cli_dni";
            cmbFiltroCliente.ValueMember = "cli_dni";
            cmbFiltroCliente.DataSource = ABMVentas.get_clientes_sp();
        }

        private void FormVerVentas_Load(object sender, EventArgs e)
        {
            load_venta();
            load_combo_clientes();
        }

        private void dgwVenta_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgwVenta.CurrentRow != null)
            {
                txtNVenta.Text = dgwVenta.CurrentRow.Cells["ven_nro"].Value.ToString();
                txtFechaVenta.Text = dgwVenta.CurrentRow.Cells["ven_fecha"].Value.ToString();
                txtDNI.Text = dgwVenta.CurrentRow.Cells["cli_dni"].Value.ToString();
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            cmbFiltroCliente.Text = null;
            load_venta();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbFiltroCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgwVenta.DataSource = ABMVentas.list_ventasByCliente(cmbFiltroCliente.Text);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            cmbFiltroCliente.Text = null;
            load_venta();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormFiltrarVenta filtrar = new FormFiltrarVenta();
            filtrar.Show();
        }

    }
}
