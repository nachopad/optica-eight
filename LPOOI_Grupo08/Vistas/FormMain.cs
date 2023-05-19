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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);
            Rectangle Forma = new Rectangle(new Point(0, 0), this.ClientSize);
            LinearGradientBrush Gradiente = new LinearGradientBrush(Forma,
            Color.Cyan, Color.Blue,

           LinearGradientMode.Vertical);
            e.Graphics.FillRegion(Gradiente, new Region(Forma));
        }

        public FormMain(Usuario usu,string tipo) {

            InitializeComponent();
            nomUsu.Text = usu.Usu_NombreUsuario;
            tipoUsu.Text= tipo;
        }

        private void navCliente_Click(object sender, EventArgs e)
        {
            AltaCliente formCliente = new AltaCliente();
            formCliente.Show();
        }

        private void navProducto_Click(object sender, EventArgs e)
        {
            AltaProducto formProducto = new AltaProducto();
            formProducto.Show();
        }

        private void navObraSocial_Click(object sender, EventArgs e)
        {
            AltaObraSocial formObraSocial = new AltaObraSocial();
            formObraSocial.Show();
        }

        private void navSalir_Click_1(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Está seguro de cerrar sesión?", "Advertencia", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                FormMain.ActiveForm.Hide();
                formLogin login = new formLogin();
                login.Activate();
                login.Show();
                this.Close();

            }
        }

        private void realizarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVenta formVenta = new FormVenta();
            formVenta.Show();
        }

        private void navVentaVer_Click(object sender, EventArgs e)
        {
            FormVerVentas ver = new FormVerVentas();
            ver.Show();
        }

        private void navUsuario_Click(object sender, EventArgs e)
        {
            AltaUsuario altaUsuario = new AltaUsuario();
            altaUsuario.Show();
        }

        public void verificar_login(string usuario, string rolCodigo)
        {
            if(rolCodigo == "3")
            {
                navCliente.Visible = false;
                navVenta.Visible = false;
                navObraSocial.Visible = false;
            }
            else if (rolCodigo == "2")
            {
                navUsuario.Visible = false;
                navProducto.Visible = false;
                navObraSocial.Visible = false;
            }
            nomUsu.Text = usuario;
            tipoUsu.Text = UsuarioABM.get_rolDescripcion_sp(rolCodigo);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void nomUsu_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    
    }
}
