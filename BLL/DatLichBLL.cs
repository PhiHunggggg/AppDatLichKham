using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDatLichKham.BLL
{
    internal class DatLichBLL
    {
        private static DatLichBLL instance;
        public static DatLichBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DatLichBLL();
                }
                return instance;
            }
            private set => instance = value;
        }
        private DatLichBLL() { }
        public bool ThemDatLich(string bacSiID, int benhNhanID, string hoTen, bool gioiTinh, string sdt, string diaChi, string ghiChu, string ngayHen, string gioDangki)
        {
            if (string.IsNullOrEmpty(bacSiID)|| string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(sdt) || string.IsNullOrEmpty(diaChi) || string.IsNullOrEmpty(ngayHen) || string.IsNullOrEmpty(gioDangki) /**/)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; // Trả về false nếu có trường nào đó rỗng
            }
            else if(sdt.Length < 10 || sdt.Length > 11)
            {
                MessageBox.Show("Số điện thoại không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; // Trả về false nếu số điện thoại không hợp lệ
            }
            else if (DAL.DatLichDAL.Instance.CheckDaDatLich(benhNhanID, DateTime.Parse(ngayHen)))
            {
                MessageBox.Show("Bạn đã đặt lịch khám vào ngày này rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; // Trả về false nếu đã đặt lịch vào ngày này
            }
            else if (DAL.LichLamViecDAL.Instance.CheckCaTrung(int.Parse(bacSiID), DateTime.Parse(ngayHen), TimeSpan.Parse(gioDangki)))
            {
                MessageBox.Show("Bác sĩ đã có lịch khám vào thời gian này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; // Trả về false nếu bác sĩ đã có lịch khám vào thời gian này
            }
            else
            {
                int bacSiIDInt = int.Parse(bacSiID);
                DateTime ngayHenDatetime = ngayHen == "" ? DateTime.Now : DateTime.Parse(ngayHen);
                TimeSpan gioDangkiTimespan = TimeSpan.Parse(gioDangki);
                return DAL.DatLichDAL.Instance.ThemDatLich(bacSiIDInt, benhNhanID, hoTen, gioiTinh, sdt, diaChi, ghiChu, ngayHenDatetime, gioDangkiTimespan);
            }
        }
        public int DemSoLichDaXacNhan(string bacSiID, string ngayHen, string giohen)
        {
            // Chuyển đổi các tham số từ string sang kiểu dữ liệu tương ứng
            int bacSiIDInt = int.Parse(bacSiID);
            DateTime ngayHenDatetime = ngayHen == "" ? DateTime.Now : DateTime.Parse(ngayHen);
            TimeSpan giohenTimespan = TimeSpan.Parse(giohen);
            return DAL.DatLichDAL.Instance.DemSoLichDaXacNhan(bacSiIDInt, ngayHenDatetime, giohenTimespan);
        }
    }
}
