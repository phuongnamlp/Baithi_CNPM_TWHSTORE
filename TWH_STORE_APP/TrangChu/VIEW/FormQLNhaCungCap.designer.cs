
namespace TrangChu.VIEW
{
    partial class FormQLNhaCungCap
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
            this.GroupControl = new DevExpress.XtraEditors.GroupControl();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtLoai = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvNCC = new System.Windows.Forms.DataGridView();
            this.MKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl)).BeginInit();
            this.GroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupControl
            // 
            this.GroupControl.Controls.Add(this.btnSua);
            this.GroupControl.Controls.Add(this.txtSoDT);
            this.GroupControl.Controls.Add(this.txtTenNCC);
            this.GroupControl.Controls.Add(this.labelControl1);
            this.GroupControl.Controls.Add(this.txtLoai);
            this.GroupControl.Controls.Add(this.txtDiaChi);
            this.GroupControl.Controls.Add(this.txtEmail);
            this.GroupControl.Controls.Add(this.labelControl7);
            this.GroupControl.Controls.Add(this.labelControl8);
            this.GroupControl.Controls.Add(this.labelControl9);
            this.GroupControl.Controls.Add(this.txtMaNCC);
            this.GroupControl.Controls.Add(this.labelControl5);
            this.GroupControl.Controls.Add(this.labelControl6);
            this.GroupControl.Controls.Add(this.btnHuy);
            this.GroupControl.Controls.Add(this.btnXoa);
            this.GroupControl.Controls.Add(this.btnThem);
            this.GroupControl.Controls.Add(this.dgvNCC);
            this.GroupControl.Location = new System.Drawing.Point(55, 5);
            this.GroupControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupControl.Name = "GroupControl";
            this.GroupControl.Size = new System.Drawing.Size(1246, 377);
            this.GroupControl.TabIndex = 1;
            this.GroupControl.Text = "QUẢN LÝ THÔNG TIN NHÀ CUNG CẤP";
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(205, 316);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(87, 43);
            this.btnSua.TabIndex = 39;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtSoDT
            // 
            this.txtSoDT.Location = new System.Drawing.Point(203, 150);
            this.txtSoDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(163, 23);
            this.txtSoDT.TabIndex = 38;
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(203, 116);
            this.txtTenNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(163, 23);
            this.txtTenNCC.TabIndex = 37;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(35, 86);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(131, 21);
            this.labelControl1.TabIndex = 36;
            this.labelControl1.Text = "Mã Nhà Cung Cấp";
            // 
            // txtLoai
            // 
            this.txtLoai.Location = new System.Drawing.Point(203, 250);
            this.txtLoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLoai.Name = "txtLoai";
            this.txtLoai.Size = new System.Drawing.Size(163, 23);
            this.txtLoai.TabIndex = 33;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(203, 215);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(163, 23);
            this.txtDiaChi.TabIndex = 34;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(203, 183);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(163, 23);
            this.txtEmail.TabIndex = 35;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(35, 249);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(73, 21);
            this.labelControl7.TabIndex = 30;
            this.labelControl7.Text = "Loại Hàng";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(35, 217);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(96, 21);
            this.labelControl8.TabIndex = 31;
            this.labelControl8.Text = "Nhập Địa Chỉ";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(35, 185);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(41, 21);
            this.labelControl9.TabIndex = 32;
            this.labelControl9.Text = "Email";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(203, 84);
            this.txtMaNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(163, 23);
            this.txtMaNCC.TabIndex = 29;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(35, 152);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(103, 21);
            this.labelControl5.TabIndex = 27;
            this.labelControl5.Text = "Số Điện Thoai";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(35, 118);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(137, 21);
            this.labelControl6.TabIndex = 28;
            this.labelControl6.Text = "Tên Nhà Cung Cấp";
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(299, 316);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(87, 43);
            this.btnHuy.TabIndex = 12;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(110, 316);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(87, 43);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(16, 316);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(87, 43);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvNCC
            // 
            this.dgvNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MKH,
            this.TKH,
            this.NS,
            this.SDT,
            this.DiaChi,
            this.LoaiHang});
            this.dgvNCC.Location = new System.Drawing.Point(394, 65);
            this.dgvNCC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvNCC.Name = "dgvNCC";
            this.dgvNCC.RowHeadersWidth = 51;
            this.dgvNCC.Size = new System.Drawing.Size(815, 242);
            this.dgvNCC.TabIndex = 10;
            this.dgvNCC.SelectionChanged += new System.EventHandler(this.dgvNCC_SelectionChanged);
            // 
            // MKH
            // 
            this.MKH.HeaderText = "MaNCC";
            this.MKH.MinimumWidth = 6;
            this.MKH.Name = "MKH";
            this.MKH.Width = 125;
            // 
            // TKH
            // 
            this.TKH.HeaderText = "TenNCC";
            this.TKH.MinimumWidth = 6;
            this.TKH.Name = "TKH";
            this.TKH.Width = 150;
            // 
            // NS
            // 
            this.NS.HeaderText = "SDT";
            this.NS.MinimumWidth = 6;
            this.NS.Name = "NS";
            this.NS.Width = 125;
            // 
            // SDT
            // 
            this.SDT.HeaderText = "Email";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.Width = 125;
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "DiaChi";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 125;
            // 
            // LoaiHang
            // 
            this.LoaiHang.HeaderText = "LoaiHang";
            this.LoaiHang.MinimumWidth = 6;
            this.LoaiHang.Name = "LoaiHang";
            this.LoaiHang.Width = 125;
            // 
            // FormQLNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 410);
            this.Controls.Add(this.GroupControl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormQLNhaCungCap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQLNCC";
            this.Load += new System.EventHandler(this.FormQLNCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl)).EndInit();
            this.GroupControl.ResumeLayout(false);
            this.GroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl GroupControl;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvNCC;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.TextBox txtTenNCC;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txtLoai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtEmail;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.TextBox txtMaNCC;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.DataGridViewTextBoxColumn MKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NS;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiHang;
        private System.Windows.Forms.Button btnSua;
    }
}