
namespace TrangChu.VIEW
{
    partial class FormPhiDichVu
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
            this.grpPDV = new DevExpress.XtraEditors.GroupControl();
            this.btnThoat = new System.Windows.Forms.Button();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvDV = new System.Windows.Forms.DataGridView();
            this.MAPHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOIDUNG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHIPHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaDV = new System.Windows.Forms.TextBox();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.txtChiPhi = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grpPDV)).BeginInit();
            this.grpPDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPDV
            // 
            this.grpPDV.Controls.Add(this.btnThoat);
            this.grpPDV.Controls.Add(this.reportViewer2);
            this.grpPDV.Controls.Add(this.btnIn);
            this.grpPDV.Controls.Add(this.btnHuy);
            this.grpPDV.Controls.Add(this.btnSua);
            this.grpPDV.Controls.Add(this.btnXoa);
            this.grpPDV.Controls.Add(this.btnThem);
            this.grpPDV.Controls.Add(this.dgvDV);
            this.grpPDV.Controls.Add(this.txtMaDV);
            this.grpPDV.Controls.Add(this.txtNoiDung);
            this.grpPDV.Controls.Add(this.txtChiPhi);
            this.grpPDV.Controls.Add(this.labelControl3);
            this.grpPDV.Controls.Add(this.labelControl2);
            this.grpPDV.Controls.Add(this.labelControl1);
            this.grpPDV.Location = new System.Drawing.Point(43, 13);
            this.grpPDV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpPDV.Name = "grpPDV";
            this.grpPDV.Size = new System.Drawing.Size(992, 378);
            this.grpPDV.TabIndex = 0;
            this.grpPDV.Text = "Phí dịch vụ";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(643, 318);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(87, 37);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // reportViewer2
            // 
            this.reportViewer2.Location = new System.Drawing.Point(308, 44);
            this.reportViewer2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(677, 260);
            this.reportViewer2.TabIndex = 12;
            this.reportViewer2.Load += new System.EventHandler(this.reportViewer2_Load);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(404, 318);
            this.btnIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(87, 37);
            this.btnIn.TabIndex = 11;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(523, 318);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(87, 37);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(269, 318);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(98, 37);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(145, 318);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(101, 37);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(21, 318);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 37);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvDV
            // 
            this.dgvDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAPHI,
            this.NOIDUNG,
            this.CHIPHI});
            this.dgvDV.Location = new System.Drawing.Point(308, 54);
            this.dgvDV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDV.Name = "dgvDV";
            this.dgvDV.RowHeadersWidth = 51;
            this.dgvDV.Size = new System.Drawing.Size(574, 239);
            this.dgvDV.TabIndex = 6;
            this.dgvDV.SelectionChanged += new System.EventHandler(this.dgvDV_SelectionChanged);
            // 
            // MAPHI
            // 
            this.MAPHI.HeaderText = "Mã Phí Dịch Vụ";
            this.MAPHI.MinimumWidth = 6;
            this.MAPHI.Name = "MAPHI";
            this.MAPHI.Width = 125;
            // 
            // NOIDUNG
            // 
            this.NOIDUNG.HeaderText = "Nội Dung";
            this.NOIDUNG.MinimumWidth = 6;
            this.NOIDUNG.Name = "NOIDUNG";
            this.NOIDUNG.Width = 250;
            // 
            // CHIPHI
            // 
            this.CHIPHI.HeaderText = "Chi Phí";
            this.CHIPHI.MinimumWidth = 6;
            this.CHIPHI.Name = "CHIPHI";
            this.CHIPHI.Width = 125;
            // 
            // txtMaDV
            // 
            this.txtMaDV.Location = new System.Drawing.Point(145, 74);
            this.txtMaDV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.Size = new System.Drawing.Size(146, 23);
            this.txtMaDV.TabIndex = 5;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(145, 115);
            this.txtNoiDung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(146, 23);
            this.txtNoiDung.TabIndex = 4;
            // 
            // txtChiPhi
            // 
            this.txtChiPhi.Location = new System.Drawing.Point(145, 159);
            this.txtChiPhi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtChiPhi.Name = "txtChiPhi";
            this.txtChiPhi.Size = new System.Drawing.Size(146, 23);
            this.txtChiPhi.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(21, 161);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(51, 21);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Chi Phí";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(21, 117);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 21);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Nội Dung";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(21, 76);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(111, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã Phí Dịch Vụ";
            // 
            // FormPhiDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 418);
            this.Controls.Add(this.grpPDV);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormPhiDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPDV";
            this.Load += new System.EventHandler(this.FormPhiDV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpPDV)).EndInit();
            this.grpPDV.ResumeLayout(false);
            this.grpPDV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpPDV;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOIDUNG;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHIPHI;
        private System.Windows.Forms.TextBox txtMaDV;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.TextBox txtChiPhi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button btnIn;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.Button btnThoat;
    }
}