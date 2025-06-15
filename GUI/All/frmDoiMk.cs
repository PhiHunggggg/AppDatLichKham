using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppDatLichKham.DAL;
using AppDatLichKham.Entity;

namespace AppDatLichKham.GUI.All
{
    public partial class frmDoiMk : Form
    {
        public frmDoiMk()
        {
            InitializeComponent();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            if (StaticThing.LoaiTaiKhoan == "BenhNhan")
            {
                int taikhoanid = TaiKhoanDAL.Instance.GetTaiKhoanIDbyBenhNhanID(StaticThing.idBenhNhanTaiKhoan);
                TaiKhoan taiKhoan = TaiKhoanDAL.Instance.GetTaiKhoanByID(taikhoanid);
                if (taiKhoan.MatKhau != Security.EncryptPassword(txtMatKhauCu.Text.Trim()))
                {
                    MessageBox.Show("Mật khẩu cũ không đúng!");
                    return;
                }
                if (txtMatKhauCu.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu cũ.");
                    return;
                }
                if (txtMatKhau.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu mới.");
                    return;
                }
                if (txtNhaplai.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập lại mật khẩu mới.");
                    return;
                }
                
                if (txtMatKhau.Text != txtNhaplai.Text)
                {
                    MessageBox.Show("Mật khẩu mới nhập lại không khớp!");
                    return;
                }
                string tendangnhap = taiKhoan.TenDangNhap.Trim();

                bool isSuccess = TaiKhoanDAL.Instance.UpdateTaiKhoan(tendangnhap, Security.EncryptPassword(txtMatKhau.Text), taikhoanid);

                if (isSuccess)
                {
                    MessageBox.Show("Đổi mật khẩu thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu thất bại! Vui lòng kiểm tra lại thông tin.");
                }
            }
            else if (StaticThing.LoaiTaiKhoan == "BacSi")
            {
                int taikhoanid = TaiKhoanDAL.Instance.GetTaiKhoanIDbyBacSiID(StaticThing.idBacSiTaiKhoan);
                TaiKhoan taiKhoan = TaiKhoanDAL.Instance.GetTaiKhoanByID(taikhoanid);
                if (taiKhoan.MatKhau != Security.EncryptPassword(txtMatKhauCu.Text.Trim()))
                {
                    MessageBox.Show("Mật khẩu cũ không đúng!");
                    return;
                }
                if (txtMatKhauCu.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu cũ.");
                    return;
                }
                if (txtMatKhau.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu mới.");
                    return;
                }
                if (txtNhaplai.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập lại mật khẩu mới.");
                    return;
                }
                if (txtMatKhau.Text != txtNhaplai.Text)
                {
                    MessageBox.Show("Mật khẩu mới nhập lại không khớp!");
                    return;
                }
                string tendangnhap = taiKhoan.TenDangNhap.Trim();
                bool isSuccess = TaiKhoanDAL.Instance.UpdateTaiKhoan(tendangnhap, Security.EncryptPassword(txtMatKhau.Text), taikhoanid);
                if (isSuccess)
                {
                    MessageBox.Show("Đổi mật khẩu thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu thất bại! Vui lòng kiểm tra lại thông tin.");
                }
            }
            else if (StaticThing.LoaiTaiKhoan == "Admin")
            {
                if (StaticThing.mk != Security.EncryptPassword(txtMatKhauCu.Text.Trim()))
                {
                    MessageBox.Show("Mật khẩu cũ không đúng!");
                    return;
                }
                if (txtMatKhauCu.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu cũ.");
                    return;
                }
                if (txtMatKhau.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu mới.");
                    return;
                }
                if (txtNhaplai.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập lại mật khẩu mới.");
                    return;
                } 
                if (txtMatKhau.Text != txtNhaplai.Text)
                {
                    MessageBox.Show("Mật khẩu mới nhập lại không khớp!");
                    return;
                }
                string tendangnhap = StaticThing.TenDangNhap.Trim();
                bool isSuccess = TaiKhoanDAL.Instance.UpdateTaiKhoan(tendangnhap, Security.EncryptPassword(txtMatKhau.Text), StaticThing.idTaiKhoan);
                if (isSuccess)
                {
                    MessageBox.Show("Đổi mật khẩu thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu thất bại! Vui lòng kiểm tra lại thông tin.");
                }

            }
        }
    }
}
