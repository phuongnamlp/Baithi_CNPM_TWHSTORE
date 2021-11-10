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

namespace TrangChu.VIEW
{
    public partial class FormDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public FormDoiMatKhau()
        {
            InitializeComponent();
        }

        private void FromDoiMatKhau_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tWH_STOREDataSet.USERS' table. You can move, or remove it, as needed.
        }

        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=TWH_STORE;Integrated Security=True");
        private void btnDMK_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select count (*) from USERS where TAIKHOAN = N'" +txtTenDNDMK.Text+ "' and MATKHAU = N'" +txtMkCu.Text+ "'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            errorProvider1.Clear();// hiện dấu X khi nhập sai hoặc thiếu
            if (dt.Rows[0][0].ToString() == "1")
            {
                if (txtMkMoi.Text == txtNhaplaiMK.Text)
                {
                    //if (txtMkMoi.Text.Length > 6)// mật khẩu cũ phải dài hơn 6 kí tự 
                    //{
                        SqlDataAdapter da1 = new SqlDataAdapter("Update USERS set MATKHAU = N'" +txtMkMoi.Text+ "' where TAIKHOAN = N'" +txtTenDNDMK.Text+ "'and MATKHAU = N'"+txtMkCu.Text+"'", conn);
                        DataTable dt1 = new DataTable();
                        da1.Fill(dt1);// fill dữ liệu vào DB 
                        MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}
                    //else
                    //{
                    //    errorProvider1.SetError(txtMkMoi, "Mật khẩu chưa đủ dài , vui lòng điền lại");
                    //}
                }
                else
                {
                    errorProvider1.SetError(txtMkMoi, "Vui lòng điền mật khẩu mới !!! , vui lòng điền lại");
                    errorProvider1.SetError(txtNhaplaiMK, "Mật khẩu chưa trùng khớp !!! , vui lòng điền lại");
                }
            }
            else
            {
                errorProvider1.SetError(txtTenDNDMK, "Tài khoản không chính xác , vui lòng điền lại");
                errorProvider1.SetError(txtMkCu, "Mật khẩu cũ không đúng , vui lòng điền lại ");

            }

        }

        private void btnCancelDMK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}