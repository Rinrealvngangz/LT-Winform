using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
namespace DAL
{
   public class SanPhamAccess:DataBaseAccess
    {
        public List<SanPham> LayToanBoSanPham()
        {
            List<SanPham> dsSP =new List<SanPham>();

            OpenConnection();
            SqlCommand comman = new SqlCommand();
            comman.CommandType = CommandType.Text;
            comman.CommandText = "select *from SanPham";
            comman.Connection = conn;
            SqlDataReader reader = comman.ExecuteReader();
            while(reader.Read())
            {
                int ma = reader.GetInt32(0);
                string ten = reader.GetString(1);
                int Dongia = reader.GetInt32(2);
                int MaDm = reader.GetInt32(3);
                SanPham sp = new SanPham();
                sp.MaSp = ma;
                sp.TenSp = ten;
                sp.DonGia = Dongia;
                sp.MaDM = MaDm;
                dsSP.Add(sp);
            }
            reader.Close();
            return dsSP;
        }

        public bool XoaSp(int ma)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Delete from SanPham Where masp=@ma";
            command.Connection = conn;
            command.Parameters.Add("@ma", SqlDbType.Int).Value = ma;

            int kq = command.ExecuteNonQuery();

            return kq > 0;
        }
        public bool ThemSP(SanPham sp)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "Insert into SanPham(MaSp,TenSp,DonGia,MaDM)"+"Values(@ma,@Ten,@gia,@Madm)";
            command.Connection = conn;
            command.Parameters.Add("@ma", SqlDbType.Int).Value = sp.MaSp;
            command.Parameters.Add("@Ten", SqlDbType.NVarChar).Value = sp.TenSp;
            command.Parameters.Add("@gia", SqlDbType.Int).Value = sp.DonGia;
            command.Parameters.Add("@Madm", SqlDbType.Int).Value = sp.MaDM;

            int kq = command.ExecuteNonQuery();
            return kq > 0;
        }
    }
}
