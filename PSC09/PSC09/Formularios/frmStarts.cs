using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;  // libreria para utilizar SQL

namespace PSC09
{
    public partial class frmStarts : Form
    {

        string password;

        public frmStarts()
        {
            InitializeComponent();
        }

        private void frmStarts_Load(object sender, EventArgs e)
        {
            this.Text = "Login";      // cambiamos el titulo del formulario
            this.KeyPreview = true;   // activamos las teclas de funciones
            
        }

        private void frmStarts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)  // preguntaos que si la tecla que presionaste es igual ESC
            {
                this.Close();   // cierra el formulario
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)  // pregunta que si presionaste la tecla Enter
            {
                e.Handled = true;   // indica que se ejecuto enter



                if (txtUsuario.Text.Trim() != string.Empty)  // pregunta que si el textbox es diferente de vacio
                {
                    txtPassword.Focus();  // movera el cursor hacia el textbox password
                }
            }
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)  // preguntaos que si la tecla que presionaste es igual ESC
            {
                this.Close();   // cierra el formulario
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() != string.Empty)  // pregunta que si el textbox es diferente de vacio
            {
                BuscarUsuario(txtUsuario.Text);
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); // cierro el formulario
        }


        // --------------------------------------------------
        // METODOS
        // --------------------------------------------------
        private void BuscarUsuario(string cualUsuario)
        {
            string miQuery = "SELECT NOMBRECORTO, " +
                             "       CLAVE " +
                             "  FROM USUARIO " +
                             " WHERE NOMBRECORTO ='" + cualUsuario + "'";

            SqlConnection cnxn = new SqlConnection(@"server=DESKTOP-TFVTCNK\SQLEXPRESS; database=DBPRACTICA04; integrated security = true");
            cnxn.Open();
            SqlCommand cmd = new SqlCommand(miQuery, cnxn);
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                //password = Convert.ToString(rdr["CLAVE"]);

                password = rdr["CLAVE"].ToString();
            }
        }
    }
}
