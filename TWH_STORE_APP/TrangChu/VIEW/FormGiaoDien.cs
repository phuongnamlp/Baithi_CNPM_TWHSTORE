using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using TrangChu.VIEW;
using System.Data.SqlClient;
using TrangChu.Models;

namespace TrangChu
{
    public partial class RibbonForm1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        string taikhoan = "", matkhau = "", manv = "", quyen = "";
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=TWH_STORE;Integrated Security=True");
        bool IsThoat = true;
        Model_TWHSTORE TWHContext = new Model_TWHSTORE();
        public RibbonForm1()
        {
            InitializeComponent();
        }

        public RibbonForm1(string taikhoan , string matkhau , string manv , string quyen)
        {
            InitializeComponent();
            this.Taikhoan = taikhoan;
            this.Matkhau = matkhau;
            this.Manv = manv;
            this.Quyen = quyen;
        }

        public static string QUYEN;

        public string Taikhoan { get => taikhoan; set => taikhoan = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public string Manv { get => manv; set => manv = value; }
        public string Quyen { get => quyen; set => quyen = value; }

        private void RibbonForm1_Load(object sender, EventArgs e)
        {
            skin();
            this.rpvTrangChu.RefreshReport();
        }

        public void skin()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themse = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themse.LookAndFeel.SkinName = "";
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            IsThoat = false;
            this.Close();
            FormDangNhap formDangNhap = new FormDangNhap();
            formDangNhap.Show();
        }

        private void RibbonForm1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(IsThoat)
            Application.Exit();
        }

        private void btnNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            #region phân quyền
            if (Quyen == "1")
            {
                btnNhanVien.Enabled = true;
                FormThemTT formThemTT = new FormThemTT();
                formThemTT.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không được quyền truy cập vào chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnNhanVien.Enabled = false;
            }
            #endregion
        }


        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            MessageBox.Show("Vui lòng đánh x vào ca làm việc của bạn trên FORM GOOGLESHEET !!!");
            System.Diagnostics.Process.Start("https://docs.google.com/spreadsheets/d/1OfdumZCOlstFh30BPghiSEhH7PO8jN5DZmYzou-Hmgo/edit#gid=0");
        }

        private void btnLuong_ItemClick(object sender, ItemClickEventArgs e)
        {
            #region phân quyền
            if (Quyen == "1")
            {
                btnLuong.Enabled = true;
                FormBangLuong formBangLuong = new FormBangLuong();
                formBangLuong.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không được quyền truy cập vào chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnLuong.Enabled = false;
            }
            #endregion 
        }

        private void btnMenunuoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormGoiMon formGoiMon = new FormGoiMon();
            formGoiMon.ShowDialog();
        }

        private void btnNCC_ItemClick(object sender, ItemClickEventArgs e)
        {
            #region phân quyền
            if (Quyen == "1")
            {
                btnNCC.Enabled = true;
                FormQLNhaCungCap formQLNhaCungCap = new FormQLNhaCungCap();
                formQLNhaCungCap.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không được quyền truy cập vào chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnNCC.Enabled = false;
            }
            #endregion 
        }

        private void btnPhiDichVu_ItemClick(object sender, ItemClickEventArgs e)
        {
            #region phân quyền
            if (Quyen == "1")
            {
                btnPhiDichVu.Enabled = true;
                FormPhiDichVu formPhiDichVu = new FormPhiDichVu();
                formPhiDichVu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không được quyền truy cập vào chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnPhiDichVu.Enabled = false;
            }
            #endregion     
        }

        private void btnPhiPhatSinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            #region phân quyền
            if (Quyen == "1")
            {
                btnPhiPhatSinh.Enabled = true;
                FormPhiPhatSinh formPhiPhatSinh = new FormPhiPhatSinh();
                formPhiPhatSinh.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không được quyền truy cập vào chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnPhiPhatSinh.Enabled = false;
            }
            #endregion           
        }

        private void btnChinhSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            #region phân quyền
            if (Quyen == "1")
            {
                btnChinhSua.Enabled = true;
                FormQLMenu formQLMenu = new FormQLMenu();
                formQLMenu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không được quyền truy cập vào chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnChinhSua.Enabled = false;
            }
            #endregion 
        }

        private void btnDatNVL_ItemClick(object sender, ItemClickEventArgs e)
        {
            #region phân quyền
            if (Quyen == "1")
            {
                btnDatNVL.Enabled = true;
                FormDatNVL formDatNVL = new FormDatNVL();
                formDatNVL.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không được quyền truy cập vào chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnDatNVL.Enabled = false;
            }
            #endregion 
        }

        private void btnThongKe_ItemClick(object sender, ItemClickEventArgs e)
        {
            rpvTrangChu.Visible = true;
            Model_TWHSTORE TWHContext = new Model_TWHSTORE();
            this.rpvTrangChu.LocalReport.ReportPath = "ReportTKNVL.rdlc";
            this.rpvTrangChu.RefreshReport();
        }

        private void btnHotline_ItemClick(object sender, ItemClickEventArgs e)
        {
            MessageBox.Show("Đường dây nóng: 0969012332");         
        }

        private void btnEmail_ItemClick(object sender, ItemClickEventArgs e)
        {
            MessageBox.Show("Mọi thắc mắc liên hệ email: 4BG@gmail.com");
        }

        private void btnRate_ItemClick(object sender, ItemClickEventArgs e)
        {
            rpvTrangChu.Visible = true;
            Model_TWHSTORE TWHContext = new Model_TWHSTORE();
            this.rpvTrangChu.LocalReport.ReportPath = "ReportDGKH.rdlc";
            this.rpvTrangChu.RefreshReport();
        }

        private void btnQLNVL_ItemClick(object sender, ItemClickEventArgs e)
        {
            #region phân quyền
            if (Quyen == "1")
            {
                btnQLNVL.Enabled = true;
                FormQLNguyenVatLieu formQLNguyenVatLieu = new FormQLNguyenVatLieu();
                formQLNguyenVatLieu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không được quyền truy cập vào chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnQLNVL.Enabled = false;
            }
            #endregion         
        }


        private void btnChangePass_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormDoiMatKhau formDoiMatKhau = new FormDoiMatKhau();
            formDoiMatKhau.ShowDialog();
        }

        private void btnRegister_ItemClick(object sender, ItemClickEventArgs e)
        {
            #region phân quyền
            if (Quyen == "1")
            {
                btnRegister.Enabled = true;
                FormDangKi formDangKi = new FormDangKi();
                formDangKi.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không được quyền truy cập vào chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnRegister.Enabled = false;
            }
            #endregion
        }

    }
}