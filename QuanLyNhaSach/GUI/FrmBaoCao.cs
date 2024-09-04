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
    public partial class FrmBaoCao : Form
    {
        BLLBaoCao BLLBaoCao = new BLLBaoCao();
        public FrmBaoCao()
        {
            InitializeComponent();
            txb_TextChanged();
            listView1_SelectedIndexChanged();
        }

        private void listView1_SelectedIndexChanged()
        {
            DataTable data = BLLBaoCao.GetDataBaoCao();

            this.listView1.Clear();
            this.listView1.Items.Clear();
            this.listView1.View = View.Details;
            this.listView1.Columns.Add("MÃ SÁCH", 200);
            this.listView1.Columns.Add("TÊN SÁCH", 350);
            this.listView1.Columns.Add("SỐ LƯỢNG BÁN RA", 250);
            this.listView1.Columns.Add("GIÁ NHẬP", 200);
            this.listView1.Columns.Add("GIÁ BÁN", 200);
            this.listView1.GridLines = true;
            this.listView1.FullRowSelect = true;

            int i = 0;
            foreach (DataRow row in data.Rows)
            {
                this.listView1.Items.Add(row["MASACH"].ToString());
                this.listView1.Items[i].SubItems.Add(row["TENSACH"].ToString());
                this.listView1.Items[i].SubItems.Add(row["SỐ LƯỢNG BÁN RA"].ToString());
                this.listView1.Items[i].SubItems.Add(row["GIANHAP"].ToString());
                this.listView1.Items[i].SubItems.Add(row["GIABAN"].ToString());
                i++;
            }
        }

        private void txb_TextChanged()
        {
            int von = 0;
            int tong = 0;
            float loinhuan;
            foreach (ListViewItem item in this.listView1.Items)
            {

                von = von + (int.Parse(item.SubItems[2].Text) * int.Parse(item.SubItems[3].Text));
                tong = tong + (int.Parse(item.SubItems[2].Text) * int.Parse(item.SubItems[4].Text));

            }
            loinhuan = tong - von;
            txbTongDoanhThu.Text = tong.ToString() + " VND";
            txbLoiNhuan.Text = loinhuan.ToString() + " VND";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
