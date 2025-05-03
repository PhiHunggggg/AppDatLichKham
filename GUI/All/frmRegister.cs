using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppDatLichKham.DAL;

namespace AppDatLichKham.GUI.All
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }
        public bool checkAccount(string ac)
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }
        private void frmRegister_Load(object sender, EventArgs e)
        {
            txtMat_khau.Font = txtNhap_lai_mk.Font = txtTen_dang_nhap.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            txtTen_dang_nhap.Text = "(Account)";
            txtMat_khau.Text = "(Password)";
            txtNhap_lai_mk.Text = "(Repeat password)";
        }

        private void txtTen_dang_nhap_Leave(object sender, EventArgs e)
        {
            if (txtTen_dang_nhap.Text.Trim() == "")
            {
                txtTen_dang_nhap.ForeColor = Color.DarkGray;
                txtTen_dang_nhap.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                txtTen_dang_nhap.Text = "(Account)";
            }
        }

        private void txtTen_dang_nhap_Enter(object sender, EventArgs e)
        {
            txtTen_dang_nhap.ForeColor = Color.Black;
            txtTen_dang_nhap.Font = new Font("Arial", 12, FontStyle.Bold);
            txtTen_dang_nhap.Text = "";
        }

        private void txtMat_khau_Enter(object sender, EventArgs e)
        {
            txtMat_khau.ForeColor = Color.Black;
            txtMat_khau.Font = new Font("Arial", 12, FontStyle.Bold);
            txtMat_khau.Text = "";

        }

        private void txtMat_khau_Leave(object sender, EventArgs e)
        {
            if (txtMat_khau.Text.Trim() == "")
            {
                txtMat_khau.ForeColor = Color.DarkGray;
                txtMat_khau.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                txtMat_khau.Text = "(Password)";
            }
        }

        private void txtNhap_lai_mk_Enter(object sender, EventArgs e)
        {
            txtNhap_lai_mk.ForeColor = Color.Black;
            txtNhap_lai_mk.Font = new Font("Arial", 12, FontStyle.Bold);
            txtNhap_lai_mk.Text = "";
        }


        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            if (txtTen_dang_nhap.Text.Trim() == "" || txtTen_dang_nhap.Text.Trim() == "(Account)")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản.");
                return;
            }
            if (txtMat_khau.Text.Trim() == "" || txtMat_khau.Text.Trim() == "(Password)")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.");
                return;
            }
            if (txtNhap_lai_mk.Text.Trim() == "" || txtNhap_lai_mk.Text.Trim() == "(Repeat password)")
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu.");
                return;
            }

            if (txtMat_khau.Text != txtNhap_lai_mk.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp!");
                return;
            }
            if (!checkBox1.Checked) { MessageBox.Show("Vui lòng xác nhận về điều khoản sử dụng "); return; }
            if (!checkAccount(txtTen_dang_nhap.Text)) { MessageBox.Show("Vui lòng nhập tên tài khoản dài 6-24 ký tự chữ và số, chữ hoa và chữ thường"); return; }
            string username = txtTen_dang_nhap.Text;
            string password = Security.EncryptPassword(txtMat_khau.Text);
            if (TaiKhoanDAL.Instance.KiemTraTonTaiTaiKhoan(username))
            {
                MessageBox.Show("Tài khoản đã tồn tại");
                return;
            }
            bool isSuccess = TaiKhoanDAL.Instance.DangKy(username, password, "BenhNhan");

            if (isSuccess)
            {
                MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void txtNhap_lai_mk_Leave(object sender, EventArgs e)
        {
            if (txtNhap_lai_mk.Text.Trim() == "")
            {
                txtNhap_lai_mk.ForeColor = Color.DarkGray;
                txtNhap_lai_mk.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                txtNhap_lai_mk.Text = "(Repeat password)";
            }
        }
    }
}
