
namespace QLCHTT
{
    partial class FormInHoaDon
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
            this.ChiTietHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.THOITRANGDataSet = new QLCHTT.THOITRANGDataSet();
            this.SanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ChiTietHoaDonTableAdapter = new QLCHTT.THOITRANGDataSetTableAdapters.ChiTietHoaDonTableAdapter();
            this.SanPhamTableAdapter = new QLCHTT.THOITRANGDataSetTableAdapters.SanPhamTableAdapter();
            this.HoaDonTableAdapter = new QLCHTT.THOITRANGDataSetTableAdapters.HoaDonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietHoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.THOITRANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ChiTietHoaDonBindingSource
            // 
            this.ChiTietHoaDonBindingSource.DataMember = "ChiTietHoaDon";
            this.ChiTietHoaDonBindingSource.DataSource = this.THOITRANGDataSet;
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
            // HoaDonBindingSource
            // 
            this.HoaDonBindingSource.DataMember = "HoaDon";
            this.HoaDonBindingSource.DataSource = this.THOITRANGDataSet;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetInHoaDon";
            reportDataSource1.Value = this.ChiTietHoaDonBindingSource;
            reportDataSource2.Name = "DataSetSanPham";
            reportDataSource2.Value = this.SanPhamBindingSource;
            reportDataSource3.Name = "DataSetHoaDon";
            reportDataSource3.Value = this.HoaDonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLCHTT.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, -1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(550, 425);
            this.reportViewer1.TabIndex = 0;
            // 
            // ChiTietHoaDonTableAdapter
            // 
            this.ChiTietHoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // SanPhamTableAdapter
            // 
            this.SanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // HoaDonTableAdapter
            // 
            this.HoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // FormInHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 424);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormInHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In hóa đơn";
            this.Load += new System.EventHandler(this.FormInHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietHoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.THOITRANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ChiTietHoaDonBindingSource;
        private THOITRANGDataSet THOITRANGDataSet;
        private System.Windows.Forms.BindingSource SanPhamBindingSource;
        private System.Windows.Forms.BindingSource HoaDonBindingSource;
        private THOITRANGDataSetTableAdapters.ChiTietHoaDonTableAdapter ChiTietHoaDonTableAdapter;
        private THOITRANGDataSetTableAdapters.SanPhamTableAdapter SanPhamTableAdapter;
        private THOITRANGDataSetTableAdapters.HoaDonTableAdapter HoaDonTableAdapter;
    }
}