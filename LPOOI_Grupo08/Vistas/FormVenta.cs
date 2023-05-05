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
    public partial class FormVenta : Form
    {
        public FormVenta()
        {
            InitializeComponent();
        }

        private void FormVenta_Load(object sender, EventArgs e)
        {
            load_comboClientes();
            load_comboProductos();
        }

        private void load_comboClientes()
        {
            cmbCliente.DisplayMember = "DNI";
            cmbCliente.ValueMember = "DNI";
            cmbCliente.DataSource = ClienteABM.list_clientes();
        }

        private void load_comboProductos()
        {
            cmbProducto.DisplayMember = "prod_descripcion";
            cmbProducto.ValueMember = "prod_codigo";
            cmbProducto.DataSource = ProductoABM.list_productos();
        }

        private void btnRealizarVenta_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtCantidad.Text)){
                MessageBox.Show("Debe ingresar todos los campos", "Venta", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }else{
                var respuesta = MessageBox.Show("¿Desea realizar la venta?", "Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                // Venta
                ABMVentas.insert_venta(dtpFechaVenta.Value, cmbCliente.SelectedValue.ToString());

                // Me permite obtener el nro de venta
                int nro = ABMVentas.get_NroVenta(cmbCliente.SelectedValue.ToString());
                decimal precio = ProductoABM.get_Precio(cmbProducto.SelectedValue.ToString());

                //Detalle Venta
                decimal total = precio * Convert.ToDecimal(txtCantidad.Text);
                txtTotal.Text = total.ToString();
                ABMVentas.insert_ventaDetalle(nro, cmbProducto.SelectedValue.ToString(), precio, Convert.ToDecimal(txtCantidad.Text), total);
            }
            }
            
        }

        private void btnVerVentas_Click(object sender, EventArgs e)
        {
            FormVerVentas ver = new FormVerVentas();
            ver.Show();
        }

        private void load_precio()
        {
           decimal precio = ProductoABM.get_Precio(cmbProducto.SelectedValue.ToString());
           txtPrecio.Text = "$" + precio.ToString();
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_precio();
            txtCantidad_TextChanged(sender, e);
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (!txtCantidad.Text.Equals(""))
            {
               decimal precio = ProductoABM.get_Precio(cmbProducto.SelectedValue.ToString());
               decimal total = precio * Convert.ToDecimal(txtCantidad.Text);
               txtTotal.Text = "$"+total.ToString();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormMain.ActiveForm.Activate();
            FormMain.ActiveForm.Show();
            this.Close();
        }
    }
}