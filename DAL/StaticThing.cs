using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDatLichKham.DAL
{
    public static class StaticThing
    {
        public static string LoaiTaiKhoan =null;
        public static int idBenhNhanTaiKhoan = -1;
        public static int idBacSiTaiKhoan = -1;
        public static int idTaiKhoan = -1;
        public static string mk = "";
        public static string TenDangNhap = null;
        public static int chieudai = 0;
        public static int TinhTuoi(DateTime ngaySinh)
        {
            DateTime today = DateTime.Today;
            int tuoi = today.Year - ngaySinh.Year;
            return (tuoi < 0) ? 0 : tuoi;
        }
    }
}
