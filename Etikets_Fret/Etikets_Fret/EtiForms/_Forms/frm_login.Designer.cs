namespace Etikets_Fret.EtiForms._Forms
{
    partial class frm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_username = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LabRole = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btlogin = new Bunifu.Framework.UI.BunifuTileButton();
            this.SuspendLayout();
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(21, 125);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(100, 19);
            this.materialLabel2.TabIndex = 8;
            this.materialLabel2.Text = "Mot de passe";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(21, 77);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(124, 19);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "Nom d\'utilisateur";
            // 
            // txt_password
            // 
            this.txt_password.Depth = 0;
            this.txt_password.Hint = "Mot de passe";
            this.txt_password.Location = new System.Drawing.Point(80, 147);
            this.txt_password.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.SelectedText = "";
            this.txt_password.SelectionLength = 0;
            this.txt_password.SelectionStart = 0;
            this.txt_password.Size = new System.Drawing.Size(283, 23);
            this.txt_password.TabIndex = 6;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // txt_username
            // 
            this.txt_username.Depth = 0;
            this.txt_username.Hint = "Nom d\'utilisateur";
            this.txt_username.Location = new System.Drawing.Point(80, 99);
            this.txt_username.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_username.Name = "txt_username";
            this.txt_username.PasswordChar = '\0';
            this.txt_username.SelectedText = "";
            this.txt_username.SelectionLength = 0;
            this.txt_username.SelectionStart = 0;
            this.txt_username.Size = new System.Drawing.Size(283, 23);
            this.txt_username.TabIndex = 5;
            this.txt_username.UseSystemPasswordChar = false;
            // 
            // LabRole
            // 
            this.LabRole.AutoSize = true;
            this.LabRole.Font = new System.Drawing.Font("Minion Pro SmBd", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabRole.Location = new System.Drawing.Point(369, 187);
            this.LabRole.Name = "LabRole";
            this.LabRole.Size = new System.Drawing.Size(0, 18);
            this.LabRole.TabIndex = 14;
            this.LabRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btlogin
            // 
            this.btlogin.BackColor = System.Drawing.Color.SeaGreen;
            this.btlogin.color = System.Drawing.Color.SeaGreen;
            this.btlogin.colorActive = System.Drawing.Color.DeepSkyBlue;
            this.btlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btlogin.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btlogin.ForeColor = System.Drawing.Color.White;
            this.btlogin.Image = ((System.Drawing.Image)(resources.GetObject("btlogin.Image")));
            this.btlogin.ImagePosition = 20;
            this.btlogin.ImageZoom = 50;
            this.btlogin.LabelPosition = 41;
            this.btlogin.LabelText = "Login";
            this.btlogin.Location = new System.Drawing.Point(372, 77);
            this.btlogin.Margin = new System.Windows.Forms.Padding(6);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(93, 100);
            this.btlogin.TabIndex = 12;
            this.btlogin.Click += new System.EventHandler(this.btlogin_Click);
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 223);
            this.Controls.Add(this.LabRole);
            this.Controls.Add(this.btlogin);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "frm_login";
            this.Opacity = 0.95D;
            this.Padding = new System.Windows.Forms.Padding(23, 60, 23, 20);
            this.Resizable = false;
            this.Text = "etikets - colis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_password;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_username;
        private Bunifu.Framework.UI.BunifuCustomLabel LabRole;
        private Bunifu.Framework.UI.BunifuTileButton btlogin;
    }
}