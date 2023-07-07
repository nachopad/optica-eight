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

        public static DataTable listar_obraSocial_sp()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listar_ObrasSociales_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
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
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable listar_afiliados_sp(string cuit)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "list_afiliadosByObraSocial_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("cuit", cuit);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int cantidadRegistros = dt.Rows.Count;
            DataRow totalRow = dt.NewRow();
            dt.Rows.Add(totalRow);
            int rowIndex = dt.Rows.Count - 1;
            dt.Rows[rowIndex].SetField<string>(0, "Total de afiliados: ");
            dt.Rows[rowIndex].SetField<string>(1, "" + cantidadRegistros);
            return dt;
        }
    }
}
