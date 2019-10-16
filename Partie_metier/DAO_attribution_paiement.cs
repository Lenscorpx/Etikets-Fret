using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie_metier
{
   public class DAO_attribution_paiement :Connexion
    {
        public static void enregistrer_attribution_fret(attribution_paiement_fret attr)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "enregistrer_t_attribution_paiement_fret";
                cmd.CommandType = CommandType.StoredProcedure;
               // cmd.Parameters.Add(new SqlParameter("@num_attrib_fret", attr.Num_attribution.ToString()));
                cmd.Parameters.Add(new SqlParameter("@id_fret", attr.Id_fret.ToString()));
                cmd.Parameters.Add(new SqlParameter("@transaction_id_fret", attr.Transaction_id_fret));
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void supprimer_attribution_fret(attribution_paiement_fret attr)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "delete_attribution_paiement_fret";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@id_fret", attr.Id_fret.ToString()));
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
