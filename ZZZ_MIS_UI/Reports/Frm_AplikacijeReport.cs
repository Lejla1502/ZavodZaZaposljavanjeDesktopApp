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
    public partial class Frm_AplikacijeReport : Form
    {
        DSAplikacije dsAplikacije = new DSAplikacije();
        public Frm_AplikacijeReport()
        {
            InitializeComponent();
        }

        private void Frm_AplikacijeReport_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "ZZZ_MIS_UI.Reports.rptAplikacijeTotal.rdlc";
            DAAplikacije.SelectAplikacijeTotal(dsAplikacije.AplikacijeTotal);
            bindingSource1.DataSource = dsAplikacije.AplikacijeTotal;
            
            ReportDataSource rds = new ReportDataSource("AplikacijeTotal", bindingSource1);
            reportViewer1.LocalReport.DataSources.Add(rds);
            
            this.reportViewer1.RefreshReport();
        }
    }
}
