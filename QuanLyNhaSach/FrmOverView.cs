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
    public partial class FrmOverView : Form
    {
        public FrmOverView()
        {
            InitializeComponent();
        }

        private void FrmOverView_Load(object sender, EventArgs e)
        {
            taiKhoanToolStripMenuItem.Visible = false;
        }

        private void khoSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FrmKhoSach();
            f.ShowDialog();
        }
    }
}
