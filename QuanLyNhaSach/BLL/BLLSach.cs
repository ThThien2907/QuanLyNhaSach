using QuanLyNhaSach.DLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.BLL
{
    public class BLLSach
    {
        DataAccessPlayer DLLCon = new DataAccessPlayer();
        public DataTable GetDataSach()
        {
            string query = "select * from Sach";
            return DLLCon.GetTable(query);
        }

        //public bool AddPhongBan(PhongBan pb)
        //{
        //    string query = "insert into PhongBan values('" + pb.MaPB + "', '" + pb.TenPB + "')";
        //    return DLLCon.RunQuery(query);
        //}

        //public bool UpdatePhongBan(PhongBan pb)
        //{
        //    string query = "update PhongBan set TenPB = '" + pb.TenPB + "' where MaPB = '" + pb.MaPB + "'";
        //    return DLLCon.RunQuery(query);
        //}

        //public bool DeletePhongBan(PhongBan pb)
        //{
        //    string query = "delete from PhongBan where MaPB = '" + pb.MaPB + "'";
        //    return DLLCon.RunQuery(query);
        //}
    }
}
