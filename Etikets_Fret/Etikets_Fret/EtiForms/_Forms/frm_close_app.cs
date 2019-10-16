using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Etikets_Fret.EtiForms._Forms
{
    public partial class frm_close_app : MetroForm
    {
        public frm_close_app()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            var fr = new frm_principal();
            {
                this.Hide();
                fr.Show();
            }
        }
    }
}
