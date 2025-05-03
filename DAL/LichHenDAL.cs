using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDatLichKham.Entity;
using Microsoft.Data.SqlClient;
namespace AppDatLichKham.DAL
{
    internal class LichHenDAL:DataProvider
    {
        private static LichHenDAL instance;
        public new static LichHenDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LichHenDAL();
                }
                return instance;
            }
            private set => instance = value;
        }
        private LichHenDAL() { }
        public void XoaLichHenCu()
        {
            string query = "DELETE FROM LichHen WHERE NgayHen < CAST(GETDATE() AS DATE)";
            ExecuteNonQuery(query);
        }
        public List<LichHen> GetLichHenByBenhNhanID(int benhNhanID)
        {
            string query = "SELECT * FROM LichHen WHERE BenhNhanID = @benhNhanID";
            SqlParameter[] parameters = {
                new SqlParameter("@benhNhanID", benhNhanID)
            };
            List<LichHen> list = new List<LichHen>();
            SqlDataReader reader = ExecuteReader(query, parameters);
            while (reader.Read())
            {
                LichHen lichHen = new LichHen();
                lichHen.LichHenID = (int)reader["LichHenID"];
                lichHen.BenhNhanID = (int)reader["BenhNhanID"];
                lichHen.BacSiID = (int)reader["BacSiID"];
                lichHen.NgayHen = (DateTime)reader["NgayHen"];
                lichHen.GioHen = (TimeSpan)reader["GioHen"];
                lichHen.GioDenThucTe = reader["GioDenThucTe"] != DBNull.Value ? (TimeSpan)reader["GioDenThucTe"] : (TimeSpan?)null;
                lichHen.TrangThai = (bool)reader["TrangThai"];
                lichHen.HoTenNguoiKham = reader["HoTenNguoiKham"].ToString();
                lichHen.SDT = reader["SDT"].ToString();
                lichHen.DiaChi = reader["DiaChi"].ToString();
                lichHen.GioiTinh = (bool)reader["GioiTinh"];
                lichHen.PhongKham = reader["PhongKham"] != DBNull.Value ? (int)reader["PhongKham"] : 0; // Default to 0 or another value
                list.Add(lichHen);
            }
            reader.Close();
            return list;
        }
        public List<LichHen> GetLichHenByBacSiID(int bacsiid)
        {
            string query = "SELECT * FROM LichHen WHERE BacSiID = @bacsiID";
            SqlParameter[] parameters = {
                new SqlParameter("@bacsiID", bacsiid)
            };
            List<LichHen> list = new List<LichHen>();
            SqlDataReader reader = ExecuteReader(query, parameters);
            while (reader.Read())
            {
                LichHen lichHen = new LichHen();
                lichHen.LichHenID = (int)reader["LichHenID"];
                lichHen.BenhNhanID = (int)reader["BenhNhanID"];
                lichHen.BacSiID = (int)reader["BacSiID"];
                lichHen.NgayHen = (DateTime)reader["NgayHen"];
                lichHen.GioHen = (TimeSpan)reader["GioHen"];
                lichHen.GioDenThucTe = reader["GioDenThucTe"] != DBNull.Value ? (TimeSpan)reader["GioDenThucTe"] : (TimeSpan?)null;
                lichHen.TrangThai = (bool)reader["TrangThai"];
                lichHen.HoTenNguoiKham = reader["HoTenNguoiKham"].ToString();
                lichHen.SDT = reader["SDT"].ToString();
                lichHen.DiaChi = reader["DiaChi"].ToString();
                lichHen.GioiTinh = (bool)reader["GioiTinh"];
                lichHen.PhongKham = reader["PhongKham"] != DBNull.Value ? (int)reader["PhongKham"] : 0; // Default to 0 or another value
                list.Add(lichHen);
            }
            reader.Close();
            return list;
        }
        public LichHen GetLichHenByLichID(int LichID)
        {
            LichHen lich = null;
            string query = "SELECT * FROM LichHen WHERE LichHenID = @lichhenID";
            SqlParameter[] parameters = {
                new SqlParameter("@lichhenID", LichID)
            };
            SqlDataReader reader = ExecuteReader(query, parameters);
            while (reader.Read())
            {
                LichHen lichHen = new LichHen();
                lichHen.LichHenID = (int)reader["LichHenID"];
                lichHen.BenhNhanID = (int)reader["BenhNhanID"];
                lichHen.BacSiID = (int)reader["BacSiID"];
                lichHen.NgayHen = (DateTime)reader["NgayHen"];
                lichHen.GioHen = (TimeSpan)reader["GioHen"];
                lichHen.GioDenThucTe = reader["GioDenThucTe"] != DBNull.Value ? (TimeSpan)reader["GioDenThucTe"] : (TimeSpan?)null;
                lichHen.TrangThai = (bool)reader["TrangThai"];
                lichHen.HoTenNguoiKham = reader["HoTenNguoiKham"].ToString();
                lichHen.SDT = reader["SDT"].ToString();
                lichHen.DiaChi = reader["DiaChi"].ToString();
                lichHen.GioiTinh = (bool)reader["GioiTinh"];
                lichHen.PhongKham = reader["PhongKham"] != DBNull.Value ? (int)reader["PhongKham"] : 0; // Default to 0 or another value
            }
            reader.Close();
            return lich;
        }
    }
}
