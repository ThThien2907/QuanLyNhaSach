namespace QuanLyNhaSach.GUI
{
    partial class FrmOverView
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.heThongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themTaiKhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khoSachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tacGiaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.theLoaiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nhàXuấtBảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hoaDonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongKeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbSLKhach = new System.Windows.Forms.TextBox();
            this.txbDoanhThu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lsvSach = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heThongToolStripMenuItem,
            this.sachToolStripMenuItem,
            this.hoaDonToolStripMenuItem,
            this.thongKeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1135, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // heThongToolStripMenuItem
            // 
            this.heThongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themTaiKhoanToolStripMenuItem,
            this.đổiMậtKhẩuToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.heThongToolStripMenuItem.Name = "heThongToolStripMenuItem";
            this.heThongToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.heThongToolStripMenuItem.Text = "Hệ thống";
            // 
            // themTaiKhoanToolStripMenuItem
            // 
            this.themTaiKhoanToolStripMenuItem.Name = "themTaiKhoanToolStripMenuItem";
            this.themTaiKhoanToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.themTaiKhoanToolStripMenuItem.Text = "Thêm tài khoản";
            this.themTaiKhoanToolStripMenuItem.Click += new System.EventHandler(this.themTaiKhoanToolStripMenuItem_Click);
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // sachToolStripMenuItem
            // 
            this.sachToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.khoSachToolStripMenuItem,
            this.tacGiaToolStripMenuItem1,
            this.theLoaiToolStripMenuItem1,
            this.nhàXuấtBảnToolStripMenuItem});
            this.sachToolStripMenuItem.Name = "sachToolStripMenuItem";
            this.sachToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.sachToolStripMenuItem.Text = "Sách";
            // 
            // khoSachToolStripMenuItem
            // 
            this.khoSachToolStripMenuItem.Name = "khoSachToolStripMenuItem";
            this.khoSachToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.khoSachToolStripMenuItem.Text = "Kho sách";
            this.khoSachToolStripMenuItem.Click += new System.EventHandler(this.khoSachToolStripMenuItem_Click);
            // 
            // tacGiaToolStripMenuItem1
            // 
            this.tacGiaToolStripMenuItem1.Name = "tacGiaToolStripMenuItem1";
            this.tacGiaToolStripMenuItem1.Size = new System.Drawing.Size(180, 26);
            this.tacGiaToolStripMenuItem1.Text = "Tác giả";
            this.tacGiaToolStripMenuItem1.Click += new System.EventHandler(this.tacGiaToolStripMenuItem1_Click);
            // 
            // theLoaiToolStripMenuItem1
            // 
            this.theLoaiToolStripMenuItem1.Name = "theLoaiToolStripMenuItem1";
            this.theLoaiToolStripMenuItem1.Size = new System.Drawing.Size(180, 26);
            this.theLoaiToolStripMenuItem1.Text = "Loại sách";
            this.theLoaiToolStripMenuItem1.Click += new System.EventHandler(this.theLoaiToolStripMenuItem1_Click);
            // 
            // nhàXuấtBảnToolStripMenuItem
            // 
            this.nhàXuấtBảnToolStripMenuItem.Name = "nhàXuấtBảnToolStripMenuItem";
            this.nhàXuấtBảnToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.nhàXuấtBảnToolStripMenuItem.Text = "Nhà xuất bản";
            this.nhàXuấtBảnToolStripMenuItem.Click += new System.EventHandler(this.nhàXuấtBảnToolStripMenuItem_Click);
            // 
            // hoaDonToolStripMenuItem
            // 
            this.hoaDonToolStripMenuItem.Name = "hoaDonToolStripMenuItem";
            this.hoaDonToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.hoaDonToolStripMenuItem.Text = "Hóa đơn";
            this.hoaDonToolStripMenuItem.Click += new System.EventHandler(this.hoaDonToolStripMenuItem_Click);
            // 
            // thongKeToolStripMenuItem
            // 
            this.thongKeToolStripMenuItem.Name = "thongKeToolStripMenuItem";
            this.thongKeToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.thongKeToolStripMenuItem.Text = "Thống kê";
            this.thongKeToolStripMenuItem.Click += new System.EventHandler(this.thongKeToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbSLKhach);
            this.panel1.Controls.Add(this.txbDoanhThu);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 514);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1111, 81);
            this.panel1.TabIndex = 3;
            // 
            // txbSLKhach
            // 
            this.txbSLKhach.Location = new System.Drawing.Point(267, 45);
            this.txbSLKhach.Name = "txbSLKhach";
            this.txbSLKhach.ReadOnly = true;
            this.txbSLKhach.Size = new System.Drawing.Size(172, 30);
            this.txbSLKhach.TabIndex = 2;
            // 
            // txbDoanhThu
            // 
            this.txbDoanhThu.Location = new System.Drawing.Point(267, 11);
            this.txbDoanhThu.Name = "txbDoanhThu";
            this.txbDoanhThu.ReadOnly = true;
            this.txbDoanhThu.Size = new System.Drawing.Size(172, 30);
            this.txbDoanhThu.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "SỐ LƯỢNG KHÁCH : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(992, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "23/08/2024";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "DOANH THU TRONG NGÀY : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(788, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Người dùng : ";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.Location = new System.Drawing.Point(919, 40);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(123, 22);
            this.lbUserName.TabIndex = 0;
            this.lbUserName.Text = "Nguyễn Văn A";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsvSach);
            this.panel2.Location = new System.Drawing.Point(12, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1111, 437);
            this.panel2.TabIndex = 4;
            // 
            // lsvSach
            // 
            this.lsvSach.HideSelection = false;
            this.lsvSach.Location = new System.Drawing.Point(3, 3);
            this.lsvSach.Name = "lsvSach";
            this.lsvSach.Size = new System.Drawing.Size(1105, 431);
            this.lsvSach.TabIndex = 0;
            this.lsvSach.UseCompatibleStateImageBehavior = false;
            this.lsvSach.SelectedIndexChanged += new System.EventHandler(this.lsvSach_SelectedIndexChanged);
            // 
            // FrmOverView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1135, 607);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmOverView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhà sách";
            this.Load += new System.EventHandler(this.FrmOverView_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem heThongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hoaDonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongKeToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.ToolStripMenuItem sachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khoSachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tacGiaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem theLoaiToolStripMenuItem1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lsvSach;
        private System.Windows.Forms.ToolStripMenuItem themTaiKhoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.TextBox txbSLKhach;
        private System.Windows.Forms.TextBox txbDoanhThu;
        private System.Windows.Forms.ToolStripMenuItem nhàXuấtBảnToolStripMenuItem;
    }
}