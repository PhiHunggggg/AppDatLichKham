using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDatLichKham.Entity
{
    internal class BacSi
    {
        public BacSi() { }
        public BacSi(int bacsiid,string hoten,int chuyenkhoaid,string sdt, string email,string trinhdo,string chucvu,int tuoi,string chiphikham,int taikhoanid) {
            this.BacSiID = bacsiid;
            this.HoTen=hoten;
            this.ChuyenKhoaID = chuyenkhoaid;
            this.SDT = sdt;
            this.Email = email;
            this.ChiPhiKham = chucvu;
            this.Tuoi = tuoi;
            this.Trinhdo = trinhdo;
            this.ChucVu=chucvu;
            this.TaiKhoanID = taikhoanID;
        }
        private int bacsid;
        public int BacSiID { get { return bacsid; } set { bacsid = value; } }
        private string hoten;
        public string HoTen { get { return hoten; } set { hoten = value; } }
        private int chuyenkhoaid;
        public int ChuyenKhoaID { get { return chuyenkhoaid; } set { chuyenkhoaid = value; } }
        private string sdt;
        public string SDT { get { return sdt; } set { sdt = value; } }
        private string email;
        public string Email { get { return email; } set { email = value; } }
        private string trinhdo;
        public string Trinhdo { get { return trinhdo; } set { trinhdo = value; } }
        private string chucVu;
        public string ChucVu { get { return chucVu; } set { chucVu = value; } }
        private int tuoi;
        public int Tuoi { get { return tuoi; } set { tuoi = value; } }
        private string chiPhiKham;
        public string ChiPhiKham { get { return chiPhiKham; } set {chiPhiKham = value; } }
        public string ChuyenKhoa { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public int taikhoanID { get; set; }
        private int taikhoanid;
        public int TaiKhoanID { get { return taikhoanid; } set { taikhoanid = value; } }
    }
}
