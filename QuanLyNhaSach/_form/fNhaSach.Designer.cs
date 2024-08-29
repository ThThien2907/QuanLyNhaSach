namespace QuanLyNhaSach
{
    partial class fNhaSach
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoaNXB = new System.Windows.Forms.Button();
            this.btnThemNXB = new System.Windows.Forms.Button();
            this.cbNXB = new System.Windows.Forms.ComboBox();
            this.txbNXB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(255, 395);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(280, 43);
            this.btnThoat.TabIndex = 15;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoaNXB
            // 
            this.btnXoaNXB.Location = new System.Drawing.Point(646, 349);
            this.btnXoaNXB.Name = "btnXoaNXB";
            this.btnXoaNXB.Size = new System.Drawing.Size(109, 28);
            this.btnXoaNXB.TabIndex = 14;
            this.btnXoaNXB.Text = "XOA";
            this.btnXoaNXB.UseVisualStyleBackColor = true;
            // 
            // btnThemNXB
            // 
            this.btnThemNXB.Location = new System.Drawing.Point(646, 291);
            this.btnThemNXB.Name = "btnThemNXB";
            this.btnThemNXB.Size = new System.Drawing.Size(109, 28);
            this.btnThemNXB.TabIndex = 13;
            this.btnThemNXB.Text = "THEM";
            this.btnThemNXB.UseVisualStyleBackColor = true;
            // 
            // cbNXB
            // 
            this.cbNXB.FormattingEnabled = true;
            this.cbNXB.Location = new System.Drawing.Point(170, 354);
            this.cbNXB.Name = "cbNXB";
            this.cbNXB.Size = new System.Drawing.Size(444, 21);
            this.cbNXB.TabIndex = 12;
            // 
            // txbNXB
            // 
            this.txbNXB.Location = new System.Drawing.Point(170, 299);
            this.txbNXB.Name = "txbNXB";
            this.txbNXB.Size = new System.Drawing.Size(444, 20);
            this.txbNXB.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "XOA NHA SACH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "THEM NHA SACH";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 249);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Danh sach cac nha xuat ban hien co";
            this.columnHeader1.Width = 500;
            // 
            // fNhaSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoaNXB);
            this.Controls.Add(this.btnThemNXB);
            this.Controls.Add(this.cbNXB);
            this.Controls.Add(this.txbNXB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "fNhaSach";
            this.Text = "fNhaSach";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoaNXB;
        private System.Windows.Forms.Button btnThemNXB;
        private System.Windows.Forms.ComboBox cbNXB;
        private System.Windows.Forms.TextBox txbNXB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}