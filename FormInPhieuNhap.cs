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
    public partial class FormInPhieuNhap : Form
    {
        string mapn;
        string tenncc;
        public FormInPhieuNhap()
        {
            InitializeComponent();
        }
        public FormInPhieuNhap(string mapn, string tenncc) : this()
        {
            this.mapn = mapn;
            this.tenncc = tenncc;
        }
        public List<DTO_NhaCungCap> GetNCC()
        {
            List<DTO_NhaCungCap> dtoncc = new List<DTO_NhaCungCap>();
            DTO_NhaCungCap temp = new DTO_NhaCungCap("NCC00", tenncc);
            dtoncc.Add(temp);
            return dtoncc;
        }
        private void FormInPhieuNhap_Load(object sender, EventArgs e)
        {
            List<DTO_NhaCungCap> dtoncc = GetNCC();
            SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-5LK6RF58;Initial Catalog=THOITRANG;Integrated Security=True");
            cnn.Open();
            string sqlctpn = string.Format("Select * From ChiTietPhieuNhap Where MaPhieu = '{0}'", this.mapn);
            SqlDataAdapter da1 = new SqlDataAdapter(sqlctpn, cnn);
            DataTable dt1 = new DataTable("DataSetInPhieuNhap");
            da1.Fill(dt1);
            string sqlsp = string.Format("Select * From SanPham");
            SqlDataAdapter da2 = new SqlDataAdapter(sqlsp, cnn);
            DataTable dt2 = new DataTable("DataSetSanPham");
            da2.Fill(dt2);
            cnn.Close();
            ReportDataSource rds1 = new ReportDataSource("DataSetInPhieuNhap", dt1);
            ReportDataSource rds2 = new ReportDataSource("DataSetSanPham", dt2);
            ReportDataSource rds3 = new ReportDataSource("DataSetNCC", dtoncc);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds1);
            this.reportViewer1.LocalReport.DataSources.Add(rds2);
            this.reportViewer1.LocalReport.DataSources.Add(rds3);
            this.reportViewer1.RefreshReport();
        }
    }
}
