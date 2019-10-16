using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie_metier
{
    public class DAO_paiement_fret : Connexion
    {
        public static void enregistrer_paiement_fret(paiement_fret paie)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "enregistrer_t_paiement_fret";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@transaction_id", paie.Transaction_id));
                cmd.Parameters.Add(new SqlParameter("@date_paiement", paie.Date_paiement.Date));
                cmd.Parameters.Add(new SqlParameter("@type_paiement", paie.Type_paiement));
                cmd.Parameters.Add(new SqlParameter("@montant", Convert.ToDecimal(paie.Montant)));
                cmd.Parameters.Add(new SqlParameter("@devise", paie.Devise));
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void Supprimer_paiement_fret(paiement_fret fr)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "delete_t_paiement_fret";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@transaction_id", fr.Transaction_id.ToString()));
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
