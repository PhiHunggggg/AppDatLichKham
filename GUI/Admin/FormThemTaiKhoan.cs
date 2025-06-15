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

namespace AppDatLichKham.GUI.Admin
{
    public partial class FormThemTaiKhoan : Form
    {
        public FormThemTaiKhoan()
        {
            InitializeComponent();
        }
        public bool checkAccount(string ac)
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
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
            string loaiTaiKhoan=siticoneComboBox1.SelectedItem.ToString();
            bool isSuccess = TaiKhoanDAL.Instance.DangKy(username, password, loaiTaiKhoan);

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
    }
}
