
namespace QLCHTT
{
    partial class FormInPhieuNhap
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ChiTietPhieuNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.THOITRANGDataSet = new QLCHTT.THOITRANGDataSet();
            this.SanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DTO_NhaCungCapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ChiTietPhieuNhapTableAdapter = new QLCHTT.THOITRANGDataSetTableAdapters.ChiTietPhieuNhapTableAdapter();
            this.SanPhamTableAdapter = new QLCHTT.THOITRANGDataSetTableAdapters.SanPhamTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietPhieuNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.THOITRANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTO_NhaCungCapBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ChiTietPhieuNhapBindingSource
            // 
            this.ChiTietPhieuNhapBindingSource.DataMember = "ChiTietPhieuNhap";
            this.ChiTietPhieuNhapBindingSource.DataSource = this.THOITRANGDataSet;
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
            // DTO_NhaCungCapBindingSource
            // 
            this.DTO_NhaCungCapBindingSource.DataSource = typeof(DTO_QuanLy.DTO_NhaCungCap);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetInPhieuNhap";
            reportDataSource1.Value = this.ChiTietPhieuNhapBindingSource;
            reportDataSource2.Name = "DataSetSanPham";
            reportDataSource2.Value = this.SanPhamBindingSource;
            reportDataSource3.Name = "DataSetNCC";
            reportDataSource3.Value = this.DTO_NhaCungCapBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLCHTT.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-2, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(537, 425);
            this.reportViewer1.TabIndex = 0;
            // 
            // ChiTietPhieuNhapTableAdapter
            // 
            this.ChiTietPhieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // SanPhamTableAdapter
            // 
            this.SanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // FormInPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 424);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormInPhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInPhieuNhap";
            this.Load += new System.EventHandler(this.FormInPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietPhieuNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.THOITRANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTO_NhaCungCapBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ChiTietPhieuNhapBindingSource;
        private THOITRANGDataSet THOITRANGDataSet;
        private System.Windows.Forms.BindingSource SanPhamBindingSource;
        private System.Windows.Forms.BindingSource DTO_NhaCungCapBindingSource;
        private THOITRANGDataSetTableAdapters.ChiTietPhieuNhapTableAdapter ChiTietPhieuNhapTableAdapter;
        private THOITRANGDataSetTableAdapters.SanPhamTableAdapter SanPhamTableAdapter;
    }
}