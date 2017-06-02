using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanHang.Object
{
    class KhoObj
    {
        string MaKho, TenKho, DiaChi, MaNV;

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

        public string MaKho1
        {
            get
            {
                return MaKho;
            }

            set
            {
                MaKho = value;
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

        public string TenKho1
        {
            get
            {
                return TenKho;
            }

            set
            {
                TenKho = value;
            }
        }

        public KhoObj() { }
        public KhoObj(string MaKho, string TenKho, string DiaChi, string MaNV)
        {
            this.MaKho = MaKho;
            this.TenKho = TenKho;
            this.DiaChi = DiaChi;
            this.MaNV = MaNV;
        }
    }
}
