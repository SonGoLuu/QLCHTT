using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QuanLy;
using BUS_QuanLy;

namespace QLCHTT
{
    public partial class FormMainUI : Form
    {
        string _TenTaiKhoan;
        string _CheDoNguoiDung;
        BUS_TaiKhoan busTaiKhoan = new BUS_TaiKhoan();
        BUS_NhanVien busNhanVien = new BUS_NhanVien();
        public FormMainUI()
        {
            InitializeComponent();
        }

        public string TenTaiKhoan
        {
            get
            {
                return _TenTaiKhoan;
            }
            set
            {
                _TenTaiKhoan = value;
            }
        }

        public string CheDoNguoiDung
        {
            get
            {
                return _CheDoNguoiDung;
            }
            set
            {
                _CheDoNguoiDung = value;
            }
        }

        private void FormMainUI_Load(object sender, EventArgs e)
        {
            lblNhanVien.Text = CheDoNguoiDung + ": " + busNhanVien.getHoTenNhanVien(busTaiKhoan.getMaNVTaiKhoan(TenTaiKhoan));
            if (CheDoNguoiDung != "Admin")
            {
                iconBtnQLTK.Cursor = Cursors.No;
                iconBtnQLNV.Cursor = Cursors.No;
            }
            addFormPanelHome();
            lockVisiblePanelHome();
            panelHome.Controls[0].Visible = true;
        }
        private void addFormPanelHome()
        {
            FormQLNhanVien qlnv = new FormQLNhanVien();
            FormQLTaiKhoan qltk = new FormQLTaiKhoan();
            FormQLKhachHang qlkh = new FormQLKhachHang();
            FormQLSanPham qlsp = new FormQLSanPham();
            FormQLHoaDon qlhd = new FormQLHoaDon();
            qlhd.HoTenNV = busNhanVien.getHoTenNhanVien(busTaiKhoan.getMaNVTaiKhoan(TenTaiKhoan));
            FormQLNhaCungCap qlncc = new FormQLNhaCungCap();
            FormPhieuNhap pn = new FormPhieuNhap();
            pn.HoTenNV = busNhanVien.getHoTenNhanVien(busTaiKhoan.getMaNVTaiKhoan(TenTaiKhoan));
            FormThongKe tk = new FormThongKe();
            panelHome.Controls.Add(qlnv);
            panelHome.Controls.Add(qltk);
            panelHome.Controls.Add(qlkh);
            panelHome.Controls.Add(qlsp);
            panelHome.Controls.Add(qlhd);
            panelHome.Controls.Add(qlncc);
            panelHome.Controls.Add(pn);
            panelHome.Controls.Add(tk);
        }
        private void lockVisiblePanelHome()
        {
            panelHome.Controls[0].Visible = false;
            panelHome.Controls[1].Visible = false;
            panelHome.Controls[2].Visible = false;
            panelHome.Controls[3].Visible = false;
            panelHome.Controls[4].Visible = false;
            panelHome.Controls[5].Visible = false;
            panelHome.Controls[6].Visible = false;
            panelHome.Controls[7].Visible = false;
            panelHome.Controls[8].Visible = false;
        }

        private void changeColorAll()
        {
            iconBtnQLNV.BackColor = Color.FromArgb(29, 29, 66);
            iconBtnQLTK.BackColor = Color.FromArgb(29, 29, 66);
            iconBtnQLKH.BackColor = Color.FromArgb(29, 29, 66);
            iconBtnQLSP.BackColor = Color.FromArgb(29, 29, 66);
            iconBtnQLHD.BackColor = Color.FromArgb(29, 29, 66);
            iconBtnQLNCC.BackColor = Color.FromArgb(29, 29, 66);
            iconBtnQLPN.BackColor = Color.FromArgb(29, 29, 66);
            iconBtnThongKe.BackColor = Color.FromArgb(29, 29, 66);
        }    
        private void iconbtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconBtnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            lockVisiblePanelHome();
            panelHome.Controls[0].Visible = true;
            changeColorAll();
        }

        //Nút quản lý nhân viên
        private void iconBtnQLNV_Click(object sender, EventArgs e)
        {
            if (CheDoNguoiDung == "Admin")
            {
                lockVisiblePanelHome();
                panelHome.Controls[1].Visible = true;
                changeColorAll();
                iconBtnQLNV.BackColor = Color.FromArgb(220, 20, 60);
            }                 
        }

        //Nút quản lý tài khoản
        private void iconBtnQLTK_Click(object sender, EventArgs e)
        {
            if (CheDoNguoiDung == "Admin")
            {
                lockVisiblePanelHome();
                panelHome.Controls[2].Visible = true;
                changeColorAll();
                iconBtnQLTK.BackColor = Color.FromArgb(220, 20, 60);
            }
        }

        private void iconBtnQLKH_Click(object sender, EventArgs e)
        {
            lockVisiblePanelHome();
            panelHome.Controls[3].Visible = true;
            changeColorAll();
            iconBtnQLKH.BackColor = Color.FromArgb(220, 20, 60);
        }

        private void iconBtnQLSP_Click(object sender, EventArgs e)
        {
            lockVisiblePanelHome();
            panelHome.Controls[4].Visible = true;
            changeColorAll();
            iconBtnQLSP.BackColor = Color.FromArgb(220, 20, 60);
        }

        private void iconBtnQLHD_Click(object sender, EventArgs e)
        {
            lockVisiblePanelHome();
            panelHome.Controls[5].Visible = true;
            changeColorAll();
            iconBtnQLHD.BackColor = Color.FromArgb(220, 20, 60);
        }

        private void iconBtnQLNCC_Click(object sender, EventArgs e)
        {
            lockVisiblePanelHome();
            panelHome.Controls[6].Visible = true;
            changeColorAll();
            iconBtnQLNCC.BackColor = Color.FromArgb(220, 20, 60);
        }

        private void iconBtnQLPN_Click(object sender, EventArgs e)
        {
            lockVisiblePanelHome();
            panelHome.Controls[7].Visible = true;
            changeColorAll();
            iconBtnQLPN.BackColor = Color.FromArgb(220, 20, 60);
        }

        private void iconBtnThongKe_Click(object sender, EventArgs e)
        {
            lockVisiblePanelHome();
            panelHome.Controls[8].Visible = true;
            changeColorAll();
            iconBtnThongKe.BackColor = Color.FromArgb(220, 20, 60);
        }
    }
}
