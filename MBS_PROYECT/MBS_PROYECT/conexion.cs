using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conexion_BD
{
    class conexion
    {
        DataTable dt;
        SqlDataAdapter da;
        SqlConnection conn;
        

        //Parametro para la cadena de conexion
        public string servidor, usuario, clave, db;
        public string cadena;
        private string sCn;

        //funcion que tendra la cadena de conexion
        public void conec()
        {
            servidor = "FER-PC\\FERNANDO01";
            db = "MBS_DATA";
            usuario = "sa";
            clave = "123456";
            cadena = "server=" + servidor + ";uid=" + usuario + ";pwd=" + clave + ";database=" + db;
        }

        //Cargando Datos en el DataGridView
        public void cargarProduct(DataGridView dgv)
        {
            try
            {
                conexion cn = new conexion();
                //Acceso a la funcion conec de la clases conexion
                cn.conec();
                //Variable para la cadena conexion
                sCn = cn.cadena;
                //Conexion
                conn = new SqlConnection(sCn);

                da = new SqlDataAdapter("select * from PRODUCTO ", conn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Se Pudo Cargar Los Datos: " + ex.ToString());
                throw;
            }
        }


        
    }
}
