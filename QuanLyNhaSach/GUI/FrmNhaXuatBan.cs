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

namespace QuanLyNhaSach
{
    public partial class FrmNhaXuatBan : Form
    {
        public FrmNhaXuatBan()
        {
            InitializeComponent();
        }

        BLLNhaXuatBan BLLNhaXuatBan = new BLLNhaXuatBan();
        bool add = false;

        private void FrmNhaXuatBan_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = BLLNhaXuatBan.GetDataNhaXuatBan();

            lsvNXB.Clear();
            lsvNXB.Items.Clear();
            lsvNXB.View = View.Details;
            lsvNXB.Columns.Add("MÃ NXB", 200);
            lsvNXB.Columns.Add("TÊN NXB", 300);
            lsvNXB.GridLines = true;
            lsvNXB.FullRowSelect = true;

            int i = 0;
            foreach (DataRow row in dt.Rows)
            {
                //Bỏ qua NXB mặc định MANXB == "NXB000"
                if (row["MANXB"].ToString().Trim() == "NXB000".Trim()) continue;

                this.lsvNXB.Items.Add(row["MANXB"].ToString());
                this.lsvNXB.Items[i].SubItems.Add(row["TENNHAXUATBAN"].ToString());
                i++;
            }
        }

        private void lsvNXB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvNXB.SelectedItems.Count > 0)
            {
                ListViewItem item = lsvNXB.SelectedItems[0];
                txtMaNXB.Text = item.Text;
                txtTenNXB.Text = item.SubItems[1].Text;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            add = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;

            txtMaNXB.Enabled = true;
            txtMaNXB.Clear();
            txtTenNXB.Clear();
            txtMaNXB.Focus();

            lsvNXB.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtMaNXB.Text != String.Empty)
            {
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Enabled = true;

                txtMaNXB.Enabled = false;
                txtTenNXB.Focus();
                lsvNXB.Enabled = false;
            }
            else
                MessageBox.Show("Vui lòng chọn nhà xuất bản muốn sửa!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMaNXB.Text != String.Empty)
            {
                if (MessageBox.Show("Bạn chắc chắc muốn xóa nhà xuất bản mã " + txtMaNXB.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    NhaXuatBan nxb = new NhaXuatBan(txtMaNXB.Text, txtTenNXB.Text);
                    if (BLLNhaXuatBan.DeleteNhaXuatBan(nxb))
                    {
                        FrmNhaXuatBan_Load(sender, e);
                        txtMaNXB.Clear();
                        txtTenNXB.Clear();
                    }

                }
            }
            else
                MessageBox.Show("Vui lòng chọn nhà xuất bản muốn xóa!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMaNXB.Text != String.Empty && txtTenNXB.Text != String.Empty)
            {
                bool check = false;
                NhaXuatBan nxb = new NhaXuatBan(txtMaNXB.Text, txtTenNXB.Text);
                if (add)
                {
                    bool checkMaNXB = true;
                    foreach (ListViewItem item in lsvNXB.Items)
                    {
                        if (item.Text.Trim() == txtMaNXB.Text.Trim())
                        {
                            MessageBox.Show("Mã tác giả đã bị trùng!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            checkMaNXB = false;
                            break;
                        }
                    }
                    if (checkMaNXB)
                        check = BLLNhaXuatBan.AddNhaXuatBan(nxb);
                }
                else
                {
                    check = BLLNhaXuatBan.UpdateNhaXuatBan(nxb);
                }

                if (check)
                {
                    add = false;
                    btnAdd.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnSave.Enabled = false;

                    txtMaNXB.Enabled = false;
                    txtMaNXB.Clear();
                    txtTenNXB.Clear();
                    lsvNXB.Enabled = true;
                    FrmNhaXuatBan_Load(sender, e);
                }
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắc muốn thoát!!!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
