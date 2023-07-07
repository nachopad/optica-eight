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
    public partial class FormProductosVendidosByCliente : Form
    {
        public FormProductosVendidosByCliente()
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

        private void load_comboClientes()
        {
            cmbCliente.DisplayMember = "DNI";
            cmbCliente.ValueMember = "DNI";
            cmbCliente.DataSource = ClienteABM.list_clientes_sp();
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgwProductosCliente.DataSource = ProductoABM.list_productosByCliente(cmbCliente.SelectedValue.ToString());
        }

        private void FormProductosVendidosByCliente_Load(object sender, EventArgs e)
        {
            load_comboClientes();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
