using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Partie_metier
{
    public class DAOLogin : Connexion
    {
        public static void login(LoginClass lc, BunifuCustomLabel lab,MetroForm fr, MetroForm frlog)
        {
            SqlDataReader rdr = null;
            try
            {
                connection_string1();
                if (con.State != ConnectionState.Open)
                    con.Open();
                var cmd = con.CreateCommand();
                cmd.CommandText = "verifierLogin";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parUserName = new SqlParameter("@nom_user", SqlDbType.NVarChar);
                SqlParameter parUserPassword = new SqlParameter("@pwd_user", SqlDbType.NVarChar);
                cmd.Parameters.Add(parUserName);
                cmd.Parameters.Add(parUserPassword);
                parUserName.Value = lc.User_name.ToString();
                parUserPassword.Value = lc.Pass_word.ToString();
                var da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                var dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                    lab.Text = dt.Rows[0][0].ToString();
                    rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    lab.Text = rdr["id_level"].ToString();
                }
                if (string.IsNullOrEmpty(lab.Text))
                {
                    MessageBox.Show("Vous n'avez pas un compte, veuillez reasssayer", "Erreur", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);
                    frlog.Show();
                }
                else
                {
                    fr.Show();
                    frlog.Hide();
                }
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
    }

}
    }
}
