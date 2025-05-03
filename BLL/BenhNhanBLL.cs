using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppDatLichKham.DAL;

namespace AppDatLichKham.BLL
{
    internal class BenhNhanBLL
    {
        private static BenhNhanBLL instance;
        public static BenhNhanBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BenhNhanBLL();
                }
                return instance;
            }
            private set => instance = value;
        }
        private BenhNhanBLL() { }
        public bool SuaThongTinBenhNhan(int benhNhanid, string hoTen, DateTime ngaySinh, bool gioiTinh, string sdt, string diaChi)
        {
            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(sdt) || string.IsNullOrEmpty(diaChi))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; // Trả về false nếu có trường nào đó rỗng
            }
            else if (sdt.Length < 10 || sdt.Length > 11)
            {
                MessageBox.Show("Số điện thoại không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; // Trả về false nếu số điện thoại không hợp lệ
            }
            else
            {
                return BenhNhanDAL.Instance.SuaThongTinBenhNhan(benhNhanid, hoTen, ngaySinh, gioiTinh, sdt, diaChi);
            }
        }
    }
}
