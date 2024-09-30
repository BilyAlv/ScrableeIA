using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;  // esta libreria la utilizamos para acceder a la base de datos

namespace pVTA
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            this.Text = "Maestro de Usuario";
            this.KeyPreview = true;   // activa las teclas de funciones
        }

        private void frmUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close(); // cierra el formulario
            }
        }

        #region --->> BOTONES <<---
        // ------------------------------------------------------
        // BOTONES
        // ------------------------------------------------------
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            LimpiarFormulario();
            txtUsuario.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            txtUsuario.Focus();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

            LimpiarFormulario();
            txtUsuario.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); // cierra el formulario
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnPuesto_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region  --->> TEXTBOX <<---
        // ------------------------------------------------------
        // TEXTBOX
        // ------------------------------------------------------
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)  // pregunta aqui que si la tecla que presionaste es igual a enter
            {
                e.Handled = true;   // aqui de preguntar si presionaste la tecla enter
                if (txtUsuario.Text.Trim() != string.Empty)   // aqui pregunta si el contenido del textbox es diferente de vacio
                {
                    txtNombre.Focus(); // mueve el cursor hacia el textbox llamado txtnombre
                }
            }
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)  // pregunta que si el valor de la tecla que presionaste es igual al valor de la tecla F4
            {
                btnUsuario.PerformClick();  // ejecutara el evento del boton btnUsuario y vuelve aqui de nuevo
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() != string.Empty)
            {
                BuscarUsuario(txtUsuario.Text);
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)  // pregunta aqui que si la tecla que presionaste es igual a enter
            {
                e.Handled = true;   // aqui de preguntar si presionaste la tecla enter
                if (txtNombre.Text.Trim() != string.Empty)   // aqui pregunta si el contenido del textbox es diferente de vacio
                {
                    txtCorreo.Focus(); // mueve el cursor hacia el textbox llamado txtpassword
                }
            }
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)  // pregunta aqui que si la tecla que presionaste es igual a enter
            {
                e.Handled = true;   // aqui de preguntar si presionaste la tecla enter
                if (txtCorreo.Text.Trim() != string.Empty)   // aqui pregunta si el contenido del textbox es diferente de vacio
                {
                    txtPassword.Focus(); // mueve el cursor hacia el textbox llamado txtpassword
                }
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)  // pregunta aqui que si la tecla que presionaste es igual a enter
            {
                e.Handled = true;   // aqui de preguntar si presionaste la tecla enter
                if (txtPassword.Text.Trim() != string.Empty)   // aqui pregunta si el contenido del textbox es diferente de vacio
                {
                    txtPuesto.Focus(); // mueve el cursor hacia el textbox llamado txtpuesto
                }
            }
        }

        private void txtPuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)  // pregunta aqui que si la tecla que presionaste es igual a enter
            {
                e.Handled = true;   // aqui de preguntar si presionaste la tecla enter
                if (txtPuesto.Text.Trim() != string.Empty)   // aqui pregunta si el contenido del textbox es diferente de vacio
                {
                    btnGuardar.Focus(); // mueve el cursor hacia el boton llamado guardar
                }
            }
        }

        private void txtPuesto_Leave(object sender, EventArgs e)
        {
            if (txtPuesto.Text.Trim() != string.Empty)
            {
                BuscarPuesto(txtPuesto.Text);
            }
        }

        private void txtPuesto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)  // pregunta que si el valor de la tecla que presionaste es igual al valor de la tecla F4
            {
                btnPuesto.PerformClick();  // ejecutara el evento del boton btnPuesto y vuelve aqui de nuevo
            }
        }
        #endregion

        // ------------------------------------------------------
        // METODOS
        // ------------------------------------------------------
        private void BuscarUsuario(string nomUsuario)
        {
            SqlConnection cnx = new SqlConnection(cnn.db);  cnx.Open();

            string stQuery = "SELECT NOMBRECORTO, NOMBRECOMPLETO, CORREO, CLAVE, POSICION " +
                             "  FROM USUARIO " +
                             " WHERE ACTIVO = 'True' " +
                             "   AND NOMBRECORTO = @A0";

            SqlCommand cmd = new SqlCommand(stQuery, cnx);
            cmd.Parameters.AddWithValue("@A0", nomUsuario);
            SqlDataReader rcd = cmd.ExecuteReader();

            if (rcd.Read())
            {
                txtUsuario.Text = Convert.ToString(rcd["NOMBRECORTO"]);
                txtNombre.Text = Convert.ToString(rcd["NOMBRECOMPLETO"]);
                txtCorreo.Text = Convert.ToString(rcd["CORREO"]);
                txtPassword.Text = Convert.ToString(rcd["CLAVE"]);
                txtPuesto.Text = Convert.ToString(rcd["POSICION"]);
            }
        }

        private void BuscarPuesto(string numPuesto)
        {
            SqlConnection cnx = new SqlConnection(cnn.db); cnx.Open();

            string stQuery = "SELECT NombreDePosicion FROM POSICION WHERE IDPOSICION = @A0";

            SqlCommand cmd = new SqlCommand(stQuery, cnx);
            cmd.Parameters.AddWithValue("@A0", numPuesto);
            SqlDataReader rcd = cmd.ExecuteReader();

            if (rcd.Read())
            {
                lblPuesto.Text = Convert.ToString(rcd["NombreDePosicion"]);
            }
        }

        private void LimpiarFormulario()
        {
            txtUsuario.Clear();
            txtNombre.Clear();
            txtPassword.Clear();
            txtCorreo.Clear();
            txtPuesto.Clear();
            lblPuesto.Text = "";
        }
    }
}
