using QuanLyNhaSach.DLL;
using QuanLyNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.BLL
{
    internal class BLLChiTietHoaDon
    {
        DataAccessPlayer DLLCon = new DataAccessPlayer();
        public bool Check(string maHD)
        {
            string query = $"select count(*) from HOADON Where MAHOADON = '{maHD}'";
            DataTable dt = new DataTable();
            dt = DLLCon.GetTable(query);
            if (dt.Rows.Count > 0)
            {
                int count = (int)dt.Rows[0][0];
                // Do something with the count value
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public DataTable GetDataChiTietHoaDon(string maHD)
        {
            string query = $"select * from CHITIETHOADON where MAHOADON = '{maHD}'";
            return DLLCon.GetTable(query);
        }

        public bool AddChiTietHoaDon(ChiTietHoaDon cthd)
        {
            string query = $"insert into CHITIETHOADON values ('{cthd.MAHOADON}', '{cthd.MASACH}', {cthd.SOLUONG}, {cthd.GIATIEN}, {cthd.THANHTIEN})";
            return DLLCon.RunQuery(query);
        }

        public bool UpdateChiTietHoaDon(ChiTietHoaDon cthd)
        {
            string query = $"update CHITIETHOADON set SOLUONG = '{cthd.SOLUONG}', THANHTIEN = '{cthd.THANHTIEN}' where MAHOADON = '{cthd.MAHOADON}' AND MASACH = '{cthd.MASACH}'";
            return DLLCon.RunQuery(query);
        }

        public bool DeleteChiTietHoaDon(string maHD, string maSach)
        {
            string query = $"delete from CHITIETHOADON where MAHOADON = '{maHD}' AND MASACH = '{maSach}'";
            return DLLCon.RunQuery(query);
        }
        public bool DeleteChiTietHoaDon(string maHD)
        {
            string query = $"delete from CHITIETHOADON where MAHOADON = '{maHD}'";
            return DLLCon.RunQuery(query);
        }
    }
}
