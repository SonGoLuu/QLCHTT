
namespace QLCHTT
{
    partial class FormDoanhThuTungSanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.THOITRANGDataSet = new QLCHTT.THOITRANGDataSet();
            this.SanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SanPhamTableAdapter = new QLCHTT.THOITRANGDataSetTableAdapters.SanPhamTableAdapter();
            this.ChiTietHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ChiTietHoaDonTableAdapter = new QLCHTT.THOITRANGDataSetTableAdapters.ChiTietHoaDonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.THOITRANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietHoaDonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Top;
            reportDataSource3.Name = "DataSetSanPham";
            reportDataSource3.Value = this.SanPhamBindingSource;
            reportDataSource4.Name = "DataSetCTHD";
            reportDataSource4.Value = this.ChiTietHoaDonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLCHTT.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(858, 490);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnExit.IconColor = System.Drawing.Color.Black;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.Location = new System.Drawing.Point(813, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // THOITRANGDataSet
            // 
            this.THOITRANGDataSet.DataSetName = "THOITRANGDataSet";
            this.THOITRANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SanPhamBindingSource
            // 
            this.SanPhamBindingSource.DataMember = "SanPham";
            this.SanPhamBindingSource.DataSource = this.THOITRANGDataSet;
            // 
            // SanPhamTableAdapter
            // 
            this.SanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // ChiTietHoaDonBindingSource
            // 
            this.ChiTietHoaDonBindingSource.DataMember = "ChiTietHoaDon";
            this.ChiTietHoaDonBindingSource.DataSource = this.THOITRANGDataSet;
            // 
            // ChiTietHoaDonTableAdapter
            // 
            this.ChiTietHoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // FormDoanhThuTungSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 490);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDoanhThuTungSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDoanhThuTungSanPham";
            this.Load += new System.EventHandler(this.FormDoanhThuTungSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.THOITRANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietHoaDonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.BindingSource SanPhamBindingSource;
        private THOITRANGDataSet THOITRANGDataSet;
        private System.Windows.Forms.BindingSource ChiTietHoaDonBindingSource;
        private THOITRANGDataSetTableAdapters.SanPhamTableAdapter SanPhamTableAdapter;
        private THOITRANGDataSetTableAdapters.ChiTietHoaDonTableAdapter ChiTietHoaDonTableAdapter;
    }
}