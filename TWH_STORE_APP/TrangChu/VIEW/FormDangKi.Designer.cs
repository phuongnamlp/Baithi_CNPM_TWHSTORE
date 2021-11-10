
namespace TrangChu.VIEW
{
    partial class FormDangKi
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
            this.components = new System.ComponentModel.Container();
            this.txtNhapMNV = new System.Windows.Forms.TextBox();
            this.txtMatKhauDK = new System.Windows.Forms.TextBox();
            this.txtTenDangNhapDK = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancelDK = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbb_Quyen = new System.Windows.Forms.ComboBox();
            this.dgvDK = new System.Windows.Forms.DataGridView();
            this.tendangnhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matkhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaitk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNhapMNV
            // 
            this.txtNhapMNV.Location = new System.Drawing.Point(160, 108);
            this.txtNhapMNV.Name = "txtNhapMNV";
            this.txtNhapMNV.Size = new System.Drawing.Size(163, 23);
            this.txtNhapMNV.TabIndex = 1;
            // 
            // txtMatKhauDK
            // 
            this.txtMatKhauDK.Location = new System.Drawing.Point(160, 76);
            this.txtMatKhauDK.Name = "txtMatKhauDK";
            this.txtMatKhauDK.Size = new System.Drawing.Size(163, 23);
            this.txtMatKhauDK.TabIndex = 1;
            // 
            // txtTenDangNhapDK
            // 
            this.txtTenDangNhapDK.Location = new System.Drawing.Point(160, 45);
            this.txtTenDangNhapDK.Name = "txtTenDangNhapDK";
            this.txtTenDangNhapDK.Size = new System.Drawing.Size(163, 23);
            this.txtTenDangNhapDK.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(24, 111);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(118, 17);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Nhập Mã Nhân Viên";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(24, 79);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(57, 17);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Mật Khẩu";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(24, 48);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(96, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên Đăng Nhập";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(35, 235);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(89, 33);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Đăng Kí";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancelDK
            // 
            this.btnCancelDK.Location = new System.Drawing.Point(949, 312);
            this.btnCancelDK.Name = "btnCancelDK";
            this.btnCancelDK.Size = new System.Drawing.Size(95, 33);
            this.btnCancelDK.TabIndex = 7;
            this.btnCancelDK.Text = "Hủy";
            this.btnCancelDK.UseVisualStyleBackColor = true;
            this.btnCancelDK.Click += new System.EventHandler(this.btnCancelDK_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(24, 146);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(88, 17);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Loại Tài Khoản";
            // 
            // cbb_Quyen
            // 
            this.cbb_Quyen.FormattingEnabled = true;
            this.cbb_Quyen.Location = new System.Drawing.Point(160, 143);
            this.cbb_Quyen.Name = "cbb_Quyen";
            this.cbb_Quyen.Size = new System.Drawing.Size(163, 24);
            this.cbb_Quyen.TabIndex = 9;
            // 
            // dgvDK
            // 
            this.dgvDK.AllowUserToAddRows = false;
            this.dgvDK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tendangnhap,
            this.matkhau,
            this.manv,
            this.loaitk});
            this.dgvDK.Location = new System.Drawing.Point(404, 41);
            this.dgvDK.Name = "dgvDK";
            this.dgvDK.RowHeadersWidth = 51;
            this.dgvDK.RowTemplate.Height = 24;
            this.dgvDK.Size = new System.Drawing.Size(640, 261);
            this.dgvDK.TabIndex = 10;
            this.dgvDK.SelectionChanged += new System.EventHandler(this.dgvDK_SelectionChanged);
            // 
            // tendangnhap
            // 
            this.tendangnhap.HeaderText = "Tên đăng nhập";
            this.tendangnhap.MinimumWidth = 6;
            this.tendangnhap.Name = "tendangnhap";
            this.tendangnhap.Width = 150;
            // 
            // matkhau
            // 
            this.matkhau.HeaderText = "Mật khẩu";
            this.matkhau.MinimumWidth = 6;
            this.matkhau.Name = "matkhau";
            this.matkhau.Width = 125;
            // 
            // manv
            // 
            this.manv.HeaderText = "Mã nhân viên ";
            this.manv.MinimumWidth = 6;
            this.manv.Name = "manv";
            this.manv.Width = 125;
            // 
            // loaitk
            // 
            this.loaitk.HeaderText = "Loại tài khoản";
            this.loaitk.MinimumWidth = 6;
            this.loaitk.Name = "loaitk";
            this.loaitk.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "* Quản lý thêm thông tin nhân viên trước khi đăng kí tài khoản * ";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.cbb_Quyen);
            this.groupControl1.Controls.Add(this.txtTenDangNhapDK);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtNhapMNV);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtMatKhauDK);
            this.groupControl1.Location = new System.Drawing.Point(35, 41);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(343, 188);
            this.groupControl1.TabIndex = 12;
            this.groupControl1.Text = "Thông tin đăng kí";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(170, 235);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(89, 33);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(298, 235);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(89, 33);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // FormDangKi
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 357);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDK);
            this.Controls.Add(this.btnCancelDK);
            this.Controls.Add(this.btnRegister);
            this.Name = "FormDangKi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Đăng Kí";
            this.Load += new System.EventHandler(this.DangKi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMatKhauDK;
        private System.Windows.Forms.TextBox txtTenDangNhapDK;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txtNhapMNV;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancelDK;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cbb_Quyen;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.DataGridView dgvDK;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendangnhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn matkhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaitk;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
    }
}