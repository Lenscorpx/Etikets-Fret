namespace Etikets_Fret.EtiForms._UserControls
{
    partial class uc_etikets_fret
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_enregistrer = new System.Windows.Forms.Button();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_id_etikets_fret = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_server_name = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dt_pick_date = new Bunifu.Framework.UI.BunifuDatepicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Etikets_Fret.Properties.Resources.icon_tickets;
            this.pictureBox2.Location = new System.Drawing.Point(12, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(164, 135);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 153;
            this.pictureBox2.TabStop = false;
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_supprimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(160)))), ((int)(((byte)(218)))));
            this.btn_supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supprimer.Location = new System.Drawing.Point(847, 166);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(113, 34);
            this.btn_supprimer.TabIndex = 152;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_enregistrer
            // 
            this.btn_enregistrer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_enregistrer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(160)))), ((int)(((byte)(218)))));
            this.btn_enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enregistrer.Location = new System.Drawing.Point(728, 166);
            this.btn_enregistrer.Name = "btn_enregistrer";
            this.btn_enregistrer.Size = new System.Drawing.Size(113, 34);
            this.btn_enregistrer.TabIndex = 151;
            this.btn_enregistrer.Text = "Enregistrer";
            this.btn_enregistrer.UseVisualStyleBackColor = true;
            this.btn_enregistrer.Click += new System.EventHandler(this.btn_enregistrer_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(186, 62);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(101, 19);
            this.materialLabel2.TabIndex = 150;
            this.materialLabel2.Text = "Date Creation";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(182, 15);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(74, 19);
            this.materialLabel1.TabIndex = 149;
            this.materialLabel1.Text = "ID Etikets";
            // 
            // txt_id_etikets_fret
            // 
            this.txt_id_etikets_fret.Depth = 0;
            this.txt_id_etikets_fret.Hint = "Entrez le code ID Etikets";
            this.txt_id_etikets_fret.Location = new System.Drawing.Point(230, 36);
            this.txt_id_etikets_fret.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_id_etikets_fret.Name = "txt_id_etikets_fret";
            this.txt_id_etikets_fret.PasswordChar = '\0';
            this.txt_id_etikets_fret.SelectedText = "";
            this.txt_id_etikets_fret.SelectionLength = 0;
            this.txt_id_etikets_fret.SelectionStart = 0;
            this.txt_id_etikets_fret.Size = new System.Drawing.Size(730, 23);
            this.txt_id_etikets_fret.TabIndex = 147;
            this.txt_id_etikets_fret.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 325);
            this.panel1.TabIndex = 146;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(994, 325);
            this.dataGridView1.TabIndex = 123;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(186, 110);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(95, 19);
            this.materialLabel3.TabIndex = 155;
            this.materialLabel3.Text = "Server Name";
            // 
            // txt_server_name
            // 
            this.txt_server_name.Depth = 0;
            this.txt_server_name.Hint = "Nom de serveur local";
            this.txt_server_name.Location = new System.Drawing.Point(230, 132);
            this.txt_server_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_server_name.Name = "txt_server_name";
            this.txt_server_name.PasswordChar = '\0';
            this.txt_server_name.SelectedText = "";
            this.txt_server_name.SelectionLength = 0;
            this.txt_server_name.SelectionStart = 0;
            this.txt_server_name.Size = new System.Drawing.Size(730, 23);
            this.txt_server_name.TabIndex = 154;
            this.txt_server_name.UseSystemPasswordChar = false;
            // 
            // dt_pick_date
            // 
            this.dt_pick_date.BackColor = System.Drawing.Color.White;
            this.dt_pick_date.BorderRadius = 0;
            this.dt_pick_date.Cursor = System.Windows.Forms.Cursors.No;
            this.dt_pick_date.ForeColor = System.Drawing.Color.Black;
            this.dt_pick_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_pick_date.FormatCustom = null;
            this.dt_pick_date.Location = new System.Drawing.Point(230, 82);
            this.dt_pick_date.Name = "dt_pick_date";
            this.dt_pick_date.Size = new System.Drawing.Size(298, 25);
            this.dt_pick_date.TabIndex = 156;
            this.dt_pick_date.Value = new System.DateTime(2017, 11, 20, 0, 0, 0, 0);
            // 
            // uc_etikets_fret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dt_pick_date);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txt_server_name);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_enregistrer);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txt_id_etikets_fret);
            this.Controls.Add(this.panel1);
            this.Name = "uc_etikets_fret";
            this.Size = new System.Drawing.Size(994, 531);
            this.Load += new System.EventHandler(this.uc_etikets_fret_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_enregistrer;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_id_etikets_fret;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_server_name;
        private Bunifu.Framework.UI.BunifuDatepicker dt_pick_date;
    }
}
