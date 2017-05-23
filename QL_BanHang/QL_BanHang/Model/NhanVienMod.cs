using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QL_BanHang.Object;
namespace QL_BanHang.Model
{
    class NhanVienMod
    {
        ConnectToSql con = new ConnectToSql();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select * from NhanVien";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.strConn;
            try
            {
                con.OpenConnect();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                con.CloseConnection();
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                cmd.Dispose();
                con.CloseConnection();
            }
            return dt;
        }

        public bool AddNhanVien(NhanVienObj nvObj)
        {
            cmd.CommandText = "Insert into NhanVien values('" + nvObj.MaNV1 + "',N'" + nvObj.TenNV1 + "',CONVERT(date,'" + nvObj.NS1.ToShortDateString() + "',103)  ,N'" + nvObj.GT1 + "',N'" + nvObj.DiaChi1 + "','" + nvObj.SDT1 + "','" + nvObj.Luong1 + "','" + nvObj.MaNQL1 + "','" + nvObj.MaQH1 + "')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.strConn;
            try
            {
                con.OpenConnect();
                cmd.ExecuteNonQuery();
                con.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                cmd.Dispose();
                con.CloseConnection();
            }
            return false;
        }

        public bool DeleteNhanVien(string ma)
        {
            cmd.CommandText = "Delete NhanVien where MaNV='" + ma + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.strConn;
            try
            {
                con.OpenConnect();
                cmd.ExecuteNonQuery();
                con.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                cmd.Dispose();
                con.CloseConnection();
            }
            return false;
        }

        public bool UpdateNhanVien(NhanVienObj nvObj)
        {
            cmd.CommandText = "Update NhanVien set TenNV=N'" + nvObj.TenNV1 + "' ,NS=CONVERT(date,'" + nvObj.NS1.ToShortDateString() + "',103)  ,GT =N'" + nvObj.GT1 + "',DiaChi=N'" + nvObj.DiaChi1 + "',SDT='" + nvObj.SDT1 + "',Luong='" + nvObj.Luong1 + "',MaNQL='" + nvObj.MaNQL1 + "',MaQH='" + nvObj.MaQH1 + "' where MaNV='" + nvObj.MaNV1 + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.strConn;
            try
            {
                con.OpenConnect();
                cmd.ExecuteNonQuery();
                con.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                cmd.Dispose();
                con.CloseConnection();
            }
            return false;
        }
        public DataTable SearchNhanVien(string MaNV)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select * from NhanVien  where MaNV like '%" + MaNV + "%'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.strConn;
            try
            {
                con.OpenConnect();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                con.CloseConnection();
                return dt;

            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                cmd.Dispose();
                con.CloseConnection();
            }
            return dt;
        }
    }
}
