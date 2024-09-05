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
    public partial class FrmLoaiSach : Form
    {
        public FrmLoaiSach()
        {
            InitializeComponent();
        }

        BLLLoaiSach BLLLoaiSach = new BLLLoaiSach();
        bool add = false;

        private void FrmLoaiSach_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = BLLLoaiSach.GetDataLoaiSach();

            lsvLS.Clear();
            lsvLS.Items.Clear();
            lsvLS.View = View.Details;
            lsvLS.Columns.Add("MÃ LOẠI SÁCH", 200);
            lsvLS.Columns.Add("TÊN LOẠI SÁCH", 300);
            lsvLS.GridLines = true;
            lsvLS.FullRowSelect = true;

            int i = 0;
            foreach (DataRow row in dt.Rows)
            {
                this.lsvLS.Items.Add(row["MALOAISACH"].ToString());
                this.lsvLS.Items[i].SubItems.Add(row["TENLOAISACH"].ToString());
                i++;
            }
        }

        private void lsvLS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvLS.SelectedItems.Count > 0)
            {
                ListViewItem item = lsvLS.SelectedItems[0];
                txtMaLS.Text = item.Text;
                txtTenLS.Text = item.SubItems[1].Text;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            add = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;

            txtMaLS.Enabled = true;
            txtMaLS.Clear();
            txtTenLS.Clear();
            txtMaLS.Focus();

            lsvLS.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtMaLS.Text != String.Empty)
            {
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Enabled = true;

                txtMaLS.Enabled = false;
                txtTenLS.Focus();

                lsvLS.Enabled = false;
            }
            else
                MessageBox.Show("Vui lòng chọn loại sách muốn sửa!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMaLS.Text != String.Empty)
            {
                if (MessageBox.Show("Bạn chắc chắc muốn xóa loại sách mã " + txtMaLS.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    LoaiSach ls = new LoaiSach(txtMaLS.Text, txtTenLS.Text);
                    if (BLLLoaiSach.DeleteLoaiSach(ls))
                    {
                        FrmLoaiSach_Load(sender, e);
                        txtMaLS.Clear();
                        txtTenLS.Clear();
                    }

                }
            }
            else
                MessageBox.Show("Vui lòng chọn loại sách muốn xóa!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMaLS.Text != String.Empty && txtTenLS.Text != String.Empty)
            {
                bool check = false;
                LoaiSach ls = new LoaiSach(txtMaLS.Text, txtTenLS.Text);
                if (add)
                {
                    bool checkMaLS = true;
                    foreach (ListViewItem item in lsvLS.Items)
                    {
                        if (item.Text.Trim() == txtMaLS.Text.Trim())
                        {
                            MessageBox.Show("Mã loại sách đã bị trùng!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            checkMaLS = false;
                            break;
                        }
                    }
                    if (checkMaLS)
                        check = BLLLoaiSach.AddLoaiSach(ls);
                }
                else
                {
                    check = BLLLoaiSach.UpdateLoaiSach(ls);
                }

                if (check)
                {
                    add = false;
                    btnAdd.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnSave.Enabled = false;

                    txtMaLS.Enabled = false;
                    txtMaLS.Clear();
                    txtTenLS.Clear();
                    lsvLS.Enabled = true;
                    FrmLoaiSach_Load(sender, e);
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
