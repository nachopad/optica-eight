using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class ObraSocial
    {
        private string os_Cuit;
        private string os_RazonSocial;
        private string os_Direccion;
        private string os_Telefono;
        private int os_id;

        public int Os_id
        {
            get { return os_id; }
            set { os_id = value; }
        }

        public string Os_Telefono
        {
            get { return os_Telefono; }
            set { os_Telefono = value; }
        }


        public string Os_RazonSocial
        {
            get { return os_RazonSocial; }
            set { os_RazonSocial = value; }
        }
        

        public string Os_Direccion
        {
            get { return os_Direccion; }
            set { os_Direccion = value; }
        }

        public string Os_cuit
        {
            get { return os_Cuit; }
            set { os_Cuit = value; }
        }

        public ObraSocial(string cuit, string razonSocial, string direccion, string telefono)
        {
            os_Cuit = cuit;
            os_Direccion = direccion;
            os_RazonSocial = razonSocial;
            os_Telefono = telefono;
        }

        public ObraSocial()
        {
            // TODO: Complete member initialization
        }

        public override string ToString()
        {
            return "Cuit: " + os_Cuit + ", Razon Social: " + os_RazonSocial + ", Direccion: " + os_Direccion + ", Telefono: " + os_Telefono;
        }

    }
}
