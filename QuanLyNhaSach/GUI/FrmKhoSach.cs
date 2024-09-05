using QuanLyNhaSach.BLL;
using QuanLyNhaSach.DTO;
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
    public partial class FrmKhoSach : Form
    {
        public FrmKhoSach()
        {
            InitializeComponent();
        }

        BLLSach BLLSach = new BLLSach();
        BLLTacGia BLLTacGia = new BLLTacGia();
        BLLLoaiSach BLLLoaiSach = new BLLLoaiSach();
        BLLNhaXuatBan BLLNhaXuatBan = new BLLNhaXuatBan();
        bool add = false;

        private void FrmKhoSach_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = BLLSach.GetDataKhoSach();

            this.lsvSach.Clear();
            this.lsvSach.Items.Clear();
            this.lsvSach.View = View.Details;
            this.lsvSach.Columns.Add("MÃ SÁCH", 100);
            this.lsvSach.Columns.Add("TÊN SÁCH", 250);
            this.lsvSach.Columns.Add("SỐ LƯỢNG", 110);
            this.lsvSach.Columns.Add("TÁC GIẢ", 200);
            this.lsvSach.Columns.Add("LOẠI SÁCH", 150);
            this.lsvSach.Columns.Add("GIÁ NHẬP", 100);
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
                this.lsvSach.Items[i].SubItems.Add(row["GIANHAP"].ToString());
                this.lsvSach.Items[i].SubItems.Add(row["GIABAN"].ToString());
                this.lsvSach.Items[i].SubItems.Add(row["LANTAIBAN"].ToString());
                this.lsvSach.Items[i].SubItems.Add(row["TENNHAXUATBAN"].ToString());
                this.lsvSach.Items[i].SubItems.Add(row["NAMXUATBAN"].ToString());
                i++;
            }

            DataTable dtTG = new DataTable();
            dtTG = BLLTacGia.GetDataTacGia();
            cboTG.DataSource = dtTG;
            cboTG.DisplayMember = "TENTG";
            cboTG.ValueMember = "MATG";

            DataTable dtLS = new DataTable();
            dtLS = BLLLoaiSach.GetDataLoaiSach();
            cboLS.DataSource = dtLS;
            cboLS.DisplayMember = "TENLOAISACH";
            cboLS.ValueMember = "MALOAISACH";

            DataTable dtNXB = new DataTable();
            dtNXB = BLLNhaXuatBan.GetDataNhaXuatBan();
            cboNXB.DataSource = dtNXB;
            cboNXB.DisplayMember = "TENNHAXUATBAN";
            cboNXB.ValueMember = "MANXB";

            cboTG.Text = "";
            cboLS.Text = "";
            cboNXB.Text = "";
        }

        private void lsvSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvSach.SelectedItems.Count > 0)
            {
                ListViewItem item = lsvSach.SelectedItems[0];
                txtMaSach.Text = item.Text;
                txtTenSach.Text = item.SubItems[1].Text;
                txtSoLuong.Text = item.SubItems[2].Text;
                cboTG.Text = item.SubItems[3].Text; // tacgia
                cboLS.Text = item.SubItems[4].Text; // loaisach
                txtGiaNhap.Text = item.SubItems[5].Text;
                txtGiaBan.Text = item.SubItems[6].Text;
                txtLanTaiBan.Text = item.SubItems[7].Text;
                cboNXB.Text = item.SubItems[8].Text; // nxb
                txtNamXuatBan.Text = item.SubItems[9].Text;
            }
        }

        private void ClearTxt()
        {
            txtMaSach.Clear();
            txtTenSach.Clear();
            txtGiaNhap.Clear();
            txtGiaBan.Clear();
            txtLanTaiBan.Clear();
            txtNamXuatBan.Clear();
            txtSoLuong.Clear();

            cboTG.Text = "";
            cboLS.Text = "";
            cboNXB.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            add = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;

            ClearTxt();
            txtMaSach.Enabled = true;
            txtMaSach.Focus();

            lsvSach.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text != String.Empty)
            {
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Enabled = true;

                txtMaSach.Enabled = false;
                txtTenSach.Focus();

                lsvSach.Enabled = false;
            }
            else
                MessageBox.Show("Vui lòng chọn sách muốn sửa!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text != String.Empty)
            {
                if (MessageBox.Show("Bạn chắc chắc muốn xóa sách mã " + txtMaSach.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Sach s = new Sach(
                        txtMaSach.Text, 
                        txtTenSach.Text, 
                        Convert.ToInt32(txtSoLuong.Text),
                        cboTG.SelectedValue.ToString(), 
                        cboLS.SelectedValue.ToString(), 
                        Convert.ToInt32(txtGiaBan.Text), 
                        Convert.ToInt32(txtGiaNhap.Text), 
                        Convert.ToInt32(txtLanTaiBan.Text), 
                        cboNXB.SelectedValue.ToString(), 
                        Convert.ToInt32(txtNamXuatBan.Text));
                    if (BLLSach.DeleteSach(s))
                    {
                        FrmKhoSach_Load(sender, e);
                        ClearTxt();
                    }

                }
            }
            else
                MessageBox.Show("Vui lòng chọn sách muốn xóa!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text != String.Empty &&
                txtTenSach.Text != String.Empty &&
                cboTG.Text != String.Empty &&
                cboLS.Text != String.Empty &&
                cboNXB.Text != String.Empty &&
                txtGiaNhap.Text != String.Empty &&
                txtGiaBan.Text != String.Empty &&
                txtLanTaiBan.Text != String.Empty &&
                txtNamXuatBan.Text != String.Empty &&
                txtSoLuong.Text != String.Empty)
            {
                bool check = false;
                Sach s = new Sach(
                        txtMaSach.Text,
                        txtTenSach.Text,
                        Convert.ToInt32(txtSoLuong.Text),
                        cboTG.SelectedValue.ToString(),
                        cboLS.SelectedValue.ToString(),
                        Convert.ToInt32(txtGiaBan.Text),
                        Convert.ToInt32(txtGiaNhap.Text),
                        Convert.ToInt32(txtLanTaiBan.Text),
                        cboNXB.SelectedValue.ToString(),
                        Convert.ToInt32(txtNamXuatBan.Text));
                if (add)
                {
                    bool checkMaSach = true;
                    foreach (ListViewItem item in lsvSach.Items)
                    {
                        if (item.Text.Trim() == txtMaSach.Text.Trim())
                        {
                            MessageBox.Show("Mã sách đã bị trùng!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            checkMaSach = false;
                            break;
                        }
                    }
                    if (checkMaSach)
                        check = BLLSach.AddSach(s);
                }
                else
                {
                    check = BLLSach.UpdateSach(s);
                }

                if (check)
                {
                    add = false;
                    btnAdd.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnSave.Enabled = false;

                    txtMaSach.Enabled = false;

                    ClearTxt();
                    lsvSach.Enabled = true;
                    FrmKhoSach_Load(sender, e);
                }
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắc muốn thoát!!!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
