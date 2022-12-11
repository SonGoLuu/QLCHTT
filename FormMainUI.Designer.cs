
namespace QLCHTT
{
    partial class FormMainUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconbtnExit = new FontAwesome.Sharp.IconButton();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconBtnLogout = new FontAwesome.Sharp.IconButton();
            this.iconBtnThongKe = new FontAwesome.Sharp.IconButton();
            this.iconBtnQLPN = new FontAwesome.Sharp.IconButton();
            this.iconBtnQLNCC = new FontAwesome.Sharp.IconButton();
            this.iconBtnQLHD = new FontAwesome.Sharp.IconButton();
            this.iconBtnQLSP = new FontAwesome.Sharp.IconButton();
            this.iconBtnQLKH = new FontAwesome.Sharp.IconButton();
            this.iconBtnQLTK = new FontAwesome.Sharp.IconButton();
            this.iconBtnQLNV = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelHome = new System.Windows.Forms.Panel();
            this.pictureBoxHome = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.iconbtnExit);
            this.panel1.Controls.Add(this.lblNhanVien);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1074, 34);
            this.panel1.TabIndex = 0;
            // 
            // iconbtnExit
            // 
            this.iconbtnExit.BackColor = System.Drawing.Color.White;
            this.iconbtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconbtnExit.FlatAppearance.BorderSize = 0;
            this.iconbtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnExit.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconbtnExit.IconColor = System.Drawing.Color.Black;
            this.iconbtnExit.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconbtnExit.IconSize = 35;
            this.iconbtnExit.Location = new System.Drawing.Point(1037, 4);
            this.iconbtnExit.Name = "iconbtnExit";
            this.iconbtnExit.Size = new System.Drawing.Size(30, 29);
            this.iconbtnExit.TabIndex = 8;
            this.iconbtnExit.UseVisualStyleBackColor = false;
            this.iconbtnExit.Click += new System.EventHandler(this.iconbtnExit_Click);
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.BackColor = System.Drawing.Color.White;
            this.lblNhanVien.Font = new System.Drawing.Font("Be Vietnam Pro", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhanVien.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNhanVien.Location = new System.Drawing.Point(12, 5);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(246, 23);
            this.lblNhanVien.TabIndex = 7;
            this.lblNhanVien.Text = "Admin: Trần Huỳnh Lưu";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));
            this.panel3.Controls.Add(this.panelMenu);
            this.panel3.Controls.Add(this.panelLogo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(217, 537);
            this.panel3.TabIndex = 2;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.panelMenu.Controls.Add(this.iconBtnLogout);
            this.panelMenu.Controls.Add(this.iconBtnThongKe);
            this.panelMenu.Controls.Add(this.iconBtnQLPN);
            this.panelMenu.Controls.Add(this.iconBtnQLNCC);
            this.panelMenu.Controls.Add(this.iconBtnQLHD);
            this.panelMenu.Controls.Add(this.iconBtnQLSP);
            this.panelMenu.Controls.Add(this.iconBtnQLKH);
            this.panelMenu.Controls.Add(this.iconBtnQLTK);
            this.panelMenu.Controls.Add(this.iconBtnQLNV);
            this.panelMenu.Location = new System.Drawing.Point(0, 89);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(217, 448);
            this.panelMenu.TabIndex = 1;
            // 
            // iconBtnLogout
            // 
            this.iconBtnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBtnLogout.FlatAppearance.BorderSize = 0;
            this.iconBtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnLogout.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.iconBtnLogout.IconColor = System.Drawing.Color.White;
            this.iconBtnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnLogout.IconSize = 40;
            this.iconBtnLogout.Location = new System.Drawing.Point(174, 403);
            this.iconBtnLogout.Name = "iconBtnLogout";
            this.iconBtnLogout.Size = new System.Drawing.Size(40, 34);
            this.iconBtnLogout.TabIndex = 1;
            this.iconBtnLogout.UseVisualStyleBackColor = true;
            this.iconBtnLogout.Click += new System.EventHandler(this.iconBtnLogout_Click);
            // 
            // iconBtnThongKe
            // 
            this.iconBtnThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBtnThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnThongKe.FlatAppearance.BorderSize = 0;
            this.iconBtnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnThongKe.Font = new System.Drawing.Font("Segoe UI Black", 9.5F, System.Drawing.FontStyle.Bold);
            this.iconBtnThongKe.ForeColor = System.Drawing.Color.White;
            this.iconBtnThongKe.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.iconBtnThongKe.IconColor = System.Drawing.Color.White;
            this.iconBtnThongKe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnThongKe.IconSize = 40;
            this.iconBtnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnThongKe.Location = new System.Drawing.Point(0, 343);
            this.iconBtnThongKe.Name = "iconBtnThongKe";
            this.iconBtnThongKe.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.iconBtnThongKe.Size = new System.Drawing.Size(217, 49);
            this.iconBtnThongKe.TabIndex = 0;
            this.iconBtnThongKe.Text = "  Thống Kê, Báo Cáo";
            this.iconBtnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnThongKe.UseVisualStyleBackColor = true;
            this.iconBtnThongKe.Click += new System.EventHandler(this.iconBtnThongKe_Click);
            // 
            // iconBtnQLPN
            // 
            this.iconBtnQLPN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBtnQLPN.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnQLPN.FlatAppearance.BorderSize = 0;
            this.iconBtnQLPN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnQLPN.Font = new System.Drawing.Font("Segoe UI Black", 9.5F, System.Drawing.FontStyle.Bold);
            this.iconBtnQLPN.ForeColor = System.Drawing.Color.White;
            this.iconBtnQLPN.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            this.iconBtnQLPN.IconColor = System.Drawing.Color.White;
            this.iconBtnQLPN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnQLPN.IconSize = 40;
            this.iconBtnQLPN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnQLPN.Location = new System.Drawing.Point(0, 294);
            this.iconBtnQLPN.Name = "iconBtnQLPN";
            this.iconBtnQLPN.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.iconBtnQLPN.Size = new System.Drawing.Size(217, 49);
            this.iconBtnQLPN.TabIndex = 0;
            this.iconBtnQLPN.Text = "  Quản Lý Phiếu Nhập";
            this.iconBtnQLPN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnQLPN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnQLPN.UseVisualStyleBackColor = true;
            this.iconBtnQLPN.Click += new System.EventHandler(this.iconBtnQLPN_Click);
            // 
            // iconBtnQLNCC
            // 
            this.iconBtnQLNCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBtnQLNCC.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnQLNCC.FlatAppearance.BorderSize = 0;
            this.iconBtnQLNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnQLNCC.Font = new System.Drawing.Font("Segoe UI Black", 9.5F, System.Drawing.FontStyle.Bold);
            this.iconBtnQLNCC.ForeColor = System.Drawing.Color.White;
            this.iconBtnQLNCC.IconChar = FontAwesome.Sharp.IconChar.ShippingFast;
            this.iconBtnQLNCC.IconColor = System.Drawing.Color.White;
            this.iconBtnQLNCC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnQLNCC.IconSize = 40;
            this.iconBtnQLNCC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnQLNCC.Location = new System.Drawing.Point(0, 245);
            this.iconBtnQLNCC.Name = "iconBtnQLNCC";
            this.iconBtnQLNCC.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.iconBtnQLNCC.Size = new System.Drawing.Size(217, 49);
            this.iconBtnQLNCC.TabIndex = 0;
            this.iconBtnQLNCC.Text = "  Quản Lý Nhà Cung Cấp";
            this.iconBtnQLNCC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnQLNCC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnQLNCC.UseVisualStyleBackColor = true;
            this.iconBtnQLNCC.Click += new System.EventHandler(this.iconBtnQLNCC_Click);
            // 
            // iconBtnQLHD
            // 
            this.iconBtnQLHD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBtnQLHD.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnQLHD.FlatAppearance.BorderSize = 0;
            this.iconBtnQLHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnQLHD.Font = new System.Drawing.Font("Segoe UI Black", 9.5F, System.Drawing.FontStyle.Bold);
            this.iconBtnQLHD.ForeColor = System.Drawing.Color.White;
            this.iconBtnQLHD.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.iconBtnQLHD.IconColor = System.Drawing.Color.White;
            this.iconBtnQLHD.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnQLHD.IconSize = 40;
            this.iconBtnQLHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnQLHD.Location = new System.Drawing.Point(0, 196);
            this.iconBtnQLHD.Name = "iconBtnQLHD";
            this.iconBtnQLHD.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.iconBtnQLHD.Size = new System.Drawing.Size(217, 49);
            this.iconBtnQLHD.TabIndex = 0;
            this.iconBtnQLHD.Text = "  Quản Lý Hóa Đơn";
            this.iconBtnQLHD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnQLHD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnQLHD.UseVisualStyleBackColor = true;
            this.iconBtnQLHD.Click += new System.EventHandler(this.iconBtnQLHD_Click);
            // 
            // iconBtnQLSP
            // 
            this.iconBtnQLSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBtnQLSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnQLSP.FlatAppearance.BorderSize = 0;
            this.iconBtnQLSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnQLSP.Font = new System.Drawing.Font("Segoe UI Black", 9.5F, System.Drawing.FontStyle.Bold);
            this.iconBtnQLSP.ForeColor = System.Drawing.Color.White;
            this.iconBtnQLSP.IconChar = FontAwesome.Sharp.IconChar.Vest;
            this.iconBtnQLSP.IconColor = System.Drawing.Color.White;
            this.iconBtnQLSP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnQLSP.IconSize = 40;
            this.iconBtnQLSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnQLSP.Location = new System.Drawing.Point(0, 147);
            this.iconBtnQLSP.Name = "iconBtnQLSP";
            this.iconBtnQLSP.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.iconBtnQLSP.Size = new System.Drawing.Size(217, 49);
            this.iconBtnQLSP.TabIndex = 0;
            this.iconBtnQLSP.Text = "  Quản Lý Sản Phẩm";
            this.iconBtnQLSP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnQLSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnQLSP.UseVisualStyleBackColor = true;
            this.iconBtnQLSP.Click += new System.EventHandler(this.iconBtnQLSP_Click);
            // 
            // iconBtnQLKH
            // 
            this.iconBtnQLKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBtnQLKH.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnQLKH.FlatAppearance.BorderSize = 0;
            this.iconBtnQLKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnQLKH.Font = new System.Drawing.Font("Segoe UI Black", 9.5F, System.Drawing.FontStyle.Bold);
            this.iconBtnQLKH.ForeColor = System.Drawing.Color.White;
            this.iconBtnQLKH.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconBtnQLKH.IconColor = System.Drawing.Color.White;
            this.iconBtnQLKH.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnQLKH.IconSize = 40;
            this.iconBtnQLKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnQLKH.Location = new System.Drawing.Point(0, 98);
            this.iconBtnQLKH.Name = "iconBtnQLKH";
            this.iconBtnQLKH.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.iconBtnQLKH.Size = new System.Drawing.Size(217, 49);
            this.iconBtnQLKH.TabIndex = 0;
            this.iconBtnQLKH.Text = "  Quản Lý Khách Hàng";
            this.iconBtnQLKH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnQLKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnQLKH.UseVisualStyleBackColor = true;
            this.iconBtnQLKH.Click += new System.EventHandler(this.iconBtnQLKH_Click);
            // 
            // iconBtnQLTK
            // 
            this.iconBtnQLTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.iconBtnQLTK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBtnQLTK.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnQLTK.FlatAppearance.BorderSize = 0;
            this.iconBtnQLTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnQLTK.Font = new System.Drawing.Font("Segoe UI Black", 9.5F, System.Drawing.FontStyle.Bold);
            this.iconBtnQLTK.ForeColor = System.Drawing.Color.White;
            this.iconBtnQLTK.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.iconBtnQLTK.IconColor = System.Drawing.Color.White;
            this.iconBtnQLTK.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnQLTK.IconSize = 40;
            this.iconBtnQLTK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnQLTK.Location = new System.Drawing.Point(0, 49);
            this.iconBtnQLTK.Name = "iconBtnQLTK";
            this.iconBtnQLTK.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.iconBtnQLTK.Size = new System.Drawing.Size(217, 49);
            this.iconBtnQLTK.TabIndex = 0;
            this.iconBtnQLTK.Text = "  Quản Lý Tài Khoản";
            this.iconBtnQLTK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnQLTK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnQLTK.UseVisualStyleBackColor = false;
            this.iconBtnQLTK.Click += new System.EventHandler(this.iconBtnQLTK_Click);
            // 
            // iconBtnQLNV
            // 
            this.iconBtnQLNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBtnQLNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnQLNV.FlatAppearance.BorderSize = 0;
            this.iconBtnQLNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnQLNV.Font = new System.Drawing.Font("Segoe UI Black", 9.5F, System.Drawing.FontStyle.Bold);
            this.iconBtnQLNV.ForeColor = System.Drawing.Color.White;
            this.iconBtnQLNV.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.iconBtnQLNV.IconColor = System.Drawing.Color.White;
            this.iconBtnQLNV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnQLNV.IconSize = 40;
            this.iconBtnQLNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnQLNV.Location = new System.Drawing.Point(0, 0);
            this.iconBtnQLNV.Name = "iconBtnQLNV";
            this.iconBtnQLNV.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.iconBtnQLNV.Size = new System.Drawing.Size(217, 49);
            this.iconBtnQLNV.TabIndex = 0;
            this.iconBtnQLNV.Text = "  Quản Lý Nhân Viên";
            this.iconBtnQLNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnQLNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnQLNV.UseVisualStyleBackColor = true;
            this.iconBtnQLNV.Click += new System.EventHandler(this.iconBtnQLNV_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.panelLogo.Controls.Add(this.pictureBoxLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(217, 91);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.pictureBoxLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLogo.Image = global::QLCHTT.Properties.Resources.in__1_;
            this.pictureBoxLogo.Location = new System.Drawing.Point(50, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(114, 91);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click);
            // 
            // panelHome
            // 
            this.panelHome.Controls.Add(this.pictureBoxHome);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHome.Location = new System.Drawing.Point(217, 34);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(857, 537);
            this.panelHome.TabIndex = 4;
            // 
            // pictureBoxHome
            // 
            this.pictureBoxHome.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHome.Image")));
            this.pictureBoxHome.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxHome.Name = "pictureBoxHome";
            this.pictureBoxHome.Size = new System.Drawing.Size(857, 537);
            this.pictureBoxHome.TabIndex = 2;
            this.pictureBoxHome.TabStop = false;
            // 
            // FormMainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1074, 571);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMainUI";
            this.Load += new System.EventHandler(this.FormMainUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconBtnLogout;
        private FontAwesome.Sharp.IconButton iconBtnThongKe;
        private FontAwesome.Sharp.IconButton iconBtnQLPN;
        private FontAwesome.Sharp.IconButton iconBtnQLNCC;
        private FontAwesome.Sharp.IconButton iconBtnQLHD;
        private FontAwesome.Sharp.IconButton iconBtnQLSP;
        private FontAwesome.Sharp.IconButton iconBtnQLKH;
        private FontAwesome.Sharp.IconButton iconBtnQLTK;
        private FontAwesome.Sharp.IconButton iconBtnQLNV;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private FontAwesome.Sharp.IconButton iconbtnExit;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.PictureBox pictureBoxHome;
    }
}