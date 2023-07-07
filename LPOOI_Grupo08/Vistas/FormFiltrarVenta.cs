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
    public partial class FormFiltrarVenta : Form
    {
        public FormFiltrarVenta()
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

        private void FormFiltrarVenta_Load(object sender, EventArgs e)
        {
            load_Dates();
            fechaInicio.Value = DateTime.Now.AddHours(-2);
        }

        private void load_Dates()
        {
            tablaFechas.DataSource = ABMVentas.list_venta();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (fechaInicio.Value > fechaFinal.Value)
                {
                    MessageBox.Show("Fecha Inicio no puede ser menor que la fecha final");
                    fechaInicio.Value = DateTime.Now.AddHours(-2);
                    fechaFinal.Value = DateTime.Now;
                }
                string fechaI = fechaInicio.Value.ToString("yyyy/M/d");
                string fechaF = fechaFinal.Value.ToString("yyyy/M/d");
                tablaFechas.DataSource = ABMVentas.filterSales(fechaI, fechaF);
                tablaFechas.Visible = true;
                lblFechas.Visible = false;
            }
            catch (Exception error)
            {
                MessageBox.Show("ERROR: " + error.Message);
            } 
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
