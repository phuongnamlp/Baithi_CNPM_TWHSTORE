using DevExpress.XtraEditors;
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
using Microsoft.Reporting.WinForms;

namespace TrangChu.VIEW
{
    public partial class FormPhiDichVu : DevExpress.XtraEditors.XtraForm
    {
       
        ConnectSQL con = new ConnectSQL();
        Model_TWHSTORE TWHContext;
        public FormPhiDichVu()
        {
            InitializeComponent();
            TWHContext = new Model_TWHSTORE();
        }

        private void FormPhiDV_Load(object sender, EventArgs e)
        {
            reportViewer2.Visible = false;
            dgvDV.Visible = true;
            List<PHIDICHVU> listTT = TWHContext.PHIDICHVUs.ToList();
            BindingDataFromListToDataGridView(listTT);
            dgvDV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.reportViewer2.RefreshReport();
        }
        private void BindingDataFromListToDataGridView(List<PHIDICHVU> listTT)
        {
            dgvDV.Rows.Clear();
            for (int i = 0; i < listTT.Count; i++)
            {
                int index = dgvDV.Rows.Add();
                dgvDV.Rows[index].Cells[0].Value = listTT[i].MAPHIEUDV;
                dgvDV.Rows[index].Cells[1].Value = listTT[i].NOIDUNG;
                dgvDV.Rows[index].Cells[2].Value = listTT[i].CHIPHI;
            }
        }
        private bool ValidateData()
        {

            if (string.IsNullOrWhiteSpace(txtMaDV.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNoiDung.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtChiPhi.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateData())
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin !");
                }
                else
                {
                    PHIDICHVU DV = new PHIDICHVU();
                    PHIDICHVU DV1 = TWHContext.PHIDICHVUs.FirstOrDefault(s => s.MAPHIEUDV.ToString().CompareTo(txtMaDV.Text) == 0);
                    if (DV1 == null)
                    {
                        // nhập dữ liệu 
                        DV.MAPHIEUDV = txtMaDV.Text;
                        DV.NOIDUNG = txtNoiDung.Text;
                        DV.CHIPHI = int.Parse(txtChiPhi.Text);

                        TWHContext.PHIDICHVUs.Add(DV);
                        TWHContext.SaveChanges();
                        BindingDataFromListToDataGridView(TWHContext.PHIDICHVUs.ToList());
                        MessageBox.Show("Thêm thông tin phí dịch vụ thành công !");
                    }
                    else
                    {
                        MessageBox.Show("Thông tin phí đã tồn tại !");
                    }
                }
                txtMaDV.Clear();
                txtNoiDung.Clear();
                txtChiPhi.Clear();

            }
            catch (Exception)
            {
                MessageBox.Show("Có Lỗi Xảy Ra");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDV.SelectedRows.Count > 0)
            {
                string MaDV = dgvDV.SelectedRows[0].Cells[0].Value.ToString();
                PHIDICHVU ttdv = TWHContext.PHIDICHVUs.FirstOrDefault(
                    s => s.MAPHIEUDV.ToString().CompareTo(MaDV) == 0);
                TWHContext.PHIDICHVUs.Remove(ttdv);
                TWHContext.SaveChanges();
                BindingDataFromListToDataGridView(TWHContext.PHIDICHVUs.ToList());
                MessageBox.Show("Xóa thông tin thành công !");
            }
            txtMaDV.Clear();
            txtNoiDung.Clear();
            txtChiPhi.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            PHIDICHVU dv = TWHContext.PHIDICHVUs.FirstOrDefault(
                   s => s.MAPHIEUDV.CompareTo(txtMaDV.Text) == 0);
            if (dv != null)
            {
                dv.MAPHIEUDV = txtMaDV.Text;
                dv.NOIDUNG = txtNoiDung.Text;
                dv.CHIPHI = int.Parse(txtChiPhi.Text);

                TWHContext.SaveChanges();
                BindingDataFromListToDataGridView(TWHContext.PHIDICHVUs.ToList());
            }
            else
            {
                MessageBox.Show("Phí không tồn tại");
            }
            txtMaDV.Clear();
            txtNoiDung.Clear();
            txtChiPhi.Clear();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            reportViewer2.Visible = false;
            dgvDV.Visible = true;
        }

        private void dgvDV_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDV.SelectedRows.Count > 0)
            {
                if (dgvDV.SelectedRows[0].Cells[0].Value != null)
                {
                    if (dgvDV.SelectedRows[0].Cells[2].Value != null)
                    {
                        txtMaDV.Text = dgvDV.SelectedRows[0].Cells[0].Value.ToString();
                        txtNoiDung.Text = dgvDV.SelectedRows[0].Cells[1].Value.ToString();
                        txtChiPhi.Text = dgvDV.SelectedRows[0].Cells[2].Value.ToString();
                    }
                }
            }


        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            dgvDV.Visible = false;
            reportViewer2.Visible = true;
            Model_TWHSTORE context = new Model_TWHSTORE();
            List<PHIDICHVU> listdichvu = context.PHIDICHVUs.ToList();
            this.reportViewer2.LocalReport.ReportPath = "ReportPDV.rdlc";
            var reportDataSource = new ReportDataSource("DataSetDV", TWHContext.PHIDICHVUs.ToList());
            this.reportViewer2.LocalReport.DataSources.Clear();
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer2.RefreshReport();
        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}