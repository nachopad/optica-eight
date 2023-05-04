using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class UsuarioABM
    {

        public static void insert_usuario(Usuario user)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Usuario(rol_codigo,usu_apellido_nombre,usu_nombre_usuario,usu_contrasenia) values(@rol,@ape,@usu,@pass)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@rol", user.Rol_Id);
            cmd.Parameters.AddWithValue("@ape", user.Usu_ApellidoNombre);
            cmd.Parameters.AddWithValue("@usu", user.Usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@pass", user.Usu_Contrasena);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void modify_cliente(Usuario usuario, string id, string rolCod)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Usuario set usu_nombre_usuario=@usu, usu_contrasenia=@pas, usu_apellido_nombre=@ape, rol_codigo=@cod WHERE usu_id=@id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@cod", rolCod);
            cmd.Parameters.AddWithValue("@usu", usuario.Usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@pas", usuario.Usu_Contrasena);
            cmd.Parameters.AddWithValue("@ape", usuario.Usu_ApellidoNombre);
           
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void delete_usuario(string idUsuario)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "DELETE FROM Usuario WHERE usu_id LIKE @id";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", "%" + idUsuario + "%");

            cnn.Open();

            // Ejecuta la consulta usando ExecuteNonQuery()
            cmd.ExecuteNonQuery();

            // Cierra la conexión
            cnn.Close();
        }

        public static DataTable search_usuarios(string sPattern)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText += " usu_id, ";
            cmd.CommandText += " rol_descripcion as 'Rol', ";
            cmd.CommandText += " usu_apellido_nombre as 'Apellido y Nombre', ";
            cmd.CommandText += " usu_nombre_usuario as 'Usuario', usu_contrasenia as 'Contraseña', ";
            cmd.CommandText += " U.rol_codigo ";
            cmd.CommandText += " FROM Usuario as U";
            cmd.CommandText += " LEFT JOIN Roles as R ON (R.rol_codigo=U.rol_codigo)";

            cmd.CommandText += " WHERE";
            cmd.CommandText += " usu_nombre_usuario LIKE @pattern ";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@pattern", "%" + sPattern + "%");

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en la DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable list_roles()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Roles";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en la DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable list_usuarios()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText += " usu_id, ";
            cmd.CommandText += " rol_descripcion as 'Rol', ";
            cmd.CommandText += " usu_apellido_nombre as 'Apellido y Nombre', ";
            cmd.CommandText += " usu_nombre_usuario as 'Usuario', usu_contrasenia as 'Contraseña', ";
            cmd.CommandText += " U.rol_codigo ";
            cmd.CommandText += " FROM Usuario as U";
            cmd.CommandText += " LEFT JOIN Roles as R ON (R.rol_codigo=U.rol_codigo)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Ejecuta la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Llena los datos de la consulta en la DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public string verificar_loginBD(string username, string contrasena)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT usu_nombre_usuario, rol_codigo FROM Usuario WHERE usu_nombre_usuario LIKE @usuario AND usu_contrasenia LIKE @pas ");
            cmd.Parameters.AddWithValue("usuario", "%" + username + "%");
            cmd.Parameters.AddWithValue("pas", "%" + contrasena + "%");

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt.Rows[0][1].ToString();
        }

        public static string get_rolDescripcion(string rolCod)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM Roles WHERE rol_codigo = @cod";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@cod", rolCod);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt.Rows[0]["rol_descripcion"].ToString();
        }

    }
}
