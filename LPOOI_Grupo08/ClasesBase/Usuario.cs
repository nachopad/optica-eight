using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Usuario
    {

        private int usu_ID;
        private string usu_NombreUsuario;
        private string usu_Contrasena;
        private string usu_ApellidoNombre;
        private int rol_Id;

        public Usuario(int rolId, string apellidoNombre, string nombreUsu, string contrasena)
        {
            this.Rol_Id = rolId;
            this.Usu_ApellidoNombre = apellidoNombre;
            this.Usu_NombreUsuario = nombreUsu;
            this.Usu_Contrasena = contrasena;
        }

        public Usuario()
        {
            
        }

        public int Usu_ID
        {
            get { return usu_ID; }
            set { usu_ID = value; }
        }
        
        public string Usu_NombreUsuario
        {
            get { return usu_NombreUsuario; }
            set { usu_NombreUsuario = value; }
        }
        
        public string Usu_Contrasena
        {
            get { return usu_Contrasena; }
            set { usu_Contrasena = value; }
        }
        
        public string Usu_ApellidoNombre
        {
            get { return usu_ApellidoNombre; }
            set { usu_ApellidoNombre = value; }
        }

        public int Rol_Id
        {
            get { return rol_Id; }
            set { rol_Id = value; }
        }

    }
}
