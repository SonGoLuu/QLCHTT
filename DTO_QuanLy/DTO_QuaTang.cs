using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_QuaTang
    {
        private string _TenQua;
        private string _TenKH;
        public string TenQua
        {
            get
            {
                return _TenQua;
            }
            set
            {
                _TenQua = value;
            }
        }
        public string TenKH
        {
            get
            {
                return _TenKH;
            }
            set
            {
                _TenKH = value;
            }
        }
        public DTO_QuaTang()
        {

        }
        public DTO_QuaTang(string tenqua, string tenkh)
        {
            this.TenQua = tenqua;
            this.TenKH = tenkh;
        }
    }
}
