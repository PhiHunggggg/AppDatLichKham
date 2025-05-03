using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDatLichKham.Entity;
using Microsoft.Data.SqlClient;

namespace AppDatLichKham.DAL
{
    internal class BacSiDAL : DataProvider
    {
        private static BacSiDAL instance;
        public new static BacSiDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BacSiDAL();
                }
                return instance;
            }
            private set => instance = value;
        }
        private BacSiDAL() { }
        public void AddBacSi(string tenBacSi, string chuyenKhoa)
        {
            string query = "INSERT INTO BacSi (TenBacSi, ChuyenKhoa) VALUES (@tenBacSi, @chuyenKhoa)";
            SqlParameter[] parameters = {
                new SqlParameter("@tenBacSi", tenBacSi),
                new SqlParameter("@chuyenKhoa", chuyenKhoa)
            };
            ExecuteQuery(query, parameters);
        }
        public void UpdateBacSi(int bacSiID, string tenBacSi, string chuyenKhoa)
        {
            string query = "UPDATE BacSi SET TenBacSi = @tenBacSi, ChuyenKhoa = @chuyenKhoa WHERE BacSiID = @bacSiID";
            SqlParameter[] parameters = {
                new SqlParameter("@bacSiID", bacSiID),
                new SqlParameter("@tenBacSi", tenBacSi),
                new SqlParameter("@chuyenKhoa", chuyenKhoa)
            };
            ExecuteQuery(query, parameters);
        }
        public List<BacSi> GetBacSiByChuyenKhoa(int chuyenKhoaID)
        {

            string query = "SELECT * FROM BacSi WHERE ChuyenKhoaID = @chuyenKhoaID";
            SqlParameter[] parameters = {
                new SqlParameter("@chuyenKhoaID", chuyenKhoaID)
            };
            List<BacSi> list = new List<BacSi>();
            SqlDataReader reader = ExecuteReader(query, parameters);
            while (reader.Read())
            {
                BacSi bacsi = new BacSi();
                bacsi.BacSiID = (int)reader["BacSiID"];
                bacsi.HoTen = reader["HoTen"].ToString();
                bacsi.ChuyenKhoaID = (int)reader["ChuyenKhoaID"];
                bacsi.SDT = reader["SDT"].ToString();
                bacsi.Email = reader["Email"].ToString();
                bacsi.ChucVu = reader["ChucVu"].ToString();
                bacsi.Trinhdo = reader["TrinhDo"].ToString();
                bacsi.Tuoi = (int)reader["Tuoi"];
                bacsi.ChiPhiKham = reader["ChiPhiKham"].ToString();
                list.Add(bacsi);
            }
            reader.Close();
            return list;
        }
        public List<BacSi> GetDanhSachBacSiRanh(int chuyenKhoaID, DateTime ngay, TimeSpan gio)
        {
            List<BacSi> danhSach = new List<BacSi>();

            string query = @"
        SELECT BS.BacSiID, BS.HoTen,BS.ChuyenKhoaID, BS.SDT, BS.Email, BS.TrinhDo, BS.ChucVu, BS.Tuoi, BS.ChiPhiKham
        FROM BacSi BS
        WHERE BS.ChuyenKhoaID = @chuyenKhoaID
        AND BS.BacSiID NOT IN (
            SELECT LH.BacSiID
            FROM LichHen LH
            WHERE LH.NgayHen = @ngay AND LH.GioHen = @gio
        )";

            SqlParameter[] parameters = {
        new SqlParameter("@chuyenKhoaID", chuyenKhoaID),
        new SqlParameter("@ngay", ngay.Date),
        new SqlParameter("@gio", gio)
    };

            using (SqlDataReader reader = ExecuteReader(query, parameters))
            {
                while (reader.Read())
                {
                    BacSi bs = new BacSi
                    {
                        BacSiID = reader.GetInt32(0),
                        HoTen = reader.GetString(1),
                        ChuyenKhoaID = reader.GetInt32(2),
                        SDT = reader.GetString(3),
                        Email = reader.GetString(4),
                        Trinhdo = reader.GetString(5),
                        ChucVu = reader["ChucVu"].ToString(),
                        Tuoi = (int)reader["Tuoi"],
                        ChiPhiKham = reader["ChiPhiKham"].ToString()
                    };
                    danhSach.Add(bs);
                }
            }
            return danhSach;
        }

        public BacSi GetBacSiByID(int bacsiID)
        {
            BacSi bacsi = null;
            string query = "SELECT * FROM BacSi WHERE BacSiID = @bacsiID";
            SqlParameter[] parameters = {
                new SqlParameter("@bacsiID", bacsiID)
            };
            SqlDataReader reader = ExecuteReader(query, parameters);
            if (reader.Read())
            {
                bacsi = new BacSi();
                bacsi.BacSiID = (int)reader["BacSiID"];
                bacsi.HoTen = reader["HoTen"].ToString();
                bacsi.ChuyenKhoaID = (int)reader["ChuyenKhoaID"];
                bacsi.SDT = reader["SDT"].ToString();
                bacsi.Email = reader["Email"].ToString();
                bacsi.ChucVu = reader["ChucVu"].ToString();
                bacsi.Trinhdo = reader["TrinhDo"].ToString();
                bacsi.Tuoi = (int)reader["Tuoi"];
                bacsi.ChiPhiKham = reader["ChiPhiKham"].ToString();
            }
            reader.Close();
            return bacsi;
        }
    }
} 
