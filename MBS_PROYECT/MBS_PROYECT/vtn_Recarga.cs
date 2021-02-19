using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MBS_PROYECT
{
    public partial class vtn_Recarga : Form
    {
        SqlCommand cmd;
        public vtn_Recarga()
        {
            InitializeComponent();
            lblFecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = new SqlConnection("server=FER-PC\\FERNANDO01;database=MBS_DATA;integrated security = true");
                cn.Open();
                cmd = new SqlCommand("SELECT COUNT(*) FROM RECARGAS",cn);
                int id = Convert.ToInt32(cmd.ExecuteScalar());
                string idd = (id + 1).ToString();
                cmd = new SqlCommand("EXECUTE Agregar_recarga @Cod_Prodcuto = '" + idd + "',@Cant_Vendidas = '1',"
                                    + "@Cod_Descuento = '1',"
                                    + "@fecha = '" + lblFecha.Text + "',"
                                    + "@Num_Telefono = '" + txtTelf.Text + "',"
                                    + "@Monto = '" + txtMonto.Text + "',"
                                    + "@Id_Recarga = '" +id+ "',"
                                    + "@Operadora = '" + cmbOp.Text + "'", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Datos ingresados correctamente");
                cn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(""+ex);
            }
        }
    }
}
