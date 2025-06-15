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

namespace AppDatLichKham.GUI.All
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            DialogResult = DialogResult.None;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (DatLichDAL.Instance.XoaDatLichCu())
            {
            }
            else
            {
            }
            LichHenDAL.Instance.XoaLichHenCu();
            txtMat_khau.PasswordChar = '\0';
            txtMat_khau.Font = txtTai_khoan.Font = new Font("Arial", 10, FontStyle.Regular);
            txtTai_khoan.Text = "(Account)";
            txtMat_khau.Text = "(Password)";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtTai_khoan.Text.Trim() == "" || txtTai_khoan.Text == "(Account)") { MessageBox.Show("Vui lòng nhập tên tài khoản. "); return; }
            if (txtMat_khau.Text.Trim() == "" || txtMat_khau.Text == "(Password)") { MessageBox.Show("Vui lòng nhập mật khẩu."); return; }
            string username = txtTai_khoan.Text;
            string password =Security.EncryptPassword( txtMat_khau.Text);

            // Kiểm tra tài khoản
            string loaiTaiKhoan = TaiKhoanDAL.Instance.DangNhap(username, password);
            if (loaiTaiKhoan != null)
            {

                if (loaiTaiKhoan == "BacSi")
                {
                    StaticThing.LoaiTaiKhoan = "BacSi";
                    try
                    {
                        StaticThing.idBacSiTaiKhoan = TaiKhoanDAL.Instance.GetBacSiID(username, password);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi lấy ID bệnh nhân: " + ex.Message);
                    }
                }
                else if (loaiTaiKhoan == "BenhNhan")
                {
                    StaticThing.LoaiTaiKhoan = "BenhNhan";
                    try
                    {
                        StaticThing.idBenhNhanTaiKhoan = TaiKhoanDAL.Instance.GetBenhNhanID(username, password);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi lấy ID bệnh nhân: " + ex.Message);
                    }
                }
                else if (loaiTaiKhoan == "Admin")
                {
                    StaticThing.LoaiTaiKhoan = "Admin";
                }
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Login successful !!!");
                int taiKhoanID = TaiKhoanDAL.Instance.GetTaiKhoanID(username, password);
                StaticThing.idTaiKhoan = taiKhoanID;
                StaticThing.mk = password;
                StaticThing.TenDangNhap = username;
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tài khoản, mật khẩu hoặc email! Vui lòng thử lại.");
                txtTai_khoan.Clear();
                txtMat_khau.Font = txtTai_khoan.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                txtTai_khoan.ForeColor = txtMat_khau.ForeColor = Color.DarkGray;
                txtTai_khoan.Text = "(Account)";
                txtMat_khau.Clear();
                txtMat_khau.Text = "(Password)";
                txtMat_khau.PasswordChar = '\0';
                txtTai_khoan.Focus();
                this.DialogResult = DialogResult.None;
            }
        }

        private void btnsign_Click(object sender, EventArgs e)
        {
            frmRegister frmRegister = new frmRegister();
            frmRegister.ShowDialog();
        }

        private void txtTai_khoan_Enter(object sender, EventArgs e)
        {
            
            txtTai_khoan.ForeColor = Color.Black;
            txtTai_khoan.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            txtTai_khoan.Text = "";
        }

        private void txtTai_khoan_Leave(object sender, EventArgs e)
        {
            if (txtTai_khoan.Text.Trim() == "")
            {
                txtTai_khoan.ForeColor = Color.DarkGray;
                txtTai_khoan.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                txtTai_khoan.Text = "(Account)";
            }
        }

        private void txtMat_khau_Enter(object sender, EventArgs e)
        {
            txtMat_khau.ForeColor = Color.Black;
            txtMat_khau.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            txtMat_khau.Text = "";
            if(ckbHienthimatkhau.Checked == true)
            {
                txtMat_khau.PasswordChar = '\0';
            }
            else
            {
                txtMat_khau.PasswordChar = '*';
            }
        }

        private void txtMat_khau_Leave(object sender, EventArgs e)
        {
            if (txtMat_khau.Text.Trim() == "")
            {
                txtMat_khau.ForeColor = Color.DarkGray;
                txtMat_khau.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                txtMat_khau.Text = "(Password)";
                txtMat_khau.PasswordChar = '\0';
            }
        }

        private void btnLogin_Enter(object sender, EventArgs e)
        {
            btnLogin.FillColor = Color.Purple;
        }

        private void btnLogin_Leave(object sender, EventArgs e)
        {
            btnLogin.FillColor = Color.DeepSkyBlue;
        }

        private void btnsign_Enter(object sender, EventArgs e)
        {
            btnsign.FillColor = Color.Purple;
        }

        private void btnsign_Leave(object sender, EventArgs e)
        {
            btnsign.FillColor = Color.MediumBlue;
        }
    }
}
