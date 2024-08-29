using QuanLyNhaSach.BLL;
using QuanLyNhaSach.DLL;
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
    public partial class FrmOverView : Form
    {
        public FrmOverView()
        {
            InitializeComponent();
        }

        BLLSach BLLSach = new BLLSach();

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
                this.lsvSach.Items[i].SubItems.Add(row["MATG"].ToString());
                this.lsvSach.Items[i].SubItems.Add(row["MALOAISACH"].ToString());
                this.lsvSach.Items[i].SubItems.Add(row["GIABAN"].ToString());
                this.lsvSach.Items[i].SubItems.Add(row["LANTAIBAN"].ToString());
                this.lsvSach.Items[i].SubItems.Add(row["MANXB"].ToString());
                this.lsvSach.Items[i].SubItems.Add(row["NAMXUATBAN"].ToString());
                i++;
            }

            taiKhoanToolStripMenuItem.Visible = false;

        }

        private void khoSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FrmKhoSach();
            f.ShowDialog();
        }
    }
}
