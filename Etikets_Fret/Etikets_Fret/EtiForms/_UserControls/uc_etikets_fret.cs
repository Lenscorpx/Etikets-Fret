using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Partie_metier;

namespace Etikets_Fret.EtiForms._UserControls
{
    public partial class uc_etikets_fret : UserControl
    {
        Affectation aff = new Affectation();
        string nom_pc, username_pc;

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
         
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
         
        }

        private void uc_etikets_fret_Load(object sender, EventArgs e)
        {
          
        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            aff.remlir_champs_etikets_fret(dataGridView1, txt_id_etikets_fret, dt_pick_date, txt_server_name);
        }

        public uc_etikets_fret()
        {
            InitializeComponent();
            nom_pc = Environment.MachineName;
            username_pc = Environment.UserName;
            txt_server_name.Text = string.Format("{0}/{1}", nom_pc, username_pc);
        }
    }
}
