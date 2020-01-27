using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ZZZ_MIS_DAL;

namespace ZZZ_MIS_UI
{
    public partial class Frm_Kompanije : Form
    {
        DSKompanije dsKompanije = new DSKompanije();
        public Frm_Kompanije()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DAKompanije.SelectKompanijeByName(dsKompanije.Kompanije,Convert.ToInt32( cbxDrzave.SelectedValue), txtImeKompanije.Text,Convert.ToInt32( cbxKategorija.SelectedValue));
            dgKompanije.AutoGenerateColumns = false;
            dgKompanije.DataSource = dsKompanije.Kompanije;
            
            lblCompaniesNumber.Text = dsKompanije.Kompanije.Count.ToString();
        }

        private void Frm_Kompanije_Load(object sender, EventArgs e)
        {
            DAKompanije.GetAllDrzave(dsKompanije.Drzave);
            DSKompanije.DrzaveRow drzava = dsKompanije.Drzave.NewDrzaveRow();
            drzava.DrzavaID = 0;
            drzava.Naziv = "Izaberi državu";

            dsKompanije.Drzave.Rows.InsertAt(drzava, 0);

            cbxDrzave.DataSource = dsKompanije.Drzave;
            cbxDrzave.DisplayMember = "Naziv";
            cbxDrzave.ValueMember = "DrzavaID";

            DAKompanije.GetAllKategorije(dsKompanije.Kategorije);
            DSKompanije.KategorijeRow kategorija = dsKompanije.Kategorije.NewKategorijeRow();
            kategorija.KategorijaID = 0;
            kategorija.Naziv = "Izaberi kategoriju";

            dsKompanije.Kategorije.Rows.InsertAt(kategorija, 0);

            cbxKategorija.DataSource = dsKompanije.Kategorije;
            cbxKategorija.DisplayMember = "Naziv";
            cbxKategorija.ValueMember = "KategorijaID";

            btnSearch_Click(null,null);
        }

        private void btnAds_Click(object sender, EventArgs e)
        {
            int kompanijaID = Convert.ToInt32(dgKompanije.SelectedRows[0].Cells[0].Value);

            Frm_Kompanije_Oglasi frm = new Frm_Kompanije_Oglasi(kompanijaID);
            frm.Show();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Reports.Frm_KompanijeReport frm = new Reports.Frm_KompanijeReport(dsKompanije.Kompanije);
            frm.Show();
        }
    }
}
