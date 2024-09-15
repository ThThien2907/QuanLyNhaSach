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
    public class BLLSach
    {
        DataAccessLayer DAL = new DataAccessLayer();
        public DataTable GetDataSach()
        {
            //string query = "select * from Sach";
            string query = "SELECT MASACH, SOLUONG, TENSACH, TENTG, TENLOAISACH, GIABAN, LANTAIBAN, TENNHAXUATBAN, NAMXUATBAN " +
                "FROM SACH s " +
                "LEFT JOIN TACGIA t ON s.MATG = t.MATG " +
                "LEFT JOIN LOAISACH ls ON s.MALOAISACH = ls.MALOAISACH " +
                "LEFT JOIN NHAXUATBAN nxb ON s.MANXB = nxb.MANXB";
            return DAL.GetTable(query);
        }

        public DataTable GetDataKhoSach()
        {
            string query = "SELECT MASACH, SOLUONG, TENSACH, TENTG, TENLOAISACH, GIANHAP, GIABAN, LANTAIBAN, TENNHAXUATBAN, NAMXUATBAN " +
                "FROM SACH s " +
                "LEFT JOIN TACGIA t ON s.MATG = t.MATG " +
                "LEFT JOIN LOAISACH ls ON s.MALOAISACH = ls.MALOAISACH " +
                "LEFT JOIN NHAXUATBAN nxb ON s.MANXB = nxb.MANXB";
            return DAL.GetTable(query);
        }
        
        public bool AddSach(Sach s)
        {
            string query = $"insert into SACH values ('{s.MASACH}','{s.SOLUONG}', '{s.TENSACH}', '{s.MATG}', '{s.MALOAISACH}', '{s.GIABAN}', '{s.GIANHAP}', '{s.LANTAIBAN}', '{s.MANXB}', '{s.NAMXUATBAN}')";
            if (DAL.RunQuery(query))
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
            if (DAL.RunQuery(query))
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
            if (DAL.RunQuery(query))
            {
                MessageBox.Show("Xóa thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
                return false;
        }

        public string GetTenSach(string maSach)
        {
            string query = $"select TENSACH from SACH where MASACH = '{maSach}'";
            DataSet ds = DAL.GetDataSet(query);
            string tenSach = "";
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];
                tenSach = row["TENSACH"].ToString();
            }
            return tenSach;
        }

        public int GetSoLuongSach(string maSach)
        {
            string query = $"select SOLUONG from SACH where MASACH = '{maSach}'";
            DataSet ds = DAL.GetDataSet(query);
            int soLuong = 0;
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];
                soLuong = int.Parse(row["SOLUONG"].ToString());
            }
            return soLuong;
        }

        public bool UpdateSoLuongSach(string maSach, int soLuong)
        {
            string query = $"update SACH set SOLUONG = '{soLuong}' where MASACH = '{maSach}'";
            return DAL.RunQuery(query);
        }
    }
}
