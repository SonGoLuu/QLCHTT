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
    public partial class Form1 : Form
    {
        BUS_TaiKhoan busTaiKhoan = new BUS_TaiKhoan();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (cbbNguoiDung.Texts != "" && txtTenTaiKhoan.Texts != "" && txtMatKhau.Texts != "")
            {
                if (busTaiKhoan.checkTaiKhoan(txtTenTaiKhoan.Texts, txtMatKhau.Texts, cbbNguoiDung.Texts) == true)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    FormMainUI m = new FormMainUI();
                    m.TenTaiKhoan = txtTenTaiKhoan.Texts;
                    m.CheDoNguoiDung = cbbNguoiDung.Texts;
                    m.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công!");
                }
            }
            else
            {
                MessageBox.Show("Mời bạn nhập đầy đủ!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
