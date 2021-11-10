
namespace TrangChu.VIEW
{
    partial class FormPhiPhatSinh
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
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtNhapCP = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtNhapND = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNhapMP = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MAPHIEU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOIDUNG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHIPHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIn = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(67, 160);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(51, 21);
            this.labelControl3.TabIndex = 26;
            this.labelControl3.Text = "Chi Phí";
            // 
            // txtNhapCP
            // 
            this.txtNhapCP.Location = new System.Drawing.Point(173, 158);
            this.txtNhapCP.Name = "txtNhapCP";
            this.txtNhapCP.Size = new System.Drawing.Size(163, 23);
            this.txtNhapCP.TabIndex = 25;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(67, 113);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 21);
            this.labelControl2.TabIndex = 26;
            this.labelControl2.Text = "Nội Dung";
            // 
            // txtNhapND
            // 
            this.txtNhapND.Location = new System.Drawing.Point(173, 111);
            this.txtNhapND.Name = "txtNhapND";
            this.txtNhapND.Size = new System.Drawing.Size(163, 23);
            this.txtNhapND.TabIndex = 25;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(67, 71);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 21);
            this.labelControl1.TabIndex = 26;
            this.labelControl1.Text = "Mã Phí";
            // 
            // txtNhapMP
            // 
            this.txtNhapMP.Location = new System.Drawing.Point(173, 69);
            this.txtNhapMP.Name = "txtNhapMP";
            this.txtNhapMP.Size = new System.Drawing.Size(163, 23);
            this.txtNhapMP.TabIndex = 25;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(34, 348);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 51);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(176, 348);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(128, 51);
            this.btnXoa.TabIndex = 27;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAPHIEU,
            this.NOIDUNG,
            this.CHIPHI});
            this.dataGridView1.Location = new System.Drawing.Point(485, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(426, 336);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // MAPHIEU
            // 
            this.MAPHIEU.HeaderText = "Mã phiếu";
            this.MAPHIEU.MinimumWidth = 6;
            this.MAPHIEU.Name = "MAPHIEU";
            this.MAPHIEU.Width = 125;
            // 
            // NOIDUNG
            // 
            this.NOIDUNG.HeaderText = "Nội Dung";
            this.NOIDUNG.MinimumWidth = 6;
            this.NOIDUNG.Name = "NOIDUNG";
            this.NOIDUNG.Width = 125;
            // 
            // CHIPHI
            // 
            this.CHIPHI.HeaderText = "Chi Phí";
            this.CHIPHI.MinimumWidth = 6;
            this.CHIPHI.Name = "CHIPHI";
            this.CHIPHI.Width = 125;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(322, 348);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(128, 51);
            this.btnIn.TabIndex = 29;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(484, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(426, 336);
            this.reportViewer1.TabIndex = 30;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtNhapMP);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtNhapND);
            this.groupControl1.Controls.Add(this.txtNhapCP);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Location = new System.Drawing.Point(34, 43);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(416, 247);
            this.groupControl1.TabIndex = 31;
            this.groupControl1.Text = "Phí Phát Sinh";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(471, 348);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 51);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormPhiPhatSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 424);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnAdd);
            this.Name = "FormPhiPhatSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPhiPhatSinh";
            this.Load += new System.EventHandler(this.FormPhiPhatSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox txtNhapCP;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txtNhapND;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txtNhapMP;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPHIEU;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOIDUNG;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHIPHI;
        private System.Windows.Forms.Button btnIn;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Button btnCancel;
    }
}