using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn_FW.Models
{
    public class CTHD
    {
        public virtual int MaHD { get; set; }
        public virtual int MaTTSP { get; set; }
        public virtual string TenSP { get; set; }
        public virtual long SoLuong { get; set; }
        public virtual long Gia { get; set; }
        public virtual long ThanhTien{ get; set; }
        public string ConnectionString { get; set; }
        public CTHD()
        {
            ConnectionString = "server=localhost;port=3306;database=website_dienthoai;uid=root;password=";
        }
        public CTHD(string cs)
        {
            ConnectionString = cs;
        }
        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
        public int InsertCTHD(CTHD ct)
        {
            using (MySqlConnection conn = GetConnection())
            {
                var now = DateTime.Now.ToString("yyyy-MM-dd");
                conn.Open();
                var sql = "insert into CTHD values(@mahd, @mattsp, @soluong,0)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("mahd", ct.MaHD);
                cmd.Parameters.AddWithValue("mattsp", ct.MaTTSP);
                cmd.Parameters.AddWithValue("soluong", ct.SoLuong);
                return (cmd.ExecuteNonQuery());
            }
        }
        public List<CTHD> ListCTHD(int mahd)
        {
            List<CTHD> list = new List<CTHD>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var sql = "SELECT * FROM CTHD c, THONGTINSP t WHERE c.MaTTSP = t.MaTTSP AND MAHD = @mahd";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("mahd", mahd);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new CTHD { 
                            MaHD = int.Parse(reader["MaHD"].ToString()),
                            MaTTSP = int.Parse(reader["MaTTSP"].ToString()),
                            TenSP = reader["TenSP"].ToString(),
                            SoLuong = int.Parse(reader["SoLuong"].ToString()),
                            ThanhTien = int.Parse(reader["ThanhTien"].ToString()),
                        });                      
                    }
                }
            }
            return list;
        }
    }
}
