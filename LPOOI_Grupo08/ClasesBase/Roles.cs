using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Roles
    {
        private int rol_Codigo;
        private string rol_Descripcion;

        public Roles(int codigo, string descripcion)
        {
            this.Rol_Codigo = codigo;
            this.Rol_Descripcion = descripcion;
        }

        public int Rol_Codigo
        {
            get { return rol_Codigo; }
            set { rol_Codigo = value; }
        }

        public string Rol_Descripcion
        {
            get { return rol_Descripcion; }
            set { rol_Descripcion = value; }
        }

    }
}
