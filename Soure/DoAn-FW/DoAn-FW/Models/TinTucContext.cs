using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using PagedList;
namespace DoAn_FW.Models
{
    public class TinTucContext
    {
        public string ConnectionString { get; set; }
        public TinTucContext()
        {
            ConnectionString = "server=localhost;port=3306;database=website_dienthoai;uid=root;password=";
        }
        public TinTucContext(string cs)
        {
            ConnectionString = cs;
        }
        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
        //Tin Tức
        public List<TinTuc> ListAllTinTuc()
        {
            List<TinTuc> list = new List<TinTuc>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open(); ;
                var sql = " SELECT * FROM TINTUC";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new TinTuc()
                        {
                            MaTinTuc = int.Parse(reader["MaTinTuc"].ToString()),
                            HinhBia = reader["HinhBia"].ToString(),
                            TieuDe = reader["TieuDe"].ToString(),
                            NoiDung = reader["NoiDung"].ToString(),
                            Link = reader["Link"].ToString(),
                            TrangThai = int.Parse(reader["TrangThai"].ToString())
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }

        public IEnumerable<TinTuc> ListPagingTinTuc(int page, int pageSize)
        {
            List<TinTuc> list = new List<TinTuc>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open(); ;
                var sql = " SELECT * FROM TINTUC ORDER BY MaTinTuc DESC";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new TinTuc()
                        {
                            MaTinTuc = int.Parse(reader["MaTinTuc"].ToString()),
                            HinhBia = reader["HinhBia"].ToString(),
                            TieuDe = reader["TieuDe"].ToString(),
                            NoiDung = reader["NoiDung"].ToString(),
                            Link = reader["Link"].ToString(),
                            TrangThai = int.Parse(reader["TrangThai"].ToString())
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list.ToPagedList(page, pageSize);
        }

        public List<TinTuc> LietKeTinTuc(string id)
        {
            List<TinTuc> list = new List<TinTuc>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open(); ;
                var sql = " SELECT * FROM TINTUC WHERE MaTinTuc = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id", id);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new TinTuc()
                        {
                            MaTinTuc = int.Parse(reader["MaTinTuc"].ToString()),
                            HinhBia = reader["HinhBia"].ToString(),
                            TieuDe = reader["TieuDe"].ToString(),
                            NoiDung = reader["NoiDung"].ToString(),
                            Link = reader["Link"].ToString(),
                            TrangThai = int.Parse(reader["TrangThai"].ToString())
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
