using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie_metier
{
    class DAO_recuperation_fret :Connexion
    {
        public static void enregistrer_recuperation_fret(recuperation_fret rpr)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "enregistrer_t_recuperation_fert";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@date_recuperation", rpr.Date_recuperation.Date));
                cmd.Parameters.Add(new SqlParameter("@nom_recuperateur", rpr.Nom_recuperateur));
                cmd.Parameters.Add(new SqlParameter("@num_carte", rpr.Nun_carte));
                cmd.Parameters.Add(new SqlParameter("@telephone", rpr.Telephoene));
                cmd.Parameters.Add(new SqlParameter("@observation", rpr.Observation));
                cmd.Parameters.Add(new SqlParameter("@id_fret", rpr.Id_fret.ToString()));
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void Supprimer_recuperation_fret(recuperation_fret rpr)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "supprimer_t_recuperation_fret";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@id_fret", rpr.Id_fret));
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
