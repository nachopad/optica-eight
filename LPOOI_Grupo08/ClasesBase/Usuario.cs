﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Usuario
    {

        private int usu_ID;

        public int Usu_ID
        {
            get { return usu_ID; }
            set { usu_ID = value; }
        }
        private string usu_NombreUsuario;

        public string Usu_NombreUsuario
        {
            get { return usu_NombreUsuario; }
            set { usu_NombreUsuario = value; }
        }
        private string usu_Contrasena;

        public string Usu_Contrasena
        {
            get { return usu_Contrasena; }
            set { usu_Contrasena = value; }
        }
        private string usu_ApellidoNombre;

        public string Usu_ApellidoNombre
        {
            get { return usu_ApellidoNombre; }
            set { usu_ApellidoNombre = value; }
        }

        private int rol_Id;

        public int Rol_Id
        {
            get { return rol_Id; }
            set { rol_Id = value; }
        }

        public Usuario(int rolId,string apellidoNombre,string nombreUsu,string contrasena) {
            this.Rol_Id = rolId;
            this.Usu_ApellidoNombre = apellidoNombre;
            this.Usu_NombreUsuario = nombreUsu;
            this.Usu_Contrasena = contrasena;
        }
    }
}
