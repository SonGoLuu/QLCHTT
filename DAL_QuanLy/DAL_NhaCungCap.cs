using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO_QuanLy;

namespace DAL_QuanLy
{
    public class DAL_NhaCungCap : DBConnect
    {
        public DataTable getAllNCC()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NHACUNGCAP", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        //Lấy mã NCC từ tên NCC
        public string getMaNCC(string TenNCC)
        {
            cnn.Open();
            string sql = string.Format("SELECT MANCC FROM NHACUNGCAP WHERE TENNCC =N'{0}'", TenNCC);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string MaNCC = dt.Rows[0].Field<string>(0);
            cnn.Close();
            return MaNCC;
        }
        //Lấy danh sách tên ncc
        public DataTable getAllTenNCC()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT TenNCC FROM NHACUNGCAP", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        //Thêm NCC
        public bool themNCC(DTO_NhaCungCap ncc)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("themNCC", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNCC", ncc.MaNCC);
                cmd.Parameters.AddWithValue("@TenNCC", ncc.TenNCC);
                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                cnn.Close();
            }

            return false;
        }
        //Sửa NCC
        public bool suaNCC(DTO_NhaCungCap ncc)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("suaNCC", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNCC", ncc.MaNCC);
                cmd.Parameters.AddWithValue("@TenNCC", ncc.TenNCC);
                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                cnn.Close();
            }

            return false;
        }
        //Xóa NCC
        public bool xoaNCC(DTO_NhaCungCap ncc)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("xoaNCC", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNCC", ncc.MaNCC);
                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                cnn.Close();
            }

            return false;
        }
        //Tìm kiếm NCC
        public DataTable findNCC(string TenNCC)
        {
            cnn.Open();
            string sql = string.Format("SELECT * FROM NHACUNGCAP WHERE TENNCC = N'{0}'", TenNCC);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        //Lấy tên ncc từ mã ncc
        public string getTenNCC(string mancc)
        {
            cnn.Open();
            string sql = string.Format("SELECT TENNCC FROM NHACUNGCAP WHERE MANCC = '{0}'", mancc);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string tenncc = dt.Rows[0].Field<string>(0);
            cnn.Close();
            return tenncc;
        }
    }
}
