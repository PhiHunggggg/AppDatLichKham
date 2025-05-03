using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppDatLichKham.Entity;
using Microsoft.Data.SqlClient;
namespace AppDatLichKham.DAL
{
    internal class BenhNhanDAL : DataProvider
    {
        private static BenhNhanDAL instance;
        public new static BenhNhanDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BenhNhanDAL();
                }
                return instance;
            }
            private set => instance = value;
        }
        private BenhNhanDAL() { }
        public bool SuaThongTinBenhNhan(int benhNhanid, string hoTen, DateTime ngaySinh, bool gioiTinh, string sdt, string diaChi)
        {
            try
            {
                string query = @"UPDATE BenhNhan 
                         SET HoTen = @HoTen, 
                             NgaySinh = @NgaySinh, 
                             GioiTinh = @GioiTinh, 
                             SDT = @SDT, 
                             DiaChi = @DiaChi 
                         WHERE BenhNhanID = @BenhNhanID";
                SqlParameter[] parameters = {
                    new SqlParameter("@BenhNhanID", benhNhanid),
                    new SqlParameter("@HoTen", hoTen),
                    new SqlParameter("@NgaySinh", ngaySinh),
                    new SqlParameter("@GioiTinh", gioiTinh),
                    new SqlParameter("@SDT", sdt),
                    new SqlParameter("@DiaChi", diaChi)
                };
                ExecuteNonQuery(query, parameters);
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật thông tin bệnh nhân: " + ex.Message);
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }

        }
        public BenhNhan GetBenhNhanByID(int benhNhanID)
        {
            string query = "SELECT * FROM BenhNhan WHERE BenhNhanID = @benhNhanID";
            SqlParameter[] parameters = {
                new SqlParameter("@benhNhanID", benhNhanID)
            };
            using (SqlDataReader reader = ExecuteReader(query, parameters))
            { 

                if (reader.Read())
                {
                    BenhNhan benhnhan = new BenhNhan();
                    benhnhan.BenhNhanID = (int)reader["BenhNhanID"];
                    benhnhan.Hoten = reader["HoTen"].ToString();
                    benhnhan.Ngaysinh = (DateTime)reader["NgaySinh"];
                    benhnhan.Gioitinh = (bool)reader["GioiTinh"];
                    benhnhan.Sdt = reader["SDT"].ToString();
                    benhnhan.Diachi = reader["DiaChi"].ToString();
                    return benhnhan;
                }
            }
            return null;
        }
    }
}
