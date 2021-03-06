﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BanHang.Object
{
    class HoaDonBanHangObj
    {
        string MaHD, MaNV, MaKH;
        DateTime NgayLamHD;

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

        public DateTime NgayLamHD1
        {
            get
            {
                return NgayLamHD;
            }

            set
            {
                NgayLamHD = value;
            }
        }


        public HoaDonBanHangObj() { }
        public HoaDonBanHangObj(string MaHD, DateTime NgayLamHD, string MaNV, string MaKH)
        {
            this.MaHD = MaHD;
            this.NgayLamHD = NgayLamHD;
            this.MaNV = MaNV;
            this.MaKH = MaKH;
        }
    }
}
