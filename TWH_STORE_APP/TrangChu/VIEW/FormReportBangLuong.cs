using DevExpress.XtraEditors;
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
using TrangChu.Models;

namespace TrangChu
{
    public partial class FormReportBangLuong : DevExpress.XtraEditors.XtraForm
    {
        Model_TWHSTORE TWHContext;
        public FormReportBangLuong()
        {
            InitializeComponent();
            TWHContext = new Model_TWHSTORE();
        }

        private void FormBangLuong_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportPath = "ReportBangLuong.rdlc";
            var reportDataSource = new ReportDataSource("DataSet_BangLuong", TWHContext.BANGLUONGs.ToList()); 
            this.reportViewer1.LocalReport.DataSources.Clear(); 
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}