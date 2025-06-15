using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AppDatLichKham.Entity
{
    internal class BenhNhan
    {
        public BenhNhan() { }
        public BenhNhan(int benhnhanid, string hoten,DateTime ngaysinh,bool gioitinh,string diachi,string sdt, string taikhoanid)
        {
            this.BenhNhanID = benhnhanid;
            this.Hoten = hoten;
            this.Ngaysinh = ngaysinh;
            this.Gioitinh = gioitinh;
            this.Diachi = diachi;
            this.Sdt = sdt;
            this.taikhoanid = taikhoanID;
        }
        private int benhnhanid;
        public int BenhNhanID{get{return benhnhanid;}set { benhnhanid = value; } }

        private string hoten;
        public string Hoten{get{return hoten;}set { hoten = value; } }

        private DateTime ngaysinh;
        public DateTime Ngaysinh{get{return ngaysinh;}set { ngaysinh = value; } }

        public bool gioitinh;
        public bool Gioitinh { get { return gioitinh; } set { gioitinh = value; } }
        public string diachi;
        public string Diachi { get { return diachi; } set { diachi = value; } }
        public string sdt;
        public string Sdt { get { return sdt; } set { sdt = value; } }
        public string GioiTinhString
        {
            get { return Gioitinh ? "Nam" : "Nữ"; }
        }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public int taikhoanID { get; set; }
        private int taikhoanid;
        public int TaiKhoanID { get { return taikhoanid; } set { taikhoanid = value; } }
    }
}
