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
    public class DAL_PhieuNhap : DBConnect
    {
        public DataTable getAllPhieuNhap()
        {
            cnn.Open();
            string sql = string.Format("SELECT A.MAPHIEU, A.MANCC, A.MANVLAP, B.HOTENNV, A.NGAYLAP, A.TONGTIEN FROM PHIEUNHAP A, NHANVIEN B WHERE A.MANVLAP =B.MANV");
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        public DataTable getPhieuNhap(string MaPhieu)
        {
            cnn.Open();
            string sql = string.Format("SELECT A.MAPHIEU, A.MANCC, A.MANVLAP, B.HOTENNV, A.NGAYLAP, A.TONGTIEN FROM PHIEUNHAP A, NHANVIEN B WHERE A.MANVLAP =B.MANV AND A.MAPHIEU ='{0}'", MaPhieu);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        //Thêm phiếu nhập
        public bool themPhieuNhap(DTO_PhieuNhap phieunhap)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("themPhieuNhap", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaPhieu", phieunhap.MaPhieu);
                cmd.Parameters.AddWithValue("@MaNCC", phieunhap.MaNCC);
                cmd.Parameters.AddWithValue("@MaNVLap", phieunhap.MaNVLap);
                cmd.Parameters.AddWithValue("@NgayLap", phieunhap.NgayLap);
                cmd.Parameters.AddWithValue("@TongTien", phieunhap.TongTien);
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
        public bool checkMaPhieu(string MaPhieu)
        {
            cnn.Open();
            string sql = string.Format("SELECT MAPHIEU FROM PHIEUNHAP WHERE MAPHIEU = '{0}'", MaPhieu);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            { return false; }
        }

        //Sửa phiếu nhập
        public bool suaPhieuNhap(decimal tongtien, string maphieu)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("suaPhieuNhap", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaPhieu", maphieu);
                cmd.Parameters.AddWithValue("@MaPhieu", tongtien);
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
        public DataTable trongCTPN(string MaPN)
        {
            cnn.Open();
            string sql = string.Format("SELECT A.MAPHIEU, B.TENNCC, A.MANVLAP, C.HOTENNV, A.NGAYLAP, A.TONGTIEN  FROM PHIEUNHAP A, NHACUNGCAP B, NHANVIEN C WHERE A.MANCC = B.MANCC AND A.MANVLAP = C.MANV AND A.MAPHIEU ='{0}'", MaPN);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
    }
}
