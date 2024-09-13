using QuanLyNhaSach.DAL;
using QuanLyNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.BLL
{
    internal class BLLHoaDon
    {
        DataAccessLayer DAL = new DataAccessLayer();
        public bool Check(string maHD)
        {
            string query = $"select count(*) from HOADON Where MAHOADON = '{maHD}'";
            DataTable dt = new DataTable();
            dt = DAL.GetTable(query);
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
        public DataTable GetDataHoaDon()
        {
            string query = "select * from HOADON";
            return DAL.GetTable(query);
        }
        public bool AddHoaDon(HoaDon hd)
        {
            string query = $"insert into HOADON values ('{hd.MAHOADON}', '{hd.TENKHACHHANG}', '{hd.NGAYLAP}', '{hd.TONGTIEN}')";
            return DAL.RunQuery(query);
        }
        public bool UpdateHoaDon(HoaDon hd)
        {
            string query = $"update HOADON set TENKHACHHANG = '{hd.TENKHACHHANG}', NGAYLAP = '{hd.NGAYLAP}', TONGTIEN = '{hd.TONGTIEN}' where MAHOADON = '{hd.MAHOADON}'";
            return DAL.RunQuery(query);
        }
        public bool DeleteHoaDon(string maHd)
        {
            string query = $"delete from HOADON where MAHOADON = '{maHd}'";
            return DAL.RunQuery(query);
        }
    }
}
