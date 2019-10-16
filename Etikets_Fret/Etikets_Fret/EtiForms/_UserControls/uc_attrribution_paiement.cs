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
using Etikets_Fret.EtiReports;

namespace Etikets_Fret.EtiForms._UserControls
{
    public partial class uc_attrribution_paiement : UserControl
    {
        BindingSource bs = new BindingSource();
        public uc_attrribution_paiement()
        {
            InitializeComponent();
        }
        Affectation af = new Affectation();
        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Chargement_donnees.select_index(cbx_fret, txt_ref_fret, 4);
            //af.chercher_attribution_fret_par_id_fret(dataGridView1, cbx_fret);

            //bs.DataSource = Chargement_donnees.recherche_attrib_fret_par_ref_fret(cbx_fret).Tables[0];
            //dataGridView1.DataSource = bs;
            //bindingNavigator1.BindingSource = bs;
            //if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index > -1)
            //{
            //    txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //    cbx_transaction.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //    cbx_fret.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            //    txt_ref_fret.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            //}
            //else
            //{

            //}
        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }
        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            af.affectation_attribution_fret(txt_id.Text.Trim(),txt_ref_fret.Text.Trim(),cbx_transaction.Text);
            dataGridView1.Refresh();
            dataGridView1.DataSource = Chargement_donnees.charger_dg_fret(5).Tables[0];  
        }

        private void uc_attrribution_paiement_Load(object sender, EventArgs e)
        {
            Chargement_donnees.increment_id(txt_id, 2);
            cbx_transaction.DataSource= Chargement_donnees.charge_combobox(4).Items;
            cbx_fret.DataSource= Chargement_donnees.charge_combobox(5).Items;
            dataGridView1.DataSource= Chargement_donnees.charger_dg_fret(5).Tables[0];
            bs.DataSource = Chargement_donnees.charger_dg_fret(5).Tables[0];
            dataGridView1.DataSource = bs;
            bindingNavigator1.BindingSource = bs;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            af.remplir_champs_attribution_fret(dataGridView1, txt_id, cbx_transaction, cbx_fret, txt_ref_fret);
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            af.supprimer_attribution_fret(txt_id.Text);
            dataGridView1.DataSource = Chargement_donnees.charger_dg_fret(5).Tables[0];
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Chargement_donnees.increment_id(txt_id, 2);
        }
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            af.supprimer_attribution_fret(txt_id.Text);
            dataGridView1.DataSource = Chargement_donnees.charger_dg_fret(5).Tables[0];
        }

        private void cbx_transaction_Leave(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Chargement_donnees.charger_dg_fret(5).Tables[0];
            bs.DataSource = Chargement_donnees.charger_dg_fret(5).Tables[0];
            dataGridView1.DataSource = bs;
            bindingNavigator1.BindingSource = bs;
        }

        private void cbx_transaction_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            af.chercher_attribution_frer(dataGridView1, cbx_transaction);
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index > -1)
            {
                txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                cbx_transaction.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                cbx_fret.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                txt_ref_fret.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                
            }
            else
            {

            }
            bs.DataSource = Chargement_donnees.recherche_valeur(cbx_transaction).Tables[0];
            dataGridView1.DataSource = bs;
            bindingNavigator1.BindingSource = bs;
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            paiement_fret rpt = new paiement_fret();
            rpt.Transaction_id = cbx_transaction.Text;
            var prt = new Print_ticket(rpt.Transaction_id);
            prt.Show();
        }

        private void cbx_fret_Leave(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Chargement_donnees.charger_dg_fret(5).Tables[0];
            bs.DataSource = Chargement_donnees.charger_dg_fret(5).Tables[0];
            dataGridView1.DataSource = bs;
            bindingNavigator1.BindingSource = bs;
        }
    }
}
