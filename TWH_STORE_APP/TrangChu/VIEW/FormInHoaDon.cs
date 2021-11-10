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
    public partial class FormInHoaDon : Form
    {
        Model_TWHSTORE TWHSTORE;
        public FormInHoaDon()
        {
            InitializeComponent();
            TWHSTORE = new Model_TWHSTORE();
        }

        private void FormInHoaDon_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportPath = "ReportInHoaDon.rdlc";
            var reportDataSource = new ReportDataSource("DataSet1", TWHSTORE.HoaDons.ToList());
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
