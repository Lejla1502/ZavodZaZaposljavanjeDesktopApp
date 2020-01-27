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
    public partial class Frm_OglasiReport : Form
    {
        DateTime datumOd = DateTime.MinValue;
        DateTime datumDo = DateTime.MaxValue;
        int oblastId = 0;
        DSOglasi dsOglasi = new DSOglasi();
        public Frm_OglasiReport(DateTime datumOd,DateTime datumDo,int oblastId)
        {
            InitializeComponent();
            this.datumOd = datumOd;
            this.datumDo = datumDo;
            this.oblastId = oblastId;
        }

        private void Frm_OglasiReport_Load(object sender, EventArgs e)
        {
            if (datumOd == DateTime.MinValue && datumDo == DateTime.MaxValue && oblastId == 0)
            {
                reportViewer.LocalReport.ReportEmbeddedResource = "ZZZ_MIS_UI.Reports.rptOglasiTotal.rdlc";
                DAOglasi.SelectOglasiTotal(dsOglasi.OglasiTotal);
                bindingSource.DataSource = dsOglasi.OglasiTotal;

                ReportDataSource rds = new ReportDataSource("OglasiTotal", bindingSource);
                reportViewer.LocalReport.DataSources.Add(rds);
            }
            else
            {
                reportViewer.LocalReport.ReportEmbeddedResource = "ZZZ_MIS_UI.Reports.rptOglasi.rdlc";
                
                DAOglasi.GetOglasiByDatumIOblast(dsOglasi.PosaoOglasi, datumOd, datumDo, oblastId);
                bindingSource.DataSource = dsOglasi.PosaoOglasi;

                ReportDataSource rds = new ReportDataSource("Oglasi", bindingSource);
                reportViewer.LocalReport.DataSources.Add(rds);
                reportViewer.LocalReport.SetParameters(new ReportParameter("datumOd", datumOd.ToShortDateString()));
                reportViewer.LocalReport.SetParameters(new ReportParameter("datumDo", datumDo.ToShortDateString()));
                reportViewer.LocalReport.SetParameters(new ReportParameter("Oblast", oblastId.ToString()));
            }

            this.reportViewer.RefreshReport();
        }
    }
}
