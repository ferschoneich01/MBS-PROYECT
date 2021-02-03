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
        public Main()
        {
            InitializeComponent();
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
            Form formulario = new GUI_MODERNISTA.Form2();

            formulario.Show();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form vtnRecarga = new Ventana_Recarga();

            vtnRecarga.Show();
        }

        private void retiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form vtnRetiros = new Ventana_Retiros();

            vtnRetiros.Show();
        }
    }
}
