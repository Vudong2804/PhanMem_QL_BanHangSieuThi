using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QL_BanHang.Model;

namespace QL_BanHang.Object
{
    class CungCapObj
    {
        string MaNCC, MaMH, SoLuong;

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
        public CungCapObj() { }
        public CungCapObj(string MaNCC, string MaMH, string SoLuong)
        {
            this.MaNCC = MaNCC;
            this.MaMH = MaMH;
            this.SoLuong = SoLuong;
        }

    }
}
