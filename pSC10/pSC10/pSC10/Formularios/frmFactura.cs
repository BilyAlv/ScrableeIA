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
    public partial class frmFactura : Form
    {
        Boolean ExisteLaData;
        double zImpuesto;
        double zTotal;
        double zSubtotal;
        double lnImpuesto;

        public frmFactura()
        {
            InitializeComponent();
            EstiloDataGridView();  // le damos el formato que deseamos al datagridview
        }

        private void frmFactura_Load(object sender, EventArgs e)
        {
            this.Text = "Factura";
            this.KeyPreview = true;

            lblFechaFactura.Text = DateTime.Now.ToString("ddMMyyyy");

            ExisteLaData = false;   // esta variable la vamos a usar cuando consultemos una factura para luego usarla en el boton borrar

            lblFactura.Text = Busco.BuscaUltimoNumero("1");  // AQUI TRAE EL ULTIMO NUMERO DE FACTURA
        }

        private void frmFactura_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)  // pregunta si presionaste la tecla de ESC
            {
                this.Close();  // cierra el formulario
            }
        }

        #region --> TextBox <<--
        // -----------------------------------------------------------------
        // TEXTBOX
        // -----------------------------------------------------------------

        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;
                if (txtCliente.Text.Trim() != string.Empty)
                {
                    txtArticulo.Focus();
                }
            }
        }

        private void txtCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                btnVENCTE.PerformClick();
            }
        }

        private void txtCliente_Leave(object sender, EventArgs e)
        {
            if (txtCliente.Text.Trim() != string.Empty)
            {
                BuscarCliente(txtCliente.Text);
            }
        }

        private void txtArticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;
                if (txtArticulo.Text.Trim() != string.Empty)
                {
                    txtCantidad.Focus();
                }
            }
        }

        private void txtArticulo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                btnArticulo.PerformClick();
            }
        }

        private void txtArticulo_Leave(object sender, EventArgs e)
        {
            if (txtArticulo.Text.Trim() != string.Empty)
            {
                BuscarArticulo(txtArticulo.Text); // metodo para buscar un articulo o producto
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;
                if (txtCantidad.Text.Trim() != string.Empty)
                {
                    btnInsertarLn.Focus();
                }
            }
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            // calcula el total por linea antes de insertar la en el datagridview

            double nmCant = Convert.ToDouble(txtCantidad.Text);
            double nmPrec = Convert.ToDouble(lblPrecio.Text);

            if (nmCant > 0)
            {
                if (nmPrec > 0)
                {
                    double price = Convert.ToDouble(lblPrecio.Text);
                    double quantity = Convert.ToDouble(txtCantidad.Text);
                    double total = price * quantity;   // total sin impuesto

                    lblTotalLn.Text = total.ToString();
                }
            }
        }

        #endregion

        private void btnBorrarLn_Click(object sender, EventArgs e)
        {
            if (dgv.RowCount > 0)
            {
                BorrarLineaDelDataGridView();  // metodo para borrar una linea del datagridview
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (ExisteLaData == true)  // solo si es verdadera borra la factura
            {
                BorrarData(lblFactura.Text);
                LimpiarFormulario();

                ExisteLaData = false; // luego de borrar hay que colocarla false
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // si el datagridview tiene data, limpiara la linea del detalle luego la linea 
            // seleccionada se mostrara el los textbox y label
            // luego borramos de la grilla esa linea seleccionada
            // para luego totalizar la grilla sin esa linea

            if (dgv.RowCount > 0)
            {
                LimpiarDetalle();

                txtArticulo.Text = dgv.CurrentRow.Cells[0].Value.ToString();
                lblArticulo.Text = dgv.CurrentRow.Cells[1].Value.ToString();
                txtCantidad.Text = dgv.CurrentRow.Cells[2].Value.ToString();
                lblPrecio.Text = dgv.CurrentRow.Cells[3].Value.ToString();
                lblImpuesto.Text = dgv.CurrentRow.Cells[4].Value.ToString();
                lblTotalLn.Text = dgv.CurrentRow.Cells[5].Value.ToString();

                BorrarLineaDelDataGridView();

                TotalizarFactura();
            }
        }

        private void btnArticulo_Click(object sender, EventArgs e)
        {
            // falta la ventana de consulta de articulo

        }

        #region -->> METODOS <<--
        // -----------------------------------------------------------------
        // METODOS
        // -----------------------------------------------------------------

        private void BuscarFactura(string nmrFactura)
        {
            ExisteLaData = false;  // es falsa mientras no se busque una factura

            SqlConnection cnx = new SqlConnection(cnn.db); cnx.Open();
            string tsQuery = "SELECT A.FACTURA, " +
                             "       A.CLIENTE, " +
                             "       A.FECHA, " +
                             "       A.SUBTOTAL," +
                             "       A.IMPUESTO, " +
                             "       A.MONTOFACTURADO," +
                             "       B.NOMBRE," +
                             "       B.PAGAIMPUESTO " +
                             "  FROM HFACTURA A INNER JOIN CLIENTES B ON A.CLIENTE =  B.IDCLIENTE " +
                             " WHERE A.FACTURA = '" + nmrFactura + "'" +
                             "   AND A.ACTIVO  = 0";
            SqlCommand cmd = new SqlCommand(tsQuery, cnx);
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                ExisteLaData = true; // es verdadera cuando encontramos la factura

                // asignamos los valores de los campos de la tabla a los label y textbox
                lblFactura.Text = Convert.ToString(rdr["FACTURA"]);
                lblFechaFactura.Text = Convert.ToString(rdr["FECHA"]);
                txtCliente.Text = Convert.ToString(rdr["CLIENTE"]);

                lblPagaImpuesto.Text = Convert.ToString(rdr["PAGAIMPUESTO"]);
                lblNombre.Text = Convert.ToString(rdr["NOMBRE"]);

                lblSubtotal.Text = Convert.ToString(rdr["SUBTOTAL"]);
                lblImpuesto.Text = Convert.ToString(rdr["IMPUESTO"]);
                lblTotal.Text = Convert.ToString(rdr["MONTOFACTURADO"]);
                 
                BuscaDetalle(lblFactura.Text);  // este metodo es para buscar el detalle de la factura

                TotalizarFactura(); // metodo para totalizar la factura
            }

            cmd.Dispose();
            cnx.Close();  // cerramos la conexion a la Base de datos
        }

        private void BuscaDetalle(string nmrFactura)
        {
            this.dgv.Rows.Clear();  // limpia el datagridview
            this.dgv.Refresh();     // refresca y le devuelve las especificaciones anteriores

            // abrimos la base de datos
            SqlConnection cnx = new SqlConnection(cnn.db);        cnx.Open();

            // script que sera enviado al motor de sql
            string stQuery = "    SELECT A.ARTICULO, " +
                             "           B.DESCRIPCION, " +
                             "           A.CANTIDAD, " +
                             "           A.PRECIODEVENTA, " +
                             "           A.IMPUESTO, " +
                             "           A.MONTOPORLINEA " +
                             "      FROM DFACTURA A INNER JOIN PRODUCTOS B ON A.ARTICULO = B.ITEM " +
                             "     WHERE A.FACTURA ='" + nmrFactura +
                             "' ORDER BY A.FACTURA, A.SEC ASC";
            SqlCommand cmd = new SqlCommand(stQuery, cnx);
            SqlDataReader rcd = cmd.ExecuteReader(); // ejecutamos el scripts

            // recorre el contenedor con los registros encontrados de la factura 
            while (rcd.Read())
            {
                dgv.Rows.Add();   // le suma uno al contador del datagridview
                int xRows = dgv.Rows.Count - 1;  // le resta 1 para obtener la linea correcta en donde se colocara los valores 

                dgv[0, xRows].Value = Convert.ToString(rcd["ARTICULO"]);
                dgv[1, xRows].Value = Convert.ToString(rcd["DESCRIPCION"]);
                dgv[2, xRows].Value = Convert.ToString(rcd["CANTIDAD"]);
                dgv[3, xRows].Value = Convert.ToString(rcd["PRECIODEVENTA"]);
                dgv[4, xRows].Value = Convert.ToString(rcd["IMPUESTO"]);
                dgv[5, xRows].Value = Convert.ToString(rcd["MONTOPORLINEA"]);
            }
        }

        private void BuscarArticulo(string nmrArticulo)
        {
            SqlConnection cnx = new SqlConnection(cnn.db); cnx.Open();
            string tsQuery = "SELECT ITEM, DESCRIPCION, PRECIODEVENTA, IMPUESTO FROM PRODUCTOS WHERE ITEM ='" + nmrArticulo + "'";
            SqlCommand cmd = new SqlCommand(tsQuery, cnx);
            SqlDataReader rdr = cmd.ExecuteReader();  // ejecutamos el scripts

            if (rdr.Read()) // verifica si obtuvo datos
            {
                lblArticulo.Text = Convert.ToString(rdr["DESCRIPCION"]);
                lblPrecio.Text = Convert.ToString(rdr["PRECIODEVENTA"]);
                lnImpuesto = Convert.ToDouble(rdr["IMPUESTO"]);  // este campo contiene el % del impuesto con este vamos a calcular el impuesto
            }

            cmd.Dispose();
            cnx.Close(); // cerramos la conexion a la Base de datos

        }

        private void BuscarCliente(string nmrCliente)
        {
            SqlConnection cnx = new SqlConnection(cnn.db); cnx.Open();
            string tsQuery = "SELECT NOMBRE, PAGAIMPUESTO FROM CLIENTES WHERE  IDCLIENTE = " + nmrCliente ;
            SqlCommand cmd = new SqlCommand(tsQuery, cnx);
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read()) // ejecutamos el scripts
            {
                lblNombre.Text = Convert.ToString(rdr["NOMBRE"]);
                lblPagaImpuesto.Text = Convert.ToString(rdr["PAGAIMPUESTO"]);  // aqui debe traer 1 =Paga Impuesto / 0 =No paga impuesto

                if (lblPagaImpuesto.Text == "1")
                {
                    lblNombrePaga.Text = "Paga Impuesto";
                }
                else
                {
                    lblNombrePaga.Text = "No Paga Impuesto";
                }
            }

            cmd.Dispose();
            cnx.Close();
        }

        private void TotalizarFactura()
        {
            try
            {
                zImpuesto = 0;
                zSubtotal = 0;
                zTotal = 0;

                lblSubtotal.Text = "";
                lblImpuesto.Text = "";
                lblTotal.Text = "";

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    Double nImpuesto = Convert.ToDouble(dgv.CurrentRow.Cells[4].Value.ToString()); // obtiene el valor del impuesto
                    Double nSubtotal = Convert.ToDouble(dgv.CurrentRow.Cells[5].Value.ToString()); // obtiene el valor del precio * cantidad

                    // calculo del impuesto por linea de articulo
                    Double nTotal = nSubtotal + nImpuesto;

                    // acumula los valores
                    zImpuesto = zImpuesto + nImpuesto;
                    zSubtotal = zSubtotal + nSubtotal;
                    zTotal = zTotal + nTotal;
                }

                // dejo ver los totales
                lblSubtotal.Text = Convert.ToString(zSubtotal);
                lblImpuesto.Text = Convert.ToString(zImpuesto);
                lblTotal.Text = Convert.ToString(zTotal);
            }
            catch
            {
                //
            }
        }

        private void EstiloDataGridView()
        {
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersVisible = false;
            this.dgv.RowHeadersVisible = false;

            this.dgv.Columns.Add("Col00", "");
            this.dgv.Columns.Add("Col01", "");
            this.dgv.Columns.Add("Col02", "");
            this.dgv.Columns.Add("Col03", "");
            this.dgv.Columns.Add("Col04", "");
            this.dgv.Columns.Add("Col05", "");

            DataGridViewColumn
            column = dgv.Columns[00]; column.Width = 100;
            column = dgv.Columns[01]; column.Width = 420;
            column = dgv.Columns[02]; column.Width = 100;
            column = dgv.Columns[03]; column.Width = 100;
            column = dgv.Columns[04]; column.Width = 100;
            column = dgv.Columns[05]; column.Width = 100;

            this.dgv.BorderStyle = BorderStyle.None;
            this.dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            this.dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            this.dgv.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            this.dgv.BackgroundColor = Color.LightGray;

            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 6, 0, 6);
            this.dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.CornflowerBlue;
            this.dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void InsertarData()
        {
            if (dgv.RowCount > 0)  // verifica que datagridview tenga data
            {
                if (lblTotal.Text != string.Empty) // verfica que el label del total sea diferente de vacio
                {
                    string stQuery = "INSERT INTO HFACTURA (FACTURA, CLIENTE, FECHA, SUBTOTAL, IMPUESTO, MONTOFACTURADO, ACTIVO ) " +
                                     "VALUES (@A0, @A1, @A2, @A3, @A4, @A5, @A6);";
                    SqlConnection cnt = new SqlConnection(cnn.db); cnt.Open();
                    SqlCommand cmd = new SqlCommand(stQuery, cnt);

                    cmd.Parameters.AddWithValue("@A0", lblFactura.Text);
                    cmd.Parameters.AddWithValue("@A1", txtCliente.Text);
                    cmd.Parameters.AddWithValue("@A2", lblFechaFactura.Text);
                    cmd.Parameters.AddWithValue("@A3", lblSubtotal.Text);
                    cmd.Parameters.AddWithValue("@A4", lblImpuesto.Text);
                    cmd.Parameters.AddWithValue("@A5", lblTotal.Text);
                    cmd.Parameters.AddWithValue("@A6", "1");

                    cmd.ExecuteNonQuery(); // ejecuta el query

                    cmd.Dispose();
                    cnt.Close();

                    InsertaDetalleFactura();  // metodo para insertar el detalle de la factura
                }
            }
        }

        private void InsertaDetalleFactura()
        {
            string stQueri = "INSERT INTO DFACTURA " +
                             "          ( FACTURA,       " +
                             "            ARTICULO, " +
                             "            CANTIDAD, " +
                             "            PRECIODEVENTA, " +
                             "            IMPUESTO, " +
                             "            MONTOPORLINEA, " +
                             "            CLIENTE,  " +
                             "            FECHA,    " +
                             "            SEC,           " +
                             "            ACTIVO ) " +
                             "     VALUES (@A0, @A1, @A2, @A3, @A4, @A5, @A6, @A7, @A8, @A9)";

            SqlConnection cnx = new SqlConnection(cnn.db); cnx.Open();

            // recorre el datagridview e inserta los valores de cada celda a la tabla
            for (int xrow = 0; xrow < dgv.Rows.Count - 1; xrow++)
            {
                // obtiene los valores de las celdas 
                string nmArt = dgv.Rows[xrow].Cells[0].Value.ToString();
                string nmCan = dgv.Rows[xrow].Cells[2].Value.ToString();
                string nmPre = dgv.Rows[xrow].Cells[3].Value.ToString();
                string nmImp = dgv.Rows[xrow].Cells[4].Value.ToString();
                string nmTot = dgv.Rows[xrow].Cells[5].Value.ToString();

                SqlCommand cmm = new SqlCommand(stQueri, cnx);
                cmm.Parameters.AddWithValue("@A0", lblFactura.Text);
                cmm.Parameters.AddWithValue("@A1", nmArt);
                cmm.Parameters.AddWithValue("@A2", nmCan);
                cmm.Parameters.AddWithValue("@A3", nmPre);
                cmm.Parameters.AddWithValue("@A4", nmImp);
                cmm.Parameters.AddWithValue("@A5", nmTot);
                cmm.Parameters.AddWithValue("@A6", txtCliente.Text);
                cmm.Parameters.AddWithValue("@A7", lblFechaFactura.Text);
                cmm.Parameters.AddWithValue("@A8", xrow.ToString());
                cmm.Parameters.AddWithValue("@A9", "1");

                cmm.ExecuteNonQuery();
                cmm.Dispose();
            }
        }

        private void BorrarData(string numFactura)
        {
            if (ExisteLaData == true)  // si la variable es verdadera entonces podras borrar el registro
            {
                SqlConnection cns = new SqlConnection(cnn.db);   cns.Open();
                string ssQuery = "DELETE FROM HFACTURA WHERE FACTURA ='" + numFactura + "'";
                SqlCommand cms = new SqlCommand(ssQuery, cns);
                cms.ExecuteNonQuery();

                SqlConnection cnx = new SqlConnection(cnn.db);   cnx.Open();
                string tsQuery = "DELETE FROM DFACTURA WHERE FACTURA ='" + numFactura +"'";
                SqlCommand cmd = new SqlCommand(tsQuery, cnx);
                cmd.ExecuteNonQuery();
            }
        }

        private void LimpiarDetalle()
        {
            txtArticulo.Clear();
            lblArticulo.Text = "";
            txtCantidad.Clear();
            lblImpuestoLn.Text = "";
            lblTotalLn.Text = "";
            lblPrecio.Text = "";
        }

        private void LimpiarFormulario()
        {
            ExisteLaData = false;

            lblFactura.Text = "";
            txtCliente.Clear();
            lblNombre.Text = "";
            lblPagaImpuesto.Text = "";
            lblNombrePaga.Text = "";

            lblSubtotal.Text = "";
            lblImpuesto.Text = "";
            lblTotal.Text = "";

            this.dgv.Rows.Clear();  // limpia el datagridview
            this.dgv.Refresh();     // refresca y le devuelve las especificaciones anteriores

            LimpiarDetalle();  // metodo para limpiar el detalle

            lblFactura.Text = Busco.BuscaUltimoNumero("1");  // AQUI TRAE EL ULTIMO NUMERO DE FACTURA
        }

        private void InsertaLinea()
        {
            // inserta una linea al datagridview
            dgv.Rows.Add();
            int xRows = dgv.Rows.Count - 1;

            dgv[0, xRows].Value = txtArticulo.Text;
            dgv[1, xRows].Value = lblArticulo.Text;
            dgv[2, xRows].Value = txtCantidad.Text;
            dgv[3, xRows].Value = lblPrecio.Text;
            dgv[4, xRows].Value = lblImpuestoLn.Text;
            dgv[5, xRows].Value = lblTotalLn.Text;

        }

        private void BorrarLineaDelDataGridView()
        {
            int CuantasLineasTengo = Convert.ToInt32(dgv.RowCount);

            if (CuantasLineasTengo == 1)  // esta pregunta es por que si el datagridview tiene una sola linea se utiliza este metodo para borrar
            {
                dgv.Rows.RemoveAt(dgv.RowCount - 1);
            }
            else // de lo contrario utiliza este
            {
                dgv.Rows.Remove(dgv.CurrentRow);
            }

            txtArticulo.Focus();  // mueve el focus hacia ese textbox
        }


        private void ActualizaSecuenciaFactura(string numFactura)
        {
            // despues de insertada una factura en las tablas actualiza la secuencia en esta otra tabla
            string upQuery = "UPDATE SECUENCIA SET SECUENCIA ='" + numFactura + "' FROM SECUENCIA WHERE ID ='1')";

            SqlConnection cnx = new SqlConnection(cnn.db); cnx.Open();
            SqlCommand cmd = new SqlCommand(upQuery, cnx);
            cmd.ExecuteNonQuery();
        }

        #endregion

        #region -->> BOTONES <<--
        // -----------------------------------------------------------------
        // BOTONES
        // -----------------------------------------------------------------
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();  // limpia el formulario

            lblFactura.Text = Busco.BuscaUltimoNumero("1"); // busca el numero de factura siguiente
            txtCliente.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (lblTotal.Text.Trim() != string.Empty)  // si total es diferente de vacio 
            {
                BorrarData(lblFactura.Text);  // borra la factura por si acaso existe
                InsertarData();  // inserta la nueva factura

                LimpiarFormulario(); // limpia el formulario
                ActualizaSecuenciaFactura(lblFactura.Text); // actualiza la secuencia de factura

                txtCliente.Focus();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCONFACT_Click(object sender, EventArgs e)
        {
            // abre la ventana de consulta factura
            frmVENFACT frm = new frmVENFACT();
            frm.ShowDialog();

            lblFactura.Text = frm.var1;  // me trae de la ventana de consulta la factura seleccionada
            BuscarFactura(lblFactura.Text); // con ese numero va al metodo a buscar la factura
            
        }

        private void btnVENCTE_Click(object sender, EventArgs e)
        {
            frmVENCTE frm = new frmVENCTE();  // abre la ventana de consulta cliente
            DialogResult res = frm.ShowDialog();

            txtCliente.Text = frm.var1;  // aqui trae el cliente
            lblNombre.Text = frm.var2;   // aqui trae el nombre

        }

        private void btnInsertarLn_Click(object sender, EventArgs e)
        {
            if (txtArticulo.Text.Trim() != string.Empty)
            {
                if (txtCantidad.Text.Trim() != string.Empty)
                {
                    InsertaLinea();  // inserta una linea en el datagridview
                    TotalizarFactura(); // totaliza la factura
                    LimpiarDetalle();  // limpia el detalle
                }
            }
        }
        #endregion

    }
}
