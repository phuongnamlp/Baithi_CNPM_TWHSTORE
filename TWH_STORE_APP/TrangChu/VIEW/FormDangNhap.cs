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


namespace TrangChu.VIEW
{
    public partial class FormDangNhap : DevExpress.XtraEditors.XtraForm 
    {
        ConnectSQL con = new ConnectSQL();
        public bool IsLogin { get; set; }

        public FormDangNhap()
        {
            InitializeComponent();
            IsLogin = false;
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                string tk = txtTenDangNhap.Text;
                string mk = txtMatKhau.Text;
                dt = con.GetData("Select *from USERS Where TAIKHOAN ='" + tk + "'and MATKHAU ='" + mk + "'");
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    RibbonForm1 ribbonForm1 = new RibbonForm1(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
                    ribbonForm1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc tài khoản !");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối");
            }

        }

        private void btnOutLO_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void FormDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtTenDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Tab))
            {
                txtTenDangNhap.Focus();
            }
        }
    }
}