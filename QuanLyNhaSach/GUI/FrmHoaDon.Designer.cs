namespace QuanLyNhaSach.GUI
{
    partial class FrmHoaDon
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lsvHoaDon = new System.Windows.Forms.ListView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lsvChiTietHoaDon = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.txbTenKH = new System.Windows.Forms.TextBox();
            this.txbMaHD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCreateHD = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCTHD = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lsvSach = new System.Windows.Forms.ListView();
            this.btnAddCTHD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nbudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdateCTHD = new System.Windows.Forms.Button();
            this.btnDeleteCTHD = new System.Windows.Forms.Button();
            this.btnSaveCTHD = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSaveHD = new System.Windows.Forms.Button();
            this.btnDeleteHD = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbudSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lsvHoaDon);
            this.panel1.Location = new System.Drawing.Point(2, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 289);
            this.panel1.TabIndex = 0;
            // 
            // lsvHoaDon
            // 
            this.lsvHoaDon.HideSelection = false;
            this.lsvHoaDon.Location = new System.Drawing.Point(3, 3);
            this.lsvHoaDon.Name = "lsvHoaDon";
            this.lsvHoaDon.Size = new System.Drawing.Size(669, 283);
            this.lsvHoaDon.TabIndex = 0;
            this.lsvHoaDon.UseCompatibleStateImageBehavior = false;
            this.lsvHoaDon.View = System.Windows.Forms.View.Details;
            this.lsvHoaDon.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lsvChiTietHoaDon);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(683, 47);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(804, 247);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // lsvChiTietHoaDon
            // 
            this.lsvChiTietHoaDon.HideSelection = false;
            this.lsvChiTietHoaDon.Location = new System.Drawing.Point(3, 3);
            this.lsvChiTietHoaDon.Name = "lsvChiTietHoaDon";
            this.lsvChiTietHoaDon.Size = new System.Drawing.Size(798, 241);
            this.lsvChiTietHoaDon.TabIndex = 0;
            this.lsvChiTietHoaDon.UseCompatibleStateImageBehavior = false;
            this.lsvChiTietHoaDon.View = System.Windows.Forms.View.Details;
            this.lsvChiTietHoaDon.SelectedIndexChanged += new System.EventHandler(this.lsvChiTietHoaDon_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDeleteHD);
            this.panel2.Controls.Add(this.dtpNgayLap);
            this.panel2.Controls.Add(this.txbTenKH);
            this.panel2.Controls.Add(this.txbMaHD);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnCreateHD);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnCTHD);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(2, 300);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(672, 467);
            this.panel2.TabIndex = 2;
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayLap.Location = new System.Drawing.Point(277, 225);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(288, 30);
            this.dtpNgayLap.TabIndex = 7;
            // 
            // txbTenKH
            // 
            this.txbTenKH.Location = new System.Drawing.Point(277, 171);
            this.txbTenKH.Name = "txbTenKH";
            this.txbTenKH.Size = new System.Drawing.Size(288, 30);
            this.txbTenKH.TabIndex = 6;
            // 
            // txbMaHD
            // 
            this.txbMaHD.Location = new System.Drawing.Point(277, 114);
            this.txbMaHD.Name = "txbMaHD";
            this.txbMaHD.Size = new System.Drawing.Size(288, 30);
            this.txbMaHD.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "NGÀY LẬP";
            // 
            // btnCreateHD
            // 
            this.btnCreateHD.Location = new System.Drawing.Point(10, 15);
            this.btnCreateHD.Name = "btnCreateHD";
            this.btnCreateHD.Size = new System.Drawing.Size(187, 45);
            this.btnCreateHD.TabIndex = 4;
            this.btnCreateHD.Text = "Lập hóa đơn mới";
            this.btnCreateHD.UseVisualStyleBackColor = true;
            this.btnCreateHD.Click += new System.EventHandler(this.button7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "TÊN KHÁCH HÀNG";
            // 
            // btnCTHD
            // 
            this.btnCTHD.Location = new System.Drawing.Point(277, 15);
            this.btnCTHD.Name = "btnCTHD";
            this.btnCTHD.Size = new System.Drawing.Size(187, 45);
            this.btnCTHD.TabIndex = 4;
            this.btnCTHD.Text = "Chi tiết hóa đơn";
            this.btnCTHD.UseVisualStyleBackColor = true;
            this.btnCTHD.Click += new System.EventHandler(this.button6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "MÃ HÓA ĐƠN";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lsvSach);
            this.panel3.Location = new System.Drawing.Point(683, 414);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(804, 280);
            this.panel3.TabIndex = 3;
            // 
            // lsvSach
            // 
            this.lsvSach.HideSelection = false;
            this.lsvSach.Location = new System.Drawing.Point(3, 3);
            this.lsvSach.Name = "lsvSach";
            this.lsvSach.Size = new System.Drawing.Size(798, 274);
            this.lsvSach.TabIndex = 0;
            this.lsvSach.UseCompatibleStateImageBehavior = false;
            this.lsvSach.View = System.Windows.Forms.View.Details;
            this.lsvSach.SelectedIndexChanged += new System.EventHandler(this.listView3_SelectedIndexChanged);
            // 
            // btnAddCTHD
            // 
            this.btnAddCTHD.Location = new System.Drawing.Point(724, 315);
            this.btnAddCTHD.Name = "btnAddCTHD";
            this.btnAddCTHD.Size = new System.Drawing.Size(136, 45);
            this.btnAddCTHD.TabIndex = 4;
            this.btnAddCTHD.Text = "Thêm";
            this.btnAddCTHD.UseVisualStyleBackColor = true;
            this.btnAddCTHD.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(705, 719);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "CHỌN SỐ LƯỢNG";
            // 
            // nbudSoLuong
            // 
            this.nbudSoLuong.Location = new System.Drawing.Point(880, 717);
            this.nbudSoLuong.Name = "nbudSoLuong";
            this.nbudSoLuong.Size = new System.Drawing.Size(234, 30);
            this.nbudSoLuong.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(705, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "CHỌN SÁCH";
            // 
            // btnUpdateCTHD
            // 
            this.btnUpdateCTHD.Location = new System.Drawing.Point(920, 315);
            this.btnUpdateCTHD.Name = "btnUpdateCTHD";
            this.btnUpdateCTHD.Size = new System.Drawing.Size(136, 45);
            this.btnUpdateCTHD.TabIndex = 4;
            this.btnUpdateCTHD.Text = "Sửa";
            this.btnUpdateCTHD.UseVisualStyleBackColor = true;
            this.btnUpdateCTHD.Click += new System.EventHandler(this.btnUpdateCTHD_Click);
            // 
            // btnDeleteCTHD
            // 
            this.btnDeleteCTHD.Location = new System.Drawing.Point(1116, 315);
            this.btnDeleteCTHD.Name = "btnDeleteCTHD";
            this.btnDeleteCTHD.Size = new System.Drawing.Size(136, 45);
            this.btnDeleteCTHD.TabIndex = 4;
            this.btnDeleteCTHD.Text = "Xóa";
            this.btnDeleteCTHD.UseVisualStyleBackColor = true;
            this.btnDeleteCTHD.Click += new System.EventHandler(this.btnDeleteCTHD_Click);
            // 
            // btnSaveCTHD
            // 
            this.btnSaveCTHD.Location = new System.Drawing.Point(1312, 315);
            this.btnSaveCTHD.Name = "btnSaveCTHD";
            this.btnSaveCTHD.Size = new System.Drawing.Size(136, 45);
            this.btnSaveCTHD.TabIndex = 4;
            this.btnSaveCTHD.Text = "Lưu";
            this.btnSaveCTHD.UseVisualStyleBackColor = true;
            this.btnSaveCTHD.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(705, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "CHI TIẾT HÓA ĐƠN";
            // 
            // btnSaveHD
            // 
            this.btnSaveHD.Location = new System.Drawing.Point(1248, 701);
            this.btnSaveHD.Name = "btnSaveHD";
            this.btnSaveHD.Size = new System.Drawing.Size(230, 58);
            this.btnSaveHD.TabIndex = 4;
            this.btnSaveHD.Text = "Hoàn thành hóa đơn";
            this.btnSaveHD.UseVisualStyleBackColor = true;
            this.btnSaveHD.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnDeleteHD
            // 
            this.btnDeleteHD.Location = new System.Drawing.Point(515, 15);
            this.btnDeleteHD.Name = "btnDeleteHD";
            this.btnDeleteHD.Size = new System.Drawing.Size(136, 45);
            this.btnDeleteHD.TabIndex = 7;
            this.btnDeleteHD.Text = "Xóa";
            this.btnDeleteHD.UseVisualStyleBackColor = true;
            this.btnDeleteHD.Click += new System.EventHandler(this.btnXoaHD_Click);
            // 
            // FrmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1490, 771);
            this.Controls.Add(this.nbudSoLuong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveHD);
            this.Controls.Add(this.btnSaveCTHD);
            this.Controls.Add(this.btnUpdateCTHD);
            this.Controls.Add(this.btnDeleteCTHD);
            this.Controls.Add(this.btnAddCTHD);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn";
            this.Load += new System.EventHandler(this.FrmHoaDon_Load);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nbudSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView lsvHoaDon;
        private System.Windows.Forms.Button btnAddCTHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lsvSach;
        private System.Windows.Forms.NumericUpDown nbudSoLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdateCTHD;
        private System.Windows.Forms.Button btnDeleteCTHD;
        private System.Windows.Forms.Button btnSaveCTHD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSaveHD;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.TextBox txbTenKH;
        private System.Windows.Forms.TextBox txbMaHD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCreateHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCTHD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lsvChiTietHoaDon;
        private System.Windows.Forms.Button btnDeleteHD;
    }
}