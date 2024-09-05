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
        private string tenSach;
        private int soLuong;
        private string maTG;
        private string maLoaiSach;
        private int giaBan;
        private int giaNhap;
        private int lanTaiBan;
        private string maNXB;
        private int namXB;
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

        public int SOLUONG
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        public string MATG
        {
            get { return maTG; }
            set { maTG = value; }
        }

        public string MALOAISACH
        {
            get { return maLoaiSach; }
            set { maLoaiSach = value; }
        }

        public int GIABAN
        {
            get { return giaBan; }
            set { giaBan = value; }
        }

        public int GIANHAP
        {
            get { return giaNhap; }
            set { giaNhap = value; }
        }

        public int LANTAIBAN
        {
            get { return lanTaiBan; }
            set { lanTaiBan = value; }
        }

        public string MANXB
        {
            get { return maNXB; }
            set { maNXB = value; }
        }
        public int NAMXUATBAN
        {
            get { return namXB; }
            set { namXB = value; }
        }
        public Sach()
        {

        }

        public Sach(string maSach, string tenSach, int soLuong, string maTG, string maLoaiSach, int giaBan, int giaNhap, int lanTaiBan, string maNXB, int namXB)
        {
            this.MASACH = maSach;
            this.TENSACH = tenSach;
            this.SOLUONG = soLuong;
            this.MATG = maTG;
            this.MALOAISACH = maLoaiSach;
            this.GIABAN = giaBan;
            this.GIANHAP = giaNhap;
            this.LANTAIBAN = lanTaiBan;
            this.MANXB = maNXB;
            this.NAMXUATBAN = namXB;
        }
    }
}
