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

namespace TrangChu.VIEW
{
    public partial class FormQLMenu : DevExpress.XtraEditors.XtraForm
    {
        ConnectSQL con = new ConnectSQL();
        Model_TWHSTORE TWHContext;
        public FormQLMenu()
        {
            InitializeComponent();
            TWHContext = new Model_TWHSTORE();
        }


        private void FormQLMN_Load(object sender, EventArgs e)
        {
            List<SANPHAM> listTT = TWHContext.SANPHAMs.ToList();
            BindingDataFromListToDataGridView(listTT);
            dgvMN.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void BindingDataFromListToDataGridView(List<SANPHAM> listTT)
        {
            dgvMN.Rows.Clear();
            for (int i = 0; i < listTT.Count; i++)
            {
                int index = dgvMN.Rows.Add();
                dgvMN.Rows[index].Cells[0].Value = listTT[i].MAMON;
                dgvMN.Rows[index].Cells[1].Value = listTT[i].NAME;
                dgvMN.Rows[index].Cells[2].Value = listTT[i].GIA;
            }
        }
        private bool ValidateData()
        {

            if (string.IsNullOrWhiteSpace(txtMaMon.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTenMon.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtGiaTien.Text))
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
                    SANPHAM TTMN = new SANPHAM();
                    SANPHAM TTMN1 = TWHContext.SANPHAMs.FirstOrDefault(s => s.MAMON.ToString().CompareTo(txtMaMon.Text) == 0);
                    if (TTMN1 == null)
                    {
                        // nhập dữ liệu 
                        TTMN.MAMON = txtMaMon.Text;
                        TTMN.NAME = txtTenMon.Text;
                        TTMN.GIA = int.Parse(txtGiaTien.Text);

                        TWHContext.SANPHAMs.Add(TTMN);
                        TWHContext.SaveChanges();
                        BindingDataFromListToDataGridView(TWHContext.SANPHAMs.ToList());
                        MessageBox.Show("Thêm thông tin thức uống thành công !");
                    }
                    else
                    {
                        MessageBox.Show("Thông tin thức uống đã tồn tại !");
                    }
                }
                txtMaMon.Clear();
                txtTenMon.Clear();
                txtGiaTien.Clear();

            }
            catch (Exception)
            {
                MessageBox.Show("Có Lỗi Xảy Ra");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvMN.SelectedRows.Count > 0)
            {
                string MaM = dgvMN.SelectedRows[0].Cells[0].Value.ToString();
                SANPHAM ttmn = TWHContext.SANPHAMs.FirstOrDefault(
                    s => s.MAMON.ToString().CompareTo(MaM) == 0);
                TWHContext.SANPHAMs.Remove(ttmn);
                TWHContext.SaveChanges();
                BindingDataFromListToDataGridView(TWHContext.SANPHAMs.ToList());
                MessageBox.Show("Xóa thông tin thành công !");
            }
            txtMaMon.Clear();
            txtTenMon.Clear();
            txtGiaTien.Clear();
        }   

        private void btnSua_Click(object sender, EventArgs e)
        {
            SANPHAM menu = TWHContext.SANPHAMs.FirstOrDefault(
                    s => s.MAMON.CompareTo(txtMaMon.Text) == 0);
            if (menu != null)
            {
                menu.MAMON = txtMaMon.Text;
                menu.NAME = txtTenMon.Text;
                menu.GIA = int.Parse(txtGiaTien.Text);

                TWHContext.SaveChanges();
                BindingDataFromListToDataGridView(TWHContext.SANPHAMs.ToList());
            }
            else
            {
                MessageBox.Show("Thức uống không tồn tại");
            }
            txtMaMon.Clear();
            txtTenMon.Clear();
            txtGiaTien.Clear();


        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvMN_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMN.SelectedRows.Count > 0)
            {
                if (dgvMN.SelectedRows[0].Cells[0].Value != null)
                {
                    if (dgvMN.SelectedRows[0].Cells[2].Value != null)
                    {
                        txtMaMon.Text = dgvMN.SelectedRows[0].Cells[0].Value.ToString();
                        txtTenMon.Text = dgvMN.SelectedRows[0].Cells[1].Value.ToString();
                        txtGiaTien.Text = dgvMN.SelectedRows[0].Cells[2].Value.ToString();
                    }
                }
            }
        }
    }
}