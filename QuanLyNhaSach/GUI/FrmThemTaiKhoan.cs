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
            if (!BLLTaiKhoan.ThemTaiKhoan(txtUserName.Text, txtPassWord.Text))
                MessageBox.Show("Thêm tài khoản không thành công !!", "Thông báo", MessageBoxButtons.OK);
            else
                MessageBox.Show("Thêm tài khoản thành công !!", "Thông báo", MessageBoxButtons.OK);
        }
    }
}
