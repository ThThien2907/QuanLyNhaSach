using QuanLyNhaSach.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach.BLL
{
    internal class BLLTaiKhoan
    {
        DataAccessLayer DAL = new DataAccessLayer();
        public DataTable GetDataTaiKhoan()
        {
            string query = "select * from TaiKhoan";
            return DAL.GetTable(query);
        }
        public bool CheckUser(string userName, string password)
        {
            try
            {
                string query = $"select count(*) from TaiKhoan where USERNAME = '{userName}' AND PASS_WORD = '{password}'";
                DataTable taiKhoan = DAL.GetTable(query);
                if (taiKhoan.Rows.Count > 0)
                {
                    int count = (int)taiKhoan.Rows[0][0];
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
            catch (Exception ex)
            {
                MessageBox.Show("Loi " + ex.Message);
            }
            return false;
        }
        public bool DoiMatKhau(string userName, string newPassword)
        {
            string query = $"UPDATE TaiKhoan SET PASS_WORD = '{newPassword}' WHERE USERNAME = '{userName}'";
            return DAL.RunQuery(query);
        }
        public bool ThemTaiKhoan(string userName, string password)
        {
            string query = $"insert into TAIKHOAN values ('{userName}','{password}')";
            return DAL.RunQuery(query);
        }
    }
}
