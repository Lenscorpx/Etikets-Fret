using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin.Controls;
using Bunifu.Framework;
using Bunifu.Framework.UI;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace Partie_metier
{

    public class Affectation : Connexion
    {
        tarif_coli tar = new tarif_coli();
        type_colis tyc = new type_colis();
        fret fr = new fret();
        paiement_fret pf = new paiement_fret();
        attribution_paiement_fret at = new attribution_paiement_fret();
        recuperation_fret recup = new recuperation_fret();
        // fx pour affecter les valeurs de la classe modele tarif dans des text filds
        public void affectation_tarif
            (string txt_id , string txt_prix,string txt_devise)
        {
            connection_string();
            try
            {
                tar.Id_tarif = Convert.ToInt32(txt_id.ToString());
                tar.Prix = Convert.ToDecimal(txt_prix.ToString());
                tar.Devise = txt_devise;
                tar.Enregistrer_tarif_coli();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite", ex.Message);

            }
        }
        // fx pour affecter les valeurs de la classe modele type colis dans des text filds
        public void affectation_type_colis(string txt_Id, string txt_description,string txt_unite, string txt_ref_tarif)
        {
            connection_string();
            try
            {
                tyc.Code_type_colis = txt_Id.ToString();
                tyc.Description = txt_description;
                tyc.Unite = txt_unite;
                tyc.Id_tarif = Convert.ToInt32(txt_ref_tarif.ToString());
                tyc.Enregistrer_type_colis();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite", ex.Message);

            }
        }
        // suppression type colis
        public void supprimer_type_colis(string id)
        {
            connection_string();
            try
            {
                DialogResult dlg = MessageBox.Show("Etes-vous sûr de supprimer ?", "Suppression",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    tyc.Code_type_colis = id.ToString();
                    tyc.Supprimer_type_colis();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Une erreur s'est produite", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // charger combo box et data grid pour categorie
        public void chdg_categorie(DataGridView dgv)
        {
            dgv.DataSource = Chargement_donnees.charger_dg_fret(3).Tables[0];
        }
        //chercher occurance categorie
        public void chercher_categorie(DataGridView dgv, MaterialSingleLineTextField txt_Id)
        {
            dgv.DataSource = Chargement_donnees.recherche_valeur(txt_Id,1).Tables[0];
        }
        //chercher occurance fret
        public void chercher_fret(DataGridView dgv, MaterialSingleLineTextField txt_Id)
        {
            dgv.DataSource = Chargement_donnees.recherche_valeur(txt_Id, 2).Tables[0];
        }
        
        //chercher occurence paiement 
        public void chercher_paiement(DataGridView dgv, MaterialSingleLineTextField txt_Id)
        {
            dgv.DataSource = Chargement_donnees.recherche_valeur(txt_Id, 3).Tables[0];
        }
        //chercher occurence attribution paiement
        public void chercher_attribution_frer(DataGridView dgv, MaterialSingleLineTextField cbx)
        {
            dgv.DataSource = Chargement_donnees.recherche_valeur(cbx).Tables[0];
        }
        //chercher attribution paiement par id_fret
        public void chercher_attribution_fret_par_id_fret(DataGridView dgv, MaterialSingleLineTextField cbx)
        {
            dgv.DataSource = Chargement_donnees.recherche_valeur(cbx).Tables[0];
        }
        //chercher occurence recuperation_coli
        public void chercher_recuperation_colis(DataGridView dgv, MetroComboBox cbx)
        {
            dgv.DataSource = Chargement_donnees.recherche_recuperation_fret(cbx.Text).Tables[0];
        }
        //remplir champs du formulaire categorie colis
        public void remlir_champs_categorie_fret(DataGridView dgv, MaterialSingleLineTextField txt_Id, MaterialSingleLineTextField txt_descr, MaterialSingleLineTextField txt_unite, MetroComboBox txt_ref_tarif)
        {
            if (dgv.CurrentRow != null && dgv.CurrentRow.Index > -1)
            {
                txt_Id.Text= dgv.CurrentRow.Cells[0].Value.ToString();
                txt_descr.Text= dgv.CurrentRow.Cells[1].Value.ToString();
                txt_unite.Text = dgv.CurrentRow.Cells[2].Value.ToString();
                txt_ref_tarif.Text= dgv.CurrentRow.Cells[3].Value.ToString();
            }
            else
            {
            }

        }

        // fx pour affecter les valeurs de la classe modele fret dans des text filds
       

        public void remlir_champs_etikets_fret(DataGridView dgv, MaterialSingleLineTextField txt_Id, BunifuDatepicker txt_date, MaterialSingleLineTextField txt_server)
        {
            try
            {
                if (dgv.CurrentRow != null && dgv.CurrentRow.Index > -1)
                    txt_Id.Text = dgv.CurrentRow.Cells[0].Value.ToString();
                txt_date.Text = dgv.CurrentRow.Cells[1].Value.ToString();
                txt_server.Text = dgv.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite", ex.Message);
            }
        }
        public void affectation_fret

            (
           string txt_Id,
            DateTime txt_date,
            string txt_nomProp,
            string txt_contactPro,
            string txt_nomDest,
            string txt_contactDest,
            string txt_adressDest,
            string txt_colis,
            string txt_poids,
            string txt_ref_etikets,
            string txt_ref_type_colis,
            string txt_ref_embarq
            )
        {
            try
            {
                fr.Id_fret =Convert.ToInt32(txt_Id);
                fr.Date_fret =Convert.ToDateTime(txt_date);
                fr.Nom_proprietaire = txt_nomProp.ToString();
                fr.Contact_proprietaire = txt_contactPro.ToString();
                fr.Nom_destinataire = txt_nomDest.ToString();
                fr.Contact_destinataire = txt_contactDest.ToString();
                fr.Adresse_destinataire = txt_adressDest.ToString();
                fr.Designation_colis = txt_colis.ToString();
                fr.Poids = Convert.ToDecimal(txt_poids.ToString());
                fr.Ref_etikets = txt_ref_etikets.ToString();
                fr.Ref_type_colis = txt_ref_type_colis.ToString();
                fr.Ref_embarquement = txt_ref_embarq.ToString();
                fr.Enregistrer_fret();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite", ex.Message);
            }
        }

        public void supprimer_fret(string id)
        {
            connection_string();
           

                    fr.Id_fret = Convert.ToInt32(id.ToString());
                    fr.Supprimer_fret();
              
        }
        //Affectation recuperation_fret
        public void affectation_recuperation_fret
           (
           string txt_ref_fret,
           DateTime txt_date,
           string txt_nomRecuperateur,
           string txt_num_carte,
           string txt_telephone,
           string txt_observation
           )
        {
            try
            {
                recup.Id_fret = Convert.ToInt32(txt_ref_fret.ToString());
                recup.Date_recuperation = Convert.ToDateTime(txt_date);
                recup.Nom_recuperateur = txt_nomRecuperateur.ToString();
                recup.Nun_carte = txt_num_carte.ToString();
                recup.Telephoene = txt_telephone.ToString();
                recup.Observation = txt_observation.ToString();
                recup.Enregistrer_recuepration_fret();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Voulez-vous modifier cet enregistrement ? Car ces colis ou objets sont déjà retirés", ex.Message);
            }
        }

        public void supprimer_recuperation_fret(string id)
        {
            connection_string();
            try
            {
                DialogResult dlg = MessageBox.Show("Etes-vous sûr de supprimer ?", "Suppression",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    recup.Id_fret = Convert.ToInt32(id.ToString());
                    recup.Supprimer_recuperaion_fret();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Une erreur s'est produite", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // supprimer tarif
        public void supprimer_enregistrement(string id)
        {
            connection_string();
            try
            {
                DialogResult dlg = MessageBox.Show("Etes-vous sûr de supprimer ?", "Suppression",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    tar.Id_tarif = Convert.ToInt32(id.ToString());        
                    tar.Supprimer_tarif_colis();
                }
        }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Une erreur s'est produite", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
  
        public void chdg_tarif(DataGridView dgv)
        {
            dgv.DataSource =Chargement_donnees.charger_dg_fret(2).Tables[0];
        }
        public void remplir_champs_tarif(DataGridView dgv, MaterialSingleLineTextField txt_id, MaterialSingleLineTextField txt_prix, MetroComboBox txt_devise)
        {
            try
            { 
            if (dgv.CurrentRow != null && dgv.CurrentRow.Index > -1)
            {
                txt_id.Text = dgv.CurrentRow.Cells[0].Value.ToString();
                txt_prix.Text = dgv.CurrentRow.Cells[1].Value.ToString();
                txt_devise.Text = dgv.CurrentRow.Cells[2].Value.ToString();
            }
            else
            {

            }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Une erreur s'est produite", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // remplir champs fret
        public void remplir_champs_fret(
            DataGridView dgv,
            MaterialSingleLineTextField txt1,
            MaterialSingleLineTextField txt2,
            BunifuDatepicker txt3,
            MaterialSingleLineTextField txt4,
            MaterialSingleLineTextField txt5,
            MaterialSingleLineTextField txt6,
            MaterialSingleLineTextField txt7,
            MaterialSingleLineTextField txt8,
            MaterialSingleLineTextField txt9,
            MaterialSingleLineTextField txt10,
            MaterialSingleLineTextField txt11,
            MaterialSingleLineTextField txt12,
            MaterialSingleLineTextField txt13,
            MaterialSingleLineTextField txt14,
            MetroComboBox txt15,
            MetroComboBox txt16
            )
        {
            try
            {
                if (dgv.CurrentRow != null && dgv.CurrentRow.Index > -1)
                {
                    txt1.Text = dgv.CurrentRow.Cells[0].Value.ToString();
                    txt2.Text = dgv.CurrentRow.Cells[1].Value.ToString();
                    txt3.Text = dgv.CurrentRow.Cells[2].Value.ToString();
                    txt4.Text = dgv.CurrentRow.Cells[3].Value.ToString();
                    txt5.Text = dgv.CurrentRow.Cells[4].Value.ToString();
                    txt6.Text = dgv.CurrentRow.Cells[5].Value.ToString();
                    txt7.Text = dgv.CurrentRow.Cells[6].Value.ToString();
                    txt8.Text = dgv.CurrentRow.Cells[7].Value.ToString();
                    txt9.Text = dgv.CurrentRow.Cells[8].Value.ToString();
                    txt10.Text = dgv.CurrentRow.Cells[9].Value.ToString();
                    txt11.Text = dgv.CurrentRow.Cells[10].Value.ToString();
                    txt12.Text = dgv.CurrentRow.Cells[11].Value.ToString();
                    txt13.Text = dgv.CurrentRow.Cells[12].Value.ToString();
                    txt14.Text = dgv.CurrentRow.Cells[13].Value.ToString();
                    txt15.Text = dgv.CurrentRow.Cells[14].Value.ToString();
                    txt16.Text = dgv.CurrentRow.Cells[15].Value.ToString();
                }
                else
                {

                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Une erreur s'est produite", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //remplir champs recuperation fret
        public void remplir_champs_recuperation_fret(
           DataGridView dgv,
           MaterialSingleLineTextField txt1,
           MaterialSingleLineTextField txt2,
           BunifuDatepicker txt3,
           MaterialSingleLineTextField txt4,
           MaterialSingleLineTextField txt5,
           MaterialSingleLineTextField txt6,
           RichTextBox txt7
           
           )
        {
            try
            {
            if (dgv.CurrentRow != null && dgv.CurrentRow.Index > -1)
            {
                txt1.Text = dgv.CurrentRow.Cells[0].Value.ToString();
                txt2.Text = dgv.CurrentRow.Cells[1].Value.ToString();
                txt3.Text = dgv.CurrentRow.Cells[2].Value.ToString();
                txt4.Text = dgv.CurrentRow.Cells[3].Value.ToString();
                txt5.Text = dgv.CurrentRow.Cells[4].Value.ToString();
                txt6.Text = dgv.CurrentRow.Cells[5].Value.ToString();
                txt7.Text = dgv.CurrentRow.Cells[6].Value.ToString();
                //txt8.Text = dgv.CurrentRow.Cells[7].Value.ToString();
           
            }
            else
            {

            }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Une erreur s'est produite", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void affectation_paiement_fret
           (string txt_id, DateTime txt_date_paie, string txt_type_paie, string montant,string devise)
        {
            connection_string();
            try
            {
                pf.Transaction_id = txt_id;
                pf.Date_paiement = Convert.ToDateTime(txt_date_paie);
                pf.Type_paiement = txt_type_paie;
                pf.Montant = Convert.ToDecimal(montant);
                pf.Devise = devise;
                pf.Enregistrer_paiement_fret();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite", ex.Message);

            }
        }

        public void affectation_attribution_fret
          (string fret,string txt_transaction)
        {
            connection_string();
            try
            {
                //at.Num_attribution = Convert.ToInt32(txt_id);
                at.Id_fret =Convert.ToInt32(fret);
                at.Transaction_id_fret = txt_transaction;
                at.Enregistrer_attribution_fret();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite", ex.Message);

            }
        }
     public void supprimer_attribution_fret(string id)
        {
            connection_string();
                    at.Id_fret = Convert.ToInt32(id);
                    at.Supprimer_attribution_fret();
          }

        //Remplir champs paiement fret
        public void remplir_champs_paiement_fret(
            DataGridView dgv,
            MaterialSingleLineTextField txt1,
            BunifuDatepicker txt2,
            MaterialSingleLineTextField txt3,
            MaterialSingleLineTextField txt4,
            MetroComboBox txt5
            )
        {
            try { 
            if (dgv.CurrentRow != null && dgv.CurrentRow.Index > -1)
            {
                txt1.Text = dgv.CurrentRow.Cells[0].Value.ToString();
                txt2.Text = dgv.CurrentRow.Cells[1].Value.ToString();
                txt3.Text = dgv.CurrentRow.Cells[2].Value.ToString();
                txt4.Text = dgv.CurrentRow.Cells[3].Value.ToString();
                txt5.Text = dgv.CurrentRow.Cells[4].Value.ToString();
            }
            else
            {

            }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Une erreur s'est produite", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //remplir champ attr paiement
        public void remplir_champs_paiement(
       DataGridView dgv,
       MaterialSingleLineTextField txt1,
       MaterialSingleLineTextField txt2,
       MaterialSingleLineTextField txt3,
       MetroComboBox txt4
       )
        {
            try
            {
                if (dgv.CurrentRow != null && dgv.CurrentRow.Index > -1)
                {
                    txt1.Text = dgv.CurrentRow.Cells[1].Value.ToString();
                    txt2.Text = dgv.CurrentRow.Cells[3].Value.ToString();
                    txt3.Text = dgv.CurrentRow.Cells[5].Value.ToString();
                    txt4.Text = dgv.CurrentRow.Cells[4].Value.ToString();
                }
                else
                {

                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Une erreur s'est produite", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void remplir_champs_attribution_fret(
          DataGridView dgv,
          MaterialSingleLineTextField txt1,
          MetroComboBox txt2,
          MetroComboBox txt3,
         MaterialSingleLineTextField txt4
          )
        {
            try { 
            if (dgv.CurrentRow != null && dgv.CurrentRow.Index > -1)
            {
                txt1.Text = dgv.CurrentRow.Cells[0].Value.ToString();
                txt2.Text = dgv.CurrentRow.Cells[2].Value.ToString();
                txt3.Text = dgv.CurrentRow.Cells[6].Value.ToString();
                txt4.Text = dgv.CurrentRow.Cells[1].Value.ToString();
            }
            else
            {

            }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Une erreur s'est produite", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void supprimer_paiement_fret(string id)
        {
            connection_string();
                
                    pf.Transaction_id = id;
                    pf.Supprimer_fret();   
        }
        public void affectation_attribution_paiement
          (string txt_id, string txt_id_fret, string id_transaction)
        {
            connection_string();
            try
            {
                at.Num_attribution = Convert.ToInt32(txt_id);
                at.Id_fret = Convert.ToInt32(txt_id_fret);
                at.Transaction_id_fret = id_transaction;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite", ex.Message);

            }
        }
    }
}
