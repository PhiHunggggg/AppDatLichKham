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
    internal class DatLichDAL : DataProvider
    {
        private static DatLichDAL instance;
        public new static DatLichDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DatLichDAL();
                }
                return instance;
            }
            private set => instance = value;
        }
        private DatLichDAL() { }
        public bool CheckDaDatLich(int benhNhanID, DateTime ngay)
        {
            string query = "SELECT COUNT(*) FROM DatLich WHERE BenhNhanID = @BenhNhanID AND NgayHen = @NgayDatLich";
            SqlParameter[] parameters = {
                new SqlParameter("@BenhNhanID", benhNhanID),
                new SqlParameter("@NgayDatLich", ngay)
            };
            int count = (int)ExecuteScalar(query, parameters);
            return count > 0;
        }
        public bool CheckCaTrungDatLich(int bacSiID, DateTime ngayHen, TimeSpan gioDangKi)
        {
            string query = "SELECT COUNT(*) FROM DatLich WHERE BacSiID = @BacSiID AND NgayHen = @NgayHen AND GioDangKi = @GioDangKi";
            SqlParameter[] parameters = {
                new SqlParameter("@BacSiID", bacSiID),
                new SqlParameter("@NgayHen", ngayHen),
                new SqlParameter("@GioDangKi", gioDangKi)
            };
            int count = (int)ExecuteScalar(query, parameters);
            return count > 0;
        }
        public bool XacNhanLichHenMini(int datLichId)
        {
            string query = "UPDATE DatLich SET TrangThai = 1 WHERE DatLichID = @DatLichID";
            SqlParameter[] parameters = {
                new SqlParameter("@DatLichID", datLichId)
            };
            int rowsAffected = ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }
        public int DemSoLichDaXacNhan(int bacSiID, DateTime ngayHen, TimeSpan gioDangKi)
        {
            string query = "SELECT COUNT(*) FROM DatLich WHERE BacSiID = @BacSiID AND NgayHen = @NgayHen AND GioDangKi = @GioDangKi AND TrangThai = 1";
            SqlParameter[] parameters = {
                new SqlParameter("@BacSiID", bacSiID),
                new SqlParameter("@NgayHen", ngayHen),
                new SqlParameter("@GioDangKi", gioDangKi)
            };
            int count = (int)ExecuteScalar(query, parameters);
            return count;
        }
        public bool XacNhanLichHen(int datLichId)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string getQuery = "SELECT * FROM DatLich WHERE DatLichID = @DatLichID";
                DatLich lich = null;

                using (SqlCommand cmd = new SqlCommand(getQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@DatLichID", datLichId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lich = new DatLich
                            {
                                DatLichID = reader.GetInt32(0),
                                BacSiID = reader.GetInt32(1),
                                BenhNhanID = reader.GetInt32(2),
                                HoTen = reader.GetString(3),
                                GioiTinh = reader.GetBoolean(4),
                                Sdt = reader.GetString(5),
                                DiaChi = reader.GetString(6),
                                GhiChu = reader.GetString(7),
                                NgayHen = reader.GetDateTime(8),
                                GioDangki = reader.GetTimeSpan(9)
                            };
                        }
                    }
                }

                if (lich == null)
                {
                    MessageBox.Show("Không tìm thấy lịch hẹn!");
                    return false;
                }
                // 3. Thêm vào LichHen và lấy lại LichHenID
                string insertLichHen = @"
            INSERT INTO LichHen (BacSiID, BenhNhanID, NgayHen, GioHen, GhiChu, HoTenNguoiKham, SDT, GioiTinh,DiaChi, DatLichID)
            OUTPUT INSERTED.LichHenID
            VALUES (@BacSiID, @BenhNhanID, @NgayHen, @GioHen, @GhiChu, @HoTenNguoiKham, @SoDienThoai, @GioiTinh,@DiaChi, @DatLichID)";

                int lichHenID = -1;
                using (SqlCommand cmd = new SqlCommand(insertLichHen, conn))
                {
                    cmd.Parameters.AddWithValue("@BacSiID", lich.BacSiID);
                    cmd.Parameters.AddWithValue("@BenhNhanID", lich.BenhNhanID);
                    cmd.Parameters.AddWithValue("@NgayHen", lich.NgayHen.Date);
                    cmd.Parameters.AddWithValue("@GioHen", lich.GioDangki);
                    cmd.Parameters.AddWithValue("@GhiChu", (object)lich.GhiChu ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@HoTenNguoiKham", lich.HoTen);
                    cmd.Parameters.AddWithValue("@SoDienThoai", lich.Sdt);
                    cmd.Parameters.AddWithValue("@GioiTinh", lich.GioiTinh);
                    cmd.Parameters.AddWithValue("@DiaChi", lich.DiaChi);
                    cmd.Parameters.AddWithValue("@DatLichID", lich.DatLichID);

                    lichHenID = (int)cmd.ExecuteScalar();
                }

                // 4. Thêm vào LichLamViec nếu chưa có
                string checkLichLamViec = @"
        SELECT COUNT(*) FROM LichLamViec 
        WHERE BacSiID = @BacSiID AND Ngay = @NgayHen AND GioBatDau = @GioHen";

                using (SqlCommand cmd = new SqlCommand(checkLichLamViec, conn))
                {
                    cmd.Parameters.AddWithValue("@BacSiID", lich.BacSiID);
                    cmd.Parameters.AddWithValue("@NgayHen", lich.NgayHen.Date);
                    cmd.Parameters.AddWithValue("@GioHen", lich.GioDangki);
                    int count = (int)cmd.ExecuteScalar();

                    if (count == 0 && lichHenID > 0)
                    {
                        string insertLichLamViec = @"
                INSERT INTO LichLamViec (BacSiID, Ngay, GioBatDau, LichHenID)
                VALUES (@BacSiID, @NgayHen, @GioHen, @LichHenID)";

                        using (SqlCommand cmdInsert = new SqlCommand(insertLichLamViec, conn))
                        {
                            cmdInsert.Parameters.AddWithValue("@BacSiID", lich.BacSiID);
                            cmdInsert.Parameters.AddWithValue("@NgayHen", lich.NgayHen.Date);
                            cmdInsert.Parameters.AddWithValue("@GioHen", lich.GioDangki);
                            cmdInsert.Parameters.AddWithValue("@LichHenID", lichHenID);
                            cmdInsert.ExecuteNonQuery();
                        }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xác nhận lịch: " + ex.Message);
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        public bool XoaDatLich(int datLichID)
        {
            string query = "DELETE FROM DatLich WHERE DatLichID = @DatLichID";
            SqlParameter[] parameters = {
                new SqlParameter("@DatLichID", datLichID)
            };
            int rowsAffected = ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }
        public bool HuyLichHen(int datLichID)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                // 1. Lấy LichHenID từ DatLichID
                int lichHenID = -1;
                string getLichHenIDQuery = "SELECT LichHenID FROM LichHen WHERE DatLichID = @DatLichID";
                using (SqlCommand cmd = new SqlCommand(getLichHenIDQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@DatLichID", datLichID);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        lichHenID = Convert.ToInt32(result);
                    }
                }

                // 2. Xóa bản ghi trong LichLamViec nếu có
                if (lichHenID != -1)
                {
                    string deleteLichLamViec = "DELETE FROM LichLamViec WHERE LichHenID = @LichHenID";
                    using (SqlCommand cmd = new SqlCommand(deleteLichLamViec, conn))
                    {
                        cmd.Parameters.AddWithValue("@LichHenID", lichHenID);
                        cmd.ExecuteNonQuery();
                    }

                    // 3. Xóa bản ghi trong LichHen
                    string deleteLichHen = "DELETE FROM LichHen WHERE LichHenID = @LichHenID";
                    using (SqlCommand cmd = new SqlCommand(deleteLichHen, conn))
                    {
                        cmd.Parameters.AddWithValue("@LichHenID", lichHenID);
                        cmd.ExecuteNonQuery();
                    }
                }

                // 4. Cập nhật trạng thái về "đang chờ" trong DatLich
                string updateDatLich = "UPDATE DatLich SET TrangThai = 0 WHERE DatLichID = @DatLichID";
                using (SqlCommand cmd = new SqlCommand(updateDatLich, conn))
                {
                    cmd.Parameters.AddWithValue("@DatLichID", datLichID);
                    cmd.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hủy lịch hẹn: " + ex.Message);
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        public bool XoaDatLichCu()
        {
            string query = "DELETE FROM DatLich WHERE NgayHen < CAST(GETDATE() AS DATE)";
            int rowsAffected = ExecuteNonQuery1(query);
            return rowsAffected > 0;
        }
        public bool ThemDatLich(int bacSiID, int benhNhanID, string hoTen, bool gioiTinh, string sdt, string diaChi, string ghiChu, DateTime ngayHen, TimeSpan gioDangki)
        {
            int lichHenId = -1;
            DateTime thoiGian = DateTime.Now;
            try
            {
                string query = @"
            INSERT INTO DatLich 
            (BacSiID, BenhNhanID, HoTen, GioiTinh, SDT, DiaChi, GhiChu, NgayHen, GioDangKi,ThoiGian)
            VALUES (@BacSiID, @BenhNhanID, @HoTen, @GioiTinh, @SDT, @DiaChi, @GhiChu, @NgayHen, @GioDangKi,@ThoiGian);
            SELECT SCOPE_IDENTITY();";
                SqlParameter[] parameters = {
                    new SqlParameter("@BacSiID", bacSiID),
                    new SqlParameter("@BenhNhanID", benhNhanID),
                    new SqlParameter("@HoTen", hoTen),
                    new SqlParameter("@GioiTinh", gioiTinh),
                    new SqlParameter("@SDT", sdt),
                    new SqlParameter("@DiaChi", diaChi),
                    new SqlParameter("@GhiChu", ghiChu),
                    new SqlParameter("@NgayHen", ngayHen),
                    new SqlParameter("@GioDangKi", gioDangki),
                    new SqlParameter("@ThoiGian", thoiGian)
                    };
                lichHenId = Convert.ToInt32(ExecuteScalar(query, parameters));

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm lịch hẹn: " + ex.Message);
            }
            finally
            {
                // Đóng kết nối nếu cần thiết
                // connection.Close();
            }
            return lichHenId > 0; // Trả về true nếu thêm thành công

        }
        public List<DatLich> GetDatLichByBacSiID(int bacSiID, DateTime ngayHen, TimeSpan gioDangKi)
        {
            List<DatLich> danhSachLichHen = new List<DatLich>();
            try
            {
                string query = "SELECT * FROM DatLich WHERE BacSiID = @BacSiID AND NgayHen=@NgayHen AND GioDangKi=@GioDangKi";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@BacSiID", bacSiID);
                    cmd.Parameters.AddWithValue("@NgayHen", ngayHen);
                    cmd.Parameters.AddWithValue("@GioDangKi", gioDangKi);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        DatLich lichHen = new DatLich
                        {
                            DatLichID = reader.GetInt32(0),
                            BacSiID = reader.GetInt32(1),
                            BenhNhanID = reader.GetInt32(2),
                            HoTen = reader.GetString(3),
                            GioiTinh = reader.GetBoolean(4),
                            Sdt = reader.GetString(5),
                            DiaChi = reader.GetString(6),
                            GhiChu = reader.GetString(7),
                            NgayHen = reader.GetDateTime(8),
                            GioDangki = reader.GetTimeSpan(9),
                            ThoiGian = reader.GetDateTime(10),
                            KhanCap = reader.IsDBNull(11) ? false : reader.GetBoolean(11),
                            TrangThai = reader.IsDBNull(12) ? (bool?)null : reader.GetBoolean(12)
                        };
                        danhSachLichHen.Add(lichHen);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy danh sách lịch hẹn: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            return danhSachLichHen;

        }
        public List<DatLich> GetDatLichByBenhNhanID(int benhNhanID)
        {
            List<DatLich> danhSachLichHen = new List<DatLich>();
            try
            {
                string query = "SELECT * FROM DatLich WHERE BenhNhanID = @BenhNhanID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@BenhNhanID", benhNhanID);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        DatLich lichHen = new DatLich
                        {
                            DatLichID = reader.GetInt32(0),
                            BacSiID = reader.GetInt32(1),
                            BenhNhanID = reader.GetInt32(2),
                            HoTen = reader.GetString(3),
                            GioiTinh = reader.GetBoolean(4),
                            Sdt = reader.GetString(5),
                            DiaChi = reader.GetString(6),
                            GhiChu = reader.GetString(7),
                            NgayHen = reader.GetDateTime(8),
                            GioDangki = reader.GetTimeSpan(9),
                            ThoiGian = reader.GetDateTime(10),
                            KhanCap = reader.IsDBNull(11) ? false : reader.GetBoolean(11),
                            TrangThai = reader.IsDBNull(12) ? (bool?)null : reader.GetBoolean(12)
                        };
                        danhSachLichHen.Add(lichHen);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy danh sách lịch hẹn: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            return danhSachLichHen;
        }
    
    public List<DatLich> GetDatLichByBacSiID(int bacSiID)
        {
            List<DatLich> danhSachLichHen = new List<DatLich>();
            try
            {
                string query = "SELECT * FROM DatLich WHERE BacSiID = @BacSiID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@BacSiID", bacSiID);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        DatLich lichHen = new DatLich
                        {
                            DatLichID = reader.GetInt32(0),
                            BacSiID = reader.GetInt32(1),
                            BenhNhanID = reader.GetInt32(2),
                            HoTen = reader.GetString(3),
                            GioiTinh = reader.GetBoolean(4),
                            Sdt = reader.GetString(5),
                            DiaChi = reader.GetString(6),
                            GhiChu = reader.GetString(7),
                            NgayHen = reader.GetDateTime(8),
                            GioDangki = reader.GetTimeSpan(9),
                            ThoiGian = reader.GetDateTime(10),
                            KhanCap = reader.IsDBNull(11) ? false : reader.GetBoolean(11),
                            TrangThai = reader.IsDBNull(12) ? (bool?)null : reader.GetBoolean(12)
                        };
                        danhSachLichHen.Add(lichHen);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy danh sách lịch hẹn: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            return danhSachLichHen;
        }
    }
}
