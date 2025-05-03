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
using AppDatLichKham.Entity;

namespace AppDatLichKham.GUI.BacSy
{
    public partial class frmLichLamViec : Form
    {
        public frmLichLamViec()
        {
            InitializeComponent();
        }

        private void frmLichLamViec_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            LoadLichLamViec();
        }
        private void LoadLichLamViec()
        {
            int bacSiID = StaticThing.idBacSiTaiKhoan;

            List<LichHen> danhSachLichHen = LichHenDAL.Instance.GetLichHenByBacSiID(bacSiID);
            foreach (var lichHen in danhSachLichHen)
            {
                AppDatLichKham.Entity.BenhNhan benhNhan = TaiKhoanDAL.Instance.GetBenhNhanByID(lichHen.BenhNhanID);
                if (benhNhan != null)
                {
                    lichHen.HoTenNguoiKham = benhNhan.Hoten;
                }
            }

            dataGridView1.DataSource = danhSachLichHen;
            dataGridView1.Columns["LichHenID"].HeaderText = "Lịch Hẹn ID";
            dataGridView1.Columns["BacSiHoTen"].Visible = false;
            dataGridView1.Columns["Khoa"].Visible = false;
            dataGridView1.Columns["GioiTinhString"].HeaderText = "Giới tính";
            dataGridView1.Columns["BacSiID"].Visible = false;
            dataGridView1.Columns["BenhNhanID"].Visible = false;
            dataGridView1.Columns["NgayHen"].HeaderText = "Ngày Hẹn";
            dataGridView1.Columns["GioHen"].HeaderText = "Giờ Hẹn";
            dataGridView1.Columns["GioDenThucTe"].Visible = false;
            dataGridView1.Columns["TrangThai"].Visible = false;
            dataGridView1.Columns["GhiChu"].Visible = false;
            dataGridView1.Columns["HoTenNguoiKham"].HeaderText = "Tên bệnh nhân";
            dataGridView1.Columns["SDT"].Visible = false;
            dataGridView1.Columns["GioiTinh"].Visible = false;
            dataGridView1.Columns["PhongKham"].Visible = false;
            dataGridView1.Columns["DiaChi"].Visible = false;
            dataGridView1.Columns["trangThaiString"].HeaderText = "Trạng thái";
            dataGridView1.Columns["phongKhamString"].HeaderText = "Phòng khám";
        }
    }
}
