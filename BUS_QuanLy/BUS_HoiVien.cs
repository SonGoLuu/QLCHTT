using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_QuanLy;
using DTO_QuanLy;

namespace BUS_QuanLy
{
    public class BUS_HoiVien
    {
        DAL_HoiVien dalHoiVien = new DAL_HoiVien();
        public DataTable getAllHoiVien()
        {
            return dalHoiVien.getAllHoiVien();
        }    
    }
}
