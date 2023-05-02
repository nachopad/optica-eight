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
    public partial class AltaCliente : Form
    {
        public AltaCliente()
        {
            InitializeComponent();
        }

        private void AltaCliente_Load(object sender, EventArgs e)
        {

        }

        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            string dni = txtDni.Text;
            string apellido = txtApellido.Text;
            string nombre = txtNombre.Text;
            string direccion = txtDireccion.Text;
            string cuit = txtCuit.Text;
            string nroCarnet = txtNroCarnet.Text;

            if (string.IsNullOrEmpty(dni) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(direccion) || string.IsNullOrEmpty(cuit) || string.IsNullOrEmpty(nroCarnet))
                MessageBox.Show("Todos los campos son obligatorios");
            else if (MessageBox.Show("¿Está seguro que desea continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Cliente cliente = new Cliente(dni, apellido, nombre, direccion, cuit, nroCarnet);
                MessageBox.Show("Cliente Guardado:" + cliente.ToString());
            }
        }


       
    }
}
