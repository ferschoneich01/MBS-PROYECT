﻿using System;
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
    public partial class vtn_facturacion : Form
    {
        public vtn_facturacion(string MontoTot,string Pago)
        {
            InitializeComponent();
            montototal.Text = MontoTot;
            lblPago.Text = Pago;

            float cambio = float.Parse(Pago) - float.Parse(MontoTot);
            lblCambio.Text = cambio.ToString();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Pnlmonto_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pnlmodo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pnlpago_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pnlcambio_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void montototal_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();

        }
    }
}
