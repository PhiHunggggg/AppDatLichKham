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
        public List<TaiKhoan> GetAllTaiKhoan()
        {
            string query = "SELECT * FROM TaiKhoan";
            SqlDataReader reader = ExecuteReader(query);
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
            while (reader.Read())
            {
                TaiKhoan taiKhoan = new TaiKhoan
                {
                    TaiKhoanID = (int)reader["TaiKhoanID"],
                    TenDangNhap = reader["TenDangNhap"].ToString(),
                    MatKhau = reader["MatKhau"].ToString(),
                    LoaiTaiKhoan = reader["LoaiTaiKhoan"].ToString(),
                    BenhNhanID = reader["BenhNhanID"] != DBNull.Value ? Convert.ToInt32(reader["BenhNhanID"]) : 0,
                    BacSiID = reader["BacSiID"] != DBNull.Value ? Convert.ToInt32(reader["BacSiID"]) : 0
                };
                taiKhoans.Add(taiKhoan);
            }
            reader.Close();
            return taiKhoans;
        }

        public bool UpdateTaiKhoan(string username, string password, int taiKhoanID)
        {
            try
            {
                string query = "UPDATE TaiKhoan SET TenDangNhap = @username, MatKhau = @password WHERE TaiKhoanID = @id";
                SqlParameter[] parameters = {
        new SqlParameter("@username", username),
        new SqlParameter("@password", password),
        new SqlParameter("@id", taiKhoanID)
    };
                ExecuteQuery(query, parameters);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật tài khoản: " + ex.Message);
            }
        }
        public int GetTaiKhoanIDbyBenhNhanID(int benhNhanID)
        {
            string query = "SELECT TaiKhoanID FROM TaiKhoan WHERE BenhNhanID = @benhNhanID";
            SqlParameter[] parameters = {
                new SqlParameter("@benhNhanID", benhNhanID)
            };
            object result = ExecuteScalar(query, parameters);
            return result != null ? Convert.ToInt32(result) : -1;
        }
        public int GetTaiKhoanIDbyBacSiID(int bacSiID)
        {
            string query = "SELECT TaiKhoanID FROM TaiKhoan WHERE BacSiID = @bacSiID";
            SqlParameter[] parameters = {
                new SqlParameter("@bacSiID", bacSiID)
            };
            object result = ExecuteScalar(query, parameters);
            return result != null ? Convert.ToInt32(result) : -1;
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
                    MatKhau = reader["MatKhau"].ToString(),
                    LoaiTaiKhoan = reader["LoaiTaiKhoan"].ToString(),
                    BenhNhanID = reader["BenhNhanID"] != DBNull.Value ? Convert.ToInt32(reader["BenhNhanID"]) : 0,
                    BacSiID = reader["BacSiID"] != DBNull.Value ? Convert.ToInt32(reader["BacSiID"]) : 0
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
            string loaijtk = "";
            if (loaiTaiKhoan == "Bệnh nhân")
            {
                loaijtk = "BenhNhan";
            }
            else if (loaiTaiKhoan == "Bác sỹ")
            {
                loaijtk = "BacSi";
            }
            else if (loaiTaiKhoan == "Quản trị viên")
            {
                loaijtk = "Admin";
            }
            else
            {
                throw new Exception("Loại tài khoản không hợp lệ");
            }
            try
            {
                // 1. Insert vào bảng TaiKhoan trước → lấy TaiKhoanID
                string queryTaiKhoan = "INSERT INTO TaiKhoan (TenDangNhap, MatKhau, LoaiTaiKhoan) OUTPUT INSERTED.TaiKhoanID VALUES (@username, @password, @loaiTaiKhoan)";
                SqlParameter[] parametersTaiKhoan = {
                new SqlParameter("@username", username),
                new SqlParameter("@password", password),
                new SqlParameter("@loaiTaiKhoan", loaijtk)
                };
                int taiKhoanID = Convert.ToInt32(ExecuteScalar(queryTaiKhoan, parametersTaiKhoan));

                if (loaiTaiKhoan == "Bệnh nhân")
                {
                    // 2. Insert vào bảng BenhNhan → lấy BenhNhanID
                    string sqlBenhNhan = "INSERT INTO BenhNhan (HoTen, NgaySinh, GioiTinh, SDT, DiaChi, TaiKhoanID) OUTPUT INSERTED.BenhNhanID " +
                                         "VALUES (@HoTen, @NgaySinh, @GioiTinh,@SDT, @DiaChi, @TaiKhoanID)";
                    SqlParameter[] parametersBenhNhan = {
                new SqlParameter("@HoTen", username),
                new SqlParameter("@NgaySinh", DateTime.Now),
                new SqlParameter("@GioiTinh", 1),
                new SqlParameter("@SDT", "098" + new Random().Next(1000000, 9999999).ToString()),
                new SqlParameter("@DiaChi", "Chưa cập nhật"),
                new SqlParameter("@TaiKhoanID", taiKhoanID)
            };
                    int benhNhanID = Convert.ToInt32(ExecuteScalar(sqlBenhNhan, parametersBenhNhan));

                    // 3. Cập nhật lại bảng TaiKhoan với BenhNhanID
                    string updateTaiKhoan = "UPDATE TaiKhoan SET BenhNhanID = @BenhNhanID WHERE TaiKhoanID = @TaiKhoanID";
                    SqlParameter[] parametersUpdate = {
                new SqlParameter("@BenhNhanID", benhNhanID),
                new SqlParameter("@TaiKhoanID", taiKhoanID)
            };
                    ExecuteQuery(updateTaiKhoan, parametersUpdate);
                    return true;

                }
                else if (loaiTaiKhoan == "Bác sỹ")
                {
                    // 2. Insert vào bảng BacSi → lấy BacSiID
                    string sqlBacSi = "INSERT INTO BacSi (HoTen, ChuyenKhoaID, SDT, Email, ChucVu, TrinhDo, Tuoi, ChiPhiKham, TaiKhoanID) OUTPUT INSERTED.BacSiID " +
                                      "VALUES (@HoTen, @ChuyenKhoaID, @SDT, @Email, @ChucVu, @TrinhDo, @Tuoi, @ChiPhiKham, @TaiKhoanID)";
                    SqlParameter[] parametersBacSi = {
                new SqlParameter("@HoTen", username),
                new SqlParameter("@ChuyenKhoaID", 11),
                new SqlParameter("@SDT", "0000000000"),
                new SqlParameter("@Email", "bacsy@gmail.com"),
                new SqlParameter("@ChucVu", "Bác sĩ"),
                new SqlParameter("@TrinhDo", "Cử nhân"),
                new SqlParameter("@Tuoi", 30),
                new SqlParameter("@ChiPhiKham", "100.000 VNĐ"),
                new SqlParameter("@TaiKhoanID", taiKhoanID)
            };
                    int bacSiID = Convert.ToInt32(ExecuteScalar(sqlBacSi, parametersBacSi));

                    // 3. Cập nhật lại bảng TaiKhoan với BacSiID
                    string updateTaiKhoan = "UPDATE TaiKhoan SET BacSiID = @BacSiID WHERE TaiKhoanID = @TaiKhoanID";
                    SqlParameter[] parametersUpdate = {
                new SqlParameter("@BacSiID", bacSiID),
                new SqlParameter("@TaiKhoanID", taiKhoanID)
            };
                    ExecuteQuery(updateTaiKhoan, parametersUpdate);
                    return true;
                }
                else if (loaijtk == "Admin")
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi đăng ký: " + ex.Message);
            }
            return false;
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
        public List<TaiKhoan> GetTaiKhoanByUsername(string username)
        {
            string query = "SELECT * FROM TaiKhoan WHERE LOWER(TenDangNhap) LIKE LOWER(@username)";
            SqlParameter[] parameters = {
        new SqlParameter("@username", "%" + username + "%")
    };
            SqlDataReader reader = ExecuteReader(query, parameters);
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
            while (reader.Read())
            {
                TaiKhoan taiKhoan = new TaiKhoan
                {
                    TaiKhoanID = (int)reader["TaiKhoanID"],
                    TenDangNhap = reader["TenDangNhap"].ToString(),
                    MatKhau = reader["MatKhau"].ToString(),
                    LoaiTaiKhoan = reader["LoaiTaiKhoan"].ToString(),
                    BenhNhanID = reader["BenhNhanID"] != DBNull.Value ? Convert.ToInt32(reader["BenhNhanID"]) : 0,
                    BacSiID = reader["BacSiID"] != DBNull.Value ? Convert.ToInt32(reader["BacSiID"]) : 0
                };
                taiKhoans.Add(taiKhoan);
            }
            reader.Close();
            return taiKhoans;
        }

    }
}
