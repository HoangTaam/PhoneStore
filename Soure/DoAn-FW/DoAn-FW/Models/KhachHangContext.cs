using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using PagedList;
namespace DoAn_FW.Models
{
    public class KhachHangContext
    {
        public string ConnectionString { get; set; }
        public KhachHangContext()
        {
            ConnectionString = "server=localhost;port=3306;database=website_dienthoai;uid=root;password=";
        }
        public KhachHangContext(string cs)
        {
            ConnectionString = cs;
        }
        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public int ThemTK(KhachHang kh)
        {
            using (MySqlConnection conn = GetConnection())
            {
                    conn.Open();
                    var sql = "insert into KHACHHANG(TENKH,GIOITINH,SDT,EMAIL,MATKHAU,CMND,DIACHI,LOAIKH) values(@tenkh, @gt, @sdt, @email, @matkhau, @cmnd ,@diachi, 'Bình thường')";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("tenkh", kh.TenKH);
                    cmd.Parameters.AddWithValue("gt", kh.GioiTinh);
                    cmd.Parameters.AddWithValue("sdt", kh.SDT);
                    cmd.Parameters.AddWithValue("email", kh.Email);
                    cmd.Parameters.AddWithValue("matkhau", kh.MatKhau);
                    cmd.Parameters.AddWithValue("cmnd", kh.CMND);
                    cmd.Parameters.AddWithValue("diachi", kh.DiaChi);
                    return (cmd.ExecuteNonQuery()); 
            }
        }
        public int CapNhatTK(KhachHang kh)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var sql = "Update KHACHHANG SET TENKH = @tenkh, GioiTinh = @gt, SDT = @sdt, CMND = @cmnd, DIACHI = @diachi Where MaKH = @makh";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("tenkh", kh.TenKH);
                cmd.Parameters.AddWithValue("gt", kh.GioiTinh);
                cmd.Parameters.AddWithValue("sdt", kh.SDT);
                cmd.Parameters.AddWithValue("cmnd", kh.CMND);
                cmd.Parameters.AddWithValue("diachi", kh.DiaChi);
                cmd.Parameters.AddWithValue("makh", kh.MaKH);

                return (cmd.ExecuteNonQuery());
            }
        }
        public KhachHang KHDangNhap(string email, string matkhau)
        {
            KhachHang kh = new KhachHang();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open(); ;
                var sql = "SELECT * FROM KHACHHANG WHERE Email = @email AND MatKhau = @matkhau";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("matkhau", matkhau);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader.HasRows)
                        {
                            kh.MaKH = int.Parse(reader["MaKH"].ToString());
                            kh.TenKH = reader["TenKH"].ToString();
                            kh.GioiTinh = reader["GioiTinh"].ToString();
                            kh.SDT = reader["SDT"].ToString();
                            kh.Email = reader["Email"].ToString();
                            kh.MatKhau = reader["MatKhau"].ToString();
                            kh.CMND = reader["CMND"].ToString();
                            kh.DiaChi = reader["DiaChi"].ToString();
                            kh.LoaiKH = reader["LoaiKH"].ToString();
                        }
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return kh;
        }

    }
}
