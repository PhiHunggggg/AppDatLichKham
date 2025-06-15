using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace AppDatLichKham.DAL
{
    internal class LichNghiDAL : DataProvider
    {
        private static LichNghiDAL instance;
        public new static LichNghiDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LichNghiDAL();
                }
                return instance;
            }
            private set => instance = value;
        }
        public LichNghiDAL() { }
        public void InsertLichNghi(int bacSiID, DateTime ngayNghi, TimeSpan? caNghi, string lyDo, bool trangThai)
        {
            string query = "INSERT INTO LichNghi (BacSiID, NgayNghi, CaNghi, LyDo, TrangThai) VALUES (@BacSiID, @NgayNghi, @CaNghi, @LyDo, @TrangThai)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@BacSiID", bacSiID),
                new SqlParameter("@NgayNghi", ngayNghi),
                new SqlParameter("@CaNghi", caNghi ?? (object)DBNull.Value),  
                new SqlParameter("@LyDo", lyDo),
                new SqlParameter("@TrangThai", trangThai)
            };
            ExecuteNonQuery(query, parameters);
        }
        public void UpdateLichNghi(int lichNghiID, int bacSiID, DateTime ngayNghi, TimeSpan? caNghi, string lyDo, bool trangThai)
        {
            string query = "UPDATE LichNghi SET BacSiID = @BacSiID, NgayNghi = @NgayNghi, CaNghi = @CaNghi, LyDo = @LyDo, TrangThai = @TrangThai WHERE LichNghiID = @LichNghiID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@LichNghiID", lichNghiID),
                new SqlParameter("@BacSiID", bacSiID),
                new SqlParameter("@NgayNghi", ngayNghi),
                new SqlParameter("@CaNghi", caNghi ?? (object)DBNull.Value),
                new SqlParameter("@LyDo", lyDo),
                new SqlParameter("@TrangThai", trangThai)
            };
            ExecuteNonQuery(query, parameters);
        }
        public void XacNhanLichNghi(int lichNghiID,bool trangThai)
        {
            string query = "UPDATE LichNghi SET TrangThai = @TrangThai WHERE LichNghiID = @LichNghiID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@LichNghiID", lichNghiID),
                new SqlParameter("@TrangThai", trangThai)
            };
            ExecuteNonQuery(query, parameters);
        }
        public void DeleteLichNghi(int lichNghiID)
        {
            string query = "DELETE FROM LichNghi WHERE LichNghiID = @LichNghiID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@LichNghiID", lichNghiID)
            };
            ExecuteNonQuery(query, parameters);
        }
        public List<Entity.LichNghi> GetLichNghiByBacSiID(int bacSiID)
        {
            string query = "SELECT * FROM LichNghi WHERE BacSiID = @BacSiID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@BacSiID", bacSiID)
            };
            List<Entity.LichNghi> list = new List<Entity.LichNghi>();
            SqlDataReader reader = ExecuteReader(query, parameters);
            while (reader.Read())
            {
                Entity.LichNghi lichNghi = new Entity.LichNghi
                {
                    LichNghiID = (int)reader["LichNghiID"],
                    BacSiID = (int)reader["BacSiID"],
                    NgayNghi = (DateTime)reader["NgayNghi"],
                    CaNghi = reader["CaNghi"] != DBNull.Value ? (TimeSpan)reader["CaNghi"] : default(TimeSpan),
                    LyDo = reader["LyDo"].ToString(),
                    TrangThai = (bool)reader["TrangThai"]
                };
                list.Add(lichNghi);
            }
            reader.Close();
            return list;
        }
        public List<Entity.LichNghi> GetAllLichNghi()
        {
            string query = "SELECT * FROM LichNghi";
            List<Entity.LichNghi> list = new List<Entity.LichNghi>();
            SqlDataReader reader = ExecuteReader(query);
            while (reader.Read())
            {
                Entity.LichNghi lichNghi = new Entity.LichNghi
                {
                    LichNghiID = (int)reader["LichNghiID"],
                    BacSiID = (int)reader["BacSiID"],
                    NgayNghi = (DateTime)reader["NgayNghi"],
                    CaNghi = reader["CaNghi"] != DBNull.Value ? (TimeSpan)reader["CaNghi"] : default(TimeSpan),
                    LyDo = reader["LyDo"].ToString(),
                    TrangThai = (bool)reader["TrangThai"]
                };
                list.Add(lichNghi);
            }
            reader.Close();
            return list;
        }
        public bool CheckLichNghiExistsCa(int bacSiID, DateTime ngayNghi, TimeSpan caNghi,bool TrangThai)
        {
            string query = "SELECT COUNT(*) FROM LichNghi WHERE BacSiID = @BacSiID AND NgayNghi = @NgayNghi AND CaNghi = @CaNghi AND TrangThai=@TrangThai";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@BacSiID", bacSiID),
                new SqlParameter("@NgayNghi", ngayNghi),
                new SqlParameter("@CaNghi", caNghi),
                new SqlParameter("@TrangThai", TrangThai)
            };
            int count = (int)ExecuteScalar(query, parameters);
            return count > 0;
        }
        public bool CheckLichNghiExistsNgay(int bacSiID, DateTime ngayNghi,bool trangThai)
        {
            string query = "SELECT COUNT(*) FROM LichNghi WHERE BacSiID = @BacSiID AND NgayNghi = @NgayNghi AND TrangThai = @TrangThai AND CaNghi IS Null" ;
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@BacSiID", bacSiID),
                new SqlParameter("@NgayNghi", ngayNghi),
                new SqlParameter("@TrangThai", trangThai)
            };
            int count = (int)ExecuteScalar(query, parameters);
            return count > 0;
        }
        public List<DateTime> GetNgayNghiByBacSiID(int bacSiID)
        {
            List<DateTime> list = new List<DateTime>();
            string query = "SELECT * FROM LichNghi WHERE BacSiID = @BacSiID";
            SqlParameter[] parameters = new SqlParameter[]
                        {
                new SqlParameter("@BacSiID", bacSiID)
                        }; SqlDataReader reader = ExecuteReader(query, parameters);
            while (reader.Read())
            {
                Entity.LichNghi lichNghi = new Entity.LichNghi
                {
                    LichNghiID = (int)reader["LichNghiID"],
                    BacSiID = (int)reader["BacSiID"],
                    NgayNghi = (DateTime)reader["NgayNghi"],
                    CaNghi = reader["CaNghi"] != DBNull.Value ? (TimeSpan)reader["CaNghi"] : default(TimeSpan),
                    LyDo = reader["LyDo"].ToString(),
                    TrangThai = (bool)reader["TrangThai"]
                };
                list.Add(lichNghi.NgayNghi);
            }
            reader.Close();
            return list;
        }

    }
}
