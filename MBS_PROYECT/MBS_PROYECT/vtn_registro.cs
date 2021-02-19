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
    public partial class vtn_registro : Form
    {

        SqlCommand cmd;
        public vtn_registro()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=FER-PC\\FERNANDO01;database=MBS_DATA;integrated security = true");
            if (txtPass.Text == txtPassConfir.Text)
            {
                int ciudad = 0;
                if (cbCiudad.Text == "Managua")
                {
                    ciudad = 1;
                }
                else if (cbCiudad.Text == "Chinandega")
                {
                    ciudad = 2;
                }
                else if (cbCiudad.Text == "Masaya")
                {
                    ciudad = 3;
                }
                else if (cbCiudad.Text == "Diriamba")
                {
                    ciudad = 4;
                }
                else if (cbCiudad.Text == "Leon")
                {
                    ciudad = 5;
                }
                else if (cbCiudad.Text == "Esteli")
                {
                    ciudad = 6;
                }

                con.Open();


                BorrarMensajeError();
                if (ValidarCampos())
                {
                    SqlConnection cn = new SqlConnection("server=FER-PC\\FERNANDO01;database=MBS_DATA;integrated security = true");
                    cmd = new SqlCommand("EXECUTE Registro_usuario @Cedula = '" + txtCedula.Text + "',"
                                        + "@Nombre = '" + txtNombre.Text + "',"
                                        + "@Apellido = '" + txtApellido.Text + "',"
                                        + "@Fecha_nac = '" + dtpNacimiento.Value + "',"
                                        + "@Direccion = '" + txtDireccion.Text + "',"
                                        + "@Telefono = '" + txtTelefono.Text + "',"
                                        + "@Correo = '" + txtCorreo.Text + "',"
                                        + "@Cod_Ciudad = '" + ciudad.ToString() + "',"
                                        + "@Usuario = '" + txtNombreUsuario.Text + "',"
                                        + "@Contraseña = '" + txtPass.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datos ingresados correctamente");
                    con.Close();
                    Login l = new Login();
                    l.Show();
                    this.Close();
                }
                
            
                
            }
            else
            {
                MessageBox.Show("Confirme la contraseña correctamente!");
            }
            
        }

        private bool ValidarCampos() {
            bool ok = true;
            if (txtNombre.Text == "") {
                ok = false;
                errorProvider1.SetError(txtNombre, "Ingresar nombre");
            }

            if (txtApellido.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtApellido, "Ingresar nombre");
            }

            if (txtNombreUsuario.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNombreUsuario, "Ingresar nombre de usuario");
            }

            if (txtCorreo.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtCorreo, "Ingresar correo electronico");
            }
            if (txtPass.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtPass, "Ingresar contraseña");
            }

            if (txtPassConfir.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtPassConfir, "Confirme su contraseña");
            }

            if (txtDireccion.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtDireccion, "Ingrese su domicilio");
            }

            if (txtCedula.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtCedula, "Ingrese su numero de identificacion");
            }


           
                return ok;
        }

        private void BorrarMensajeError() {
            errorProvider1.SetError(txtNombre, "");
            errorProvider1.SetError(txtApellido, "");
            errorProvider1.SetError(txtCedula, "");
            errorProvider1.SetError(txtDireccion, "");
            errorProvider1.SetError(txtCorreo, "");
            errorProvider1.SetError(txtPass, "");
            errorProvider1.SetError(txtPassConfir, "");
            errorProvider1.SetError(txtTelefono, "");

        }
      
    }
}
