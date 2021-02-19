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
    public partial class Pago : Form
    {
        SqlCommand cmd;
        public Pago(string TOTAL)
        {
            InitializeComponent();
            lblTOT.Text = TOTAL;
            
        }

        public Pago()
        {

        }
        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (txtPago.Text != "")
            {
                Form vtnFac = new vtn_facturacion(lblTOT.Text,txtPago.Text);
                SqlConnection con = new SqlConnection("server=FER-PC\\FERNANDO01;database=MBS_DATA;integrated security = true");
                /*con.Open();               
                cmd = new SqlCommand("EXECUTE Registro_ventas @Cod_Producto = '" + txtCedula.Text + "',"
                                    + "@Cant_Vendidas = '" + txtNombre.Text + "',"
                                    + "@Cod_Descuento = '" + txtApellido.Text + "',"
                                    + "@Id_Recarga = '" + dtpNacimiento.Value + "',"
                                    + "@fecha = '" + txtPass.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Datos ingresados correctamente");
                con.Close();*/
                vtnFac.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Porfavor ingresar el monto de pago!");
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            this.Close();
        }
    }
}
