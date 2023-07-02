using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class ObraSocialABM
    {

        public static Boolean search_cuit_obra_social_sp(string cuit)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "search_obra_social_cuit_sp";

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@cuit", cuit);

            cnn.Open();
            int count = (int)cmd.ExecuteScalar();
            cnn.Close();
            return count == 0;
        }

        public static void insert_obra_social_sp(ObraSocial obraSocial)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert_obra_social_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@cuit", obraSocial.Os_cuit);
            cmd.Parameters.AddWithValue("@direccion", obraSocial.Os_Direccion);
            cmd.Parameters.AddWithValue("@razonSocial", obraSocial.Os_RazonSocial);
            cmd.Parameters.AddWithValue("@telefono", obraSocial.Os_Telefono);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable list_obraSocial_sp()
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

        public static void modify_obra_social_sp(ObraSocial obraSocial)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "modify_obra_social_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", obraSocial.Os_id);
            cmd.Parameters.AddWithValue("@cuit", obraSocial.Os_cuit);
            cmd.Parameters.AddWithValue("@direccion", obraSocial.Os_Direccion);
            cmd.Parameters.AddWithValue("@razon", obraSocial.Os_RazonSocial);
            cmd.Parameters.AddWithValue("@telefono", obraSocial.Os_Telefono);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void delete_obra_social_sp(string id)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "delete_obra_social_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", "%" + id + "%");

            cnn.Open();

            //// Ejecuta la consulta usando ExecuteNonQuery()
            cmd.ExecuteNonQuery();

            //// Cierra la conexión
            cnn.Close();
        }
    }
}
