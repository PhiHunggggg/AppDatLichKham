using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDatLichKham.DAL.Entity
{
    internal class LichSuKham
    {
        public LichSuKham() { }
        public LichSuKham(int lichSuKhamID, string tenBacSi, string tenBenhNhan, DateTime ngayKham, TimeSpan gioKham, TimeSpan gioDen, string donThuoc, string ghiChu,int bacSiID,int benhNhanID)
        {
            this.LichSuID = lichSuKhamID;
            this.TenBacSi = tenBacSi;
            this.TenBenhNhan = tenBenhNhan;
            this.NgayHen = ngayKham;
            this.GioHen = gioKham;
            this.donThuoc = donThuoc;
            this.GhiChu = ghiChu;
            this.BacSiID = bacSiID;
            this.BenhNhanID = benhNhanID;
        }
        private int bacSiID;
        public int BacSiID { get => bacSiID; set => bacSiID = value; }
        private int benhNhanID;
        public int BenhNhanID { get => benhNhanID; set => benhNhanID = value; }

        private int lichSuKhamID;
        public int LichSuID { get => lichSuKhamID; set => lichSuKhamID = value; }
        private string tenBacSi;
        public string TenBacSi { get => tenBacSi; set => tenBacSi = value; }
        private string tenBenhNhan;
        public string TenBenhNhan { get => tenBenhNhan; set => tenBenhNhan = value; }
        private DateTime ngayKham;
        public DateTime NgayHen { get => ngayKham; set => ngayKham = value; }
        private TimeSpan gioKham;
        public TimeSpan GioHen { get => gioKham; set => gioKham = value; }
        private TimeSpan gioDen;
        public TimeSpan GioDen { get => gioDen; set => gioDen = value; }
        private string donThuoc;
        public string DonThuoc { get => donThuoc; set => donThuoc = value; }
        private string ghiChu;
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
    }
}
