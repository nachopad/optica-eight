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

        public static void insert_cliente(Cliente cliente)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Cliente(cli_dni,cli_apellido,cli_nombre,cli_direccion,os_cuit,cli_nro_carnet) values(@dni,@ape,@nom,@dire,@cuit,@carnet)";
            cmd.CommandType = CommandType.Text;
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

        public static void modify_cliente(Cliente cliente)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Cliente set cli_dni=@dni, cli_apellido=@ape, cli_nombre=@nom, cli_direccion=@dire, os_cuit=@cuit, cli_nro_carnet=@carnet WHERE cli_dni=@dni ";
            cmd.CommandType = CommandType.Text;
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

        public static DataTable list_clientes()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText += "cli_id, ";
            cmd.CommandText += " cli_dni as 'DNI', ";
            cmd.CommandText += " cli_apellido as 'Apellido', cli_nombre as 'Nombre', ";
            cmd.CommandText += " cli_direccion as 'Direccion', os_cuit as 'CUIT', cli_nro_carnet as 'N° Carnet' ";
            cmd.CommandText += " FROM Cliente as C";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en la DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable search_clientes(string dni, string nroCarnet)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText += "cli_id, ";
            cmd.CommandText += " cli_dni as 'DNI', ";
            cmd.CommandText += " cli_apellido as 'Apellido', cli_nombre as 'Nombre', ";
            cmd.CommandText += " cli_direccion as 'Direccion', os_cuit as 'CUIT', cli_nro_carnet as 'N° Carnet' ";
            cmd.CommandText += " FROM Cliente as C";
            //cmd.CommandText += " LEFT JOIN Cliente as R ON (R.cli_dno=C.cli_dni)"; DUDA

            cmd.CommandText += " WHERE";
            cmd.CommandText += " cli_dni LIKE @dni AND cli_nro_carnet LIKE @nroCarnet ";

            cmd.CommandType = CommandType.Text;
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

        public static void delete_cliente(string dniCliente)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "DELETE FROM Cliente WHERE cli_dni LIKE @dni";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", "%" + dniCliente + "%");

            cnn.Open();

            // Ejecuta la consulta usando ExecuteNonQuery()
            cmd.ExecuteNonQuery();

            // Cierra la conexión
            cnn.Close();
        }



    }
}
