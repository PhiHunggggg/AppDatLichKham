using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDatLichKham.Entity
{
    internal class LichLamViec
    {
        public LichLamViec() { }
        public LichLamViec(int lichid, int bacsiid, DateTime ngay, TimeSpan giobatdau, TimeSpan gioketthuc ,bool trangthai,int lichhenid)
        {
            this.LichID = lichid;
            this.BacSiID = bacsiid;
            this.Ngay = ngay;
            this.GioBatDau = giobatdau;
            this.GioKetThuc = gioketthuc;
            this.TrangThai = trangthai;
            this.lichhenid = lichhenid;
        }
        private int lichid;
        public int LichID { get => lichid; set => lichid = value; }
        private int bacsiid;
        public int BacSiID { get => bacsiid; set => bacsiid = value; }
        private DateTime ngaylamviec;
        public string HoTenNguoiKham { get; set; }
        public DateTime Ngay { get => ngaylamviec; set => ngaylamviec = value; }
        private TimeSpan giobatdau;
        public TimeSpan GioBatDau { get => giobatdau; set => giobatdau = value; }
        private TimeSpan gioketthuc;
        public TimeSpan GioKetThuc { get => gioketthuc; set => gioketthuc = value; }
        public int PhongKham { get; set; }  

        private bool trangthai;
        public bool TrangThai { get => trangthai; set => trangthai = value; }
        private int lichhenid;
        public int LichHenID { get => lichhenid; set => lichhenid = value; }
    }
}
