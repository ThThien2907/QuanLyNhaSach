using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DTO
{
    internal class NhaXuatBan
    {
        private string maNXB;
        private string tenNXB;

        public string MANXB
        {
            get { return maNXB; }
            set { maNXB = value; }
        }

        public string TENNHAXUATBAN
        {
            get { return tenNXB; }
            set { tenNXB = value; }
        }

        public NhaXuatBan()
        {
        }

        public NhaXuatBan(string maNXB, string tenNXB)
        {
            this.MANXB = maNXB;
            this.TENNHAXUATBAN = tenNXB;
        }
    }
}
