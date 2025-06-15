using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppDatLichKham.DAL;
using AppDatLichKham.Entity;
using DevExpress.XtraPrinting.Native;

namespace AppDatLichKham.GUI.BenhNhan
{
    public partial class frmLichKham : Form
    {
        public frmLichKham()
        {
            InitializeComponent();
            printDocument1 = new PrintDocument();
            printDocument1.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Lấy nội dung của Panel và in ra
            Bitmap panelBitmap = new Bitmap(flyoutPanel1.Width, flyoutPanel1.Height);
            flyoutPanel1.DrawToBitmap(panelBitmap, new Rectangle(0, 0, flyoutPanel1.Width, flyoutPanel1.Height));

            // Vẽ bitmap lên giấy
            e.Graphics.DrawImage(panelBitmap, 0, 0);
        }
        private void LoadLichKham()
        {
            
            int benhNhanID = StaticThing.idBenhNhanTaiKhoan; 

            List<LichHen> danhSachLichHen = LichHenDAL.Instance.GetLichHenByBenhNhanID(benhNhanID);
            foreach (var lichHen in danhSachLichHen)
            {
                BacSi bacSi = TaiKhoanDAL.Instance.GetBacSiByID(lichHen.BacSiID);
                if (bacSi != null)
                {
                    lichHen.BacSiHoTen = bacSi.HoTen;
                    bacSi.ChuyenKhoa = ChuyenKhoaDAL.Instance.GetChuyenKhoaByID(bacSi.ChuyenKhoaID);
                    lichHen.Khoa=bacSi.ChuyenKhoa;
                }
            }
            var danhsachsapxep = danhSachLichHen
            .OrderBy(x => x.NgayHen.Date)              // 1. Ngày hẹn tăng dần
            .ToList();
            dataGridView1.DataSource = danhsachsapxep;
            dataGridView1.Columns["LichHenID"].HeaderText = "Lịch Hẹn ID";
            dataGridView1.Columns["BacSiHoTen"].HeaderText = "Bác sỹ phụ trách";
            dataGridView1.Columns["Khoa"].HeaderText = "Chuyên khoa";
            dataGridView1.Columns["GioiTinhString"].HeaderText = "Giới tính";
            dataGridView1.Columns["BacSiID"].Visible = false;
            dataGridView1.Columns["BenhNhanID"].Visible = false;
            dataGridView1.Columns["NgayHen"].HeaderText = "Ngày Hẹn";
            dataGridView1.Columns["NgayHen"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns["GioHen"].HeaderText = "Giờ Hẹn";
            dataGridView1.Columns["GioDenThucTe"].Visible = false;
            dataGridView1.Columns["TrangThai"].Visible = false;
            dataGridView1.Columns["GhiChu"].Visible = false;
            dataGridView1.Columns["HoTenNguoiKham"].Visible = false;
            dataGridView1.Columns["SDT"].Visible = false;
            dataGridView1.Columns["GioiTinh"].Visible = false;
            dataGridView1.Columns["PhongKham"].Visible = false;
            dataGridView1.Columns["DiaChi"].Visible = false;
            dataGridView1.Columns["trangThaiString"].HeaderText = "Trạng thái";
            dataGridView1.Columns["phongKhamString"].HeaderText = "Phòng khám";
            dataGridView1.Columns["LichHenID"].Width = 40;
            dataGridView1.Columns["LichHenID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["BacSiHoTen"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns["Khoa"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns["NgayHen"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["GioHen"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["DonThuoc"].Visible=false;
        }

        private void frmLichKham_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            LoadLichKham();
            xmsin.Items.Add("In thông tin", null, (s, ev) => In());
        }
        public void In()
        {
            if (lblPhong.Text == null || lblPhong.Text == "Chưa cập nhật")
            {
                MessageBox.Show("Vui lòng chờ bác sỹ cập nhật địa chỉ khám bệnh");
                return;
            }
            else { 

                PrintPreviewDialog previewDialog = new PrintPreviewDialog();
                previewDialog.Document = printDocument1;
                previewDialog.ClientSize = new Size(1000, 800); // Kích thước của cửa sổ xem trước
                                                                // Hiển thị xem trước in
                previewDialog.ShowDialog();
                /*System.Windows.Forms.PrintDialog printDialog = new System.Windows.Forms.PrintDialog();
                printDialog.Document = printDocument1;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    // Bắt đầu in
                    printDocument1.Print();
                }*/
            }
        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Ví dụ: Lấy giá trị từ hàng được chọn và hiển thị lên các TextBox
                lbltenBN.Text = row.Cells["HoTenNguoiKham"].Value.ToString();

                if (row.Cells["GioiTinh"].Value.ToString() == "True")
                {
                    lblGioitinh.Text = "Nam";
                }
                else
                {
                    lblGioitinh.Text = "Nữ";
                }
                lblKhoa.Text = row.Cells["Khoa"].Value.ToString();
                lblMaBN.Text = row.Cells["BenhNhanID"].Value.ToString();
                lblPhong.Text = row.Cells["phongKhamString"].Value.ToString();
                lbltenbacSy.Text = row.Cells["BacSiHoTen"].Value.ToString();
                lblThoiGianKham.Text = row.Cells["GioHen"].Value.ToString();
                lblIdcaKhasm.Text = row.Cells["LichHenID"].Value.ToString();
                lblNgayKham.Text = Convert.ToDateTime(row.Cells["NgayHen"].Value).ToString("dd/MM/yyyy");
                AppDatLichKham.Entity.BenhNhan benhNhan = BenhNhanDAL.Instance.GetBenhNhanByID(StaticThing.idBenhNhanTaiKhoan);
                DateTime ngaySinh = benhNhan.Ngaysinh;
                if (ngaySinh != null)
                {
                    lblTuoi.Text = StaticThing.TinhTuoi(ngaySinh).ToString();
                }
                if (StaticThing.TinhTuoi(ngaySinh) == 0||ngaySinh==null)
                {
                    lblTuoi.Text = " Không có dữ liệu, vui lòng cập nhật! ";
                }
                flyoutPanel1.ShowPopup();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void flyoutPanelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xmsin_Opening(object sender, CancelEventArgs e)
        {

        }

        private void inToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
