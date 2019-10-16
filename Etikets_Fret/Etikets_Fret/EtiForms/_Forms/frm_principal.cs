using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;
using Etikets_Fret.EtiForms._UserControls;

namespace Etikets_Fret.EtiForms._Forms
{
    public partial class frm_principal : MetroForm
    {
        private void show_accueil()
        {
            var fr = new us_accueil_form()
            {
                Size = panel2.Size
            };
            panel2.Controls.Clear();
            panel2.Controls.Add(fr);
            fr.Visible = false;
            bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Scale;
            bunifuTransition1.ShowSync(fr);
            panel2.Controls.Add(fr);
            fr.Visible = true;
        }
        public frm_principal()
        {
            InitializeComponent();
            //show_accueil();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var fr = new uc_navigateur()
            {
                Size = panel2.Size
            };
            panel2.Controls.Clear();
            panel2.Controls.Add(fr);
            fr.Visible = true;
        }

        private void btn_tarif_Click(object sender, EventArgs e)
        {
            var fr = new uc_tarif()
            {
                Size = panel2.Size
            };
            panel2.Controls.Clear();
            panel2.Controls.Add(fr);
            fr.Visible = false;
            bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            bunifuTransition1.ShowSync(fr);
            fr.Visible = true;
        }

        private void btn_rapports_Click(object sender, EventArgs e)
        {
            var fr = new us_accueil_form()
            {
                Size = panel2.Size
            };
            panel2.Controls.Clear();
            panel2.Controls.Add(fr);
            fr.Visible = false;
            bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            bunifuTransition1.ShowSync(fr);
            fr.Visible = true;
        }

        private void btn_fret_Click(object sender, EventArgs e)
        {
            var fr = new uc_fret()
            {
                Size = panel2.Size
            };
            panel2.Controls.Clear();
            panel2.Controls.Add(fr);
            fr.Visible = false;
            bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            bunifuTransition1.ShowSync(fr);
            fr.Visible = true;
        }

        private void btn_etikets_Click(object sender, EventArgs e)
        {
            var fr = new us_accueil_form()
            {
                Size = panel2.Size
            };
            panel2.Controls.Clear();
            panel2.Controls.Add(fr);
            fr.Visible = false;
            bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Scale;
            bunifuTransition1.ShowSync(fr);
            panel2.Controls.Add(fr);
            fr.Visible = true;
        }

        private void btn_categories_Click(object sender, EventArgs e)
        {
            var fr = new uc_categories()
            {
                Size = panel2.Size
            };
            panel2.Controls.Clear();
            panel2.Controls.Add(fr);
            fr.Visible = false;
            bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            bunifuTransition1.ShowSync(fr);
            fr.Visible = true;
        }

        private void Paiement_fret_Click(object sender, EventArgs e)
        {
            var fr = new uc_paiement()
            {
                Size = panel2.Size
            };
            panel2.Controls.Clear();
            panel2.Controls.Add(fr);
            fr.Visible = false;
            bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            bunifuTransition1.ShowSync(fr);
            fr.Visible = true;
        }

        private void attribution_fret_Click(object sender, EventArgs e)
        {
            var fr = new uc_attrribution_paiement()
            {
                Size = panel2.Size
            };
            panel2.Controls.Clear();
            panel2.Controls.Add(fr);
            fr.Visible = false;
            bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            bunifuTransition1.ShowSync(fr);
            fr.Visible = true;
        }

        private void frm_principal_Load(object sender, EventArgs e)
        {
            show_accueil();
        }

        private void recuperation_coli_Click(object sender, EventArgs e)
        {
            var fr = new uc_recuperation_fret()
            {
                Size = panel2.Size
            };
            panel2.Controls.Clear();
            panel2.Controls.Add(fr);
            fr.Visible = false;
            bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            bunifuTransition1.ShowSync(fr);
            fr.Visible = true;
        }
    }
}