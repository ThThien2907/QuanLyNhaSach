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
    internal class BLLTacGia
    {
        DataAccessPlayer DLLCon = new DataAccessPlayer();

        public DataTable GetDataTacGia()
        {
            string query = "select * from TACGIA";
            return DLLCon.GetTable(query);
        }

        public bool AddTacGia(TacGia tg)
        {
            string query = $"insert into TACGIA values ('{tg.MATG}', '{tg.TENTG}')";
            return DLLCon.RunQuery(query);
        }

        public bool UpdateTacGia(TacGia tg)
        {
            string query = $"update TACGIA set TENTG = '{tg.TENTG}' where MATG = '{tg.MATG}'";
            return DLLCon.RunQuery(query);
        }

        public bool DeleteTacGia(TacGia tg)
        {
            string query = $"delete from TACGIA where MATG = '{tg.MATG}'";
            return DLLCon.RunQuery(query);
        }
    }
}
