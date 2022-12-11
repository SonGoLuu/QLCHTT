using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QuanLy;
using DTO_QuanLy;

namespace QLCHTT
{
    public partial class FormChiTietPhieuNhap : Form
    {
        string _MaPN;
        BUS_CTPN busCTPN = new BUS_CTPN();
        BUS_PhieuNhap busPhieuNhap = new BUS_PhieuNhap();
        public FormChiTietPhieuNhap()
        {
            InitializeComponent();
        }
        public string MaPN
        {
            get
            {
                return _MaPN;
            }
            set
            {
                _MaPN = value;
            }
        }

        private void iconbtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormChiTietPhieuNhap_Load(object sender, EventArgs e)
        {
            dgvCTPN.DataSource = busCTPN.getdgvCTHD(MaPN);
            txtMaPhieu.Text = busPhieuNhap.trongCTPN(MaPN).Rows[0].Field<string>(0);
            txtTenNCC.Text = busPhieuNhap.trongCTPN(MaPN).Rows[0].Field<string>(1);
            txtMaNVLap.Text = busPhieuNhap.trongCTPN(MaPN).Rows[0].Field<string>(2);
            txtHoTenNV.Text = busPhieuNhap.trongCTPN(MaPN).Rows[0].Field<string>(3);
            txtNgayLap.Text = busPhieuNhap.trongCTPN(MaPN).Rows[0].Field<DateTime>(4).ToString("dd/MM/yyyy");
            txtTongTien.Text = busPhieuNhap.trongCTPN(MaPN).Rows[0].Field<decimal>(5).ToString();
        }
    }
}
