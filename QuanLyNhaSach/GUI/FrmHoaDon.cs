using QuanLyNhaSach.BLL;
using QuanLyNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach.GUI
{
    public partial class FrmHoaDon : Form
    {
        BLLHoaDon BLLHoaDon = new BLLHoaDon();
        BLLSach BLLSach = new BLLSach();
        BLLChiTietHoaDon BLLChiTietHoaDon = new BLLChiTietHoaDon();
        public FrmHoaDon()
        {
            InitializeComponent();
        }

        private void FrmHoaDon_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            CreateLsvHoaHon();
            CreateLsvSach();
            CreateLsvChiTietHD();

            dt = BLLHoaDon.GetDataHoaDon();
            LoadDataHoaDon(dt);
            dt = new DataTable();
            dt = BLLSach.GetDataSach();
            LoadDataSach(dt);
            

            IsActiveCTHDPanel(false);
            txbMaHD.Enabled = false;
            txbTenKH.Enabled = false;
            dtpNgayLap.Enabled = false;

            lsvChiTietHoaDon.Enabled = false;
            lsvSach.Enabled = false;
            nbudSoLuong.Enabled = false;
            btnSaveHD.Enabled = false;
            btnCTHD.Enabled = false;
            btnDeleteHD.Enabled = false;
        }
        private void CreateLsvHoaHon()
        {
            this.lsvHoaDon.Clear();
            this.lsvHoaDon.Items.Clear();
            this.lsvHoaDon.Columns.Add("MÃ HÓA ĐƠN", 140);
            this.lsvHoaDon.Columns.Add("TÊN KHÁCH HÀNG", 200);
            this.lsvHoaDon.Columns.Add("NGÀY LẬP", 150);
            this.lsvHoaDon.Columns.Add("TỔNG TIỀN", 170);
            this.lsvHoaDon.GridLines = true;
            this.lsvHoaDon.FullRowSelect = true;
        }
        private void CreateLsvSach()
        {
            this.lsvSach.Clear();
            this.lsvSach.Items.Clear();
            this.lsvSach.Columns.Add("MÃ SÁCH", 90);
            this.lsvSach.Columns.Add("TÊN SÁCH", 200);
            this.lsvSach.Columns.Add("GIÁ BÌA", 70);
            this.lsvSach.Columns.Add("TÊN TÁC GIẢ", 170);
            this.lsvSach.Columns.Add("THỂ LOẠI", 90);
            this.lsvSach.Columns.Add("NHÀ XUẤT BẢN", 170);
            this.lsvSach.GridLines = true;
            this.lsvSach.FullRowSelect = true;
        }
        private void CreateLsvChiTietHD()
        {
            this.lsvChiTietHoaDon.Clear();
            this.lsvChiTietHoaDon.Items.Clear();
            this.lsvChiTietHoaDon.Columns.Add("MÃ HÓA ĐƠN", 120);
            this.lsvChiTietHoaDon.Columns.Add("MÃ SÁCH", 90);
            //this.lsvChiTietHoaDon.Columns.Add("TÊN SÁCH", 200);
            this.lsvChiTietHoaDon.Columns.Add("SỐ LƯỢNG", 100);
            this.lsvChiTietHoaDon.Columns.Add("GIÁ TIỀN", 110);
            this.lsvChiTietHoaDon.Columns.Add("THÀNH TIỀN", 180);
            this.lsvChiTietHoaDon.GridLines = true;
            this.lsvChiTietHoaDon.FullRowSelect = true;
        }
        private void LoadDataHoaDon(DataTable dataTable)
        {
            lsvHoaDon.Items.Clear();
            int i = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                this.lsvHoaDon.Items.Add(row["MAHOADON"].ToString());
                this.lsvHoaDon.Items[i].SubItems.Add(row["TENKHACHHANG"].ToString());
                this.lsvHoaDon.Items[i].SubItems.Add(row["NGAYLAP"].ToString());
                this.lsvHoaDon.Items[i].SubItems.Add(row["TONGTIEN"].ToString());
                i++;
            }
        }
        private void LoadDataSach(DataTable dataTable)
        {
            int i = 0;
            lsvChiTietHoaDon.Items.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                this.lsvSach.Items.Add(row["MASACH"].ToString());
                this.lsvSach.Items[i].SubItems.Add(row["TENSACH"].ToString());
                this.lsvSach.Items[i].SubItems.Add(row["GIABAN"].ToString());
                this.lsvSach.Items[i].SubItems.Add(row["TENTG"].ToString());
                this.lsvSach.Items[i].SubItems.Add(row["TENLOAISACH"].ToString());
                this.lsvSach.Items[i].SubItems.Add(row["TENNHAXUATBAN"].ToString());
                i++;
            }
        }
        private void LoadDataChiTietHoaDon(DataTable dataTable)
        {
            int i = 0;
            lsvChiTietHoaDon.Items.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                this.lsvChiTietHoaDon.Items.Add(row["MAHOADON"].ToString());
                this.lsvChiTietHoaDon.Items[i].SubItems.Add(row["MASACH"].ToString());
                this.lsvChiTietHoaDon.Items[i].SubItems.Add(row["SOLUONG"].ToString());
                this.lsvChiTietHoaDon.Items[i].SubItems.Add(row["GIATIEN"].ToString());
                this.lsvChiTietHoaDon.Items[i].SubItems.Add(row["THANHTIEN"].ToString());
                i++;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCTHD.Enabled = true;
            btnDeleteHD.Enabled = true;
            if (lsvHoaDon.SelectedItems.Count <= 0) return;
            ListViewItem item = lsvHoaDon.SelectedItems[0];
            txbMaHD.Text = lsvHoaDon.SelectedItems[0].Text;
            txbTenKH.Text = lsvHoaDon.SelectedItems[0].SubItems[1].Text;
            dtpNgayLap.Value = DateTime.Parse(lsvHoaDon.SelectedItems[0].SubItems[2].Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            btnAddCTHD.Enabled = true;
            btnSaveCTHD.Enabled = false;
            btnUpdateCTHD.Enabled = true;
            btnDeleteCTHD.Enabled = true;
            btnSaveHD.Enabled = true;
            
            txbMaHD.Enabled = true;
            txbTenKH.Enabled = true;
            txbMaHD.Clear();
            txbTenKH.Clear();
            dtpNgayLap.Value = DateTime.Now;
            dtpNgayLap.Enabled = true;

            lsvChiTietHoaDon.Enabled = true;
            lsvChiTietHoaDon.Items.Clear();

            lsvSach.Enabled = true;
        }

        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvSach.SelectedItems.Count > 0)
            {
                nbudSoLuong.Value = 0;
                nbudSoLuong.Enabled = true;
            }
            else nbudSoLuong.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (lsvHoaDon.SelectedItems.Count <= 0) return;
            dtpNgayLap.Enabled = true;
            btnCreateHD.Enabled = false;
            btnDeleteHD.Enabled = false;
            lsvChiTietHoaDon.Enabled = true;
            lsvSach.Enabled = true;
            IsActiveCTHDPanel(true);
            
            LoadDataChiTietHoaDon(BLLChiTietHoaDon.GetDataChiTietHoaDon(txbMaHD.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nbudSoLuong.Value <= 0)
            {
                MessageBox.Show("Vui lòng điền số lượng !!!");
                return;
            } 
            ListViewItem itemSach = lsvSach.SelectedItems[0];
            ListViewItem itemChiTietHD = new ListViewItem();
            string maSach = itemSach.SubItems[0].Text;
            itemChiTietHD.Text = txbMaHD.Text;
            itemChiTietHD.SubItems.Add(itemSach.Text);
            //itemChiTietHD.SubItems.Add(itemSach.SubItems[1]);
            itemChiTietHD.SubItems.Add(nbudSoLuong.Value.ToString());
            itemChiTietHD.SubItems.Add(itemSach.SubItems[2]);
            itemChiTietHD.SubItems.Add((nbudSoLuong.Value * int.Parse(itemSach.SubItems[2].Text.ToString())).ToString());
            try
            {
                foreach (ListViewItem item in lsvChiTietHoaDon.Items)
                {
                    if (item.SubItems[1].Text == maSach)
                    {
                        int newsoLuong = int.Parse(item.SubItems[2].Text) + int.Parse(nbudSoLuong.Value.ToString());
                        item.SubItems[2].Text = newsoLuong.ToString();
                        item.SubItems[4].Text = ((newsoLuong * int.Parse(itemSach.SubItems[2].Text.ToString())).ToString());
                        return;
                    }
                }
                lsvChiTietHoaDon.Items.Add(itemChiTietHD);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnCreateHD.Enabled = true;
            btnDeleteHD.Enabled = true;
            EditChiTietHoaDonData(txbMaHD.Text);
            IsActiveCTHDPanel(false);
            ActiveSachPanel(false);
            lsvChiTietHoaDon.Enabled = false;
            HoaDon newHD = new HoaDon();
            newHD.MAHOADON = txbMaHD.Text;
            newHD.TENKHACHHANG = txbTenKH.Text;
            newHD.NGAYLAP = dtpNgayLap.Text;
            int S = 0;
            foreach (ListViewItem item in lsvChiTietHoaDon.Items)
            {
                S += int.Parse(item.SubItems[4].Text);
            }
            newHD.TONGTIEN = S;
            BLLHoaDon.UpdateHoaDon(newHD);
            FrmHoaDon_Load(sender, e);
        }
        private void ActiveSachPanel(bool trueFalse)
        {
            lsvSach.Enabled = trueFalse;
            nbudSoLuong.Enabled = trueFalse;

        }
        private void IsActiveCTHDPanel(bool isActive)
        {
            btnAddCTHD.Enabled = isActive;
            btnSaveCTHD.Enabled = isActive;
            btnUpdateCTHD.Enabled = isActive;
            btnDeleteCTHD.Enabled = isActive;
        }

        private void lsvChiTietHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            if (lsvHoaDon.SelectedItems.Count <= 0) return;
            BLLChiTietHoaDon.DeleteChiTietHoaDon(lsvHoaDon.SelectedItems[0].SubItems[0].Text);
            BLLHoaDon.DeleteHoaDon(lsvHoaDon.SelectedItems[0].SubItems[0].Text);
            LoadDataHoaDon(BLLHoaDon.GetDataHoaDon());
            FrmHoaDon_Load(sender, e);
        }

        private void btnLuuHD_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txbMaHD.Text != string.Empty && txbTenKH.Text != string.Empty)
            {
                if (!BLLHoaDon.Check(txbMaHD.Text))
                {
                    btnSaveCTHD.Enabled = false;
                    txbMaHD.Enabled = false;
                    txbTenKH.Enabled = false;
                    dtpNgayLap.Enabled = false;
                    HoaDon newHD = new HoaDon();
                    newHD.MAHOADON = txbMaHD.Text;
                    newHD.TENKHACHHANG = txbTenKH.Text;
                    newHD.NGAYLAP = dtpNgayLap.Text;
                    int S = 0;
                    foreach (ListViewItem item in lsvChiTietHoaDon.Items)
                    {
                        S += int.Parse(item.SubItems[4].Text);
                    }
                    newHD.TONGTIEN = S;
                    BLLHoaDon.AddHoaDon(newHD);

                    AddCTHD();
                    //EditChiTietHoaDonData(txbMaHD.Text);
                    FrmHoaDon_Load(sender, e);
                }
                else MessageBox.Show("Mã hóa đơn đã tồn tại !!!");
            }
            else MessageBox.Show("Vui lòng điền đầy đủ thông tin !!!");
        }

        private void btnDeleteCTHD_Click(object sender, EventArgs e)
        {
            if (lsvChiTietHoaDon.SelectedItems.Count <= 0) return;
            ListViewItem item = lsvChiTietHoaDon.SelectedItems[0];
            lsvChiTietHoaDon.Items.Remove(item);
            //BLLChiTietHoaDon.DeleteChiTietHoaDon(item.Text, item.SubItems[1].Text);
        }
        private void EditChiTietHoaDonData(string maHD)
        {
            BLLChiTietHoaDon.DeleteChiTietHoaDon(maHD);
            AddCTHD();
        }
        private void AddCTHD()
        {
            foreach (ListViewItem item in lsvChiTietHoaDon.Items)
            {
                ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon();
                chiTietHoaDon.MAHOADON = txbMaHD.Text;
                chiTietHoaDon.MASACH = item.SubItems[1].Text;
                chiTietHoaDon.TENSACH = item.SubItems[2].Text;
                chiTietHoaDon.SOLUONG = int.Parse(item.SubItems[2].Text);
                chiTietHoaDon.GIATIEN = int.Parse(item.SubItems[3].Text);
                chiTietHoaDon.THANHTIEN = int.Parse(item.SubItems[4].Text);
                BLLChiTietHoaDon.AddChiTietHoaDon(chiTietHoaDon);
            }
        }

        private void btnUpdateCTHD_Click(object sender, EventArgs e)
        {
            if (lsvChiTietHoaDon.SelectedItems.Count <= 0) return;
            ListViewItem cthdItem = lsvChiTietHoaDon.SelectedItems[0];
            ListViewItem selectItemSach = new ListViewItem();
            foreach (ListViewItem item in lsvSach.Items)
            {
                if (item.SubItems[0].Text == cthdItem.SubItems[1].Text)
                {
                    selectItemSach = item;
                    nbudSoLuong.Value = int.Parse(cthdItem.SubItems[2].Text);
                }
            }
            lsvChiTietHoaDon.SelectedItems[0].Selected = false;
            lsvChiTietHoaDon.Items.Remove(cthdItem);
            selectItemSach.Selected = true;
        }
    }
}
