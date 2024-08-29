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
            //string query = "select * from Sach";
            string query = "SELECT MASACH, SOLUONG, TENSACH, TENTG, TENLOAISACH, GIABAN, LANTAIBAN, TENNHAXUATBAN, NAMXUATBAN " +
                "FROM SACH s " +
                "LEFT JOIN TACGIA t ON s.MATG = t.MATG " +
                "LEFT JOIN LOAISACH ls ON s.MALOAISACH = ls.MALOAISACH " +
                "LEFT JOIN NHAXUATBAN nxb ON s.MANXB = nxb.MANXB";
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
