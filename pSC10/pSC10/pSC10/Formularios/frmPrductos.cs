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

namespace pSC10
{
    public partial class frmPrductos : Form
    {
        Boolean existeData;

        public frmPrductos()
        {
            InitializeComponent();
        }

        private void frmPrductos_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;   // activa las teclas de funciones
            this.Text = "Maestro de Productos";

            existeData = false;
        }

        private void frmPrductos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)  // pregunta si presionaste la tecla de ESC
            {
                this.Close();  // cierra el formulario
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtProducto.Text.Trim() != string.Empty)  // AQUI ESTOY preguntando que si el textbox es diferente de vacio
            {
                if (txtNombre.Text.Trim() != string.Empty)  // AQUI ESTOY preguntando que si el textbox es diferente de vacio
                {
                    if (txtCantidad.Text.Trim() != string.Empty)  // AQUI ESTOY preguntando que si el textbox es diferente de vacio
                    {
                        InsertaData();

                        LimpiarForm();
                        txtProducto.Focus();
                    }
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
            txtProducto.Focus();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (existeData == true)
            {
                BorrarData(txtProducto.Text);
                LimpiarForm();
                txtProducto.Focus();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); // cierra
        }

        private void LimpiarForm()
        {
            txtProducto.Clear();
            txtCantidad.Clear();
            txtNombre.Clear();
            txtCosto.Text = "";
            txtPrecio.Clear();
            txtBarra.Clear();
            txtTieneImpuesto.Clear();
            txtImpuesto.Clear();

            existeData = false;
        }

        private void BorrarData(string numProducto)
        {
            SqlConnection cnx = new SqlConnection(cnn.db);
            cnx.Open();

            string tsQuery = "UPDATE PRODUCTOS SET ESTATUSPRODUCTO = 3 FROM PRODUCTOS WHERE ITEM ='" + numProducto;
            SqlCommand cmd = new SqlCommand(tsQuery, cnx);
            cmd.ExecuteNonQuery();
        }

        private void InsertaData()
        {
            // ----------------------------------------------------------------------
            // BORRA SI EL REGISTRO EXISTE
            // ----------------------------------------------------------------------
            SqlConnection cxn = new SqlConnection(cnn.db);
            cxn.Open();

            string tsQuery = "DELETE FROM PRODUCTOS WHERE ITEM ='" + txtProducto.Text + "'";
            SqlCommand cdm = new SqlCommand(tsQuery, cxn);
            cdm.ExecuteNonQuery();
            cxn.Close();

            SqlConnection cnx = new SqlConnection(cnn.db);  // le indica la conexion a la base de datos por medio la clase cnn
            cnx.Open();  // abrimos la base de datos

            string stQuery = "INSERT INTO PRODUCTOS (ITEM, DECRIPCION, CANTIDAD, COSTOS, PRECIODEVENTA, IMPUESTO, BARCODE, ESTATUSPRODUCTO" +
                             "     VALUES (@A0, @A1, @A2, @A3, @A4, @A5, @A6, @A7, 1)";

            SqlCommand cmd = new SqlCommand(stQuery, cnx);
            cmd.Parameters.AddWithValue("@A0", txtProducto.Text); // declaramos la variable y le asignamos valor por medio del textbox
            cmd.Parameters.AddWithValue("@A1", txtNombre.Text);
            cmd.Parameters.AddWithValue("@A2", txtCantidad.Text);
            cmd.Parameters.AddWithValue("@A3", txtCosto.Text);
            cmd.Parameters.AddWithValue("@A4", txtCantidad.Text);
            cmd.Parameters.AddWithValue("@A5", txtPrecio.Text);
            cmd.Parameters.AddWithValue("@A6", txtImpuesto.Text);
            cmd.Parameters.AddWithValue("@A7", txtBarra.Text);

            cmd.ExecuteNonQuery();  
            cnx.Close();  // cerramos la base de datos
        }

        private void BuscarData(string nProd)
        {
            existeData = false;

            SqlConnection cnx = new SqlConnection(cnn.db);  // le indica la conexion a la base de datos por medio la clase cnn
            cnx.Open();

            string stQuery = "     SELECT ITEM, DESCRIPCION, CANTIDAD, PRECIODEVENTA, COSTO, Impuesto, TieneImpuesto, BarCode " +
                             "       FROM PRODUCTOS " +
                             "      WHERE EstatusProducto = 1 " +
                             "        AND ITEM ='" + nProd + "'";
            SqlCommand cmd = new SqlCommand(stQuery, cnx);
            SqlDataReader rcd = cmd.ExecuteReader();

            if (rcd.Read())
            {
                existeData = true;

                txtNombre.Text = Convert.ToString(rcd["DESCRIPCION"]);
                txtCantidad.Text = Convert.ToString(rcd["CANTIDAD"]);
                txtCosto.Text = Convert.ToString(rcd["COSTO"]);
                txtPrecio.Text = Convert.ToString(rcd["PRECIODEVENTA"]);
                txtImpuesto.Text = Convert.ToString(rcd["Impuesto"]);
                txtBarra.Text = Convert.ToString(rcd["BarCode"]);
                txtTieneImpuesto.Text = Convert.ToString(rcd["TieneImpuesto"]);
            }
        }

        private void txtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)  // aqui pregunta si la tecla que presionaste es igual ENTER
            {
                e.Handled = true;
                if (txtProducto.Text.Trim() != string.Empty)  // AQUI ESTOY preguntando que si el textbox es diferente de vacio
                {
                    txtNombre.Focus(); // movera el cursor hacia el siguiente textbox
                }
            }
        }

        private void txtProducto_Leave(object sender, EventArgs e)
        {
            if (txtProducto.Text.Trim() != string.Empty)  // AQUI ESTOY preguntando que si el textbox es diferente de vacio
            {
                BuscarData(txtProducto.Text);  // ejecuta el metodo y le envia la data del textbox al metodo
            }
        }

        private void txtProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)   // esta preguntado que si presinaste la tecla F4
            {
                btnProducto.PerformClick();
            }
        }
    }
}
