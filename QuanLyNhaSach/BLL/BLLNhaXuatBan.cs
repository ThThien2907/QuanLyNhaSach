using QuanLyNhaSach.DLL;
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
    internal class BLLNhaXuatBan
    {
        DataAccessPlayer DLLCon = new DataAccessPlayer();

        public DataTable GetDataNhaXuatBan()
        {
            string query = "select * from NHAXUATBAN";
            return DLLCon.GetTable(query);
        }

        public bool AddNhaXuatBan(NhaXuatBan nxb)
        {
            string query = $"insert into NHAXUATBAN values ('{nxb.MANXB}', '{nxb.TENNHAXUATBAN}')";
            if (DLLCon.RunQuery(query))
            {
                MessageBox.Show("Thêm thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
                return false;
        }

        public bool UpdateNhaXuatBan(NhaXuatBan nxb)
        {
            string query = $"update NHAXUATBAN set TENNHAXUATBAN = '{nxb.TENNHAXUATBAN}' where MANXB = '{nxb.MANXB}'";
            if (DLLCon.RunQuery(query))
            {
                MessageBox.Show("Cập nhật thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
                return false;
        }

        public bool DeleteNhaXuatBan(NhaXuatBan nxb)
        {
            string query = $"delete from NHAXUATBAN where MANXB = '{nxb.MANXB}'";
            if (DLLCon.RunQuery(query))
            {
                MessageBox.Show("Xóa thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
                return false;
        }
    }
}
