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
    public class BLLThongke
    {
        DataAccessLayer DAL = new DataAccessLayer();
        public DataTable GetDataThongKe(string tuNgay, string denNgay)
        {
            string query = $"select * from HOADON where NGAYLAP between '{tuNgay}' and '{denNgay}'";
            return DAL.GetTable(query);
        }

        public string GetSoLuongKhach(string timeNow)
        {
            string query = $"Select Count(MAHOADON) From HOADON Where NGAYLAP = '{timeNow}'";
            
            DataTable dt = DAL.GetTable(query);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0][0].ToString();
            }
            return "0";
        }
        public string GetDoanhThu(string timeNow)
        {
            string query = $"Select SUM(TONGTIEN) AS [DOANHTHU] From HOADON Where NGAYLAP = '{timeNow}'";
            DataTable dt = DAL.GetTable(query);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0][0].ToString();
            }
            return "0";
        }
    }
}
