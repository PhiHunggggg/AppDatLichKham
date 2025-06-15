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

namespace AppDatLichKham.GUI.Admin
{
    public partial class frmDuyetLichNghi : Form
    {
        public frmDuyetLichNghi()
        {
            InitializeComponent();
        }

        private void frmDuyetLichNghi_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;

            LoadDanhSachLichHen();
        }
        private void LoadDanhSachLichHen()
        {

            int benhNhanID = StaticThing.idBenhNhanTaiKhoan; // Hoặc lấy từ biến static đã lưu khi đăng nhập
                                                             // Duyệt qua danh sách lịch hẹn và gán tên bác sĩ

            List<LichNghi> danhsachlichNghi = LichNghiDAL.Instance.GetAllLichNghi();

            var danhSachSapXep = danhsachlichNghi
                .Where(x => x.TrangThai == false) // Chỉ lấy những lịch nghỉ chưa xác nhận
                .OrderByDescending(x => x.NgayNghi)  // TrangThai = 1 (đã xác nhận) lên trước
                .ToList();
            foreach (var lichnghi in danhsachlichNghi)
            {
                BacSi bacSi = BacSiDAL.Instance.GetBacSiByID(lichnghi.BacSiID);
                if (bacSi != null)
                {
                    lichnghi.BacSiHoTen = bacSi.HoTen;
                }
            }
            dataGridView1.DataSource = danhSachSapXep;
            dataGridView1.Columns["LichNghiID"].HeaderText = "Lịch Nghỉ ID";
            dataGridView1.Columns["LichNghiID"].Width = 40;
            dataGridView1.Columns["BacSiID"].Visible = false;
            dataGridView1.Columns["BacSiHoTen"].HeaderText = "Tên Bác Sĩ";
            dataGridView1.Columns["BacSiHoTen"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns["NgayNghi"].HeaderText = "Ngày Nghỉ";
            dataGridView1.Columns["NgayNghi"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns["NgayNghi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["CaNghi"].Visible=false;
            dataGridView1.Columns["LyDo"].Visible = false;
            dataGridView1.Columns["TrangThai"].Visible=false;
            dataGridView1.Columns["TrangThaiString"].HeaderText = "Trạng thái";
            dataGridView1.Columns["TrangThaiString"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["CaNghiString"].HeaderText = "Ca nghỉ";
            dataGridView1.Columns["CaNghiString"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return; // Tránh lỗi khi click vào header hoặc ngoài vùng dữ liệu
            }
            txtLichNghiID.Text = dataGridView1.Rows[e.RowIndex].Cells["LichNghiID"].Value.ToString();
            pnlLyDo.Visible = true;
            txtLyDo.Text = dataGridView1.Rows[e.RowIndex].Cells["LyDo"].Value.ToString();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            LichNghiDAL.Instance.XacNhanLichNghi(Convert.ToInt32(txtLichNghiID.Text), true);
            MessageBox.Show("Đã xác nhận lịch nghỉ thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            pnlLyDo.Visible = false;
            LoadDanhSachLichHen();
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            LichNghiDAL.Instance.DeleteLichNghi(Convert.ToInt32(txtLichNghiID.Text));
            MessageBox.Show("Đã từ chối lịch nghỉ thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            pnlLyDo.Visible = false;
            LoadDanhSachLichHen();
        }
    }
}
