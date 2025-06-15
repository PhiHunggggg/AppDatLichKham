using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDatLichKham.DAL.Entity;
using Microsoft.Data.SqlClient;

namespace AppDatLichKham.DAL
{
        internal class PhongKhamDAL : DataProvider
        {
            private static PhongKhamDAL instance;
            public new static PhongKhamDAL Instance
            {
                get
                {
                    if (instance == null)
                    {
                        instance = new PhongKhamDAL();
                    }
                    return instance;
                }
                private set => instance = value;
            }
            private PhongKhamDAL() { }
        public List<PhongKhamEntity> GetDanhSachPhongKhamRanh(DateTime ngay, TimeSpan gio)
        {
            List<PhongKhamEntity> danhSach = new List<PhongKhamEntity>();

            string query = @"
            SELECT PK.PhongKham, PK.TenPhongKham
            FROM PhongKham PK
            WHERE NOT EXISTS (
             SELECT 1
             FROM LichHen LH
              WHERE LH.NgayHen = @ngay AND LH.GioHen = @gio
             AND LH.PhongKham = PK.PhongKham
            )";

            SqlParameter[] parameters = {
            new SqlParameter("@ngay", ngay.Date),
            new SqlParameter("@gio", gio)
            };

            using (SqlDataReader reader = ExecuteReader(query, parameters))
            {
                while (reader.Read())
                {
                    PhongKhamEntity pk = new PhongKhamEntity
                    {
                        PhongKham = reader.GetInt32(0),
                        TenPhongKham = reader.GetString(1)
                    };
                    danhSach.Add(pk);
                }
            }

            return danhSach;
        }
        public string GetTenPhongKhamByID(int phongKhamID)
        {
            string query = "SELECT TenPhongKham FROM PhongKham WHERE PhongKham = @phongKhamID";
            SqlParameter[] parameters = {
                new SqlParameter("@phongKhamID", phongKhamID)
            };
            return ExecuteScalar(query, parameters)?.ToString();
        }

    }
}
