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

namespace TrangChu.VIEW
{
    public partial class FormInDSNhanVien : Form
    {
        Model_TWHSTORE TWHContext;
        public FormInDSNhanVien()
        {
            InitializeComponent();
            TWHContext = new Model_TWHSTORE();
        }

        private void FormInDSNhanVien_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportPath = "ReportDSNhanVien.rdlc";
            var reportDataSource = new ReportDataSource("DataSet_DSNV", TWHContext.THONGTIN_NHANVIEN.ToList()); //đúng
            this.reportViewer1.LocalReport.DataSources.Clear(); //clear
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
