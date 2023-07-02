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
            ObraSocial obraSocial = new ObraSocial();
            obraSocial.Os_cuit = txtCuit.Text;
            obraSocial.Os_RazonSocial = txtRazonSocial.Text;
            obraSocial.Os_Direccion = txtDireccion.Text;
            obraSocial.Os_Telefono = txtTelefono.Text;

            if (String.IsNullOrEmpty(txtCuit.Text) || String.IsNullOrEmpty(txtRazonSocial.Text) || String.IsNullOrEmpty(txtDireccion.Text) || String.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("Debe completar todos los campos antes para registrar una Obra Social", "Error al registrar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var respuesta = MessageBox.Show("¿Está seguro que desea registrar los datos?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    if (ObraSocialABM.search_cuit_obra_social_sp(obraSocial.Os_cuit) == true)
                    {
                        ObraSocialABM.insert_obra_social_sp(obraSocial);
                        MessageBox.Show("Se registro correctamente la obra social", "Registrar completo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtCuit.Text = null;
                        txtRazonSocial.Text = null;
                        txtDireccion.Text = null;
                        txtTelefono.Text = null;
                        obraSocial_load();
                    }
                    else
                    {
                        MessageBox.Show("Ya existe una Obra social registrado con el CUIT ingresado", "Errror al registrar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
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

        private void dgwObrasSociales_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgwObrasSociales.CurrentRow != null)
            {
                txtId.Text = dgwObrasSociales.CurrentRow.Cells["Id"].Value.ToString();
                txtCuit.Text = dgwObrasSociales.CurrentRow.Cells["Cuit"].Value.ToString();
                txtDireccion.Text = dgwObrasSociales.CurrentRow.Cells["Direccion"].Value.ToString();
                txtRazonSocial.Text = dgwObrasSociales.CurrentRow.Cells["Razon Social"].Value.ToString();
                txtTelefono.Text = dgwObrasSociales.CurrentRow.Cells["Telefono"].Value.ToString();
            }
        }

        private void obraSocial_load()
        {
            dgwObrasSociales.DataSource = ObraSocialABM.list_obraSocial_sp();
        }

        private void AltaObraSocial_Load(object sender, EventArgs e)
        {
            dgwObrasSociales.DataSource = ObraSocialABM.list_obraSocial_sp();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtCuit.Text.Equals(""))
            {
                MessageBox.Show("Debe seleccionar una obra social antes de realizar una modificacion", "Error al modificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                ObraSocial obraSocial = new ObraSocial();
                obraSocial.Os_id = Int32.Parse(txtId.Text);
                obraSocial.Os_cuit = txtCuit.Text;
                obraSocial.Os_RazonSocial = txtRazonSocial.Text;
                obraSocial.Os_Direccion = txtDireccion.Text;
                obraSocial.Os_Telefono = txtTelefono.Text;

                if (String.IsNullOrEmpty(txtCuit.Text) || String.IsNullOrEmpty(txtRazonSocial.Text) || String.IsNullOrEmpty(txtDireccion.Text) || String.IsNullOrEmpty(txtTelefono.Text))
                {
                    MessageBox.Show("Debe completar todos los campos antes de modificar una Obra Social", "Error al registrar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    var respuesta = MessageBox.Show("¿Está seguro que desea modificar los datos?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        if (ObraSocialABM.search_cuit_obra_social_sp(obraSocial.Os_cuit) == false)
                        {
                            //UsuarioABM.modify_usuario_sp(usuario);
                            ObraSocialABM.modify_obra_social_sp(obraSocial);

                            MessageBox.Show("Datos modificados exitosamente", "Aviso");
                            obraSocial_load();
                        }
                        else
                        {
                            MessageBox.Show("No puede modificar, la obra social no se encuentra registrada", "Errror al modificiar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                    }
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("¿Está seguro que desea eliminar la obra social?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                ObraSocialABM.delete_obra_social_sp(txtId.Text);
                MessageBox.Show("Obra social eliminada exitosamente", "Eliminacion exitosa");
                obraSocial_load();

            }
        }
    }
}
