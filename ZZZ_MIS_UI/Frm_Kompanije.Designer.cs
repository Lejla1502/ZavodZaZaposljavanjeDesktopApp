namespace ZZZ_MIS_UI
{
    partial class Frm_Kompanije
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
            this.lblDrzave = new System.Windows.Forms.Label();
            this.cbxDrzave = new System.Windows.Forms.ComboBox();
            this.lblImeKompanije = new System.Windows.Forms.Label();
            this.txtImeKompanije = new System.Windows.Forms.TextBox();
            this.lblKategorija = new System.Windows.Forms.Label();
            this.cbxKategorija = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgKompanije = new System.Windows.Forms.DataGridView();
            this.KompanijaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImeKompanije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KontaktOsoba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KontaktBroj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCompaniesCount = new System.Windows.Forms.Label();
            this.lblCompaniesNumber = new System.Windows.Forms.Label();
            this.btnAds = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgKompanije)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDrzave
            // 
            this.lblDrzave.AutoSize = true;
            this.lblDrzave.Location = new System.Drawing.Point(12, 13);
            this.lblDrzave.Name = "lblDrzave";
            this.lblDrzave.Size = new System.Drawing.Size(41, 13);
            this.lblDrzave.TabIndex = 0;
            this.lblDrzave.Text = "Države";
            // 
            // cbxDrzave
            // 
            this.cbxDrzave.FormattingEnabled = true;
            this.cbxDrzave.Location = new System.Drawing.Point(59, 8);
            this.cbxDrzave.Name = "cbxDrzave";
            this.cbxDrzave.Size = new System.Drawing.Size(121, 21);
            this.cbxDrzave.TabIndex = 1;
            // 
            // lblImeKompanije
            // 
            this.lblImeKompanije.AutoSize = true;
            this.lblImeKompanije.Location = new System.Drawing.Point(186, 13);
            this.lblImeKompanije.Name = "lblImeKompanije";
            this.lblImeKompanije.Size = new System.Drawing.Size(75, 13);
            this.lblImeKompanije.TabIndex = 2;
            this.lblImeKompanije.Text = "Ime kompanije";
            // 
            // txtImeKompanije
            // 
            this.txtImeKompanije.Location = new System.Drawing.Point(267, 10);
            this.txtImeKompanije.Name = "txtImeKompanije";
            this.txtImeKompanije.Size = new System.Drawing.Size(100, 20);
            this.txtImeKompanije.TabIndex = 3;
            // 
            // lblKategorija
            // 
            this.lblKategorija.AutoSize = true;
            this.lblKategorija.Location = new System.Drawing.Point(373, 13);
            this.lblKategorija.Name = "lblKategorija";
            this.lblKategorija.Size = new System.Drawing.Size(54, 13);
            this.lblKategorija.TabIndex = 4;
            this.lblKategorija.Text = "Kategorija";
            // 
            // cbxKategorija
            // 
            this.cbxKategorija.FormattingEnabled = true;
            this.cbxKategorija.Location = new System.Drawing.Point(433, 10);
            this.cbxKategorija.Name = "cbxKategorija";
            this.cbxKategorija.Size = new System.Drawing.Size(121, 21);
            this.cbxKategorija.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(560, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgKompanije
            // 
            this.dgKompanije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKompanije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KompanijaID,
            this.ImeKompanije,
            this.KontaktOsoba,
            this.KontaktBroj,
            this.Email});
            this.dgKompanije.Location = new System.Drawing.Point(15, 37);
            this.dgKompanije.Name = "dgKompanije";
            this.dgKompanije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgKompanije.Size = new System.Drawing.Size(724, 313);
            this.dgKompanije.TabIndex = 7;
            // 
            // KompanijaID
            // 
            this.KompanijaID.DataPropertyName = "KompanijaID";
            this.KompanijaID.HeaderText = "KompanijaID";
            this.KompanijaID.Name = "KompanijaID";
            this.KompanijaID.Visible = false;
            // 
            // ImeKompanije
            // 
            this.ImeKompanije.DataPropertyName = "ImeKompanije";
            this.ImeKompanije.HeaderText = "Ime kompanije";
            this.ImeKompanije.Name = "ImeKompanije";
            this.ImeKompanije.Width = 170;
            // 
            // KontaktOsoba
            // 
            this.KontaktOsoba.DataPropertyName = "KontaktOsoba";
            this.KontaktOsoba.HeaderText = "Kontakt osoba";
            this.KontaktOsoba.Name = "KontaktOsoba";
            // 
            // KontaktBroj
            // 
            this.KontaktBroj.DataPropertyName = "KontaktBroj";
            this.KontaktBroj.HeaderText = "Kontakt broj";
            this.KontaktBroj.Name = "KontaktBroj";
            this.KontaktBroj.Width = 120;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.Width = 160;
            // 
            // lblCompaniesCount
            // 
            this.lblCompaniesCount.AutoSize = true;
            this.lblCompaniesCount.Location = new System.Drawing.Point(25, 357);
            this.lblCompaniesCount.Name = "lblCompaniesCount";
            this.lblCompaniesCount.Size = new System.Drawing.Size(89, 13);
            this.lblCompaniesCount.TabIndex = 8;
            this.lblCompaniesCount.Text = "Companies count";
            // 
            // lblCompaniesNumber
            // 
            this.lblCompaniesNumber.AutoSize = true;
            this.lblCompaniesNumber.Location = new System.Drawing.Point(130, 356);
            this.lblCompaniesNumber.Name = "lblCompaniesNumber";
            this.lblCompaniesNumber.Size = new System.Drawing.Size(35, 13);
            this.lblCompaniesNumber.TabIndex = 9;
            this.lblCompaniesNumber.Text = "label1";
            // 
            // btnAds
            // 
            this.btnAds.Location = new System.Drawing.Point(664, 351);
            this.btnAds.Name = "btnAds";
            this.btnAds.Size = new System.Drawing.Size(75, 23);
            this.btnAds.TabIndex = 10;
            this.btnAds.Text = "View Ads";
            this.btnAds.UseVisualStyleBackColor = true;
            this.btnAds.Click += new System.EventHandler(this.btnAds_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(574, 351);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 11;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Frm_Kompanije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 379);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnAds);
            this.Controls.Add(this.lblCompaniesNumber);
            this.Controls.Add(this.lblCompaniesCount);
            this.Controls.Add(this.dgKompanije);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbxKategorija);
            this.Controls.Add(this.lblKategorija);
            this.Controls.Add(this.txtImeKompanije);
            this.Controls.Add(this.lblImeKompanije);
            this.Controls.Add(this.cbxDrzave);
            this.Controls.Add(this.lblDrzave);
            this.Name = "Frm_Kompanije";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kompanije";
            this.Load += new System.EventHandler(this.Frm_Kompanije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgKompanije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDrzave;
        private System.Windows.Forms.ComboBox cbxDrzave;
        private System.Windows.Forms.Label lblImeKompanije;
        private System.Windows.Forms.TextBox txtImeKompanije;
        private System.Windows.Forms.Label lblKategorija;
        private System.Windows.Forms.ComboBox cbxKategorija;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgKompanije;
        private System.Windows.Forms.Label lblCompaniesCount;
        private System.Windows.Forms.Label lblCompaniesNumber;
        private System.Windows.Forms.Button btnAds;
        private System.Windows.Forms.DataGridViewTextBoxColumn KompanijaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImeKompanije;
        private System.Windows.Forms.DataGridViewTextBoxColumn KontaktOsoba;
        private System.Windows.Forms.DataGridViewTextBoxColumn KontaktBroj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.Button btnPrint;
    }
}

