using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion_BD
{
    class conexion
    {
        //Parametro para la cadena de conexion
        public string servidor, usuario, clave, db;
        public string cadena;

        //funcion que tendra la cadena de conexion
        public static SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection("SERVER=FER-PC\\FERNANDO01;DATABASE=MBS_DATA;Integrated security=true");
            cn.Open();
            return cn;
        }
    }
}
