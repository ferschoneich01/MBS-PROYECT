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
    public partial class vtn_inventario : Form
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private string sCn;
        private Boolean Editar = false, Vacio;
        conexion cn = new conexion();

        public vtn_inventario()
        {
            InitializeComponent();

            //Acceso a la funcion conec de la clases conexion
            cn.conec();
            //Variable para la cadena conexion
            sCn = cn.cadena;
            //Conexion
            conn = new SqlConnection(sCn);
        }

        private void vtn_inventario_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(sCn);
            cn.cargarProduct(dgvDatosProductos);
        }

        //Metodos a Usar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text) || string.IsNullOrEmpty(txtDescripcion.Text) || string.IsNullOrEmpty(txtPrecio.Text) ||
                string.IsNullOrEmpty(txtCantidad.Text) || string.IsNullOrEmpty(cbxCategoria.Text) || string.IsNullOrEmpty(cbxProveedor.Text))
            {
                MessageBox.Show("El campo es requerido", "Mensaje de error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

            
            //Ingresando Registros
            if (Editar == false)
            {
                try
                {
                    conn.Open();
                    string insertProduct;

                    insertProduct = "INSERT INTO PRODUCTO (Cod_Producto, Descripcion, Precio, Stock, Tipo,proveedor)";
                    insertProduct += "VALUES (@Cod_Producto, @Descripcion, @Precio, @Stock,@Tipo, @proveedor)";
                    cmd = new SqlCommand(insertProduct, conn);
                    cmd.Parameters.AddWithValue("@Cod_Producto", txtCodigo.Text);
                    cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                    cmd.Parameters.AddWithValue("@Precio", float.Parse(txtPrecio.Text));
                    cmd.Parameters.AddWithValue("@Stock", int.Parse(txtCantidad.Text));
                    cmd.Parameters.AddWithValue("@Tipo", cbxCategoria.Text);
                    cmd.Parameters.AddWithValue("@proveedor", int.Parse(cbxProveedor.Text));
          
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("***Registro Ingresado Exitosamente***", "Ingresando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cn.cargarProduct(dgvDatosProductos);
                    conn.Close();
                    LimpiarCampos();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("**El Registro No Fue Ingresado**", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }

            }
            //Modificando Registros
            if (Editar == true)
            {
                try
                {
                    conn.Open();
                    string ProcEditar = null;
                    ProcEditar = "EditarProductos";
                    cmd = new SqlCommand(ProcEditar, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Cod_Producto", txtCodigo.Text);
                    cmd.Parameters.AddWithValue("@Desc", txtDescripcion.Text);
                    cmd.Parameters.AddWithValue("@Precio", float.Parse(txtPrecio.Text));
                    cmd.Parameters.AddWithValue("@Stock", int.Parse(txtCantidad.Text));
                    cmd.Parameters.AddWithValue("@Categoria", cbxCategoria.Text);
                    cmd.Parameters.AddWithValue("@ProvProduct", int.Parse(cbxProveedor.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("***Registro Modificado Exitosamente***", "Editando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cn.cargarProduct(dgvDatosProductos);
                    conn.Close();
                    LimpiarCampos();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("**El Registro No Fue Editado**", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                }
            }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        //Metodo Para Eliminar Registros
        public void EliminarRegistro(string Cod_Producto)
        {
            conn.Open();
            string ProcELiminar = null;
            ProcELiminar = "EliminarProducto";
            cmd = new SqlCommand(ProcELiminar, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Cod_Producto", Cod_Producto);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        //Limpiar Campos
        public void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
            cbxCategoria.Text = "Seleccione Categoria";
            cbxProveedor.Text = "Seleccione Proveedor";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvDatosProductos.SelectedRows.Count > 0)
            {
                Editar = true;
                txtCodigo.Text = dgvDatosProductos.CurrentRow.Cells["Cod_Producto"].Value.ToString();
                txtDescripcion.Text = dgvDatosProductos.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtPrecio.Text = dgvDatosProductos.CurrentRow.Cells["Precio"].Value.ToString();
                txtCantidad.Text = dgvDatosProductos.CurrentRow.Cells["Stock"].Value.ToString();
                cbxCategoria.Text = dgvDatosProductos.CurrentRow.Cells["Tipo"].Value.ToString();
                cbxProveedor.Text = dgvDatosProductos.CurrentRow.Cells["proveedores"].Value.ToString();
            }
            else
            {
                MessageBox.Show("**Seleccion un Registro, Porfavor**", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string Cod_Producto;
            if (dgvDatosProductos.SelectedRows.Count > 0)
            {
                Cod_Producto = dgvDatosProductos.CurrentRow.Cells["Cod_Producto"].Value.ToString();
                EliminarRegistro(Cod_Producto);
                MessageBox.Show("***Registro Eliminado Exitosamente***", "Eliminando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cn.cargarProduct(dgvDatosProductos);
                conn.Close();
            }
            else
            {
                MessageBox.Show("**Seleccion un Registro, Porfavor**", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source =.; Initial Catalog = MBS_DATA; Integrated Security = True");
            conn.Open();
            cmd = conn.CreateCommand();

            try
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM PRODUCTO WHERE Cod_Producto LIKE('" + txtBuscar.Text + "%')";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvDatosProductos.DataSource = dt;
                txtBuscar.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, Asegurese de Poner el Codigo Correcto" + ex.ToString());
                throw;
            }
            conn.Close();
        }
    }
}
