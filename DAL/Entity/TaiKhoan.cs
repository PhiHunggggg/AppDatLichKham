using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDatLichKham.Entity
{
    internal class TaiKhoan
    {
       
        public TaiKhoan() { }
        public TaiKhoan(int TaiKhoanID, string TenDangNhap, string MatKhau, string LoaiTaiKhoan, int BenhNhanId, int BacSiID)
        {
            this.TaiKhoanID = TaiKhoanID;
            this.TenDangNhap = TenDangNhap;
            this.MatKhau = MatKhau;
            this.LoaiTaiKhoan = LoaiTaiKhoan;
            this.BenhNhanID = BenhNhanId;
            this.BacSiID = BacSiID;
        }
        private int malich;
        public int TaiKhoanID { get=>malich; set=>malich=value; }
        private string tendangnhap;
        public string TenDangNhap { get=>tendangnhap; set=>tendangnhap=value;}
        private string matKhau;
        public string MatKhau { get=>matKhau; set=>matKhau=value;}
        private string loaitaikhoan;
        public string LoaiTaiKhoan { get=>loaitaikhoan; set=>loaitaikhoan=value;}
        private int benhnhanid;
        public  int BenhNhanID { get => benhnhanid; set => benhnhanid = value; }
        private  int bacsiid;
        public int BacSiID { get => bacsiid; set => bacsiid = value; }
        public string LoaiTaiKhoanHienThi
        {
            get
            {
                if (LoaiTaiKhoan == "BenhNhan")
                    return "Bệnh Nhân";
                else if (LoaiTaiKhoan == "BacSi")
                    return "Bác Sĩ";
                else if (LoaiTaiKhoan == "Admin")
                    return "Quản Trị Viên";
                else
                    return "Không xác định";
            }
        }
    }
}
