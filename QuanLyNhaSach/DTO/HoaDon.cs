using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DTO
{
    public class HoaDon
    {
        private string maHoaDon;
        private string tenKhachHang;
        private string ngayLap;
        private decimal tongTien;
        public string MAHOADON { get { return maHoaDon; } set { maHoaDon = value; }}
        public string TENKHACHHANG { get {  return tenKhachHang; } set {  tenKhachHang = value; }}
        public decimal TONGTIEN { get {  return tongTien; } set {  tongTien = value; }}
        public string NGAYLAP { get { return ngayLap; }
            set
            {
                ngayLap = value;
            } }
    }
}
