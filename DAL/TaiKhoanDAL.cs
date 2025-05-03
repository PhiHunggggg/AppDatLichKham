using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDatLichKham.Entity;
using Microsoft.Data.SqlClient;

namespace AppDatLichKham.DAL
{
    internal class TaiKhoanDAL : DataProvider

    {

        private static TaiKhoanDAL instance;
        public new static TaiKhoanDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TaiKhoanDAL();
                }
                return instance;
            }
            private set => instance = value;
        }
        private TaiKhoanDAL() { }

        public void AddTaiKhoan(string username, string password)
        {
            string query = "INSERT INTO TaiKhoan (TenDangNhap, MatKhau) VALUES (@username, @password)";
            SqlParameter[] parameters = {
        new SqlParameter("@username", username),
        new SqlParameter("@password", password)
    };
            ExecuteQuery(query, parameters);
        }

        public void UpdateTaiKhoan(string username, string password, int taiKhoanID)
        {
            string query = "UPDATE TaiKhoan SET TenDangNhap = @username, MatKhau = @password WHERE TaiKhoanID = @id";
            SqlParameter[] parameters = {
        new SqlParameter("@username", username),
        new SqlParameter("@password", password),
        new SqlParameter("@id", taiKhoanID)
    };
            ExecuteQuery(query, parameters);
        }

        public void DeleteTaiKhoan(int taiKhoanID)
        {
            string query = "DELETE FROM TaiKhoan WHERE TaiKhoanID = @id";
            SqlParameter[] parameters = {
        new SqlParameter("@id", taiKhoanID)
        };
            ExecuteQuery(query, parameters);
        }

        public TaiKhoan GetTaiKhoanByID(int taiKhoanID)
        {
            string query = "SELECT * FROM TaiKhoan WHERE TaiKhoanID = @id";
            SqlParameter[] parameters = {
                new SqlParameter("@id", taiKhoanID)
                };
            SqlDataReader reader = ExecuteReader(query, parameters);
            TaiKhoan taiKhoan = null;
            if (reader.Read())
            {
                taiKhoan = new TaiKhoan
                {
                    TaiKhoanID = (int)reader["TaiKhoanID"],
                    TenDangNhap = reader["TenDangNhap"].ToString(),
                    MatKhau = reader["Password"].ToString(),
                    LoaiTaiKhoan = reader["LoaiTaiKhoan"].ToString(),
                    BenhNhanID = (int)reader["BenhNhanID"],
                    BacSiID = (int)reader["BacSiID"]
                };
            }
            reader.Close();
            return taiKhoan;
        } 
        public string DangNhap(string username, string password)
        {
            try
            {
                string query = "SELECT * FROM TaiKhoan WHERE TenDangNhap = @username AND MatKhau = @password";
                SqlParameter[] parameters = {
                new SqlParameter("@username", username),
                new SqlParameter("@password", password)
                  };
                SqlDataReader reader = ExecuteReader(query, parameters);
                if (reader.Read())
                {
                    string loaiTaiKhoan = reader["LoaiTaiKhoan"].ToString();
                    reader.Close();
                    return loaiTaiKhoan;
                }
                else
                {
                    reader.Close();
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi đăng nhập: " + ex.Message);
            }
        }
        #region Lay ID
        public int GetBenhNhanID(string username, string password)
        {
            string query = "SELECT BenhNhanID FROM TaiKhoan WHERE TenDangNhap = @username AND MatKhau = @password";
            SqlParameter[] parameters = {
                new SqlParameter("@username", username),
                new SqlParameter("@password", password)
            };
            object result = ExecuteScalar(query, parameters);
            return result != null ? Convert.ToInt32(result) : -1;
        }
        public int GetBacSiID(string username, string password)
        {
            string query = "SELECT BacSiID FROM TaiKhoan WHERE TenDangNhap = @username AND MatKhau = @password";
            SqlParameter[] parameters = {
                new SqlParameter("@username", username),
                new SqlParameter("@password", password)
            };
            object result = ExecuteScalar(query, parameters);
            return result != null ? Convert.ToInt32(result) : -1;
        }
        public int GetTaiKhoanID(string username, string password)
        {
            string query = "SELECT TaiKhoanID FROM TaiKhoan WHERE TenDangNhap = @username AND MatKhau = @password";
            SqlParameter[] parameters = {
                new SqlParameter("@username", username),
                new SqlParameter("@password", password)
            };
            object result = ExecuteScalar(query, parameters);
            return result != null ? Convert.ToInt32(result) : -1;
        }
        #endregion
        public bool DangKy(string username, string password, string loaiTaiKhoan)
        {
            try
            {
                string sqlBenhNhan = "INSERT INTO BenhNhan (HoTen, NgaySinh, GioiTinh, DiaChi) OUTPUT INSERTED.BenhNhanID VALUES (@HoTen, @NgaySinh, @GioiTinh, @DiaChi)";
                SqlParameter[] parametersBenhNhan = {
                    new SqlParameter("@HoTen", username),
                    new SqlParameter("@NgaySinh", DateTime.Now),
                    new SqlParameter("@GioiTinh", 1),
                    new SqlParameter("@DiaChi", "Chưa cập nhật")
                };
                int benhNhanID = (int)ExecuteScalar(sqlBenhNhan, parametersBenhNhan);
                string query = "INSERT INTO TaiKhoan (TenDangNhap, MatKhau, LoaiTaiKhoan,BenhNhanID) VALUES (@username, @password, @loaiTaiKhoan,@BenhNhanID)";
                SqlParameter[] parameters = {
                    new SqlParameter("@username", username),
                    new SqlParameter("@password", password),
                    new SqlParameter("@loaiTaiKhoan", loaiTaiKhoan)
                    ,new SqlParameter("@BenhNhanID", benhNhanID)
                };
                ExecuteQuery(query, parameters);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi đăng ký: " + ex.Message);
            }
        }
        public bool KiemTraTonTaiTaiKhoan(string username)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = @username";
                SqlParameter[] parameters = {
                    new SqlParameter("@username", username)
                };
                int count = (int)ExecuteScalar(query, parameters);
                return count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi kiểm tra tài khoản: " + ex.Message);
            }
        }
        public BenhNhan GetBenhNhanByID(int id)
        {
            string query = "SELECT * FROM BenhNhan WHERE BenhNhanID = @id";
            SqlParameter[] parameters = {
                new SqlParameter("@id", id)
            };
            SqlDataReader reader = ExecuteReader(query, parameters);
            BenhNhan benhNhan = null;
            if (reader.Read())
            {
                benhNhan = new BenhNhan
                {
                    BenhNhanID = (int)reader["BenhNhanID"],
                    Hoten = reader["HoTen"].ToString(),
                    Ngaysinh = (DateTime)reader["NgaySinh"],
                    Gioitinh = (bool)reader["GioiTinh"],
                    Sdt = reader["SDT"].ToString(),
                    Diachi = reader["DiaChi"].ToString()
                };
            }
            reader.Close();
            return benhNhan;
        }
        public BacSi GetBacSiByID(int id)
        {
            string query = "SELECT * FROM BacSi WHERE BacSiID = @id";
            SqlParameter[] parameters = {
                new SqlParameter("@id", id)
            };
            SqlDataReader reader = ExecuteReader(query, parameters);
            BacSi bacsi = null;
            if (reader.Read())
            {
                bacsi = new BacSi
                {
                    BacSiID = (int)reader["BacSiID"],
                    HoTen = reader["HoTen"].ToString(),
                    ChuyenKhoaID = (int)reader["ChuyenKhoaID"],
                    SDT = reader["SDT"].ToString(),
                    Email = reader["Email"].ToString(),
                    ChucVu = reader["ChucVu"].ToString(),
                    Trinhdo = reader["TrinhDo"].ToString(),
                    Tuoi = (int)reader["Tuoi"],
                    ChiPhiKham = reader["ChiPhiKham"].ToString()
                };
            }
            reader.Close();
            return bacsi;
        }
    }
}
