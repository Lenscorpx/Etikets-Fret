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
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting.Preview;
using Bunifu.Framework.UI;


namespace Partie_metier
{
    public class Chargement_donnees : Connexion
    {
        //chargement des datagrid view -----------------------------------------------------------------
        public static DataSet charger_dg_fret(int x)
        {
            connection_string();
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                var cmd = conn.CreateCommand();
                if (x == 1)
                {
                    cmd.CommandText = "charger_dg_fret";
                }
                else if (x == 2)
                {
                    cmd.CommandText = "charger_dg_tarif_fret";
                }
                else if (x == 3)
                {
                    cmd.CommandText = "charger_dg_type_colis";
                }
    
                else if (x == 5)
                {
                    cmd.CommandText = "charger_dg_attribution_paiement";
                }
                else if (x == 6)
                {
                    cmd.CommandText = "charger_dg_recuperation_fret";
                }
                cmd.CommandType = CommandType.StoredProcedure;
                IDbDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                var ds = new DataSet();
                da.Fill(ds);
                ds.Tables[0].TableName = "chdg";
                conn.Close();
                return ds;
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
        }

        //chargement des combo box --------------------------------------------------------------
        public static ComboBox charge_combobox(int x)
        {
            connection_string();
            try
            {
                ComboBox cmb = new ComboBox();
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                if (x == 1)
                {
                    cmd.CommandText = "charger_combo_type_colis";
                    var dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        cmb.Items.Add(dr["description_type"].ToString());
                    }
                    dr.Close();
                }

                else if (x == 2)
                {
                    cmd.CommandText = "charger_combo_embarquement";
                    var dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        cmb.Items.Add(dr["actual_bateau"].ToString());
                    }
                    dr.Close();
                }

