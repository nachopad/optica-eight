using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Cliente
    {
        private string cli_Dni;
        private string cli_Apellido;
        private string cli_Nombre;
        private string cli_Direccion;
        private string cli_Cuit;
        private string cli_NroCarnet;
        private int cli_Id;


        public Cliente(string dni, string apellido, string nombre, string direccion, string cuit, string nroCarnet)
        {
            Cli_Dni = dni;
            Cli_Apellido = apellido;
            Cli_Nombre = nombre;
            Cli_Direccion = direccion;
            Cli_Cuit = cuit;
            Cli_NroCarnet = nroCarnet;
        }

        public Cliente()
        {

        }

        public int Cli_Id
        {
            get { return cli_Id; }
            set { cli_Id = value; }
        }

        public string Cli_Dni
        {
            get { return cli_Dni; }
            set { cli_Dni = value; }
        }
        
        public string Cli_Apellido
        {
            get { return cli_Apellido; }
            set { cli_Apellido = value; }
        }
       
        public string Cli_Nombre
        {
            get { return cli_Nombre; }
            set { cli_Nombre = value; }
        }
        
        public string Cli_Direccion
        {
            get { return cli_Direccion; }
            set { cli_Direccion = value; }
        }
        
        public string Cli_Cuit
        {
            get { return cli_Cuit; }
            set { cli_Cuit = value; }
        }
        
        public string Cli_NroCarnet
        {
            get { return cli_NroCarnet; }
            set { cli_NroCarnet = value; }
        }

        public override string ToString()
        {
            return "DNI: " + Cli_Dni + ", Apellido: " + Cli_Apellido + ", Nombre: " + Cli_Nombre + ", Dirección: " + Cli_Direccion + ", CUIT: " + Cli_Cuit + ", Nro. Carnet: " + Cli_NroCarnet;
        }

    }
}
