﻿using System;
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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        public FormMain(Usuario usu,string tipo) {

            InitializeComponent();
            nomUsu.Text = usu.Usu_NombreUsuario;
            tipoUsu.Text= tipo;
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        

        private void navSalir_Click_1(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Está seguro de cerrar sesión", "Seleccione", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                FormMain.ActiveForm.Hide();
                formLogin login = new formLogin();
                login.Activate();
                login.Show();
                this.Close();

            }
        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

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

    
    }
}
