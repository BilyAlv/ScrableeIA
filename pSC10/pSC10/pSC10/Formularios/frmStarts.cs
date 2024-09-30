using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;  // nos permite acceder a la base de datos

namespace pSC10
{
    public partial class frmStarts : Form
    {
        string password;

        public frmStarts()
        {
            InitializeComponent();  // es en donde esta el diseno del formulario
        }

        private void frmStarts_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;  // esta instruccion sirve para activar las teclas de funciones
            this.Text = "Entrada a la aplicacion"; // aqui le cambia el texto al formulario
        }

        private void frmStarts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)  // aqui esta preguntando si presionaste la tecla de escape
            {
                Application.Exit(); // Aqui la aplicacion cierra totalmente, completa
            }
        }

        // ----------------------------------------
        // BOTONES
        // ----------------------------------------
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() != string.Empty)  // AQUI ESTOY preguntando que si el textbox es diferente de vacio
            {
                if (txtPassword.Text.Trim() != string.Empty)  // AQUI ESTOY preguntando que si el textbox es diferente de vacio
                {
                    if (txtPassword.Text.Trim() == password)
                    {
                        frmMenu frm = new frmMenu();  // le asigna al objeto frm el formulario llamado frmMenu
                        frm.Show();   // carga o muestra el formulario del menu

                        this.Hide(); //aqui esconde el formulario frmStarts
                    }
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Aqui la aplicacion cierra totalmente, completa
        }

        // ----------------------------------------
        // TEXTBOX
        // ----------------------------------------
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)  // aqui pregunta si la tecla que presionaste es igual ENTER
            {
                e.Handled = true;
                // .Trim() elimina los espacios de los lados del textbox
                // .Text contiene lo escrito en el textbox
                if (txtUsuario.Text.Trim() != string.Empty)  // AQUI ESTOY preguntando que si el textbox es diferente de vacio
                {
                    txtPassword.Focus(); // movera el cursor hacia el siguiente textbox
                }
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() != string.Empty)  // AQUI ESTOY preguntando que si el textbox es diferente de vacio
            {
                BuscarUsuario(txtUsuario.Text);  // ejecuta el metodo y le envia la data del textbox al metodo
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)  // aqui pregunta si la tecla que presionaste es igual ENTER
            {
                e.Handled = true;
                // .Trim() elimina los espacios de los lados del textbox
                // .Text contiene lo escrito en el textbox
                if (txtPassword.Text.Trim() != string.Empty)  // AQUI ESTOY preguntando que si el textbox es diferente de vacio
                {
                    btnAceptar.Focus(); // movera el cursor hacia el boton aceptar
                }
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() != string.Empty)  // AQUI ESTOY preguntando que si el textbox es diferente de vacio
            {
                if (txtPassword.Text.Trim() != string.Empty)  // AQUI ESTOY preguntando que si el textbox es diferente de vacio
                {
                    if (txtPassword.Text.Trim() == password)
                    {
                        btnAceptar.PerformClick();
                    }
                }
            }
        }

        // -----------------------------------------
        // METODOS
        // -----------------------------------------

        private void BuscarUsuario(string sTusuario)
        {
            string stQuery = "SELECT NOMBRECORTO, CLAVE " +
                             "  FROM USUARIO " +
                             " WHERE NOMBRECORTO = @A0";

            SqlConnection cndb = new SqlConnection(cnn.db);  // aqui le indicamos la conexion al servidor 
            cndb.Open();  // aqui abrimos la bse de datos

            SqlCommand cmd = new SqlCommand(stQuery, cndb);
            cmd.Parameters.AddWithValue("@A0", sTusuario);
            SqlDataReader rcd = cmd.ExecuteReader();

            if (rcd.Read())  // aqui pregunta si tiene informacion el contenedor
            {
                password = Convert.ToString(rcd["CLAVE"]);
            }

            cmd.Dispose();  // descomponemos el script de sql
            cndb.Close();   // aqui cierra la base de datos
        }
    }
}
