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
    public partial class frmDEPTO : Form
    {
        Boolean existeDepto;

        public frmDEPTO()
        {
            InitializeComponent();
        }

        private void frmDEPTO_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;   // activa las teclas de funciones
            this.Text = "Departamentos";

            existeDepto = false;
        }

        private void frmDEPTO_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)  // pregunta si presionaste la tecla de ESC
            {
                this.Close();  // cierra el formulario
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtDEPTO.Text.Trim() != string.Empty)  // AQUI ESTOY preguntando que si el textbox es diferente de vacio
            {
                if (txtNombre.Text.Trim() != string.Empty)  // AQUI ESTOY preguntando que si el textbox es diferente de vacio
                {
                    if (txtFabrica.Text.Trim() != string.Empty)  // AQUI ESTOY preguntando que si el textbox es diferente de vacio
                    {
                        InsertaData();

                        LimpiarForm();
                        txtDEPTO.Focus();
                    }
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
            txtDEPTO.Focus();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (existeDepto == true)
            {
                BorrarData(txtDEPTO.Text);
                LimpiarForm();
                txtDEPTO.Focus();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); // cierra
        }

        private void btnDEPTO_Click(object sender, EventArgs e)
        {
            frmVENDEPTO frm = new frmVENDEPTO();  // creamos un objeto llamado frm y le asignamos un forms
            DialogResult res = frm.ShowDialog();

            if (frm.existeVar == true)
            {
                txtDEPTO.Text = frm.var1;
                txtNombre.Text = frm.var2;
            }
        }

        // -------------------------------------------------------
        // METODOS
        // -------------------------------------------------------
        private void LimpiarForm()
        {
            txtDEPTO.Clear();
            txtFabrica.Clear();
            txtNombre.Clear();
            lblFabrica.Text = "";

            existeDepto = false;
        }

        private void InsertaData()
        {
            // ----------------------------------------------------------------------
            // BORRA SI EL REGISTRO EXISTE
            // ----------------------------------------------------------------------
            SqlConnection cxn = new SqlConnection(cnn.db);
            cxn.Open();

            string tsQuery = "DELETE FROM DEPARTAMENTO WHERE IDDEPARTAMENTO ='" + txtDEPTO.Text + "'";
            SqlCommand cdm = new SqlCommand(tsQuery, cxn);
            cdm.ExecuteNonQuery();
            cxn.Close();

            // ----------------------------------------------------------------------
            // INSERTA LA DATA A LA TABLA
            // ----------------------------------------------------------------------
            SqlConnection cnx = new SqlConnection(cnn.db);  // le indica la conexion a la base de datos por medio la clase cnn
            cnx.Open();  // abrimos la base de datos

            string stQuery = "INSERT INTO DEPARTAMENTO (IDDEPARTAMENTO, NOMBREDEPARTAMENTO, IDFABRICA, ESTATUS" +
                             "     VALUES (@A0, @A1, @A2, 1)";

            SqlCommand cmd = new SqlCommand(stQuery, cnx);
            cmd.Parameters.AddWithValue("@A0", txtDEPTO.Text); // declaramos la variable y le asignamos valor por medio del textbox
            cmd.Parameters.AddWithValue("@A1", txtNombre.Text);
            cmd.Parameters.AddWithValue("@A2", txtFabrica.Text);

            cmd.ExecuteNonQuery();  // este comando ejecutara el script, debe tomar en cuenta que se utiliza ExecuteNomQuery solo
                                    // para realizar insert, delete y update

            cnx.Close();  // cerramos la base de datos
        }

        private void BorrarData(string numDepto)
        {
            SqlConnection cnx = new SqlConnection(cnn.db);  
            cnx.Open();

            string tsQuery = "UPDATE DEPARTAMENTO SET ESTATUS = 3 FROM DEPARTAMENTO";
            SqlCommand cmd = new SqlCommand(tsQuery, cnx);
            cmd.ExecuteNonQuery();
        }

        private void BuscarData(string nDepto)
        {
            existeDepto = false;

            SqlConnection cnx = new SqlConnection(cnn.db);  // le indica la conexion a la base de datos por medio la clase cnn
            cnx.Open();

            string stQuery = "     SELECT A.IDDEPARTAMENTO, A.NOMBREDEPARTAMENTO, A.IDFABRICA, B.NombreDeFabrica, A.ESTATUS " +
                             "       FROM DEPARTAMENTO A " +
                             " INNER JOIN FABRICA B ON A.IDFABRICA = B.IDFABRICA " +
                             "      WHERE A.ESTATUS = 1 " +
                             "        AND A.IDDEPARTAMENTO ='" + nDepto + "'";
            SqlCommand cmd = new SqlCommand(stQuery, cnx);
            SqlDataReader rcd =  cmd.ExecuteReader();

            if (rcd.Read())
            {
                existeDepto = true;

                txtNombre.Text = Convert.ToString(rcd["NOMBREDEPARTAMENTO"]);
                txtFabrica.Text = Convert.ToString(rcd["IDFABRICA"]);
                lblFabrica.Text = Convert.ToString(rcd["NombreDeFabrica"]);
            }
        }

        // -------------------------------------------------------
        // TEXTBOX
        // -------------------------------------------------------
        private void txtDEPTO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)  // aqui pregunta si la tecla que presionaste es igual ENTER
            {
                e.Handled = true;
                // .Trim() elimina los espacios de los lados del textbox
                // .Text contiene lo escrito en el textbox
                if (txtDEPTO.Text.Trim() != string.Empty)  // AQUI ESTOY preguntando que si el textbox es diferente de vacio
                {
                    txtNombre.Focus(); // movera el cursor hacia el siguiente textbox
                }
            }
        }

        private void txtDEPTO_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)   // esta preguntado que si presinaste la tecla F4
            {
                btnDEPTO.PerformClick();
            }
        }

        private void txtDEPTO_Leave(object sender, EventArgs e)
        {
            if (txtDEPTO.Text.Trim() != string.Empty)  // AQUI ESTOY preguntando que si el textbox es diferente de vacio
            {
                BuscarData(txtDEPTO.Text);  // ejecuta el metodo y le envia la data del textbox al metodo
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)  // aqui pregunta si la tecla que presionaste es igual ENTER
            {
                e.Handled = true;
                if (txtNombre.Text.Trim() != string.Empty)  // AQUI ESTOY preguntando que si el textbox es diferente de vacio
                {
                    txtFabrica.Focus(); // movera el cursor hacia el siguiente textbox
                }
            }
        }

        private void txtFabrica_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)  // aqui pregunta si la tecla que presionaste es igual ENTER
            {
                e.Handled = true;
                if (txtFabrica.Text.Trim() != string.Empty)  // AQUI ESTOY preguntando que si el textbox es diferente de vacio
                {
                    btnGuardar.Focus(); // movera el cursor hacia el siguiente textbox
                }
            }
        }

        private void txtFabrica_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)   // esta preguntado que si presinaste la tecla F4
            {
                btnFabrica.PerformClick();
            }
        }

        private void txtFabrica_Leave(object sender, EventArgs e)
        {
            if (txtFabrica.Text.Trim() != string.Empty)  // AQUI ESTOY preguntando que si el textbox es diferente de vacio
            {
                lblFabrica.Text = Busco.Fabrica(txtFabrica.Text);  // ejecuta el metodo y le envia la data del textbox al metodo
            }
        }

        private void btnFabrica_Click(object sender, EventArgs e)
        {
            frmVENFABRICA frm = new frmVENFABRICA();  // creamos un objeto llamado frm y le asignamos un forms
            DialogResult res = frm.ShowDialog();

            if (frm.existeVar == true)
            {
                txtFabrica.Text = frm.var1;
                lblFabrica.Text = frm.var2;

                frm.existeVar = false;
            }
        }           
    }
}