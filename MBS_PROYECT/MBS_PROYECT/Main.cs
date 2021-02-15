using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MBS_PROYECT
{
    public partial class Main : Form
    {
        public string link;
        public Main()
        {
            InitializeComponent();

            
            
        }
        public void foto(string url)
        {
            MessageBox.Show("Se ejecuto " + link);
            
            
            contenedor_img.ImageLocation = url;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        

        private void btnProveedores_Click(object sender, EventArgs e)
        {
           
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form log = new Login();

            log.Show();
            this.Hide();
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form vtnRecarga = new vtn_Recarga();

            vtnRecarga.Show();
        }

        private void retiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form vtnRetiros = new vtn_Retiros();

            vtnRetiros.Show();
        }

        private void BtnAdministrar_Click(object sender, EventArgs e)
        {

        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form vtnInv = new vtn_inventario();
            vtnInv.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form vtnFac = new vtn_facturacion();
            vtnFac.ShowDialog();
        }

        private void cambiarDeCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form log = new Login();

            log.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImg = new OpenFileDialog();
            getImg.InitialDirectory = "C:\\";
            getImg.Filter = "Archivos de imagen (*.jpg)(*.jpeg)|*.jpg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";

            if (getImg.ShowDialog() == DialogResult.OK)
            {
                contenedor_img.ImageLocation = getImg.FileName;
                //txtURL.Text = getImg.FileName;


            }
            else
            {
                MessageBox.Show("No se selecciono Imagen", "sin seleccion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            

        }

        private void Contenedor_img_Click(object sender, EventArgs e)
        {

        }

        private void Button4_KeyDown(object sender, KeyEventArgs e)
        {
            OpenFileDialog getImg = new OpenFileDialog();
            getImg.InitialDirectory = "C:\\";
            getImg.Filter = "Archivos de imagen (*.jpg)(*.jpeg)|*.jpg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";

            if (getImg.ShowDialog() == DialogResult.OK)
            {
                contenedor_img.ImageLocation = getImg.FileName;
                //txtURL.Text = getImg.FileName;


            }
            else
            {
                MessageBox.Show("No se selecciono Imagen", "sin seleccion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Button3_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void BanproToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DepositoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form dep = new vtnDepositos();
            dep.Show();
        }
    }
}
