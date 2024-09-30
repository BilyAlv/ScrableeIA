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
    public partial class frmVENFACT : Form
    {
        public string var1;
        public string var2;
        public string var3;
        public Boolean existeVar;

        public frmVENFACT()
        {
            InitializeComponent();
            EstiloDataGridView();
        }

        private void frmVENFACT_Load(object sender, EventArgs e)
        {

        }

        private void frmVENFACT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)  // aqui pregunta si la tecla que presionaste es igual ENTER
            {
                e.Handled = true;
                btnAceptar.Focus();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            BuscarData();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            existeVar = false;
            this.Close();
        }

        private void BuscarData()
        {
            existeVar = false;

            this.dgv.Rows.Clear();  // limpia el datagridview
            this.dgv.Refresh();     // refresca y le devuelve las especificaciones anteriores

            SqlConnection cnx = new SqlConnection(cnn.db);
            cnx.Open();

            string stQuery = "SELECT FACTURA, FECHA, SUBTOTAL, IMPUESTO, MONTOFACTURADO " +
                             "  FROM HFACTURA " +
                             " WHERE CLIENTE = '" + txtBuscar.Text + "' ORDER BY FACTURA, FECHA ASC";
            SqlCommand cmd = new SqlCommand(stQuery, cnx);
            SqlDataReader rcd = cmd.ExecuteReader();

            while (rcd.Read())
            {
                dgv.Rows.Add();   // le suma uno al contador del datagridview
                int xRows = dgv.Rows.Count - 1;

                dgv[0, xRows].Value = Convert.ToString(rcd["FACTURA"]);
                dgv[1, xRows].Value = Convert.ToString(rcd["FECHA"]);
                dgv[2, xRows].Value = Convert.ToString(rcd["SUBTOTAL"]);
                dgv[3, xRows].Value = Convert.ToString(rcd["IMPUESTO"]);
                dgv[4, xRows].Value = Convert.ToString(rcd["MONTOFACTURADO"]);
            }
        }

        private void EstiloDataGridView()
        {
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersVisible = true;
            this.dgv.RowHeadersVisible = false;

            this.dgv.Columns.Add("Col00", "Documento");
            this.dgv.Columns.Add("Col01", "Fecha");
            this.dgv.Columns.Add("Col02", "Subtotal");
            this.dgv.Columns.Add("Col03", "Impuesto");
            this.dgv.Columns.Add("Col04", "Monto");

            DataGridViewColumn
            column = dgv.Columns[00]; column.Width = 100;
            column = dgv.Columns[01]; column.Width = 100;
            column = dgv.Columns[02]; column.Width = 150;
            column = dgv.Columns[03]; column.Width = 150;
            column = dgv.Columns[04]; column.Width = 150;

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

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSelecciona.PerformClick();
        }

        private void btnSelecciona_Click(object sender, EventArgs e)
        {
            if (dgv.RowCount > 0)
            {
                var1 = dgv.CurrentRow.Cells[0].Value.ToString();  // FACTURA
                var2 = dgv.CurrentRow.Cells[1].Value.ToString();  // FECHA
                var3 = dgv.CurrentRow.Cells[4].Value.ToString();  // MONTO

                existeVar = true;
                this.Close();
            }
        }
    }
}

