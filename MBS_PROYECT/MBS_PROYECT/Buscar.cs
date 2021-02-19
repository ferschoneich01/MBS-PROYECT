using Conexion_BD;
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
    public partial class Buscar : Form
    {
        
        SqlDataAdapter da;
        DataTable a;
        SqlConnection cn;
        
        //public int cantidad;
        
        public Buscar(int cant)
        {
            InitializeComponent();
            lblCant.Text = cant.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            

            cn = new SqlConnection("server=FER-PC\\FERNANDO01;database=MBS_DATA;integrated security = true");
            cn.Open();
            try
            {
                da = new SqlDataAdapter("exec Seleccionar "+"'"+txtBuscar.Text+"'", cn);
                a = new DataTable();
                da.Fill(a);
               
                dgvProductos.DataSource = a;


            }
            catch
            {

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvProductos.RowCount == 0)
            {
                MessageBox.Show("Debe buscar agregar un producto!");

            }
            else
            {
                Main m = Owner as Main;
                string A = this.dgvProductos.CurrentRow.Cells[0].Value.ToString(); //CAPTURAMOS LOS DATOS DE LA COLUMNA 0 Y 1 
                string B = this.dgvProductos.CurrentRow.Cells[1].Value.ToString();
                string C = this.dgvProductos.CurrentRow.Cells[2].Value.ToString();
                string D = this.dgvProductos.CurrentRow.Cells[3].Value.ToString();
                string E = this.dgvProductos.CurrentRow.Cells[4].Value.ToString();
                string F = this.dgvProductos.CurrentRow.Cells[5].Value.ToString();

                int cantidad_fact = int.Parse(lblCant.Text);


                do
                {

                    m.tabla_productos.Rows.Add(A, B, C, D, E, F);//ENVIAMOS DATOS CAPTURADOS A LA DG1
                    cantidad_fact -= 1;
                } while (cantidad_fact > 0);

                

                float cant = float.Parse(this.dgvProductos.CurrentRow.Cells[2].Value.ToString());
                float cantidad = float.Parse(m.txtCant.Text);
                
                m.suma += cant * cantidad;
                m.LBLTOT.Text = m.suma.ToString();


                this.Close();

            }

            

        }
    }
}
