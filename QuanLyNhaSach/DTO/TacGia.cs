using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DTO
{
    internal class TacGia
    {
        private string maTG;
        private string tenTG;

        public string MATG
        {
            get { return maTG; }
            set { maTG = value; }
        }

        public string TENTG
        {
            get { return tenTG; }
            set { tenTG = value; }
        }

        public TacGia()
        {
        }

        public TacGia(string maTG, string tenTG)
        {
            this.MATG = maTG;
            this.TENTG = tenTG;
        }
    }
}
