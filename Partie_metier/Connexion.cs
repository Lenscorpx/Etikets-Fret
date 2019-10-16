using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie_metier
{
   public  class Connexion
    {
        public static IDbConnection conn;
        public static SqlConnection con;
        public static void initialisation(string NomServeur, string NomBd, string NomUser, string pw)
        {
            string connectionStr = string.Format(
                "Data Source={0}; Initial Catalog={1}; User ID={2}; Password={3}",
                NomServeur,
                NomBd,
                NomUser,
                pw);
            conn = new SqlConnection(connectionStr);

        }

        public static void initialisation1(string NomServeur, string NomBd, string NomUser, string pw)
        {
            string connectionStr = string.Format(
                "Data Source={0}; Initial Catalog={1}; User ID={2}; Password={3}",
                NomServeur,
                NomBd,
                NomUser,
                pw);
            con = new SqlConnection(connectionStr);

        }

        public static void connection_string()
        {
            initialisation(@"JMV\JMV", "db_etikets", "sa", "jmv");
        }
        public static void connection_string1()
        {
            initialisation1(@"JMV\JMV", "db_etikets", "sa", "jmv");
        }
    }
}
