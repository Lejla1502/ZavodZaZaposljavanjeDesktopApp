namespace ZZZ_MIS_UI
{
    partial class Frm_Kandidati
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
            this.dgKandidati = new System.Windows.Forms.DataGridView();
            this.KandidatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRodjenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StrucnaSprema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Certifikat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblKandidati = new System.Windows.Forms.Label();
            this.lblKandidatiProfesije = new System.Windows.Forms.Label();
            this.dgKandidatiProfesije = new System.Windows.Forms.DataGridView();
            this.OblastNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iskustvo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Industrija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uloga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vjestine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxDrzave = new System.Windows.Forms.ComboBox();
            this.lblDrzava = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgKandidati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgKandidatiProfesije)).BeginInit();
            this.SuspendLayout();
            // 
            // dgKandidati
            // 
            this.dgKandidati.AllowUserToAddRows = false;
            this.dgKandidati.AllowUserToDeleteRows = false;
            this.dgKandidati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKandidati.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KandidatID,
            this.Ime,
            this.Prezime,
            this.Email,
            this.DatumRodjenja,
            this.StrucnaSprema,
            this.Certifikat});
            this.dgKandidati.Location = new System.Drawing.Point(13, 63);
            this.dgKandidati.Name = "dgKandidati";
            this.dgKandidati.ReadOnly = true;
            this.dgKandidati.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgKandidati.Size = new System.Drawing.Size(667, 188);
            this.dgKandidati.TabIndex = 0;
            this.dgKandidati.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgKandidati_CellContentClick);
            // 
            // KandidatID
            // 
            this.KandidatID.DataPropertyName = "KandidatID";
            this.KandidatID.HeaderText = "KandidatID";
            this.KandidatID.Name = "KandidatID";
            this.KandidatID.ReadOnly = true;
            this.KandidatID.Visible = false;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // DatumRodjenja
            // 
            this.DatumRodjenja.DataPropertyName = "DatumRodjenja";
            this.DatumRodjenja.HeaderText = "Datum rodjenja";
            this.DatumRodjenja.Name = "DatumRodjenja";
            this.DatumRodjenja.ReadOnly = true;
            // 
            // StrucnaSprema
            // 
            this.StrucnaSprema.DataPropertyName = "StrucnaSprema";
            this.StrucnaSprema.HeaderText = "StrucnaSprema";
            this.StrucnaSprema.Name = "StrucnaSprema";
            this.StrucnaSprema.ReadOnly = true;
            // 
            // Certifikat
            // 
            this.Certifikat.DataPropertyName = "Certifikat";
            this.Certifikat.HeaderText = "Certifikat";
            this.Certifikat.Name = "Certifikat";
            this.Certifikat.ReadOnly = true;
            // 
            // lblKandidati
            // 
            this.lblKandidati.AutoSize = true;
            this.lblKandidati.Location = new System.Drawing.Point(15, 47);
            this.lblKandidati.Name = "lblKandidati";
            this.lblKandidati.Size = new System.Drawing.Size(51, 13);
            this.lblKandidati.TabIndex = 1;
            this.lblKandidati.Text = "Kandidati";
            // 
            // lblKandidatiProfesije
            // 
            this.lblKandidatiProfesije.AutoSize = true;
            this.lblKandidatiProfesije.Location = new System.Drawing.Point(15, 266);
            this.lblKandidatiProfesije.Name = "lblKandidatiProfesije";
            this.lblKandidatiProfesije.Size = new System.Drawing.Size(96, 13);
            this.lblKandidatiProfesije.TabIndex = 2;
            this.lblKandidatiProfesije.Text = "Kandidati_profesije";
            // 
            // dgKandidatiProfesije
            // 
            this.dgKandidatiProfesije.AllowUserToAddRows = false;
            this.dgKandidatiProfesije.AllowUserToDeleteRows = false;
            this.dgKandidatiProfesije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKandidatiProfesije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OblastNaziv,
            this.Iskustvo,
            this.Industrija,
            this.Uloga,
            this.Vjestine});
            this.dgKandidatiProfesije.Location = new System.Drawing.Point(16, 294);
            this.dgKandidatiProfesije.Name = "dgKandidatiProfesije";
            this.dgKandidatiProfesije.ReadOnly = true;
            this.dgKandidatiProfesije.Size = new System.Drawing.Size(664, 172);
            this.dgKandidatiProfesije.TabIndex = 3;
            // 
            // OblastNaziv
            // 
            this.OblastNaziv.DataPropertyName = "Naziv";
            this.OblastNaziv.HeaderText = "Oblast";
            this.OblastNaziv.Name = "OblastNaziv";
            this.OblastNaziv.ReadOnly = true;
            // 
            // Iskustvo
            // 
            this.Iskustvo.DataPropertyName = "Iskustvo";
            this.Iskustvo.HeaderText = "Iskustvo";
            this.Iskustvo.Name = "Iskustvo";
            this.Iskustvo.ReadOnly = true;
            // 
            // Industrija
            // 
            this.Industrija.DataPropertyName = "Industrija";
            this.Industrija.HeaderText = "Industrija";
            this.Industrija.Name = "Industrija";
            this.Industrija.ReadOnly = true;
            // 
            // Uloga
            // 
            this.Uloga.DataPropertyName = "Uloga";
            this.Uloga.HeaderText = "Uloga";
            this.Uloga.Name = "Uloga";
            this.Uloga.ReadOnly = true;
            // 
            // Vjestine
            // 
            this.Vjestine.DataPropertyName = "Vjestine";
            this.Vjestine.HeaderText = "Vjestine";
            this.Vjestine.Name = "Vjestine";
            this.Vjestine.ReadOnly = true;
            // 
            // cbxDrzave
            // 
            this.cbxDrzave.FormattingEnabled = true;
            this.cbxDrzave.Location = new System.Drawing.Point(87, 9);
            this.cbxDrzave.Name = "cbxDrzave";
            this.cbxDrzave.Size = new System.Drawing.Size(121, 21);
            this.cbxDrzave.TabIndex = 4;
            // 
            // lblDrzava
            // 
            this.lblDrzava.AutoSize = true;
            this.lblDrzava.Location = new System.Drawing.Point(25, 12);
            this.lblDrzava.Name = "lblDrzava";
            this.lblDrzava.Size = new System.Drawing.Size(41, 13);
            this.lblDrzava.TabIndex = 5;
            this.lblDrzava.Text = "Država";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(233, 13);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(24, 13);
            this.lblIme.TabIndex = 6;
            this.lblIme.Text = "Ime";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(264, 13);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 7;
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(393, 16);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(44, 13);
            this.lblPrezime.TabIndex = 8;
            this.lblPrezime.Text = "Prezime";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(443, 13);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtPrezime.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(564, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(605, 261);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 11;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Frm_Kandidati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 478);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.lblDrzava);
            this.Controls.Add(this.cbxDrzave);
            this.Controls.Add(this.dgKandidatiProfesije);
            this.Controls.Add(this.lblKandidatiProfesije);
            this.Controls.Add(this.lblKandidati);
            this.Controls.Add(this.dgKandidati);
            this.Name = "Frm_Kandidati";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kandidati";
            this.Load += new System.EventHandler(this.Frm_Kandidati_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgKandidati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgKandidatiProfesije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgKandidati;
        private System.Windows.Forms.Label lblKandidati;
        private System.Windows.Forms.Label lblKandidatiProfesije;
        private System.Windows.Forms.DataGridView dgKandidatiProfesije;
        private System.Windows.Forms.ComboBox cbxDrzave;
        private System.Windows.Forms.Label lblDrzava;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn KandidatID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRodjenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn StrucnaSprema;
        private System.Windows.Forms.DataGridViewTextBoxColumn Certifikat;
        private System.Windows.Forms.DataGridViewTextBoxColumn OblastNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iskustvo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Industrija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uloga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vjestine;
        private System.Windows.Forms.Button btnPrint;
    }
}