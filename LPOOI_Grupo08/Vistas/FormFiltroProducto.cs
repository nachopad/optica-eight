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
    public partial class FormFiltroProducto : Form
    {
        public FormFiltroProducto()
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

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

            string fechaI = fechaInicio.Value.ToString("yyyy/M/d");
            string fechaF = fechaFinal.Value.ToString("yyyy/M/d");
            if(DateTime.Parse(fechaI) > DateTime.Parse(fechaF))
             MessageBox.Show("La fecha de Inicio no puede ser mayor a la Fecha Final");
            else
            tablaVenta.DataSource = ABMVentas.get_SalesByDate(fechaI, fechaF);
        }

        
    }
}
