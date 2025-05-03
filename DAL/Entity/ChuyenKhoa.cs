using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDatLichKham.Entity
{
    internal class ChuyenKhoa
    {
        public ChuyenKhoa() { }
        public ChuyenKhoa(int chuyenkhoaid, string tenchuyenkhoa)
        {
            this.ChuyenKhoaID = chuyenkhoaid;
            this.TenChuyenKhoa = tenchuyenkhoa;
        }
        private int chuyenkhoaid;
        private string tenchuyenkhoa;
        public int ChuyenKhoaID { get { return chuyenkhoaid; } set { chuyenkhoaid = value; } }
        public string TenChuyenKhoa { get { return tenchuyenkhoa; } set { tenchuyenkhoa = value; } }

    }
}
