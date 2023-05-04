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
    public partial class FormVerVentas : Form
    {
        public FormVerVentas()
        {
            InitializeComponent();
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
                txtNVenta.Text = dgwVenta.CurrentRow.Cells["ven_nro"].Value.ToString();
                txtFechaVenta.Text = dgwVenta.CurrentRow.Cells["ven_fecha"].Value.ToString();
                txtDNI.Text = dgwVenta.CurrentRow.Cells["cli_dni"].Value.ToString();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
