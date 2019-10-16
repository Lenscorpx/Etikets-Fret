using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Partie_metier;

namespace Etikets_Fret.EtiForms._UserControls
{

    public partial class uc_fret : UserControl
    {
        BindingSource bs = new BindingSource();
        Affectation aff = new Affectation();
        public uc_fret()
        {
            InitializeComponent();
            dataGridView1.DataSource = Chargement_donnees.charger_dg_fret(1).Tables[0];
            cbx_type_colis.DataSource = Chargement_donnees.charge_combobox(1).Items;
            txt_cmb_embarquement.DataSource = Chargement_donnees.charge_combobox(2).Items;
            // liberer_champs();
            Chargement_donnees.increment_id(txt_id_fret, 1);
            bs.DataSource = Chargement_donnees.charger_dg_fret(1).Tables[0];
            dataGridView1.DataSource = bs;
            bindingNavigator1.BindingSource = bs;
            champs_fret();
            calculer_total_prix();
        }
        private void uc_fret_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = Chargement_donnees.charger_dg_fret(5).Tables[0];
            aff.remplir_champs_paiement(dataGridView2, txt_id_paiement,txt_montant_paye, txt_type_paiement,cbx_devise_paie);
            Chargement_donnees.increment_id(txt_id_paiement, 3);
            cbx_devise_paie.Items.Add("USD");
            cbx_devise_paie.Items.Add("CDF");
            cbx_devise_paie.SelectedIndex = 0; 
        }
        public void champs_fret()
        {
            aff.remplir_champs_fret
               (
                   dataGridView1,
                   txt_id_fret,
                   txt_tickets,
                   dt_pick_date,
                   txt_colis,
                   txt_poids,
                   txt_unites,
                   txt_pu,
                   txt_montat,
                   txt_devise,
                   txt_nom_proprietaire,
                   txt_contact_proprietaire,
                   txt_nom_destinataire,
                   txt_contact_destinataire,
                   txt_adresse_destinataire,
                   cbx_type_colis
               );
        }
        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            aff.affectation_fret(
            txt_id_fret.Text.Trim(),
            dt_pick_date.Value,
            txt_nom_proprietaire.Text.Trim(),
            txt_contact_proprietaire.Text.Trim(),
            txt_nom_destinataire.Text.Trim(),
            txt_contact_destinataire.Text.Trim(),
            txt_adresse_destinataire.Text.Trim(),
            txt_colis.Text.Trim(),
            txt_poids.Text.Trim(),
            txt_tickets.Text.Trim(),
            txt_ref_colis.Text.Trim(),
            txt_ref_embarq.Text.Trim()
            );
            dataGridView1.DataSource = Chargement_donnees.charger_dg_fret(1).Tables[0];
            Chargement_donnees.increment_id(txt_id_fret, 1);

            // enregistrement paiement fret
            aff.affectation_paiement_fret(txt_id_paiement.Text, dt_pick_date.Value = DateTime.Today.Date, txt_type_paiement.Text.Trim(), txt_montant_paye.Text.Trim(), cbx_devise_paie.Text);
            dataGridView2.DataSource = Chargement_donnees.charger_dg_fret(5).Tables[0];
            txt_type_paiement.Text = "";
            txt_montant_paye.Text = "";
            Chargement_donnees.increment_id(txt_id_paiement, 3);
            //enregistrement attribution fret

            
        }

        private void cbx_type_colis_SelectedIndexChanged(object sender, EventArgs e)
        {
            Chargement_donnees.select_index(cbx_type_colis, txt_ref_colis, 2);
            Chargement_donnees.select_index(cbx_type_colis, txt_unites, 5);
            Chargement_donnees.select_index_alcul_prix_fret(cbx_type_colis, txt_pu, txt_devise);
            calculer_total_prix();
        }

        private void txt_cmb_embarquement_SelectedIndexChanged(object sender, EventArgs e)
        {
            Chargement_donnees.select_index(txt_cmb_embarquement, txt_ref_embarq, 3);
        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            champs_fret();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Chargement_donnees.increment_id(txt_id_fret, 1);
            liberer_champs();
            //pour paiement fret
            Chargement_donnees.increment_id(txt_id_paiement, 3);
            txt_type_paiement.Text = "";
            txt_montant_paye.Text = "";
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            aff.supprimer_fret(txt_id_fret.Text);
            dataGridView1.DataSource = Chargement_donnees.charger_dg_fret(1).Tables[0];
            //supprimer paiement fret
            aff.supprimer_paiement_fret(txt_id_paiement.Text.Trim());
            dataGridView2.DataSource = Chargement_donnees.charger_dg_fret(5).Tables[0];
        }
        private void txt_tickets_KeyUp(object sender, KeyEventArgs e)
        {
            aff.chercher_fret(dataGridView1, txt_tickets);
            bs.DataSource = Chargement_donnees.recherche_valeur(txt_tickets,2).Tables[0];
            dataGridView1.DataSource = bs;
            bindingNavigator1.BindingSource = bs;
            champs_fret();
        }

        private void txt_tickets_Leave(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Chargement_donnees.charger_dg_fret(1).Tables[0];
            Chargement_donnees.increment_id(txt_id_fret, 1);
            bs.DataSource = Chargement_donnees.charger_dg_fret(1).Tables[0];
            dataGridView1.DataSource = bs;
            bindingNavigator1.BindingSource = bs;
            champs_fret();
        }

        private void txt_poids_KeyUp(object sender, KeyEventArgs e)
        {
            //Chargement_donnees.select_index_alcul_prix_fret(cbx_type_colis, txt_pu, txt_devise);
        }

        private void liberer_champs()
            {
            Chargement_donnees.increment_id(txt_id_fret, 1);
            txt_adresse_destinataire.Text = "";
            txt_colis.Text = "";
            txt_contact_destinataire.Text = "";
            txt_contact_proprietaire.Text = "";
            txt_pu.Text = "";
            txt_montat.Text = "";
            txt_unites.Text = "";
            txt_devise.Text = "";
            txt_nom_destinataire.Text = "";
            txt_nom_proprietaire.Text = "";
            txt_poids.Text = "";
        }
        private void txt_poids_KeyUp_1(object sender, KeyEventArgs e)
        {
            calculer_total_prix();
        }
        private void calculer_total_prix()
        {
            if (!string.IsNullOrEmpty(txt_poids.Text))
            {
                try
                {
                    cacul_montant_paye m = new cacul_montant_paye();
                    m.Poids = Convert.ToDecimal(txt_poids.Text);
                    m.Pu = Convert.ToDecimal(txt_pu.Text);
                    m.calcul_Prix_paye();
                    txt_montat.Text = m.Pt.ToString();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "Une erreur s'est produite", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

            }
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            aff.remplir_champs_paiement(dataGridView2, txt_id_paiement, txt_montant_paye, txt_type_paiement, cbx_devise_paie);
        }
    }
}
