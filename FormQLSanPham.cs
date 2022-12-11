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
    public partial class FormQLSanPham : UserControl
    {
        BUS_Loai busLoai = new BUS_Loai();
        BUS_SanPham busSP = new BUS_SanPham();
        public FormQLSanPham()
        {
            InitializeComponent();
        }

        private void btnLoai_Click(object sender, EventArgs e)
        {
            FormQLLoai loai = new FormQLLoai();
            loai.ShowDialog();
        }

        private void FormQLSanPham_Load(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = busSP.getAllSP();
            listBoxLoai.DataSource = busLoai.getAllLoai();
            listBoxLoai.DisplayMember = "TenLoai";
        }

        private void dgvSanPham_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvSanPham.SelectedRows[0];
            txtMaSP.Text = row.Cells[0].Value.ToString();
            txtTenSP.Text = row.Cells[1].Value.ToString();
            txtLoai.Text = row.Cells[2].Value.ToString();
            txtGiaBan.Text = row.Cells[3].Value.ToString();
            txtSLTon.Text = row.Cells[4].Value.ToString();
            txtChatLieu.Text = row.Cells[5].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text != "" && txtTenSP.Text != "" && txtLoai.Text != "" && txtGiaBan.Text != "" && txtSLTon.Text != "" && txtChatLieu.Text !="")
            {
                string masp = txtMaSP.Text;
                string tensp = txtTenSP.Text;
                string maloai = txtLoai.Text;
                decimal giaban = Convert.ToDecimal(txtGiaBan.Text);
                int slton = Convert.ToInt32(txtSLTon.Text);
                string chatlieu = txtChatLieu.Text;
                DTO_SanPham dtoSP = new DTO_SanPham(masp, tensp, maloai, giaban, slton, chatlieu);
                if (busSP.themSP(dtoSP))
                {
                    MessageBox.Show("Thêm thành công!");
                    dgvSanPham.DataSource = busSP.getAllSP();
                    refreshAll();
                }
                else MessageBox.Show("Thêm không thành công!");
            }
            else MessageBox.Show("Vui lòng điền đầy đủ!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.SelectedRows.Count > 0)
            {
                if (txtMaSP.Text != "" && txtTenSP.Text != "" && txtLoai.Text != "" && txtGiaBan.Text != "" && txtSLTon.Text != "" && txtChatLieu.Text != "")
                {
                    string masp = txtMaSP.Text;
                    string tensp = txtTenSP.Text;
                    string maloai = txtLoai.Text;
                    decimal giaban = Convert.ToDecimal(txtGiaBan.Text);
                    int slton = Convert.ToInt32(txtSLTon.Text);
                    string chatlieu = txtChatLieu.Text;
                    DTO_SanPham dtoSP = new DTO_SanPham(masp, tensp, maloai, giaban, slton, chatlieu);
                    if (busSP.suaSP(dtoSP))
                    {
                        MessageBox.Show("Sửa thành công!");
                        dgvSanPham.DataSource = busSP.getAllSP();
                        refreshAll();
                    }
                    else MessageBox.Show("Sửa không thành công!");
                }
                else MessageBox.Show("Vui lòng điền đầy đủ!");
            }
            else MessageBox.Show("Vui lòng chọn sản phẩm cần sửa!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.SelectedRows.Count > 0)
            {
                if (txtMaSP.Text != "" && txtTenSP.Text != "" && txtLoai.Text != "" && txtGiaBan.Text != "" && txtSLTon.Text != "" && txtChatLieu.Text != "")
                {
                    string masp = txtMaSP.Text;
                    string tensp = txtTenSP.Text;
                    string maloai = txtLoai.Text;
                    decimal giaban = Convert.ToDecimal(txtGiaBan.Text);
                    int slton = Convert.ToInt32(txtSLTon.Text);
                    string chatlieu = txtChatLieu.Text;
                    DTO_SanPham dtoSP = new DTO_SanPham(masp, tensp, maloai, giaban, slton, chatlieu);
                    if (busSP.xoaSP(dtoSP))
                    {
                        MessageBox.Show("Xóa thành công!");
                        dgvSanPham.DataSource = busSP.getAllSP();
                        refreshAll();
                    }
                    else MessageBox.Show("Xóa không thành công!");
                }
                else MessageBox.Show("Thiếu thông tin cần thiết!");
            }
            else MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!");
        }

        private void btnFindSP_Click(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = busSP.findSP(txtFindSP.Texts);
        }

        private void refreshAll()
        {
            dgvSanPham.DataSource = busSP.getAllSP();
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtLoai.Text = "";
            txtGiaBan.Text = "";
            txtSLTon.Text = "";
            txtChatLieu.Text = "";
        }
        private void txtFindSP__TextChanged(object sender, EventArgs e)
        {
            if (txtFindSP.Texts == "")
            {
                refreshAll();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshAll();
            dgvSanPham.DataSource = busSP.getAllSP();
            listBoxLoai.DataSource = busLoai.getAllLoai();
        }

        private void txtMaSP_Enter(object sender, EventArgs e)
        {
            refreshAll();
            string sospcuoi = dgvSanPham.Rows[dgvSanPham.Rows.Count - 1].Cells[0].Value.ToString();
            string sospmoi = (Convert.ToInt32(sospcuoi.Substring(2)) + 1).ToString();
            if (Convert.ToInt32(sospmoi) <= 9) txtMaSP.Text = "SP0" + sospmoi;
            else txtMaSP.Text = "SP" + sospmoi;
        }
    }
}
