using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Partie_metier;
using System.Data.SqlClient;

namespace Etikets_Fret.EtiReports
{
    public partial class Print_ticket : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        string codeTransaction;

        public Print_ticket(string codeTransaction)
        {
            InitializeComponent();
            this.codeTransaction = codeTransaction;
            var xtrp = new XtraPrint_ticket_fret();
            Chargement_donnees.print_ticket_fret(xtrp, codeTransaction, documentViewer1);
            documentViewer1.Refresh();
        }
    }
}
