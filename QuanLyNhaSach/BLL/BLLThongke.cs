using QuanLyNhaSach.DLL;
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
        DataAccessPlayer DLLCon = new DataAccessPlayer();
        public DataTable GetDataThongKe(string tuNgay, string denNgay)
        {
            string query = $"select * from HOADON where NGAYLAP between {tuNgay} and {denNgay}";
            return DLLCon.GetTable(query);
        }
    }
}
