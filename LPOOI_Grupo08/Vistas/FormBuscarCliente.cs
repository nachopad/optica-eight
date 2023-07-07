using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;
using System.Drawing.Drawing2D;

namespace Vistas
{
    public partial class FormBuscarCliente : Form
    {
        public FormBuscarCliente()
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

        private void FormBuscarCliente_Load(object sender, EventArgs e)
        {
            dgwCliente.Visible = false;
            labelBusqueda.Visible = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string busqueda="";
            if (radioApellido.Checked){
                busqueda = "Apellido";
            }
            else if(radioNombre.Checked){
                busqueda = "Nombre";
            }
            else if (radioDni.Checked) {
                busqueda = "Dni";
            }
            this.dgwCliente.DataSource = ClienteABM.search_clientes_nombreApellidoDni_sp(txtDni.Text, txtNombre.Text, txtApellido.Text, busqueda);
            if (dgwCliente.RowCount == 1)
            {
                MessageBox.Show("No existen clientes registrados con los datos ingresados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dgwCliente.Visible = false;
                labelBusqueda.Visible = true;
            }
            else
            {
                labelBusqueda.Visible = false;
                dgwCliente.Visible = true;
            }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("El DNI debe ser numérico.", "Validación DNI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

            string currentText = txtDni.Text;

            if (currentText.Length >= 8 && e.KeyChar != '\b')
            {
                MessageBox.Show("El DNI debe tener máximo 8 caracteres.", "Validación DNI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

    }
}
