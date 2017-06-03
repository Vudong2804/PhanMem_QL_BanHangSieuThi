using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanHang.Object
{
    class MatHangObj
    {
        string MaMH, TenMH, MaNCC, MaKho, DonGia, MaQH;

        public string DonGia1
        {
            get
            {
                return DonGia;
            }

            set
            {
                DonGia = value;
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

        public string MaMH1
        {
            get
            {
                return MaMH;
            }

            set
            {
                MaMH = value;
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



        public string TenMH1
        {
            get
            {
                return TenMH;
            }

            set
            {
                TenMH = value;
            }
        }

        public MatHangObj() { }
        public MatHangObj(string MaMH, string TenMH, string MaNCC, string MaKho, string DonGia, string MaQH)
        {
            this.MaMH = MaMH;
            this.TenMH = TenMH;
            this.MaNCC = MaNCC;
            this.MaKho = MaKho;
            this.DonGia = DonGia;
            this.MaQH = MaQH;

        }
    }
}
