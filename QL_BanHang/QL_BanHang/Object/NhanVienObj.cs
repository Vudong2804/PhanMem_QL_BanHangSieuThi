using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanHang.Object
{
    class NhanVienObj
    {
        string MaNV, TenNV, GT, DiaChi, SDT, Luong, MaNQL, MaQH;
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

        public string Luong1
        {
            get
            {
                return Luong;
            }

            set
            {
                Luong = value;
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

        public string MaNV1
        {
            get
            {
                return MaNV;
            }

            set
            {
                MaNV = value;
            }
        }

        public string MaQH1
        {
            get
            {
                return MaQH;
            }

            set
            {
                MaQH = value;
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

        public string TenNV1
        {
            get
            {
                return TenNV;
            }

            set
            {
                TenNV = value;
            }
        }

        public NhanVienObj() { }
        public NhanVienObj(string MaNV, string TenNV, DateTime NS, string GT, string DiaChi, string SDT, string Luong, string MaNQL, string MaQH)
        {
            this.MaNV = MaNV;
            this.TenNV = TenNV;
            this.NS = NS;
            this.GT = GT;
            this.DiaChi = DiaChi;
            this.SDT = SDT;
            this.Luong = Luong;
            this.MaNQL = MaNQL;
            this.MaQH = MaQH;

        }
    }
}
