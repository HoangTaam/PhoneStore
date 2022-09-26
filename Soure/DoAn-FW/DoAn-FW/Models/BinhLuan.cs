using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn_FW.Models
{
    public class BinhLuan
    {
        public virtual long MaBL { get; set; }

        public virtual long MaTTSP { get; set; }

        public virtual long MaKH { get; set; }

        public virtual string NoiDung { get; set; }

        public string ConnectionString { get; set; }
        public BinhLuan()
        {
            ConnectionString = "server=localhost;port=3306;database=website_dienthoai;uid=root;password=";
        }
        public BinhLuan(string cs)
        {
            ConnectionString = cs;
        }
        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
        public int InsertBL(BinhLuan bl)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var sql = "insert into BINHLUAN(MaTTSP, MaKH, NoiDung) values(@mattsp, @makh, @noidung)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("mattsp", bl.MaTTSP);
                cmd.Parameters.AddWithValue("makh", bl.MaKH);
                cmd.Parameters.AddWithValue("noidung", bl.NoiDung);
                return (cmd.ExecuteNonQuery());
            }
        }
    }
}
