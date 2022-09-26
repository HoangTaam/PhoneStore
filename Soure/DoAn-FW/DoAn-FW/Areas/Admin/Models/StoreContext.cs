using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace Web_projectframeword_admin.Models
{
    public class StoreContext
    {
        public string ConnectionString { get; set; }//biết thành viên 

        public StoreContext(string connectionString) //phuong thuc khoi tao
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection() //lấy connection 
        {
            return new MySqlConnection(ConnectionString);
        }

        //Hóa Đơn
        public (List<HoaDonViewModel> hd, int pages, int page) GetDSHD(int page)
        {
            List<HoaDonViewModel> list = new List<HoaDonViewModel>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "SELECT * FROM hoadon hd, khachhang kh WHERE hd.MaKH = kh.MaKH order by tinhtranghd;";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new HoaDonViewModel()
                        {
                            MaHD = Convert.ToInt32(reader["MAHD"]),
                            MaKM = (reader["MAKM"] != System.DBNull.Value) ? Convert.ToInt32(reader["MAKM"]) : 0 ,
                            TenKH = reader["TENKH"].ToString(),
                            DiaChiGH = reader["DiaChiGH"].ToString(),
                            TongTienTT = Convert.ToInt32(reader["TONGTIENTT"]),
                            NgayLapHD = Convert.ToDateTime(reader["NGAYLAPHD"]),
                            TinhTrangTT = Convert.ToInt32(reader["TINHTRANGTT"]),
                            TinhTrangHD = Convert.ToInt32(reader["TINHTRANGHD"]),
                            SoTienNhan = Convert.ToInt32(reader["SOTIENNHAN"]),
                            SoTienTra = Convert.ToInt32(reader["SOTIENTRA"]),
                        });
                    }                            
                    reader.Close();
                }
                conn.Close();
            }
            int Size = 10;
            int pages = (int)Math.Ceiling((double)list.Count / Size);
            List<HoaDonViewModel> dshd = list.Skip((page - 1) * Size).Take(Size).ToList();
            return (dshd, pages, page);
        }

        public (List<HoaDonViewModel> hd, int pages, int page) GetDSCD(int page)
        {
            List<HoaDonViewModel> list = new List<HoaDonViewModel>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "SELECT hd.MAHD, hd.MAKM, TENKH, DIACHIGH, TONGTIENTT, NGAYLAPHD, TINHTRANGTT, TINHTRANGHD, SOTIENNHAN, SOTIENTRA" +
                    " FROM hoadon hd, khachhang kh WHERE hd.MaKH = kh.MaKH and tinhtranghd = 0 order by tinhtranghd;";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new HoaDonViewModel()
                        {
                            MaHD = Convert.ToInt32(reader["MAHD"]),
                            MaKM = (reader["MAKM"] != System.DBNull.Value) ? Convert.ToInt32(reader["MAKM"]) : 0 ,  
                            TenKH = reader["TENKH"].ToString(),
                            DiaChiGH = reader["DiaChiGH"].ToString(),
                            TongTienTT = Convert.ToInt32(reader["TONGTIENTT"]),
                            NgayLapHD = Convert.ToDateTime(reader["NGAYLAPHD"]),
                            TinhTrangTT = Convert.ToInt32(reader["TINHTRANGTT"]),
                            TinhTrangHD = Convert.ToInt32(reader["TINHTRANGHD"]),
                            SoTienNhan = Convert.ToInt32(reader["SOTIENNHAN"]),
                            SoTienTra = Convert.ToInt32(reader["SOTIENTRA"]),
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            int Size = 10;
            int pages = (int)Math.Ceiling((double)list.Count / Size);
            List<HoaDonViewModel> dshd = list.Skip((page - 1) * Size).Take(Size).ToList();
            return (dshd, pages, page);
        }
        public int ThemHD(HoaDonEditModel hd)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "INSERT INTO Hoadon(MaHD, MaKH, MaKM, DiaChiGH, TongTienTT, NgayLapHD, TinhTrangHD, TinhTrangTT, SoTienNhan, SoTienTra) VALUES (NULL, @makh, @makm, @diachigh, @tongtientt, @ngaylaphd, @tinhtranghd, @tinhtrangtt, @sotiennhan, @sotientra)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("makh", hd.MaKH);
                cmd.Parameters.AddWithValue("makm", hd.MaKM);
                cmd.Parameters.AddWithValue("diachigh", hd.DiaChiGH);
                cmd.Parameters.AddWithValue("tongtientt", hd.TongTienTT);
                cmd.Parameters.AddWithValue("ngaylaphd", hd.NgayLapHD);
                cmd.Parameters.AddWithValue("tinhtranghd", hd.TinhTrangHD);
                cmd.Parameters.AddWithValue("tinhtrangtt", hd.TinhTrangTT);
                cmd.Parameters.AddWithValue("sotiennhan", hd.SoTienNhan);
                cmd.Parameters.AddWithValue("sotientra", hd.SoTienTra);
                return (cmd.ExecuteNonQuery());

            }
        }

        public HoaDonEditModel GetHD(int id)
        {
            HoaDonEditModel HD = new HoaDonEditModel();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "SELECT * FROM HoaDon WHERE MAHD = @mahd";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("mahd", id);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        HD.MaHD = Convert.ToInt32(reader["MAHD"]);
                        HD.MaKH = Convert.ToInt32(reader["MAKH"]);
                        HD.MaKM = (reader["MAKM"] != System.DBNull.Value) ? Convert.ToInt32(reader["MAKM"]) : 0;  
                        HD.NgayLapHD = Convert.ToDateTime(reader["NGAYLAPHD"]);
                        HD.SoTienNhan = Convert.ToInt32(reader["SOTIENNHAN"]); ;
                        HD.SoTienTra = Convert.ToInt32(reader["SOTIENTRA"]); 
                        HD.TinhTrangHD = Convert.ToInt32(reader["TINHTRANGHD"]); 
                        HD.TinhTrangTT = Convert.ToInt32(reader["TINHTRANGTT"]); 
                        HD.TongTienTT = Convert.ToInt32(reader["TONGTIENTT"]); 
                        HD.DiaChiGH = reader["DIACHIGH"].ToString();
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return HD;
        }

        public int UpdateHD(HoaDonEditModel hd)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                if (hd.MaKM == 0)
                {
                    var str = "update HoaDon " +
                    "set MAKH=@makh, DIACHIGH=@diachigh, TONGTIENTT=@tongtientt, NGAYLAPHD=@ngaylaphd, TINHTRANGHD=@tinhtranghd, TINHTRANGTT=@tinhtrangtt, SOTIENNHAN=@sotiennhan, SOTIENTRA=@sotientra " +
                    "where MAHD=@mahd";
                    MySqlCommand cmd = new MySqlCommand(str, conn);
                    cmd.Parameters.AddWithValue("makh", hd.MaKH);
                    cmd.Parameters.AddWithValue("diachigh", hd.DiaChiGH);
                    cmd.Parameters.AddWithValue("tongtientt", hd.TongTienTT);
                    cmd.Parameters.AddWithValue("ngaylaphd", hd.NgayLapHD);
                    cmd.Parameters.AddWithValue("tinhtranghd", hd.TinhTrangHD);
                    cmd.Parameters.AddWithValue("tinhtrangtt", hd.TinhTrangTT);
                    cmd.Parameters.AddWithValue("sotiennhan", hd.SoTienNhan);
                    cmd.Parameters.AddWithValue("sotientra", hd.SoTienTra);
                    cmd.Parameters.AddWithValue("mahd", hd.MaHD);
                    return (cmd.ExecuteNonQuery());
                }
                else
                {
                    var str = "update HoaDon " +
                    "set MAKH=@makh, MAKM=@makm, DIACHIGH=@diachigh, TONGTIENTT=@tongtientt, NGAYLAPHD=@ngaylaphd, TINHTRANGHD=@tinhtranghd, TINHTRANGTT=@tinhtrangtt, SOTIENNHAN=@sotiennhan, SOTIENTRA=@sotientra " +
                    "where MAHD=@mahd";
                    MySqlCommand cmd = new MySqlCommand(str, conn);
                    cmd.Parameters.AddWithValue("makh", hd.MaKH);
                    cmd.Parameters.AddWithValue("makm", hd.MaKM);
                    cmd.Parameters.AddWithValue("diachigh", hd.DiaChiGH);
                    cmd.Parameters.AddWithValue("tongtientt", hd.TongTienTT);
                    cmd.Parameters.AddWithValue("ngaylaphd", hd.NgayLapHD);
                    cmd.Parameters.AddWithValue("tinhtranghd", hd.TinhTrangHD);
                    cmd.Parameters.AddWithValue("tinhtrangtt", hd.TinhTrangTT);
                    cmd.Parameters.AddWithValue("sotiennhan", hd.SoTienNhan);
                    cmd.Parameters.AddWithValue("sotientra", hd.SoTienTra);
                    cmd.Parameters.AddWithValue("mahd", hd.MaHD);
                    return (cmd.ExecuteNonQuery());
                }
                
            }
        }
        public List<CTHD> GetDSCTHD(int MAHD)
        {
            List<CTHD> list = new List<CTHD>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select MAHD, CTHD.MATTSP, cthd.SOLUONG, TENSP, THANHTIEN from cthd join thongtinsp sp on cthd.mattsp = sp.mattsp where MAHD = @mahd";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("mahd", MAHD);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new CTHD()
                        {
                            MaHD = Convert.ToInt32(reader["MAHD"]),
                            MaSP = Convert.ToInt32(reader["MATTSP"]),
                            SoLuong = Convert.ToInt32(reader["SOLUONG"]),
                            ThanhTien = Convert.ToInt32(reader["THANHTIEN"]),
                            TenSP = reader["TENSP"].ToString()
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }

        public int InsertCTHD(CTHD ct)
        {
            List<int> list = new List<int>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select mattsp from cthd where mahd = @mahd";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("mahd", ct.MaHD);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(Convert.ToInt32(reader["mattsp"]));
                    }
                    reader.Close();
                }
                if(list.Contains(ct.MaSP))
                {
                    var sql = "update cthd set soluong = @sl where mahd = @mahd and mattsp = @masp";
                    MySqlCommand cmd1 = new MySqlCommand(sql, conn);
                    cmd1.Parameters.AddWithValue("sl", ct.SoLuong);
                    cmd1.Parameters.AddWithValue("mahd", ct.MaHD);
                    cmd1.Parameters.AddWithValue("masp", ct.MaSP);
                    return (cmd1.ExecuteNonQuery());
                }
                else
                {
                    var sql = "insert into cthd(mahd, mattsp, soluong) values(@mahd, @mattsp, @sl)";
                    MySqlCommand cmd1 = new MySqlCommand(sql, conn);
                    cmd1.Parameters.AddWithValue("sl", ct.SoLuong);
                    cmd1.Parameters.AddWithValue("mahd", ct.MaHD);
                    cmd1.Parameters.AddWithValue("mattsp", ct.MaSP);
                    return (cmd1.ExecuteNonQuery());
                }
            }
        }

        public int HuyHD(int mahd)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update hoadon set tinhtranghd = -1 where mahd = @ma";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("ma", mahd);
                return (cmd.ExecuteNonQuery());


            }
        }

        public int DuyetHD(int mahd)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var manv = 0;
                var sql = "select manv from nhanvien where LoaiNV ='Giao hàng'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    manv = Convert.ToInt32(reader["manv"]);
                }
                var sql1 = "insert into giaohang values(@mahd, @manv, '0')";
                MySqlCommand cmd1 = new MySqlCommand(sql1, conn);
                cmd1.Parameters.AddWithValue("mahd", mahd);
                cmd1.Parameters.AddWithValue("manv", manv);
                cmd1.ExecuteNonQuery();
                var str = "update hoadon set tinhtranghd = 1 where mahd = @ma";
                MySqlCommand cmd2 = new MySqlCommand(str, conn);
                cmd2.Parameters.AddWithValue("ma", mahd);
                return cmd2.ExecuteNonQuery();
            }
        }

        public int DeleteHD(int mahd)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from giaohang where MAHD = @mahd;" +
                    "delete from cthd where MAHD = @mahd;" +
                    "delete from hoadon where MAHD = @mahd;";
                MySqlCommand cmd1 = new MySqlCommand(str, conn);
                cmd1.Parameters.AddWithValue("mahd", mahd);
                return (cmd1.ExecuteNonQuery());
            }
        }

        public int DeleteCTHD(int mahd, int masp)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from cthd where MAHD = @mahd and MATTSP = @masp;";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("mahd", mahd);
                cmd.Parameters.AddWithValue("masp", masp);
                return (cmd.ExecuteNonQuery());
            }
        }    

        //Giao hàng
        public (List<GiaoHang> gh, int pages, int page) GetDSGH(int page)
        {
            List<GiaoHang> list = new List<GiaoHang>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "SELECT gh.MAHD, DIACHIGH, gh.MANV, TENNV, SDT, TINHTRANGGH FROM hoadon hd, giaohang gh, nhanvien nv WHERE hd.MaHD = gh.MaHD and gh.MANV = nv.MANV order by tinhtranggh;";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new GiaoHang()
                        {
                            MaHD = Convert.ToInt32(reader["MAHD"]),
                            DiaChiGH = reader["DIACHIGH"].ToString(),
                            MaNV = Convert.ToInt32(reader["MANV"]),
                            TenNV = reader["TENNV"].ToString(),
                            SDT = reader["SDT"].ToString(),
                            TinhTrangGH = Convert.ToInt32(reader["TINHTRANGGH"])
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            int Size = 10;
            int pages = (int)Math.Ceiling((double)list.Count / Size);
            List<GiaoHang> dsgh = list.Skip((page - 1) * Size).Take(Size).ToList();
            return (dsgh, pages, page);
        }

        public int HoanThanhGH(int MAHD, int MANV, int stn)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update hoadon set sotiennhan = @stn where mahd = @mahd;" +
                    "update giaohang set tinhtranggh = 1 where mahd =@mahd and manv=@manv;";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("stn", stn);
                cmd.Parameters.AddWithValue("mahd", MAHD);
                cmd.Parameters.AddWithValue("manv", MANV);
                return (cmd.ExecuteNonQuery());
            }
        }
        public int DeleteGH(int mahd, int manv)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from giaohang where MANV=@manv and MAHD = @mahd";
                MySqlCommand cmd1 = new MySqlCommand(str, conn);
                cmd1.Parameters.AddWithValue("mahd", mahd);
                cmd1.Parameters.AddWithValue("manv", manv);
                return (cmd1.ExecuteNonQuery());
            }
        }
        public int HDChuaDuyet()
        {
            int sohd = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select count(*) as sohd from hoadon where tinhtranghd =0 ";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    sohd = Convert.ToInt32(reader["sohd"]);
                }
            }
            return sohd;
        }

        public int GHChuaGiao()
        {
            int sogh = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select count(*) as sogh from giaohang where tinhtranggh = 0 ";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    sogh = Convert.ToInt32(reader["sogh"]);
                }
            }
            return sogh;
        }

        //Khách hàng
        public List<KhachHang> GetDSKH()
        {
            List<KhachHang> DSKH = new List<KhachHang>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "SELECT * FROM khachhang";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DSKH.Add(new KhachHang()
                        {
                            MaKH = Convert.ToInt32(reader["MAKH"]),
                            TenKH = reader["TENKH"].ToString(),
                            GioiTinh = reader["GioiTinh"].ToString(),
                            SDT = reader["SDT"].ToString(),
                            Email = reader["Email"].ToString(),
                            MatKhau = reader["MatKhau"].ToString(),
                            CMND = reader["CMND"].ToString(),
                            DiaChi = reader["DiaChi"].ToString(),
                            LoaiKH = reader["LoaiKH"].ToString(),
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return (DSKH);
        }

        public KhachHang GetKH(int id)
        {
            KhachHang KH = new KhachHang();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "SELECT * FROM khachhang WHERE MAKH = @makh";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("makh", id);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        KH.MaKH = Convert.ToInt32(reader["MAKH"]);
                        KH.TenKH = reader["TENKH"].ToString();
                        KH.SDT = reader["SDT"].ToString();
                        KH.Email = reader["Email"].ToString();
                        KH.GioiTinh = reader["GIOITINH"].ToString();
                        KH.CMND = reader["CMND"].ToString();
                        KH.DiaChi = reader["DIACHI"].ToString();
                        KH.MatKhau = reader["MATKHAU"].ToString();
                        KH.LoaiKH = reader["LOAIKH"].ToString();
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return KH;
        }
        public (List<KhachHang> kh, int pages, int page) GetDSKH(int page)
        {
            List<KhachHang> DSKH = new List<KhachHang>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "SELECT * FROM khachhang";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DSKH.Add(new KhachHang()
                        {
                            MaKH = Convert.ToInt32(reader["MAKH"]),
                            TenKH = reader["TENKH"].ToString(),
                            GioiTinh = reader["GioiTinh"].ToString(),
                            SDT = reader["SDT"].ToString(),
                            Email = reader["Email"].ToString(),
                            MatKhau = reader["MatKhau"].ToString(),
                            CMND = reader["CMND"].ToString(),
                            DiaChi = reader["DiaChi"].ToString(),
                            LoaiKH = reader["LoaiKH"].ToString(),
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            int Size = 10;
            int pages = (int)Math.Ceiling((double)DSKH.Count / Size);
            List<KhachHang> dskh = DSKH.Skip((page - 1) * Size).Take(Size).ToList();
            return (dskh, pages, page);
        }

        public int DeleteKH(int id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from khachhang where MAKH=@makh";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("makh", id);
                return (cmd.ExecuteNonQuery());
            }
        }
        public (List<NhanVien> nv, int pages, int page) GetDSNV(int page)
        {
            List<NhanVien> DSNV = new List<NhanVien>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "SELECT * FROM nhanvien";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DSNV.Add(new NhanVien()
                        {
                            MaNV = Convert.ToInt32(reader["MANV"]),
                            TenNV = reader["TENNV"].ToString(),
                            NgayVL = Convert.ToDateTime(reader["NGAYVL"]),
                            Luong = Convert.ToInt32(reader["LUONG"]),
                            SDT = reader["SDT"].ToString(),
                            Email = reader["Email"].ToString(),
                            MatKhau = reader["MatKhau"].ToString(),
                            CMND = reader["CMND"].ToString(),
                            DiaChi = reader["DiaChi"].ToString(),
                            LoaiNV = reader["LoaiNV"].ToString(),
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            int Size = 10;
            int pages = (int)Math.Ceiling((double)DSNV.Count / Size);
            List<NhanVien> dsnv = DSNV.Skip((page - 1) * Size).Take(Size).ToList();
            return (dsnv, pages, page);
        }

        public List<KhuyenMai> GetDSKM()
        {
            List<KhuyenMai> DSKM = new List<KhuyenMai>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "SELECT * FROM khuyenmai";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DSKM.Add(new KhuyenMai()
                        {
                            MaKM = Convert.ToInt32(reader["MAKM"]),
                            SoPTKM = Convert.ToInt32(reader["SoPTKM"]),
                            TuNgay = Convert.ToDateTime(reader["TuNgay"]),
                            DenNgay = Convert.ToDateTime(reader["DenNgay"]),
                            TTienToiThieu = Convert.ToInt32(reader["TTienToiThieu"]),

                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return DSKM;
        }

        public List<SanPham> GetDSSP()
        {
            List<SanPham> DSSP = new List<SanPham>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "SELECT * FROM thongtinsp";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DSSP.Add( new SanPham() 
                        {
                            MATTSP = reader["MATTSP"].ToString(),
                            TENSP  = reader["TENSP"].ToString(),
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return DSSP;
        }

        public int ThemNhanVien(NhanVien nv)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "INSERT INTO `nhanvien` (`MaNV`, `TenNV`, `NgayVL`, `Luong`, `SDT`, `Email`, `MatKhau`, `CMND`, `DiaChi`, `LoaiNV`) VALUES (NULL, @tennv, @ngayvl, @luong, @sdt, @email, @matkhau, @cmnd, @diachi, @loainv)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("tennv", nv.TenNV);
                cmd.Parameters.AddWithValue("ngayvl", nv.NgayVL);
                cmd.Parameters.AddWithValue("luong", nv.Luong);
                cmd.Parameters.AddWithValue("sdt", nv.SDT);
                cmd.Parameters.AddWithValue("email", nv.Email);
                cmd.Parameters.AddWithValue("matKhau", "11111111");
                cmd.Parameters.AddWithValue("cmnd", nv.CMND);
                cmd.Parameters.AddWithValue("diachi", nv.DiaChi);
                cmd.Parameters.AddWithValue("loainv", nv.LoaiNV);
                return (cmd.ExecuteNonQuery());

            }
        }

        public NhanVien GetNV(int id)
        {
            NhanVien NV = new NhanVien();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "SELECT * FROM nhanvien WHERE MANV = @manv";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("manv", id);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
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
                    reader.Close();
                }
                conn.Close();
            }
            return NV;
        }

        public int DeleteNV(int id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from giaohang where MANV=@manv;" +
                    "delete from phieunhap where MANV=@manv";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("manv", id);
                cmd.ExecuteNonQuery();
                str = "delete from nhanvien where MANV=@manv";
                MySqlCommand cmd1 = new MySqlCommand(str, conn);                
                cmd1.Parameters.AddWithValue("manv", id);
                return (cmd1.ExecuteNonQuery());
            }
        }

        public int UpdateNV(NhanVien nv)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update NhanVien " +
                    "set TENNV=@tennv, NGAYVL=@ngayvl, LUONG=@luong, SDT=@sdt, EMAIL=@email, CMND=@cmnd, DIACHI=@diachi, LOAINV=@loainv " +
                    "where MANV=@manv";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("tennv", nv.TenNV);
                cmd.Parameters.AddWithValue("ngayvl", nv.NgayVL);
                cmd.Parameters.AddWithValue("luong", nv.Luong);
                cmd.Parameters.AddWithValue("sdt", nv.SDT);
                cmd.Parameters.AddWithValue("email", nv.Email);
                cmd.Parameters.AddWithValue("cmnd", nv.CMND);
                cmd.Parameters.AddWithValue("diachi", nv.DiaChi);
                cmd.Parameters.AddWithValue("loainv", nv.LoaiNV);
                cmd.Parameters.AddWithValue("manv", nv.MaNV);
                return (cmd.ExecuteNonQuery());
            }
        }

        ///Nhà cung cấp
        public List<NhaCungCap> GetNhaCungCaps()
        {
            List<NhaCungCap> list = new List<NhaCungCap>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from nhacc";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new NhaCungCap()
                        {
                            mancc = reader["MaNCC"].ToString(),
                            tenncc = reader["TenNCC"].ToString(),
                            email = reader["Email"].ToString(),
                            sdt = reader["SDT"].ToString(),
                            diachi = reader["DiaChi"].ToString(),
                            website = reader["Website"].ToString(),
                        });
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }
        public int ThemNCC(NhaCungCap ncc)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into nhacc values(@MaNCC, @TenNCC, @Email, @SDT, @DiaChi, @Website)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("MaNCC", ncc.mancc);
                cmd.Parameters.AddWithValue("TenNCC", ncc.tenncc);
                cmd.Parameters.AddWithValue("Email", ncc.email);
                cmd.Parameters.AddWithValue("SDT", ncc.sdt);
                cmd.Parameters.AddWithValue("DiaChi", ncc.diachi);
                cmd.Parameters.AddWithValue("Website", ncc.website);
                return (cmd.ExecuteNonQuery());
            }
        }
        public int XoaNCC(string tt)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from nhacc where mancc=@MaNCC";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("MaNCC", tt);
                return (cmd.ExecuteNonQuery());
            }
        }
        public int SuaNCC(NhaCungCap ncc)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update nhacc set tenncc = @TenNCC, email = @Email, sdt = @SDT, diachi = @DiaChi, website = @Website where mancc=@MaNCC";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("MaNCC", ncc.mancc);
                cmd.Parameters.AddWithValue("TenNCC", ncc.tenncc);
                cmd.Parameters.AddWithValue("Email", ncc.email);
                cmd.Parameters.AddWithValue("SDT", ncc.sdt);
                cmd.Parameters.AddWithValue("DiaChi", ncc.diachi);
                cmd.Parameters.AddWithValue("Website", ncc.website);
                return (cmd.ExecuteNonQuery());
            }
        }
        public NhaCungCap GetNhaCungCapTheoMa(int id)
        {
            NhaCungCap list = new NhaCungCap();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from nhacc where mancc=@id";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("id", id);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.mancc = reader["MaNCC"].ToString();
                        list.tenncc = reader["TenNCC"].ToString();
                        list.email = reader["Email"].ToString();
                        list.sdt = reader["SDT"].ToString();
                        list.diachi = reader["DiaChi"].ToString();
                        list.website = reader["Website"].ToString();
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }

        ///////Tin tức///////
        public List<TinTuc> GetTinTucs()
        {
            List<TinTuc> list = new List<TinTuc>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from tintuc";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new TinTuc()
                        {
                            matintuc = reader["MaTinTuc"].ToString(),
                            hinhbia = reader["HinhBia"].ToString(),
                            tieude = reader["TieuDe"].ToString(),
                            link = reader["Link"].ToString(),
                            noidung = reader["NoiDung"].ToString(),
                            trangthai = int.Parse(reader["TrangThai"].ToString()),
                        });
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }
        public TinTuc GetTinTucTheoMa(int id)
        {
            TinTuc list = new TinTuc();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from tintuc where matintuc=@id";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("id", id);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.matintuc = reader["MaTinTuc"].ToString();
                        list.hinhbia = reader["HinhBia"].ToString();
                        list.tieude = reader["TieuDe"].ToString();
                        list.link = reader["Link"].ToString();
                        list.noidung = reader["NoiDung"].ToString();
                        list.trangthai = int.Parse(reader["TrangThai"].ToString());
                    }
                    reader.Close();
                }

                conn.Close();

            }
            return list;
        }
        public int ThemTT(TinTuc tt)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into tintuc values(@MaTinTuc, @HinhBia, @TieuDe, @NoiDung, @Link, @TrangThai)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("MaTinTuc", tt.matintuc);
                cmd.Parameters.AddWithValue("HinhBia", tt.hinhbia);
                cmd.Parameters.AddWithValue("TieuDe", tt.tieude);
                cmd.Parameters.AddWithValue("NoiDung", tt.noidung);
                cmd.Parameters.AddWithValue("Link", tt.link);
                cmd.Parameters.AddWithValue("TrangThai", tt.trangthai);
                return (cmd.ExecuteNonQuery());
            }
        }
        public int XoaTT(string tt)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from tintuc where matintuc=@MaTinTuc";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("MaTinTuc", tt);
                return (cmd.ExecuteNonQuery());
            }
        }
        public int SuaTT(TinTuc tt)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update tintuc set hinhbia = @HinhBia, tieude = @TieuDe, link = @Link, trangthai = @TrangThai, noidung = @NoiDung where matintuc=@MaTinTuc";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("MaTinTuc", tt.matintuc);
                cmd.Parameters.AddWithValue("HinhBia", tt.hinhbia);
                cmd.Parameters.AddWithValue("TieuDe", tt.tieude);
                cmd.Parameters.AddWithValue("NoiDung", tt.noidung);
                cmd.Parameters.AddWithValue("Link", tt.link);
                cmd.Parameters.AddWithValue("TrangThai", tt.trangthai);
                return (cmd.ExecuteNonQuery());
            }
        }



        //////Khuyến mãi
        public List<KhuyenMai> GetKhuyenMais()
        {
            List<KhuyenMai> list = new List<KhuyenMai>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from khuyenmai";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new KhuyenMai()
                        {
                            MaKM = Int32.Parse(reader["MAKM"].ToString()),
                            SoPTKM = Int32.Parse(reader["SOPTKM"].ToString()),
                            TuNgay = DateTime.Parse(reader["TUNGAY"].ToString()),
                            DenNgay = DateTime.Parse(reader["DENNGAY"].ToString()),
                            TTienToiThieu = Int32.Parse(reader["TTIENTOITHIEU"].ToString()),
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public int[] XoaKhuyenMai(string km)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();

                var queryKHUYENMAI = "delete from khuyenmai where MAKM=@makm";
                MySqlCommand cmd1 = new MySqlCommand(queryKHUYENMAI, conn);
                cmd1.Parameters.AddWithValue("makm", km);
                int[] deleted = new int[1];
                deleted[0] = cmd1.ExecuteNonQuery();
                return deleted;
            }
        }
        public KhuyenMai ViewKhuyenMai(string Id)
        {
            KhuyenMai km = new KhuyenMai();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select * from khuyenmai where MAKM = @makm";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("makm", Id);
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    km.MaKM = Int32.Parse(reader["MAKM"].ToString());
                    km.SoPTKM = Int32.Parse(reader["SOPTKM"].ToString());
                    km.TuNgay = DateTime.Parse(reader["TUNGAY"].ToString());
                    km.DenNgay = DateTime.Parse(reader["DENNGAY"].ToString());
                    km.TTienToiThieu = Int32.Parse(reader["TTIENTOITHIEU"].ToString());
                }
                conn.Close();
            }
            return (km);
        }
        public int UpdateKhuyenMai(KhuyenMai km)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update khuyenmai set SOPTKM=@soptkm, TUNGAY=@tungay, DENNGAY=@denngay, TTIENTOITHIEU=@ttientoithieu where MAKM=@makm";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("MAKM", km.MaKM);
                cmd.Parameters.AddWithValue("SOPTKM", km.SoPTKM);
                cmd.Parameters.AddWithValue("TUNGAY", km.TuNgay);
                cmd.Parameters.AddWithValue("DENNGAY", km.DenNgay);
                cmd.Parameters.AddWithValue("TTIENTOITHIEU", km.TTienToiThieu);
                return (cmd.ExecuteNonQuery());
            }
        }
        public int InsertKhuyenMai(KhuyenMai km)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into khuyenmai values(@makm, @soptkm, @tungay, @denngay, @ttientoithieu)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("MAKM", km.MaKM);
                cmd.Parameters.AddWithValue("SOPTKM", km.SoPTKM);
                cmd.Parameters.AddWithValue("TUNGAY", km.TuNgay);
                cmd.Parameters.AddWithValue("DENNGAY", km.DenNgay);
                cmd.Parameters.AddWithValue("TTIENTOITHIEU", km.TTienToiThieu);
                return (cmd.ExecuteNonQuery());
            }
        }


        //////Hổ trợ
        public List<HoTro> GetHoTros()
        {
            List<HoTro> list = new List<HoTro>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from binhluan, thongtinsp, khachhang where binhluan.mattsp = thongtinsp.mattsp and binhluan.makh = khachhang.makh";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new HoTro()
                        {
                            MABL = Int32.Parse(reader["MABL"].ToString()),
                            TENSP = reader["TENSP"].ToString(),
                            TENKH = reader["TENKH"].ToString(),
                            NOIDUNG = reader["NOIDUNG"].ToString(),
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public int[] XoaHoTro(string ht)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();

                var queryBINHLUAN = "delete from binhluan where MABL=@mabl";
                MySqlCommand cmd1 = new MySqlCommand(queryBINHLUAN, conn);
                cmd1.Parameters.AddWithValue("mabl", ht);
                int[] deleted = new int[1];
                deleted[0] = cmd1.ExecuteNonQuery();
                return deleted;
            }
        }
        public HoTro ViewHoTro(string Id)
        {
            HoTro ht = new HoTro();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select * from binhluan where MABL = @mabl";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("mabl", Id);
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    ht.MABL = Int32.Parse(reader["MABL"].ToString());
                    ht.MATTSP = Int32.Parse(reader["MATTSP"].ToString());
                    ht.MAKH = Int32.Parse(reader["MAKH"].ToString());
                    ht.NOIDUNG = reader["NOIDUNG"].ToString();
                }
                conn.Close();
            }
            return (ht);
        }


        ////Sản phẩm
        public (List<SanPham> sp, int pages, int page) GetSanPhams(int page)
        {
            List<SanPham> list = new List<SanPham>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from thongtinsp, loaisp, thuonghieu where thongtinsp.maloaisp = loaisp.maloaisp and thongtinsp.math = thuonghieu.math";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new SanPham()
                        {
                            MATTSP = reader["MATTSP"].ToString(),
                            TENSP = reader["TENSP"].ToString(),
                            HINHANH = reader["HINHANH"].ToString(),
                            TENLOAISP = reader["TENLOAISP"].ToString(),
                            TENTH = reader["TENTH"].ToString(),
                            GIA = Int32.Parse(reader["GIA"].ToString()),
                            GIAKM = Int32.Parse(reader["GIAKM"].ToString()),
                            SOLUONG = Int32.Parse(reader["SOLUONG"].ToString()),
                            MAUSAC = reader["MAUSAC"].ToString(),
                            RAM = Int32.Parse(reader["RAM"].ToString()),
                            BONHOTRONG = Int32.Parse(reader["BONHOTRONG"].ToString()),
                            PIN = Int32.Parse(reader["PIN"].ToString()),
                            KICHTHUOCMANHINH = float.Parse(reader["KICHTHUOCMANHINH"].ToString()),
                            CAMERATRUOC = reader["CAMERATRUOC"].ToString(),
                            CAMERASAU = reader["CAMERASAU"].ToString(),
                            CPU = reader["CPU"].ToString()
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            int Size = 8;
            int pages = (int)Math.Ceiling((double)list.Count / Size);
            List<SanPham> dssp = list.Skip((page - 1) * Size).Take(Size).ToList();
            return (dssp, pages, page);
        }
        public int[] XoaSanPham(string mattsp)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();

                var queryBINHLUAN = "delete from binhluan where MATTSP=@mattsp";
                MySqlCommand cmd1 = new MySqlCommand(queryBINHLUAN, conn);
                cmd1.Parameters.AddWithValue("mattsp", mattsp);

                var queryGIOHANG = "delete from giohang where MATTSP=@mattsp";
                MySqlCommand cmd3 = new MySqlCommand(queryGIOHANG, conn);
                cmd3.Parameters.AddWithValue("mattsp", mattsp);

                var queryTHONGTINSP = "delete from thongtinsp where MATTSP=@mattsp";
                MySqlCommand cmd5 = new MySqlCommand(queryTHONGTINSP, conn);
                cmd5.Parameters.AddWithValue("mattsp", mattsp);

                var queryCTHD = "delete from cthd where MATTSP=@mattsp";
                MySqlCommand cmd6 = new MySqlCommand(queryCTHD, conn);
                cmd6.Parameters.AddWithValue("mattsp", mattsp);

                var queryCTPN = "delete from ctpn where MATTSP=@mattsp";
                MySqlCommand cmd7 = new MySqlCommand(queryCTPN, conn);
                cmd7.Parameters.AddWithValue("mattsp", mattsp);

                var queryGIAOHANG = "delete from giaohang where MaHD IN (select distinct MaHD from cthd where cthd.MATTSP=@mattsp)";
                MySqlCommand cmd8 = new MySqlCommand(queryGIAOHANG, conn);
                cmd8.Parameters.AddWithValue("mattsp", mattsp);

                var queryHOADON = "delete from hoadon where MaHD IN (select distinct MAHD from cthd where cthd.MATTSP=@mattsp)";
                MySqlCommand cmd9 = new MySqlCommand(queryHOADON, conn);
                cmd9.Parameters.AddWithValue("mattsp", mattsp);

                var queryPHIEUNHAP = "delete from phieunhap where  MaPN IN (select distinct MaPN from ctpn where ctpn.MATTSP=@mattsp)";
                MySqlCommand cmd10 = new MySqlCommand(queryPHIEUNHAP, conn);
                cmd10.Parameters.AddWithValue("mattsp", mattsp);
                int[] deleted = new int[10];
                deleted[0] = cmd1.ExecuteNonQuery();
                
                deleted[2] = cmd3.ExecuteNonQuery();
               
                deleted[4] = cmd5.ExecuteNonQuery();
                deleted[5] = cmd6.ExecuteNonQuery();
                deleted[6] = cmd7.ExecuteNonQuery();
                deleted[7] = cmd8.ExecuteNonQuery();
                deleted[8] = cmd9.ExecuteNonQuery();
                deleted[9] = cmd10.ExecuteNonQuery();
                return deleted;
            }
        }
        public SanPham ViewSanPham(string Id)
        {
            SanPham ttsp = new SanPham();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select * from thongtinsp where MATTSP = @mattsp";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("mattsp", Id);
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    ttsp.MATTSP = reader["MATTSP"].ToString();
                    ttsp.TENSP = reader["TENSP"].ToString();
                    ttsp.HINHANH = reader["HINHANH"].ToString();
                    ttsp.MALOAISP = Int32.Parse(reader["MALOAISP"].ToString());
                    ttsp.MATH = Int32.Parse(reader["MATH"].ToString());
                    ttsp.GIA = Int32.Parse(reader["GIA"].ToString());
                    ttsp.GIAKM = Int32.Parse(reader["GIAKM"].ToString());
                    ttsp.SOLUONG = Int32.Parse(reader["SOLUONG"].ToString());
                    ttsp.MAUSAC = reader["MAUSAC"].ToString();
                    ttsp.RAM = Int32.Parse(reader["RAM"].ToString());
                    ttsp.BONHOTRONG = Int32.Parse(reader["BONHOTRONG"].ToString());
                    ttsp.PIN = Int32.Parse(reader["PIN"].ToString());
                    ttsp.KICHTHUOCMANHINH = float.Parse(reader["KICHTHUOCMANHINH"].ToString());
                    ttsp.CAMERATRUOC = reader["CAMERATRUOC"].ToString();
                    ttsp.CAMERASAU = reader["CAMERASAU"].ToString();
                    ttsp.CPU = reader["CPU"].ToString();
                }
                conn.Close();
            }
            return (ttsp);
        }
        public int UpdateSanPham(SanPham ttsp)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update thongtinsp set TENSP=@tensp, HINHANH=@hinhanh, MALOAISP=@maloaisp, MATH=@math, GIA=@gia, GIAKM=@giakm, SOLUONG=@soluong, MAUSAC=@mausac, RAM=@ram, BONHOTRONG=@bonhotrong, PIN=@pin, KICHTHUOCMANHINH=@kichthuocmanhinh, CAMERATRUOC=@cameratruoc, CAMERASAU=@camerasau, CPU=@cpu where MATTSP=@mattsp";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("MATTSP", ttsp.MATTSP);
                cmd.Parameters.AddWithValue("TENSP", ttsp.TENSP);
                cmd.Parameters.AddWithValue("HINHANH", ttsp.HINHANH);
                cmd.Parameters.AddWithValue("MALOAISP", ttsp.MALOAISP);
                cmd.Parameters.AddWithValue("MATH", ttsp.MATH);
                cmd.Parameters.AddWithValue("GIA", ttsp.GIA);
                cmd.Parameters.AddWithValue("GIAKM", ttsp.GIAKM);
                cmd.Parameters.AddWithValue("SOLUONG", ttsp.SOLUONG);
                cmd.Parameters.AddWithValue("MAUSAC", ttsp.MAUSAC);
                cmd.Parameters.AddWithValue("RAM", ttsp.RAM);
                cmd.Parameters.AddWithValue("BONHOTRONG", ttsp.BONHOTRONG);
                cmd.Parameters.AddWithValue("PIN", ttsp.PIN);
                cmd.Parameters.AddWithValue("KICHTHUOCMANHINH", ttsp.KICHTHUOCMANHINH);
                cmd.Parameters.AddWithValue("CAMERATRUOC", ttsp.CAMERATRUOC);
                cmd.Parameters.AddWithValue("CAMERASAU", ttsp.CAMERASAU);
                cmd.Parameters.AddWithValue("CPU", ttsp.CPU);
                return (cmd.ExecuteNonQuery());
            }
        }
        public int InsertSanPham(SanPham ttsp)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into thongtinsp values(@mattsp, @tensp, @hinhanh, @maloaisp, @math, @gia, @giakm, @soluong, @mausac, @ram, @bonhotrong, @pin, @kichthuocmanhinh, @cameratruoc, @camerasau, @cpu)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("MATTSP", ttsp.MATTSP);
                cmd.Parameters.AddWithValue("TENSP", ttsp.TENSP);
                cmd.Parameters.AddWithValue("HINHANH", ttsp.HINHANH);
                cmd.Parameters.AddWithValue("MALOAISP", ttsp.MALOAISP);
                cmd.Parameters.AddWithValue("MATH", ttsp.MATH);
                cmd.Parameters.AddWithValue("GIA", ttsp.GIA);
                cmd.Parameters.AddWithValue("GIAKM", ttsp.GIAKM);
                cmd.Parameters.AddWithValue("SOLUONG", ttsp.SOLUONG);
                cmd.Parameters.AddWithValue("MAUSAC", ttsp.MAUSAC);
                cmd.Parameters.AddWithValue("RAM", ttsp.RAM);
                cmd.Parameters.AddWithValue("BONHOTRONG", ttsp.BONHOTRONG);
                cmd.Parameters.AddWithValue("PIN", ttsp.PIN);
                cmd.Parameters.AddWithValue("KICHTHUOCMANHINH", ttsp.KICHTHUOCMANHINH);
                cmd.Parameters.AddWithValue("CAMERATRUOC", ttsp.CAMERATRUOC);
                cmd.Parameters.AddWithValue("CAMERASAU", ttsp.CAMERASAU);
                cmd.Parameters.AddWithValue("CPU", ttsp.CPU);
                return (cmd.ExecuteNonQuery());
            }
        }
        public List<SanPham> FindSanPham(string ten)
        {
            List<SanPham> list = new List<SanPham>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from thongtinsp where TENSP=@tensp";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("tensp", ten);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            list.Add(new SanPham()
                            {
                                MATTSP = reader["MATTSP"].ToString(),
                                TENSP = reader["TENSP"].ToString(),
                                HINHANH = reader["HINHANH"].ToString(),
                                MALOAISP = Int32.Parse(reader["MALOAISP"].ToString()),
                                MATH = Int32.Parse(reader["MATH"].ToString()),
                                GIA = Int32.Parse(reader["GIA"].ToString()),
                                GIAKM = Int32.Parse(reader["GIAKM"].ToString()),
                                SOLUONG = Int32.Parse(reader["SOLUONG"].ToString()),
                                MAUSAC = reader["MAUSAC"].ToString(),
                                RAM = Int32.Parse(reader["RAM"].ToString()),
                                BONHOTRONG = Int32.Parse(reader["BONHOTRONG"].ToString()),
                                PIN = Int32.Parse(reader["PIN"].ToString()),
                                KICHTHUOCMANHINH = float.Parse(reader["KICHTHUOCMANHINH"].ToString()),
                                CAMERATRUOC = reader["CAMERATRUOC"].ToString(),
                                CAMERASAU = reader["CAMERASAU"].ToString(),
                                CPU = reader["CPU"].ToString()
                            });
                        }
                        reader.Close();
                    }
                }
                conn.Close();
            }
            return list;
        }

        public List<LoaiSanPham> GetLoaiSanPhams()
        {
            List<LoaiSanPham> list = new List<LoaiSanPham>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from loaisp";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new LoaiSanPham()
                        {
                            MALOAISP = Int32.Parse(reader["MALOAISP"].ToString()),
                            TENLOAISP = reader["TENLOAISP"].ToString(),
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public List<ThuongHieu> GetThuongHieus()
        {
            List<ThuongHieu> list = new List<ThuongHieu>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from thuonghieu";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new ThuongHieu()
                        {
                            MATH = Int32.Parse(reader["MATH"].ToString()),
                            TENTH = reader["TENTH"].ToString(),
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public int InsertLoaiSanPham(string TENLOAISP)
        {

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into loaisp values(null, @tenloaisp)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("tenloaisp", TENLOAISP);
                return (cmd.ExecuteNonQuery());
            }
        }
        public int InsertThuongHieu(ThuongHieu th)
        {

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into thuonghieu values(null, @tenth)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("tenth", th.TENTH);
                return (cmd.ExecuteNonQuery());
            }
        }
        public int[] XoaLoaiSanPham(string lsp)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var queryLOAISANPHAM = "delete from loaisp where TENLOAISP=@tenloaisp";
                MySqlCommand cmd1 = new MySqlCommand(queryLOAISANPHAM, conn);
                cmd1.Parameters.AddWithValue("tenloaisp", lsp);
                int[] deleted = new int[1];
                deleted[0] = cmd1.ExecuteNonQuery();
                return deleted;
            }
        }
        public int[] XoaThuongHieu(string th)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var queryTHUONGHIEU = "delete from thuonghieu where TENTH=@tenth";
                MySqlCommand cmd1 = new MySqlCommand(queryTHUONGHIEU, conn);
                cmd1.Parameters.AddWithValue("tenth", th);
                int[] deleted = new int[1];
                deleted[0] = cmd1.ExecuteNonQuery();
                return deleted;
            }
        }

        ////////Phiếu nhập
        public List<CTPN> GetDSCTPN(int MAPN)
        {
            List<CTPN> list = new List<CTPN>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select MAPN, CTPN.MATTSP, ctpn.SOLUONG, TENSP, GIANHAP, THANHTIEN from ctpn join thongtinsp sp on ctpn.mattsp = sp.mattsp where MAPN = @mapn";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("mapn", MAPN);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new CTPN()
                        {
                            MAPN = Convert.ToInt32(reader["MAPN"]),
                            MATTSP = Convert.ToInt32(reader["MATTSP"]),
                            SOLUONG = Convert.ToInt32(reader["SOLUONG"]),
                            GIANHAP = Convert.ToInt32(reader["GIANHAP"]),
                            THANHTIEN = Convert.ToInt32(reader["THANHTIEN"]),
                            TENSP = reader["TENSP"].ToString()
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public int InsertCTPN(CTPN ct)
        {
            List<int> list = new List<int>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select mattsp from ctpn where mapn = @mapn and mattsp = @mattsp";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("mapn", ct.MAPN);
                cmd.Parameters.AddWithValue("mattsp", ct.MATTSP);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(Convert.ToInt32(reader["mattsp"]));
                    }
                    reader.Close();
                }
                if (list.Count() > 0)
                {
                    var sql = "update ctpn set soluong = @sl, gianhap = @gn where mapn = @mapn and mattsp = @mattsp";
                    MySqlCommand cmd1 = new MySqlCommand(sql, conn);
                    cmd1.Parameters.AddWithValue("sl", ct.SOLUONG);
                    cmd1.Parameters.AddWithValue("gn", ct.GIANHAP);
                    cmd1.Parameters.AddWithValue("mapn", ct.MAPN);
                    cmd1.Parameters.AddWithValue("mattsp", ct.MATTSP);
                    return (cmd1.ExecuteNonQuery());
                }
                else
                {
                    var sql = "insert into ctpn(mapn, mattsp, soluong, gianhap) values(@mapn, @mattsp, @sl, @gn)";
                    MySqlCommand cmd1 = new MySqlCommand(sql, conn);
                    cmd1.Parameters.AddWithValue("sl", ct.SOLUONG);
                    cmd1.Parameters.AddWithValue("gn", ct.GIANHAP);
                    cmd1.Parameters.AddWithValue("mapn", ct.MAPN);
                    cmd1.Parameters.AddWithValue("mattsp", ct.MATTSP);
                    return (cmd1.ExecuteNonQuery());
                }
            }
        }
        
        public int DeleteCTPN(int mapn, int mattsp)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "delete from ctpn where MAPN = @mapn and MATTSP = @masp;";
                MySqlCommand cmd1 = new MySqlCommand(str, conn);
                cmd1.Parameters.AddWithValue("mapn", mapn);
                cmd1.Parameters.AddWithValue("masp", mattsp);

                return (cmd1.ExecuteNonQuery());
            }
        }

        /////Phiếu nhập
        ///
        public List<NhapHang> GetNhapHangs()
        {
            List<NhapHang> list = new List<NhapHang>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from phieunhap, nhacc, nhanvien where phieunhap.mancc = nhacc.mancc and phieunhap.manv = nhanvien.manv";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new NhapHang()
                        {
                            MAPN = Int32.Parse(reader["MAPN"].ToString()),
                            TONGTIENTT = Int32.Parse(reader["TONGTIENTT"].ToString()),
                            NGAYLAPPN = DateTime.Parse(reader["NGAYLAPPN"].ToString()),
                            TINHTRANGTT = Int32.Parse(reader["TINHTRANGTT"].ToString()),
                            TENNCC = reader["TENNCC"].ToString(),
                            TENNV = reader["TENNV"].ToString(),
                        });
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return list;
        }
        public int XoaNhapHang(string nh)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();

                var queryPHIEUNHAP = "delete from ctpn where MAPN = @mapn;" +
                    "delete from phieunhap where MAPN=@mapn";
                MySqlCommand cmd1 = new MySqlCommand(queryPHIEUNHAP, conn);
                cmd1.Parameters.AddWithValue("mapn", nh);
                return cmd1.ExecuteNonQuery();
                
            }
        }
        public NhapHang ViewNhapHang(string Id)
        {
            NhapHang nh = new NhapHang();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "select * from phieunhap where MAPN = @mapn";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("mapn", Id);
                using (var reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    nh.MAPN = Int32.Parse(reader["MAPN"].ToString());
                    nh.TONGTIENTT = Int32.Parse(reader["TONGTIENTT"].ToString());
                    nh.NGAYLAPPN = DateTime.Parse(reader["NGAYLAPPN"].ToString());
                    nh.TINHTRANGTT = Int32.Parse(reader["TINHTRANGTT"].ToString());
                    nh.MANCC = Int32.Parse(reader["MANCC"].ToString());
                    nh.MANV = Int32.Parse(reader["MANV"].ToString());
                }
                conn.Close();
            }
            return (nh);
        }
        public int UpdateNhapHang(NhapHang nh)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "update phieunhap set TINHTRANGTT=@tinhtrangtt, MANCC=@mancc, MANV=@manv where MAPN=@mapn";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("tinhtrangtt", nh.TINHTRANGTT);
                cmd.Parameters.AddWithValue("mancc", nh.MANCC);
                cmd.Parameters.AddWithValue("manv", nh.MANV);
                cmd.Parameters.AddWithValue("mapn", nh.MAPN);
                return (cmd.ExecuteNonQuery());
            }
        }
        public int InsertNhapHang(NhapHang nh)
        {

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var str = "insert into phieunhap values(@mapn, @tongtientt, @ngaylappn, @tinhtrangtt, @mancc, @manv)";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("MAPN", nh.MAPN);
                cmd.Parameters.AddWithValue("TONGTIENTT", nh.TONGTIENTT);
                cmd.Parameters.AddWithValue("NGAYLAPPN", nh.NGAYLAPPN);
                cmd.Parameters.AddWithValue("TINHTRANGTT", nh.TINHTRANGTT);
                cmd.Parameters.AddWithValue("MANCC", nh.MANCC);
                cmd.Parameters.AddWithValue("MANV", nh.MANV);
                return (cmd.ExecuteNonQuery());
            }
        }
        public List<CTPN> GetCTPNs()
        {
            List<CTPN> list = new List<CTPN>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string str = "select * from ctpn, thongtinsp where thongtinsp.mattsp = ctpn.mattsp";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new CTPN()
                        {
                            MAPN = Int32.Parse(reader["MAPN"].ToString()),
                            MATTSP = Int32.Parse(reader["MATTSP"].ToString()),
                            TENSP = reader["TENSP"].ToString(),
                            GIANHAP = Int32.Parse(reader["GIANHAP"].ToString()),
                            SOLUONG = Int32.Parse(reader["SOLUONG"].ToString()),
                            THANHTIEN = Int32.Parse(reader["THANHTIEN"].ToString()),
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
