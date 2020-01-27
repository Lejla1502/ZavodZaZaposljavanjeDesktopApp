using Microsoft.Reporting.WinForms;
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

namespace ZZZ_MIS_UI.Reports
{
    public partial class Frm_KompanijeReport : Form
    {
        DSKompanije dsKompanije = new DSKompanije();
        public Frm_KompanijeReport(DSKompanije.KompanijeDataTable dtKompanije)
        {
            InitializeComponent();
            DSKompanijeBindingSource.DataSource = dtKompanije;
        }

        private void Frm_KompanijeReport_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("Kompanije", DSKompanijeBindingSource);
            reportViewer.LocalReport.DataSources.Add(rds);

            this.reportViewer.RefreshReport();
        }
    }
}
