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

namespace AppDatLichKham.GUI.Admin
{
    public partial class frmTaiKhoan : Form
    {
        public frmTaiKhoan()
        {
            InitializeComponent();

        }
        private void LoadDanhSachTaiKhoan()
        {
            List<TaiKhoan> danhsachTaiKhoan = TaiKhoanDAL.Instance.GetAllTaiKhoan();

            var danhSachSapXep = danhsachTaiKhoan
            .OrderBy(tk =>
            {
                // Gán trọng số cho từng loại tài khoản
                if (tk.LoaiTaiKhoan == "Admin") return 0;
                if (tk.LoaiTaiKhoan == "BacSi") return 1;
                if (tk.LoaiTaiKhoan == "BenhNhan") return 2;
                return 3; // nếu có loại khác
            })
            .ToList();


            dataGridView1.DataSource = danhSachSapXep;
            dataGridView1.Columns["TaiKhoanID"].HeaderText = "Tài khoản ID";
            dataGridView1.Columns["TaiKhoanID"].Width = 40;
            dataGridView1.Columns["TaiKhoanID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["TenDangNhap"].HeaderText = "Tên đăng nhập";
            dataGridView1.Columns["MatKhau"].Visible = false;
            dataGridView1.Columns["LoaiTaiKhoanHienThi"].HeaderText = "Loại tài khoản";
            dataGridView1.Columns["LoaiTaiKhoan"].Visible = false;
            dataGridView1.Columns["LoaiTaiKhoanHienThi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["BenhNhanID"].Visible = false;
            dataGridView1.Columns["BacSiID"].Visible = false;


        }
        private void LoadDanhSachBacsi()
        {
            List<TaiKhoan> danhsachTaiKhoan = TaiKhoanDAL.Instance.GetAllTaiKhoan();

            var danhSachSapXep = danhsachTaiKhoan
            .Where(tk=>tk.LoaiTaiKhoan=="BacSi")
            .OrderBy(tk=>tk.TenDangNhap)
            .ToList();


            dataGridView1.DataSource = danhSachSapXep;
            dataGridView1.Columns["TaiKhoanID"].HeaderText = "Tài khoản ID";
            dataGridView1.Columns["TaiKhoanID"].Width = 40;
            dataGridView1.Columns["TaiKhoanID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["TenDangNhap"].HeaderText = "Tên đăng nhập";
            dataGridView1.Columns["MatKhau"].Visible = false;
            dataGridView1.Columns["LoaiTaiKhoanHienThi"].HeaderText = "Loại tài khoản";
            dataGridView1.Columns["LoaiTaiKhoan"].Visible = false;
            dataGridView1.Columns["LoaiTaiKhoanHienThi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["BenhNhanID"].Visible = false;
            dataGridView1.Columns["BacSiID"].Visible = false;


        }
        private void LoadDanhSachBenhnhan()
        {
            List<TaiKhoan> danhsachTaiKhoan = TaiKhoanDAL.Instance.GetAllTaiKhoan();

            var danhSachSapXep = danhsachTaiKhoan
            .Where(tk => tk.LoaiTaiKhoan == "BenhNhan")
            .OrderBy(tk => tk.TenDangNhap)
            .ToList();


            dataGridView1.DataSource = danhSachSapXep;
            dataGridView1.Columns["TaiKhoanID"].HeaderText = "Tài khoản ID";
            dataGridView1.Columns["TaiKhoanID"].Width = 40;
            dataGridView1.Columns["TaiKhoanID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["TenDangNhap"].HeaderText = "Tên đăng nhập";
            dataGridView1.Columns["MatKhau"].Visible = false;
            dataGridView1.Columns["LoaiTaiKhoanHienThi"].HeaderText = "Loại tài khoản";
            dataGridView1.Columns["LoaiTaiKhoan"].Visible = false;
            dataGridView1.Columns["LoaiTaiKhoanHienThi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["BenhNhanID"].Visible = false;
            dataGridView1.Columns["BacSiID"].Visible = false;
        }
        private void LoadDanhSachTimKiem()
        {
            List<TaiKhoan> danhsachTaiKhoan = TaiKhoanDAL.Instance.GetTaiKhoanByUsername(txtTimKiem.Text);

            var danhSachSapXep = danhsachTaiKhoan
            .OrderBy(tk =>
            {
                // Gán trọng số cho từng loại tài khoản
                if (tk.LoaiTaiKhoan == "Admin") return 0;
                if (tk.LoaiTaiKhoan == "BacSi") return 1;
                if (tk.LoaiTaiKhoan == "BenhNhan") return 2;
                return 3; // nếu có loại khác
            })
            .ToList();


            dataGridView1.DataSource = danhsachTaiKhoan;
            dataGridView1.Columns["TaiKhoanID"].HeaderText = "Tài khoản ID";
            dataGridView1.Columns["TaiKhoanID"].Width = 40;
            dataGridView1.Columns["TaiKhoanID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["TenDangNhap"].HeaderText = "Tên đăng nhập";
            dataGridView1.Columns["MatKhau"].Visible = false;
            dataGridView1.Columns["LoaiTaiKhoanHienThi"].HeaderText = "Loại tài khoản";
            dataGridView1.Columns["LoaiTaiKhoan"].Visible = false;
            dataGridView1.Columns["LoaiTaiKhoanHienThi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["BenhNhanID"].Visible = false;
            dataGridView1.Columns["BacSiID"].Visible = false;


        }
        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyLichKhamDataSet2.ChuyenKhoa' table. You can move, or remove it, as needed.
            this.chuyenKhoaTableAdapter.Fill(this.quanLyLichKhamDataSet2.ChuyenKhoa);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.RowHeadersVisible = false;
            LoadDanhSachTaiKhoan();
        }

        private void siticoneTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if ((int)row.Cells["BacSiID"].Value != 0)
                {
                    txtbacsiid.Text = row.Cells["BacSiID"].Value.ToString();
                    pnlBacsi.Visible = true;
                    pnlBenhnhan.Visible = false;
                    int bacsiid = Convert.ToInt32(row.Cells["BacSiID"].Value);
                    BacSi bacSi = TaiKhoanDAL.Instance.GetBacSiByID(bacsiid);

                    txtHoTen.Text = bacSi.HoTen.ToString();
                    cbcChuyenKhoa.SelectedValue = bacSi.ChuyenKhoaID;
                    txtEmail.Text = bacSi.Email.ToString();
                    txtSDT.Text = bacSi.SDT.ToString();
                    txtTuoi.Text = bacSi.Tuoi.ToString();
                    cbcTrinhDo.SelectedItem = bacSi.Trinhdo;
                    cbcChucVu.SelectedItem = bacSi.ChucVu;
                    txtChiPhiKham.Text = bacSi.ChiPhiKham.ToString();
                }
                else if ((int)row.Cells["BenhNhanID"].Value != 0)
                {
                    txtbenhnhanid.Text = row.Cells["BenhNhanID"].Value.ToString();
                    pnlBacsi.Visible = false;
                    pnlBenhnhan.Visible = true;
                    int benhnhanid = Convert.ToInt32(row.Cells["BenhNhanID"].Value);
                    Entity.BenhNhan benhNhan = TaiKhoanDAL.Instance.GetBenhNhanByID(benhnhanid);
                    txtHoTenBN.Text = benhNhan.Hoten.ToString();
                    txtSoDienThoai.Text = benhNhan.sdt.ToString();
                    txtDiaChiBN.Text = benhNhan.diachi.ToString();
                    dtpNgaySinh.Text = benhNhan.Ngaysinh.ToString();
                    if (benhNhan.gioitinh == true)
                    {
                        ckbNam.Checked = true;
                        ckbNu.Checked = false;
                    }
                    else if (benhNhan.gioitinh == false)
                    {
                        ckbNu.Checked = true;
                        ckbNam.Checked = false;
                    }
                }
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void ckbNam_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbNam.Checked == true)
            {
                ckbNu.Checked = false;
            }
            else
            {
                ckbNu.Checked = true;
            }
        }

        private void ckbNu_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbNu.Checked == true)
            {
                ckbNam.Checked = false;
            }
            else
            {
                ckbNam.Checked = true;
            }
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            if(txtSDT.Text.Length < 10 || txtSDT.Text.Length > 11)
            {
                MessageBox.Show("Số điện thoại phải có độ dài từ 10 đến 11 ký tự!");
                return;
            }
            if(txtEmail.Text.Length < 5 || !txtEmail.Text.Contains("@") || !txtEmail.Text.Contains(".")) // Kiểm tra định dạng email cơ bản
            {
                MessageBox.Show("Email không hợp lệ!");
                return;
            }
            if(txtTuoi.Text.Length == 0 || !int.TryParse(txtTuoi.Text, out int tuoi) || tuoi < 0)
            {
                MessageBox.Show("Tuổi phải là một số nguyên dương!");
                return;
            }
            if (BacSiDAL.Instance.UpdateBacSi(Convert.ToInt32(txtbacsiid.Text), txtHoTen.Text, Convert.ToInt32(cbcChuyenKhoa.SelectedValue), txtSDT.Text, txtEmail.Text, cbcTrinhDo.Text, cbcChucVu.Text, Convert.ToInt32(txtTuoi.Text), txtChiPhiKham.Text))
            {
                MessageBox.Show("Cập nhật thông tin bác sĩ thành công!");
                LoadDanhSachTaiKhoan();
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin bác sĩ thất bại!");
            }
        }

        private void cbcChuyenKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnXoaBS_Click(object sender, EventArgs e)
        {
            if (BacSiDAL.Instance.DeleteBacSi(Convert.ToInt32(txtbacsiid.Text)))
            {
                MessageBox.Show("Xóa bác sĩ thành công!");
                LoadDanhSachTaiKhoan();
            }
            else
            {
                MessageBox.Show("Xóa bác sĩ thất bại!");
            }
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            if (txtHoTenBN.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên bệnh nhân.");
                return;
            }
            if (txtSoDienThoai.Text.Trim() == "" || txtSoDienThoai.Text.Length < 10 || txtSoDienThoai.Text.Length > 11)
            {
                MessageBox.Show("Vui lòng nhập số điện thoại hợp lệ (10-11 ký tự).");
                return;
            }
            if(dtpNgaySinh.Value >= DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không hợp lệ! Vui lòng chọn ngày sinh trước ngày hiện tại.");
                return;
            }
            if (BenhNhanDAL.Instance.SuaThongTinBenhNhan(Convert.ToInt32(txtbenhnhanid.Text), txtHoTenBN.Text, dtpNgaySinh.Value, ckbNam.Checked, txtSoDienThoai.Text, txtDiaChiBN.Text))
            {
                MessageBox.Show("Cập nhật thông tin bệnh nhân thành công!");
                LoadDanhSachTaiKhoan();
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin bệnh nhân thất bại!");
            }
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            if (BenhNhanDAL.Instance.XoaBenhNhanVaTaiKhoan(Convert.ToInt32(txtbenhnhanid.Text)))
            {
                MessageBox.Show("Xóa bệnh nhân thành công!");
                LoadDanhSachTaiKhoan();
            }
            else
            {
                MessageBox.Show("Xóa bệnh nhân thất bại!");
            }
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dataGridView1.HitTest(e.X, e.Y);
                if (hit.RowIndex >= 0)
                {
                    // Chọn dòng đang click chuột phải
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[hit.RowIndex].Selected = true;
                    contextMenuStrip1.Show(dataGridView1, new Point(e.X, e.Y));
                }
            }
        }

        private void resetMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;
                var row = dataGridView1.Rows[rowIndex];

                int id = Convert.ToInt32(row.Cells["TaiKhoanID"].Value);
                string tenDangNhap = row.Cells["TenDangNhap"].Value.ToString();
                TaiKhoanDAL.Instance.UpdateTaiKhoan(tenDangNhap, "WZRHGrsBESr8wYFZ9sx0tPURuZgG2lmzyvWpwXPKz8U=", id);
                MessageBox.Show("Đặt lại mật khẩu thành công! Mật khẩu mới là: 12345");
            }
        }

