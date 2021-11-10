
namespace TrangChu.VIEW
{
    partial class FormQLNguyenVatLieu
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
            this.dtpHH = new System.Windows.Forms.DateTimePicker();
            this.dtpSX = new System.Windows.Forms.DateTimePicker();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenNVL = new System.Windows.Forms.TextBox();
            this.txtNVL = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvQLDSNVL = new System.Windows.Forms.DataGridView();
            this.manvl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennvl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayhh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLoai = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLDSNVL)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dtpHH);
            this.groupControl1.Controls.Add(this.dtpSX);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtTenNVL);
            this.groupControl1.Controls.Add(this.txtNVL);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.btnHuy);
            this.groupControl1.Controls.Add(this.btnSua);
            this.groupControl1.Controls.Add(this.btnXoa);
            this.groupControl1.Controls.Add(this.btnThem);
            this.groupControl1.Controls.Add(this.dgvQLDSNVL);
            this.groupControl1.Controls.Add(this.txtLoai);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(28, 34);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(979, 312);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Quản lý nguyên vật liệu";
            // 
            // dtpHH
            // 
            this.dtpHH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHH.Location = new System.Drawing.Point(176, 179);
            this.dtpHH.Name = "dtpHH";
            this.dtpHH.Size = new System.Drawing.Size(149, 23);
            this.dtpHH.TabIndex = 19;
            // 
            // dtpSX
            // 
            this.dtpSX.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSX.Location = new System.Drawing.Point(176, 148);
            this.dtpSX.Name = "dtpSX";
            this.dtpSX.Size = new System.Drawing.Size(149, 23);
            this.dtpSX.TabIndex = 18;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(49, 150);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(105, 21);
            this.labelControl5.TabIndex = 17;
            this.labelControl5.Text = "Ngày sản xuất";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(49, 181);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(98, 21);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "Ngày hết hạn";
            // 
            // txtTenNVL
            // 
            this.txtTenNVL.Location = new System.Drawing.Point(176, 86);
            this.txtTenNVL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenNVL.Name = "txtTenNVL";
            this.txtTenNVL.Size = new System.Drawing.Size(150, 23);
            this.txtTenNVL.TabIndex = 15;
            // 
            // txtNVL
            // 
            this.txtNVL.Location = new System.Drawing.Point(176, 55);
            this.txtNVL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNVL.Name = "txtNVL";
            this.txtNVL.Size = new System.Drawing.Size(150, 23);
            this.txtNVL.TabIndex = 14;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(49, 119);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(35, 21);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Loại ";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(382, 259);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(90, 37);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Hủy ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(140, 259);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(97, 37);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(260, 259);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 37);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(22, 259);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 37);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvQLDSNVL
            // 
            this.dgvQLDSNVL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLDSNVL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manvl,
            this.tennvl,
            this.loai,
            this.ngaysx,
            this.ngayhh});
            this.dgvQLDSNVL.Location = new System.Drawing.Point(416, 32);
            this.dgvQLDSNVL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvQLDSNVL.Name = "dgvQLDSNVL";
            this.dgvQLDSNVL.RowHeadersWidth = 51;
            this.dgvQLDSNVL.Size = new System.Drawing.Size(521, 199);
            this.dgvQLDSNVL.TabIndex = 4;
            this.dgvQLDSNVL.SelectionChanged += new System.EventHandler(this.dgvQLDSNVL_SelectionChanged);
            // 
            // manvl
            // 
            this.manvl.HeaderText = "Mã NVL";
            this.manvl.MinimumWidth = 6;
            this.manvl.Name = "manvl";
            this.manvl.Width = 125;
            // 
            // tennvl
            // 
            this.tennvl.HeaderText = "Tên NVL";
            this.tennvl.MinimumWidth = 6;
            this.tennvl.Name = "tennvl";
            this.tennvl.Width = 150;
            // 
            // loai
            // 
            this.loai.HeaderText = "Loại";
            this.loai.MinimumWidth = 6;
            this.loai.Name = "loai";
            this.loai.Width = 125;
            // 
            // ngaysx
            // 
            this.ngaysx.HeaderText = "Ngày Sản Xuất";
            this.ngaysx.MinimumWidth = 6;
            this.ngaysx.Name = "ngaysx";
            this.ngaysx.Width = 150;
            // 
            // ngayhh
            // 
            this.ngayhh.HeaderText = "Ngày Hết Hạn";
            this.ngayhh.MinimumWidth = 6;
            this.ngayhh.Name = "ngayhh";
            this.ngayhh.Width = 150;
            // 
            // txtLoai
            // 
            this.txtLoai.Location = new System.Drawing.Point(176, 117);
            this.txtLoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLoai.Name = "txtLoai";
            this.txtLoai.Size = new System.Drawing.Size(150, 23);
            this.txtLoai.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(49, 88);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 21);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên NVL";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(49, 57);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã NVL";
            // 
            // FormQLNguyenVatLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 391);
            this.Controls.Add(this.groupControl1);
            this.Name = "FormQLNguyenVatLieu";
            this.Text = "FormQLNguyenVatLieu";
            this.Load += new System.EventHandler(this.FormQLNguyenVatLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLDSNVL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DateTimePicker dtpHH;
        private System.Windows.Forms.DateTimePicker dtpSX;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.TextBox txtTenNVL;
        private System.Windows.Forms.TextBox txtNVL;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvQLDSNVL;
        private System.Windows.Forms.DataGridViewTextBoxColumn manvl;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennvl;
        private System.Windows.Forms.DataGridViewTextBoxColumn loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysx;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayhh;
        private System.Windows.Forms.TextBox txtLoai;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}