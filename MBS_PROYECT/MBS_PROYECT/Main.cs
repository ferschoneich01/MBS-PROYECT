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
        public float suma;
        
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
            Form prov = new vtn_Proveedores();
            prov.ShowDialog();
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
            
            Pago p = new Pago(LBLTOT.Text);
            p.Show();
            this.Hide();
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
            
            if(txtArticulo.Text == "" || txtCant.Text == "")
            {

                MessageBox.Show("Ingrese la cantidad del articulo!");
            }
            else
            {
                Buscar b = new Buscar(int.Parse(txtCant.Text));
                b.txtBuscar.Text = txtArticulo.Text;
                AddOwnedForm(b);  //DECIMOS QUE ELFORMULARIO2 ES HIJO  
                b.ShowDialog();
                

            }

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
        public void TablaAgregar(DataGridViewRow f)
        {
            string cod = f.Cells["Cod_Producto"].Value.ToString();
            string cod2 = f.Cells["Precio"].Value.ToString();
            string cod3 = f.Cells["Descripcion"].Value.ToString();
            string cod4 = f.Cells["stock"].Value.ToString();
            string cod5 = f.Cells["Tipo"].Value.ToString();
            string cod6 = f.Cells["proveedor"].Value.ToString();

            this.tabla_productos.Rows.Add(new[] { cod, cod2, cod3, cod4, cod5,cod6 });

        }
        private void tabla_productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabla_productos_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {

            //suma = float.Parse(LBLTOT.Text);
            //LBLTOT.Text = suma.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(tabla_productos.Rows.Count == 0)
            {
                MessageBox.Show("Debe Añadir un producto!");
            }
            else
            {
                suma -= float.Parse(tabla_productos.CurrentRow.Cells[2].Value.ToString());

                LBLTOT.Text = suma.ToString();
                tabla_productos.Rows.Remove(tabla_productos.CurrentRow);
            }
            
        }
    }

    
}
