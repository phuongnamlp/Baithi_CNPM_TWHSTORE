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
using TrangChu.Models;
using TrangChu.VIEW;


namespace TrangChu.VIEW
{

    public partial class FormGoiMon : DevExpress.XtraEditors.XtraForm
    {
        ConnectSQL con = new ConnectSQL();
        Model_TWHSTORE TWHContext;

        public FormGoiMon()
        {
            InitializeComponent();
            TWHContext = new Model_TWHSTORE();
            txtTongTien.ReadOnly = true;
            txtTongTien.Text = "0";
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            List<HoaDon> hoadons = TWHContext.HoaDons.ToList();
            BindingDataFromListToDataGridView(hoadons);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TongTien();
        }

        private void BindingDataFromListToDataGridView(List<HoaDon> hoaDons)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < hoaDons.Count; i++)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = hoaDons[i].SOBAN;
                dataGridView1.Rows[index].Cells[1].Value = hoaDons[i].TENMON;
                dataGridView1.Rows[index].Cells[2].Value = hoaDons[i].GIATIEN;
                dataGridView1.Rows[index].Cells[3].Value = hoaDons[i].TRANGTHAI;
            }
        }

        private void TongTien()
        {
            int tien = dataGridView1.Rows.Count;
            int sotien = 0;
            for (int i = 0; i < tien - 1; i++)
            {
                sotien += int.Parse(dataGridView1.Rows[i].Cells["gia"].Value.ToString());
            }
            txtTongTien.Text = sotien.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                HoaDon hoaDon = new HoaDon();
                hoaDon.SOBAN = txtSoBan.Text;
                hoaDon.TENMON = txtTenMon.Text;
                hoaDon.GIATIEN = int.Parse(txtGia.Text);
                string trangthai;
                if (radioButton1.Checked)
                {
                    trangthai = "Dùng tại quán";
                }
                else
                {
                    trangthai = "Mang đi";
                }
                hoaDon.TRANGTHAI = trangthai;

                TWHContext.HoaDons.Add(hoaDon);
                TWHContext.SaveChanges();
                BindingDataFromListToDataGridView(TWHContext.HoaDons.ToList());
                TongTien();
            }
            catch (Exception)
            {
                MessageBox.Show("!");
            }            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string hoadon = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                HoaDon hoadon1 = TWHContext.HoaDons.FirstOrDefault(
                    s => s.SOBAN.ToString().CompareTo(hoadon) == 0);
                TWHContext.HoaDons.Remove(hoadon1);
                TWHContext.SaveChanges();
                BindingDataFromListToDataGridView(TWHContext.HoaDons.ToList());
                MessageBox.Show("Xóa thông tin thành công !");
                TongTien();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            HoaDon hoaDon = TWHContext.HoaDons.FirstOrDefault(
                   s => s.SOBAN.CompareTo(txtSoBan.Text) == 0);
            if (hoaDon != null)
            {
                hoaDon.TENMON = txtTenMon.Text;
                hoaDon.GIATIEN = int.Parse(txtGia.Text);
                string trangthai;
                if (radioButton1.Checked)
                {
                    trangthai = "Dùng tại quán";
                }
                else
                {
                    trangthai = "Mang đi";
                }
                hoaDon.TRANGTHAI = trangthai;

                TWHContext.SaveChanges();
                MessageBox.Show("Sửa thành công !");
                BindingDataFromListToDataGridView(TWHContext.HoaDons.ToList());
                TongTien();
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            FormInHoaDon formInHoaDon = new FormInHoaDon();
            formInHoaDon.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.SelectedRows[0].Cells[0].Value != null)
                {
                    if (dataGridView1.SelectedRows[0].Cells[2].Value != null)
                    {
                        txtSoBan.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                        txtTenMon.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                        txtGia.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    }
                }
            }
        }
    }
}
