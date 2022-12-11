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
    public class DAL_ChiTietHoaDon : DBConnect
    {
        public DataTable getCTHD(string MaHD)
        {
            cnn.Open();
            string sql = string.Format("SELECT A.MASP, B.TENSP, B.GIABAN, A.SLMUA, A.KHUYENMAI, A.THANHTIEN FROM CHITIETHOADON A, SANPHAM B WHERE A.MASP = B.MASP AND A.MAHD = '{0}'", MaHD);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        public bool themCTHD(DTO_ChiTietHoaDon cthd)
        {
            try
            {
                // Ket noi
                cnn.Open();
                SqlCommand cmd = new SqlCommand("themCTHD", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaHD", cthd.MaHD);
                cmd.Parameters.AddWithValue("@MaSP", cthd.MaSP);
                cmd.Parameters.AddWithValue("@SLMua", cthd.SLMua);
                cmd.Parameters.AddWithValue("@KhuyenMai", cthd.KhuyenMai);
                cmd.Parameters.AddWithValue("@ThanhTien", cthd.ThanhTien);
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
        public string getMaQua(string TenQua)
        {
            cnn.Open();
            string sql = string.Format("SELECT MAQUA FROM QUATANG WHERE TENQUA = N'{0}'", TenQua);
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string maqua = dt.Rows[0].Field<string>(0);
            cnn.Close();
            return maqua;
        }
    }
}
