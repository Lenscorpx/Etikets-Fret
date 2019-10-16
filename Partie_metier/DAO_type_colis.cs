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
   public class DAO_type_colis : Connexion
    {
        public static void enregistrer_type_colis(type_colis colis)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "enregistre_t_type_colis";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@code_type_colis", colis.Code_type_colis));
                cmd.Parameters.Add(new SqlParameter("@description_type", colis.Description));
                cmd.Parameters.Add(new SqlParameter("@unite", colis.Unite));
                cmd.Parameters.Add(new SqlParameter("@id_tarif", colis.Id_tarif.ToString()));
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void suppromer_type_colis(type_colis colis)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "supprimer_t_type_colis";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@code_type_colis", colis.Code_type_colis));
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
