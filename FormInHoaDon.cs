using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using DTO_QuanLy;

namespace QLCHTT
{
    
    public partial class FormInHoaDon : Form
    {
        string mahd;
        string tenqua;
        string tenkh;
        public FormInHoaDon()
        {
            InitializeComponent();
        }
        public FormInHoaDon(string mahd, string tenqua, string tenkh) : this()
        {
            this.mahd = mahd;
            this.tenqua = tenqua;
            this.tenkh = tenkh;
        }
        public List<DTO_QuaTang> GetQuaTang()
        {
            List<DTO_QuaTang> dtoquatang = new List<DTO_QuaTang>();
            DTO_QuaTang temp = new DTO_QuaTang(tenqua, tenkh);
            dtoquatang.Add(temp);
            return dtoquatang;
        }    
        private void FormInHoaDon_Load(object sender, EventArgs e)
        {
            List<DTO_QuaTang> dtoquatang = GetQuaTang();
            SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-5LK6RF58;Initial Catalog=THOITRANG;Integrated Security=True");
            cnn.Open();
            string sqlcthd = string.Format("Select * From ChiTietHoaDon Where MaHD = '{0}'", this.mahd);
            SqlDataAdapter da1 = new SqlDataAdapter(sqlcthd, cnn);
            DataTable dt1 = new DataTable("DataSetInHoaDon");
            da1.Fill(dt1);
            string sqlsp = string.Format("Select * From SanPham");
            SqlDataAdapter da2 = new SqlDataAdapter(sqlsp, cnn);
            DataTable dt2 = new DataTable("DataSetSanPham");
            da2.Fill(dt2);
            cnn.Close();
            ReportDataSource rds1 = new ReportDataSource("DataSetInHoaDon", dt1);
            ReportDataSource rds2 = new ReportDataSource("DataSetSanPham", dt2);
            ReportDataSource rds3 = new ReportDataSource("DataSetQuaTang", dtoquatang);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds1);
            this.reportViewer1.LocalReport.DataSources.Add(rds2);
            this.reportViewer1.LocalReport.DataSources.Add(rds3);
            this.reportViewer1.RefreshReport();
        }
    }
}
