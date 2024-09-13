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
        private bool isUpdate = false;
        private bool isAdd = false;
        private void FrmHoaDon_Load(object sender, EventArgs e)
        {
            CreateLsvHoaHon();
            CreateLsvSach();
            CreateLsvChiTietHD();

            LoadDataHoaDon();
            LoadDataSach();

            SetDefault();
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
            this.lsvSach.Columns.Add("SỐ LƯỢNG", 90);
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
        private void LoadDataHoaDon()
        {
            DataTable dataTable = new DataTable();
            dataTable = BLLHoaDon.GetDataHoaDon();
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
        private void LoadDataSach()
        {
            DataTable dataTable = new DataTable();
            dataTable = BLLSach.GetDataSach();
            int i = 0;
            lsvSach.Items.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                this.lsvSach.Items.Add(row["MASACH"].ToString());
                this.lsvSach.Items[i].SubItems.Add(row["TENSACH"].ToString());
                this.lsvSach.Items[i].SubItems.Add(row["SOLUONG"].ToString());
                this.lsvSach.Items[i].SubItems.Add(row["GIABAN"].ToString());
                this.lsvSach.Items[i].SubItems.Add(row["TENTG"].ToString());
                this.lsvSach.Items[i].SubItems.Add(row["TENLOAISACH"].ToString());
                this.lsvSach.Items[i].SubItems.Add(row["TENNHAXUATBAN"].ToString());
                i++;
            }
        }
        private void LoadDataChiTietHoaDon()
        {
            DataTable dataTable = new DataTable();
            dataTable = BLLChiTietHoaDon.GetDataChiTietHoaDon(txbMaHD.Text);
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
            if (lsvHoaDon.SelectedItems.Count <= 0)
            {
                btnCTHD.Enabled = false;
                btnDeleteHD.Enabled = false;
            }
            else
            {
                btnCTHD.Enabled = true;
                btnDeleteHD.Enabled = true;
                ListViewItem item = lsvHoaDon.SelectedItems[0];
                txbMaHD.Text = lsvHoaDon.SelectedItems[0].Text;
                txbTenKH.Text = lsvHoaDon.SelectedItems[0].SubItems[1].Text;
                dtpNgayLap.Value = DateTime.Parse(lsvHoaDon.SelectedItems[0].SubItems[2].Text);
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isAdd)
            {
                if (nbudSoLuong.Value > 0)
                {
                    if (lsvSach.SelectedItems.Count > 0)
                    {
                        ListViewItem itemSach = lsvSach.SelectedItems[0];
                        int soLuongSach = BLLSach.GetSoLuongSach(itemSach.Text);
                        if (soLuongSach < int.Parse(nbudSoLuong.Value.ToString()))
                        {
                            MessageBox.Show("Vượt quá số lượng sách trong kho!!!");
                        }
                        else
                        {
                            ListViewItem itemChiTietHD = new ListViewItem();

                            ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon();
                            chiTietHoaDon.MAHOADON = txbMaHD.Text;
                            chiTietHoaDon.MASACH = itemSach.Text;
                            chiTietHoaDon.SOLUONG = int.Parse(nbudSoLuong.Value.ToString());
                            chiTietHoaDon.GIATIEN = int.Parse(itemSach.SubItems[3].Text);
                            chiTietHoaDon.THANHTIEN = chiTietHoaDon.SOLUONG * chiTietHoaDon.GIATIEN;

                            bool checkSachTrongHD = false;

                            foreach (ListViewItem item in lsvChiTietHoaDon.Items)
                            {
                                if (itemSach.Text.Trim() == item.SubItems[1].Text.Trim())
                                {
                                    chiTietHoaDon.SOLUONG = int.Parse(item.SubItems[2].Text) + int.Parse(nbudSoLuong.Value.ToString());
                                    chiTietHoaDon.THANHTIEN = chiTietHoaDon.SOLUONG * chiTietHoaDon.GIATIEN;
                                    checkSachTrongHD = true;
                                    break;
                                }
                            }

                            if (checkSachTrongHD)
                            {
                                if (BLLChiTietHoaDon.UpdateChiTietHoaDon(chiTietHoaDon))
                                {
                                    BLLSach.UpdateSoLuongSach(itemSach.Text, soLuongSach - int.Parse(nbudSoLuong.Value.ToString()));
                                    LoadDataChiTietHoaDon();
                                    LoadDataSach();
                                    btnAddCTHD.Enabled = true;
                                    btnSaveCTHD.Enabled = false;

                                    ActiveSachPanel(false);
                                }
                            }
                            else
                            {
                                if (BLLChiTietHoaDon.AddChiTietHoaDon(chiTietHoaDon))
                                {
                                    BLLSach.UpdateSoLuongSach(itemSach.Text, soLuongSach - int.Parse(nbudSoLuong.Value.ToString()));
                                    LoadDataChiTietHoaDon();
                                    LoadDataSach();
                                    btnAddCTHD.Enabled = true;
                                    btnSaveCTHD.Enabled = false;

                                    ActiveSachPanel(false);
                                }

                            }
                        }
                    }
                    else MessageBox.Show("Vui lòng chọn sách !!!");
                }
                else MessageBox.Show("Vui lòng chọn số lượng !!!");
            }
            else if (isUpdate)
            {
                if (nbudSoLuong.Value > 0)
                {
                    if (lsvChiTietHoaDon.SelectedItems.Count <= 0) return;

                    ListViewItem cthdItem = lsvChiTietHoaDon.SelectedItems[0];

                    int soLuongSach = BLLSach.GetSoLuongSach(cthdItem.SubItems[1].Text);
                    int newSoLuong = int.Parse(nbudSoLuong.Value.ToString());
                    int oldSoLuong = int.Parse(cthdItem.SubItems[2].Text);

                    ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon();
                    chiTietHoaDon.MAHOADON = cthdItem.Text;
                    chiTietHoaDon.MASACH = cthdItem.SubItems[1].Text;
                    chiTietHoaDon.SOLUONG = int.Parse(nbudSoLuong.Value.ToString());
                    chiTietHoaDon.GIATIEN = int.Parse(cthdItem.SubItems[3].Text);
                    chiTietHoaDon.THANHTIEN = chiTietHoaDon.SOLUONG * chiTietHoaDon.GIATIEN;


                    if (newSoLuong > oldSoLuong)
                    {
                        if (soLuongSach >= newSoLuong - oldSoLuong)
                        {
                            if (BLLChiTietHoaDon.UpdateChiTietHoaDon(chiTietHoaDon))
                            {
                                BLLSach.UpdateSoLuongSach(cthdItem.SubItems[1].Text, soLuongSach - (newSoLuong - oldSoLuong));
                                LoadDataChiTietHoaDon();
                                LoadDataSach();
                                btnAddCTHD.Enabled = true;
                                btnUpdateCTHD.Enabled = false;
                                btnDeleteCTHD.Enabled = false;
                                btnSaveCTHD.Enabled = false;
                                lsvChiTietHoaDon.Enabled = true;

                                ActiveSachPanel(false);
                            }
                        }
                        else MessageBox.Show("Vượt quá số lượng sách trong kho!!!");
                    }
                    else
                    {
                        if (BLLChiTietHoaDon.UpdateChiTietHoaDon(chiTietHoaDon))
                        {
                            BLLSach.UpdateSoLuongSach(cthdItem.SubItems[1].Text, soLuongSach + (oldSoLuong - newSoLuong));
                            LoadDataChiTietHoaDon();
                            LoadDataSach();
                            btnAddCTHD.Enabled = true;
                            btnUpdateCTHD.Enabled = false;
                            btnDeleteCTHD.Enabled = false;
                            btnSaveCTHD.Enabled = false;
                            lsvChiTietHoaDon.Enabled = true;

                            ActiveSachPanel(false);
                        }
                    }
                }
                else MessageBox.Show("Vui lòng chọn số lượng !!!");
            }
        }
        private void ActiveSachPanel(bool trueFalse)
        {
            lsvSach.Enabled = trueFalse;
            nbudSoLuong.Enabled = trueFalse;
            nbudSoLuong.Value = 0;

        }

        private void SetDefault()
        {
            btnAddCTHD.Enabled = false;
            btnSaveCTHD.Enabled = false;
            btnUpdateCTHD.Enabled = false;
            btnDeleteCTHD.Enabled = false;

            btnCreateHD.Enabled = true;
            btnCTHD.Enabled = false;
            btnDeleteHD.Enabled = false;
            btnSaveHD.Enabled = false;
            btnConfirm.Enabled = false;

            txbMaHD.Clear();
            txbTenKH.Clear();

            lsvHoaDon.Enabled = true;
            lsvChiTietHoaDon.Enabled = false;
            ActiveSachPanel(false);
        }

        private void lsvChiTietHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvChiTietHoaDon.SelectedItems.Count > 0)
            {
                ListViewItem cthdItem = lsvChiTietHoaDon.SelectedItems[0];
                nbudSoLuong.Value = int.Parse(cthdItem.SubItems[2].Text);

                btnUpdateCTHD.Enabled = true;
                btnDeleteCTHD.Enabled = true;
            }
            else
            {
                nbudSoLuong.Value = 0;

                btnUpdateCTHD.Enabled = false;
                btnDeleteCTHD.Enabled = false;
            }
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            if (lsvHoaDon.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Bạn chắc chắc muốn xóa hóa đơn " + txbMaHD.Text + " ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    DataTable dataTable = new DataTable();
                    dataTable = BLLChiTietHoaDon.GetDataChiTietHoaDon(txbMaHD.Text);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        string maHD = row["MAHOADON"].ToString();
                        string maSach = row["MASACH"].ToString();
                        int soLuong = int.Parse(row["SOLUONG"].ToString());
                        int soLuongSachTrongKho = BLLSach.GetSoLuongSach(maSach);

                        if (BLLChiTietHoaDon.DeleteChiTietHoaDon(maHD, maSach))
                        {
                            BLLSach.UpdateSoLuongSach(maSach, soLuongSachTrongKho + soLuong);
                        }
                        else
                        {
                            MessageBox.Show("Lỗi !!!");
                            break;
                        }
                    }
                    BLLHoaDon.DeleteHoaDon(lsvHoaDon.SelectedItems[0].Text);
                    btnCTHD.Enabled = false;
                    btnDeleteHD.Enabled = false;
                    txbMaHD.Clear();
                    txbTenKH.Clear();
                    LoadDataHoaDon();
                    LoadDataSach();
                }
            }
        }


        private void btnDeleteCTHD_Click(object sender, EventArgs e)
        {
            if (lsvChiTietHoaDon.SelectedItems.Count > 0)
            {
                ListViewItem cthdItem = lsvChiTietHoaDon.SelectedItems[0];
                if (MessageBox.Show("Bạn chắc chắc muốn xóa sách " + cthdItem.SubItems[1].Text + " khỏi hóa đơn ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int soLuongSach = BLLSach.GetSoLuongSach(cthdItem.SubItems[1].Text);

                    if (BLLChiTietHoaDon.DeleteChiTietHoaDon(cthdItem.Text, cthdItem.SubItems[1].Text))
                    {
                        BLLSach.UpdateSoLuongSach(cthdItem.SubItems[1].Text, soLuongSach + int.Parse(cthdItem.SubItems[2].Text));
                        LoadDataChiTietHoaDon();
                        LoadDataSach();
                        btnAddCTHD.Enabled = true;
                        btnUpdateCTHD.Enabled = false;
                        btnDeleteCTHD.Enabled = false;
                    }
                }
            }
        }
        
        private void btnUpdateCTHD_Click(object sender, EventArgs e)
        {
            isAdd = false;
            isUpdate = true;
            btnSaveCTHD.Enabled = true;
            btnAddCTHD.Enabled = false;
            btnDeleteCTHD.Enabled = false;

            nbudSoLuong.Enabled = true;
            lsvChiTietHoaDon.Enabled = false;
        }

        private void btnCreateHD_Click(object sender, EventArgs e)
        {
            txbMaHD.Enabled = true;
            txbTenKH.Enabled = true;
            txbMaHD.Clear();
            txbTenKH.Clear();
            txbMaHD.Focus();
            dtpNgayLap.Value = DateTime.Now;

            lsvHoaDon.Enabled = false;
            btnConfirm.Enabled = true;
            btnCTHD.Enabled = false;
            btnDeleteHD.Enabled = false;
        }

        private void btnCTHD_Click(object sender, EventArgs e)
        {
            if (lsvHoaDon.SelectedItems.Count > 0)
            {
                dtpNgayLap.Value = DateTime.Now;
                btnCreateHD.Enabled = false;
                btnDeleteHD.Enabled = false;
                btnSaveHD.Enabled = true;
                lsvChiTietHoaDon.Enabled = true;
                lsvHoaDon.Enabled = false;

                btnAddCTHD.Enabled = true;

                LoadDataChiTietHoaDon();

            }
        }

        private void btnAddCTHD_Click(object sender, EventArgs e)
        {
            isAdd = true;
            isUpdate = false;
            btnUpdateCTHD.Enabled = false;
            btnDeleteCTHD.Enabled = false;
            btnSaveCTHD.Enabled = true;

            lsvSach.Enabled = true;
            nbudSoLuong.Enabled = true;
            nbudSoLuong.Value = 0;

        }

        private void btnSaveHD_Click(object sender, EventArgs e)
        {
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
            if (BLLHoaDon.UpdateHoaDon(newHD))
            {
                FrmHoaDon_Load(sender, e);
                SetDefault();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txbMaHD.Text != string.Empty && txbTenKH.Text != string.Empty)
            {
                if (!BLLHoaDon.Check(txbMaHD.Text))
                {
                    HoaDon newHD = new HoaDon();
                    newHD.MAHOADON = txbMaHD.Text;
                    newHD.TENKHACHHANG = txbTenKH.Text;
                    newHD.NGAYLAP = dtpNgayLap.Text;
                    newHD.TONGTIEN = 0;
                    if (BLLHoaDon.AddHoaDon(newHD))
                    {
                        btnCreateHD.Enabled = false;
                        btnConfirm.Enabled = false;

                        txbMaHD.Enabled = false;
                        txbTenKH.Enabled = false;
                        dtpNgayLap.Enabled = false;

                        btnAddCTHD.Enabled = true;
                        btnSaveCTHD.Enabled = false;
                        btnSaveHD.Enabled = true;

                        lsvChiTietHoaDon.Enabled = true;
                        lsvChiTietHoaDon.Items.Clear();
                    }
                }
                else MessageBox.Show("Mã hóa đơn đã tồn tại !!!");
            }
            else MessageBox.Show("Vui lòng điền đầy đủ thông tin !!!");
        }
    }
}
