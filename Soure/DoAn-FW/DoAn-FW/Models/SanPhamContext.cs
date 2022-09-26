using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace DoAn_FW.Models
{
    public class SanPhamContext
    {
        public string ConnectionString { get; set; }
        public SanPhamContext()
        {
            ConnectionString = "server=localhost;port=3306;database=website_dienthoai;uid=root;password=";
        }
        public SanPhamContext(string cs)
        {
            ConnectionString = cs;
        }
        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
        //Tin Tức
        public List<object> ListSPMoiNhat()
        {
            List<object> list = new List<object >();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open(); ;
                var sql = " SELECT * FROM THONGTINSP ORDER BY MATTSP DESC LIMIT 7;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new
                        {
                            MaTTSP = int.Parse(reader["MaTTSP"].ToString()),
                            MaLoaiSP = int.Parse(reader["MaLoaiSP"].ToString()),
                            TenSP = reader["TenSP"].ToString(),
                            HinhAnh = reader["HinhAnh"].ToString(),
                            Ram = reader["Ram"].ToString(),
                            BoNhoTrong = reader["BoNhoTrong"].ToString(),
                            MauSac = reader["MauSac"].ToString(),
                            Gia = long.Parse(reader["Gia"].ToString()),
                            GiaKM = long.Parse(reader["GiaKM"].ToString())
                        }) ; 
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public List<LoaiSP> ListLoaiSP()
        {
            List<LoaiSP> list = new List<LoaiSP>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open(); ;
                var sql = " SELECT * FROM LOAISP";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new LoaiSP()
                        {
                            MaLoaiSP = int.Parse(reader["MaLoaiSP"].ToString()),
                            TenLoaiSP = reader["TenLoaiSP"].ToString()
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }

        public List<object> ListHang(int maloaisp)
        {
            List<object> list = new List<object>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open(); ;
                var sql = "SELECT th.MaTH, th.TenTH, COUNT(*) AS SL FROM thuonghieu th, thongtinsp t WHERE th.MaTH = t.MaTH AND t.MaLoaiSP = @maloaisp GROUP BY th.MaTH";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("maloaisp",maloaisp);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new
                        {
                            MaTH = int.Parse(reader["MaTH"].ToString()),
                            TenTH= reader["TenTH"].ToString(),
                            SL = int.Parse(reader["SL"].ToString())
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }


        public List<object> FilterSanPham(int? maloaisp)
        {
            List<object> list = new List<object>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open(); 
                var sql = " SELECT * FROM THONGTINSP WHERE MaLoaiSP = @maloaisp";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("maloaisp", maloaisp);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new
                        {
                            MaTTSP = int.Parse(reader["MaTTSP"].ToString()),
                            MaLoaiSP = int.Parse(reader["MaLoaiSP"].ToString()),
                            TenSP = reader["TenSP"].ToString(),
                            HinhAnh = reader["HinhAnh"].ToString(),
                            SoLuong = int.Parse(reader["SoLuong"].ToString()),
                            Ram = reader["Ram"].ToString(),
                            BoNhoTrong = reader["BoNhoTrong"].ToString(),
                            MauSac = reader["MauSac"].ToString(),
                            Gia = long.Parse(reader["Gia"].ToString()),
                            GiaKM = long.Parse(reader["GiaKM"].ToString())
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public List<object> SearchDT(string? search)
        {
            List<object> list = new List<object>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var sql = " SELECT * FROM THONGTINSP WHERE TenSP LIKE '%"+ search+"%' AND MaLoaiSP = 1";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new
                        {
                            MaTTSP = int.Parse(reader["MaTTSP"].ToString()),
                            MaLoaiSP = int.Parse(reader["MaLoaiSP"].ToString()),
                            TenSP = reader["TenSP"].ToString(),
                            HinhAnh = reader["HinhAnh"].ToString(),
                            Ram = reader["Ram"].ToString(),
                            BoNhoTrong = reader["BoNhoTrong"].ToString(),
                            MauSac = reader["MauSac"].ToString(),
                            Gia = long.Parse(reader["Gia"].ToString()),
                            GiaKM = long.Parse(reader["GiaKM"].ToString())
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public List<object> SearchMTB(string? search)
        {
            List<object> list = new List<object>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var sql = " SELECT * FROM THONGTINSP WHERE TenSP LIKE '%" + search + "%' AND MaLoaiSP = 2";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("search", search);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new
                        {
                            MaTTSP = int.Parse(reader["MaTTSP"].ToString()),
                            MaLoaiSP = int.Parse(reader["MaLoaiSP"].ToString()),
                            TenSP = reader["TenSP"].ToString(),
                            HinhAnh = reader["HinhAnh"].ToString(),
                            Ram = reader["Ram"].ToString(),
                            BoNhoTrong = reader["BoNhoTrong"].ToString(),
                            MauSac = reader["MauSac"].ToString(),
                            Gia = long.Parse(reader["Gia"].ToString()),
                            GiaKM = long.Parse(reader["GiaKM"].ToString())
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public List<object> SPLocTheoHangSP(int maloaisp , int? math)
        {
            List<object> list = new List<object>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open(); ;
                var sql = " SELECT * FROM THONGTINSP WHERE MaTH = @math AND MaLoaiSP = @maloaisp";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("math", math);
                cmd.Parameters.AddWithValue("maloaisp", maloaisp);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new
                        {
                            MaTTSP = int.Parse(reader["MaTTSP"].ToString()),
                            MaLoaiSP = int.Parse(reader["MaLoaiSP"].ToString()),
                            TenSP = reader["TenSP"].ToString(),
                            HinhAnh= reader["HinhAnh"].ToString(),
                            Ram = reader["Ram"].ToString(),
                            BoNhoTrong = reader["BoNhoTrong"].ToString(),
                            MauSac = reader["MauSac"].ToString(),
                            Gia = long.Parse(reader["Gia"].ToString()),
                            GiaKM = long.Parse(reader["GiaKM"].ToString())
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public object ChiTietSP(int mattsp)
        {
            object list = new object();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open(); ;
                var sql = "SELECT * FROM THONGTINSP t , LOAISP l, THUONGHIEU th WHERE t.MaLoaiSP = l.MaLoaiSP AND t.MaTH = TH.MaTH AND t.MaTTSP = @mattsp";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("mattsp", mattsp);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list = new
                        {
                            MaTTSP = int.Parse(reader["MaTTSP"].ToString()),
                            MaLoaiSP = int.Parse(reader["MaLoaiSP"].ToString()),
                            Gia = int.Parse(reader["Gia"].ToString()),
                            GiaKM = int.Parse(reader["GiaKM"].ToString()),
                            SoLuong = int.Parse(reader["SoLuong"].ToString()),
                            Mausac = reader["MauSac"].ToString(),
                            Ram = int.Parse(reader["Ram"].ToString()),
                            Bonhotrong = int.Parse(reader["BoNhoTrong"].ToString()),
                            Pin = int.Parse(reader["Pin"].ToString()),
                            Kichthuocmanhinh = float.Parse(reader["KichThuocManHinh"].ToString()),
                            Cameratruoc= reader["CameraTruoc"].ToString(),
                            Camerasau = reader["CameraSau"].ToString(),
                            Cpu = reader["CPU"].ToString(),
                            TenTH = reader["TenTH"].ToString(),
                            LoaiSP = reader["TenLoaiSP"].ToString(),
                            HinhAnh = reader["HinhAnh"].ToString(),
                            TenSP = reader["TenSP"].ToString(),
                        };
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public List<object> BinhLuans(int mattsp)
        {
            List<object> list = new List<object>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open(); ;
                var sql = "SELECT * FROM BINHLUAN b, KHACHHANG k WHERE b.MaKH = k.MaKH AND b.MaTTSP = @mattsp";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("mattsp", mattsp);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new
                        {
                            TenKH = reader["TenKH"].ToString(),
                            NoiDung = reader["NoiDung"].ToString(),
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
