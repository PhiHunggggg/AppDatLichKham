using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDatLichKham.Entity;
using Microsoft.Data.SqlClient;
namespace AppDatLichKham.DAL
{
    internal class LichHenDAL : DataProvider
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
        public LichHenDAL() { }
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
                lichHen.DonThuoc = reader["DonThuoc"] != DBNull.Value ? reader["DonThuoc"].ToString() : null; // Handle nullable DonThuoc
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
                lichHen.DonThuoc = reader["DonThuoc"] != DBNull.Value ? reader["DonThuoc"].ToString() : null; // Handle nullable DonThuoc
                list.Add(lichHen);
            }
            reader.Close();
            return list;
        }
        public LichHen GetLichHenByLichID(int LichID)
        {
            LichHen lichHen = null;
            string query = "SELECT * FROM LichHen WHERE LichHenID = @lichhenID";
            SqlParameter[] parameters = {
                new SqlParameter("@lichhenID", LichID)
            };
            SqlDataReader reader = ExecuteReader(query, parameters);
            while (reader.Read())
            {
                lichHen = new LichHen();
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
                lichHen.DonThuoc = reader["DonThuoc"] != DBNull.Value ? reader["DonThuoc"].ToString() : null; // Handle nullable DonThuoc
            }
            reader.Close();
            return lichHen;
        }
        public bool UpdatePhongKhamOrGioDen(int lichHenID, int? phongKhamMoi, TimeSpan? gioDenMoi, string ghiChu, string donThuoc)
        {
            List<string> setClauses = new List<string>();
            List<SqlParameter> parameters = new List<SqlParameter>();

            if (phongKhamMoi.HasValue)
            {
                setClauses.Add("PhongKham = @phongKham");
                parameters.Add(new SqlParameter("@phongKham", phongKhamMoi.Value));
            }

            if (gioDenMoi.HasValue)
            {
                setClauses.Add("GioDenThucTe = @gioDen");
                parameters.Add(new SqlParameter("@gioDen", gioDenMoi.Value));
            }

            if (!string.IsNullOrEmpty(ghiChu))
            {
                setClauses.Add("GhiChu = @ghiChu");
                parameters.Add(new SqlParameter("@ghiChu", ghiChu));
            }
            if (!string.IsNullOrEmpty(donThuoc))
            {
                setClauses.Add("DonThuoc = @donThuoc");
                parameters.Add(new SqlParameter("@donThuoc", donThuoc));
            }
            if (setClauses.Count == 0)
                return false; // Không có gì để cập nhật

            string setClause = string.Join(", ", setClauses);
            string query = $"UPDATE LichHen SET {setClause} WHERE LichHenID = @lichHenID";

            parameters.Add(new SqlParameter("@lichHenID", lichHenID));

            int rowsAffected = ExecuteNonQuery(query, parameters.ToArray());
            return rowsAffected > 0;
        }
        public bool UpdateTrangThai(int lichHenID, bool trangThaiMoi)
        {
            string query = "UPDATE LichHen SET TrangThai = @trangThai WHERE LichHenID = @lichHenID";
            SqlParameter[] parameters = {
                new SqlParameter("@trangThai", trangThaiMoi),
                new SqlParameter("@lichHenID", lichHenID)
            };
            int rowsAffected = ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }
        public void XoaLichHen(int lichHenID)
        {
            string query = "DELETE FROM LichHen WHERE LichHenID = @lichHenID";
            SqlParameter[] parameters = {
                new SqlParameter("@lichHenID", lichHenID)
            };
            ExecuteNonQuery(query, parameters);
        }
    }
}
