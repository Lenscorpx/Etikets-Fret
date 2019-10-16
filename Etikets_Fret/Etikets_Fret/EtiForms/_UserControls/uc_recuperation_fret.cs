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
    public partial class uc_recuperation_fret : UserControl
    {
        BindingSource bs = new BindingSource();
        Affectation aff = new Affectation();
        public uc_recuperation_fret()
        {
            InitializeComponent();
            cbx_id_fret.DataSource = Chargement_donnees.charge_combobox(5).Items;
            dataGridView1.DataSource = Chargement_donnees.charger_dg_fret(6).Tables[0];
            bs.DataSource = Chargement_donnees.charger_dg_fret(6).Tables[0];
            dataGridView1.DataSource = bs;
            bindingNavigator1.BindingSource = bs;
        }

        private void cbx_id_fret_SelectedIndexChanged(object sender, EventArgs e)
        {
            Chargement_donnees.select_index(cbx_id_fret, txt_ref_fret, 4);
            aff.chercher_recuperation_colis(dataGridView1, cbx_id_fret); 
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index > -1)
            {
                txt_ref_fret.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_tickets.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                dt_pick_date.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txt_nom_destinataire.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
               num_carte.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txt_contact.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txt_observation.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                cbx_id_fret.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            }
            else
            {

            }
            bs.DataSource = Chargement_donnees.recherche_recuperation_fret(cbx_id_fret.Text).Tables[0];
            dataGridView1.DataSource = bs;
            bindingNavigator1.BindingSource = bs;
            Chargement_donnees.listefret(listBox1, txt_tickets);
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            aff.affectation_recuperation_fret(txt_ref_fret.Text.Trim(), dt_pick_date.Value, txt_nom_destinataire.Text.Trim(), num_carte.Text.Trim(), txt_contact.Text.Trim(), txt_observation.Text.Trim());
            dataGridView1.DataSource = Chargement_donnees.charger_dg_fret(6).Tables[0];
            bs.DataSource = Chargement_donnees.charger_dg_fret(6).Tables[0];
            dataGridView1.DataSource = bs;
            bindingNavigator1.BindingSource = bs;
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            aff.supprimer_recuperation_fret(txt_ref_fret.Text.Trim());
            dataGridView1.DataSource = Chargement_donnees.charger_dg_fret(6).Tables[0];
            bs.DataSource = Chargement_donnees.charger_dg_fret(6).Tables[0];
            dataGridView1.DataSource = bs;
            bindingNavigator1.BindingSource = bs;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            aff.remplir_champs_recuperation_fret(dataGridView1, txt_ref_fret, txt_tickets,dt_pick_date,txt_nom_destinataire,num_carte,txt_contact,cbx_id_fret,txt_observation);
            Chargement_donnees.listefret(listBox1, txt_tickets);
        }

        private void uc_recuperation_fret_Load(object sender, EventArgs e)
        {
          //  aff.remplir_champs_recuperation_fret(dataGridView1, txt_ref_fret, txt_tickets, dt_pick_date, txt_nom_destinataire, num_carte, txt_contact, cbx_id_fret, txt_observation);
        }


        private void txt_tickets_KeyUp(object sender, KeyEventArgs e)
        {
           Chargement_donnees.listefret(listBox1,txt_tickets);
           
        }
    }
}
