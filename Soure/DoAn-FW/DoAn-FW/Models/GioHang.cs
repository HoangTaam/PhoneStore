using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DoAn_FW.Models
{
    public class GioHang
    {
        public string ConnectionString { get; set; }
        public GioHang()
        {
            ConnectionString = "server=localhost;port=3306;database=website_dienthoai;uid=root;password=";
        }
        public GioHang(string cs)
        {
            ConnectionString = cs;
        }
        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
        public int MaTTSP { get; set; }
        public int MaKH { get; set; }
        public int SLTon {get; set;}
        public int SoLuong { get; set; }
        public List<GioHang> ListGioHang(int makh)
        {
            List<GioHang> list = new List<GioHang>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open(); ;
                var sql = " SELECT * FROM GIOHANG WHERE MAKH = @makh";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("makh", makh);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new GioHang()
                        {
                            MaTTSP = int.Parse(reader["MaTTSP"].ToString()),
                            MaKH = int.Parse(reader["MaKH"].ToString()),
                            SoLuong = int.Parse(reader["SoLuong"].ToString())
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public List<object> ListCTSP(int makh)
        {
            List<object> list = new List<object>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open(); ;
                var sql = " SELECT t.MaTTSP, t.MaLoaiSP , g.MaKH, g.SoLuong, t.TenSP, t.HinhAnh, t.Gia, t.GiaKM, t.MauSac, t.Ram, t.BoNhoTrong FROM GIOHANG g, THONGTINSP t WHERE g.MaTTSP = t.MaTTSP AND MAKH = @makh";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("makh", makh);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new
                        {
                            MaTTSP = int.Parse(reader["MaTTSP"].ToString()),
                            MaLoaiSP = int.Parse(reader["MaLoaiSP"].ToString()),
                            MaKH = int.Parse(reader["MaKH"].ToString()),
                            SoLuong = int.Parse(reader["SoLuong"].ToString()),
                            TenSP = reader["TenSP"].ToString(),
                            HinhAnh = reader["HinhAnh"].ToString(),
                            Gia = long.Parse(reader["Gia"].ToString()),
                            GiaKM = long.Parse(reader["GiaKM"].ToString()),
                            MauSac = reader["MauSac"].ToString(),
                            Ram = int.Parse(reader["Ram"].ToString()),
                            BoNhoTrong = int.Parse(reader["BoNhoTrong"].ToString()),
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public int InsertGH(GioHang gh)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var sql = "insert into GIOHANG(MaTTSP, SoLuong, MaKH) values(@mattsp, @soluong , @makh)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("mattsp", gh.MaTTSP);
                cmd.Parameters.AddWithValue("soluong", gh.SoLuong);
                cmd.Parameters.AddWithValue("makh", gh.MaKH);
                return (cmd.ExecuteNonQuery());
            }
        }
        public int UpdateGH(GioHang gh)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var sql = "UPDATE giohang SET SoLuong = SoLuong + @soluong WHERE MaTTSP = @mattsp AND MaKH = @makh";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("mattsp", gh.MaTTSP);
                cmd.Parameters.AddWithValue("soluong", gh.SoLuong);
                cmd.Parameters.AddWithValue("makh", gh.MaKH);
                return (cmd.ExecuteNonQuery());
            }
        }
        public int DeleteGH(int mattsp, int makh)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var sql = "DELETE FROM GIOHANG WHERE MaTTSP = @mattsp AND MaKH = @makh";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("mattsp", mattsp);
                cmd.Parameters.AddWithValue("makh", makh);
                return (cmd.ExecuteNonQuery());
            }
        }
    }
}
