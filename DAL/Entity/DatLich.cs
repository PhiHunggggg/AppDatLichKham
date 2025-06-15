using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDatLichKham.Entity
{
    internal class DatLich
    {
        public DatLich() { }
        public DatLich(int datLichID, int bacSiID, int benhNhanID, string hoTen, bool gioiTinh, string sdt, string diaChi, string ghiChu, DateTime ngayHen, TimeSpan gioDangki, DateTime thoiGian, bool khanCap, bool? trangThai)
        {

            this.DatLichID = datLichID;
            this.BacSiID = bacSiID;
            this.BenhNhanID = benhNhanID;
            this.HoTen = hoTen;
            this.GioiTinh = gioiTinh;
            this.Sdt = sdt;
            this.DiaChi = diaChi;
            this.GhiChu = ghiChu;
            this.NgayHen = ngayHen;
            this.GioDangki = gioDangki;
            this.ThoiGian = thoiGian;
            this.KhanCap = khanCap;
            this.TrangThai = trangThai;
        }
        private int datLichID;
        public int DatLichID { get { return datLichID; } set { datLichID = value; } }
        private int bacSiID;
        public int BacSiID { get { return bacSiID; } set { bacSiID = value; } }
        private int benhNhanID;
        public int BenhNhanID { get { return benhNhanID; } set { benhNhanID = value; } }
        private string hoTen;
        public string BacSiHoTen { get; set; } // Thêm thuộc tính này

        public string HoTen { get { return hoTen; } set { hoTen = value; } }
        private bool gioiTinh;
        public bool GioiTinh { get { return gioiTinh; } set { gioiTinh = value; } }
        private string diaChi;
        public string DiaChi { get { return diaChi; } set { diaChi = value; } }
        private string sdt;
        public string Sdt { get { return sdt; } set { sdt = value; } }
        private string ghiChu;
        public string GhiChu { get { return ghiChu; } set { ghiChu = value; } }
        private DateTime ngayHen;
        public DateTime NgayHen { get { return ngayHen; } set { ngayHen = value; } }
        private TimeSpan gioDangki;
        public TimeSpan GioDangki { get { return gioDangki; } set { gioDangki = value; } }
        public string GioiTinhString
        {
            get { return GioiTinh ? "Nam" : "Nữ"; }
        }
        private DateTime thoiGian;
        public DateTime ThoiGian { get { return thoiGian; } set { thoiGian = value; } }
        private bool khanCap;
        public bool KhanCap { get { return khanCap; } set { khanCap = value; } }
        private bool? trangThai;
        public bool? TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }
        public string TrangThaiString
        {
            get
            {
                if (TrangThai == false)
                    return "Bị từ chối";
                else if (TrangThai == true)
                    return "Đã xác nhận";
                else
                    return "Chưa xác nhận";
            }
        }
        public string KhanCapString
        {
            get
            { return KhanCap ? "Có" : "Không"; }
        }
        public bool IsGroupHeader { get; set; } = false;
        public string GroupTitle
        {
            get; set;
        }
    }
}
