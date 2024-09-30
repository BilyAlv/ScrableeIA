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
    public partial class frmVENFABRICA : Form
    {
        public string var1;
        public string var2;
        public Boolean existeVar;

        public frmVENFABRICA()
        {
            InitializeComponent();
        }

        private void frmVENFABRICA_Load(object sender, EventArgs e)
        {
            this.Text = "Consulta Fabricas";
            this.KeyPreview = true;
            existeVar = false;

            EstiloDataGridView();
        }

        private void frmVENFABRICA_KeyDown(object sender, KeyEventArgs e)
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
            this.Close();
        }

        private void BuscarData()
        {
            existeVar = false;

            this.dgv.Rows.Clear();  // limpia el datagridview
            this.dgv.Refresh();     // refresca y le devuelve las especificaciones anteriores

            SqlConnection cnx = new SqlConnection(cnn.db);
            cnx.Open();

            string stQuery = "SELECT IDFABRICA, NOMBREDEFABRICA" +
                             "  FROM FABRICA " +
                             " WHERE NOMBREDEFABRICA LIKE '%" + txtBuscar.Text + "%' ORDER BY NOMBREDEFABRICA ASC";
            SqlCommand cmd = new SqlCommand(stQuery, cnx);
            SqlDataReader rcd = cmd.ExecuteReader();

            while (rcd.Read())
            {
                existeVar = true;

                dgv.Rows.Add();   // le suma uno al contador del datagridview
                int xRows = dgv.Rows.Count - 1;

                dgv[0, xRows].Value = Convert.ToString(rcd["IDFABRICA"]);
                dgv[1, xRows].Value = Convert.ToString(rcd["NOMBREDEFABRICA"]);
            }
        }

        private void EstiloDataGridView()
        {
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersVisible = true;
            this.dgv.RowHeadersVisible = false;

            this.dgv.Columns.Add("Col00", "Fabrica");
            this.dgv.Columns.Add("Col01", "Nombre de Fabrica");

            DataGridViewColumn
            column = dgv.Columns[00]; column.Width = 100;
            column = dgv.Columns[01]; column.Width = 590;

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

            var1 = dgv.CurrentRow.Cells[0].Value.ToString();
            var2 = dgv.CurrentRow.Cells[1].Value.ToString();
            existeVar = true;

            this.Close();
        }

        private void btnSelecciona_Click(object sender, EventArgs e)
        {
            if (dgv.RowCount > 0)
            {
                try
                {
                    var1 = dgv.CurrentRow.Cells[0].Value.ToString();
                    var2 = dgv.CurrentRow.Cells[1].Value.ToString();

                    existeVar = true;
                    this.Close();
                }
                catch
                {
                    //
                }
            }
        }
    }
}

