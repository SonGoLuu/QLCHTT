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
    public class DAL_HoaDon : DBConnect
    {
        public DataTable getAllHoaDon()
        {
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT A.MAHD, B.SDTKH, A.MANVLAP, D.TENQUA, C.HOTENNV, A.NGAYLAP, A.TONGTIEN  FROM HOADON A, KHACHHANG B, NHANVIEN C, QUATANG D WHERE A.MAKH = B.MAKH AND A.MANVLAP = C.MANV AND A.MAQUA = D.MAQUA", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        //Thêm hóa đơn
        public bool themHoaDon(DTO_HoaDon hoadon)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("themHoaDon", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaHD", hoadon.MaHD);
                cmd.Parameters.AddWithValue("@MaKH", hoadon.MaKH);
                cmd.Parameters.AddWithValue("@MaNVLap", hoadon.MaNVLap);
                cmd.Parameters.AddWithValue("@MaQua", hoadon.MaQua);
                cmd.Parameters.AddWithValue("@NgayLap", hoadon.NgayLap);
                cmd.Parameters.AddWithValue("@TongTien", hoadon.TongTien);
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
        public DataTable findHoaDon(string SDTKH)
        {
            cnn.Open();
            string sql = string.Format("SELECT A.MAHD, B.SDTKH, A.MANVLAP, D.TENQUA, C.HOTENNV, A.NGAYLAP, A.TONGTIEN  FROM HOADON A, KHACHHANG B, NHANVIEN C, QUATANG D WHERE A.MAKH = B.MAKH AND A.MANVLAP = C.MANV AND A.MAQUA = D.MAQUA AND B.SDTKH ='{0}'", SDTKH);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        public DataTable trongCTHD(string MaHD)
        {
            cnn.Open();
            string sql = string.Format("SELECT A.MAHD, B.SDTKH, A.MANVLAP, C.HOTENNV, A.NGAYLAP, A.TONGTIEN  FROM HOADON A, KHACHHANG B, NHANVIEN C WHERE A.MAKH = B.MAKH AND A.MANVLAP = C.MANV AND A.MAHD ='{0}'", MaHD);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
    }
}
