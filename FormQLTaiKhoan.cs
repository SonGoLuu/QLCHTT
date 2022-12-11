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
    public partial class FormQLTaiKhoan : UserControl
    {
        BUS_TaiKhoan busTaiKhoan = new BUS_TaiKhoan();
        public FormQLTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            FormTaomoitaikhoan taomoitk = new FormTaomoitaikhoan();
            taomoitk.ShowDialog();
        }

        private void btnSuaTK_Click(object sender, EventArgs e)
        {
            FormSuataikhoan suatk = new FormSuataikhoan();
            suatk.ShowDialog();
        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            FormXoataikhoan xoatk = new FormXoataikhoan();
            xoatk.ShowDialog();
        }

        private void dgvTaiKhoan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.Value != null)
            {
                e.Value = new string('*', e.Value.ToString().Length);
            }
        }

        private void FormQLTaiKhoan_Load(object sender, EventArgs e)
        {
            dgvTaiKhoan.DataSource = busTaiKhoan.getAllTaiKhoan();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvTaiKhoan.DataSource = busTaiKhoan.getAllTaiKhoan();
            txtFindTK.Texts = "";
        }

        private void btnFindTK_Click(object sender, EventArgs e)
        {
            dgvTaiKhoan.DataSource = busTaiKhoan.findTaiKhoan(txtFindTK.Texts);
        }
    }
}
