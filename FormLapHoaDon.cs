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
    public delegate void SendMessage(String value);
    public partial class FormLapHoaDon : Form
    {
        string _HoTenNV;
        string _MaHDCuoi;
        decimal _TongTien = 0;
        string _TenQua;
        BUS_HoaDon busHoaDon = new BUS_HoaDon();
        BUS_KhachHang busKhachHang = new BUS_KhachHang();
        BUS_NhanVien busNhanVien = new BUS_NhanVien();
        BUS_SanPham busSP = new BUS_SanPham();
        BUS_CTHD busCTHD = new BUS_CTHD();
        public FormLapHoaDon()
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

        public string MaHDCuoi
        {
            get
            {
                return _MaHDCuoi;
            }
            set
            {
                _MaHDCuoi = value;
            }
        }
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
        private void iconbtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SetValue(String value)
        {
            this.txtQuaTang.Text = value;
        }
        private void btnVongQuayMayMan_Click(object sender, EventArgs e)
        {
            FormVongQuayMayMan formVongQuayMayMan = new FormVongQuayMayMan(SetValue);
            formVongQuayMayMan.ShowDialog();
        }    
        private void FormLapHoaDon_Load(object sender, EventArgs e)
        {
            txtNgayLap.Text = DateTime.Today.ToString("dd/MM/yyyy");
            txtHoTenNV.Text = this.HoTenNV;
            txtMaNVLap.Text = busNhanVien.findNhanVien(this.HoTenNV).Rows[0].Field<string>(0);
            cbbMaSP.DataSource = busSP.getAllMaSP();
            cbbMaSP.DisplayMember = "MaSP";
            cbbMaSP.SelectedItem = null;
            txtQuaTang.Text = "Không";
        }

        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {
            string mahd = txtMaHD.Text;
            string makh = txtMaKH.Text;
            string manvlap = txtMaNVLap.Text;
            string maqua = busCTHD.getMaQua(txtQuaTang.Text);
            DateTime ngaylap = Convert.ToDateTime(txtNgayLap.Text);
            decimal tongtien = Convert.ToDecimal(txtTongTien.Text);
            DTO_HoaDon dtoHoaDon = new DTO_HoaDon(mahd, makh, manvlap, maqua, ngaylap, tongtien);
            busHoaDon.themHoaDon(dtoHoaDon);
            foreach (DataGridViewRow row in btnInHoaDon.Rows)
            {
                string masp = row.Cells[0].Value.ToString();
                int sl = Convert.ToInt32(row.Cells[3].Value.ToString());
                int khuyenmai = Convert.ToInt32(row.Cells[4].Value.ToString());
                decimal thanhtien = Convert.ToDecimal(row.Cells[6].Value.ToString());
                DTO_ChiTietHoaDon dtoCTHD = new DTO_ChiTietHoaDon(mahd, masp, sl, khuyenmai, thanhtien);
                busCTHD.themCTHD(dtoCTHD);
            }
            MessageBox.Show("Lập hóa đơn thành công!");
            TenQua = txtQuaTang.Text;
            rjButton1.Enabled = true;
        }

        private void txtMaKH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (busKhachHang.checkMaKH(txtMaKH.Text))
                {
                    txtHoTenKH.Text = busKhachHang.getHoTenKhachHang(txtMaKH.Text);
                    txtSDTKH.Text = busKhachHang.getSDTKH(txtMaKH.Text);
                    txtDiaChi.Text = busKhachHang.getDiaChi(txtMaKH.Text);
                    txtKhuyenMai.Text = busKhachHang.getGiamGia(txtMaKH.Text).ToString();
                }
                else
                {
                    MessageBox.Show("Khách hàng mới!");
                }
            }
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text != "" && txtHoTenKH.Text != "" && txtSDTKH.Text != "" && txtDiaChi.Text != "")
            {
                string makh = txtMaKH.Text;
                string mahv = "HV00";
                string hotenkh = txtHoTenKH.Text;
                string sdtkh = txtSDTKH.Text;
                string diachi = txtDiaChi.Text;
                DTO_KhachHang dtoKhachHang = new DTO_KhachHang(makh, mahv, hotenkh, sdtkh, diachi);
                if (busKhachHang.themKhachHang(dtoKhachHang))
                {
                    MessageBox.Show("Thêm khách hàng mới thành công!");
                }
                else MessageBox.Show("Thêm khách hàng mới không thành công!");
            }
            else MessageBox.Show("Vui lòng điền đầy đủ!");
        }

        private void cbbMaSP_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtTenSP.Text = busSP.getThongTinSP(this.cbbMaSP.GetItemText(this.cbbMaSP.SelectedItem)).Rows[0].Field<string>(1);
            txtGiaBan.Text = busSP.getThongTinSP(this.cbbMaSP.GetItemText(this.cbbMaSP.SelectedItem)).Rows[0].Field<decimal>(3).ToString();
            txtChatLieu.Text = busSP.getThongTinSP(this.cbbMaSP.GetItemText(this.cbbMaSP.SelectedItem)).Rows[0].Field<string>(5);
        }

        private void btnThemVaoHoaDon_Click(object sender, EventArgs e)
        {
            if (txtTenSP.Text != "" && txtSLMua.Text != "" && txtKhuyenMai.Text != "")
            {
                string masp = this.cbbMaSP.GetItemText(this.cbbMaSP.SelectedItem);
                string tensp = txtTenSP.Text;
                decimal giaban = Convert.ToDecimal(txtGiaBan.Text);
                int sl = Convert.ToInt32(txtSLMua.Text);
                int khuyenmai = Convert.ToInt32(txtKhuyenMai.Text);
                string chatlieu = txtChatLieu.Text;
                decimal thanhtien = Convert.ToDecimal(txtThanhTien.Text);
                this.btnInHoaDon.Rows.Add(masp, tensp, giaban, sl, khuyenmai, chatlieu, thanhtien);
                this.TongTien += thanhtien;
                txtTongTien.Text = this.TongTien.ToString();
                refresh();
            }
            else MessageBox.Show("Vui lòng điền đầy đủ!");
        }

        private void txtKhuyenMai_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Convert.ToInt32(txtKhuyenMai.Text) != 0)
                {
                    txtThanhTien.Text = (Convert.ToDecimal(txtGiaBan.Text) * Convert.ToInt32(txtSLMua.Text) * (100 - Convert.ToInt32(txtKhuyenMai.Text)) / 100).ToString();
                }
                else
                {
                    txtThanhTien.Text = (Convert.ToDecimal(txtGiaBan.Text) * Convert.ToInt32(txtSLMua.Text)).ToString();
                }
            }
        }
        private void refeshAll()
        {
            txtMaHD.Text = "";
            txtMaKH.Text = "";
            txtHoTenKH.Text = "";
            txtSDTKH.Text = "";
            txtDiaChi.Text = "";
            cbbMaSP.SelectedItem = null;
            txtTenSP.Text = "";
            txtGiaBan.Text = "";
            txtSLMua.Text = "";
            txtChatLieu.Text = "";
            txtKhuyenMai.Text = "";
            txtThanhTien.Text = "";
            txtTongTien.Text = "";
            this.TongTien = 0;
            btnInHoaDon.Rows.Clear();
        }
        private void refresh()
        {
            cbbMaSP.SelectedItem = null;
            txtTenSP.Text = "";
            txtGiaBan.Text = "";
            txtSLMua.Text = "";
            txtChatLieu.Text = "";
            txtKhuyenMai.Text = busKhachHang.getGiamGia(txtMaKH.Text).ToString();
            txtThanhTien.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            refeshAll();
        }

        private void txtMaHD_Enter(object sender, EventArgs e)
        {
            refeshAll();
            string sohdcuoi;
            if (MaHDCuoi != "0") sohdcuoi = MaHDCuoi;
            else sohdcuoi = "HD00";
            string sohdmoi = (Convert.ToInt32(sohdcuoi.Substring(2)) + 1).ToString();
            if (Convert.ToInt32(sohdmoi) <= 9) txtMaHD.Text = "HD0" + sohdmoi;
            else txtMaHD.Text = "HD" + sohdmoi;
        }

        private void checkBoxVQMM_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxVQMM.Checked == true)
            {
                btnVongQuayMayMan.Enabled = true;
            }
            else btnVongQuayMayMan.Enabled = false;
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            FormInHoaDon formInHoaDon = new FormInHoaDon(txtMaHD.Text, txtQuaTang.Text, txtHoTenKH.Text);
            formInHoaDon.ShowDialog();
        }
    }
}
