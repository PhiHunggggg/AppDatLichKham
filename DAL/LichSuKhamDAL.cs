using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDatLichKham.DAL.Entity;
using AppDatLichKham.Entity;
using DevExpress.Internal.WinApi.Windows.UI.Notifications;
using Microsoft.Data.SqlClient;

namespace AppDatLichKham.DAL
{
    internal class LichSuKhamDAL : DataProvider
    {
        private static LichSuKhamDAL instance;
        public new static LichSuKhamDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LichSuKhamDAL();
                }
                return instance;
            }
            private set => instance = value;
        }
        protected LichSuKhamDAL() { }
        public List<Entity.LichSuKham> GetLichSuKhamByBenhNhanID(int benhNhanID)
        {
            string query = @"
            SELECT LichSuID, TenBacSi, TenBenhNhan, NgayHen, GioHen, GioDen, DonThuoc, GhiChu,BacSiID,BenhNhanID
            FROM LichSuKham
            WHERE BenhNhanID = @benhNhanID";
            SqlParameter[] parameters = {
                new SqlParameter("@benhNhanID", benhNhanID)
            };
            List<Entity.LichSuKham> list = new List<Entity.LichSuKham>();
            SqlDataReader reader = ExecuteReader(query, parameters);
            while (reader.Read())
            {
                Entity.LichSuKham lichSuKham = new Entity.LichSuKham
                {
                    LichSuID = (int)reader["LichSuID"],
                    TenBacSi = reader["TenBacSi"].ToString(),
                    TenBenhNhan = reader["TenBenhNhan"].ToString(),
                    NgayHen = (DateTime)reader["NgayHen"],
                    GioHen = (TimeSpan)reader["GioHen"],
                    GioDen = (TimeSpan)reader["GioDen"],
                    DonThuoc = reader["DonThuoc"] != DBNull.Value ? reader["DonThuoc"].ToString() : null,
                    GhiChu = reader["GhiChu"] != DBNull.Value ? reader["GhiChu"].ToString() : null,
                    BacSiID = (int)reader["BacSiID"],
                    BenhNhanID = (int)reader["BenhNhanID"]
                };
                list.Add(lichSuKham);
            }
            reader.Close();
            return list;
        }
        public bool InsertLichSuKham(string tenBacSi,string tenBenhNhan, DateTime ngayHen, TimeSpan gioHen, TimeSpan gioDen, string ghiChu, string donThuoc,int BacSiID,int BenhNhanID)
        {
            string query = @"
            INSERT INTO LichSuKham (TenBacSi, TenBenhNhan, NgayHen, GioHen, GioDen, DonThuoc, GhiChu, BacSiID, BenhNhanID)
            VALUES (@TenBacSi, @TenBenhNhan, @NgayKham, @GioKham, @GioDen, @DonThuoc, @GhiChu, @BacSiID, @BenhNhanID)";
            SqlParameter[] parameters = {
                new SqlParameter("@TenBacSi", tenBacSi),
                new SqlParameter("@TenBenhNhan", tenBenhNhan),
                new SqlParameter("@NgayKham",ngayHen),
                new SqlParameter("@GioKham", gioHen),
                new SqlParameter("@GioDen", gioDen),
                new SqlParameter("@DonThuoc", (object)donThuoc ?? DBNull.Value),
                new SqlParameter("@GhiChu", (object)ghiChu ?? DBNull.Value),
                new SqlParameter("@BacSiID", BacSiID),
                new SqlParameter("@BenhNhanID", BenhNhanID)
            };
            return ExecuteNonQuery(query, parameters) > 0;
        }
        public List<LichSuKham> GetLichSuKhamByBacSiID(int bacsiid)
        {
            string query = @"
            SELECT LichSuID, TenBacSi, TenBenhNhan, NgayHen, GioHen, GioDen, DonThuoc, GhiChu,BacSiID,BenhNhanID
            FROM LichSuKham
            WHERE BacSiID = @BacSiID";
            SqlParameter[] parameters = {
                new SqlParameter("@BacSiID", bacsiid)
            };
            List<LichSuKham> list = new List<LichSuKham>();
            SqlDataReader reader = ExecuteReader(query, parameters);
            while (reader.Read())
            {
                LichSuKham lichSuKham = new LichSuKham
                {
                    LichSuID = (int)reader["LichSuID"],
                    TenBacSi = reader["TenBacSi"].ToString(),
                    TenBenhNhan = reader["TenBenhNhan"].ToString(),
                    NgayHen = (DateTime)reader["NgayHen"],
                    GioHen = (TimeSpan)reader["GioHen"],
                    GioDen = (TimeSpan)reader["GioDen"],
                    DonThuoc = reader["DonThuoc"] != DBNull.Value ? reader["DonThuoc"].ToString() : null,
                    GhiChu = reader["GhiChu"] != DBNull.Value ? reader["GhiChu"].ToString() : null,
                    BacSiID = bacsiid,
                    BenhNhanID = (int)reader["BenhNhanID"]
                };
                list.Add(lichSuKham);
            }
            reader.Close();
            return list;
        }
    }
}
