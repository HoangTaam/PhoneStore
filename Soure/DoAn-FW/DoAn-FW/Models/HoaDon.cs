using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn_FW.Models
{
    public class HoaDon
    {
        public virtual long MaHD { get; set; }

        public virtual long MaKH { get; set; }

        public virtual long MaKM { get; set; }
        public virtual string DiaChiGH { get; set; }
        public virtual long TongTienTT { get; set; }
        public virtual DateTime NgayLapHD { get; set; }
        public virtual int TinhTrangHD { get; set; }
        public virtual int TinhTrangTT { get; set; }
        public virtual int TinhTrangGH { get; set; }
        public virtual long SoTienNhan { get; set; }
        public virtual long SoTienTra { get; set; }
        public string ConnectionString { get; set; }
        public HoaDon()
        {
            ConnectionString = "server=localhost;port=3306;database=website_dienthoai;uid=root;password=";
        }
        public HoaDon(string cs)
        {
            ConnectionString = cs;
        }
        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
        public int InsertHD(int makh, int makm ,string dchi)
        {
            int last_id = 0;
            using (MySqlConnection conn = GetConnection())
            {
                try
                {
                    var now = DateTime.Now.ToString("yyyy-MM-dd");
                    conn.Open();
                    if (makm != null && makm > 0)
                    {
                        var sql = "insert into HOADON(MaKH, MaKM, DiaChiGH, NgayLapHD, TinhTrangTT,SoTienNhan, SoTienTra) values(@makh, @makm, @dchi, @ngaylaphd,0,0,0); SELECT LAST_INSERT_ID()";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("makh", makh);
                        cmd.Parameters.AddWithValue("makm", makm);
                        cmd.Parameters.AddWithValue("dchi", dchi);
                        cmd.Parameters.AddWithValue("ngaylaphd", now);
                        last_id = int.Parse(cmd.ExecuteScalar().ToString());
                    }
                    else
                    {
                        var sql = "insert into HOADON(MaKH, DiaChiGH, NgayLapHD, TinhTrangTT,SoTienNhan, SoTienTra) values(@makh, @dchi, @ngaylaphd,0,0,0); SELECT LAST_INSERT_ID()";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("makh", makh);
                        cmd.Parameters.AddWithValue("dchi", dchi);
                        cmd.Parameters.AddWithValue("ngaylaphd", now);
                        last_id = int.Parse(cmd.ExecuteScalar().ToString());
                    }
                }
                /*}
                catch(MySqlException ex)
                {
                    return 0;
                }*/
                finally
                {
                    conn.Close();
                }
            }
            return last_id; 
        }
        public List<HoaDon> ListHD(int makh)
        {
            List<HoaDon> list = new List<HoaDon>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var sql = "SELECT * FROM HOADON WHERE MaKH = @makh ORDER BY NgayLapHD DESC";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("makh",makh);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        HoaDon hd = new HoaDon();
                        hd.MaHD = int.Parse(reader["MaHD"].ToString());
                        hd.TongTienTT = long.Parse(reader["TongTienTT"].ToString());
                        hd.NgayLapHD = DateTime.Parse(reader["NgayLapHD"].ToString());
                        hd.TinhTrangHD = int.Parse(reader["TinhTrangHD"].ToString());
                        hd.TinhTrangTT = int.Parse(reader["TinhTrangTT"].ToString());
                        var sqlgh = "SELECT * FROM GIAOHANG WHERE MaHD = @mahd";
                        MySqlConnection conn2 = GetConnection();
                        conn2.Open();
                        MySqlCommand cmdgh = new MySqlCommand(sqlgh, conn2);
                        cmdgh.Parameters.AddWithValue("mahd", hd.MaHD);
                        using (var readergh = cmdgh.ExecuteReader())
                        { 
                            while (readergh.Read()) { hd.TinhTrangGH = int.Parse(readergh["TinhTrangGH"].ToString()); }
                        }
                        list.Add(hd);
                    }
                }
            }
            return list;
        }
        public int CapNhatHD(int mahd, int tthd)
        {
            using(MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var sql = "Update HOADON SET TinhTrangHD = @tthd WHERE MaHD = @mahd";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("tthd", tthd);
                cmd.Parameters.AddWithValue("mahd", mahd);
                return (cmd.ExecuteNonQuery());
            }
        }
        public HoaDon GetHD(int mahd)
        {
            HoaDon list = new HoaDon();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var sql = "SELECT * FROM HOADON WHERE MAHD = @mahd";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("mahd", mahd);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.MaHD = int.Parse(reader["MaHD"].ToString());
                        list.TongTienTT = long.Parse(reader["TongTienTT"].ToString());
                        list.NgayLapHD = DateTime.Parse(reader["NgayLapHD"].ToString());
                        list.DiaChiGH = reader["DiaChiGH"].ToString();
                    }
                }
            }
            return list;
        }
    }
}
