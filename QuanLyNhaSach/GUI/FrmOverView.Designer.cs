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
            this.taiKhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khoSachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tacGiaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.theLoaiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hoaDonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongKeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taiKhoanToolStripMenuItem,
            this.sachToolStripMenuItem,
            this.hoaDonToolStripMenuItem,
            this.thongKeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1135, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // taiKhoanToolStripMenuItem
            // 
            this.taiKhoanToolStripMenuItem.Name = "taiKhoanToolStripMenuItem";
            this.taiKhoanToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.taiKhoanToolStripMenuItem.Text = "Tài khoản";
            // 
            // sachToolStripMenuItem
            // 
            this.sachToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.khoSachToolStripMenuItem,
            this.tacGiaToolStripMenuItem1,
            this.theLoaiToolStripMenuItem1});
            this.sachToolStripMenuItem.Name = "sachToolStripMenuItem";
            this.sachToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.sachToolStripMenuItem.Text = "Sách";
            // 
            // khoSachToolStripMenuItem
            // 
            this.khoSachToolStripMenuItem.Name = "khoSachToolStripMenuItem";
            this.khoSachToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.khoSachToolStripMenuItem.Text = "Kho sách";
            this.khoSachToolStripMenuItem.Click += new System.EventHandler(this.khoSachToolStripMenuItem_Click);
            // 
            // tacGiaToolStripMenuItem1
            // 
            this.tacGiaToolStripMenuItem1.Name = "tacGiaToolStripMenuItem1";
            this.tacGiaToolStripMenuItem1.Size = new System.Drawing.Size(151, 26);
            this.tacGiaToolStripMenuItem1.Text = "Tác giả";
            // 
            // theLoaiToolStripMenuItem1
            // 
            this.theLoaiToolStripMenuItem1.Name = "theLoaiToolStripMenuItem1";
            this.theLoaiToolStripMenuItem1.Size = new System.Drawing.Size(151, 26);
            this.theLoaiToolStripMenuItem1.Text = "Thể loại";
            // 
            // hoaDonToolStripMenuItem
            // 
            this.hoaDonToolStripMenuItem.Name = "hoaDonToolStripMenuItem";
            this.hoaDonToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.hoaDonToolStripMenuItem.Text = "Hóa đơn";
            // 
            // thongKeToolStripMenuItem
            // 
            this.thongKeToolStripMenuItem.Name = "thongKeToolStripMenuItem";
            this.thongKeToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.thongKeToolStripMenuItem.Text = "Thống kê";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 514);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1111, 81);
            this.panel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "0 NGƯỜI";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "0 VND";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(919, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nguyễn Văn A";
            // 
            // dgvSach
            // 
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Location = new System.Drawing.Point(12, 79);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.RowHeadersWidth = 51;
            this.dgvSach.RowTemplate.Height = 24;
            this.dgvSach.Size = new System.Drawing.Size(1111, 429);
            this.dgvSach.TabIndex = 4;
            // 
            // FrmOverView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1135, 607);
            this.Controls.Add(this.dgvSach);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label7);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem taiKhoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hoaDonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongKeToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem sachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khoSachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tacGiaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem theLoaiToolStripMenuItem1;
        private System.Windows.Forms.DataGridView dgvSach;
    }
}