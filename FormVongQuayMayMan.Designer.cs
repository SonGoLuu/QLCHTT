
namespace QLCHTT
{
    partial class FormVongQuayMayMan
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
            this.Spin_Button = new System.Windows.Forms.Button();
            this.Title_Label = new System.Windows.Forms.Label();
            this.Wheel_PictureBox = new System.Windows.Forms.PictureBox();
            this.iconbtnExit = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.Wheel_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Spin_Button
            // 
            this.Spin_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Spin_Button.BackColor = System.Drawing.Color.Crimson;
            this.Spin_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Spin_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Spin_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spin_Button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Spin_Button.Location = new System.Drawing.Point(240, 535);
            this.Spin_Button.Name = "Spin_Button";
            this.Spin_Button.Size = new System.Drawing.Size(102, 30);
            this.Spin_Button.TabIndex = 5;
            this.Spin_Button.Text = "Quay";
            this.Spin_Button.UseVisualStyleBackColor = false;
            this.Spin_Button.Click += new System.EventHandler(this.Spin_Button_Click);
            // 
            // Title_Label
            // 
            this.Title_Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Title_Label.AutoSize = true;
            this.Title_Label.Font = new System.Drawing.Font("Be Vietnam Pro", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Title_Label.Location = new System.Drawing.Point(151, -6);
            this.Title_Label.Name = "Title_Label";
            this.Title_Label.Size = new System.Drawing.Size(290, 41);
            this.Title_Label.TabIndex = 4;
            this.Title_Label.Text = "Vòng quay may mắn";
            // 
            // Wheel_PictureBox
            // 
            this.Wheel_PictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Wheel_PictureBox.BackgroundImage = global::QLCHTT.Properties.Resources.No_Slots_active;
            this.Wheel_PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Wheel_PictureBox.Location = new System.Drawing.Point(47, 44);
            this.Wheel_PictureBox.Name = "Wheel_PictureBox";
            this.Wheel_PictureBox.Size = new System.Drawing.Size(491, 477);
            this.Wheel_PictureBox.TabIndex = 6;
            this.Wheel_PictureBox.TabStop = false;
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
            this.iconbtnExit.Location = new System.Drawing.Point(547, 6);
            this.iconbtnExit.Name = "iconbtnExit";
            this.iconbtnExit.Size = new System.Drawing.Size(38, 34);
            this.iconbtnExit.TabIndex = 31;
            this.iconbtnExit.UseVisualStyleBackColor = true;
            this.iconbtnExit.Click += new System.EventHandler(this.iconbtnExit_Click);
            // 
            // FormVongQuayMayMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(587, 571);
            this.Controls.Add(this.iconbtnExit);
            this.Controls.Add(this.Wheel_PictureBox);
            this.Controls.Add(this.Spin_Button);
            this.Controls.Add(this.Title_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVongQuayMayMan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVongQuayMayMan";
            this.Load += new System.EventHandler(this.FormVongQuayMayMan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Wheel_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox Wheel_PictureBox;
        private System.Windows.Forms.Button Spin_Button;
        private System.Windows.Forms.Label Title_Label;
        private FontAwesome.Sharp.IconButton iconbtnExit;
    }
}