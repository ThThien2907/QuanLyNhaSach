using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DTO
{
    public class Sach
    {
        private string maSach;
        private int soLuong;
        private string tenSach;
        private string maTG;
        private string maLoaiSach;
        private int giaBan;
        private int giaNhap;
        private int lanTaiBan;
        private string maNXB;
        private string namXB;
        public string MASACH
        {
            get { return maSach; }
            set { maSach = value; }
        }

        public string TENSACH
        {
            get { return tenSach; }
            set { tenSach = value; }
        }

        public Sach()
        {

        }

        public Sach(string maPB, string tenPB)
        {
            //this.MaPB = maPB;
            //this.TenPB = tenPB;
        }
    }
}
