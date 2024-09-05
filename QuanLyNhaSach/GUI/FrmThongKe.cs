using QuanLyNhaSach.BLL;
using QuanLyNhaSach.GUI;
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
    public partial class FrmThongKe : Form
    {

        BLLThongke BLLThongke = new BLLThongke();
        public FrmThongKe()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tungay = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string denngay = dateTimePicker2.Value.ToString("yyyy-MM-dd");

            DataTable data = BLLThongke.GetDataThongKe(tungay, denngay);

            this.dgvThongKe.Clear();
            this.dgvThongKe.Items.Clear();
            this.dgvThongKe.View = View.Details;
            this.dgvThongKe.Columns.Add("MÃ HÓA ĐƠN", 150);
            this.dgvThongKe.Columns.Add("TÊN KHÁCH HÀNG", 250);
            this.dgvThongKe.Columns.Add("NGÀY LẬP", 200);
            this.dgvThongKe.Columns.Add("TỔNG TIỀN", 200);
            this.dgvThongKe.GridLines = true;
            this.dgvThongKe.FullRowSelect = true;

            int i = 0;
            foreach (DataRow row in data.Rows)
            {
                this.dgvThongKe.Items.Add(row["MAHOADON"].ToString());
                this.dgvThongKe.Items[i].SubItems.Add(row["TENKHACHHANG"].ToString());
                this.dgvThongKe.Items[i].SubItems.Add(row["NGAYLAP"].ToString());
                this.dgvThongKe.Items[i].SubItems.Add(row["TONGTIEN"].ToString());
                i++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1_SelectedIndexChanged(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmBaoCao f = new FrmBaoCao();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
