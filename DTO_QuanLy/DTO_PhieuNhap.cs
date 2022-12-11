using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_PhieuNhap
    {
        string _MaPhieu;
        string _MaNCC;
        string _MaNVLap;
        DateTime _NgayLap;
        decimal _TongTien;
        /*=======GETTER/SETTER=======*/
        public string MaPhieu
        {
            get
            {
                return _MaPhieu;
            }
            set
            {
                _MaPhieu = value;
            }
        }
        public string MaNCC
        {
            get
            {
                return _MaNCC;
            }
            set
            {
                _MaNCC = value;
            }
        }
        public string MaNVLap
        {
            get
            {
                return _MaNVLap;
            }
            set
            {
                _MaNVLap = value;
            }
        }
        public DateTime NgayLap
        {
            get
            {
                return _NgayLap;
            }
            set
            {
                _NgayLap = value;
            }
        }
        public decimal TongTien
        {
            get
            {
                return _TongTien;
            }
            set
            {
                _TongTien = value;
            }
        }
        public DTO_PhieuNhap()
        {

        }
        public DTO_PhieuNhap(string maphieu, string mancc, string manvlap, DateTime ngaylap, decimal tongtien)
        {
            this.MaPhieu = maphieu;
            this.MaNCC = mancc;
            this.MaNVLap = manvlap;
            this.NgayLap = ngaylap;
            this.TongTien = tongtien;
        }
    }
}
