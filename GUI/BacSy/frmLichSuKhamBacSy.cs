using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppDatLichKham.DAL;
using AppDatLichKham.DAL.Entity;
using AppDatLichKham.Entity;

namespace AppDatLichKham.GUI.BacSy
{
    public partial class frmLichSuKhamBacSy : Form
    {
        public frmLichSuKhamBacSy()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void LoadDanhSachLichHen()
        {

            int bacsiid = StaticThing.idBacSiTaiKhoan; // Hoặc lấy từ biến static đã lưu khi đăng nhập
                                                       // Duyệt qua danh sách lịch hẹn và gán tên bác sĩ

            List<LichSuKham> lichSuKham = LichSuKhamDAL.Instance.GetLichSuKhamByBacSiID(bacsiid);
            DateTime ngayHienTai = DateTime.Now.Date;
            TimeSpan gioHienTai = DateTime.Now.TimeOfDay;

            var lichSuSapXep = lichSuKham
                .OrderBy(lh => lh.NgayHen)
                .ToList();

            dataGridView1.DataSource = lichSuSapXep;
            dataGridView1.Columns["LichSuID"].Visible=false;
            dataGridView1.Columns["BacSiID"].Visible = false;
            dataGridView1.Columns["BenhNhanID"].Visible = false;
            dataGridView1.Columns["TenBacSi"].Visible = false;
            dataGridView1.Columns["NgayHen"].HeaderText = "Ngày khám";
            dataGridView1.Columns["NgayHen"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns["GioHen"].HeaderText = "Giờ Hẹn";
            dataGridView1.Columns["GioDen"].HeaderText = "Giờ đến";
            dataGridView1.Columns["GioDen"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["GhiChu"].Visible = false;
            dataGridView1.Columns["TenBenhNhan"].HeaderText = "Tên bệnh nhân";
            dataGridView1.Columns["TenBenhNhan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["NgayHen"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["GioHen"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["DonThuoc"].Visible = false;
        }
        private void LoadDanhSachLichHenTheoTen()
        {

            int bacsiid = StaticThing.idBacSiTaiKhoan; // Hoặc lấy từ biến static đã lưu khi đăng nhập
                                                       // Duyệt qua danh sách lịch hẹn và gán tên bác sĩ

            List<LichSuKham> lichSuKham = LichSuKhamDAL.Instance.GetLichSuKhamByBacSiID(bacsiid);
            DateTime ngayHienTai = DateTime.Now.Date;
            TimeSpan gioHienTai = DateTime.Now.TimeOfDay;
            List<LichSuKham> lichSuSapXep = new List<LichSuKham>();
            if (ckbLoctheongay.Checked == false&& string.IsNullOrEmpty(txtTimKiem.Text)) { 
             lichSuSapXep = lichSuKham
                .Where(lh => lh.TenBenhNhan.ToLower().Contains(txtTimKiem.Text.ToLower()))
                .OrderBy(lh => lh.NgayHen)
                .ToList();
            }
            else if(ckbLoctheongay.Checked && string.IsNullOrEmpty(txtTimKiem.Text))
            {
                DateTime ngayLoc = dtpNgayLoc.Value.Date;
                lichSuSapXep = lichSuKham
                    .Where(lh => lh.NgayHen.Date == ngayLoc)
                    .OrderBy(lh => lh.NgayHen)
                    .ToList();
            }
            else if (ckbLoctheongay.Checked && !string.IsNullOrEmpty(txtTimKiem.Text))
            {
                DateTime ngayLoc = dtpNgayLoc.Value.Date;
                lichSuSapXep = lichSuKham
                    .Where(lh => lh.TenBenhNhan.ToLower().Contains(txtTimKiem.Text.ToLower()) && lh.NgayHen.Date == ngayLoc)
                    .OrderBy(lh => lh.NgayHen)
                    .ToList();
            }

            dataGridView1.DataSource = lichSuSapXep;
            dataGridView1.Columns["LichSuID"].Visible = false;
            dataGridView1.Columns["BacSiID"].Visible = false;
            dataGridView1.Columns["BenhNhanID"].Visible = false;
            dataGridView1.Columns["TenBacSi"].Visible = false;
            dataGridView1.Columns["NgayHen"].HeaderText = "Ngày khám";
            dataGridView1.Columns["NgayHen"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns["GioHen"].HeaderText = "Giờ Hẹn";
            dataGridView1.Columns["GioDen"].HeaderText = "Giờ đến";
            dataGridView1.Columns["GioDen"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["GhiChu"].Visible = false;
            dataGridView1.Columns["TenBenhNhan"].HeaderText = "Tên bệnh nhân";
            dataGridView1.Columns["TenBenhNhan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["NgayHen"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["GioHen"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["DonThuoc"].Visible = false;
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtHoTen_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        if(e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return; // Tránh lỗi khi click vào header hoặc ngoài vùng dữ liệu
            }
            lblHoten.Text = dataGridView1.Rows[e.RowIndex].Cells["TenBenhNhan"].Value.ToString();
            lblNgayKham.Text = dataGridView1.Rows[e.RowIndex].Cells["NgayHen"].Value.ToString();
            lblGioHen.Text = dataGridView1.Rows[e.RowIndex].Cells["GioHen"].Value.ToString();
            lblGioDen.Text = dataGridView1.Rows[e.RowIndex].Cells["GioDen"].Value.ToString();
            txtDonThuoc.Text = dataGridView1.Rows[e.RowIndex].Cells["DonThuoc"].Value.ToString();
            txtGhiChu.Text = dataGridView1.Rows[e.RowIndex].Cells["GhiChu"].Value.ToString();
            pnlThongtin.Visible = true;
        }

        private void frmLichSuKhamBacSy_Load(object sender, EventArgs e)
        {
            LoadDanhSachLichHen();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtTimKiem.Text))
            {
                LoadDanhSachLichHen();
            }
            else
            {
                LoadDanhSachLichHenTheoTen();
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void dtpNgayLoc_ValueChanged(object sender, EventArgs e)
        {
            if(ckbLoctheongay.Checked)
            {
                    LoadDanhSachLichHenTheoTen();
            }
        }
    }
}
