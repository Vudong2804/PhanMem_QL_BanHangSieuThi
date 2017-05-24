using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanHang.Object
{
    class ChiTietHoaDonObj
    {
        string MaHD, MaMH, DonGia, SoLuong, ThanhTien;

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

        public string MaHD1
        {
            get
            {
                return MaHD;
            }

            set
            {
                MaHD = value;
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

        public string SoLuong1
        {
            get
            {
                return SoLuong;
            }

            set
            {
                SoLuong = value;
            }
        }

        public string ThanhTien1
        {
            get
            {
                return ThanhTien;
            }

            set
            {
                ThanhTien = value;
            }
        }

        public ChiTietHoaDonObj() { }
        public ChiTietHoaDonObj(string MaHD, string MaMH, string DonGia, string SoLuong, string ThanhTien)
        {
            this.MaHD = MaHD;
            this.MaMH = MaMH;
            this.DonGia = DonGia;
            this.SoLuong = SoLuong;
            this.ThanhTien = ThanhTien;
        }
    }
}
