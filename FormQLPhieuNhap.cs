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
    public partial class FormQLPhieuNhap : Form
    {
        string _HoTenNV;
        string _MaPNCuoi;
        decimal _TongTien = 0;
        BUS_PhieuNhap busPhieuNhap = new BUS_PhieuNhap();
        BUS_NhaCungCap busNCC = new BUS_NhaCungCap();
        BUS_NhanVien busNhanVien = new BUS_NhanVien();
        BUS_SanPham busSP = new BUS_SanPham();
        BUS_CTPN busCTPN = new BUS_CTPN();
        public FormQLPhieuNhap()
        {
            InitializeComponent();
        }
        public string HoTenNV
        {
            get
            {
                return _HoTenNV;
            }
            set
            {
                _HoTenNV = value;
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

        public string MaPNCuoi
        {
            get
            {
                return _MaPNCuoi;
            }
            set
            {
                _MaPNCuoi = value;
            }
        }
        private void iconbtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormQLPhieuNhap_Load(object sender, EventArgs e)
        {
            txtNgayLap.Text = DateTime.Today.ToString("dd/MM/yyyy");
            txtHoTenNV.Text = this.HoTenNV;
            txtMaNVLap.Text = busNhanVien.findNhanVien(this.HoTenNV).Rows[0].Field<string>(0);
            cbbTenNCC.DataSource = busNCC.getAllTenNCC();
            cbbTenNCC.DisplayMember = "TenNCC";
            cbbTenNCC.SelectedItem = null;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maphieu = txtMaPhieu.Text;
            string mancc = busNCC.getMaNCC(cbbTenNCC.Text);
            string manvlap = txtMaNVLap.Text;
            DateTime ngaylap = Convert.ToDateTime(txtNgayLap.Text);
            decimal tongtien = Convert.ToDecimal(txtTongTien.Text);
            DTO_PhieuNhap dtoPhieuNhap = new DTO_PhieuNhap(maphieu, mancc, manvlap, ngaylap, tongtien);
            busPhieuNhap.themPhieuNhap(dtoPhieuNhap);
            foreach (DataGridViewRow row in dgvCTPN.Rows)
            {
                string masp = row.Cells[0].Value.ToString();
                decimal giagoc = Convert.ToDecimal(row.Cells[2].Value.ToString());
                int slnhap = Convert.ToInt32(row.Cells[3].Value.ToString());
                decimal thanhtien = Convert.ToDecimal(row.Cells[4].Value.ToString());
                DTO_ChiTietPhieuNhap dtoCTPN = new DTO_ChiTietPhieuNhap(maphieu, masp, giagoc, slnhap, thanhtien);
                busCTPN.themCTPN(dtoCTPN);
            }
            MessageBox.Show("Lập phiếu nhập thành công!");
            btnInPhieu.Enabled = true;
        }

        private void txtMaSP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (busSP.checkMaSP(txtMaSP.Text))
                {
                    txtTenSP.Text = busSP.getThongTinSP(txtMaSP.Text).Rows[0].Field<string>(1);
                    txtLoai.Text = busSP.getThongTinSP(txtMaSP.Text).Rows[0].Field<string>(2);
                    txtChatLieu.Text = busSP.getThongTinSP(txtMaSP.Text).Rows[0].Field<string>(5);
                }
                else
                {
                    MessageBox.Show("Sản phẩm mới!");
                }
            }
        }

        private void txtGiaGoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                txtThanhTien.Text = (Convert.ToDecimal(txtGiaGoc.Text) * Convert.ToInt32(txtSLNhap.Text)).ToString();
            }
        }

        private void btnThemVaoPhieuNhap_Click(object sender, EventArgs e)
        {
            if (txtTenSP.Text != "" && txtSLNhap.Text != "" && txtGiaGoc.Text != "")
            {
                string masp = txtMaSP.Text;
                string tensp = txtTenSP.Text;
                decimal giagoc = Convert.ToDecimal(txtGiaGoc.Text);
                int slnhap = Convert.ToInt32(txtSLNhap.Text);
                decimal thanhtien = Convert.ToDecimal(txtThanhTien.Text);
                string maloai = txtLoai.Text;
                string chatlieu = txtChatLieu.Text;
                if(busSP.checkMaSP(masp) == false)
                {
                    DTO_SanPham dtoSP = new DTO_SanPham(masp, tensp, maloai, 0, 0, chatlieu);
                    busSP.themSP(dtoSP);
                }    
                this.dgvCTPN.Rows.Add(masp, tensp, giagoc, slnhap, thanhtien);
                this.TongTien += thanhtien;
                txtTongTien.Text = this.TongTien.ToString();
                refresh();
            }
            else MessageBox.Show("Vui lòng điền đầy đủ!");
        }
        private void refresh()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtLoai.Text = "";
            txtGiaGoc.Text = "";
            txtSLNhap.Text = "";
            txtChatLieu.Text = "";
            txtThanhTien.Text = "";
        }

        private void txtMaPhieu_Enter(object sender, EventArgs e)
        {
            string sophieucuoi = MaPNCuoi;
            string sophieumoi = (Convert.ToInt32(sophieucuoi.Substring(2)) + 1).ToString();
            if (Convert.ToInt32(sophieumoi) <= 9) txtMaPhieu.Text = "PN0" + sophieumoi;
            else txtMaPhieu.Text = "PN" + sophieumoi;
        }

        private void btnInPhieu_Click(object sender, EventArgs e)
        {
            FormInPhieuNhap formInPhieuNhap = new FormInPhieuNhap(txtMaPhieu.Text, cbbTenNCC.Text);
            formInPhieuNhap.ShowDialog();
        }
    }
}
