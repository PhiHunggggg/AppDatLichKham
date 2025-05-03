using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppDatLichKham.BLL;
using AppDatLichKham.DAL;
using AppDatLichKham.Entity;

namespace AppDatLichKham.GUI.BenhNhan
{
    public partial class frmThongTinBenhNhan : Form
    {
        public frmThongTinBenhNhan()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void LoadThongTin()
        {
            AppDatLichKham.Entity.BenhNhan bn = TaiKhoanDAL.Instance.GetBenhNhanByID(StaticThing.idBenhNhanTaiKhoan);
            txtTenBenhNhan.Text = bn.Hoten;
            lblDiachi.Text = bn.Diachi;
            lblSDT.Text = bn.Sdt;
            lblHoten.Text = bn.Hoten;
            lblGioiTinh.Text = bn.Gioitinh == true ? "Nam" : "Nữ";
            lblNgaysinh.Text = bn.Ngaysinh.ToString("dd/MM/yyyy");
            dateTimePicker1.Value = bn.Ngaysinh;
            if (bn.Gioitinh == true)
            {
                ckbNam.Checked = true;
            }
            else
            {
                ckbNu.Checked = true;
            }
            txtDiachi.Text = bn.Diachi;
            txtSDT.Text = bn.Sdt;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            DateTime ngaysinh = dateTimePicker1.Value;
            bool gioitinh;
            if (ckbNam.Checked)
            {
                gioitinh = true;
            }
            else
            {
                gioitinh = false;
            }
            bool suaxong = BenhNhanBLL.Instance.SuaThongTinBenhNhan(StaticThing.idBenhNhanTaiKhoan, txtTenBenhNhan.Text, ngaysinh, gioitinh, txtSDT.Text, txtDiachi.Text);
            if (suaxong)
            {
                MessageBox.Show("Cập nhật thông tin thành công!");
                LoadThongTin();
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin thất bại!");
            }
        }

        private void ckbNam_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbNam.Checked)
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
            if (ckbNu.Checked)
            {
                ckbNam.Checked = false;
            }
            else
            {
                ckbNam.Checked = true;
            }
        }


        private void frmThongTinBenhNhan_Load_1(object sender, EventArgs e)
        {
            LoadThongTin();

        }
    }
}
