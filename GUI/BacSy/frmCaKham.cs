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
    public partial class frmCaKham : Form
    {
        public frmCaKham()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void siticoneTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void siticoneDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan gioDen = dtpGioDen.Value.TimeOfDay;
            if (TimeSpan.TryParse(txtGioHen.Text, out TimeSpan gioHen))
            {
                // Tính chênh lệch tuyệt đối giữa giờ đến và giờ hẹn
                TimeSpan chenhlech = gioDen - gioHen;
                if (chenhlech.Duration() <= TimeSpan.FromMinutes(2))
                {
                    cbcTrangthaiden.SelectedIndex = 0;
                }
                else if (gioDen < gioHen)
                {
                    cbcTrangthaiden.SelectedIndex = 1;
                }
                else
                {
                    cbcTrangthaiden.SelectedIndex = 2;
                }
            }
            else
            {
                MessageBox.Show("Giờ hẹn không hợp lệ!");
            }

        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            dtpGioDen.Value = DateTime.Now;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoadDanhSachLichHen()
        {

            int bacsiid = StaticThing.idBacSiTaiKhoan; // Hoặc lấy từ biến static đã lưu khi đăng nhập
                                                       // Duyệt qua danh sách lịch hẹn và gán tên bác sĩ

            List<LichHen> danhSachLichHen = LichHenDAL.Instance.GetLichHenByBacSiID(bacsiid);
            DateTime ngayHienTai = DateTime.Now.Date;
            TimeSpan gioHienTai = DateTime.Now.TimeOfDay;

            var danhSachHomNay = danhSachLichHen
                .Where(lh => lh.NgayHen == ngayHienTai && lh.GioHen >= gioHienTai)
                .OrderBy(lh => lh.GioHen)
                .ToList();

            dataGridView1.DataSource = danhSachHomNay;
            dataGridView1.Columns["LichHenID"].HeaderText = "Lịch Hẹn ID";
            dataGridView1.Columns["BacSiHoTen"].Visible = false;
            dataGridView1.Columns["GioiTinhString"].Visible = false;
            dataGridView1.Columns["BacSiID"].Visible = false;
            dataGridView1.Columns["BenhNhanID"].Visible = false;
            dataGridView1.Columns["NgayHen"].HeaderText = "Ngày Hẹn";
            dataGridView1.Columns["NgayHen"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns["GioHen"].HeaderText = "Giờ Hẹn";
            dataGridView1.Columns["GioDenThucTe"].HeaderText = "Giờ đến";
            dataGridView1.Columns["GioDenThucTe"].DefaultCellStyle.Alignment= DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["TrangThai"].Visible = false;
            dataGridView1.Columns["GhiChu"].Visible = false;
            dataGridView1.Columns["HoTenNguoiKham"].HeaderText = "Tên bệnh nhân";
            dataGridView1.Columns["SDT"].Visible = false;
            dataGridView1.Columns["GioiTinh"].Visible = false;
            dataGridView1.Columns["PhongKham"].Visible = false;
            dataGridView1.Columns["DiaChi"].Visible = false;
            dataGridView1.Columns["trangThaiString"].HeaderText = "Trạng thái";
            dataGridView1.Columns["phongKhamString"].Visible = false;
            dataGridView1.Columns["LichHenID"].Width = 40;
            dataGridView1.Columns["LichHenID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["BacSiHoTen"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns["Khoa"].Visible = false;
            dataGridView1.Columns["NgayHen"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["GioHen"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["DonThuoc"].Visible = false;
            if(danhSachHomNay.Count > 0)
            {
                pnlTrong.Visible = false;
            }
        }

        private void frmCaKham_Load(object sender, EventArgs e)
        {
            LoadDanhSachLichHen();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                BacSi bs = BacSiDAL.Instance.GetBacSiByID(StaticThing.idBacSiTaiKhoan);
                pnlThongtin.Visible = true;
                txtGioHen.Text = dataGridView1.Rows[e.RowIndex].Cells["GioHen"].Value?.ToString();
                txtLichhenid.Text = dataGridView1.Rows[e.RowIndex].Cells["LichHenID"].Value?.ToString();
                txtTenBacSi.Text = bs.HoTen;
                txtTenBenhNhan.Text = dataGridView1.Rows[e.RowIndex].Cells["HoTenNguoiKham"].Value?.ToString();
                txtbenhnhanid.Text = dataGridView1.Rows[e.RowIndex].Cells["BenhNhanID"].Value?.ToString();
            }
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            if (LichHenDAL.Instance.UpdateTrangThai(Convert.ToInt32(txtLichhenid.Text), true))
            {
            }
            else
            {
                MessageBox.Show("Cập nhật trạng thái thất bại. Vui lòng thử lại.");
                return;
            }
            TimeSpan gioDenRaw = dtpGioDen.Value.TimeOfDay;
            TimeSpan gioDen = new TimeSpan(gioDenRaw.Hours, gioDenRaw.Minutes, gioDenRaw.Seconds);
            if (LichHenDAL.Instance.UpdatePhongKhamOrGioDen(Convert.ToInt32(txtLichhenid.Text), null, gioDen, txtGhiChu.Text, txtDonThuoc.Text))
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadDanhSachLichHen();
                pnlThongtin.Visible = false;
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại. Vui lòng thử lại.");
            }
            DateTime ngayHen = DateTime.Today.Date;
            TimeSpan gioHen = TimeSpan.Parse(txtGioHen.Text);
            if (LichSuKhamDAL.Instance.InsertLichSuKham(txtTenBacSi.Text, txtTenBenhNhan.Text, ngayHen, gioHen, gioDen, txtGhiChu.Text, txtDonThuoc.Text, StaticThing.idBacSiTaiKhoan, Convert.ToInt32(txtbenhnhanid.Text)))
            {
            }
            else
            {
                MessageBox.Show("Lưu lịch sử khám thất bại. Vui lòng thử lại.");
            }
            LichHenDAL.Instance.XoaLichHen(Convert.ToInt32(txtLichhenid.Text));
            LoadDanhSachLichHen();
        }
        private void txtGioHen_TextChanged(object sender, EventArgs e)
        {

        }
    } 
}
