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
    internal class BLLLoaiSach
    {
        DataAccessLayer DAL = new DataAccessLayer();

        public DataTable GetDataLoaiSach()
        {
            string query = "select * from LOAISACH";
            return DAL.GetTable(query);
        }

        public bool AddLoaiSach(LoaiSach ls)
        {
            string query = $"insert into LOAISACH values ('{ls.MALOAISACH}', '{ls.TENLOAISACH}')";
            if (DAL.RunQuery(query))
            {
                MessageBox.Show("Thêm thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
                return false;
        }

        public bool UpdateLoaiSach(LoaiSach ls)
        {
            string query = $"update LOAISACH set TENLOAISACH = '{ls.TENLOAISACH}' where MALOAISACH = '{ls.MALOAISACH}'";
            if (DAL.RunQuery(query))
            {
                MessageBox.Show("Cập nhật thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
                return false;
        }

        public bool DeleteLoaiSach(LoaiSach ls)
        {
            //Update LoaiSach = Default
            string query = $"update SACH SET MALOAISACH = 'LS000' where MALOAISACH = '{ls.MALOAISACH}'";
            DAL.RunQuery(query);

            query = $"delete from LOAISACH where MALOAISACH = '{ls.MALOAISACH}'";
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
