using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanHang.Object
{
    class KhachHangObj
    {
        string MaKH, TenKH, GT, DiaChi, SDT;
        DateTime NS;

        public string DiaChi1
        {
            get
            {
                return DiaChi;
            }

            set
            {
                DiaChi = value;
            }
        }

        public string GT1
        {
            get
            {
                return GT;
            }

            set
            {
                GT = value;
            }
        }

        public string MaKH1
        {
            get
            {
                return MaKH;
            }

            set
            {
                MaKH = value;
            }
        }

        public DateTime NS1
        {
            get
            {
                return NS;
            }

            set
            {
                NS = value;
            }
        }

        public string SDT1
        {
            get
            {
                return SDT;
            }

            set
            {
                SDT = value;
            }
        }

        public string TenKH1
        {
            get
            {
                return TenKH;
            }

            set
            {
                TenKH = value;
            }
        }

        public KhachHangObj() { }
        public KhachHangObj(string MaKH, string TenKH, DateTime NS, string GT, string DiaChi, string SDT)
        {
            this.MaKH = MaKH;
            this.TenKH = TenKH;
            this.NS = NS;
            this.GT = GT;
            this.DiaChi = DiaChi;
            this.SDT = SDT;
        }
    }
}
