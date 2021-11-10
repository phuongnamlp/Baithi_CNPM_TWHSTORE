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
    public partial class FormQLNguyenVatLieu : Form
    {
        ConnectSQL con = new ConnectSQL();
        Model_TWHSTORE TWHContext;

        public FormQLNguyenVatLieu()
        {
            InitializeComponent();
            TWHContext = new Model_TWHSTORE();
        }
       
        private void FormQLNguyenVatLieu_Load(object sender, EventArgs e)
        {
            List<DANHSACH_NVL> danhsachNVL = TWHContext.DANHSACH_NVL.ToList();
            BindingDataFromListToDataGridView(danhsachNVL);
            dgvQLDSNVL.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void BindingDataFromListToDataGridView(List<DANHSACH_NVL> danhsachNVl)
        {
            dgvQLDSNVL.Rows.Clear();
            for (int i = 0; i < danhsachNVl.Count; i++)
            {
                int index = dgvQLDSNVL.Rows.Add();
                dgvQLDSNVL.Rows[index].Cells[0].Value = danhsachNVl[i].MANVL;
                dgvQLDSNVL.Rows[index].Cells[1].Value = danhsachNVl[i].TENNVL;
                dgvQLDSNVL.Rows[index].Cells[2].Value = danhsachNVl[i].LOAI;
                dgvQLDSNVL.Rows[index].Cells[3].Value = danhsachNVl[i].NGAYSX;
                dgvQLDSNVL.Rows[index].Cells[4].Value = danhsachNVl[i].NGAYHH;
            }
        }

        private void dgvQLDSNVL_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvQLDSNVL.SelectedRows.Count > 0)
            {
                if (dgvQLDSNVL.SelectedRows[0].Cells[0].Value != null)
                {
                    if (dgvQLDSNVL.SelectedRows[0].Cells[2].Value != null)
                    {
                        txtNVL.Text = dgvQLDSNVL.SelectedRows[0].Cells[0].Value.ToString();
                        txtTenNVL.Text = dgvQLDSNVL.SelectedRows[0].Cells[1].Value.ToString();
                        txtLoai.Text = dgvQLDSNVL.SelectedRows[0].Cells[2].Value.ToString();
                        dtpSX.Value = DateTime.Parse((dgvQLDSNVL.SelectedRows[0].Cells[3].Value.ToString()));
                        dtpHH.Value = DateTime.Parse((dgvQLDSNVL.SelectedRows[0].Cells[4].Value.ToString()));
                    }
                }
            }
        }

        private bool ValidateData()
        {

            if (string.IsNullOrWhiteSpace(txtNVL.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTenNVL.Text))
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
                    DANHSACH_NVL danhsachNVL = new DANHSACH_NVL();
                    DANHSACH_NVL danhsachNVL1 = TWHContext.DANHSACH_NVL.FirstOrDefault(s => s.MANVL.ToString().CompareTo(txtNVL.Text) == 0);
                    if (danhsachNVL1 == null)
                    {
                        // nhập dữ liệu 
                        danhsachNVL.MANVL = txtNVL.Text;
                        danhsachNVL.TENNVL = txtTenNVL.Text;
                        danhsachNVL.LOAI = txtLoai.Text;
                        danhsachNVL.NGAYSX = dtpSX.Value;
                        danhsachNVL.NGAYHH = dtpHH.Value;

                        TWHContext.DANHSACH_NVL.Add(danhsachNVL);
                        TWHContext.SaveChanges();
                        BindingDataFromListToDataGridView(TWHContext.DANHSACH_NVL.ToList());
                        MessageBox.Show("Thêm thông tin nguyên vật liệu thành công !");
                    }
                    else
                    {
                        MessageBox.Show("Thông tin đã tồn tại !");
                    }
                }

                txtNVL.Clear();
                txtTenNVL.Clear();
                txtLoai.Clear();

            }
            catch (Exception)
            {
                MessageBox.Show("!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DANHSACH_NVL ds = TWHContext.DANHSACH_NVL.FirstOrDefault(
                    s => s.MANVL.CompareTo(txtNVL.Text) == 0);
            if (ds != null)
            {
                ds.TENNVL= txtTenNVL.Text;
                ds.LOAI = txtLoai.Text;
                ds.NGAYSX = dtpSX.Value;
                ds.NGAYHH = dtpHH.Value;

                TWHContext.SaveChanges();
                BindingDataFromListToDataGridView(TWHContext.DANHSACH_NVL.ToList());
                MessageBox.Show("Cập nhật thông tin thành công");

            }
            else
            {
                MessageBox.Show("Thông tin không tồn tại");
            }

            txtNVL.Clear();
            txtTenNVL.Clear();
            txtLoai.Clear();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvQLDSNVL.SelectedRows.Count > 0)
                {
                    string ds = dgvQLDSNVL.SelectedRows[0].Cells[0].Value.ToString();
                    DANHSACH_NVL ds1 = TWHContext.DANHSACH_NVL.FirstOrDefault(
                        s => s.MANVL.ToString().CompareTo(ds) == 0);
                    TWHContext.DANHSACH_NVL.Remove(ds1);
                    TWHContext.SaveChanges();
                    BindingDataFromListToDataGridView(TWHContext.DANHSACH_NVL.ToList());
                    MessageBox.Show("Xóa thông tin thành công !");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn phải xóa nguyên vật liệu này trong danh sách đặt hàng trước");
            }
            

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
