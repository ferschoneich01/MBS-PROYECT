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
    public partial class vtn_Anuncio : Form
    {
        public vtn_Anuncio()
        {
            InitializeComponent();
        }

        string url;
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImg = new OpenFileDialog();
            getImg.InitialDirectory = "C:\\";
            getImg.Filter = "Archivos de imagen (*.jpg)(*.jpeg)|*.jpg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";
           
            if (getImg.ShowDialog() == DialogResult.OK)
            {
                pbAnuncio.ImageLocation = getImg.FileName;
                txtURL.Text = getImg.FileName;
                
            }
            else
            {
                MessageBox.Show("No se selecciono Imagen", "sin seleccion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();

            
            main.contenedor_img.Image = Image.FromFile(txtURL.Text);
            main.contenedor_img.Refresh();
        }
    }
}
