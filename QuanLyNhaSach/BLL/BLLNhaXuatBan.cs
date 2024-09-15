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
    internal class BLLNhaXuatBan
    {
        DataAccessLayer DAL = new DataAccessLayer();

        public DataTable GetDataNhaXuatBan()
        {
            string query = "select * from NHAXUATBAN";
            return DAL.GetTable(query);
        }

        public bool AddNhaXuatBan(NhaXuatBan nxb)
        {
            string query = $"insert into NHAXUATBAN values ('{nxb.MANXB}', '{nxb.TENNHAXUATBAN}')";
            if (DAL.RunQuery(query))
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
            if (DAL.RunQuery(query))
            {
                MessageBox.Show("Cập nhật thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
                return false;
        }

        public bool DeleteNhaXuatBan(NhaXuatBan nxb)
        {
            //Update NXB = Default
            string query = $"update SACH SET MANXB = 'NXB000' where MANXB = '{nxb.MANXB}'";
            DAL.RunQuery(query);

            query = $"delete from NHAXUATBAN where MANXB = '{nxb.MANXB}'";
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
