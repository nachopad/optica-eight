using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class ProductoABM
    {
        public static DataTable list_productos()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM producto";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Ejecutar la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el data table
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        // Creo que lo puedo hacer en el FormVenta. Pero tengo entendido que en la vista no se tendria que hacer este tipo de acciones.
        public static decimal get_Precio(string cod)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM producto WHERE prod_codigo = @cod ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@cod", cod);

            //Ejecutar la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el data table
            DataTable dt = new DataTable();
            da.Fill(dt);

            return Convert.ToDecimal(dt.Rows[0]["prod_precio"].ToString());
        }
        //Este metodo permitira obtener lalista ordenada por Categoria
        public static DataTable list_producto_order_by_Categoria()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "listar_producto_categoria_sp";

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection = cnn;

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        //Este metodo permitira obtener lalista ordenada por Descripcion
        public static DataTable list_producto_order_by_Descripcion()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "listar_producto_descripcion_sp";

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection = cnn;

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable list_productosByCliente(string dni)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "list_productosByCliente_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            // Parametro de Entrada
            cmd.Parameters.AddWithValue("@dni", dni);

            //Ejecutar la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en el data table
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}
