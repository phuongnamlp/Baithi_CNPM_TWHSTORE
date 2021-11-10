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
    public partial class FormThemTT : DevExpress.XtraEditors.XtraForm
    {
        ConnectSQL con = new ConnectSQL();
        Model_TWHSTORE TWHContext;

        public FormThemTT()
        {
            InitializeComponent();
            TWHContext = new Model_TWHSTORE();
        }

        private void FormThemTT_Load(object sender, EventArgs e)
        {
            List<THONGTIN_NHANVIEN> listTT = TWHContext.THONGTIN_NHANVIEN.ToList();
            BindingDataFromListToDataGridView(listTT);
            dgvFormThemTT.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void BindingDataFromListToDataGridView(List<THONGTIN_NHANVIEN> listTT)
        {
            dgvFormThemTT.Rows.Clear();
            for (int i = 0; i < listTT.Count; i++)
            {
                int index = dgvFormThemTT.Rows.Add();
                dgvFormThemTT.Rows[index].Cells[0].Value = listTT[i].MANV;
                dgvFormThemTT.Rows[index].Cells[1].Value = listTT[i].TENNV;
                dgvFormThemTT.Rows[index].Cells[2].Value = listTT[i].GIOITINH;
                dgvFormThemTT.Rows[index].Cells[3].Value = listTT[i].NGAYSINH;
                dgvFormThemTT.Rows[index].Cells[4].Value = listTT[i].SDT;
                dgvFormThemTT.Rows[index].Cells[5].Value = listTT[i].DIACHI;
                dgvFormThemTT.Rows[index].Cells[6].Value = listTT[i].CHUCVU;
            }
        }

        private bool ValidateData()
        {

            if (string.IsNullOrWhiteSpace(txtNhapMNV.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNhapHoTen.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNhapSDT.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNhapDC.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNhapCV.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnThemTT_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateData())
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin !");
                }
                else
                {
                    THONGTIN_NHANVIEN TTNV = new THONGTIN_NHANVIEN();
                    THONGTIN_NHANVIEN TTNV1 = TWHContext.THONGTIN_NHANVIEN.FirstOrDefault(s => s.MANV.ToString().CompareTo(txtNhapMNV.Text) == 0);
                    if (TTNV1 == null)
                    {
                        // nhập dữ liệu 
                        TTNV.MANV = txtNhapMNV.Text;
                        TTNV.TENNV = txtNhapHoTen.Text;
                        string gioitinh;
                        if (radioButton1.Checked)
                        {
                            gioitinh = "Nam";
                        }
                        else
                        {
                            gioitinh = "Nữ";
                        }
                        TTNV.GIOITINH = gioitinh;
                        TTNV.NGAYSINH = dateTimePicker1.Value;
                        TTNV.SDT = txtNhapSDT.Text;
                        TTNV.DIACHI = txtNhapDC.Text;
                        TTNV.CHUCVU = txtNhapCV.Text;

                        TWHContext.THONGTIN_NHANVIEN.Add(TTNV);
                        TWHContext.SaveChanges();
                        BindingDataFromListToDataGridView(TWHContext.THONGTIN_NHANVIEN.ToList());
                        MessageBox.Show("Thêm thông tin nhân viên thành công !");
                    }
                    else
                    {
                        MessageBox.Show("Thông tin nhân viên đã tồn tại !");
                    }
                }
                txtNhapMNV.Clear();
                txtNhapHoTen.Clear();
                txtNhapSDT.Clear();
                txtNhapDC.Clear();
                txtNhapCV.Clear();

            }
            catch (Exception)
            {
                MessageBox.Show("Có Lỗi Xảy Ra");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvFormThemTT.SelectedRows.Count > 0)
                {
                    string MaNV = dgvFormThemTT.SelectedRows[0].Cells[0].Value.ToString();
                    THONGTIN_NHANVIEN ttnv = TWHContext.THONGTIN_NHANVIEN.FirstOrDefault(
                        s => s.MANV.ToString().CompareTo(MaNV) == 0);
                    TWHContext.THONGTIN_NHANVIEN.Remove(ttnv);
                    TWHContext.SaveChanges();
                    BindingDataFromListToDataGridView(TWHContext.THONGTIN_NHANVIEN.ToList());
                    MessageBox.Show("Xóa thông tin thành công !");
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra !");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng xóa thông tin tài khoản trước !");
            }

            txtNhapMNV.Clear();
            txtNhapHoTen.Clear();
            txtNhapSDT.Clear();
            txtNhapDC.Clear();
            txtNhapCV.Clear();
        }

        private void btnCancelTT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            THONGTIN_NHANVIEN ttnv = TWHContext.THONGTIN_NHANVIEN.FirstOrDefault(
                    s => s.MANV.CompareTo(txtNhapMNV.Text) == 0);
            if (ttnv != null)
            {
                ttnv.TENNV = txtNhapHoTen.Text;
                string gioitinh;
                if (radioButton1.Checked)
                {
                    gioitinh = "Nam";
                }
                else
                {
                    gioitinh = "Nữ";
                }
                ttnv.GIOITINH = gioitinh;
                ttnv.NGAYSINH = dateTimePicker1.Value;
                ttnv.SDT = txtNhapSDT.Text;
                ttnv.DIACHI = txtNhapDC.Text;
                ttnv.CHUCVU = txtNhapCV.Text;

                TWHContext.SaveChanges();
                BindingDataFromListToDataGridView(TWHContext.THONGTIN_NHANVIEN.ToList());
            }
            else
            {
                MessageBox.Show("Sinh viên không tồn tại");
            }

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            FormInDSNhanVien formInDSNhanVien = new FormInDSNhanVien();
            formInDSNhanVien.ShowDialog();
        }

        private void dgvFormThemTT_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFormThemTT.SelectedRows.Count > 0)
            {
                if (dgvFormThemTT.SelectedRows[0].Cells[0].Value != null)
                {
                    if (dgvFormThemTT.SelectedRows[0].Cells[2].Value != null)
                    {
                        txtNhapMNV.Text = dgvFormThemTT.SelectedRows[0].Cells[0].Value.ToString();
                        txtNhapHoTen.Text = dgvFormThemTT.SelectedRows[0].Cells[1].Value.ToString();
                        txtNhapSDT.Text = dgvFormThemTT.SelectedRows[0].Cells[4].Value.ToString();
                        txtNhapDC.Text = dgvFormThemTT.SelectedRows[0].Cells[5].Value.ToString();
                        txtNhapCV.Text = dgvFormThemTT.SelectedRows[0].Cells[6].Value.ToString();
                    }
                }
            }
        }
    }
}
