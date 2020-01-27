namespace ZZZ_MIS_UI
{
    partial class Frm_Kompanije_Oglasi
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
            this.dgOglasi = new System.Windows.Forms.DataGridView();
            this.OglasID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivPosla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vjestine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iskustvo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edukacija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojPozicija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumObjave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumIsteka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgOglasi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgOglasi
            // 
            this.dgOglasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOglasi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OglasID,
            this.NazivPosla,
            this.Vjestine,
            this.Iskustvo,
            this.Edukacija,
            this.BrojPozicija,
            this.DatumObjave,
            this.DatumIsteka});
            this.dgOglasi.Location = new System.Drawing.Point(12, 12);
            this.dgOglasi.Name = "dgOglasi";
            this.dgOglasi.Size = new System.Drawing.Size(788, 314);
            this.dgOglasi.TabIndex = 0;
            // 
            // OglasID
            // 
            this.OglasID.DataPropertyName = "OglasID";
            this.OglasID.HeaderText = "OglasID";
            this.OglasID.Name = "OglasID";
            this.OglasID.Visible = false;
            // 
            // NazivPosla
            // 
            this.NazivPosla.DataPropertyName = "NazivPosla";
            this.NazivPosla.HeaderText = "Naziv posla";
            this.NazivPosla.Name = "NazivPosla";
            // 
            // Vjestine
            // 
            this.Vjestine.DataPropertyName = "Vjestine";
            this.Vjestine.HeaderText = "Vjestine";
            this.Vjestine.Name = "Vjestine";
            // 
            // Iskustvo
            // 
            this.Iskustvo.DataPropertyName = "Iskustvo";
            this.Iskustvo.HeaderText = "Iskustvo";
            this.Iskustvo.Name = "Iskustvo";
            // 
            // Edukacija
            // 
            this.Edukacija.DataPropertyName = "Edukacija";
            this.Edukacija.HeaderText = "Edukacija";
            this.Edukacija.Name = "Edukacija";
            // 
            // BrojPozicija
            // 
            this.BrojPozicija.DataPropertyName = "BrojPozicija";
            this.BrojPozicija.HeaderText = "Broj pozicija";
            this.BrojPozicija.Name = "BrojPozicija";
            // 
            // DatumObjave
            // 
            this.DatumObjave.DataPropertyName = "DatumObjave";
            this.DatumObjave.HeaderText = "Datum objave";
            this.DatumObjave.Name = "DatumObjave";
            // 
            // DatumIsteka
            // 
            this.DatumIsteka.DataPropertyName = "DatumIsteka";
            this.DatumIsteka.HeaderText = "Datum isteka";
            this.DatumIsteka.Name = "DatumIsteka";
            // 
            // Frm_Kompanije_Oglasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 355);
            this.Controls.Add(this.dgOglasi);
            this.Name = "Frm_Kompanije_Oglasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oglasi kompanije";
            this.Load += new System.EventHandler(this.Frm_Kompanije_Oglasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgOglasi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgOglasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn OglasID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivPosla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vjestine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iskustvo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edukacija;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojPozicija;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumObjave;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumIsteka;
    }
}