using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;
using Etikets_Fret.EtiForms._Forms;
using Partie_metier;

namespace Etikets_Fret.EtiForms._Forms
{
    public partial class frm_login : MetroForm
    {
        public frm_login()
        {
            InitializeComponent();
        }
        frm_principal frm = new frm_principal();
        private void btlogin_Click(object sender, EventArgs e)
        {
            var lcs = new LoginClass();
            lcs.User_name = txt_username.Text.Trim();
            lcs.Pass_word = txt_password.Text.Trim();
            DAOLogin.login(lcs,LabRole,frm,this);  
            
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            //frm_close_app cl = new frm_close_app();
            //cl.Show();
        }
     
    }
}