                else if (x == 3)
                {
                    cmd.CommandText = "charger_combo_tarif";
                    var dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        cmb.Items.Add(dr["prix_coli"].ToString());
                    }
                    dr.Close();
                }
                else if (x == 4)
                {
                    {
                        cmd.CommandText = "charger_combo_bateau";
                        var dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            cmb.Items.Add(dr["nom_bateau"].ToString());
                        }
                        dr.Close();
                    }
                }
                else if (x == 6)
                {
                    {
                        cmd.CommandText = "charger_combo_trajet";
                        var dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            cmb.Items.Add(dr["description_trajet"].ToString());
                        }
                        dr.Close();
                    }
                }

                else if (x == 7)
                {
                    {
                        cmd.CommandText = "charger_combo_section";
                        var dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            cmb.Items.Add(dr["description_section"].ToString());
                        }
                        dr.Close();
                    }
                }
                cmd.Dispose();
                conn.Close();
                return cmb;
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
        }

        //chargement des index_values----------------------------------------------------------------------------
        public static void select_index(MetroComboBox cmb1, MaterialSingleLineTextField cmb,int x)
        {
            connection_string();
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                if (x == 1)
                    {
                        cmd.CommandText = "charger_select_index_tarif";
                        cmd.Parameters.Add(new SqlParameter("@prix_coli", cmb1.Text));
                    var dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            cmb.Text = dr["id_tarif"].ToString();
                        }
                        dr.Close();
                    }
                else if(x==2)
                    {
                        cmd.CommandText = "select_index_type_coli";
                        cmd.Parameters.Add(new SqlParameter("@description_type", cmb1.Text));
                        var dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                        cmb.Text = dr["code_type_colis"].ToString();
                        }
                        dr.Close();
                    }
                else if(x==3)
                    {
                        cmd.CommandText = "charger_select_index_embarquement";
                        cmd.Parameters.Add(new SqlParameter("@actual_bateau", cmb1.Text));
                        var dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            cmb.Text = dr["x_code_embarquement"].ToString();
                        }
                        dr.Close();
                     }
                else if (x == 5)
                {
                    cmd.CommandText = "select_index_type_coli";
                    cmd.Parameters.Add(new SqlParameter("@description_type", cmb1.Text));
                    var dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        cmb.Text = dr["unite"].ToString();
                    }
                    dr.Close();
                }
                else if (x == 6)
                {
                    cmd.CommandText = "calcule_montant_fret";
                    cmd.Parameters.Add(new SqlParameter("@description_type", cmb1.Text));
                    var dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        cmb.Text = dr["devise"].ToString();
                    }
                    dr.Close();
                }
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
        }

        public static void select_index_alcul_prix_fret(MetroComboBox cmb1, MaterialSingleLineTextField prix_unitaire, MaterialSingleLineTextField cmb)
        {
            connection_string();
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "calcule_montant_fret";
                    cmd.Parameters.Add(new SqlParameter("@description_type", cmb1.Text));
                    var dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                       // montant.Text=dr["Montant_a_payer"].ToString();
                        cmb.Text = dr["devise"].ToString();
                        prix_unitaire.Text = dr["prix"].ToString();
                    }
                    dr.Close();
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
        }

        //chargement des identifiants
        public static void increment_id(MaterialSingleLineTextField txt_id_fret, int x)
        {
            connection_string();
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;

                if (x == 1)
                {
                    cmd.CommandText = "increment_id_fret";
                }

                if (x == 2)
                {
                    cmd.CommandText = "increment_id_attribution_fret";
                }
                if (x == 3)
                {
                    cmd.CommandText = "increement_id_paiement_fret";
                }
                object obj = cmd.ExecuteScalar();
                txt_id_fret.Text = obj.ToString();
                cmd.Dispose();
                conn.Close();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
        }

        //recherche des occurences

        public static DataSet recherche_valeur(MaterialSingleLineTextField cmb1, int x)
        {
            connection_string();
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                if (x == 1)
                {
                    cmd.CommandText = "chercher_type_colis";
                    cmd.Parameters.Add(new SqlParameter("@code_type_colis", cmb1.Text.Trim()));
                }
                else if (x == 2)
                {
                    cmd.CommandText = "chercher_fret";
                    cmd.Parameters.Add(new SqlParameter("@id_fret", cmb1.Text.Trim()));
                }
                else if (x == 3)
                {
                    cmd.CommandText = "chercher_paiement";
                    cmd.Parameters.Add(new SqlParameter("@transaction_id_fret", cmb1.Text.Trim()));
                }
                else if (x == 4)
                {
                    cmd.CommandText = "remplir_liste";
                    cmd.Parameters.Add(new SqlParameter("@id_etikets_fret", cmb1.Text.Trim()));
                }
                IDbDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                var ds = new DataSet();
                da.Fill(ds);
                ds.Tables[0].TableName = "chdg";
                conn.Close();
                return ds;
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
        }
        //chercher occurence recuperation_fret
        public static DataSet recherche_recuperation_fret(string cmb1 )
        {
            connection_string();
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "chercher_recuperation_fret";
                cmd.Parameters.Add(new SqlParameter("@id_fret",Convert.ToInt32(cmb1)));
                IDbDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                var ds = new DataSet();
                da.Fill(ds);
                ds.Tables[0].TableName = "chdg";
                conn.Close();
                return ds;
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
        }
        //rechercher occurence attribution paiement=====================================================================
        public static DataSet recherche_valeur(MaterialSingleLineTextField cmb1)
        {
            connection_string();
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "chercher_attribution_paie";
                    cmd.Parameters.Add(new SqlParameter("@id_fret", cmb1.Text.Trim()));
                IDbDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                var ds = new DataSet();
                da.Fill(ds);
                ds.Tables[0].TableName = "chdg";
                conn.Close();
                return ds;
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
        }
        //Etats de sorties ===============================================================================================
        public static void print_ticket_fret(XtraReport xt, string codeTransaction,DocumentViewer documentViewer1)
        {
            connection_string1();
            try
            {
            if (con.State == ConnectionState.Closed)
            con.Open();
            var cmd = con.CreateCommand();
            cmd.CommandText = "print_ticket_fret";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id_etikets_fret", codeTransaction));
            cmd.ExecuteNonQuery();
            var da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            var dtset = new DataSet();
            da.Fill(dtset, "print_ticket_fret");
            xt.DataSource = dtset;
                documentViewer1.DocumentSource = xt;
               xt.CreateDocument();
            }
            catch (Exception etr)
            {
                MessageBox.Show("Erreur lors du chargement!", "Echec", MessageBoxButtons.OK, MessageBoxIcon.Error);
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous consulter le message d'erreur?", "Message d'erreur", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(etr.ToString());
                }
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }
       
        //print manifeste
        public static void print_mninifeste(
            XtraReport xt,
            print_manifeste prtm,
            DocumentViewer documentViewer1,int x)
        {
            connection_string1();
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                var cmd = con.CreateCommand();
                if (x == 1)
                {
                    cmd.CommandText = "print_manifeste";
                }
                else if (x == 2)
                {
                    cmd.CommandText = "print_releve_paiement_fret";
                }
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@nom_bateau", prtm.Nom_bateau));
                cmd.Parameters.Add(new SqlParameter("@description_trajet", prtm.Trajet));
                cmd.Parameters.Add(new SqlParameter("@description_section", prtm.Section));
                cmd.Parameters.Add(new SqlParameter("@date_embarquement",Convert.ToDateTime(prtm.Date_emb)));
                var da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                var dtset = new DataSet();
                da.Fill(dtset);
                dtset.Tables[0].TableName = "Print";
                xt.DataSource=dtset ;
                documentViewer1.DocumentSource = xt;
               xt.CreateDocument();
            }
            catch (Exception etr)
            {
                MessageBox.Show("Erreur lors du chargement!", "Echec", MessageBoxButtons.OK, MessageBoxIcon.Error);
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous consulter le message d'erreur?", "Message d'erreur", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(etr.ToString());
                }
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }
        
    }
}
