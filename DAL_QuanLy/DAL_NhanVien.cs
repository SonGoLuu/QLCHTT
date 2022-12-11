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
    public class DAL_NhanVien : DBConnect
    {
        /// <summary>
        /// Get toàn bộ nhân viên
        /// </summary>
        /// <returns></returns>
        public DataTable getNhanVien()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NhanVien", cnn);
            DataTable dtNhanVien = new DataTable();
            da.Fill(dtNhanVien);
            cnn.Close();
            return dtNhanVien;
        }
        /// <summary>
        /// Thêm nhân viên
        /// </summary>
        /// <returns></returns>
        public bool themNhanVien(DTO_NhanVien nv)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("themNhanVien", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNV", nv.MaNV);
                cmd.Parameters.AddWithValue("@HoTenNV", nv.HoTenNV);
                cmd.Parameters.AddWithValue("@ChucVu", nv.ChucVu);
                cmd.Parameters.AddWithValue("@NgaySinh", nv.NgaySinh);
                cmd.Parameters.AddWithValue("@GioiTinh", nv.GioiTinh);
                cmd.Parameters.AddWithValue("@SDTNV", nv.SDTNV);
                cmd.Parameters.AddWithValue("@DiaChi", nv.DiaChi);
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
        public bool suaNhanVien(DTO_NhanVien nv)
        {
            try
            {
                // Ket noi
                cnn.Open();
                // Query string
                SqlCommand cmd = new SqlCommand("suaNhanVien", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNV", nv.MaNV);
                cmd.Parameters.AddWithValue("@HoTenNV", nv.HoTenNV);
                cmd.Parameters.AddWithValue("@ChucVu", nv.ChucVu);
                cmd.Parameters.AddWithValue("@NgaySinh", nv.NgaySinh);
                cmd.Parameters.AddWithValue("@GioiTinh", nv.GioiTinh);
                cmd.Parameters.AddWithValue("@SDTNV", nv.SDTNV);
                cmd.Parameters.AddWithValue("@DiaChi", nv.DiaChi);
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
        public bool xoaNhanVien(string MANV)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("xoaNhanVien", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNV", MANV);
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
        public DataTable findNhanVien(string HoTenNV)
        {
            cnn.Open();
            string sqlFind = string.Format("SELECT * FROM NHANVIEN WHERE HOTENNV = N'{0}'", HoTenNV);
            SqlDataAdapter da = new SqlDataAdapter(sqlFind, cnn);
            DataTable dtFindNhanVien = new DataTable();
            da.Fill(dtFindNhanVien);
            cnn.Close();
            return dtFindNhanVien;
        }

        //Lấy họ tên nhân viên
        public string getHoTenNhanVien(string MaNV)
        {
            cnn.Open();
            string sqlFind = string.Format("SELECT HOTENNV FROM NHANVIEN WHERE MANV = '{0}'", MaNV);
            SqlDataAdapter da = new SqlDataAdapter(sqlFind, cnn);
            DataTable dtTenNhanVien = new DataTable();
            da.Fill(dtTenNhanVien);
            string HoTenNV = dtTenNhanVien.Rows[0].Field<string>(0);
            cnn.Close();
            return HoTenNV;
        }

        //Lấy chức vụ nhân viên
        public string getChucVu(string MaNV)
        {
            cnn.Open();
            string sqlFind = string.Format("SELECT CHUCVU FROM NHANVIEN WHERE MANV = '{0}'", MaNV);
            SqlDataAdapter da = new SqlDataAdapter(sqlFind, cnn);
            DataTable dtChucVu = new DataTable();
            da.Fill(dtChucVu);
            string ChucVu = dtChucVu.Rows[0].Field<string>(0);
            cnn.Close();
            return ChucVu;
        }

        //Lấy danh sách Mã Nhân Viên chưa có tài khoản
        public DataTable getMaNVChuaCoTaiKhoan()
        {
            cnn.Open();
            string sqlFind = string.Format("SELECT MANV FROM NHANVIEN EXCEPT SELECT MANV FROM TAIKHOAN");
            SqlDataAdapter da = new SqlDataAdapter(sqlFind, cnn);
            DataTable dtDsMaNV = new DataTable();
            da.Fill(dtDsMaNV);
            cnn.Close();
            return dtDsMaNV;
        }

    }
}
