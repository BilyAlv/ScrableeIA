using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace pSC10
{
    public class cnn
    {
        public static string db = @"server=DESKTOP-TFVTCNK\SQLEXPRESS; database=DBpractica04; integrated security =true";
        public static string BD = @"server=DESKTOP-TFVTCNK\SQLEXPRESS; database=NWIND; integrated security =true";
    }

    public class Busco
    {
        public static string BuscaUltimoNumero(string nmID)
        {
            SqlConnection cnxn = new SqlConnection(cnn.db); cnxn.Open();
            SqlCommand cmmnd = new SqlCommand("SELECT SECUENCIA + 1 AS ULTIMO FROM SECUENCIA WHERE ID ='" + nmID + "'", cnxn);
            SqlDataReader rdr = cmmnd.ExecuteReader();

            if (rdr.Read())
            {
                return Convert.ToString(rdr["ULTIMO"]);
            }

            cmmnd.Dispose();
            cnxn.Close();
            return null;
        }

        public static string BuscaSiPagaImpruesto(string nmID)
        {
            SqlConnection cnxn = new SqlConnection(cnn.db); cnxn.Open();
            SqlCommand cmmnd = new SqlCommand("SELECT PAGAIMPUESTO FROM CLIENTES WHERE IDCLIENTE = " + nmID, cnxn);
            SqlDataReader rdr = cmmnd.ExecuteReader();

            if (rdr.Read())
            {
                return Convert.ToString(rdr["PAGAIMPUESTO"]);
            }

            cmmnd.Dispose();
            cnxn.Close();
            return null;
        }

        public static string Fabrica(string nFabrica)
        {
            SqlConnection cnx = new SqlConnection(cnn.db);  // le indica la conexion a la base de datos por medio la clase cnn
            cnx.Open();

            string stQuery = "SELECT NombreDeFabrica " +
                             "  FROM Fabrica " +
                             " WHERE idFabrica ='" + nFabrica + "'";
            SqlCommand cmd = new SqlCommand(stQuery, cnx);
            SqlDataReader rcd = cmd.ExecuteReader();

            if (rcd.Read())
            {
                return Convert.ToString(rcd["NombreDeFabrica"]);
            }

            cmd.Dispose();
            cnx.Close();
            return null;
        }
    }
}
