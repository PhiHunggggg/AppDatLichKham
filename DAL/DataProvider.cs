using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace AppDatLichKham.DAL
{
    internal class DataProvider : SQLConnection
    {
        #region Properties
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }
        #endregion
        #region Constructor
        protected DataProvider() { }
        #endregion
        #region Methods
        // Truy vấn ko trả về dữ liệu
        public void ExecuteNonQuery(string query)
        {
            try
            {
                OpenConnection();
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseConnection();
            }
        }
        public int ExecuteNonQuery1(string query)
        {
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand(query, conn);
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                CloseConnection();
                throw ex;
            }
        }
        public int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand(query, conn);
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                CloseConnection();
                throw ex;
            }
        }

        // Truy vấn trả về dữ liệu duy nhất
        public object ExecuteScalar(string query)
        {
            try
            {
                OpenConnection();
                cmd = new SqlCommand(query, conn);
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseConnection();
            }
        }
        public object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand(query, conn);
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                CloseConnection();
                throw ex;
            }
        }
        // Đọc từng dòng dữ liệu
        public SqlDataReader ExecuteReader(string query)
        {
            try
            {
                OpenConnection();
                cmd = new SqlCommand(query, conn);
                return cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public SqlDataReader ExecuteReader(string query, SqlParameter[] parameters = null)
        {
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand(query, conn);

                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                CloseConnection(); 
                throw ex;
            }
        }
        //Truyền tham số an toàn
        public void ExecuteQuery(string query, SqlParameter[] parameters)
        {
            try
            {
                OpenConnection();
                cmd = new SqlCommand(query, conn);
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseConnection();
            }
        }
        public void ExecuteQuery(string query)
        {
            try
            {
                OpenConnection();
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseConnection();
            }
        }
        #endregion
    }
}
