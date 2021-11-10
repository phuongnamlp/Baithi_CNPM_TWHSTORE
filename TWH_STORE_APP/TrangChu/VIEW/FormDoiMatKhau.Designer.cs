
namespace TrangChu.VIEW
{
    partial class FormDoiMatKhau
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenDNDMK = new System.Windows.Forms.TextBox();
            this.txtMkCu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMkMoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNhaplaiMK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnDMK = new System.Windows.Forms.Button();
            this.btnCancelDMK = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // txtTenDNDMK
            // 
            this.txtTenDNDMK.Location = new System.Drawing.Point(186, 49);
            this.txtTenDNDMK.Name = "txtTenDNDMK";
            this.txtTenDNDMK.Size = new System.Drawing.Size(174, 23);
            this.txtTenDNDMK.TabIndex = 1;
            // 
            // txtMkCu
            // 
            this.txtMkCu.Location = new System.Drawing.Point(186, 86);
            this.txtMkCu.Name = "txtMkCu";
            this.txtMkCu.Size = new System.Drawing.Size(174, 23);
            this.txtMkCu.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu cũ";
            // 
            // txtMkMoi
            // 
            this.txtMkMoi.Location = new System.Drawing.Point(186, 127);
            this.txtMkMoi.Name = "txtMkMoi";
            this.txtMkMoi.Size = new System.Drawing.Size(174, 23);
            this.txtMkMoi.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật khẩu mới ";
            // 
            // txtNhaplaiMK
            // 
            this.txtNhaplaiMK.Location = new System.Drawing.Point(186, 165);
            this.txtNhaplaiMK.Name = "txtNhaplaiMK";
            this.txtNhaplaiMK.Size = new System.Drawing.Size(174, 23);
            this.txtNhaplaiMK.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nhập lại mật khẩu";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtNhaplaiMK);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.txtMkMoi);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.txtMkCu);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.txtTenDNDMK);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(82, 18);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(429, 206);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "Đổi mật khẩu";
            // 
            // btnDMK
            // 
            this.btnDMK.Location = new System.Drawing.Point(236, 238);
            this.btnDMK.Name = "btnDMK";
            this.btnDMK.Size = new System.Drawing.Size(124, 35);
            this.btnDMK.TabIndex = 9;
            this.btnDMK.Text = "Xác nhận ";
            this.btnDMK.UseVisualStyleBackColor = true;
            this.btnDMK.Click += new System.EventHandler(this.btnDMK_Click);
            // 
            // btnCancelDMK
            // 
            this.btnCancelDMK.Location = new System.Drawing.Point(387, 238);
            this.btnCancelDMK.Name = "btnCancelDMK";
            this.btnCancelDMK.Size = new System.Drawing.Size(124, 35);
            this.btnCancelDMK.TabIndex = 10;
            this.btnCancelDMK.Text = "Hủy";
            this.btnCancelDMK.UseVisualStyleBackColor = true;
            this.btnCancelDMK.Click += new System.EventHandler(this.btnCancelDMK_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 300);
            this.Controls.Add(this.btnCancelDMK);
            this.Controls.Add(this.btnDMK);
            this.Controls.Add(this.groupControl1);
            this.Name = "FormDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FromDoiMatKhau";
            this.Load += new System.EventHandler(this.FromDoiMatKhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenDNDMK;
        private System.Windows.Forms.TextBox txtMkCu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMkMoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNhaplaiMK;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Button btnDMK;
        private System.Windows.Forms.Button btnCancelDMK;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}