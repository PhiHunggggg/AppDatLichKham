using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDatLichKham.Entity;
using Microsoft.Data.SqlClient;

namespace AppDatLichKham.DAL
{
    internal class LichLamViecDAL:DataProvider
    {
        private static LichLamViecDAL instance;
        public new static LichLamViecDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LichLamViecDAL();
                }
                return instance;
            }
            private set => instance = value;
        }
        private LichLamViecDAL() { }
        public bool CheckCaTrung(int bacsiid, DateTime ngay, TimeSpan gio)
        {
            string query = @"
            SELECT COUNT(*) 
            FROM LichLamViec 
            WHERE BacSiID = @BacSiID 
                  AND Ngay = @NgayCheck 
                  AND GioBatDau = @GioCheck
                  AND TrangThai = 0";
            SqlParameter[] parameters = {
                new SqlParameter("@BacSiID", bacsiid),
                new SqlParameter("@NgayCheck", ngay),
                new SqlParameter("@GioCheck", gio)
            };
            int count = (int)ExecuteScalar(query, parameters);
            return count > 0;

        }
        public List<LichLamViec> GetLichLamViecByBacSiID(int bacSiID)
        {
            List<LichLamViec> lichLamViecs = new List<LichLamViec>();
            string query = @"
            SELECT * 
            FROM LichLamViec 
            WHERE BacSiID = @BacSiID";
            SqlParameter[] parameters = {
                new SqlParameter("@BacSiID", bacSiID)
            };
            using (SqlDataReader reader = ExecuteReader(query, parameters))
            {
                while (reader.Read())
                {
                    LichLamViec lich = new LichLamViec
                    {
                        LichID = (int)reader["LichID"],
                        BacSiID = (int)reader["BacSiID"],
                        Ngay = (DateTime)reader["Ngay"],
                        GioBatDau = (TimeSpan)reader["GioBatDau"],
                        GioKetThuc = reader["GioKetThuc"] != DBNull.Value ? (TimeSpan)reader["GioKetThuc"] : TimeSpan.MinValue,
                        TrangThai = (bool)reader["TrangThai"],
                        LichHenID = (int)reader["LichhenID"]
                    };
                    lichLamViecs.Add(lich);
                }
            }
            return lichLamViecs;
        }
    }
}
