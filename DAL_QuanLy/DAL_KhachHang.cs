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
    public class DAL_KhachHang : DBConnect
    {
        public DataTable getAllKhachHang()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM KHACHHANG", cnn);
            DataTable dtKhachHang = new DataTable();
            da.Fill(dtKhachHang);
            cnn.Close();
            return dtKhachHang;
        }
        //Lấy họ tên khách hàng
        public string getHoTenKhachHang(string MaKH)
        {
            cnn.Open();
            string sqlFind = string.Format("SELECT TENKH FROM KHACHHANG WHERE MAKH = '{0}'", MaKH);
            SqlDataAdapter da = new SqlDataAdapter(sqlFind, cnn);
            DataTable dtTenKH = new DataTable();
            da.Fill(dtTenKH);
            string HoTenKH = dtTenKH.Rows[0].Field<string>(0);
            cnn.Close();
            return HoTenKH;
        }
        //Lấy sđt khách hàng
        public string getSDTKH(string MaKH)
        {
            cnn.Open();
            string sqlFind = string.Format("SELECT SDTKH FROM KHACHHANG WHERE MAKH = '{0}'", MaKH);
            SqlDataAdapter da = new SqlDataAdapter(sqlFind, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string SDTKH = dt.Rows[0].Field<string>(0);
            cnn.Close();
            return SDTKH;
        }
        //Lấy địa chỉ khách hàng
        public string getDiaChi(string MaKH)
        {
            cnn.Open();
            string sqlFind = string.Format("SELECT DIACHI FROM KHACHHANG WHERE MAKH = '{0}'", MaKH);
            SqlDataAdapter da = new SqlDataAdapter(sqlFind, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string DiaChi = dt.Rows[0].Field<string>(0);
            cnn.Close();
            return DiaChi;
        }
        //Lấy giảm giá cho khách hàng
        public int getGiamGia(string MaKH)
        {
            cnn.Open();
            string sqlFind = string.Format("SELECT GIAMGIA FROM HoiVien A, KhachHang B WHERE A.MaHV = B.MaHV AND B.MaKH = '{0}'", MaKH);
            SqlDataAdapter da = new SqlDataAdapter(sqlFind, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int GiamGia = dt.Rows[0].Field<int>(0);
            cnn.Close();
            return GiamGia;
        }
        //Lấy Mã KH from SDTKH
        public string getMaKHFromSDTKH(string SDTKH)
        {
            cnn.Open();
            string sqlFind = string.Format("SELECT MAKH FROM KHACHHANG WHERE SDTKH = '{0}'", SDTKH);
            SqlDataAdapter da = new SqlDataAdapter(sqlFind, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string MaKH = dt.Rows[0].Field<string>(0);
            cnn.Close();
            return MaKH;
        }
        //Thêm KHÁCH HÀNG
        public bool themKhachHang(DTO_KhachHang kh)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("themKhachHang", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaKH", kh.MaKH);
                cmd.Parameters.AddWithValue("@MaThe", kh.MaHV);
                cmd.Parameters.AddWithValue("@TenKH", kh.HoTenKH);
                cmd.Parameters.AddWithValue("@SDTKH", kh.SDTKH);
                cmd.Parameters.AddWithValue("@DiaChi", kh.DiaChi);
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
        //Sửa KHÁCH HÀNG
        public bool suaKhachHang(DTO_KhachHang kh)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("suaKhachHang", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaKH", kh.MaKH);
                cmd.Parameters.AddWithValue("@MaThe", kh.MaHV);
                cmd.Parameters.AddWithValue("@TenKH", kh.HoTenKH);
                cmd.Parameters.AddWithValue("@SDTKH", kh.SDTKH);
                cmd.Parameters.AddWithValue("@DiaChi", kh.DiaChi);
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
        //Xóa KHÁCH HÀNG
        public bool xoaKhachHang(DTO_KhachHang kh)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("xoaKhachHang", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaKH", kh.MaKH);
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
        public DataTable findKhachHang(string SDTKH)
        {
            cnn.Open();
            string sql = string.Format("SELECT * FROM KHACHHANG WHERE SDTKH ='{0}'", SDTKH);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        public bool checkMaKH(string MaKH)
        {
            cnn.Open();
            string sql = string.Format("SELECT MAKH FROM KHACHHANG WHERE MAKH ='{0}'", MaKH);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            if (dt.Rows.Count > 0) return true;
            else return false;
        }
    }
}
