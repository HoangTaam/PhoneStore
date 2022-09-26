using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn_FW.Models
{
    public class KhuyenMai
    {
        public virtual int MaKM { get; set; }

        public virtual int SoPTKM { get; set; }

        public virtual DateTime TuNgay { get; set; }

        public virtual DateTime DenNgay { get; set; }
        public virtual long TTienToiThieu { get; set; }

        public string ConnectionString { get; set; }
        public KhuyenMai()
        {
            ConnectionString = "server=localhost;port=3306;database=website_dienthoai;uid=root;password=";
        }
        public KhuyenMai(string cs)
        {
            ConnectionString = cs;
        }
        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
        public List<KhuyenMai> ListKM()
        {
            List<KhuyenMai> list = new List<KhuyenMai>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var now = DateTime.Now.ToString("yyyy-MM-dd");
                var sql = "SELECT * FROM KHUYENMAI WHERE TuNgay <= @datenow AND DenNgay >= @datenow;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("datenow", now);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new KhuyenMai()
                        {
                            MaKM = int.Parse(reader["MaKM"].ToString()),
                            SoPTKM = int.Parse(reader["SoPTKM"].ToString()),
                            TuNgay = DateTime.Parse(reader["TuNgay"].ToString()),
                            DenNgay = DateTime.Parse(reader["DenNgay"].ToString()),
                            TTienToiThieu = int.Parse(reader["TTienToiThieu"].ToString()),
                        }) ;
                    }
                    reader.Close();
                }
            }
            return list;
        }
        public KhuyenMai GetKM(int makm)
        {
            KhuyenMai list = new KhuyenMai();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var sql = "SELECT * FROM KHUYENMAI WHERE @MaKM = makm";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("makm", makm);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.MaKM = int.Parse(reader["MaKM"].ToString());
                        list.SoPTKM = int.Parse(reader["SoPTKM"].ToString());
                        list.TuNgay = DateTime.Parse(reader["TuNgay"].ToString());
                        list.DenNgay = DateTime.Parse(reader["DenNgay"].ToString());
                        list.TTienToiThieu = int.Parse(reader["TTienToiThieu"].ToString());
                    }
                    reader.Close();
                }
            }
            return list;
        }
    }
}
