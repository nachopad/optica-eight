using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class ABMVentas
    {
        public static void insert_venta(DateTime fecha, string dni)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT INTO Venta (ven_fecha, cli_dni) values(@fecha,@dni)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@fecha", fecha);
            cmd.Parameters.AddWithValue("@dni", dni);

            //Parametros
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }


        public static DataTable list_venta()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * From Venta";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable list_ventasByCliente(string dni)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "list_ventasByCliente_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", dni);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable get_clientes_sp()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "get_clientes_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        } 

        public static int get_NroVenta(string dni)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT TOP 1 * FROM Venta WHERE cli_dni = @dni ORDER BY ven_nro DESC ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", dni);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return Int32.Parse(dt.Rows[0]["ven_nro"].ToString());
        }

        public static void insert_ventaDetalle(int vnro, string cod, decimal precio, decimal cantidad, decimal total)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT INTO VentaDetalle (ven_nro, prod_codigo, det_precio, det_cantidad, det_total) values(@vnro, @cod, @precio, @cantidad, @total)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@vnro", vnro);
            cmd.Parameters.AddWithValue("@cod", cod);
            cmd.Parameters.AddWithValue("@precio", precio);
            cmd.Parameters.AddWithValue("@cantidad", cantidad);
            cmd.Parameters.AddWithValue("@total", total);

            //Parametros
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable filterSales(string fechaInicio, string fechaFinal)
        {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            //   cmd.CommandText = "SELECT ven_fecha as 'Fecha Venta', V.cli_dni as 'DNI Cliente',cli_apellido as 'Apellido', cli_nombre as 'Nombre' FROM Venta AS V LEFT OUTER JOIN Cliente AS C ON (C.cli_dni = V.cli_dni) WHERE ven_fecha BETWEEN '" + fechaInicio + " 03:00:00' AND '" + fechaFinal + " 23:30:00'";
            cmd.CommandText = "SELECT "; // ven_nro as 'Venta Numero', ven_fecha as 'Fecha Venta', cli_dni as 'DNI Cliente' FROM Venta WHERE ven_fecha BETWEEN '" + fechaInicio + " 03:00:00' AND '" + fechaFinal + " 23:30:00'";
            cmd.CommandText += " ven_nro as 'Venta Numero', ";
            cmd.CommandText += " ven_fecha as 'Fecha Venta', cli_dni as 'DNI Cliente' ";
            cmd.CommandText += " FROM Venta ";
            cmd.CommandText += " WHERE ven_fecha ";
            cmd.CommandText += " BETWEEN '" + fechaInicio + " 03:00:00' AND '" + fechaFinal + " 23:30:00'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        //Metodo para obtener registros de ventas de un producto en un periodo de tiempo
        public static DataTable get_SalesByDate(String fechaInicio, String fechaFinal)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "get_SalesByDate";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio);
            cmd.Parameters.AddWithValue("@fechaFinal", fechaFinal);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Connection = cnn;
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;

        }

    }
}
