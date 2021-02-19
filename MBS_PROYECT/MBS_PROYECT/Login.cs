using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace MBS_PROYECT
{
        public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        

        


        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form vtnReg = new vtn_registro();
            vtnReg.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("server=FER-PC\\FERNANDO01;database=MBS_DATA;integrated security = true"))
                {

                    using (SqlCommand cmd = new SqlCommand("SELECT Nombre,Contraseña FROM USUARIO WHERE Nombre = '" + txtUser.Text + "' AND Contraseña = '" + txtPass.Text + "'",con))
                    {
                        con.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            Form vtnMain = new Main();



                            vtnMain.Show();

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Contraseña o Usuarioincorrectos :(");
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(""+ex);
            }

            

            BorrarMensajeError();
            if (
            ValidarCampos())
            {
                MessageBox.Show("Datos ingresados correctamente");
            }

        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        private bool ValidarCampos()
        {

            bool ok = true;
            if (txtUser.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtUser, "Ingrese su usuario");
            }

            if (txtPass.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtPass, "Ingrese su Contraseña");
            }

            return ok;
        }

        //validacion para borrar mensaje de error

        private void BorrarMensajeError()
        {
            errorProvider1.SetError(txtUser, "");
            errorProvider1.SetError(txtPass, "");
            

        }
    }
}
