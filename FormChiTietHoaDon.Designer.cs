
namespace QLCHTT
{
    partial class FormChiTietHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChiTietHoaDon));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconbtnExit = new FontAwesome.Sharp.IconButton();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.dgvCTHD = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTongTien = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtHoTenNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaNVLap = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNgayLap = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSDTKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaHD = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.iconbtnExit);
            this.panel1.Controls.Add(this.bunifuLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 48);
            this.panel1.TabIndex = 31;
            // 
            // iconbtnExit
            // 
            this.iconbtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconbtnExit.FlatAppearance.BorderSize = 0;
            this.iconbtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnExit.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconbtnExit.IconColor = System.Drawing.Color.White;
            this.iconbtnExit.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconbtnExit.IconSize = 35;
            this.iconbtnExit.Location = new System.Drawing.Point(681, 0);
            this.iconbtnExit.Name = "iconbtnExit";
            this.iconbtnExit.Size = new System.Drawing.Size(38, 48);
            this.iconbtnExit.TabIndex = 30;
            this.iconbtnExit.UseVisualStyleBackColor = true;
            this.iconbtnExit.Click += new System.EventHandler(this.iconbtnExit_Click);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Be Vietnam Pro Black", 14F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.bunifuLabel1.Location = new System.Drawing.Point(273, 9);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(181, 29);
            this.bunifuLabel1.TabIndex = 0;
            this.bunifuLabel1.Text = "CHI TIẾT HÓA ĐƠN";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dgvCTHD
            // 
            this.dgvCTHD.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dgvCTHD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCTHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvCTHD.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCTHD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCTHD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCTHD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCTHD.ColumnHeadersHeight = 35;
            this.dgvCTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6});
            this.dgvCTHD.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCTHD.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCTHD.EnableHeadersVisualStyles = false;
            this.dgvCTHD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dgvCTHD.Location = new System.Drawing.Point(35, 145);
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.ReadOnly = true;
            this.dgvCTHD.RowHeadersVisible = false;
            this.dgvCTHD.RowTemplate.Height = 40;
            this.dgvCTHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTHD.Size = new System.Drawing.Size(653, 196);
            this.dgvCTHD.TabIndex = 32;
            this.dgvCTHD.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.dgvCTHD.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dgvCTHD.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCTHD.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCTHD.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCTHD.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCTHD.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCTHD.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dgvCTHD.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dgvCTHD.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCTHD.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvCTHD.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCTHD.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCTHD.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvCTHD.ThemeStyle.ReadOnly = true;
            this.dgvCTHD.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dgvCTHD.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCTHD.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvCTHD.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvCTHD.ThemeStyle.RowsStyle.Height = 40;
            this.dgvCTHD.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.dgvCTHD.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Tổng thành tiền";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtTongTien);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(243, 347);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(237, 32);
            this.panel3.TabIndex = 34;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTongTien.DefaultText = "";
            this.txtTongTien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTongTien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTongTien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTongTien.DisabledState.Parent = this.txtTongTien;
            this.txtTongTien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTongTien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTongTien.FocusedState.Parent = this.txtTongTien;
            this.txtTongTien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTongTien.HoverState.Parent = this.txtTongTien;
            this.txtTongTien.Location = new System.Drawing.Point(104, 4);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.PasswordChar = '\0';
            this.txtTongTien.PlaceholderText = "";
            this.txtTongTien.SelectedText = "";
            this.txtTongTien.ShadowDecoration.Parent = this.txtTongTien;
            this.txtTongTien.Size = new System.Drawing.Size(122, 24);
            this.txtTongTien.TabIndex = 41;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtHoTenNV);
            this.panel2.Controls.Add(this.txtMaNVLap);
            this.panel2.Controls.Add(this.txtNgayLap);
            this.panel2.Controls.Add(this.txtSDTKH);
            this.panel2.Controls.Add(this.txtMaHD);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(719, 89);
            this.panel2.TabIndex = 35;
            // 
            // txtHoTenNV
            // 
            this.txtHoTenNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoTenNV.DefaultText = "";
            this.txtHoTenNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHoTenNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHoTenNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoTenNV.DisabledState.Parent = this.txtHoTenNV;
            this.txtHoTenNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoTenNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoTenNV.FocusedState.Parent = this.txtHoTenNV;
            this.txtHoTenNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoTenNV.HoverState.Parent = this.txtHoTenNV;
            this.txtHoTenNV.Location = new System.Drawing.Point(411, 54);
            this.txtHoTenNV.Name = "txtHoTenNV";
            this.txtHoTenNV.PasswordChar = '\0';
            this.txtHoTenNV.PlaceholderText = "";
            this.txtHoTenNV.SelectedText = "";
            this.txtHoTenNV.ShadowDecoration.Parent = this.txtHoTenNV;
            this.txtHoTenNV.Size = new System.Drawing.Size(165, 24);
            this.txtHoTenNV.TabIndex = 40;
            // 
            // txtMaNVLap
            // 
            this.txtMaNVLap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNVLap.DefaultText = "";
            this.txtMaNVLap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaNVLap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaNVLap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNVLap.DisabledState.Parent = this.txtMaNVLap;
            this.txtMaNVLap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNVLap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNVLap.FocusedState.Parent = this.txtMaNVLap;
            this.txtMaNVLap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNVLap.HoverState.Parent = this.txtMaNVLap;
            this.txtMaNVLap.Location = new System.Drawing.Point(213, 54);
            this.txtMaNVLap.Name = "txtMaNVLap";
            this.txtMaNVLap.PasswordChar = '\0';
            this.txtMaNVLap.PlaceholderText = "";
            this.txtMaNVLap.SelectedText = "";
            this.txtMaNVLap.ShadowDecoration.Parent = this.txtMaNVLap;
            this.txtMaNVLap.Size = new System.Drawing.Size(98, 24);
            this.txtMaNVLap.TabIndex = 39;
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNgayLap.DefaultText = "";
            this.txtNgayLap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNgayLap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNgayLap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNgayLap.DisabledState.Parent = this.txtNgayLap;
            this.txtNgayLap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNgayLap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNgayLap.FocusedState.Parent = this.txtNgayLap;
            this.txtNgayLap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNgayLap.HoverState.Parent = this.txtNgayLap;
            this.txtNgayLap.Location = new System.Drawing.Point(539, 11);
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.PasswordChar = '\0';
            this.txtNgayLap.PlaceholderText = "";
            this.txtNgayLap.SelectedText = "";
            this.txtNgayLap.ShadowDecoration.Parent = this.txtNgayLap;
            this.txtNgayLap.Size = new System.Drawing.Size(122, 24);
            this.txtNgayLap.TabIndex = 38;
            // 
            // txtSDTKH
            // 
            this.txtSDTKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDTKH.DefaultText = "";
            this.txtSDTKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSDTKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSDTKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDTKH.DisabledState.Parent = this.txtSDTKH;
            this.txtSDTKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDTKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDTKH.FocusedState.Parent = this.txtSDTKH;
            this.txtSDTKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDTKH.HoverState.Parent = this.txtSDTKH;
            this.txtSDTKH.Location = new System.Drawing.Point(324, 11);
            this.txtSDTKH.Name = "txtSDTKH";
            this.txtSDTKH.PasswordChar = '\0';
            this.txtSDTKH.PlaceholderText = "";
            this.txtSDTKH.SelectedText = "";
            this.txtSDTKH.ShadowDecoration.Parent = this.txtSDTKH;
            this.txtSDTKH.Size = new System.Drawing.Size(122, 24);
            this.txtSDTKH.TabIndex = 37;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaHD.DefaultText = "";
            this.txtMaHD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaHD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaHD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaHD.DisabledState.Parent = this.txtMaHD;
            this.txtMaHD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaHD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaHD.FocusedState.Parent = this.txtMaHD;
            this.txtMaHD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaHD.HoverState.Parent = this.txtMaHD;
            this.txtMaHD.Location = new System.Drawing.Point(111, 11);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.PasswordChar = '\0';
            this.txtMaHD.PlaceholderText = "";
            this.txtMaHD.SelectedText = "";
            this.txtMaHD.ShadowDecoration.Parent = this.txtMaHD;
            this.txtMaHD.Size = new System.Drawing.Size(96, 24);
            this.txtMaHD.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(361, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tên NV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Mã HD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(225, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "SĐT Khách hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(479, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "Ngày lập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(142, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "Mã NV Lập";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "MaSP";
            this.Column1.FillWeight = 73.50689F;
            this.Column1.HeaderText = "Mã SP";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 70;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column5.DataPropertyName = "TenSP";
            this.Column5.FillWeight = 135.1578F;
            this.Column5.HeaderText = "Tên SP";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 205;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.DataPropertyName = "GiaBan";
            this.Column2.FillWeight = 117.45F;
            this.Column2.HeaderText = "Giá bán";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 90;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SLMua";
            this.Column3.FillWeight = 71.74884F;
            this.Column3.HeaderText = "Số lượng";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 86;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "KhuyenMai";
            this.Column4.FillWeight = 85.15166F;
            this.Column4.HeaderText = "Khuyến mãi";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 104;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column6.DataPropertyName = "ThanhTien";
            this.Column6.FillWeight = 116.9848F;
            this.Column6.HeaderText = "Thành tiền";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 98;
            // 
            // FormChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 380);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvCTHD);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChiTietHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChiTietHoaDon";
            this.Load += new System.EventHandler(this.FormChiTietHoaDon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconbtnExit;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCTHD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtMaHD;
        private Guna.UI2.WinForms.Guna2TextBox txtHoTenNV;
        private Guna.UI2.WinForms.Guna2TextBox txtMaNVLap;
        private Guna.UI2.WinForms.Guna2TextBox txtNgayLap;
        private Guna.UI2.WinForms.Guna2TextBox txtSDTKH;
        private Guna.UI2.WinForms.Guna2TextBox txtTongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}