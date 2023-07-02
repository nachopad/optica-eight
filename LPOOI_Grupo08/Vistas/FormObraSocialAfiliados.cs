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
    public partial class FormObraSocialAfiliados : Form
    {

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);
            Rectangle Forma = new Rectangle(new Point(0, 0), this.ClientSize);
            LinearGradientBrush Gradiente = new LinearGradientBrush(Forma,
            Color.OrangeRed, Color.Yellow,

           LinearGradientMode.ForwardDiagonal);
            e.Graphics.FillRegion(Gradiente, new Region(Forma));
        }


        public FormObraSocialAfiliados()
        {
            InitializeComponent();
        }

        private void cmbObraSocial_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgwAfiliados.DataSource = ObraSocialABM.listar_afiliados_sp(cmbObraSocial.SelectedValue.ToString());
        }

        private void FormObraSocialAfiliados_Load(object sender, EventArgs e)
        {
            load_combo_obrasSocialesCuit();
        }

        private void load_combo_obrasSocialesCuit()
        {
            cmbObraSocial.DisplayMember = "Razon Social";
            cmbObraSocial.ValueMember = "Cuit";
            cmbObraSocial.DataSource = ObraSocialABM.listar_obraSocial_sp();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
