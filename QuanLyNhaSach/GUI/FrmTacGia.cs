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


        private void LoadData()
        {
            
        }

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

            txtMaTG.Clear();
            txtTenTG.Clear();
            txtMaTG.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            txtMaTG.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            TacGia tg = new TacGia(txtMaTG.Text, txtTenTG.Text);
            if (BLLTacGia.DeleteTacGia(tg))
            {
                MessageBox.Show("Thành công !!", "Thông báo", MessageBoxButtons.OK);
                FrmTacGia_Load(sender, e);
            }
            else
                MessageBox.Show("Thất bại !!", "Thông báo", MessageBoxButtons.OK);
            txtMaTG.Clear();
            txtTenTG.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool check = false;
            TacGia tg = new TacGia(txtMaTG.Text, txtTenTG.Text);
            if (add)
            {
                check = BLLTacGia.AddTacGia(tg);
            }
            else
            {
                check = BLLTacGia.UpdateTacGia(tg);
            } 

            if (check)
            {
                MessageBox.Show("Thành công !!", "Thông báo", MessageBoxButtons.OK);
                FrmTacGia_Load(sender, e);
            }
            else
                MessageBox.Show("Thất bại !!", "Thông báo", MessageBoxButtons.OK);
            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
            txtMaTG.Enabled=true;
            txtMaTG.Clear();
            txtTenTG.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
