using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DTO
{
    internal class LoaiSach
    {
        private string maLoaiSach;
        private string tenLoaiSach;

        public string MALOAISACH
        {
            get { return maLoaiSach; }
            set { maLoaiSach = value; }
        }

        public string TENLOAISACH
        {
            get { return tenLoaiSach; }
            set { tenLoaiSach = value; }
        }

        public LoaiSach()
        {
        }

        public LoaiSach(string maLoaiSach, string tenLoaiSach)
        {
            this.MALOAISACH = maLoaiSach;
            this.TENLOAISACH = tenLoaiSach;
        }
    }
}
