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
    public class BLLSach
    {
        DataAccessPlayer DLLCon = new DataAccessPlayer();
        public DataTable GetDataSach()
        {
            //string query = "select * from Sach";
            string query = "SELECT MASACH, SOLUONG, TENSACH, TENTG, TENLOAISACH, GIABAN, LANTAIBAN, TENNHAXUATBAN, NAMXUATBAN " +
                "FROM SACH s " +
                "LEFT JOIN TACGIA t ON s.MATG = t.MATG " +
                "LEFT JOIN LOAISACH ls ON s.MALOAISACH = ls.MALOAISACH " +
                "LEFT JOIN NHAXUATBAN nxb ON s.MANXB = nxb.MANXB";
            return DLLCon.GetTable(query);
        }

        public DataTable GetDataKhoSach()
        {
            string query = "SELECT MASACH, SOLUONG, TENSACH, TENTG, TENLOAISACH, GIANHAP, GIABAN, LANTAIBAN, TENNHAXUATBAN, NAMXUATBAN " +
                "FROM SACH s " +
                "LEFT JOIN TACGIA t ON s.MATG = t.MATG " +
                "LEFT JOIN LOAISACH ls ON s.MALOAISACH = ls.MALOAISACH " +
                "LEFT JOIN NHAXUATBAN nxb ON s.MANXB = nxb.MANXB";
            return DLLCon.GetTable(query);
        }
        
        public bool AddSach(Sach s)
        {
            string query = $"insert into SACH values ('{s.MASACH}','{s.SOLUONG}', '{s.TENSACH}', '{s.MATG}', '{s.MALOAISACH}', '{s.GIABAN}', '{s.GIANHAP}', '{s.LANTAIBAN}', '{s.MANXB}', '{s.NAMXUATBAN}')";
            if (DLLCon.RunQuery(query))
            {
                MessageBox.Show("Thêm thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
                return false;
        }

        public bool UpdateSach(Sach s)
        {
            string query = $"update SACH set TENSACH = '{s.TENSACH}', SOLUONG = '{s.SOLUONG}', MATG = '{s.MATG}', MALOAISACH = '{s.MALOAISACH}', GIABAN = '{s.GIABAN}', GIANHAP = '{s.GIANHAP}', LANTAIBAN = '{s.LANTAIBAN}', MANXB = '{s.MANXB}', NAMXUATBAN = '{s.NAMXUATBAN}' where MASACH = '{s.MASACH}'";
            if (DLLCon.RunQuery(query))
            {
                MessageBox.Show("Cập nhật thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
                return false;
        }

        public bool DeleteSach(Sach s)
        {
            string query = $"delete from SACH where MASACH = '{s.MASACH}'";
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
