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
    public partial class Frm_Kompanije_Oglasi : Form
    {
        int kompanijaID;
        DSOglasi dsOglasi = new DSOglasi();

        public Frm_Kompanije_Oglasi(int kompanijaID)
        {
            InitializeComponent();
            this.kompanijaID = kompanijaID;
        }

        private void Frm_Kompanije_Oglasi_Load(object sender, EventArgs e)
        {
            DAOglasi.SelectOglasiByKompanijaID(dsOglasi.PosaoOglasi, kompanijaID);

            dgOglasi.AutoGenerateColumns = false;
            dgOglasi.DataSource = dsOglasi.PosaoOglasi;
        }
    }
}
