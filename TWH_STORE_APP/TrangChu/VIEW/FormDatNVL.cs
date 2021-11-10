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
    public partial class FormDatNVL : DevExpress.XtraEditors.XtraForm
    {
        ConnectSQL con = new ConnectSQL();
        Model_TWHSTORE TWHContext;
        public FormDatNVL()
        {
            InitializeComponent();
            TWHContext = new Model_TWHSTORE();
        }

        private void FormDatNVL_Load(object sender, EventArgs e)
        {
            reportViewerDNVL.Visible = false;
            dgvDNVL.Visible = true;
            List<THONGTIN_NHACUNGCAP> ttncc = TWHContext.THONGTIN_NHACUNGCAP.ToList();
            FillDataToComboBox(ttncc);
            List<DANHSACHCANNHAP_NVL> listTT = TWHContext.DANHSACHCANNHAP_NVL.ToList();
            BindingDataFromListToDataGridView(listTT);
            dgvDNVL.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.reportViewerDNVL.RefreshReport();
        }

        private void FillDataToComboBox(List<THONGTIN_NHACUNGCAP> ttncc)
        {
            ccbNCC.DataSource = ttncc;
            ccbNCC.DisplayMember = "TENNCC";
            ccbNCC.ValueMember = "MANCC";
        }

        private void BindingDataFromListToDataGridView(List<DANHSACHCANNHAP_NVL> listTT)
        {
            dgvDNVL.Rows.Clear();
            for (int i = 0; i < listTT.Count; i++)
            {
                int index = dgvDNVL.Rows.Add();
                dgvDNVL.Rows[index].Cells[0].Value = listTT[i].IDLOAI;
                dgvDNVL.Rows[index].Cells[1].Value = listTT[i].MANVL;
                dgvDNVL.Rows[index].Cells[2].Value = listTT[i].LOAIHANG;
                dgvDNVL.Rows[index].Cells[3].Value = listTT[i].SOLUONG;
                dgvDNVL.Rows[index].Cells[4].Value = listTT[i].THONGTIN_NHACUNGCAP.TENNCC;
            }
        }

        private bool ValidateData()
        {

            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMaNVL.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtLoaiHang.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSoLuong.Text))
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
                    DANHSACHCANNHAP_NVL NVL = new DANHSACHCANNHAP_NVL();
                    DANHSACHCANNHAP_NVL NVL1 = TWHContext.DANHSACHCANNHAP_NVL.FirstOrDefault(s => s.MANVL.ToString().CompareTo(txtMaNVL.Text) == 0);
                    if (NVL1 == null)
                    {
                        // nhập dữ liệu 
                        NVL.IDLOAI = int.Parse(txtID.Text);
                        NVL.MANVL = txtMaNVL.Text;
                        NVL.LOAIHANG = txtLoaiHang.Text;
                        NVL.SOLUONG = int.Parse(txtSoLuong.Text);
                        NVL.MANCC = ccbNCC.SelectedValue.ToString();


                        TWHContext.DANHSACHCANNHAP_NVL.Add(NVL);
                        TWHContext.SaveChanges();
                        BindingDataFromListToDataGridView(TWHContext.DANHSACHCANNHAP_NVL.ToList());
                        MessageBox.Show("Thêm thông tin danh sách đặt nguyên vật liệu thành công !");
                    }
                    else
                    {
                        MessageBox.Show("Nguyên vật liệu đã tồn tại !");
                    }
                }
                txtID.Clear();
                txtMaNVL.Clear();
                txtSoLuong.Clear();
                txtLoaiHang.Clear();

            }
                catch (Exception)
                {
                    MessageBox.Show("Có Lỗi Xảy Ra");
                }
} 

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDNVL.SelectedRows.Count > 0)
            {
                string id = dgvDNVL.SelectedRows[0].Cells[0].Value.ToString();
                DANHSACHCANNHAP_NVL id1 = TWHContext.DANHSACHCANNHAP_NVL.FirstOrDefault(
                    s => s.IDLOAI.ToString().CompareTo(id) == 0);
                TWHContext.DANHSACHCANNHAP_NVL.Remove(id1);
                TWHContext.SaveChanges();
                BindingDataFromListToDataGridView(TWHContext.DANHSACHCANNHAP_NVL.ToList());
                MessageBox.Show("Xóa thông tin thành công !");
            }
            else
            {
                MessageBox.Show("Bạn cần phải xóa loại nguyên vật liệu đó bên chức năng quản lý trước !");
            }
            txtID.Clear();
            txtMaNVL.Clear();
            txtSoLuong.Clear();
            txtLoaiHang.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DANHSACHCANNHAP_NVL dnvl = TWHContext.DANHSACHCANNHAP_NVL.FirstOrDefault(
                   s => s.MANVL.CompareTo(txtMaNVL.Text) == 0);
            if (dnvl != null)
            {
                dnvl.LOAIHANG = txtLoaiHang.Text;
                dnvl.SOLUONG = int.Parse(txtSoLuong.Text);
                dnvl.MANCC = ccbNCC.SelectedValue.ToString();

                TWHContext.SaveChanges();
                BindingDataFromListToDataGridView(TWHContext.DANHSACHCANNHAP_NVL.ToList());
            }
            else
            {
                MessageBox.Show("Nguyên vật liệu không tồn tại");
            }
            txtID.Clear();
            txtMaNVL.Clear();
            txtSoLuong.Clear();
            txtLoaiHang.Clear();
        }

        private void dgvDNVL_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDNVL.SelectedRows.Count > 0)
            {
                if (dgvDNVL.SelectedRows[0].Cells[0].Value != null)
                {
                    if (dgvDNVL.SelectedRows[0].Cells[2].Value != null)
                    {
                        txtID.Text = dgvDNVL.SelectedRows[0].Cells[0].Value.ToString();
                        txtMaNVL.Text = dgvDNVL.SelectedRows[0].Cells[1].Value.ToString();
                        txtLoaiHang.Text = dgvDNVL.SelectedRows[0].Cells[2].Value.ToString();
                        txtSoLuong.Text = dgvDNVL.SelectedRows[0].Cells[3].Value.ToString();
                        ccbNCC.SelectedIndex = ccbNCC.FindStringExact(dgvDNVL.SelectedRows[0].Cells[4].Value.ToString());
                    }
                }
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            dgvDNVL.Visible = false;
            reportViewerDNVL.Visible = true;
            List<DANHSACHCANNHAP_NVL> listNVL = TWHContext.DANHSACHCANNHAP_NVL.ToList();
            this.reportViewerDNVL.LocalReport.ReportPath = "ReportDNVL.rdlc";
            var reportDataSource = new ReportDataSource("DataSetDNVL", TWHContext.DANHSACHCANNHAP_NVL.ToList());
            this.reportViewerDNVL.LocalReport.DataSources.Clear();
            this.reportViewerDNVL.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewerDNVL.RefreshReport();
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            reportViewerDNVL.Visible = false;
            dgvDNVL.Visible = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}