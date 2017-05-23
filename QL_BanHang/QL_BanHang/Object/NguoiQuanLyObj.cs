using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanHang.Object
{
    class NguoiQuanLyObj
    {
        string MaNQL, TenNQL, GT, DiaChi, SDT;
        DateTime NS, NgayNC;

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

        public string MaNQL1
        {
            get
            {
                return MaNQL;
            }

            set
            {
                MaNQL = value;
            }
        }

        public DateTime NgayNC1
        {
            get
            {
                return NgayNC;
            }

            set
            {
                NgayNC = value;
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

        public string TenNQL1
        {
            get
            {
                return TenNQL;
            }

            set
            {
                TenNQL = value;
            }
        }

        public NguoiQuanLyObj() { }
        public NguoiQuanLyObj(string MaNQL, string TenNQL, DateTime NS, string GT, string DiaChi, DateTime NgayNC, string SDT)
        {
            this.DiaChi = DiaChi;
            this.GT = GT;
            this.MaNQL = MaNQL;
            this.TenNQL = TenNQL;
            this.NgayNC = NgayNC;
            this.NS = NS;
            this.SDT = SDT;
        }
    }
}
