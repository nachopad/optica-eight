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
    public partial class AltaObraSocial : Form
    {
        public AltaObraSocial()
        {
            InitializeComponent();
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

       
    }
}
