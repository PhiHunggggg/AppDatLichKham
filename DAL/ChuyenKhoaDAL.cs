using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDatLichKham.Entity;
using Microsoft.Data.SqlClient;

namespace AppDatLichKham.DAL
{
    internal class ChuyenKhoaDAL : DataProvider
    {
        private static ChuyenKhoaDAL instance;
        public new static ChuyenKhoaDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChuyenKhoaDAL();
                }
                return instance;
            }
            private set => instance = value;
        }
        private ChuyenKhoaDAL() { }
        public void AddChuyenKhoa(string tenChuyenKhoa)
        {
            string query = "INSERT INTO ChuyenKhoa (TenChuyenKhoa) VALUES (@tenChuyenKhoa)";
            SqlParameter[] parameters = {
        new SqlParameter("@tenChuyenKhoa", tenChuyenKhoa)
    };
            ExecuteQuery(query, parameters);
        }
        public void UpdateChuyenKhoa(string tenChuyenKhoa, int chuyenKhoaID)
        {
            string query = "UPDATE ChuyenKhoa SET TenChuyenKhoa = @tenChuyenKhoa WHERE ChuyenKhoaID = @id";
            SqlParameter[] parameters = {
        new SqlParameter("@tenChuyenKhoa", tenChuyenKhoa),
        new SqlParameter("@id", chuyenKhoaID)
    };
            ExecuteQuery(query, parameters);
        }
        public void DeleteChuyenKhoa(int chuyenKhoaID)
        {
            string query = "DELETE FROM ChuyenKhoa WHERE ChuyenKhoaID = @id";
            SqlParameter[] parameters = {
        new SqlParameter("@id", chuyenKhoaID)
    };
            ExecuteQuery(query, parameters);
        }
        public List<ChuyenKhoa> GetAllChuyenKhoa()
        {

            string query = "SELECT * FROM ChuyenKhoa";
            List<ChuyenKhoa> list = new List<ChuyenKhoa>();
            SqlDataReader reader = ExecuteReader(query);
            while (reader.Read())
            {
                ChuyenKhoa chuyenKhoa = new ChuyenKhoa();
                chuyenKhoa.ChuyenKhoaID = reader.GetInt32(0);
                chuyenKhoa.TenChuyenKhoa = reader.GetString(1);
                list.Add(chuyenKhoa);
            }
            reader.Close();
            return list;
        }
        public string GetChuyenKhoaByID(int chuyenKhoaID)
        {
            string query = "SELECT TenChuyenKhoa FROM ChuyenKhoa WHERE ChuyenKhoaID = @id";
            SqlParameter[] parameters = {
                new SqlParameter("@id", chuyenKhoaID)
            };
            SqlDataReader reader = ExecuteReader(query, parameters);
            string tenChuyenKhoa = null;
            if (reader.Read())
            {
                tenChuyenKhoa = reader.GetString(0);
            }
            reader.Close();
            return tenChuyenKhoa;
        }
    }
}
