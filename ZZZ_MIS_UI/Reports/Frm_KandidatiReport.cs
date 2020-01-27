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
    
    public partial class Frm_KandidatiReport : Form
    {
        DSKandidati dsKandidati = new DSKandidati();
        public Frm_KandidatiReport(DSKandidati.KandidatiDataTable dtKandidati)
        {
            InitializeComponent();
            DSKandidatiBindingSource.DataSource = dtKandidati;
        }

        private void Frm_KandidatiReport_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("Kandidati", DSKandidatiBindingSource);
            reportViewer.LocalReport.DataSources.Add(rds);
            this.reportViewer.RefreshReport();
        }
    }
}
