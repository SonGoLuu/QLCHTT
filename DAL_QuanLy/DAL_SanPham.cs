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
    public class DAL_SanPham : DBConnect
    {
        public DataTable getAllSP()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM SANPHAM", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        //Lấy mã sp từ tên sp
        public string getMaSP(string TenSP)
        {
            cnn.Open();
            string sql = string.Format("SELECT MASP FROM SANPHAM WHERE TENSP ='{0}'", TenSP);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string MaSP = dt.Rows[0].Field<string>(0);
            cnn.Close();
            return MaSP;
        }

        //Lấy thông tin sản phẩm từ mã sp
        public DataTable getThongTinSP(string MaSP)
        {
            cnn.Open();
            string sql = string.Format("SELECT * FROM SANPHAM WHERE MASP = '{0}'", MaSP);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        //Thêm sản phẩm
        public bool themSP(DTO_SanPham sp)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("themSanPham", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaSP", sp.MaSP);
                cmd.Parameters.AddWithValue("@TenSP", sp.TenSP);
                cmd.Parameters.AddWithValue("@MaLoai", sp.MaLoai);
                cmd.Parameters.AddWithValue("@GiaBan", sp.GiaBan);
                cmd.Parameters.AddWithValue("@SLTon", sp.SLTon);
                cmd.Parameters.AddWithValue("@ChatLieu", sp.ChatLieu);
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
        //Sửa Sản phẩm
        public bool suaSP(DTO_SanPham sp)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("suaSanPham", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaSP", sp.MaSP);
                cmd.Parameters.AddWithValue("@TenSP", sp.TenSP);
                cmd.Parameters.AddWithValue("@MaLoai", sp.MaLoai);
                cmd.Parameters.AddWithValue("@GiaBan", sp.GiaBan);
                cmd.Parameters.AddWithValue("@SLTon", sp.SLTon);
                cmd.Parameters.AddWithValue("@ChatLieu", sp.ChatLieu);
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
        //Xóa SP
        public bool xoaSP(DTO_SanPham sp)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("xoaSanPham", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaSP", sp.MaSP);
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
        //Tìm kiếm SP
        public DataTable findSP(string TenSP)
        {
            cnn.Open();
            string sql = string.Format("SELECT * FROM SANPHAM WHERE TENSP =N'{0}'", TenSP);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        //Lấy tất cả mã sản phẩm
        public DataTable getAllMaSP()
        {
            cnn.Open();
            string sql = string.Format("SELECT MASP FROM SANPHAM");
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        public bool checkMaSP(string MaSP)
        {
            cnn.Open();
            string sql = string.Format("SELECT MASP FROM SANPHAM WHERE MASP ='{0}'", MaSP);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            if (dt.Rows.Count > 0) return true;
            else return false;
        }
        /*public bool updateSLTon(int SLMua, string MaSP)
        {
            try
            {
                cnn.Open();
                string sql = string.Format("UPDATE SANPHAM SET SLTON = SLTON - {0} WHERE MASP = '{1}'", SLMua, MaSP);
                SqlCommand cmd = new SqlCommand(sql, cnn);
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
        }*/
    }
}
