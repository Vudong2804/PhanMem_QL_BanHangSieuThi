using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanHang.Object
{
    class NhaCCObj
    {
        string MaNCC, TenNCC, SDT, DiaChi;

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

        public string MaNCC1
        {
            get
            {
                return MaNCC;
            }

            set
            {
                MaNCC = value;
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

        public string TenNCC1
        {
            get
            {
                return TenNCC;
            }

            set
            {
                TenNCC = value;
            }
        }

        public NhaCCObj() { }
        public NhaCCObj(string MaNCC, string TenNCC, string SDT, string DiaChi)
        {
            this.MaNCC = MaNCC;
            this.TenNCC = TenNCC;
            this.SDT = SDT;
            this.DiaChi = DiaChi;
        }
    }
}
