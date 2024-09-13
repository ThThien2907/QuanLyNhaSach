using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach.DAL
{
    public class DataAccessLayer
    {
        private SqlDataAdapter da;
        private SqlConnection sqlConn;
        private DataTable dt;
        private DataSet ds;

        private void Connected()
        {
            //string strCon = @"Data Source=LAPTOP-RAAMJ882\\SQLEXPRESS;Initial Catalog=QLNS;Integrated Security=True"; 
            string strCon = @"Data Source=DESKTOP-INQH0L7\SQLEXPRESS;Initial Catalog=QLNS;Integrated Security=True"; //thien
            //string strCon = @"Data Source=TANTHANH;Initial Catalog=QLNS;Integrated Security=True"; //thien

            try
            {
                if (sqlConn == null)
                {
                    sqlConn = new SqlConnection(strCon);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable GetTable(string query)
        {
            Connected();
            if (sqlConn.State == ConnectionState.Closed)
            {
                sqlConn.Open();
            }
            da = new SqlDataAdapter(query, sqlConn);
            dt = new DataTable();
            da.Fill(dt);
            if (sqlConn.State == ConnectionState.Open)
            {
                sqlConn.Close();
            }
            return dt;
        }

        public DataSet GetDataSet(string query)
        {
            Connected();
            if (sqlConn.State == ConnectionState.Closed)
            {
                sqlConn.Open();
            }
            da = new SqlDataAdapter(query, sqlConn);
            ds = new DataSet();
            da.Fill(ds);
            if (sqlConn.State == ConnectionState.Open)
            {
                sqlConn.Close();
            }
            return ds;
        }

        public bool RunQuery(string query)
        {
            int check = 0;
            try
            {
                Connected();
                if (sqlConn.State == ConnectionState.Closed)
                {
                    sqlConn.Open();
                }
                SqlCommand sqlCommand = new SqlCommand(query, sqlConn);
                check = sqlCommand.ExecuteNonQuery();
                if (sqlConn.State == ConnectionState.Open)
                {
                    sqlConn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (check > 0)
                return true;
            return false;
        }
    }
}