        private void xóaTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;
                var row = dataGridView1.Rows[rowIndex];

                int id = Convert.ToInt32(row.Cells["TaiKhoanID"].Value);
                int bacSiID = Convert.ToInt32(row.Cells["BacSiID"].Value);
                int benhNhanID = Convert.ToInt32(row.Cells["BenhNhanID"].Value);
                if(bacSiID != 0)
                {
                    if (BacSiDAL.Instance.DeleteBacSi(bacSiID))
                    {
                        TaiKhoanDAL.Instance.DeleteTaiKhoan(id);
                        MessageBox.Show("Xóa tài khoản bác sĩ thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Xóa tài khoản bác sĩ thất bại!");
                    }
                }
                else if (benhNhanID != 0)
                {
                    if (BenhNhanDAL.Instance.XoaBenhNhanVaTaiKhoan(benhNhanID))
                    {
                        TaiKhoanDAL.Instance.DeleteTaiKhoan(id);
                        MessageBox.Show("Xóa tài khoản bệnh nhân thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Xóa tài khoản bệnh nhân thất bại!");
                    }
                }
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true; // Ngăn DataGridView xuống dòng
                if (dataGridView1.CurrentRow != null)
                {
                    int rowIndex = dataGridView1.CurrentCell.RowIndex;
                    int columnIndex = dataGridView1.CurrentCell.ColumnIndex;
                    dataGridView1_CellClick(dataGridView1, new DataGridViewCellEventArgs(columnIndex, rowIndex));
                }
            }
        }

        private void siticoneButton2_Click_1(object sender, EventArgs e)
        {
            FormThemTaiKhoan formThemTaiKhoan = new FormThemTaiKhoan();
            formThemTaiKhoan.ShowDialog();
            LoadDanhSachTaiKhoan(); 
        }

        private void pnlBacsi_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticoneTextBox1_TextChanged(object sender, EventArgs e)
        {
            if(txtTimKiem.Text != "")
                LoadDanhSachTimKiem();
            else
                LoadDanhSachTaiKhoan();
        }

        private void pnlBenhnhan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            LoadDanhSachBacsi();
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            LoadDanhSachBenhnhan();
        }
    }
}
