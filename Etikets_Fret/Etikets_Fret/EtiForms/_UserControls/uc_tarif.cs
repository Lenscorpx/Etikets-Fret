using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using Partie_metier;

namespace Etikets_Fret.EtiForms._UserControls
{
    public partial class uc_tarif : UserControl
    {
        Affectation aff = new Affectation();
        public uc_tarif()
        {
            InitializeComponent();
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            aff.affectation_tarif(txt_id_tarif.Text.Trim(),txt_prix.Text.Trim(),cbx_devise.Text.Trim());
            aff.chdg_tarif(dataGridView1);
        }
        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            aff.supprimer_enregistrement(txt_id_tarif.Text.Trim());
            aff.chdg_tarif(dataGridView1);
        }

        private void uc_tarif_Load(object sender, EventArgs e)
        {
            aff.chdg_tarif(dataGridView1);
            aff.remplir_champs_tarif(dataGridView1, txt_id_tarif, txt_prix,cbx_devise);
            cbx_devise.Items.Add("USD");
            cbx_devise.Items.Add("CDF");
            cbx_devise.Text="USD";
        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            aff.remplir_champs_tarif(dataGridView1, txt_id_tarif, txt_prix,cbx_devise);
        }
    }
}
