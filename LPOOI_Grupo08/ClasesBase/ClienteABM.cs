using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class ClienteABM
    {

        public static void insert_cliente_sp(Cliente cliente)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert_cliente_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", cliente.Cli_Dni);
            cmd.Parameters.AddWithValue("@ape", cliente.Cli_Apellido);
            cmd.Parameters.AddWithValue("@nom", cliente.Cli_Nombre);
            cmd.Parameters.AddWithValue("@dire", cliente.Cli_Direccion);
            cmd.Parameters.AddWithValue("@cuit", cliente.Cli_Cuit);
            cmd.Parameters.AddWithValue("@carnet", cliente.Cli_NroCarnet);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void modify_cliente_sp(Cliente cliente)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "modify_cliente_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", cliente.Cli_Id);
            cmd.Parameters.AddWithValue("@dni", cliente.Cli_Dni);
            cmd.Parameters.AddWithValue("@ape", cliente.Cli_Apellido);
            cmd.Parameters.AddWithValue("@nom", cliente.Cli_Nombre);
            cmd.Parameters.AddWithValue("@dire", cliente.Cli_Direccion);
            cmd.Parameters.AddWithValue("@cuit", cliente.Cli_Cuit);
            cmd.Parameters.AddWithValue("@carnet", cliente.Cli_NroCarnet);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable list_clientes_sp()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "list_clientes_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en la DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        
        public static DataTable list_ObrasSocialesCuit_sp()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "list_ObrasSocialesCuit_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en la DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        
        public static DataTable search_clientes_sp(string dni, string nroCarnet)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "search_clientes_sp";

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", "%" + dni + "%");
            cmd.Parameters.AddWithValue("@nroCarnet", "%" + nroCarnet + "%");

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en la DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static void delete_cliente_sp(string dniCliente)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "delete_cliente_sp";

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", "%" + dniCliente + "%");

            cnn.Open();

            // Ejecuta la consulta usando ExecuteNonQuery()
            cmd.ExecuteNonQuery();

            // Cierra la conexión
            cnn.Close();
        }

        public static Boolean search_dni_sp(string dni)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "search_dni_sp";

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", dni);

            cmd.Parameters.Add("@count_client", SqlDbType.Int);
            cmd.Parameters["@count_client"].Direction = ParameterDirection.Output;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

            return ((int)cmd.Parameters["@count_client"].Value) == 0;
        }

    }
}
