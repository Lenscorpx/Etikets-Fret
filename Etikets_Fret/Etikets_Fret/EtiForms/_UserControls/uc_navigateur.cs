using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Etikets_Fret.EtiForms._UserControls
{
    public partial class uc_navigateur : UserControl
    {
        public uc_navigateur()
        {
            InitializeComponent();

            webBrowser1.Navigate("www.conebase-sas.com");
            webBrowser1.ProgressChanged += new WebBrowserProgressChangedEventHandler(webBrowser1_ProgressChanged);
        }
        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            int max = (int)Math.Max(e.MaximumProgress, e.CurrentProgress);
            //int min = (int)Math.Min(e.MaximumProgress, e.CurrentProgress);
            progressBar1.Maximum = max;
            progressBar1.Minimum = 0;
            if ((e.CurrentProgress > 0) && (e.CurrentProgress < 100))
            {
                //Run your code here when page is actually 100% complete
                progressBar1.Value = (int)e.CurrentProgress;
                progressBar1.Refresh();
            }
                
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            lbl_titre2.Text = "Loading ... ";
            progressBar1.MarqueeAnimationSpeed = 100;
            progressBar1.Style = ProgressBarStyle.Marquee;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            progressBar1.MarqueeAnimationSpeed = 0;
            progressBar1.Style = ProgressBarStyle.Blocks;
            lbl_titre2.Text = "Ready";
            progressBar1.Hide();

        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            if (!webBrowser1.IsBusy)
            {
                progressBar1.MarqueeAnimationSpeed = 0;
                progressBar1.Style = ProgressBarStyle.Blocks;

                progressBar1.Text = "Ready";
            }
        }
    }
}
