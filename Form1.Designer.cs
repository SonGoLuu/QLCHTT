
namespace QLCHTT
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelDangnhap = new System.Windows.Forms.Panel();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.pictureBGLOGO = new System.Windows.Forms.PictureBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnDangNhap = new Guna.UI2.WinForms.Guna2Button();
            this.txtMatKhau = new RJCodeAdvance.RJControls.RJTextBox();
            this.txtTenTaiKhoan = new RJCodeAdvance.RJControls.RJTextBox();
            this.cbbNguoiDung = new RJCodeAdvance.RJControls.RJComboBox();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.pictureDangnhap = new System.Windows.Forms.PictureBox();
            this.panelDangnhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBGLOGO)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDangnhap)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDangnhap
            // 
            this.panelDangnhap.BackColor = System.Drawing.Color.Transparent;
            this.panelDangnhap.Controls.Add(this.btnExit);
            this.panelDangnhap.Controls.Add(this.pictureBGLOGO);
            this.panelDangnhap.Controls.Add(this.guna2GroupBox1);
            this.panelDangnhap.Controls.Add(this.pictureDangnhap);
            this.panelDangnhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDangnhap.Location = new System.Drawing.Point(0, 0);
            this.panelDangnhap.Name = "panelDangnhap";
            this.panelDangnhap.Size = new System.Drawing.Size(804, 450);
            this.panelDangnhap.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(31)))), ((int)(((byte)(122)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnExit.IconSize = 35;
            this.btnExit.Location = new System.Drawing.Point(771, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 34);
            this.btnExit.TabIndex = 5;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBGLOGO
            // 
            this.pictureBGLOGO.Image = global::QLCHTT.Properties.Resources.dt2n_store__1_;
            this.pictureBGLOGO.Location = new System.Drawing.Point(313, 0);
            this.pictureBGLOGO.Name = "pictureBGLOGO";
            this.pictureBGLOGO.Size = new System.Drawing.Size(491, 450);
            this.pictureBGLOGO.TabIndex = 4;
            this.pictureBGLOGO.TabStop = false;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.btnDangNhap);
            this.guna2GroupBox1.Controls.Add(this.txtMatKhau);
            this.guna2GroupBox1.Controls.Add(this.txtTenTaiKhoan);
            this.guna2GroupBox1.Controls.Add(this.cbbNguoiDung);
            this.guna2GroupBox1.Controls.Add(this.bunifuLabel3);
            this.guna2GroupBox1.Controls.Add(this.bunifuLabel2);
            this.guna2GroupBox1.Controls.Add(this.bunifuLabel1);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(19)))), ((int)(((byte)(138)))));
            this.guna2GroupBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(36, 119);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(241, 319);
            this.guna2GroupBox1.TabIndex = 3;
            this.guna2GroupBox1.Text = "Đăng nhập tài khoản";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.CheckedState.Parent = this.btnDangNhap;
            this.btnDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangNhap.CustomImages.Parent = this.btnDangNhap;
            this.btnDangNhap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(19)))), ((int)(((byte)(138)))));
            this.btnDangNhap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.HoverState.Parent = this.btnDangNhap;
            this.btnDangNhap.Location = new System.Drawing.Point(27, 269);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.ShadowDecoration.Parent = this.btnDangNhap;
            this.btnDangNhap.Size = new System.Drawing.Size(180, 35);
            this.btnDangNhap.TabIndex = 6;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.SystemColors.Window;
            this.txtMatKhau.BorderColor = System.Drawing.Color.Orchid;
            this.txtMatKhau.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMatKhau.BorderRadius = 0;
            this.txtMatKhau.BorderSize = 2;
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMatKhau.Location = new System.Drawing.Point(18, 220);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatKhau.Multiline = false;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMatKhau.PasswordChar = false;
            this.txtMatKhau.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMatKhau.PlaceholderText = "";
            this.txtMatKhau.Size = new System.Drawing.Size(200, 31);
            this.txtMatKhau.TabIndex = 5;
            this.txtMatKhau.Texts = "";
            this.txtMatKhau.UnderlinedStyle = false;
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.BackColor = System.Drawing.SystemColors.Window;
            this.txtTenTaiKhoan.BorderColor = System.Drawing.Color.Orchid;
            this.txtTenTaiKhoan.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTenTaiKhoan.BorderRadius = 0;
            this.txtTenTaiKhoan.BorderSize = 2;
            this.txtTenTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(18, 145);
            this.txtTenTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenTaiKhoan.Multiline = false;
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTenTaiKhoan.PasswordChar = false;
            this.txtTenTaiKhoan.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTenTaiKhoan.PlaceholderText = "";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(200, 31);
            this.txtTenTaiKhoan.TabIndex = 4;
            this.txtTenTaiKhoan.Texts = "";
            this.txtTenTaiKhoan.UnderlinedStyle = false;
            // 
            // cbbNguoiDung
            // 
            this.cbbNguoiDung.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbbNguoiDung.BorderColor = System.Drawing.Color.Violet;
            this.cbbNguoiDung.BorderSize = 1;
            this.cbbNguoiDung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbbNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbbNguoiDung.ForeColor = System.Drawing.Color.DimGray;
            this.cbbNguoiDung.IconColor = System.Drawing.Color.Fuchsia;
            this.cbbNguoiDung.Items.AddRange(new object[] {
            "Admin",
            "Nhân viên"});
            this.cbbNguoiDung.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbbNguoiDung.ListTextColor = System.Drawing.Color.DimGray;
            this.cbbNguoiDung.Location = new System.Drawing.Point(18, 79);
            this.cbbNguoiDung.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbbNguoiDung.Name = "cbbNguoiDung";
            this.cbbNguoiDung.Padding = new System.Windows.Forms.Padding(1);
            this.cbbNguoiDung.Size = new System.Drawing.Size(200, 30);
            this.cbbNguoiDung.TabIndex = 3;
            this.cbbNguoiDung.Texts = "";
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.bunifuLabel3.ForeColor = System.Drawing.Color.Silver;
            this.bunifuLabel3.Location = new System.Drawing.Point(18, 193);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(61, 20);
            this.bunifuLabel3.TabIndex = 2;
            this.bunifuLabel3.Text = "Mật khẩu";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.bunifuLabel2.ForeColor = System.Drawing.Color.Silver;
            this.bunifuLabel2.Location = new System.Drawing.Point(18, 118);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(89, 20);
            this.bunifuLabel2.TabIndex = 1;
            this.bunifuLabel2.Text = "Tên tài khoản";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.Silver;
            this.bunifuLabel1.Location = new System.Drawing.Point(18, 52);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(80, 20);
            this.bunifuLabel1.TabIndex = 0;
            this.bunifuLabel1.Text = "Người dùng";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pictureDangnhap
            // 
            this.pictureDangnhap.Image = global::QLCHTT.Properties.Resources.vibes;
            this.pictureDangnhap.Location = new System.Drawing.Point(-10, 0);
            this.pictureDangnhap.Name = "pictureDangnhap";
            this.pictureDangnhap.Size = new System.Drawing.Size(360, 110);
            this.pictureDangnhap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureDangnhap.TabIndex = 2;
            this.pictureDangnhap.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(8)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.panelDangnhap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelDangnhap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBGLOGO)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDangnhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelDangnhap;
        private System.Windows.Forms.PictureBox pictureDangnhap;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private RJCodeAdvance.RJControls.RJTextBox txtMatKhau;
        private RJCodeAdvance.RJControls.RJTextBox txtTenTaiKhoan;
        private RJCodeAdvance.RJControls.RJComboBox cbbNguoiDung;
        private System.Windows.Forms.PictureBox pictureBGLOGO;
        private Guna.UI2.WinForms.Guna2Button btnDangNhap;
        private FontAwesome.Sharp.IconButton btnExit;
    }
}

