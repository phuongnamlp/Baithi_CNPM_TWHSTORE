using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using TrangChu.Models;

namespace TrangChu.VIEW
{
    public partial class FormPhiPhatSinh : DevExpress.XtraEditors.XtraForm
    {
        ConnectSQL con = new ConnectSQL();
        Model_TWHSTORE TWHContext;
        public FormPhiPhatSinh()
        {
            InitializeComponent();
            TWHContext = new Model_TWHSTORE();
        }
        private bool ValidateData()// hàm kiểm tra rỗng
        {

            if (string.IsNullOrWhiteSpace(txtNhapMP.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNhapND.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNhapCP.Text))
            {
                return false;
            }
            

            else
            {
                return true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateData())
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin !");
                }
                else
                {
                    PHIPHATSINH PPS = new PHIPHATSINH();
                    PHIPHATSINH PPS1 = TWHContext.PHIPHATSINHs.FirstOrDefault(s => s.MAPHIEU.ToString().CompareTo(txtNhapMP.Text) == 0);
                    if (PPS1 == null)
                    {
                        // nhập dữ liệu 
                        PPS.MAPHIEU = txtNhapMP.Text;
                        PPS.NOIDUNG = txtNhapND.Text;
                        PPS.CHIPHI = int.Parse(txtNhapCP.Text);
                        

                        TWHContext.PHIPHATSINHs.Add(PPS);
                        TWHContext.SaveChanges();
                        BindingDataFromListToDataGridView(TWHContext.PHIPHATSINHs.ToList());
                        MessageBox.Show("Thêm thông tin nhân viên thành công !");
                    }
                    else
                    {
                        MessageBox.Show("Thông tin nhân viên đã tồn tại !");
                    }
                }
                txtNhapMP.Clear();
                txtNhapND.Clear();
                txtNhapCP.Clear();



        }
            catch (Exception)
            {
                MessageBox.Show("Có Lỗi Xảy Ra");
            }
}

        private void FormPhiPhatSinh_Load(object sender, EventArgs e)
        {
            reportViewer1.Visible = false;
            dataGridView1.Visible = true;
            List<PHIPHATSINH> listTT = TWHContext.PHIPHATSINHs.ToList();
            BindingDataFromListToDataGridView(listTT);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.reportViewer1.RefreshReport();
        }
        private void BindingDataFromListToDataGridView(List<PHIPHATSINH> listTT)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < listTT.Count; i++)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = listTT[i].MAPHIEU;
                dataGridView1.Rows[index].Cells[1].Value = listTT[i].NOIDUNG;
                dataGridView1.Rows[index].Cells[2].Value = listTT[i].CHIPHI;
            

            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string MaPhieu = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                PHIPHATSINH pps = TWHContext.PHIPHATSINHs.FirstOrDefault(
                    s => s.MAPHIEU.ToString().CompareTo(MaPhieu) == 0);
                TWHContext.PHIPHATSINHs.Remove(pps);
                TWHContext.SaveChanges();
                BindingDataFromListToDataGridView(TWHContext.PHIPHATSINHs.ToList());
                MessageBox.Show("Xóa thông tin thành công !");
            }
            txtNhapMP.Clear();
            txtNhapND.Clear();
            txtNhapCP.Clear();
           
            
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            reportViewer1.Visible = true;
            Model_TWHSTORE context = new Model_TWHSTORE();
            List<PHIPHATSINH> listpps = context.PHIPHATSINHs.ToList();
            // List<PHIPHATSINH> listreport = new List<PHIPHATSINH>();
            this.reportViewer1.LocalReport.ReportPath = "ReportPPS.rdlc";
            var reportDataSource = new ReportDataSource("DataSetPPS", TWHContext.PHIPHATSINHs.ToList());
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.SelectedRows[0].Cells[0].Value != null)
                {
                    if (dataGridView1.SelectedRows[0].Cells[2].Value != null)
                    {
                        txtNhapMP.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                        txtNhapND.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                        txtNhapCP.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    }
                }
            }
        }
    }
}