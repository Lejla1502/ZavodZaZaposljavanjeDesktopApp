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
    public partial class Frm_Kandidati : Form
    {
        DSKandidati dsKandidati = new DSKandidati();
        public Frm_Kandidati()
        {
            InitializeComponent();
        }

        private void Frm_Kandidati_Load(object sender, EventArgs e)
        {
            DAKandidati.GetAllDrzave(dsKandidati.Drzave);
            DSKandidati.DrzaveRow drzava = dsKandidati.Drzave.NewDrzaveRow();

            drzava.DrzavaID = 0;
            drzava.Naziv = "Izaberi drzavu";

            dsKandidati.Drzave.Rows.InsertAt(drzava, 0);

            cbxDrzave.DataSource = dsKandidati.Drzave;
            cbxDrzave.DisplayMember = "Naziv";
            cbxDrzave.ValueMember = "DrzavaID";

            btnSearch_Click(null, null);
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            DAKandidati.GetKandidatiByIme(dsKandidati.Kandidati, txtIme.Text, txtPrezime.Text, Convert.ToInt32(cbxDrzave.SelectedValue));
            dgKandidati.AutoGenerateColumns = false;
            dgKandidati.DataSource = dsKandidati.Kandidati;

            dgKandidati_CellContentClick(null, null);
        }

        private void dgKandidati_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgKandidati.Rows.Count != 0)
            {
                int kandidatID = Convert.ToInt32(dgKandidati.SelectedRows[0].Cells[0].Value);
                DAKandidati.GetProfesijeByKandidatID(dsKandidati.KandidatiProfesija, kandidatID);
                dgKandidatiProfesije.AutoGenerateColumns = false;
                dgKandidatiProfesije.DataSource = dsKandidati.KandidatiProfesija;
            }
            else
            {
                dgKandidati.DataSource = null;
                dgKandidatiProfesije.DataSource = null;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Reports.Frm_KandidatiReport frm = new Reports.Frm_KandidatiReport(dsKandidati.Kandidati);
            frm.Show();
        }
    }
}
