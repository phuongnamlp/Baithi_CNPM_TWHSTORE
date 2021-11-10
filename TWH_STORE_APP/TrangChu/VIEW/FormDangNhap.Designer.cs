
namespace TrangChu.VIEW
{
    partial class FormDangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnOutLO = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtMatKhau);
            this.groupControl1.Controls.Add(this.txtTenDangNhap);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(110, 31);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(392, 148);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Đăng Nhập";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.AcceptsTab = true;
            this.txtMatKhau.Location = new System.Drawing.Point(201, 88);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(121, 23);
            this.txtMatKhau.TabIndex = 1;
            this.txtMatKhau.UseSystemPasswordChar = true;
            this.txtMatKhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTenDangNhap_KeyDown);
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.AcceptsTab = true;
            this.txtTenDangNhap.Location = new System.Drawing.Point(201, 56);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(121, 23);
            this.txtTenDangNhap.TabIndex = 1;
            this.txtTenDangNhap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTenDangNhap_KeyDown);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(65, 91);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(57, 17);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Mật Khẩu";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(65, 62);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(96, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên Đăng Nhập";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(276, 185);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(103, 39);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Đăng Nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnOutLO
            // 
            this.btnOutLO.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOutLO.Location = new System.Drawing.Point(399, 185);
            this.btnOutLO.Name = "btnOutLO";
            this.btnOutLO.Size = new System.Drawing.Size(103, 39);
            this.btnOutLO.TabIndex = 2;
            this.btnOutLO.Text = "Thoát";
            this.btnOutLO.UseVisualStyleBackColor = true;
            this.btnOutLO.Click += new System.EventHandler(this.btnOutLO_Click);
            // 
            // FormDangNhap
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOutLO;
            this.ClientSize = new System.Drawing.Size(621, 270);
            this.Controls.Add(this.btnOutLO);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.groupControl1);
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Đăng Nhập";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDangNhap_FormClosed);
            this.Load += new System.EventHandler(this.DangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnOutLO;
    }
}