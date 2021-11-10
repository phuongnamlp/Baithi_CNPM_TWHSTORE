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
using System.Data.SqlClient;
using TrangChu.Models;

namespace TrangChu.VIEW
{
    public partial class FormQLNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        ConnectSQL con = new ConnectSQL();
        Model_TWHSTORE TWHContext;
        public FormQLNhaCungCap()
        {
            InitializeComponent();
            TWHContext = new Model_TWHSTORE();
        }

        

        private void FormQLNCC_Load(object sender, EventArgs e)
        {
            List<THONGTIN_NHACUNGCAP> listTT = TWHContext.THONGTIN_NHACUNGCAP.ToList();
            BindingDataFromListToDataGridView(listTT);
            dgvNCC.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void BindingDataFromListToDataGridView(List<THONGTIN_NHACUNGCAP> listTT)
        {
            dgvNCC.Rows.Clear();
            for (int i = 0; i < listTT.Count; i++)
            {
                int index = dgvNCC.Rows.Add();
                dgvNCC.Rows[index].Cells[0].Value = listTT[i].MANCC;
                dgvNCC.Rows[index].Cells[1].Value = listTT[i].TENNCC;
                dgvNCC.Rows[index].Cells[2].Value = listTT[i].SDT;
                dgvNCC.Rows[index].Cells[3].Value = listTT[i].EMAIL;
                dgvNCC.Rows[index].Cells[4].Value = listTT[i].DIACHI;
                dgvNCC.Rows[index].Cells[5].Value = listTT[i].LOAIHANG;
            }
        }
        private bool ValidateData()// hàm kiểm tra rỗng
        {

            if (string.IsNullOrWhiteSpace(txtMaNCC.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTenNCC.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSoDT.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtLoai.Text))
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
                    THONGTIN_NHACUNGCAP TTNCC = new THONGTIN_NHACUNGCAP();
                    THONGTIN_NHACUNGCAP TTNCC1 = TWHContext.THONGTIN_NHACUNGCAP.FirstOrDefault(s => s.MANCC.ToString().CompareTo(txtMaNCC.Text) == 0);
                    if (TTNCC1 == null)
                    {
                        // nhập dữ liệu 
                        TTNCC.MANCC = txtMaNCC.Text;
                        TTNCC.TENNCC = txtTenNCC.Text;
                        TTNCC.SDT = txtSoDT.Text;
                        TTNCC.EMAIL = txtEmail.Text;
                        TTNCC.DIACHI = txtDiaChi.Text;
                        TTNCC.LOAIHANG = txtLoai.Text;

                        TWHContext.THONGTIN_NHACUNGCAP.Add(TTNCC);
                        TWHContext.SaveChanges();
                        BindingDataFromListToDataGridView(TWHContext.THONGTIN_NHACUNGCAP.ToList());
                        MessageBox.Show("Thêm thông tin nhà cung cấp thành công !");
                    }
                    else
                    {
                        MessageBox.Show("Thông tin nhà cung cấp đã tồn tại !");
                    }
                }
                txtMaNCC.Clear();
                txtTenNCC.Clear();
                txtSoDT.Clear();
                txtEmail.Clear();
                txtDiaChi.Clear();
                txtLoai.Clear();
            }

            catch (Exception)
            {
                MessageBox.Show("Có Lỗi Xảy Ra");
            }
}

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNCC.SelectedRows.Count > 0)
            {
                string MaNCC = dgvNCC.SelectedRows[0].Cells[0].Value.ToString();
                THONGTIN_NHACUNGCAP ttncc = TWHContext.THONGTIN_NHACUNGCAP.FirstOrDefault(
                    s => s.MANCC.ToString().CompareTo(MaNCC) == 0);
                TWHContext.THONGTIN_NHACUNGCAP.Remove(ttncc);
                TWHContext.SaveChanges();
                BindingDataFromListToDataGridView(TWHContext.THONGTIN_NHACUNGCAP.ToList());
                MessageBox.Show("Xóa thông tin thành công !");
            }
            txtMaNCC.Clear();
            txtTenNCC.Clear();
            txtSoDT.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
            txtLoai.Clear();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            THONGTIN_NHACUNGCAP ncc = TWHContext.THONGTIN_NHACUNGCAP.FirstOrDefault(
                    s => s.MANCC.CompareTo(txtMaNCC.Text) == 0);
            if (ncc != null)
            {
               
                ncc.TENNCC = txtTenNCC.Text;
                ncc.SDT = txtSoDT.Text;
                ncc.EMAIL = txtEmail.Text;
                ncc.DIACHI = txtDiaChi.Text;
                ncc.LOAIHANG = txtLoai.Text;

                TWHContext.SaveChanges();
                MessageBox.Show("Cập nhật thành công");
                BindingDataFromListToDataGridView(TWHContext.THONGTIN_NHACUNGCAP.ToList());
            }
            else
            {
                MessageBox.Show("Nhà cung cấp không tồn tại không tồn tại");
            }
            txtMaNCC.Clear();
            txtTenNCC.Clear();
            txtSoDT.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
            txtLoai.Clear();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvNCC_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNCC.SelectedRows.Count > 0)
            {
                if (dgvNCC.SelectedRows[0].Cells[0].Value != null)
                {
                    if (dgvNCC.SelectedRows[0].Cells[2].Value != null)
                    {
                        txtMaNCC.Text = dgvNCC.SelectedRows[0].Cells[0].Value.ToString();
                        txtTenNCC.Text = dgvNCC.SelectedRows[0].Cells[1].Value.ToString();
                        txtSoDT.Text = dgvNCC.SelectedRows[0].Cells[2].Value.ToString();
                        txtEmail.Text = dgvNCC.SelectedRows[0].Cells[3].Value.ToString();
                        txtDiaChi.Text = dgvNCC.SelectedRows[0].Cells[4].Value.ToString();
                        txtLoai.Text = dgvNCC.SelectedRows[0].Cells[5].Value.ToString();
                    }
                }
            }
        }
    }
}