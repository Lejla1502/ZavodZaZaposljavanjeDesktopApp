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
    public partial class Frm_Oglasi : Form
    {
        DSOglasi dsOglasi = new DSOglasi();
        public Frm_Oglasi()
        {
            InitializeComponent();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {

            DAOglasi.GetOglasiByDatumIOblast(dsOglasi.PosaoOglasi, dtOd.Value, dtDo.Value, Convert.ToInt32(cbxOblasti.SelectedValue));
            dgOglasi.AutoGenerateColumns = false;
            dgOglasi.DataSource = dsOglasi.PosaoOglasi;



        }
        private void Frm_Oglasi_Load(object sender, EventArgs e)
        {
            DAOglasi.GetAllOblasti(dsOglasi.Oblasti);
            DSOglasi.OblastiRow oblast = dsOglasi.Oblasti.NewOblastiRow();
            oblast.OblastID = 0;
            oblast.Naziv = "Izaberi oblast";

            dsOglasi.Oblasti.Rows.InsertAt(oblast, 0);

            cbxOblasti.DataSource = dsOglasi.Oblasti;
            cbxOblasti.DisplayMember = "Naziv";
            cbxOblasti.ValueMember = "OblastID";

            btnSearch_Click(null, null);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Reports.Frm_OglasiReport frm = new Reports.Frm_OglasiReport(dtOd.Value,dtDo.Value,Convert.ToInt32( cbxOblasti.SelectedValue));
            frm.Show();
        }
    }
}
