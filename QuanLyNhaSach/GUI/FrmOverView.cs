using QuanLyNhaSach.BLL;
using QuanLyNhaSach.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyNhaSach.GUI
{
    public partial class FrmOverView : Form
    {
        public FrmOverView(string userName)
        {
            InitializeComponent();
            lbUserName.Text = userName;
            if (userName != "Admin") themTaiKhoanToolStripMenuItem.Visible = false;
        }

        BLLSach BLLSach = new BLLSach();
        BLLThongke BLLThongke = new BLLThongke();

        private void FrmOverView_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = BLLSach.GetDataSach();

            this.lsvSach.Clear();
            this.lsvSach.Items.Clear();
            this.lsvSach.View = View.Details;
            this.lsvSach.Columns.Add("MÃ SÁCH", 100);
            this.lsvSach.Columns.Add("TÊN SÁCH", 300);
            this.lsvSach.Columns.Add("SỐ LƯỢNG", 110);
            this.lsvSach.Columns.Add("TÁC GIẢ", 250);
            this.lsvSach.Columns.Add("LOẠI SÁCH", 200);
            this.lsvSach.Columns.Add("GIÁ BÁN", 100);
            this.lsvSach.Columns.Add("LẦN TB", 70);
            this.lsvSach.Columns.Add("TÊN NXB", 140);
            this.lsvSach.Columns.Add("NĂM XB", 100);
            this.lsvSach.GridLines = true;
            this.lsvSach.FullRowSelect = true;

            int i = 0;
            foreach (DataRow row in dt.Rows)
            {
                this.lsvSach.Items.Add(row["MASACH"].ToString());
                this.lsvSach.Items[i].SubItems.Add(row["TENSACH"].ToString());
                this.lsvSach.Items[i].SubItems.Add(row["SOLUONG"].ToString());
                this.lsvSach.Items[i].SubItems.Add(row["TENTG"].ToString());
                this.lsvSach.Items[i].SubItems.Add(row["TENLOAISACH"].ToString());
                this.lsvSach.Items[i].SubItems.Add(row["GIABAN"].ToString());
                this.lsvSach.Items[i].SubItems.Add(row["LANTAIBAN"].ToString());
                this.lsvSach.Items[i].SubItems.Add(row["TENNHAXUATBAN"].ToString());
                this.lsvSach.Items[i].SubItems.Add(row["NAMXUATBAN"].ToString());
                i++;
            }
            LoadDoanhThuTrongNgay();
        }


        private void LoadDoanhThuTrongNgay()
        {
            string timeNow = DateTime.Now.ToString("yyyy-MM-dd");
            label5.Text = timeNow;

            var doanhThu = BLLThongke.GetDoanhThu(timeNow);
            var soLuongKhach = BLLThongke.GetSoLuongKhach(timeNow);


            txbDoanhThu.Text = doanhThu.ToString() + " VND";
            
            txbSLKhach.Text = soLuongKhach.ToString() + " khách";
            
        }
        private void khoSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FrmKhoSach();
            f.ShowDialog();
            FrmOverView_Load(sender, e);
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FrmDoiMatKhau(lbUserName.Text);
            f.ShowDialog();
        }

        private void thongKeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FrmThongKe();
            f.ShowDialog();
        }

        private void themTaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FrmThemTaiKhoan();
            f.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắc muốn thoát!!!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void hoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FrmHoaDon();
            f.ShowDialog();
            FrmOverView_Load(sender, e);
        }

        private void tacGiaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form f = new FrmTacGia();
            f.ShowDialog();
            FrmOverView_Load(sender, e);
        }

        private void theLoaiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form f = new FrmLoaiSach();
            f.ShowDialog();
            FrmOverView_Load(sender, e);
        }

        private void lsvSach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FrmNhaXuatBan();
            f.ShowDialog();
            FrmOverView_Load(sender, e);
        }
    }
}
