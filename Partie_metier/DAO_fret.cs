using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MetroFramework.Controls;
using MaterialSkin.Controls;

namespace Partie_metier
{
    public class DAO_fret : Connexion
    {
        public static void enregistrer_fret(fret fr)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "enregistrer_t_fret";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@id_fret",Convert.ToInt32(fr.Id_fret)));
                cmd.Parameters.Add(new SqlParameter("@date_fret", fr.Date_fret.Date));
                cmd.Parameters.Add(new SqlParameter("@nom_proprietaire", fr.Nom_proprietaire));
                cmd.Parameters.Add(new SqlParameter("@contact_proprietaire", fr.Contact_proprietaire));
                cmd.Parameters.Add(new SqlParameter("@nom_destinataire", fr.Nom_destinataire));
                cmd.Parameters.Add(new SqlParameter("@contact_destinataire", fr.Contact_destinataire));
                cmd.Parameters.Add(new SqlParameter("@adresse_destinataire", fr.Adresse_destinataire));
                cmd.Parameters.Add(new SqlParameter("@colis", fr.Designation_colis));
                cmd.Parameters.Add(new SqlParameter("@poids", Convert.ToDecimal( fr.Poids)));
                cmd.Parameters.Add(new SqlParameter("@id_etikets_fret", fr.Ref_etikets));
                cmd.Parameters.Add(new SqlParameter("@code_type_colis", fr.Ref_type_colis));
                cmd.Parameters.Add(new SqlParameter("@code_embarquement", fr.Ref_embarquement));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void Supprimer_fret(fret fr)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "supprimer_t_fret";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@id_fret", fr.Id_fret.ToString()));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
