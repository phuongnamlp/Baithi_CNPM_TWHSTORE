using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using TrangChu;
using TrangChu.Models;

namespace TrangChu.VIEW
{
    public partial class FormDangKi : DevExpress.XtraEditors.XtraForm
    {
        ConnectSQL con = new ConnectSQL();
        Model_TWHSTORE TWHContext = new Model_TWHSTORE();
        public FormDangKi()
        {
            InitializeComponent();
        }

        private void DangKi_Load(object sender, EventArgs e)
        {
            List<QUYEN> listQUYEN = TWHContext.QUYENs.ToList();
            FillDataToComboBox(listQUYEN);
            List<USER> listUSERS = TWHContext.USERS.ToList();
            BindingDataFromListToDataGridView(listUSERS);
            dgvDK.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void BindingDataFromListToDataGridView(List<USER> listUSERS)
        {
            dgvDK.Rows.Clear();
            for (int i = 0; i < listUSERS.Count; i++)
            {
                int index = dgvDK.Rows.Add();
                dgvDK.Rows[index].Cells[0].Value = listUSERS[i].TAIKHOAN;
                dgvDK.Rows[index].Cells[1].Value = listUSERS[i].MATKHAU;
                dgvDK.Rows[index].Cells[2].Value = listUSERS[i].MANV;
                dgvDK.Rows[index].Cells[3].Value = listUSERS[i].QUYEN.TENQUYEN;

            }
        }

        private void FillDataToComboBox(List<QUYEN> listQUYEN)
        {
            cbb_Quyen.DataSource = listQUYEN;
            cbb_Quyen.DisplayMember = "TENQUYEN";
            cbb_Quyen.ValueMember = "IDQUYEN";
        }

        private bool ValidateData()// hàm kiểm tra rỗng
        {

            if (string.IsNullOrWhiteSpace(txtTenDangNhapDK.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMatKhauDK.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNhapMNV.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateData())
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin !");
                }
                else
                {
                    USER uSER = new USER();
                    USER uSER1 = TWHContext.USERS.FirstOrDefault(s => s.TAIKHOAN.ToString().CompareTo(txtTenDangNhapDK.Text) == 0);
                    if (uSER1 == null)
                    {
                        // nhập dữ liệu 
                        uSER.TAIKHOAN = txtTenDangNhapDK.Text;
                        uSER.MATKHAU = txtMatKhauDK.Text;
                        uSER.MANV = txtNhapMNV.Text;
                        uSER.IDQUYEN = int.Parse(cbb_Quyen.SelectedIndex.ToString());
                        TWHContext.USERS.Add(uSER);
                        TWHContext.SaveChanges();
                        BindingDataFromListToDataGridView(TWHContext.USERS.ToList());
                        MessageBox.Show("Đăng kí tài khoản thành công !");
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản tồn tại !");

                    }
                }
                txtTenDangNhapDK.Clear();
                txtMatKhauDK.Clear();
                txtNhapMNV.Clear();

            }
            catch (Exception)
            {
                MessageBox.Show("Có Lỗi Xảy Ra");
            }
        }

        private void btnCancelDK_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            USER uSER = TWHContext.USERS.FirstOrDefault(
                    s => s.TAIKHOAN.CompareTo(txtTenDangNhapDK.Text) == 0);
            if (uSER != null)
            {
                uSER.MATKHAU = txtMatKhauDK.Text;
                uSER.MANV = txtNhapMNV.Text;

                TWHContext.SaveChanges();
                BindingDataFromListToDataGridView(TWHContext.USERS.ToList());

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDK.SelectedRows.Count > 0)
            {
                string us = dgvDK.SelectedRows[0].Cells[0].Value.ToString();
                USER us1 = TWHContext.USERS.FirstOrDefault(
                    s => s.TAIKHOAN.ToString().CompareTo(us) == 0);
                TWHContext.USERS.Remove(us1);
                TWHContext.SaveChanges();
                BindingDataFromListToDataGridView(TWHContext.USERS.ToList());
                MessageBox.Show("Xóa thông tin thành công !");
            }

        }

        private void dgvDK_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDK.SelectedRows.Count > 0)
            {
                if (dgvDK.SelectedRows[0].Cells[0].Value != null)
                {
                    if (dgvDK.SelectedRows[0].Cells[2].Value != null)
                    {
                        txtTenDangNhapDK.Text = dgvDK.SelectedRows[0].Cells[0].Value.ToString();
                        txtMatKhauDK.Text = dgvDK.SelectedRows[0].Cells[1].Value.ToString();
                        txtNhapMNV.Text = dgvDK.SelectedRows[0].Cells[2].Value.ToString();
                        cbb_Quyen.SelectedIndex = cbb_Quyen.FindStringExact(dgvDK.SelectedRows[0].Cells[3].Value.ToString());
                    }
                }
            }
        }
    }
}