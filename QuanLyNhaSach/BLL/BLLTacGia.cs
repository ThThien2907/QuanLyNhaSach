using QuanLyNhaSach.DAL;
using QuanLyNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach.BLL
{
    internal class BLLTacGia
    {
        DataAccessLayer DAL = new DataAccessLayer();

        public DataTable GetDataTacGia()
        {
            string query = "select * from TACGIA";
            return DAL.GetTable(query);
        }

        public bool AddTacGia(TacGia tg)
        {
            string query = $"insert into TACGIA values ('{tg.MATG}', '{tg.TENTG}')";
            if (DAL.RunQuery(query))
            {
                MessageBox.Show("Thêm thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
                return false;
        }

        public bool UpdateTacGia(TacGia tg)
        {
            string query = $"update TACGIA set TENTG = '{tg.TENTG}' where MATG = '{tg.MATG}'";
            if (DAL.RunQuery(query))
            {
                MessageBox.Show("Cập nhật thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
                return false;
        }

        public bool DeleteTacGia(TacGia tg)
        {
            string query = $"delete from TACGIA where MATG = '{tg.MATG}'";
            if (DAL.RunQuery(query))
            {
                MessageBox.Show("Xóa thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
                return false;
        }
    }
}
