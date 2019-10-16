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
    public partial class uc_categories : UserControl
    {
        Affectation aff = new Affectation();
        public uc_categories()
        {
            InitializeComponent();
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            aff.affectation_type_colis(txt_code_type_colis.Text.Trim(), txt_description_type.Text.Trim(),txt_unite.Text.Trim(), txt_code_tarif.Text.Trim());
            aff.chdg_categorie(dataGridView1);
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            aff.supprimer_type_colis(txt_code_type_colis.Text.Trim());
            aff.chdg_categorie(dataGridView1);
        }

        private void uc_categories_Load(object sender, EventArgs e)
        {
            aff.chdg_categorie(dataGridView1);
            cbx_site_id.DataSource = Chargement_donnees.charge_combobox(3).Items;//charger les donnees dans le combo box
            aff.remlir_champs_categorie_fret(dataGridView1, txt_code_type_colis,txt_description_type, txt_unite,cbx_site_id);
        }
        private void cbx_site_id_SelectedIndexChanged(object sender, EventArgs e)
        {
           Chargement_donnees.select_index(cbx_site_id, txt_code_tarif,1);
        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            aff.remlir_champs_categorie_fret(dataGridView1, txt_code_type_colis, txt_description_type, txt_unite,cbx_site_id);
        }

        private void txt_code_type_colis_KeyUp(object sender, KeyEventArgs e)
        {
            aff.chercher_categorie(dataGridView1, txt_code_type_colis);
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index > -1)
            {
                txt_description_type.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_unite.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                cbx_site_id.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
            else
            {
            }
        }

        private void txt_code_type_colis_Leave(object sender, EventArgs e)
        {
            aff.chdg_categorie(dataGridView1);
            aff.remlir_champs_categorie_fret(dataGridView1, txt_code_type_colis, txt_description_type, txt_unite, cbx_site_id);

        }
    }
}
