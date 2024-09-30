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
    public partial class frmMVTOCTE : Form
    {
        string codCliente;
        int ed;
        double coluno;
        double coldos;
        double coltre;
        int nmRow;

        public frmMVTOCTE()
        {
            InitializeComponent();
            EstiloDataGridView();
        }

        private void frmMVTOCTE_Load(object sender, EventArgs e)
        {
            this.Text = "Movimiento Clientes";
            this.KeyPreview = true;
        }

        private void frmMVTOCTE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void MovimientosDeCliente(string numCliente)
        {
            this.dgv.Rows.Clear();  // limpia el datagridview
            this.dgv.Refresh();     // refresca y le devuelve las especificaciones anteriores

            SqlConnection cnx = new SqlConnection(cnn.db);
            cnx.Open();

            string stquery = "     SELECT A.CustomerID, " +
                             "            D.CompanyName, " +
                             "            A.OrderID, " +
                             "            A.OrderDate, " +
                             "            B.ProductID, " +
                             "            C.ProductName, " +
                             "            B.Quantity, " +
                             "            B.Discount, " +
                             "            B.UnitPrice, " +
                             "           (B.Quantity * B.UnitPrice) * B.Discount AS Descuento, " +
                             "           (B.Quantity * B.UnitPrice) AS Total_Sin_Descuento, " +
                             "           (B.Quantity * B.UnitPrice) -((B.Quantity * B.UnitPrice) * B.Discount) AS Total_Linea " +
                             "      FROM Orders A " +
                             "INNER JOIN [Order Details] B ON A.OrderID    = B.OrderID " +
                             "INNER JOIN Products C        ON B.ProductID  = C.ProductID " +
                             "INNER JOIN Customers D       ON A.CustomerID = D.CustomerID " +
                             "     WHERE A.CustomerID ='" + numCliente + "'" + 
                             "  ORDER BY A.CustomerID ASC";

            SqlCommand cmd = new SqlCommand(stquery, cnx);
            SqlDataReader rcd = cmd.ExecuteReader();

            codCliente = "";
            nmRow = 0;
            coluno = 0;
            coldos = 0;
            coltre = 0;

            while (rcd.Read())
            {

                dgv.Rows.Add();   // le suma uno al contador del datagridview
                int xRows = dgv.Rows.Count - 1;

                dgv[00, xRows].Value = Convert.ToString(rcd["CustomerID"]);
                dgv[01, xRows].Value = Convert.ToString(rcd["CompanyName"]);
                dgv[02, xRows].Value = Convert.ToString(rcd["OrderID"]);
                dgv[03, xRows].Value = Convert.ToString(rcd["OrderDate"]);
                dgv[04, xRows].Value = Convert.ToString(rcd["ProductID"]);
                dgv[05, xRows].Value = Convert.ToString(rcd["ProductName"]);
                dgv[06, xRows].Value = Convert.ToString(rcd["Quantity"]);
                dgv[07, xRows].Value = Convert.ToString(rcd["Discount"]);
                dgv[08, xRows].Value = Convert.ToString(rcd["UnitPrice"]);
                dgv[09, xRows].Value = Convert.ToString(rcd["Descuento"]);
                dgv[10, xRows].Value = Convert.ToString(rcd["Total_Sin_Descuento"]);
                dgv[11, xRows].Value = Convert.ToString(rcd["Total_Linea"]);

                coluno = coluno +  Convert.ToDouble(rcd["Descuento"]);
                coldos = coldos + Convert.ToDouble(rcd["Total_Sin_Descuento"]);
                coltre = coltre + Convert.ToDouble(rcd["Total_Linea"]);

            }

        ln200:

            subTotal(nmRow, coluno, coldos, coltre);
        }

        private void subTotal(int r, double col01, double col02, double col03)
        {
            dgv.Rows.Add();   // le suma uno al contador del datagridview
            int xRows = dgv.Rows.Count - 1;

            dgv[0, xRows].Value = Convert.ToString(col01);
            dgv[1, xRows].Value = Convert.ToString(col02);
            dgv[1, xRows].Value = Convert.ToString(col03);
        }

        private void EstiloDataGridView()
        {
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersVisible = true;
            this.dgv.RowHeadersVisible = false;

            this.dgv.Columns.Add("Col00", "Cliente");
            this.dgv.Columns.Add("Col01", "Nombre");
            this.dgv.Columns.Add("Col02", "Orden");
            this.dgv.Columns.Add("Col03", "Fecha");
            this.dgv.Columns.Add("Col04", "Producto");
            this.dgv.Columns.Add("Col05", "Nombre Producto");
            this.dgv.Columns.Add("Col06", "Cantidad");
            this.dgv.Columns.Add("Col07", "Descuento");
            this.dgv.Columns.Add("Col08", "Precio");
            this.dgv.Columns.Add("Col09", "T Desc Linea");
            this.dgv.Columns.Add("Col10", "T Sin Desc");
            this.dgv.Columns.Add("Col11", "T Linia");

            DataGridViewColumn
            column = dgv.Columns[00]; column.Width = 100;
            column = dgv.Columns[01]; column.Width = 100;
            column = dgv.Columns[02]; column.Width = 100;
            column = dgv.Columns[03]; column.Width = 100;
            column = dgv.Columns[04]; column.Width = 100;
            column = dgv.Columns[05]; column.Width = 100;
            column = dgv.Columns[06]; column.Width = 100;
            column = dgv.Columns[07]; column.Width = 100;
            column = dgv.Columns[08]; column.Width = 100;
            column = dgv.Columns[09]; column.Width = 100;
            column = dgv.Columns[10]; column.Width = 100;
            column = dgv.Columns[11]; column.Width = 100;

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

        private void LimpiarFormulario()
        {
            this.dgv.Rows.Clear();  // limpia el datagridview
            this.dgv.Refresh();     // refresca y le devuelve las especificaciones anteriores
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmVENCTE frm = new frmVENCTE();
            frm.ShowDialog();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MovimientosDeCliente(txtCliente.Text);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)  // aqui pregunta si la tecla que presionaste es igual ENTER
            {
                e.Handled = true;
                btnBuscar.Focus();
            }
        }
    }
}
