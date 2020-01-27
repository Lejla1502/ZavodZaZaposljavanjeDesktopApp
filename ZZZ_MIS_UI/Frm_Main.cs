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
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Kandidati frm = new Frm_Kandidati();
            frm.MdiParent = this;
            frm.Show();
        }

        private void searchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Kompanije frm = new Frm_Kompanije();
            frm.MdiParent = this;
            frm.Show();
        }

        private void searchToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Frm_Oglasi frm = new Frm_Oglasi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void oglasiTotalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.Frm_OglasiReport frm = new Reports.Frm_OglasiReport(DateTime.MinValue, DateTime.MaxValue, 0);
            frm.Show();
        }

        private void aplikacijeTotalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DSAplikacije dsAplikacije = new DSAplikacije();
            Reports.Frm_AplikacijeReport frm = new Reports.Frm_AplikacijeReport();
            frm.Show();
        }
    }
}
