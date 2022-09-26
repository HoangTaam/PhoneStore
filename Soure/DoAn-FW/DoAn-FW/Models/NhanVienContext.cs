using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn_FW.Models
{
    public class NhanVienContext
    {
        public string ConnectionString { get; set; }
        public NhanVienContext()
        {
            ConnectionString = "server=localhost;port=3306;database=website_dienthoai;uid=root;password=";
        }
        public NhanVienContext(string cs)
        {
            ConnectionString = cs;
        }
        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public NhanVien KHDangNhap(string email, string matkhau)
        {
            NhanVien NV = new NhanVien();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open(); ;
                var sql = "SELECT * FROM NHANVIEN WHERE Email = @email AND MatKhau = @matkhau";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("matkhau", matkhau);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader.HasRows)
                        {
                            NV.MaNV = Convert.ToInt32(reader["MANV"]);
                            NV.TenNV = reader["TENNV"].ToString();
                            NV.NgayVL = Convert.ToDateTime(reader["NGAYVL"]);
                            NV.Luong = Convert.ToInt32(reader["LUONG"]);
                            NV.SDT = reader["SDT"].ToString();
                            NV.Email = reader["Email"].ToString();
                            NV.CMND = reader["CMND"].ToString();
                            NV.DiaChi = reader["DIACHI"].ToString();
                            NV.MatKhau = reader["MATKHAU"].ToString();
                            NV.LoaiNV = reader["LOAINV"].ToString();
                        }
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return NV;
        }
    }
}
