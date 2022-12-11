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
    public class DAL_ChiTietPhieuNhap : DBConnect
    {
        public DataTable getdgvCTHD(string maphieu)
        {
            cnn.Open();
            string sql = string.Format("SELECT A.MASP, B.TENSP, A.GIAGOC, A.SLNHAP, A.THANHTIEN FROM CHITIETPHIEUNHAP A, SANPHAM B WHERE A.MASP = B.MASP AND A.MAPHIEU = '{0}'", maphieu);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        public DataTable getCTHD()
        {
            cnn.Open();
            string sql = string.Format("SELECT * FROM CHITIETPHIEUNHAP");
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        public bool themCTPN(DTO_ChiTietPhieuNhap ctpn)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("themCTPN", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaPhieu", ctpn.MaPhieu);
                cmd.Parameters.AddWithValue("@MaSP", ctpn.MaSP);
                cmd.Parameters.AddWithValue("@GiaGoc", ctpn.GiaGoc);
                cmd.Parameters.AddWithValue("@SLNhap", ctpn.SLNhap);
                cmd.Parameters.AddWithValue("@ThanhTien", ctpn.ThanhTien);
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

    }
}
