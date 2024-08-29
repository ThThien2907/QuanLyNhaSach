using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public partial class fTacGia : Form
    {
        public fTacGia()
        {
            InitializeComponent();
        }

        private void fTacGia_Load(object sender, EventArgs e)
        {
            LoadData();
            txbMaTG.Enabled = false;
            txbTenTG.Enabled = false;
            txbQueQuan.Enabled = false;
            dtpNgayMat.Enabled = false;
            dtpNgaySinh.Enabled = false;
            chkNgayMat.Enabled = false;
            chkNgaySinh.Enabled = false;
            chkQueQuan.Enabled = false;
        }

        private void LoadData()
        {
            //throw new NotImplementedException();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
