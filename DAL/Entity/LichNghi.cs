using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDatLichKham.DAL.Entity
{
    internal class LichNghi
    {
        public LichNghi() { }
        public LichNghi(int lichNghiID, int bacSiID, DateTime ngayNghi, TimeSpan caNghi, string lyDo, bool trangThai)
        {
            this.LichNghiID = lichNghiID;
            this.BacSiID = bacSiID;
            this.NgayNghi = ngayNghi;
            this.CaNghi = caNghi;
            this.LyDo = lyDo;
            this.TrangThai = trangThai;
        }
        private int lichNghiID;
        public int LichNghiID { get => lichNghiID; set => lichNghiID = value; }
        private int bacSiID;
        public int BacSiID { get => bacSiID; set => bacSiID = value; }
        private DateTime ngayNghi;
        public DateTime NgayNghi { get => ngayNghi; set => ngayNghi = value; }
        private TimeSpan caNghi;
        public TimeSpan CaNghi { get => caNghi; set => caNghi = value; }
        private string lyDo;
        public string LyDo { get => lyDo; set => lyDo = value; }
        private bool trangThai;
        public bool TrangThai { get => trangThai; set => trangThai = value; }
        private string trangthaiString;
        public string TrangThaiString
        {
            get
            {
                return trangThai ? "Đã duyệt" : "Chưa duyệt";
            }
            set => trangthaiString = value;
        }
        public string BacSiHoTen { get; set; } 
        public string CaNghiString
        {
            get
            {
                return caNghi == TimeSpan.Zero ? "Nghỉ cả ngày" : caNghi.ToString(@"hh\:mm");
            }
            set => caNghi = TimeSpan.Parse(value);
        }
    }
}
