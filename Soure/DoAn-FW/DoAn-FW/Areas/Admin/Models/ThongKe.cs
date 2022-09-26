using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Web_projectframeword_admin.Models
{
    public class ThongKe
    {
        public ThongKe()
        {
            ConnectionString = "server=localhost;port=3306;database=website_dienthoai;uid=root;password=";
        }
        public string ConnectionString { get; set; }//biết thành viên
        public ThongKe(string connectionString) //phuong thuc khoi tao
        {
            this.ConnectionString = connectionString;
        }
        private MySqlConnection GetConnection() //lấy connection 
        {
            return new MySqlConnection(ConnectionString);
        }
        public long DoanhThuThang(int thang,int nam)
        {
            long DT = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select MONTH(NgayLapHD) AS Thang, sum(TongTienTT) AS Tong from hoadon WHERE YEAR(NgayLapHD) = @nam AND MONTH(NgayLapHD) = @thang AND TinhTrangTT = 1 GROUP BY MONTH(NgayLapHD)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("nam", nam);
                cmd.Parameters.AddWithValue("thang", thang);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DT = long.Parse(reader["Tong"].ToString());
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return DT;
        }
        public long DoanhThuNam(int nam)
        {
            long DT = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select YEAR(NgayLapHD) AS Nam, sum(TongTienTT) AS Tong from hoadon WHERE YEAR(NgayLapHD) = @nam AND TinhTrangTT = 1 GROUP BY YEAR(NgayLapHD)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("nam", nam);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DT = long.Parse(reader["Tong"].ToString());
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return DT;
        }
        public long ChiPhiThang(int thang, int nam)
        {
            long CP = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select MONTH(NgayLapPN) AS Thang, sum(TongTienTT) AS Tong from phieunhap WHERE YEAR(NgayLapPN) = @nam AND MONTH(NgayLapPN) = @thang GROUP BY MONTH(NgayLapPN)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("nam", nam);
                cmd.Parameters.AddWithValue("thang", thang);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CP = long.Parse(reader["Tong"].ToString());
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return CP;
        }
        public long ChiPhiNam(int nam)
        {
            long CP = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select YEAR(NgayLapPN) AS Nam, sum(TongTienTT) AS Tong from phieunhap WHERE YEAR(NgayLapPN) = @nam GROUP BY YEAR(NgayLapPN)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("nam", nam);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CP = long.Parse(reader["Tong"].ToString());
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return CP;
        }
        public List<HoaDon>GetHDsTheoThang(int thang, int nam)
        {
            List<HoaDon> list = new List<HoaDon>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from hoadon h, khachhang k WHERE h.MaKH = k.MaKH AND YEAR(NgayLapHD) = @nam AND MONTH(NgayLapHD) = @thang AND TinhTrangTT = 1";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("nam", nam);
                cmd.Parameters.AddWithValue("thang", thang);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new HoaDon()
                        {
                            MaHD = int.Parse(reader["MaHD"].ToString()),
                            TenKH = reader["TenKH"].ToString(),
                            TongTienTT = int.Parse(reader["TongTienTT"].ToString()),
                            NgayLapHD = DateTime.Parse(reader["NgayLapHD"].ToString()),
                        });
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }
        public List<NhapHang> GetPNsTheoThang(int thang, int nam)
        {
            List<NhapHang> list = new List<NhapHang>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from phieunhap p, nhacc n WHERE p.MaNCC = n.MaNCC AND YEAR(NgayLapPN) = @nam AND MONTH(NgayLapPN) = @thang";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("nam", nam);
                cmd.Parameters.AddWithValue("thang", thang);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new NhapHang()
                        {
                            MAPN = int.Parse(reader["MaPN"].ToString()),
                            TENNCC = reader["TenNCC"].ToString(),
                            TONGTIENTT = int.Parse(reader["TongTienTT"].ToString()),
                            NGAYLAPPN = DateTime.Parse(reader["NgayLapPN"].ToString()),
                        });
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }
        public List<object> Top3KH(int nam)
        {
            List<object> list = new List<object>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select k.MaKH, k.TenKH, SUM(h.TongTienTT) AS TongTien from hoadon h, khachhang k WHERE h.MaKH = k.MaKH AND YEAR(NgayLapHD) = @nam AND TinhTrangTT = 1 group by k.MaKH order by TongTien DESC LIMIT 3";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("nam", nam);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new 
                        {
                            MaKH = int.Parse(reader["MaKH"].ToString()),
                            TenKH = reader["TenKH"].ToString(),
                            TongTien = long.Parse(reader["TongTien"].ToString()),
                        });
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }
        public List<object> DSSP(int nam)
        {
            List<object> list = new List<object>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "SELECT t.MaTTSP,t.TenSP, COUNT(*) AS SL FROM cthd ct, hoadon h, thongtinsp t WHERE ct.MaHD = h.MaHD AND ct.MaTTSP = t.MaTTSP AND YEAR(h.NgayLapHD) = @nam AND h.TinhTrangHD = 1 GROUP BY MaTTSP ORDER BY SL DESC;";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("nam", nam);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new
                        {
                            MaTTSP = int.Parse(reader["MaTTSP"].ToString()),
                            TenSP = reader["TenSP"].ToString(),
                            SL = long.Parse(reader["SL"].ToString()),
                        });
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }
    }
}
