namespace QuanLyNhaSach.GUI
{
    partial class FrmThemTaiKhoan
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
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRePassWord = new System.Windows.Forms.TextBox();
            this.imgShowHideRePW = new System.Windows.Forms.PictureBox();
            this.imgShowHide = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgShowHideRePW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgShowHide)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(216, 147);
            this.txtPassWord.Margin = new System.Windows.Forms.Padding(6);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.Size = new System.Drawing.Size(324, 30);
            this.txtPassWord.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên người dùng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 35);
            this.label1.TabIndex = 8;
            this.label1.Text = "THÊM TÀI KHOẢN MỚI";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(216, 93);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(6);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(324, 30);
            this.txtUserName.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 263);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 54);
            this.button1.TabIndex = 4;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(416, 263);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 54);
            this.button2.TabIndex = 5;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 204);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nhập lại mật khẩu";
            // 
            // txtRePassWord
            // 
            this.txtRePassWord.Location = new System.Drawing.Point(216, 201);
            this.txtRePassWord.Margin = new System.Windows.Forms.Padding(6);
            this.txtRePassWord.Name = "txtRePassWord";
            this.txtRePassWord.PasswordChar = '*';
            this.txtRePassWord.Size = new System.Drawing.Size(324, 30);
            this.txtRePassWord.TabIndex = 3;
            // 
            // imgShowHideRePW
            // 
            this.imgShowHideRePW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgShowHideRePW.Image = global::QuanLyNhaSach.Properties.Resources.Show_Password_256;
            this.imgShowHideRePW.Location = new System.Drawing.Point(549, 201);
            this.imgShowHideRePW.Name = "imgShowHideRePW";
            this.imgShowHideRePW.Size = new System.Drawing.Size(30, 30);
            this.imgShowHideRePW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgShowHideRePW.TabIndex = 16;
            this.imgShowHideRePW.TabStop = false;
            this.imgShowHideRePW.Click += new System.EventHandler(this.imgShowHideRePW_Click);
            // 
            // imgShowHide
            // 
            this.imgShowHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgShowHide.Image = global::QuanLyNhaSach.Properties.Resources.Show_Password_256;
            this.imgShowHide.Location = new System.Drawing.Point(549, 147);
            this.imgShowHide.Name = "imgShowHide";
            this.imgShowHide.Size = new System.Drawing.Size(30, 30);
            this.imgShowHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgShowHide.TabIndex = 17;
            this.imgShowHide.TabStop = false;
            this.imgShowHide.Click += new System.EventHandler(this.imgShowHide_Click);
            // 
            // FrmThemTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(623, 340);
            this.Controls.Add(this.imgShowHideRePW);
            this.Controls.Add(this.imgShowHide);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtRePassWord);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FrmThemTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm tài khoản";
            ((System.ComponentModel.ISupportInitialize)(this.imgShowHideRePW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgShowHide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRePassWord;
        private System.Windows.Forms.PictureBox imgShowHideRePW;
        private System.Windows.Forms.PictureBox imgShowHide;
    }
}