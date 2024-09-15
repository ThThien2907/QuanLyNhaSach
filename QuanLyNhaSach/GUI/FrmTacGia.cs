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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QuanLyNhaSach
{
    public partial class FrmTacGia : Form
    {
        public FrmTacGia()
        {
            InitializeComponent();
        }

        BLLTacGia BLLTacGia = new BLLTacGia();
        bool add = false;



        private void FrmTacGia_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = BLLTacGia.GetDataTacGia();

            lsvTG.Clear();
            lsvTG.Items.Clear();
            lsvTG.View = View.Details;
            lsvTG.Columns.Add("MÃ TÁC GIẢ", 200);
            lsvTG.Columns.Add("TÊN TÁC GIẢ", 300);
            lsvTG.GridLines = true;
            lsvTG.FullRowSelect = true;

            int i = 0;
            foreach (DataRow row in dt.Rows)
            {
                //Bỏ qua Tác giả mặc định MATG == "TG000"
                if (row["MATG"].ToString().Trim() == "TG000".Trim()) continue;

                this.lsvTG.Items.Add(row["MATG"].ToString());
                this.lsvTG.Items[i].SubItems.Add(row["TENTG"].ToString());
                i++;
            }

        }

        private void lsvTG_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvTG.SelectedItems.Count > 0)
            {
                ListViewItem item = lsvTG.SelectedItems[0];
                txtMaTG.Text = item.Text;
                txtTenTG.Text = item.SubItems[1].Text;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            add = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;

            txtMaTG.Enabled = true;
            txtMaTG.Clear();
            txtTenTG.Clear();
            txtMaTG.Focus();

            lsvTG.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtMaTG.Text != String.Empty)
            {
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Enabled = true;
                txtMaTG.Enabled = false;
                txtTenTG.Focus();
                lsvTG.Enabled = false;
            }
            else
                MessageBox.Show("Vui lòng chọn tác giả muốn sửa!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMaTG.Text != String.Empty)
            {
                if (MessageBox.Show("Bạn chắc chắc muốn xóa tác giả mã " + txtMaTG.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    TacGia tg = new TacGia(txtMaTG.Text, txtTenTG.Text);
                    if (BLLTacGia.DeleteTacGia(tg))
                    {
                        FrmTacGia_Load(sender, e);
                        txtMaTG.Clear();
                        txtTenTG.Clear();
                    }

                }
            }
            else
                MessageBox.Show("Vui lòng chọn tác giả muốn xóa!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMaTG.Text != String.Empty && txtTenTG.Text != String.Empty)
            {
                bool check = false;
                TacGia tg = new TacGia(txtMaTG.Text, txtTenTG.Text);
                if (add)
                {
                    bool checkMaTG = true;
                    foreach (ListViewItem item in lsvTG.Items)
                    {
                        if (item.Text.Trim() == txtMaTG.Text.Trim())
                        {
                            MessageBox.Show("Mã tác giả đã bị trùng!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            checkMaTG = false;
                            break;
                        }
                    }
                    if (checkMaTG)
                        check = BLLTacGia.AddTacGia(tg);
                }
                else
                {
                    check = BLLTacGia.UpdateTacGia(tg);
                } 

                if (check)
                {
                    add = false;
                    btnAdd.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnSave.Enabled = false;
                    txtMaTG.Enabled = false;
                    txtMaTG.Clear();
                    txtTenTG.Clear();
                    lsvTG.Enabled = true;
                    FrmTacGia_Load(sender, e);
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
