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
    public partial class uc_paiement : UserControl
    {
        BindingSource bs = new BindingSource();
        public uc_paiement()
        {
            InitializeComponent();
        }

        Affectation af = new Affectation();
        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            af.affectation_paiement_fret(txt_id_paiement.Text, dt_pick_date.Value =DateTime.Today.Date,txt_type_paiement.Text.Trim(), txt_montant.Text.Trim(),cbx_devise.Text);
            dataGridView1.DataSource = Chargement_donnees.charger_dg_fret(4).Tables[0];
            txt_type_paiement.Text = "";
            txt_montant.Text = "";
            Chargement_donnees.increment_id(txt_id_paiement, 3);
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            af.supprimer_paiement_fret(txt_id_paiement.Text.Trim());
            dataGridView1.DataSource = Chargement_donnees.charger_dg_fret(4).Tables[0];
        }

        private void uc_paiement_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Chargement_donnees.charger_dg_fret(4).Tables[0];
            af.remplir_champs_paiement_fret(dataGridView1, txt_id_paiement,dt_pick_date,txt_type_paiement,txt_montant,cbx_devise);
            Chargement_donnees.increment_id(txt_id_paiement, 3);
            cbx_devise.Items.Add("USD");
            cbx_devise.Items.Add("CDF");
            cbx_devise.SelectedIndex = 0;
            bs.DataSource = Chargement_donnees.charger_dg_fret(4).Tables[0];
            dataGridView1.DataSource = bs;
            bindingNavigator1.BindingSource = bs;
        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            af.remplir_champs_paiement_fret(dataGridView1, txt_id_paiement, dt_pick_date, txt_type_paiement, txt_montant,cbx_devise);
        }

        private void dt_pick_date_Leave(object sender, EventArgs e)
        {
          //dt_pick_date.Value = DateTime.Today.Date;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Chargement_donnees.increment_id(txt_id_paiement, 3);
            txt_type_paiement.Text = "";
            txt_montant.Text = "";
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            af.supprimer_paiement_fret(txt_id_paiement.Text.Trim());
            dataGridView1.DataSource = Chargement_donnees.charger_dg_fret(4).Tables[0];
        }

        private void txt_id_paiement_KeyUp(object sender, KeyEventArgs e)
        {
            af.chercher_paiement(dataGridView1,txt_id_paiement);
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index > -1)
            {
                txt_id_paiement.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                dt_pick_date.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_type_paiement.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txt_montant.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
               cbx_devise.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }
            else
            {

            }
            bs.DataSource = Chargement_donnees.recherche_valeur(txt_id_paiement, 3).Tables[0];
            dataGridView1.DataSource = bs;
            bindingNavigator1.BindingSource = bs;
        }

        private void txt_id_paiement_Leave(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Chargement_donnees.charger_dg_fret(4).Tables[0];
            af.remplir_champs_paiement_fret(dataGridView1, txt_id_paiement, dt_pick_date, txt_type_paiement, txt_montant, cbx_devise);
            bs.DataSource = Chargement_donnees.charger_dg_fret(4).Tables[0];
            dataGridView1.DataSource = bs;
            bindingNavigator1.BindingSource = bs;
        }
    }
}
