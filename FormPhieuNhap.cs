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
    public partial class FormPhieuNhap : UserControl
    {
        string _HoTenNV;
        BUS_PhieuNhap busPhieuNhap = new BUS_PhieuNhap();
        public FormPhieuNhap()
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
        private void btnLapPhieuNhap_Click(object sender, EventArgs e)
        {
            FormQLPhieuNhap formQLPhieuNhap = new FormQLPhieuNhap();
            if (dgvPhieuNhap.Rows.Count == 0) formQLPhieuNhap.MaPNCuoi = "PN00";
            else formQLPhieuNhap.MaPNCuoi = dgvPhieuNhap.Rows[dgvPhieuNhap.Rows.Count - 1].Cells[0].Value.ToString();
            formQLPhieuNhap.HoTenNV = this.HoTenNV;
            formQLPhieuNhap.ShowDialog();
        }

        private void FormPhieuNhap_Load(object sender, EventArgs e)
        {
            dgvPhieuNhap.DataSource = busPhieuNhap.getAllPhieuNhap();
        }

        private void dgvPhieuNhap_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormChiTietPhieuNhap formCTPN = new FormChiTietPhieuNhap();
            formCTPN.MaPN = dgvPhieuNhap.SelectedRows[0].Cells[0].Value.ToString();
            formCTPN.ShowDialog();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgvPhieuNhap.DataSource = busPhieuNhap.getPhieuNhap(txtFind.Texts);
        }

        private void txtFind__TextChanged(object sender, EventArgs e)
        {
            if (txtFind.Texts == "")
            {
                dgvPhieuNhap.DataSource = busPhieuNhap.getAllPhieuNhap();
            }
        }
    }
}
