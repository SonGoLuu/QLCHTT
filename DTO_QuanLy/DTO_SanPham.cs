using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_SanPham
    {
        string _MaSP;
        string _TenSP;
        string _MaLoai;
        decimal _GiaBan;
        int _SLTon;
        string _ChatLieu;
        /*=======GETTER/SETTER=======*/
        public string MaSP
        {
            get
            {
                return _MaSP;
            }
            set
            {
                _MaSP = value;
            }
        }
        public string TenSP
        {
            get
            {
                return _TenSP;
            }
            set
            {
                _TenSP = value;
            }
        }
        public string MaLoai
        {
            get
            {
                return _MaLoai;
            }
            set
            {
                _MaLoai = value;
            }
        }
        public decimal GiaBan
        {
            get
            {
                return _GiaBan;
            }
            set
            {
                _GiaBan = value;
            }
        }
        public int SLTon
        {
            get
            {
                return _SLTon;
            }
            set
            {
                _SLTon = value;
            }
        }
        public string ChatLieu
        {
            get
            {
                return _ChatLieu;
            }
            set
            {
                _ChatLieu = value;
            }
        }
        public DTO_SanPham()
        {

        }
        public DTO_SanPham(string masp, string tensp, string maloai, decimal giaban, int slton, string chatlieu)
        {
            this.MaSP = masp;
            this.TenSP = tensp;
            this.MaLoai = maloai;
            this.GiaBan = giaban;
            this.SLTon = slton;
            this.ChatLieu = chatlieu;
        }
    }
}
