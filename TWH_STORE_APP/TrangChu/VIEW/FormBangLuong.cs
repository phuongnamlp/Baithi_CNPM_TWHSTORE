using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using TrangChu.Models;
using TrangChu.VIEW;


namespace TrangChu.VIEW
{
    public partial class FormBangLuong : Form
    {
        ConnectSQL con = new ConnectSQL();
        Model_TWHSTORE TWHContext;
        public FormBangLuong()
        {
            InitializeComponent();
            TWHContext = new Model_TWHSTORE();
        }

        private void FormBangLuong_Load(object sender, EventArgs e)
        {
            List<BANGLUONG> listBangLuong = TWHContext.BANGLUONGs.ToList();
            BindingDataFromListToDataGridView(listBangLuong);
            dgvBangLuong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void BindingDataFromListToDataGridView(List<BANGLUONG> listBangLuong)
        {
            dgvBangLuong.Rows.Clear();
            for (int i = 0; i < listBangLuong.Count; i++)
            {
                int index = dgvBangLuong.Rows.Add();
                dgvBangLuong.Rows[index].Cells[0].Value = listBangLuong[i].MABANGLUONG;
                dgvBangLuong.Rows[index].Cells[1].Value = listBangLuong[i].MANV;
                dgvBangLuong.Rows[index].Cells[2].Value = listBangLuong[i].TENNV;
                dgvBangLuong.Rows[index].Cells[3].Value = listBangLuong[i].TongNgayLam;
                dgvBangLuong.Rows[index].Cells[4].Value = listBangLuong[i].TongNgayVang;
                dgvBangLuong.Rows[index].Cells[5].Value = listBangLuong[i].TIENLUONG;
                dgvBangLuong.Rows[index].Cells[6].Value = listBangLuong[i].LUONGTHUONG;
                dgvBangLuong.Rows[index].Cells[7].Value = listBangLuong[i].TONGLUONG;
            }
        }

        private bool ValidateData()// hàm kiểm tra rỗng
        {

            if (string.IsNullOrWhiteSpace(txtMBL.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMNV.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtHoten.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTongNgayLam.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTongNgayVang.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTienLuong.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtLuongThuong.Text))
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
                    BANGLUONG BL = new BANGLUONG();
                    BANGLUONG BL1 = TWHContext.BANGLUONGs.FirstOrDefault(s => s.MABANGLUONG.ToString().CompareTo(txtMBL.Text) == 0);
                    if (BL1 == null)
                    {
                        // nhập dữ liệu 
                        BL.MABANGLUONG = txtMBL.Text;
                        BL.MANV = txtMNV.Text;
                        BL.TENNV = txtHoten.Text;
                        BL.TongNgayLam = int.Parse(txtTongNgayLam.Text);
                        BL.TongNgayVang = int.Parse(txtTongNgayVang.Text);
                        BL.TIENLUONG = int.Parse(txtTienLuong.Text);
                        BL.LUONGTHUONG = int.Parse(txtLuongThuong.Text);
                        BL.TONGLUONG = int.Parse(txtTongLuong.Text);

                        TWHContext.BANGLUONGs.Add(BL);
                        TWHContext.SaveChanges();
                        BindingDataFromListToDataGridView(TWHContext.BANGLUONGs.ToList());
                        MessageBox.Show("Thêm thông tin lương nhân viên thành công !");
                    }
                    else
                    {
                        MessageBox.Show("Thông tin đã tồn tại !");
                    }
                }
                txtMBL.Clear();
                txtMNV.Clear();
                txtHoten.Clear();
                txtTongNgayLam.Clear();
                txtTongNgayVang.Clear();
                txtTienLuong.Clear();
                txtLuongThuong.Clear();
                txtTongLuong.Clear();

            }
            catch (Exception)
            {
                MessageBox.Show("Có Lỗi Xảy Ra");
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            BANGLUONG bangluong = TWHContext.BANGLUONGs.FirstOrDefault(
                    s => s.MABANGLUONG.CompareTo(txtMBL.Text) == 0);
            if (bangluong != null)
            {
                bangluong.MANV = txtMNV.Text;
                bangluong.TENNV = txtHoten.Text;
                bangluong.TongNgayLam = int.Parse(txtTongNgayLam.Text);
                bangluong.TongNgayVang = int.Parse(txtTongNgayVang.Text);
                bangluong.TIENLUONG = int.Parse(txtTienLuong.Text);
                bangluong.LUONGTHUONG = int.Parse(txtLuongThuong.Text);
                bangluong.TONGLUONG = int.Parse(txtTongLuong.Text);

                TWHContext.SaveChanges();
                BindingDataFromListToDataGridView(TWHContext.BANGLUONGs.ToList());
            }
            else
            {
                MessageBox.Show("Sinh viên không tồn tại");
            }
            txtMBL.Clear();
            txtMNV.Clear();
            txtHoten.Clear();
            txtTongNgayLam.Clear();
            txtTongNgayVang.Clear();
            txtTienLuong.Clear();
            txtLuongThuong.Clear();
            txtTongLuong.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvBangLuong.SelectedRows.Count > 0)
            {
                string BL = dgvBangLuong.SelectedRows[0].Cells[0].Value.ToString();
                BANGLUONG BL1 = TWHContext.BANGLUONGs.FirstOrDefault(
                    s => s.MABANGLUONG.ToString().CompareTo(BL) == 0);
                TWHContext.BANGLUONGs.Remove(BL1);
                TWHContext.SaveChanges();
                BindingDataFromListToDataGridView(TWHContext.BANGLUONGs.ToList());
                MessageBox.Show("Xóa thông tin thành công !");
            }
            txtMBL.Clear();
            txtMNV.Clear();
            txtHoten.Clear();
            txtTongNgayLam.Clear();
            txtTongNgayVang.Clear();
            txtTienLuong.Clear();
            txtLuongThuong.Clear();
            txtTongLuong.Clear();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            FormReportBangLuong formReportBangLuong = new FormReportBangLuong();
            formReportBangLuong.ShowDialog();
        }

        private void dgvBangLuong_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvBangLuong.SelectedRows.Count > 0)
                {
                    if (dgvBangLuong.SelectedRows[0].Cells[0].Value != null)
                    {
                        if (dgvBangLuong.SelectedRows[0].Cells[2].Value != null)
                        {
                            txtMBL.Text = dgvBangLuong.SelectedRows[0].Cells[0].Value.ToString();
                            txtMNV.Text = dgvBangLuong.SelectedRows[0].Cells[1].Value.ToString();
                            txtHoten.Text = dgvBangLuong.SelectedRows[0].Cells[2].Value.ToString();
                            txtTongNgayLam.Text = dgvBangLuong.SelectedRows[0].Cells[3].Value.ToString();
                            txtTongNgayVang.Text = dgvBangLuong.SelectedRows[0].Cells[4].Value.ToString();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Có thể bạn nhập thiếu dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

    }
}
