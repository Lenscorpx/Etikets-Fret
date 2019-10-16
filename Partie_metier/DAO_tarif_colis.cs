using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Partie_metier
{
   public class DAO_tarif_colis : Connexion
    {
        public static void Enregistrer_tarif(tarif_coli tarif)
        {
            try
            { 
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                    var cmd = conn.CreateCommand();
                    cmd.CommandText = "enregistrer_t_tarif_colis";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@id_tarif", tarif.Id_tarif.ToString()));
                    cmd.Parameters.Add(new SqlParameter("@prix",Convert.ToDecimal( tarif.Prix)));
                    cmd.Parameters.Add(new SqlParameter("@devise", tarif.Devise.ToString()));
                    cmd.ExecuteNonQuery();
                    conn.Close();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
        }

        public static void Supprimer_tarif(tarif_coli tarif)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                    var cmd = conn.CreateCommand();
                    cmd.CommandText = "supprimer_tarif_colis";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@id_tarif",tarif.Id_tarif.ToString()));
                    cmd.ExecuteNonQuery();
                    conn.Close();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
        }
    }
}
