namespace ZZZ_MIS_UI
{
    partial class Frm_Oglasi
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
            this.lblOd = new System.Windows.Forms.Label();
            this.dtOd = new System.Windows.Forms.DateTimePicker();
            this.lblDo = new System.Windows.Forms.Label();
            this.dtDo = new System.Windows.Forms.DateTimePicker();
            this.lblOblast = new System.Windows.Forms.Label();
            this.cbxOblasti = new System.Windows.Forms.ComboBox();
            this.dgOglasi = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.OglasID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivPosla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vjestine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iskustvo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edukacija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojPozicija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumObjave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumIsteka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojKandidata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgOglasi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOd
            // 
            this.lblOd.AutoSize = true;
            this.lblOd.Location = new System.Drawing.Point(12, 12);
            this.lblOd.Name = "lblOd";
            this.lblOd.Size = new System.Drawing.Size(21, 13);
            this.lblOd.TabIndex = 0;
            this.lblOd.Text = "Od";
            // 
            // dtOd
            // 
            this.dtOd.Location = new System.Drawing.Point(60, 10);
            this.dtOd.Name = "dtOd";
            this.dtOd.Size = new System.Drawing.Size(153, 20);
            this.dtOd.TabIndex = 1;
            // 
            // lblDo
            // 
            this.lblDo.AutoSize = true;
            this.lblDo.Location = new System.Drawing.Point(255, 14);
            this.lblDo.Name = "lblDo";
            this.lblDo.Size = new System.Drawing.Size(21, 13);
            this.lblDo.TabIndex = 2;
            this.lblDo.Text = "Do";
            // 
            // dtDo
            // 
            this.dtDo.Location = new System.Drawing.Point(293, 10);
            this.dtDo.Name = "dtDo";
            this.dtDo.Size = new System.Drawing.Size(158, 20);
            this.dtDo.TabIndex = 3;
            // 
            // lblOblast
            // 
            this.lblOblast.AutoSize = true;
            this.lblOblast.Location = new System.Drawing.Point(484, 14);
            this.lblOblast.Name = "lblOblast";
            this.lblOblast.Size = new System.Drawing.Size(37, 13);
            this.lblOblast.TabIndex = 4;
            this.lblOblast.Text = "Oblast";
            // 
            // cbxOblasti
            // 
            this.cbxOblasti.FormattingEnabled = true;
            this.cbxOblasti.Location = new System.Drawing.Point(527, 11);
            this.cbxOblasti.Name = "cbxOblasti";
            this.cbxOblasti.Size = new System.Drawing.Size(121, 21);
            this.cbxOblasti.TabIndex = 5;
            // 
            // dgOglasi
            // 
            this.dgOglasi.AllowUserToAddRows = false;
            this.dgOglasi.AllowUserToDeleteRows = false;
            this.dgOglasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOglasi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OglasID,
            this.NazivPosla,
            this.Vjestine,
            this.Iskustvo,
            this.Edukacija,
            this.BrojPozicija,
            this.DatumObjave,
            this.DatumIsteka,
            this.BrojKandidata});
            this.dgOglasi.Location = new System.Drawing.Point(15, 39);
            this.dgOglasi.Name = "dgOglasi";
            this.dgOglasi.ReadOnly = true;
            this.dgOglasi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOglasi.Size = new System.Drawing.Size(733, 266);
            this.dgOglasi.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(673, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(673, 311);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // OglasID
            // 
            this.OglasID.DataPropertyName = "OglasID";
            this.OglasID.HeaderText = "OglasID";
            this.OglasID.Name = "OglasID";
            this.OglasID.ReadOnly = true;
            this.OglasID.Visible = false;
            // 
            // NazivPosla
            // 
            this.NazivPosla.DataPropertyName = "NazivPosla";
            this.NazivPosla.HeaderText = "Naziv posla";
            this.NazivPosla.Name = "NazivPosla";
            this.NazivPosla.ReadOnly = true;
            // 
            // Vjestine
            // 
            this.Vjestine.DataPropertyName = "Vjestine";
            this.Vjestine.HeaderText = "Vjestine";
            this.Vjestine.Name = "Vjestine";
            this.Vjestine.ReadOnly = true;
            // 
            // Iskustvo
            // 
            this.Iskustvo.DataPropertyName = "Iskustvo";
            this.Iskustvo.HeaderText = "Iskustvo";
            this.Iskustvo.Name = "Iskustvo";
            this.Iskustvo.ReadOnly = true;
            // 
            // Edukacija
            // 
            this.Edukacija.DataPropertyName = "Edukacija";
            this.Edukacija.HeaderText = "Edukacija";
            this.Edukacija.Name = "Edukacija";
            this.Edukacija.ReadOnly = true;
            // 
            // BrojPozicija
            // 
            this.BrojPozicija.DataPropertyName = "BrojPozicija";
            this.BrojPozicija.HeaderText = "Broj pozicija";
            this.BrojPozicija.Name = "BrojPozicija";
            this.BrojPozicija.ReadOnly = true;
            // 
            // DatumObjave
            // 
            this.DatumObjave.DataPropertyName = "DatumObjave";
            this.DatumObjave.HeaderText = "Datum objave";
            this.DatumObjave.Name = "DatumObjave";
            this.DatumObjave.ReadOnly = true;
            // 
            // DatumIsteka
            // 
            this.DatumIsteka.DataPropertyName = "DatumIsteka";
            this.DatumIsteka.HeaderText = "Datum isteka";
            this.DatumIsteka.Name = "DatumIsteka";
            this.DatumIsteka.ReadOnly = true;
            // 
            // BrojKandidata
            // 
            this.BrojKandidata.DataPropertyName = "BrojKandidata";
            this.BrojKandidata.HeaderText = "Broj kandidata";
            this.BrojKandidata.Name = "BrojKandidata";
            this.BrojKandidata.ReadOnly = true;
            // 
            // Frm_Oglasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 342);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgOglasi);
            this.Controls.Add(this.cbxOblasti);
            this.Controls.Add(this.lblOblast);
            this.Controls.Add(this.dtDo);
            this.Controls.Add(this.lblDo);
            this.Controls.Add(this.dtOd);
            this.Controls.Add(this.lblOd);
            this.Name = "Frm_Oglasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oglasi";
            this.Load += new System.EventHandler(this.Frm_Oglasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgOglasi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOd;
        private System.Windows.Forms.DateTimePicker dtOd;
        private System.Windows.Forms.Label lblDo;
        private System.Windows.Forms.DateTimePicker dtDo;
        private System.Windows.Forms.Label lblOblast;
        private System.Windows.Forms.ComboBox cbxOblasti;
        private System.Windows.Forms.DataGridView dgOglasi;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn OglasID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivPosla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vjestine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iskustvo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edukacija;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojPozicija;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumObjave;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumIsteka;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojKandidata;
    }
}