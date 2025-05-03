using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDatLichKham.Entity
{
    internal class LichKham
    {
        public LichKham() { }
        
        public LichKham(int maLich, int maBS, DateTime ngayKham, DateTime gioBatDau, DateTime gioKetThuc, string trangThai)
        {
            this.MaLich = maLich;
            this.MaBS = maBS;
            this.NgayKham = ngayKham;
            this.GioBatDau = gioBatDau;
            this.GioKetThuc = gioKetThuc;
            this.TrangThai = trangThai;
        }
        private int malich;
        public int MaLich { get=> malich; set => malich=value; }
        private int maBS;
        public int MaBS { get => maBS; set => maBS = value; }
        private DateTime ngayKham;
        public DateTime NgayKham { get => ngayKham; set => ngayKham = value; }
        private DateTime gioBatDau;
        public DateTime GioBatDau { get => gioBatDau; set => gioBatDau = value; }
        private DateTime gioKetThuc;
        public DateTime GioKetThuc { get => gioKetThuc; set => gioKetThuc = value; }
        private string trangThai;
        public string TrangThai { get => trangThai; set => trangThai = value; }


    }
}
