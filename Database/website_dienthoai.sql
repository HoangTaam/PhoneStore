-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Máy chủ: 127.0.0.1
-- Thời gian đã tạo: Th1 18, 2022 lúc 02:58 PM
-- Phiên bản máy phục vụ: 10.4.11-MariaDB
-- Phiên bản PHP: 7.2.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Cơ sở dữ liệu: `website_dienthoai`
--

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `binhluan`
--

CREATE TABLE `binhluan` (
  `MaBL` int(10) UNSIGNED NOT NULL,
  `MaTTSP` int(10) UNSIGNED NOT NULL,
  `MaKH` int(10) UNSIGNED NOT NULL,
  `NoiDung` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `binhluan`
--

INSERT INTO `binhluan` (`MaBL`, `MaTTSP`, `MaKH`, `NoiDung`) VALUES
(1, 3, 1, 'Nhân viên ko rành khuyến mãi và hình thức trả góp. Tuy nhiên thái độ phục vụ rất tốt. Hàng chuẩn chính hãng'),
(2, 3, 4, 'Mới mua được vài tháng bị điểm chết màn hình. Gửi bảo hành gần 1 tháng không xong, gọi điện tổng đài nhân viên toàn hẹn, hẹn xong không thấy phản hồi để gọi đi gọi lại nhiều lần.'),
(3, 3, 2, 'Xài rất ổn nha mn ơi. Pin tuy 2815 chứ trâu lắm à nha. Cam cũng đẹp, độ chi tiết cao nhưng ko rực rỡ như not10+. Lướt web mượt mà. Đặc biệt gọi zalo máy mát rượi. Sạc pin tầm 1h20 = củ sạc 12W của ipad. Mua 03/7/2021 tới giờ vẫn ngon và chưa có ý định lên ip13. Đáng mua sử dụng lâu dài nha ahihi\r\n\r\n'),
(4, 3, 2, 'XMua đc 5 tháng máy rất trơn rớt hoài bể hết mặt sau mua gói bảo hiểm 6 tháng lh nguyên tháng ko giải quyết. Chắc đợi hết tháng hết bảo hiểm là xog.'),
(5, 1, 2, 'Điện thoại iphone của mình hiện các dòng chữ xám như vậy làm mình không đăng xuất được Icloud, mình hiện tại đã tắt thời gian sử dụng và đã tắt nguồn khởi động máy lại mà nó vẫn như vậy, tgdd cho mình cách khắc phục với ạ'),
(6, 1, 2, 'sao bình thường được bạn, bạn xem lại kĩ giúp mình, phần chữ nó xám xịt thế kia mình không thể bấm đăng xuất được, chứ đỏ mới bấm đăng xuất được chứ'),
(7, 1, 2, 'Dạ nếu sản phẩm mình mua mới tại Thegioididong.com hoặc Dienmayxanh.com từ ngày 1/3/2021 trong vòng 8 tháng gần đây, không bị trầy xước cấn móp, ngấm chất lỏng, còn giữ nguyên tình trạng ban đầu, không bị lỗi do người dùng, còn đủ phụ kiện và khuyến mãi kèm theo thì bên em có chính sách thu lại ạ. Mình vui lòng cung cấp số điện thoại mua hàng để bên em hỗ trợ tính giá thu lại tham khảo giúp mình ạ! '),
(8, 1, 2, 'Dạ sản phẩm hiện tạm hết hàng tại khu vực của mình, nếu quan tâm, mình thông tin thêm khu vực phường/xã bên em hỗ trợ kiểm tra sản phẩm có chuyển hàng về được hay không giúp mình nhé\r\nMong nhận phản hồi từ anh.'),
(9, 4, 4, 'Sản phẩm đẹp, dịch vụ tốt'),
(12, 6, 4, 'Màn hình rất đẹp, coi youtube rất ổn, shop phục vụ nhiệt tình'),
(13, 13, 2, 'Sản phẩm tốt.');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `cthd`
--

CREATE TABLE `cthd` (
  `MaHD` int(10) UNSIGNED NOT NULL,
  `MaTTSP` int(10) UNSIGNED NOT NULL,
  `SoLuong` int(5) NOT NULL,
  `ThanhTien` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `cthd`
--

INSERT INTO `cthd` (`MaHD`, `MaTTSP`, `SoLuong`, `ThanhTien`) VALUES
(1, 3, 1, 27000000),
(4, 3, 1, 27000000),
(4, 10, 1, 39450000),
(5, 1, 1, 180000),
(5, 4, 1, 4000000),
(6, 3, 1, 27000000),
(6, 10, 1, 39450000),
(7, 6, 1, 22500000),
(8, 3, 1, 27000000),
(9, 7, 1, 5000000),
(10, 3, 1, 27000000),
(10, 5, 1, 8500000),
(11, 4, 2, 8000000),
(12, 3, 1, 27000000),
(13, 3, 1, 27000000),
(14, 11, 1, 11990000),
(15, 10, 1, 39450000),
(16, 6, 1, 22500000),
(16, 13, 1, 14990000);

--
-- Bẫy `cthd`
--
DELIMITER $$
CREATE TRIGGER `After_Delete_CTHD` AFTER DELETE ON `cthd` FOR EACH ROW BEGIN
	DECLARE v_TongTien INT;
    DECLARE v_TienGiam INT;
    DECLARE v_SoPTKM TinyINT(4);
    DECLARE v_NgayMua Date;
    DECLARE v_TuNgay Date;
    DECLARE v_DenNgay Date;
    DECLARE v_TTienToiThieu INT;
    DECLARE v_MaKM INT;
    
     /*Cap nhat so luong*/
    UPDATE thongtinsp 
    SET thongtinsp.SoLuong = thongtinsp.SoLuong + OLD.SoLuong 
    WHERE thongtinsp.MaTTSP = OLD.MATTSP; 
    /*Tinh Tong Tien trong hoa don*/
    /*1. Tinh Tong tien chua ap dung khuyen mai*/
    	SELECT SUM(ThanhTien) INTO v_TongTien
        FROM cthd
        WHERE MaHD = OLD.MaHD;
        UPDATE hoadon
        SET TongTienTT = v_TongTien
        WHERE MaHD = OLD.MaHD;
    /*2. Lay thong tin tu hoa don*/
    	SELECT NgayLapHD, MaKM INTO v_NgayMua, v_MaKM 
        FROM hoadon
        WHERE MaHD = OLD.MAHD;
    /*3. Lay thong tin khuyen mai*/
    IF(v_MaKM IS NOT NULL) THEN
    	SELECT SoPTKM, TuNgay, DenNgay, TTienToiThieu
        INTO v_SoPTKM, v_TuNgay, v_DenNgay, v_TTienToiThieu
        FROM khuyenmai
        WHERE MaKM = v_MaKM;
        IF(v_NgayMua >= v_TuNgay AND v_NgayMua <= v_DenNgay AND v_TongTien >= v_TTienToiThieu) THEN
        	SET v_TienGiam = v_TongTien * (v_SoPTKM/100);
            UPDATE hoadon
            SET TongTienTT = v_TongTien - v_TienGiam
            WHERE MaHD = OLD.MaHD;
        END IF;
    END IF;
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `After_Insert_CTHD` AFTER INSERT ON `cthd` FOR EACH ROW BEGIN
    DECLARE v_TongTien INT;
    DECLARE v_TienGiam INT;
    DECLARE v_SoPTKM TinyINT(4);
    DECLARE v_NgayMua Date;
    DECLARE v_TuNgay Date;
    DECLARE v_DenNgay Date;
    DECLARE v_TTienToiThieu INT;
    DECLARE v_MaKM INT;
    /*Tinh Tong Tien trong hoa don*/
    /*1. Tinh Tong tien chua ap dung khuyen mai*/
    	SELECT SUM(ThanhTien) INTO v_TongTien
        FROM cthd
        WHERE MaHD = NEW.MaHD;
        UPDATE hoadon
        SET TongTienTT = v_TongTien
        WHERE MaHD = new.MaHD;
    /*2. Lay thong tin tu hoa don*/
    	SELECT NgayLapHD, MaKM INTO v_NgayMua, v_MaKM 
        FROM hoadon
        WHERE MaHD = NEW.MAHD;
    /*3. Lay thong tin khuyen mai*/
    IF(v_MaKM IS NOT NULL) THEN
    	SELECT SoPTKM, TuNgay, DenNgay, TTienToiThieu
        INTO v_SoPTKM, v_TuNgay, v_DenNgay, v_TTienToiThieu
        FROM khuyenmai
        WHERE MaKM = v_MaKM;
        IF(v_NgayMua >= v_TuNgay AND v_NgayMua <= v_DenNgay AND v_TongTien >= v_TTienToiThieu) THEN
        	SET v_TienGiam = v_TongTien * (v_SoPTKM/100);
            UPDATE hoadon
            SET TongTienTT = v_TongTien - v_TienGiam
            WHERE MaHD = new.MaHD;
        END IF;
    END IF;
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `After_Update_CTHD` AFTER UPDATE ON `cthd` FOR EACH ROW BEGIN
	DECLARE v_TongTien INT;
    DECLARE v_TienGiam INT;
    DECLARE v_SoPTKM TinyINT(4);
    DECLARE v_NgayMua Date;
    DECLARE v_TuNgay Date;
    DECLARE v_DenNgay Date;
    DECLARE v_TTienToiThieu INT;
    DECLARE v_MaKM INT;
    /*Tinh Tong Tien trong hoa don*/
    /*1. Tinh Tong tien chua ap dung khuyen mai*/
    	SELECT SUM(ThanhTien) INTO v_TongTien
        FROM cthd
        WHERE MaHD = NEW.MaHD;
        UPDATE hoadon
        SET TongTienTT = v_TongTien
        WHERE MaHD = new.MaHD;
    /*2. Lay thong tin tu hoa don*/
    	SELECT NgayLapHD, MaKM INTO v_NgayMua, v_MaKM 
        FROM hoadon
        WHERE MaHD = NEW.MAHD;
    /*3. Lay thong tin khuyen mai*/
    IF(v_MaKM IS NOT NULL) THEN
    	SELECT SoPTKM, TuNgay, DenNgay, TTienToiThieu
        INTO v_SoPTKM, v_TuNgay, v_DenNgay, v_TTienToiThieu
        FROM khuyenmai
        WHERE MaKM = v_MaKM;
        IF(v_NgayMua >= v_TuNgay AND v_NgayMua <= v_DenNgay AND v_TongTien >= v_TTienToiThieu) THEN
        	SET v_TienGiam = v_TongTien * (v_SoPTKM/100);
            UPDATE hoadon
            SET TongTienTT = v_TongTien - v_TienGiam
            WHERE MaHD = new.MaHD;
        END IF;
    END IF;
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `Before_Insert_CTHD` BEFORE INSERT ON `cthd` FOR EACH ROW BEGIN 
	DECLARE v_Gia INT; 
    DECLARE v_GiaKM INT; 
    DECLARE v_SoLuong INT; 
    /*Kiem tra so luong co du khong*/ 
    SELECT SoLuong INTO v_SoLuong 
    FROM thongtinsp 
    WHERE thongtinsp.MaTTSP = NEW.MaTTSP; 
    IF(v_SoLuong < NEW.SoLuong) THEN
    	 SIGNAL SQLSTATE '04000'
      	 SET MESSAGE_TEXT = 'Số lượng không đủ ', MYSQL_ERRNO = 4000; 
    END IF; 
    /*Cap nhat so luong san pham*/ 
    UPDATE thongtinsp 
    SET thongtinsp.SoLuong = thongtinsp.SoLuong - NEW.SoLuong 
    WHERE thongtinsp.MaTTSP = NEW.MATTSP; 
    /*Lay gia san pham*/ 
    SELECT thongtinsp.Gia, thongtinsp.GiaKM 
    into v_Gia, v_GiaKM 
    FROM thongtinsp 
    WHERE thongtinsp.MaTTSP = NEW.MaTTSP;
    /**/ 
    IF (v_GiaKM IS NOT NULL AND V_GiaKM != 0)THEN 
    	SET NEW.ThanhTien = v_GiaKM * NEW.SoLuong; 
    ELSE 
    	SET NEW.ThanhTien = v_Gia * NEW.SoLuong; 
    END IF; 
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `Before_Updated_CTHD` BEFORE UPDATE ON `cthd` FOR EACH ROW BEGIN 
	DECLARE v_Gia INT; 
    DECLARE v_GiaKM INT; 
    DECLARE v_SoLuong INT; 
    /*Kiem tra so luong co du khong*/ 
    SELECT SoLuong INTO v_SoLuong 
    FROM thongtinsp 
    WHERE thongtinsp.MaTTSP = NEW.MaTTSP; 
    IF((v_SoLuong + OLD.SoLuong) < NEW.SoLuong) THEN
    	 SIGNAL SQLSTATE '04000'
      	 SET MESSAGE_TEXT = 'Số lượng không đủ ', MYSQL_ERRNO = 4000; 
    END IF; 
    /*Cap nhat so luong san pham*/ 
    UPDATE thongtinsp 
    SET thongtinsp.SoLuong = thongtinsp.SoLuong + OLD.SoLuong - NEW.SoLuong 
    WHERE thongtinsp.MaTTSP = NEW.MaTTSP; 
    /*Lay gia san pham*/ 
    SELECT thongtinsp.Gia, thongtinsp.GiaKM 
    into v_Gia, v_GiaKM 
    FROM thongtinsp 
    WHERE thongtinsp.MaTTSP = NEW.MaTTSP; 
    /**/ 
    IF (v_GiaKM IS NOT NULL AND v_GiaKM != 0)THEN 
    	SET NEW.ThanhTien = v_GiaKM * NEW.SoLuong; 
    ELSE 
    SET NEW.ThanhTien = v_Gia * NEW.SoLuong; 
    END IF; 
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `ctpn`
--

CREATE TABLE `ctpn` (
  `MaPN` int(10) UNSIGNED NOT NULL,
  `MaTTSP` int(10) UNSIGNED NOT NULL,
  `GiaNhap` int(11) NOT NULL,
  `SoLuong` int(10) NOT NULL,
  `ThanhTien` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `ctpn`
--

INSERT INTO `ctpn` (`MaPN`, `MaTTSP`, `GiaNhap`, `SoLuong`, `ThanhTien`) VALUES
(1, 1, 300000, 9, 2700000),
(1, 6, 17000000, 5, 85000000),
(2, 1, 100000, 5, 500000),
(2, 6, 17000000, 2, 34000000),
(2, 10, 25000000, 10, 250000000),
(3, 5, 7500000, 10, 75000000),
(3, 11, 10500000, 10, 105000000);

--
-- Bẫy `ctpn`
--
DELIMITER $$
CREATE TRIGGER `Alter_Delete_CTPN` AFTER DELETE ON `ctpn` FOR EACH ROW BEGIN
	DECLARE v_ThanhTien INT DEFAULT 0;
	/*Cap nhat lai so luong san pham*/
    UPDATE thongtinsp
    SET thongtinsp.SoLuong = thongtinsp.SoLuong - OLD.SoLuong
    WHERE thongtinsp.mattsp = OLD.mattsp;
    /*Tinh Tong Tien trong phieu nhap*/
    SELECT SUM(ctpn.ThanhTien) INTO v_ThanhTien
    FROM ctpn
    WHERE ctpn.MaPN = OLD.MaPN;
    
	UPDATE phieunhap
    SET TongTienTT = v_ThanhTien
    WHERE MaPN = OLD.MaPN; 
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `Alter_Insert_CTPN` AFTER INSERT ON `ctpn` FOR EACH ROW BEGIN
	DECLARE v_ThanhTien INT DEFAULT 0;
	/*Cap nhat lai so luong san pham*/
    UPDATE thongtinsp
    SET thongtinsp.SoLuong = thongtinsp.SoLuong + NEW.SoLuong
    WHERE thongtinsp.mattsp = NEW.mattsp;
    /*Tinh Tong Tien trong phieu nhap*/
    SELECT SUM(ctpn.ThanhTien) INTO v_ThanhTien
    FROM ctpn
    WHERE ctpn.MaPN = NEW.MaPN;
    
	UPDATE phieunhap
    SET TongTienTT = v_ThanhTien
    WHERE MaPN = NEW.MaPN; 
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `Alter_Update_CTPN` AFTER UPDATE ON `ctpn` FOR EACH ROW BEGIN
	DECLARE v_ThanhTien INT DEFAULT 0;
	/*Cap nhat lai so luong san pham*/
    UPDATE thongtinsp
    SET thongtinsp.SoLuong = thongtinsp.SoLuong - OLD.SoLuong + NEW.SoLuong
    WHERE thongtinsp.MaTTSP = NEW.MaTTSP;
    /*Tinh Tong Tien trong phieu nhap*/
    SELECT SUM(ctpn.ThanhTien) INTO v_ThanhTien
    FROM ctpn
    WHERE ctpn.MaPN = NEW.MaPN;
    
	UPDATE phieunhap
    SET TongTienTT = v_ThanhTien
    WHERE MaPN = NEW.MaPN;
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `Before_Updated_CTPN` BEFORE UPDATE ON `ctpn` FOR EACH ROW BEGIN
	SET NEW.ThanhTien = NEW.GiaNhap * NEW.SoLuong;
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `Tinh_ThanhTien_CTPN` BEFORE INSERT ON `ctpn` FOR EACH ROW BEGIN 
    SET NEW.ThanhTien = NEW.GiaNhap * NEW.SoLuong;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `giaohang`
--

CREATE TABLE `giaohang` (
  `MaHD` int(10) UNSIGNED NOT NULL,
  `MaNV` int(10) UNSIGNED DEFAULT NULL,
  `TinhTrangGH` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `giaohang`
--

INSERT INTO `giaohang` (`MaHD`, `MaNV`, `TinhTrangGH`) VALUES
(4, 2, 1),
(5, NULL, 0),
(13, 6, 1),
(15, 5, 1),
(1, 5, 1),
(16, 5, 1);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `giohang`
--

CREATE TABLE `giohang` (
  `MaTTSP` int(10) UNSIGNED NOT NULL,
  `SoLuong` int(5) NOT NULL,
  `MaKH` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `giohang`
--

INSERT INTO `giohang` (`MaTTSP`, `SoLuong`, `MaKH`) VALUES
(6, 1, 2),
(11, 1, 1),
(13, 1, 2);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `hoadon`
--

CREATE TABLE `hoadon` (
  `MaHD` int(10) UNSIGNED NOT NULL,
  `MaKH` int(10) UNSIGNED NOT NULL,
  `MaKM` int(10) UNSIGNED DEFAULT NULL,
  `DiaChiGH` text DEFAULT NULL,
  `TongTienTT` int(11) NOT NULL,
  `NgayLapHD` date NOT NULL,
  `TinhTrangHD` int(1) NOT NULL,
  `TinhTrangTT` int(1) DEFAULT NULL,
  `SoTienNhan` int(11) DEFAULT NULL,
  `SoTienTra` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `hoadon`
--

INSERT INTO `hoadon` (`MaHD`, `MaKH`, `MaKM`, `DiaChiGH`, `TongTienTT`, `NgayLapHD`, `TinhTrangHD`, `TinhTrangTT`, `SoTienNhan`, `SoTienTra`) VALUES
(1, 1, 1, 'HCM', 27000000, '2021-12-23', 1, 1, 27000000, 0),
(4, 4, NULL, 'Đồng Nai', 66450000, '2022-01-01', 1, 1, 70000000, 3550000),
(5, 4, NULL, 'Q1, HCM', 4180000, '2022-01-02', 0, 0, 0, -4180000),
(6, 2, NULL, 'Q1, HCM', 66450000, '2022-01-02', 0, 0, 0, 0),
(7, 4, 6, 'Thủ Đức, HCM', 20700000, '2022-01-08', 0, 0, 0, 0),
(8, 1, NULL, 'Q1, HCM', 27000000, '2021-04-08', 1, 1, 27000000, 0),
(9, 2, NULL, 'Thủ Đức, Hồ Chí Min', 5000000, '2021-04-15', 1, 1, 5000000, 0),
(10, 4, NULL, 'Q9, Hồ Chí Minh', 35500000, '2021-12-16', 1, 1, 35500000, 0),
(11, 2, NULL, 'Q7, HCM', 8000000, '2021-12-17', 1, 1, 8000000, 0),
(12, 2, 6, 'Q1, HCM', 24840000, '2022-01-10', 0, 0, 0, 0),
(13, 1, 6, 'Linh trung, Thủ Đức, HCM', 24840000, '2022-01-11', 1, 0, 0, 0),
(14, 1, 6, 'Q1, HCM', 11030800, '2022-01-11', 0, 0, 0, 0),
(15, 2, 6, 'Đồng Nai', 36294000, '2022-01-12', 1, 1, 36294000, 0),
(16, 2, 6, 'Thủ Đức, HCM', 34490800, '2022-01-13', 1, 1, 34490800, 0);

--
-- Bẫy `hoadon`
--
DELIMITER $$
CREATE TRIGGER `Before_Update_HD` BEFORE UPDATE ON `hoadon` FOR EACH ROW BEGIN
	DECLARE v_TongTien INT;
    DECLARE v_TienGiam INT DEFAULT 0 ;
    DECLARE v_SoPTKM TinyINT(4);
    DECLARE v_NgayMua Date;
    DECLARE v_TuNgay Date;
    DECLARE v_DenNgay Date;
    DECLARE v_TTienToiThieu INT;
	IF((NEW.MaKM != OLD.MaKM) OR (NEW.NgayLapHD != OLD.NgayLapHD)) THEN
    	/*1. Tinh Tong tien chua ap dung khuyen mai*/
    	SELECT SUM(ThanhTien) INTO v_TongTien
        FROM cthd
        WHERE MaHD = NEW.MaHD;
        SET NEW.TongTienTT = v_TongTien;
        SET NEW.SoTienTra = NEW.SoTienNhan - NEW.TongTienTT;
		/*2. Lay thong tin khuyen mai*/
    	SELECT SoPTKM, TuNgay, DenNgay, TTienToiThieu
        INTO v_SoPTKM, v_TuNgay, v_DenNgay, v_TTienToiThieu
        FROM khuyenmai
        WHERE MaKM = NEW.MaKM;
        IF(NEW.NgayLapHD >= v_TuNgay AND NEW.NgayLapHD <= v_DenNgay AND v_TongTien >= v_TTienToiThieu) THEN
        	SET v_TienGiam = v_TongTien * (v_SoPTKM/100);
            SET NEW.TongTienTT = v_TongTien - v_TienGiam;
            SET NEW.SoTienTra = NEW.SoTienNhan - NEW.TongTienTT;
        END IF;
    END IF;
    IF(NEW.SoTienNhan != OLD.SoTienNhan) THEN
    	SET NEW.SoTienTra = NEW.SoTienNhan - NEW.TongTienTT;
    END IF;
    IF(NEW.SoTienNhan >= NEW.TongTienTT) THEN
    	SET NEW.TinhTrangTT = 1;
    ELSE
    	SET NEW.TinhTrangTT = 0;
    END IF;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `khachhang`
--

CREATE TABLE `khachhang` (
  `MaKH` int(10) UNSIGNED NOT NULL,
  `TenKH` varchar(50) NOT NULL,
  `GioiTinh` char(10) NOT NULL,
  `SDT` char(12) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `MatKhau` varchar(30) NOT NULL,
  `CMND` char(12) NOT NULL,
  `DiaChi` varchar(50) DEFAULT NULL,
  `LoaiKH` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `khachhang`
--

INSERT INTO `khachhang` (`MaKH`, `TenKH`, `GioiTinh`, `SDT`, `Email`, `MatKhau`, `CMND`, `DiaChi`, `LoaiKH`) VALUES
(1, 'Nguyễn Anh Dũng', 'Nam', '000011112222', 'AnhDung@gmail.com', '123456', '272811122', 'Thủ đức, HCM', 'Thân thiết'),
(2, 'Nguyễn Đăng Khoa', 'Nam', '033112223', 'DangKhoa@gmail.com', '123456', '271829304', 'Q1, HCM', 'Bình thường'),
(4, 'Đỗ Thị Mỹ Duyên', 'Nữ', '09811112223', 'MyDuyen@gmail.com', '123456', '291112233', 'Q8, HCM', 'Bình thường');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `khuyenmai`
--

CREATE TABLE `khuyenmai` (
  `MaKM` int(10) UNSIGNED NOT NULL,
  `SoPTKM` tinyint(4) NOT NULL,
  `TuNgay` date NOT NULL,
  `DenNgay` date NOT NULL,
  `TTienToiThieu` int(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `khuyenmai`
--

INSERT INTO `khuyenmai` (`MaKM`, `SoPTKM`, `TuNgay`, `DenNgay`, `TTienToiThieu`) VALUES
(1, 10, '2021-11-01', '2021-11-30', 100000),
(2, 12, '2021-12-10', '2021-12-26', 2000000),
(3, 9, '2021-11-26', '2021-12-01', 66666),
(4, 14, '2021-11-30', '2021-12-31', 0),
(6, 8, '2022-01-01', '2022-01-31', 500000);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `loaisp`
--

CREATE TABLE `loaisp` (
  `MaLoaiSP` int(10) UNSIGNED NOT NULL,
  `TenLoaiSP` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `loaisp`
--

INSERT INTO `loaisp` (`MaLoaiSP`, `TenLoaiSP`) VALUES
(1, 'Điện thoại'),
(2, 'Máy tính bảng');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `nhacc`
--

CREATE TABLE `nhacc` (
  `MaNCC` int(10) UNSIGNED NOT NULL,
  `TenNCC` varchar(50) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `SDT` char(12) NOT NULL,
  `DiaChi` varchar(50) DEFAULT NULL,
  `Website` varchar(191) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `nhacc`
--

INSERT INTO `nhacc` (`MaNCC`, `TenNCC`, `Email`, `SDT`, `DiaChi`, `Website`) VALUES
(1, 'Apple', 'apple@gmail.com', '123456666', '32 Cách Mạng Tháng 8, P. 6, Quận 3, TP HCM', 'https://www.apple.com/vn/'),
(2, 'Samsung', 'samsung@gmail.com', '0123456777', '49 Nguyễn Văn Bá, KP3, P. Bình Thọ, Q. Thủ Đức', 'https://www.samsung.com/vn/'),
(3, 'Xiaomi', 'xiaomi@gmail.com', '123456888', '65A Hồ Xuân Hương, Phường 6, Quận 3, Tp.HCM', 'https://www.xiaomi.com/vn/'),
(4, 'OPPO', 'oppo@gmail.com', '0123456999', '32 Cách Mạng Tháng 8, P. 6, Quận 3, TP HCM', 'https://www.oppo.com/vn/'),
(5, 'iDT', 'sale@idt.com.vn', '01284213212', 'Cầu Giấy, HN', 'idt.com.vn'),
(7, 'AirB', 'aaxb@arib.con', '0124123742', 'Sầm Sơn, Thanh Hóa', 'arib.con');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `nhanvien`
--

CREATE TABLE `nhanvien` (
  `MaNV` int(10) UNSIGNED NOT NULL,
  `TenNV` varchar(30) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `NgayVL` date NOT NULL,
  `Luong` int(11) NOT NULL,
  `SDT` char(12) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `Email` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `MatKhau` varchar(30) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `CMND` char(12) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `DiaChi` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `LoaiNV` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `nhanvien`
--

INSERT INTO `nhanvien` (`MaNV`, `TenNV`, `NgayVL`, `Luong`, `SDT`, `Email`, `MatKhau`, `CMND`, `DiaChi`, `LoaiNV`) VALUES
(2, 'Mai Văn Tiến', '2020-11-12', 7000000, '0339004003', 'MVT@gmail.com', '22222222', '0455634579', 'Thủ Dức - Tp HCM', 'Bán hàng'),
(3, 'Nguyễn Thị Mai', '2020-11-15', 7000000, '0339004345', 'NTM@gmail.com', '33333333', '0345942456', ' Quận 9 - Tp HCM', 'Tiếp tân'),
(4, 'Nguyễn Thị Thu', '2020-11-20', 7000000, '0339493345', 'NTT@gmail.com', '44444444', '0445310024', ' Quận 9 - Tp HCM', 'Bán hàng'),
(5, 'Nguyễn Văn Quang', '2020-12-02', 6000000, '0945600342', 'NVQ@gmail.com', '55555555', '0542247211', ' Quận 2 - Tp HCM', 'Giao hàng'),
(6, 'Nguyễn Hữu Thắng', '2021-12-21', 40000000, '0123124123', 'thang@gm.com', '123456', '214213214', 'ABC', 'Quản lý'),
(7, 'Nguyễn HT', '2021-12-22', 0, '012749213', '2g4243@gmail.com', '11111111', '214213214', '123214', 'Quản lý'),
(8, 'Hoàng Trí Tâm', '2022-01-12', 10000000, '0379696428', 'hoangtam704@gmail.com', '11111111', '272801851', 'Đồng Nai', 'Quản lý');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `phieunhap`
--

CREATE TABLE `phieunhap` (
  `MaPN` int(10) UNSIGNED NOT NULL,
  `TongTienTT` int(11) NOT NULL,
  `NgayLapPN` date NOT NULL,
  `TinhTrangTT` int(1) NOT NULL,
  `MaNCC` int(10) UNSIGNED NOT NULL,
  `MaNV` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `phieunhap`
--

INSERT INTO `phieunhap` (`MaPN`, `TongTienTT`, `NgayLapPN`, `TinhTrangTT`, `MaNCC`, `MaNV`) VALUES
(1, 87700000, '2021-12-23', 0, 2, 4),
(2, 284500000, '2021-11-20', 0, 2, 3),
(3, 180000000, '2021-12-24', 0, 2, 2);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `thongtinsp`
--

CREATE TABLE `thongtinsp` (
  `MaTTSP` int(10) UNSIGNED NOT NULL,
  `TenSP` varchar(100) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `HinhAnh` varchar(191) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `MaLoaiSP` int(10) UNSIGNED NOT NULL,
  `MaTH` int(10) UNSIGNED NOT NULL,
  `Gia` int(100) NOT NULL,
  `GiaKM` int(100) NOT NULL,
  `SoLuong` int(5) DEFAULT NULL,
  `MauSac` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci DEFAULT NULL,
  `Ram` int(10) DEFAULT NULL,
  `BoNhoTrong` int(10) DEFAULT NULL,
  `Pin` int(10) DEFAULT NULL,
  `kichthuocmanhinh` float DEFAULT NULL,
  `CameraTruoc` varchar(100) CHARACTER SET utf8 COLLATE utf8_unicode_ci DEFAULT NULL,
  `CameraSau` varchar(100) CHARACTER SET utf8 COLLATE utf8_unicode_ci DEFAULT NULL,
  `Cpu` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `thongtinsp`
--

INSERT INTO `thongtinsp` (`MaTTSP`, `TenSP`, `HinhAnh`, `MaLoaiSP`, `MaTH`, `Gia`, `GiaKM`, `SoLuong`, `MauSac`, `Ram`, `BoNhoTrong`, `Pin`, `kichthuocmanhinh`, `CameraTruoc`, `CameraSau`, `Cpu`) VALUES
(1, '1280a', 'https://cf.shopee.vn/file/7995a45e3587d28106cedd91d44f66cb', 1, 9, 200000, 180000, 44, 'Đen', 1, 4, 890, 3, '0', '0', 'Intel Xeon E3'),
(3, 'iphone 13', 'https://cdn.tgdd.vn/Products/Images/42/250258/iphone-13-midnight-1-600x600.jpg', 1, 1, 27990000, 27000000, 38, 'Đen', 4, 64, 127, 5, '12 MP', '12 MP', 'Apple A14'),
(4, 'Oppo A91', 'https://cdn.tgdd.vn/Products/Images/42/217287/oppo-a91-trang-600x600-600x600.jpg', 1, 5, 4000000, 0, 22, 'Trắng', 8, 128, 4000, 5, '48 MP', '48 MP', 'Helios 880'),
(5, 'Samsung x3', 'https://cdn.tgdd.vn/Products/Images/42/228151/samsung-galaxy-a12-xanh-600x600-1-600x600.jpg', 1, 2, 8999999, 8500000, 42, 'Xanh', 6, 64, 4400, 5.6, '12 MP', '48 MP', '4Snap dragon 710G'),
(6, 'SamSung Galaxy Note 20', 'https://cdn.tgdd.vn/Products/Images/42/218355/samsung-galaxy-note-20-062220-122200-fix-600x600.jpg', 1, 2, 25999999, 22500000, 26, 'Bạch kim', 8, 128, 4000, 6, '13 MP', '13 MP', 'Exynos 5400'),
(7, 'Lumia', 'https://cdn.tgdd.vn/Products/Images/42/71469/microsoft-lumia-5402-1-300x300.jpg', 1, 9, 5990000, 5000000, 21, 'Cam', 2, 16, 2000, 3.6, '12 MP', '24 MP', 'Helio 500'),
(8, 'Realme 4', 'https://cdn.tgdd.vn/Products/Images/42/206177/realme-4-600x600.jpg', 1, 10, 8200000, 0, 11, 'Đen', 6, 64, 4200, 5.5, '48 MP', '48 MP', 'Snap dragon 620'),
(9, 'Vivo V23e', 'https://cdn.tgdd.vn/Products/Images/42/245607/Vivo-V23e-1-2-600x600.jpg', 1, 7, 9000000, 0, 40, 'Đa sắc', 6, 64, 4500, 5.8, '12 MP', '12 MP', '4Snap dragon 770G'),
(10, 'Máy tính bảng iPad Pro M1 12.9 inch ', 'https://cdn.tgdd.vn/Products/Images/522/238651/ipad-pro-2021-129-inch-silver-600x600.jpg', 2, 1, 39450000, 0, 10, 'Cellular', 8, 64, 41, 12.9, 'Chính 12 MP & Phụ 10 MP, TOF 3D LiDAR', '12 MP', 'Apple M1 8 nhân'),
(11, 'Samsung Galaxy Tab S7 FE WiFi', 'https://cdn.tgdd.vn/Products/Images/522/240254/samsung-galaxy-tab-s7-fe-green-600x600.jpg', 2, 2, 12990000, 11990000, 19, 'Xanh', 4, 64, 60, 12.4, '5 MP', '8 MP', ' Snapdragon 778G 8 nhân'),
(12, 'iPhone 11', 'https://cdn.tgdd.vn/Products/Images/42/153856/TimerThumb/iPhone-11-64-tet.jpg', 1, 1, 16990000, 14990000, 50, 'Đỏ', 4, 64, 3110, 6.1, '12 MP', '2 camera 12 MP', ' Apple A13 Bionic 6 nhân'),
(13, 'iPhone 11', 'https://cdn.tgdd.vn/Products/Images/42/210644/TimerThumb/iPhone-11-128-tet.jpg', 1, 1, 16990000, 14990000, 99, 'Xanh lá', 4, 64, 3110, 6.1, '12 MP', '2 camera 12 MP', 'Apple A13 Bionic'),
(14, 'iPhone 11', 'https://cdn.tgdd.vn/Products/Images/42/225380/TimerThumb/iPhone-12-mini-64-tet.jpg', 1, 1, 16990000, 14990000, 100, 'Tím', 4, 64, 3110, 6.1, '12 MP', '2 camera 12 MP', 'Apple A13 Bionic'),
(15, 'iPhone XR', 'https://cdn.tgdd.vn/Products/Images/42/190325/TimerThumb/iPhone-xr-64-tet.jpg', 1, 1, 14990000, 0, 100, 'Đen', 3, 64, 2942, 6.1, '7 MP', '12 MP', 'Apple A12 Bionic'),
(16, 'iPhone XR', 'https://cdn.tgdd.vn/Products/Images/42/191483/TimerThumb/iPhone-xr-128-tet.jpg', 1, 1, 17990000, 15990000, 100, 'Trắng', 3, 128, 2942, 6.1, '7 MP', '12 MP', 'Apple A12 Bionic'),
(17, 'iPhone 11 Pro', 'https://cdn.tgdd.vn/Products/Images/42/210655/iphone-11-pro-256gb-black-600x600.jpg', 1, 1, 23990000, 0, 100, 'Đen', 4, 256, 3046, 5.8, '\r\n12 MP', '3 camera 12 MP', 'Apple A13 Bionic'),
(18, 'iPhone 11 Pro', 'https://cdn.tgdd.vn/Products/Images/42/188705/iphone-11-pro-vang-600x600-600x600.jpg', 1, 1, 23990000, 0, 100, 'Vàng đồng', 4, 256, 3046, 5.8, '12 MP', '3 camera 12 MP', 'Apple A13 Bionic'),
(19, 'Samsung Galaxy A52', 'https://cdn.tgdd.vn/Products/Images/42/228967/TimerThumb/samsung-galaxy-a52-thumbtet.jpg', 1, 2, 9290000, 8990000, 105, 'Tím', 8, 128, 4500, 6.5, '32 MP', 'Chính 64 MP & Phụ 12 MP, 5 MP, 5 MP', 'Snapdragon 720G'),
(20, 'Samsung Galaxy A51', 'https://cdn.tgdd.vn/Products/Images/42/211570/samsung-galaxy-a51-silver-600x600.jpg', 1, 2, 7990000, 0, 76, 'Bạc Inox', 6, 128, 4000, 6.5, '32 MP', 'Chính 48 MP & Phụ 12 MP, 5 MP, 5 MP', 'Exynos 9611'),
(21, 'Samsung Galaxy A12', 'https://cdn.tgdd.vn/Products/Images/42/228151/TimerThumb/samsung-galaxy-a12-4gb-thumbtet.jpg', 1, 2, 4290000, 0, 56, 'Xanh Dương', 4, 128, 5000, 6.5, '8 MP', 'Chính 48 MP & Phụ 5 MP, 2 MP, 2 MP', 'MediaTek Helio G35'),
(22, 'Samsung Galaxy S20 FE', 'https://cdn.tgdd.vn/Products/Images/42/224859/TimerThumb/samsung-galaxy-s20-fan-edition-thumbtet-1.jpg', 1, 2, 15490000, 0, 80, ' Xanh Dương', 8, 256, 4500, 6.5, '32 MP', 'Chính 12 MP & Phụ 12 MP, 8 MP', 'Snapdragon 865'),
(23, 'Samsung Galaxy S21 FE 5G', 'https://cdn.tgdd.vn/Products/Images/42/267211/Samsung-Galaxy-S21-FE-tim-600x600.jpg', 1, 2, 15990000, 0, 120, 'Tím', 6, 128, 4500, 6.4, '32 MP', 'Chính 12 MP & Phụ 12 MP, 8 MP', 'Exynos 2100'),
(24, 'Xiaomi Redmi Note 10S', 'https://cdn.tgdd.vn/Products/Images/42/262534/xiaomi-redmi-note-10s-6gb-thumb-600x600.jpeg', 1, 3, 5990000, 5690000, 76, 'Trắng', 6, 128, 5000, 6.43, '13 MP', 'Chính 64 MP & Phụ 8 MP, 2 MP, 2 MP', 'MediaTek Helio G95'),
(25, 'Xiaomi Redmi Note 10 Pro', 'https://cdn.tgdd.vn/Products/Images/42/229228/xiaomi-redmi-note-10-pro-thumb-xam-600x600-600x600.jpg', 1, 3, 7490000, 7190000, 90, 'Xám', 8, 128, 5020, 6.67, '16 MP', 'Chính 108 MP & Phụ 8 MP, 5 MP, 2 MP', 'Snapdragon 732G'),
(26, 'Xiaomi Mi 11 Lite', 'https://cdn.tgdd.vn/Products/Images/42/233241/xiaomi-mi-11-lite-4g-black-1-600x600.jpg', 1, 3, 7990000, 7590000, 94, 'Đen', 8, 128, 4250, 6.55, '16 MP', 'Chính 64 MP & Phụ 8 MP, 5 MP', 'Snapdragon 732G'),
(27, 'Xiaomi 11 Lite 5G NE Trắng Swarovski', 'https://cdn.tgdd.vn/Products/Images/42/256053/xiaomi-11-lite-5g-ne-trang-swarovski-1-660x600.jpg', 1, 3, 9490000, 0, 90, 'Trắng', 8, 128, 4250, 6.55, '20 MP', 'Chính 64 MP & Phụ 8 MP, 5 MP', 'Snapdragon 778G 5G 8 nhân'),
(28, 'Xiaomi 11T 5G', 'https://cdn.tgdd.vn/Products/Images/42/248293/TimerThumb/248293.jpg', 1, 3, 10990000, 9990000, 78, 'Trắng', 8, 128, 5000, 6.67, '16 MP', 'Chính 108 MP & Phụ 8 MP, 5 MP', 'MediaTek Dimensity 1200'),
(29, 'Xiaomi 11T Pro 5G', 'https://cdn.tgdd.vn/Products/Images/42/262566/xiaomi-11t-pro-5g-8gb-thumb-600x600.jpeg', 1, 3, 13990000, 12990000, 85, 'Đen', 8, 256, 5000, 6.67, '16 MP', 'Chính 108 MP & Phụ 8 MP, 5 MP', 'Snapdragon 888'),
(30, 'Máy tính bảng Xiaomi Pad 5 128GB', 'https://cdn.tgdd.vn/Products/Images/522/239210/xiaomi-pad-5-white-600x600.jpg', 2, 3, 8900000, 0, 50, 'Trắng', 6, 128, 8720, 11, '8 MP', '13 MP', 'Snapdragon 860 8 nhân'),
(31, 'Máy tính bảng Xiaomi Pad 5 256GB ', 'https://cdn.tgdd.vn/Products/Images/522/239210/xiaomi-pad-5-white-600x600.jpg', 2, 3, 10490000, 0, 60, 'Trắng', 6, 256, 8720, 11, '8 MP', '13 MP', 'Snapdragon 860 8 nhân'),
(32, 'Máy tính bảng Huawei MatePad T10s', 'https://cdn.tgdd.vn/Products/Images/522/259627/Huawei-MatePad-T10s-600x600.jpg', 2, 4, 5990000, 0, 34, 'Đen', 4, 64, 5100, 10.1, '2 MP', '5 MP', 'Kirin 710A'),
(33, 'Máy tính bảng Huawei MatePad 128GB', 'https://cdn.tgdd.vn/Products/Images/522/236953/huawei-matepad-xam-128gb-600x600.jpg', 2, 4, 7790000, 0, 35, 'Xanh đen', 4, 128, 7250, 10.4, '8 MP', '8 MP', 'Kirin 820 8 nhân'),
(34, 'Máy tính bảng Huawei MatePad 11', 'https://cdn.tgdd.vn/Products/Images/522/241299/huawei-matepad-11-9-1-600x600.jpg', 2, 4, 13990000, 12990000, 50, 'Đen', 6, 128, 7250, 10.9, '8 MP', '13 MP', 'Snapdragon 865 8 nhân'),
(35, 'Máy tính bảng Samsung Galaxy Tab S7 FE 4G', 'https://cdn.tgdd.vn/Products/Images/522/240254/samsung-galaxy-tab-s7-fe-green-600x600.jpg', 2, 2, 13990000, 0, 120, 'Trắng xanh', 4, 64, 10090, 12.4, '5 MP', '8 MP', 'Snapdragon 750G'),
(36, 'Máy tính bảng Samsung Galaxy Tab S7', 'https://cdn.tgdd.vn/Products/Images/522/225031/samsung-galaxy-tab-s7-thumb-xanh-600x600-600x600.jpg', 2, 2, 18990000, 0, 100, 'Xanh đen', 6, 128, 8000, 11, '8 MP', 'Chính 13 MP & Phụ 5 MP', 'Snapdragon 865+'),
(37, 'Máy tính bảng Samsung Galaxy Tab S6 Lite', 'https://cdn.tgdd.vn/Products/Images/522/219912/samsung-galaxy-tab-s6-lite-600x600-2-600x600.jpg', 2, 2, 9990000, 0, 75, 'Xanh dương', 4, 64, 7040, 10.4, '5 MP', '8 MP', 'Exynos 9611'),
(38, 'Máy tính bảng Samsung Galaxy Tab A8', 'https://cdn.tgdd.vn/Products/Images/522/251704/samsung-galaxy-tab-a8-thumb-1-600x600.jpg', 2, 2, 8490000, 0, 75, 'Đen', 4, 64, 7040, 10.5, '5 MP', '8 MP', 'UniSOC T618'),
(39, 'Máy tính bảng iPad Pro M1 11 inch 5g', 'https://cdn.tgdd.vn/Products/Images/522/238624/ipad-pro-2021-11-inch-silver-600x600.jpg', 2, 1, 28490000, 27690000, 70, 'Trắng bạc', 8, 128, 7538, 11, '12 MP', 'Chính 12 MP & Phụ 10 MP, TOF 3D LiDAR', 'Apple M1 8 nhân'),
(40, 'Máy tính bảng iPad Pro M1 11 inch WiFi', 'https://cdn.tgdd.vn/Products/Images/522/238624/ipad-pro-2021-11-inch-silver-600x600.jpg', 2, 1, 23990000, 0, 80, 'Trắng bạc', 8, 128, 7538, 11, '12 MP', 'Chính 12 MP & Phụ 10 MP, TOF 3D LiDAR', 'Apple M1 8 nhân'),
(41, 'Máy tính bảng iPad Air 4 Wifi', 'https://cdn.tgdd.vn/Products/Images/522/228897/ipad-4-cellular-trang-new-600x600-600x600.jpg', 2, 1, 21990000, 0, 75, 'Bạc', 4, 64, 7600, 10.9, '7 MP', '12 MP', 'Apple A14 Bionic'),
(42, 'Máy tính bảng iPad mini 6 WiFi', 'https://cdn.tgdd.vn/Products/Images/522/250734/ipad-mini-6-wifi-cellular-starlight-1-600x600.jpg', 2, 1, 20990000, 19990000, 80, 'Vàng đồng', 4, 64, 7200, 8.3, '12 MP', '12 MP', 'Apple A15 Bionic'),
(43, 'Máy tính bảng iPad mini 7.9 inch Wifi Cellular', 'https://cdn.tgdd.vn/Products/Images/522/202820/ipad-mini-79-inch-wifi-cellular-64gb-2019-gold-600x600-1-600x600.jpg', 2, 1, 15990000, 12990000, 80, 'Vàng gold', 3, 64, 5124, 7.9, '7 MP', '8 MP', 'Apple A12 Bionic'),
(44, 'Máy tính bảng iPad 9 WiFi Cellular', 'https://cdn.tgdd.vn/Products/Images/522/250731/ipad-gen-9-wifi-cellular-sliver-600x600.jpg', 2, 1, 14990000, 14690000, 80, 'Bạc', 3, 64, 8600, 10.2, '12 MP', '8 MP', 'Apple A13 Bionic 6 nhân'),
(45, 'iPhone 12 Pro', 'https://cdn.tgdd.vn/Products/Images/42/213032/TimerThumb/iphone-12-pro-thumbtet.jpg', 1, 1, 30490000, 26590000, 120, 'Vàng đồng', 6, 128, 2815, 6.1, '12 MP', '3 camera 12 MP', 'Apple A14 Bionic'),
(46, 'iPhone 12 Pro', 'https://cdn.tgdd.vn/Products/Images/42/228738/TimerThumb/iphone-12-pro-256gb-thumbtet.jpg', 1, 1, 31490000, 28590000, 130, 'Đen', 6, 256, 2815, 6.1, '12 MP', '3 camera 12 MP', 'Apple A14 Bionic'),
(47, 'iPhone12 Pro Max', 'https://cdn.tgdd.vn/Products/Images/42/213033/TimerThumb/iphone-12-pro-max-thumbtet.jpg', 1, 1, 32990000, 30590000, 70, 'Đen', 6, 128, 3687, 6.7, '12 MP', '3 camera 12 MP', 'Apple A14 Bionic'),
(48, 'iPhone 12 Pro Max', 'https://cdn.tgdd.vn/Products/Images/42/228744/TimerThumb/iphone-12-pro-max-512gb-thumbtet.jpg', 1, 1, 32990000, 0, 100, 'Xanh đồng', 6, 128, 3687, 6.7, '12 MP', '3 camera 12 MP', 'Apple A14 Bionic');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `thuonghieu`
--

CREATE TABLE `thuonghieu` (
  `MaTH` int(10) UNSIGNED NOT NULL,
  `TenTH` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `thuonghieu`
--

INSERT INTO `thuonghieu` (`MaTH`, `TenTH`) VALUES
(1, 'Apple'),
(2, 'SamSung'),
(3, 'Xiaomi'),
(4, 'Huawei'),
(5, 'Oppo'),
(6, 'LG'),
(7, 'Vivo'),
(8, 'Sony'),
(9, 'Nokia'),
(10, 'Realme');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `tintuc`
--

CREATE TABLE `tintuc` (
  `MaTinTuc` int(10) NOT NULL,
  `HinhBia` varchar(191) DEFAULT NULL,
  `TieuDe` varchar(200) DEFAULT NULL,
  `NoiDung` text DEFAULT NULL,
  `Link` varchar(200) DEFAULT NULL,
  `TrangThai` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `tintuc`
--

INSERT INTO `tintuc` (`MaTinTuc`, `HinhBia`, `TieuDe`, `NoiDung`, `Link`, `TrangThai`) VALUES
(1, 'https://cdn.tgdd.vn/Files/2021/12/18/1405123/logo24hcongnghe2_1280x720-300x200.jpg', 'Tại sao Facebook tương tác kém? Bạn xem nguyên nhân gây nên tình trạng này và cách khắc phục hiệu quả nhé!', '1. Tại sao Facebook tương tác kém?\r\nTình trạng Facebook cá nhân mất tương tác diễn ra khá phổ biến, nguyên nhân chính đó là sự thay đổi những thuật toán hiển thị của Facebook và cách bạn sử dụng Facebook chưa tuân thủ theo tiêu chuẩn cộng đồng của mạng xã hội này.\r\nDưới đây là tổng hợp những nguyên nhân khiến cho Facebook của bạn bị mất tương tác:\r\nĐăng bài viết bán hàng quá nhiều trên trang cá nhân:  Nếu bạn đăng mô tả về tên sản phẩm, giá, size…kèm theo hình ảnh sản phẩm thì ngay lập tức Facebook cho rằng đây là bài viết bán hàng, bài viết này sẽ mặc định tiếp cận rất kém.\r\n\r\nÍt tương tác: Không thường xuyên tương tác với bạn bè trên Facebook nên lượt tương tác sẽ bị giảm đáng kể.\r\n\r\nThường xuyên chia sẻ bài viết, đường link tin tức, YouTube: thường xuyên chia sẻ link về trang cá nhân hoặc vào nhiều hội nhóm cũng là spam.\r\nTài khoản có tần suất đăng bài ít: Một tài khoản đăng 2-3 status mỗi ngày sẽ tiếp cận nhiều người hơn một tài khoản mỗi tuần chỉ đăng 1 bài.\r\n\r\nKhông đầu tư vào hình ảnh và thương hiệu: Những tài khoản ít đầu tư về nội dung và hình ảnh sẽ bị cắt tương tác do không mang lại nhiều giá trị cho người dùng.\r\n\r\n\r\n\r\nTài khoản vừa bị khóa Checkpoint: vì một số lý do nào đó mà Facebook  yêu cầu xác minh danh tính hoặc đổi mật khẩu thì ngay lập tức khi bạn vào được lại Facebook thì những bài viết mà bạn đăng lên sau khi bị khóa sẽ giảm đi lượt tương tác đáng kể.\r\n\r\n\r\n2. Cách khắc phục khi Facebook tương tác kém\r\nKhông chỉnh sửa sau khi đăng bài: Vì tránh tình trạng treo cái này bán cái khác nên Facebook rất nghiêm khắc trong việc kiểm tra những tình trạng như thế này.\r\nTối ưu hóa độ tiếp cận của video: Sử dụng Video đăng tải trên Fanpage để quảng bá sản phẩm thay cho những bài đăng bán hàng trên trang cá nhân. \r\n\r\nKhông thêm link Website vào bài đăng: Vì chính sách của Facebook hạn chế việc dẫn dắt người dùng của mình sang các nền tảng khác.\r\n\r\nHashtag chỉ dùng cho chiến dịch: Sử dụng hashtag tùy tiện và không thích hợp cho những bài đăng Facebook cá nhân, chỉ nên sử dụng hashtag cho các chiến dịch marketing có kế hoạch rõ ràng nhé.\r\nTích cực tương tác với bạn bè: Chủ động tương tác với mọi người để nhận được nhiều lượt tương tác từ bạn bè.\r\n\r\nĐăng bài vào các khung giờ vàng: Sáng sớm (6-8 giờ); trưa 12-13h; chiều 14-16h, tối từ 21h00-23h-0h.\r\n\r\nHi vọng bài viết này sẽ giúp ích được cho bạn. Chúc bạn thành công. Nhớ ấn Like và Chia sẻ bài viết ủng hộ mình nhé.\r\n\r\nHiện tại, Thế Giới Di Dộng đang có nhiều chương trình khuyến mãi hot đối với các dòng máy tầm trung, giúp mọi người có thể sử dụng mượt mà suốt ngày dài các tác vụ như nghe gọi, nhắn tin, lướt web, chơi game, học online... Nhấn chọn ngay nút cam dưới đây để tham khảo nhé!\r\n\r\n', 'https://www.thegioididong.com/tin-tuc/tai-sao-facebook-tuong-tac-kem-1405123', 1),
(2, 'https://cdn.tgdd.vn/Files/2021/12/20/1405436/realme-gt-2-pro-leak-2_1280x720-300x200.jpg', 'Thông số kỹ thuật Realme GT 2 bị rò rỉ trước giờ ra mắt: Nổi bật với camera Sony chất lượng, Snapdragon 888 và...', 'Realme sẽ tổ chức một sự kiện vào lúc 3 giờ chiều ngày 20/12 (giờ địa phương) tại Trung Quốc để công bố dòng Realme GT 2. Leaker nổi tiếng Digital Chat Station đã chia sẻ các thông số kỹ thuật chính của chiếc Realme GT 2 phiên bản tiêu chuẩn trước khi thiết bị được giới thiệu.\r\nNgười đưa tin tiết lộ rằng điện thoại có màn hình AMOLED phẳng kích thước 6.6 inch với thiết kế đục lỗ. Màn hình sẽ cung cấp độ phân giải Full HD+ và tốc độ làm mới 120 Hz, vị trí đục lỗ chứa camera trước 16 MP.\r\n\r\nMặt sau của GT 2 sẽ có cụm ba camera, nổi bật là camera Sony IMX766 50 MP, bên cạnh một camera 8 MP và một ống kính 2 MP.\r\nThiết bị Realme mới sẽ được trang bị bộ vi xử lý Snapdragon 888, chưa rõ cấu hình RAM + ROM, nhưng điện thoại được cho có pin 5.000 mAh và hỗ trợ sạc nhanh 65 W. Ngoài ra Realme GT 2 sẽ còn có các tính năng khác như động cơ tuyến tính trục x, loa kép và cảm biến vân tay trong màn hình.\r\n\r\nLeaker dường như đang nói về chiếc điện thoại Realme RMX3310 đã được cơ quan TENAA của Trung Quốc phê duyệt vào đầu tháng 12/2021. Thiết bị này có thể sẽ được cài đặt sẵn Realme UI 3.0 dựa trên 12.', 'https://www.thegioididong.com/tin-tuc/thong-so-ky-thuat-realme-gt-2-bi-ro-ri-truoc-khi-ra-mat-1405436', 1);

--
-- Chỉ mục cho các bảng đã đổ
--

--
-- Chỉ mục cho bảng `binhluan`
--
ALTER TABLE `binhluan`
  ADD PRIMARY KEY (`MaBL`),
  ADD KEY `fk_bl_kh` (`MaKH`),
  ADD KEY `fk_bl_ttsp` (`MaTTSP`);

--
-- Chỉ mục cho bảng `cthd`
--
ALTER TABLE `cthd`
  ADD PRIMARY KEY (`MaHD`,`MaTTSP`),
  ADD KEY `fk_cthd_ttsp` (`MaTTSP`);

--
-- Chỉ mục cho bảng `ctpn`
--
ALTER TABLE `ctpn`
  ADD PRIMARY KEY (`MaPN`,`MaTTSP`),
  ADD KEY `fk_ctpn_ttsp` (`MaTTSP`);

--
-- Chỉ mục cho bảng `giaohang`
--
ALTER TABLE `giaohang`
  ADD KEY `fk_giaohang_hd` (`MaHD`),
  ADD KEY `fk_giaohang_nv` (`MaNV`);

--
-- Chỉ mục cho bảng `giohang`
--
ALTER TABLE `giohang`
  ADD PRIMARY KEY (`MaTTSP`,`MaKH`),
  ADD KEY `fk_giohang_kh` (`MaKH`);

--
-- Chỉ mục cho bảng `hoadon`
--
ALTER TABLE `hoadon`
  ADD PRIMARY KEY (`MaHD`),
  ADD KEY `fk_hd_kh` (`MaKH`),
  ADD KEY `fk_hd_km` (`MaKM`);

--
-- Chỉ mục cho bảng `khachhang`
--
ALTER TABLE `khachhang`
  ADD PRIMARY KEY (`MaKH`);

--
-- Chỉ mục cho bảng `khuyenmai`
--
ALTER TABLE `khuyenmai`
  ADD PRIMARY KEY (`MaKM`);

--
-- Chỉ mục cho bảng `loaisp`
--
ALTER TABLE `loaisp`
  ADD PRIMARY KEY (`MaLoaiSP`);

--
-- Chỉ mục cho bảng `nhacc`
--
ALTER TABLE `nhacc`
  ADD PRIMARY KEY (`MaNCC`);

--
-- Chỉ mục cho bảng `nhanvien`
--
ALTER TABLE `nhanvien`
  ADD PRIMARY KEY (`MaNV`);

--
-- Chỉ mục cho bảng `phieunhap`
--
ALTER TABLE `phieunhap`
  ADD PRIMARY KEY (`MaPN`),
  ADD KEY `fk_pn_ncc` (`MaNCC`),
  ADD KEY `fk_pn_nv` (`MaNV`);

--
-- Chỉ mục cho bảng `thongtinsp`
--
ALTER TABLE `thongtinsp`
  ADD PRIMARY KEY (`MaTTSP`),
  ADD KEY `fk_ttsp_lsp` (`MaLoaiSP`),
  ADD KEY `fk_ttsp_th` (`MaTH`);

--
-- Chỉ mục cho bảng `thuonghieu`
--
ALTER TABLE `thuonghieu`
  ADD PRIMARY KEY (`MaTH`);

--
-- Chỉ mục cho bảng `tintuc`
--
ALTER TABLE `tintuc`
  ADD PRIMARY KEY (`MaTinTuc`);

--
-- AUTO_INCREMENT cho các bảng đã đổ
--

--
-- AUTO_INCREMENT cho bảng `binhluan`
--
ALTER TABLE `binhluan`
  MODIFY `MaBL` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT cho bảng `ctpn`
--
ALTER TABLE `ctpn`
  MODIFY `MaPN` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT cho bảng `hoadon`
--
ALTER TABLE `hoadon`
  MODIFY `MaHD` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT cho bảng `khachhang`
--
ALTER TABLE `khachhang`
  MODIFY `MaKH` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT cho bảng `khuyenmai`
--
ALTER TABLE `khuyenmai`
  MODIFY `MaKM` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT cho bảng `loaisp`
--
ALTER TABLE `loaisp`
  MODIFY `MaLoaiSP` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT cho bảng `nhacc`
--
ALTER TABLE `nhacc`
  MODIFY `MaNCC` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT cho bảng `nhanvien`
--
ALTER TABLE `nhanvien`
  MODIFY `MaNV` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT cho bảng `phieunhap`
--
ALTER TABLE `phieunhap`
  MODIFY `MaPN` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT cho bảng `thongtinsp`
--
ALTER TABLE `thongtinsp`
  MODIFY `MaTTSP` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=49;

--
-- AUTO_INCREMENT cho bảng `thuonghieu`
--
ALTER TABLE `thuonghieu`
  MODIFY `MaTH` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT cho bảng `tintuc`
--
ALTER TABLE `tintuc`
  MODIFY `MaTinTuc` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Các ràng buộc cho các bảng đã đổ
--

--
-- Các ràng buộc cho bảng `binhluan`
--
ALTER TABLE `binhluan`
  ADD CONSTRAINT `fk_bl_kh` FOREIGN KEY (`MaKH`) REFERENCES `khachhang` (`MaKH`),
  ADD CONSTRAINT `fk_bl_ttsp` FOREIGN KEY (`MaTTSP`) REFERENCES `thongtinsp` (`MaTTSP`);

--
-- Các ràng buộc cho bảng `cthd`
--
ALTER TABLE `cthd`
  ADD CONSTRAINT `fk_cthd_hd` FOREIGN KEY (`MaHD`) REFERENCES `hoadon` (`MaHD`),
  ADD CONSTRAINT `fk_cthd_ttsp` FOREIGN KEY (`MaTTSP`) REFERENCES `thongtinsp` (`MaTTSP`);

--
-- Các ràng buộc cho bảng `ctpn`
--
ALTER TABLE `ctpn`
  ADD CONSTRAINT `fk_ctpn_pn` FOREIGN KEY (`MaPN`) REFERENCES `phieunhap` (`MaPN`),
  ADD CONSTRAINT `fk_ctpn_ttsp` FOREIGN KEY (`MaTTSP`) REFERENCES `thongtinsp` (`MaTTSP`);

--
-- Các ràng buộc cho bảng `giaohang`
--
ALTER TABLE `giaohang`
  ADD CONSTRAINT `fk_giaohang_hd` FOREIGN KEY (`MaHD`) REFERENCES `hoadon` (`MaHD`),
  ADD CONSTRAINT `fk_giaohang_nv` FOREIGN KEY (`MaNV`) REFERENCES `nhanvien` (`MaNV`);

--
-- Các ràng buộc cho bảng `giohang`
--
ALTER TABLE `giohang`
  ADD CONSTRAINT `fk_giohang_kh` FOREIGN KEY (`MaKH`) REFERENCES `khachhang` (`MaKH`),
  ADD CONSTRAINT `fk_giohang_ttsp` FOREIGN KEY (`MaTTSP`) REFERENCES `thongtinsp` (`MaTTSP`);

--
-- Các ràng buộc cho bảng `hoadon`
--
ALTER TABLE `hoadon`
  ADD CONSTRAINT `fk_hd_kh` FOREIGN KEY (`MaKH`) REFERENCES `khachhang` (`MaKH`),
  ADD CONSTRAINT `fk_hd_km` FOREIGN KEY (`MaKM`) REFERENCES `khuyenmai` (`MaKM`);

--
-- Các ràng buộc cho bảng `phieunhap`
--
ALTER TABLE `phieunhap`
  ADD CONSTRAINT `fk_pn_ncc` FOREIGN KEY (`MaNCC`) REFERENCES `nhacc` (`MaNCC`),
  ADD CONSTRAINT `fk_pn_nv` FOREIGN KEY (`MaNV`) REFERENCES `nhanvien` (`MaNV`);

--
-- Các ràng buộc cho bảng `thongtinsp`
--
ALTER TABLE `thongtinsp`
  ADD CONSTRAINT `fk_ttsp_lsp` FOREIGN KEY (`MaLoaiSP`) REFERENCES `loaisp` (`MaLoaiSP`),
  ADD CONSTRAINT `fk_ttsp_th` FOREIGN KEY (`MaTH`) REFERENCES `thuonghieu` (`MaTH`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
