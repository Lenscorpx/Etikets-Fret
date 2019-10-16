namespace Etikets_Fret.EtiForms._Forms
{
    partial class frm_close_app
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
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_no = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_ok = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel1.Font = new System.Drawing.Font("Segoe UI Semilight", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(61, 73);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(362, 37);
            this.materialLabel1.TabIndex = 8;
            this.materialLabel1.Text = "Voulez vous vraiment quitter?";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel2.Font = new System.Drawing.Font("Segoe UI Semilight", 14F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(74, 141);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(349, 50);
            this.materialLabel2.TabIndex = 9;
            this.materialLabel2.Text = "Cliquez sur \'OUI\' pour quitter et sur \'Non\' \r\n     pour retourner au menu princip" +
    "al";
            // 
            // btn_no
            // 
            this.btn_no.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(239)))));
            this.btn_no.BackColor = System.Drawing.Color.White;
            this.btn_no.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_no.BorderRadius = 1;
            this.btn_no.ButtonText = "      Non";
            this.btn_no.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_no.DisabledColor = System.Drawing.Color.Gray;
            this.btn_no.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_no.Iconimage = global::Etikets_Fret.Properties.Resources.delete_256;
            this.btn_no.Iconimage_right = null;
            this.btn_no.Iconimage_right_Selected = null;
            this.btn_no.Iconimage_Selected = null;
            this.btn_no.IconMarginLeft = 0;
            this.btn_no.IconMarginRight = 0;
            this.btn_no.IconRightVisible = true;
            this.btn_no.IconRightZoom = 0D;
            this.btn_no.IconVisible = true;
            this.btn_no.IconZoom = 90D;
            this.btn_no.IsTab = false;
            this.btn_no.Location = new System.Drawing.Point(261, 240);
            this.btn_no.Name = "btn_no";
            this.btn_no.Normalcolor = System.Drawing.Color.White;
            this.btn_no.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(239)))));
            this.btn_no.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_no.selected = true;
            this.btn_no.Size = new System.Drawing.Size(162, 41);
            this.btn_no.TabIndex = 29;
            this.btn_no.Text = "      Non";
            this.btn_no.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_no.Textcolor = System.Drawing.Color.Black;
            this.btn_no.TextFont = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_no.Click += new System.EventHandler(this.btn_no_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(239)))));
            this.btn_ok.BackColor = System.Drawing.Color.White;
            this.btn_ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ok.BorderRadius = 1;
            this.btn_ok.ButtonText = "      Oui";
            this.btn_ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ok.DisabledColor = System.Drawing.Color.Gray;
            this.btn_ok.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_ok.Iconimage = global::Etikets_Fret.Properties.Resources.ok_256;
            this.btn_ok.Iconimage_right = null;
            this.btn_ok.Iconimage_right_Selected = null;
            this.btn_ok.Iconimage_Selected = null;
            this.btn_ok.IconMarginLeft = 0;
            this.btn_ok.IconMarginRight = 0;
            this.btn_ok.IconRightVisible = true;
            this.btn_ok.IconRightZoom = 0D;
            this.btn_ok.IconVisible = true;
            this.btn_ok.IconZoom = 80D;
            this.btn_ok.IsTab = false;
            this.btn_ok.Location = new System.Drawing.Point(51, 240);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Normalcolor = System.Drawing.Color.White;
            this.btn_ok.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(239)))));
            this.btn_ok.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_ok.selected = true;
            this.btn_ok.Size = new System.Drawing.Size(160, 41);
            this.btn_ok.TabIndex = 28;
            this.btn_ok.Text = "      Oui";
            this.btn_ok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ok.Textcolor = System.Drawing.Color.Black;
            this.btn_ok.TextFont = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // frm_close_app
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 321);
            this.Controls.Add(this.btn_no);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.MaximizeBox = false;
            this.Name = "frm_close_app";
            this.Opacity = 0.93D;
            this.Resizable = false;
            this.ShowIcon = false;
            this.Text = "Quitter Etikets Colis?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_ok;
        private Bunifu.Framework.UI.BunifuFlatButton btn_no;
    }
}