namespace Etikets_Fret.EtiForms._Forms
{
    partial class frm_principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            frm_close_app cl = new frm_close_app();
            cl.Show();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_principal));
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_titre2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.recuperation_coli = new Bunifu.Framework.UI.BunifuFlatButton();
            this.attribution_fret = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Paiement_fret = new Bunifu.Framework.UI.BunifuFlatButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_rapports = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_categories = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_tarif = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_fret = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_etikets = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(239)))));
            this.panel3.Controls.Add(this.lbl_titre2);
            this.bunifuTransition1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(20, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1205, 50);
            this.panel3.TabIndex = 3;
            // 
            // lbl_titre2
            // 
            this.lbl_titre2.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lbl_titre2, BunifuAnimatorNS.DecorationType.None);
            this.lbl_titre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre2.ForeColor = System.Drawing.Color.Black;
            this.lbl_titre2.Location = new System.Drawing.Point(622, 7);
            this.lbl_titre2.Name = "lbl_titre2";
            this.lbl_titre2.Size = new System.Drawing.Size(150, 36);
            this.lbl_titre2.TabIndex = 2;
            this.lbl_titre2.Text = "etikets fret";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.recuperation_coli);
            this.panel1.Controls.Add(this.attribution_fret);
            this.panel1.Controls.Add(this.Paiement_fret);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btn_rapports);
            this.panel1.Controls.Add(this.btn_categories);
            this.panel1.Controls.Add(this.btn_tarif);
            this.panel1.Controls.Add(this.btn_fret);
            this.panel1.Controls.Add(this.btn_etikets);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.Crimson;
            this.panel1.Location = new System.Drawing.Point(20, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 562);
            this.panel1.TabIndex = 4;
            // 
            // recuperation_coli
            // 
            this.recuperation_coli.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(239)))));
            this.recuperation_coli.BackColor = System.Drawing.Color.White;
            this.recuperation_coli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.recuperation_coli.BorderRadius = 1;
            this.recuperation_coli.ButtonText = "       Retrait fret";
            this.recuperation_coli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.recuperation_coli, BunifuAnimatorNS.DecorationType.None);
            this.recuperation_coli.DisabledColor = System.Drawing.Color.Gray;
            this.recuperation_coli.Iconcolor = System.Drawing.Color.Transparent;
            this.recuperation_coli.Iconimage = global::Etikets_Fret.Properties.Resources.Paper_plane_3_svg;
            this.recuperation_coli.Iconimage_right = null;
            this.recuperation_coli.Iconimage_right_Selected = null;
            this.recuperation_coli.Iconimage_Selected = null;
            this.recuperation_coli.IconMarginLeft = 0;
            this.recuperation_coli.IconMarginRight = 0;
            this.recuperation_coli.IconRightVisible = true;
            this.recuperation_coli.IconRightZoom = 0D;
            this.recuperation_coli.IconVisible = true;
            this.recuperation_coli.IconZoom = 80D;
            this.recuperation_coli.IsTab = false;
            this.recuperation_coli.Location = new System.Drawing.Point(7, 287);
            this.recuperation_coli.Name = "recuperation_coli";
            this.recuperation_coli.Normalcolor = System.Drawing.Color.White;
            this.recuperation_coli.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(239)))));
            this.recuperation_coli.OnHoverTextColor = System.Drawing.Color.White;
            this.recuperation_coli.selected = true;
            this.recuperation_coli.Size = new System.Drawing.Size(192, 41);
            this.recuperation_coli.TabIndex = 32;
            this.recuperation_coli.Text = "       Retrait fret";
            this.recuperation_coli.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.recuperation_coli.Textcolor = System.Drawing.Color.Black;
            this.recuperation_coli.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recuperation_coli.Click += new System.EventHandler(this.recuperation_coli_Click);
            // 
            // attribution_fret
            // 
            this.attribution_fret.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(239)))));
            this.attribution_fret.BackColor = System.Drawing.Color.White;
            this.attribution_fret.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.attribution_fret.BorderRadius = 1;
            this.attribution_fret.ButtonText = "       Attrib paiement";
            this.attribution_fret.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.attribution_fret, BunifuAnimatorNS.DecorationType.None);
            this.attribution_fret.DisabledColor = System.Drawing.Color.Gray;
            this.attribution_fret.Iconcolor = System.Drawing.Color.Transparent;
            this.attribution_fret.Iconimage = global::Etikets_Fret.Properties.Resources.Paper_plane_3_svg;
            this.attribution_fret.Iconimage_right = null;
            this.attribution_fret.Iconimage_right_Selected = null;
            this.attribution_fret.Iconimage_Selected = null;
            this.attribution_fret.IconMarginLeft = 0;
            this.attribution_fret.IconMarginRight = 0;
            this.attribution_fret.IconRightVisible = true;
            this.attribution_fret.IconRightZoom = 0D;
            this.attribution_fret.IconVisible = true;
            this.attribution_fret.IconZoom = 80D;
            this.attribution_fret.IsTab = false;
            this.attribution_fret.Location = new System.Drawing.Point(7, 239);
            this.attribution_fret.Name = "attribution_fret";
            this.attribution_fret.Normalcolor = System.Drawing.Color.White;
            this.attribution_fret.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(239)))));
            this.attribution_fret.OnHoverTextColor = System.Drawing.Color.White;
            this.attribution_fret.selected = true;
            this.attribution_fret.Size = new System.Drawing.Size(192, 41);
            this.attribution_fret.TabIndex = 31;
            this.attribution_fret.Text = "       Attrib paiement";
            this.attribution_fret.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.attribution_fret.Textcolor = System.Drawing.Color.Black;
            this.attribution_fret.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attribution_fret.Click += new System.EventHandler(this.attribution_fret_Click);
            // 
            // Paiement_fret
            // 
            this.Paiement_fret.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(239)))));
            this.Paiement_fret.BackColor = System.Drawing.Color.White;
            this.Paiement_fret.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Paiement_fret.BorderRadius = 1;
            this.Paiement_fret.ButtonText = "       Paiement";
            this.Paiement_fret.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.Paiement_fret, BunifuAnimatorNS.DecorationType.None);
            this.Paiement_fret.DisabledColor = System.Drawing.Color.Gray;
            this.Paiement_fret.Iconcolor = System.Drawing.Color.Transparent;
            this.Paiement_fret.Iconimage = global::Etikets_Fret.Properties.Resources.Paper_plane_3_svg;
            this.Paiement_fret.Iconimage_right = null;
            this.Paiement_fret.Iconimage_right_Selected = null;
            this.Paiement_fret.Iconimage_Selected = null;
            this.Paiement_fret.IconMarginLeft = 0;
            this.Paiement_fret.IconMarginRight = 0;
            this.Paiement_fret.IconRightVisible = true;
            this.Paiement_fret.IconRightZoom = 0D;
            this.Paiement_fret.IconVisible = true;
            this.Paiement_fret.IconZoom = 80D;
            this.Paiement_fret.IsTab = false;
            this.Paiement_fret.Location = new System.Drawing.Point(7, 193);
            this.Paiement_fret.Name = "Paiement_fret";
            this.Paiement_fret.Normalcolor = System.Drawing.Color.White;
            this.Paiement_fret.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(239)))));
            this.Paiement_fret.OnHoverTextColor = System.Drawing.Color.White;
            this.Paiement_fret.selected = true;
            this.Paiement_fret.Size = new System.Drawing.Size(192, 41);
            this.Paiement_fret.TabIndex = 30;
            this.Paiement_fret.Text = "       Paiement";
            this.Paiement_fret.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Paiement_fret.Textcolor = System.Drawing.Color.Black;
            this.Paiement_fret.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paiement_fret.Click += new System.EventHandler(this.Paiement_fret_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.linkLabel1, BunifuAnimatorNS.DecorationType.None);
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(239)))));
            this.linkLabel1.Location = new System.Drawing.Point(19, 537);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(131, 17);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "www.conebase.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox2
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = global::Etikets_Fret.Properties.Resources.cb_04;
            this.pictureBox2.Location = new System.Drawing.Point(4, 472);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(197, 73);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // btn_rapports
            // 
            this.btn_rapports.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(239)))));
            this.btn_rapports.BackColor = System.Drawing.Color.White;
            this.btn_rapports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_rapports.BorderRadius = 1;
            this.btn_rapports.ButtonText = "      Rapports";
            this.btn_rapports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_rapports, BunifuAnimatorNS.DecorationType.None);
            this.btn_rapports.DisabledColor = System.Drawing.Color.Gray;
            this.btn_rapports.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_rapports.Iconimage = global::Etikets_Fret.Properties.Resources._24_financial_analysis_report_card_reporting_valuation_analysis_512;
            this.btn_rapports.Iconimage_right = null;
            this.btn_rapports.Iconimage_right_Selected = null;
            this.btn_rapports.Iconimage_Selected = null;
            this.btn_rapports.IconMarginLeft = 0;
            this.btn_rapports.IconMarginRight = 0;
            this.btn_rapports.IconRightVisible = true;
            this.btn_rapports.IconRightZoom = 0D;
            this.btn_rapports.IconVisible = true;
            this.btn_rapports.IconZoom = 90D;
            this.btn_rapports.IsTab = false;
            this.btn_rapports.Location = new System.Drawing.Point(7, 334);
            this.btn_rapports.Name = "btn_rapports";
            this.btn_rapports.Normalcolor = System.Drawing.Color.White;
            this.btn_rapports.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(239)))));
            this.btn_rapports.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_rapports.selected = true;
            this.btn_rapports.Size = new System.Drawing.Size(195, 41);
            this.btn_rapports.TabIndex = 27;
            this.btn_rapports.Text = "      Rapports";
            this.btn_rapports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_rapports.Textcolor = System.Drawing.Color.Black;
            this.btn_rapports.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rapports.Click += new System.EventHandler(this.btn_rapports_Click);
            // 
            // btn_categories
            // 
            this.btn_categories.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(239)))));
            this.btn_categories.BackColor = System.Drawing.Color.White;
            this.btn_categories.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_categories.BorderRadius = 1;
            this.btn_categories.ButtonText = "      Categories";
            this.btn_categories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_categories, BunifuAnimatorNS.DecorationType.None);
            this.btn_categories.DisabledColor = System.Drawing.Color.Gray;
            this.btn_categories.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_categories.Iconimage = global::Etikets_Fret.Properties.Resources.high_quality_good_512;
            this.btn_categories.Iconimage_right = null;
            this.btn_categories.Iconimage_right_Selected = null;
            this.btn_categories.Iconimage_Selected = null;
            this.btn_categories.IconMarginLeft = 0;
            this.btn_categories.IconMarginRight = 0;
            this.btn_categories.IconRightVisible = true;
            this.btn_categories.IconRightZoom = 0D;
            this.btn_categories.IconVisible = true;
            this.btn_categories.IconZoom = 80D;
            this.btn_categories.IsTab = false;
            this.btn_categories.Location = new System.Drawing.Point(7, 50);
            this.btn_categories.Name = "btn_categories";
            this.btn_categories.Normalcolor = System.Drawing.Color.White;
            this.btn_categories.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(239)))));
            this.btn_categories.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_categories.selected = true;
            this.btn_categories.Size = new System.Drawing.Size(192, 41);
            this.btn_categories.TabIndex = 17;
            this.btn_categories.Text = "      Categories";
            this.btn_categories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_categories.Textcolor = System.Drawing.Color.Black;
            this.btn_categories.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_categories.Click += new System.EventHandler(this.btn_categories_Click);
            // 
            // btn_tarif
            // 
            this.btn_tarif.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(239)))));
            this.btn_tarif.BackColor = System.Drawing.Color.White;
            this.btn_tarif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_tarif.BorderRadius = 1;
            this.btn_tarif.ButtonText = "      Tarif";
            this.btn_tarif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_tarif, BunifuAnimatorNS.DecorationType.None);
            this.btn_tarif.DisabledColor = System.Drawing.Color.Gray;
            this.btn_tarif.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_tarif.Iconimage = global::Etikets_Fret.Properties.Resources.coin_money_6;
            this.btn_tarif.Iconimage_right = null;
            this.btn_tarif.Iconimage_right_Selected = null;
            this.btn_tarif.Iconimage_Selected = null;
            this.btn_tarif.IconMarginLeft = 0;
            this.btn_tarif.IconMarginRight = 0;
            this.btn_tarif.IconRightVisible = true;
            this.btn_tarif.IconRightZoom = 0D;
            this.btn_tarif.IconVisible = true;
            this.btn_tarif.IconZoom = 80D;
            this.btn_tarif.IsTab = false;
            this.btn_tarif.Location = new System.Drawing.Point(7, 97);
            this.btn_tarif.Name = "btn_tarif";
            this.btn_tarif.Normalcolor = System.Drawing.Color.White;
            this.btn_tarif.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(239)))));
            this.btn_tarif.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_tarif.selected = true;
            this.btn_tarif.Size = new System.Drawing.Size(195, 43);
            this.btn_tarif.TabIndex = 26;
            this.btn_tarif.Text = "      Tarif";
            this.btn_tarif.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tarif.Textcolor = System.Drawing.Color.Black;
            this.btn_tarif.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tarif.Click += new System.EventHandler(this.btn_tarif_Click);
            // 
            // btn_fret
            // 
            this.btn_fret.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(239)))));
            this.btn_fret.BackColor = System.Drawing.Color.White;
            this.btn_fret.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_fret.BorderRadius = 1;
            this.btn_fret.ButtonText = "       Fret";
            this.btn_fret.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_fret, BunifuAnimatorNS.DecorationType.None);
            this.btn_fret.DisabledColor = System.Drawing.Color.Gray;
            this.btn_fret.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_fret.Iconimage = global::Etikets_Fret.Properties.Resources.Paper_plane_3_svg;
            this.btn_fret.Iconimage_right = null;
            this.btn_fret.Iconimage_right_Selected = null;
            this.btn_fret.Iconimage_Selected = null;
            this.btn_fret.IconMarginLeft = 0;
            this.btn_fret.IconMarginRight = 0;
            this.btn_fret.IconRightVisible = true;
            this.btn_fret.IconRightZoom = 0D;
            this.btn_fret.IconVisible = true;
            this.btn_fret.IconZoom = 80D;
            this.btn_fret.IsTab = false;
            this.btn_fret.Location = new System.Drawing.Point(7, 146);
            this.btn_fret.Name = "btn_fret";
            this.btn_fret.Normalcolor = System.Drawing.Color.White;
            this.btn_fret.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(239)))));
            this.btn_fret.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_fret.selected = true;
            this.btn_fret.Size = new System.Drawing.Size(192, 41);
            this.btn_fret.TabIndex = 19;
            this.btn_fret.Text = "       Fret";
            this.btn_fret.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_fret.Textcolor = System.Drawing.Color.Black;
            this.btn_fret.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fret.Click += new System.EventHandler(this.btn_fret_Click);
            // 
            // btn_etikets
            // 
            this.btn_etikets.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(239)))));
            this.btn_etikets.BackColor = System.Drawing.Color.White;
            this.btn_etikets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_etikets.BorderRadius = 1;
            this.btn_etikets.ButtonText = "     Accueil";
            this.btn_etikets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_etikets, BunifuAnimatorNS.DecorationType.None);
            this.btn_etikets.DisabledColor = System.Drawing.Color.Gray;
            this.btn_etikets.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_etikets.Iconimage = global::Etikets_Fret.Properties.Resources.icon_tickets;
            this.btn_etikets.Iconimage_right = null;
            this.btn_etikets.Iconimage_right_Selected = null;
            this.btn_etikets.Iconimage_Selected = null;
            this.btn_etikets.IconMarginLeft = 0;
            this.btn_etikets.IconMarginRight = 0;
            this.btn_etikets.IconRightVisible = true;
            this.btn_etikets.IconRightZoom = 0D;
            this.btn_etikets.IconVisible = true;
            this.btn_etikets.IconZoom = 100D;
            this.btn_etikets.IsTab = false;
            this.btn_etikets.Location = new System.Drawing.Point(7, 3);
            this.btn_etikets.Name = "btn_etikets";
            this.btn_etikets.Normalcolor = System.Drawing.Color.White;
            this.btn_etikets.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(239)))));
            this.btn_etikets.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_etikets.selected = true;
            this.btn_etikets.Size = new System.Drawing.Size(201, 41);
            this.btn_etikets.TabIndex = 18;
            this.btn_etikets.Text = "     Accueil";
            this.btn_etikets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_etikets.Textcolor = System.Drawing.Color.Black;
            this.btn_etikets.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_etikets.Click += new System.EventHandler(this.btn_etikets_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(225, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 562);
            this.panel2.TabIndex = 5;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 692);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.MaximizeBox = false;
            this.Name = "frm_principal";
            this.Opacity = 0.95D;
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frm_principal_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_titre2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_rapports;
        private Bunifu.Framework.UI.BunifuFlatButton btn_categories;
        private Bunifu.Framework.UI.BunifuFlatButton btn_tarif;
        private Bunifu.Framework.UI.BunifuFlatButton btn_fret;
        private Bunifu.Framework.UI.BunifuFlatButton btn_etikets;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private Bunifu.Framework.UI.BunifuFlatButton attribution_fret;
        private Bunifu.Framework.UI.BunifuFlatButton Paiement_fret;
        private Bunifu.Framework.UI.BunifuFlatButton recuperation_coli;
    }
}