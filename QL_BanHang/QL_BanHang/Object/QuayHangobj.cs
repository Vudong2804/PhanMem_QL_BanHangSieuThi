using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanHang.Object
{
    class QuayHangObj
    {
        string MaQH, TenQuayHang, DiaChi, MaNQL;

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

        public string TenQuayHang1
        {
            get
            {
                return TenQuayHang;
            }

            set
            {
                TenQuayHang = value;
            }
        }

        public QuayHangObj() { }
        public QuayHangObj(string MaQH, string TenQuayHang, string DiaChi, string MaNQL)
        {
            this.MaQH = MaQH;
            this.TenQuayHang = TenQuayHang;
            this.DiaChi = DiaChi;
            this.MaNQL = MaNQL;
        }
    }
}
