using QuanLyNhaSach.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach.GUI
{
    public partial class FrmThemTaiKhoan : Form
    {
        public FrmThemTaiKhoan()
        {
            InitializeComponent();
        }
        BLLTaiKhoan BLLTaiKhoan = new BLLTaiKhoan();

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPassWord.Text.Trim() == txtRePassWord.Text.Trim())
            {
                if (!BLLTaiKhoan.ThemTaiKhoan(txtUserName.Text, txtPassWord.Text))
                    MessageBox.Show("Thêm tài khoản không thành công !!", "Thông báo", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Thêm tài khoản thành công !!", "Thông báo", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Mật khẩu không trùng khớp !!", "Thông báo", MessageBoxButtons.OK);
        }

        private void imgShowHide_Click(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            if (pb != null)
            {
                if (txtPassWord.PasswordChar == '*')
                {
                    pb.Image = Properties.Resources.Hide_Password_256;
                    txtPassWord.PasswordChar = '\0';
                }
                else
                {
                    pb.Image = Properties.Resources.Show_Password_256;
                    txtPassWord.PasswordChar = '*';
                }
            }
        }

        private void imgShowHideRePW_Click(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            if (pb != null)
            {
                if (txtRePassWord.PasswordChar == '*')
                {
                    pb.Image = Properties.Resources.Hide_Password_256;
                    txtRePassWord.PasswordChar = '\0';
                }
                else
                {
                    pb.Image = Properties.Resources.Show_Password_256;
                    txtRePassWord.PasswordChar = '*';
                }
            }
        }
    }
}
