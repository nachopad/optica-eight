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
    public partial class AltaObraSocial : Form
    {
        public AltaObraSocial()
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

        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            string cuit = txtCuit.Text;
            string razonSocial = txtRazonSocial.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;

            if(string.IsNullOrEmpty(cuit)||string.IsNullOrEmpty(razonSocial)||string.IsNullOrEmpty(direccion)||string.IsNullOrEmpty(telefono))
            {    MessageBox.Show("Todos los campos son obligatorios") ;

            }else if(MessageBox.Show("¿Está seguro que desea continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ObraSocial obraSocial = new ObraSocial(cuit, razonSocial, direccion, telefono);
                MessageBox.Show("Obra Social Guardado: " + obraSocial.ToString());
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegrsar_Click(object sender, EventArgs e)
        {
            AltaObraSocial.ActiveForm.Hide();
            FormMain.ActiveForm.Activate();
            FormMain.ActiveForm.Show();
            this.Close();
        }

       
    }
}
