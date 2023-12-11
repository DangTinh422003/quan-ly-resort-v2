-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Máy chủ: 127.0.0.1
-- Thời gian đã tạo: Th12 11, 2023 lúc 07:05 PM
-- Phiên bản máy phục vụ: 10.4.27-MariaDB
-- Phiên bản PHP: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Cơ sở dữ liệu: `khachsan`
--
CREATE DATABASE IF NOT EXISTS `khachsan` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `khachsan`;

DELIMITER $$
--
-- Thủ tục
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `AddNewAccount` (`username` VARCHAR(255), `password` VARCHAR(255), `email` VARCHAR(255), `role` VARCHAR(255), `create_at` DATETIME)   BEGIN
    INSERT INTO `account` (`username`, `password`, `email`, `create_at`, `Role`)
    VALUES (username, password, email, create_at, role);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `addNewBill` (IN `MaHoaDon` VARCHAR(255), IN `MaKhachHang` VARCHAR(255), IN `MaNhanVien` VARCHAR(255), IN `DanhSachMaPhong` VARCHAR(255), IN `NgayTaoHoaDon` DATETIME, IN `TongTien` DOUBLE, IN `NgayCheckIn` DATETIME, IN `SoNgayThue` INT)   BEGIN
    INSERT INTO hoadon
    (MaHD, MaKhachHang, MaNhanVien, DanhSachMaPhong, NgayTao, TongTien, NgayCheckIn, ThoiGianThue)
    VALUES (MaHoaDon, MaKhachHang, MaNhanVien, DanhSachMaPhong, NgayTaoHoaDon, TongTien, NgayCheckIn, SoNgayThue);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `AddNewCustomer` (`id` VARCHAR(255), `name` VARCHAR(255), `dateOfBirth` DATE, `phoneNumber` VARCHAR(255), `email` VARCHAR(255), `address` VARCHAR(255))   BEGIN
    INSERT INTO khachhang VALUES (id, name, dateOfBirth, phoneNumber, email, address);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ChangePassword` (IN `username` VARCHAR(255), IN `password` VARCHAR(255))   BEGIN
    UPDATE `account` SET `password`=password WHERE account.username = username;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ChangePasswordByEmail` (IN `email` VARCHAR(255), IN `newPassword` VARCHAR(255))   BEGIN
    UPDATE `account` SET `password`=newPassword WHERE account.Email = email;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `DeleteAccount` (IN `username` VARCHAR(255))   BEGIN
    DELETE FROM `account` WHERE account.username = username;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `deleteBill` (IN `MaHoaDon` VARCHAR(255))   BEGIN
    DELETE FROM hoadon
    WHERE hoadon.MaHD = MaHoaDon;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `deleteBillDV` (IN `MaHoaDon` VARCHAR(255))   BEGIN
    DELETE FROM hoadondichvu
    WHERE hoadondichvu.MaHD = MaHoaDon;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `DeleteCustomerById` (IN `id` VARCHAR(255))   BEGIN
    DELETE FROM khachhang WHERE khachhang.Cccd = id;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `GetAccount` (`username` VARCHAR(255))   BEGIN
    SELECT * FROM account WHERE account.username = username;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `GetAccounts` ()   BEGIN
    SELECT * FROM account;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `getAllBill` ()   BEGIN
    SELECT * FROM hoadon;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `getBillByCustomerId` (IN `customnerId` VARCHAR(255))   BEGIN
    SELECT *
    FROM hoadon
    WHERE 
    hoadon.MaKH = customnerId;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `GetByEmail` (`email` VARCHAR(255))   BEGIN
    SELECT * FROM account WHERE account.Email = email;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `GetCustomerById` (`id` VARCHAR(255))   BEGIN
    SELECT * FROM khachhang WHERE Cccd = id;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `GetCustomers` ()   BEGIN
    SELECT * FROM khachhang;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `GET_EMPLOYEES` ()   BEGIN
  SELECT * FROM nhanvien;
END$$

CREATE DEFINER=`root`@`%` PROCEDURE `proc_addNewBill` (IN `@MaHD` VARCHAR(20) CHARSET utf8, IN `@MaKH` VARCHAR(20) CHARSET utf8, IN `@MaNV` VARCHAR(20) CHARSET utf8, IN `@NgayTao` DATE, IN `@TongTien` DOUBLE, IN `@MaPhong` VARCHAR(50) CHARSET utf8, IN `@ThoiGianThue` INT, IN `@NgayCheckIn` DATE)   BEGIN
    INSERT INTO hoadon (MaHD, MaKH, MaNV, NgayTao, TongTien, DSMaPhong, NgayCheckIn, ThoiGianThue) VALUES (@MaHD, @MaKH, @MaNV, @NgayTao, @TongTien, @MaPhong, @ThoiGianThue, @NgayCheckIn);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_addNewCustomer` (IN `@hoten` VARCHAR(100) CHARSET utf8, IN `@ngaysinh` DATE, IN `@sdt` VARCHAR(12) CHARSET utf8, IN `@email` VARCHAR(100) CHARSET utf8, IN `@diachi` TEXT CHARSET utf8, IN `@username` VARCHAR(50) CHARSET utf8)   BEGIN
    DECLARE isUsername VARCHAR(50);
    SELECT username INTO isUsername FROM Account WHERE Account.username = @username;

    IF isUsername IS NOT NULL THEN
        SET @result = -1;
    ELSE
        SET @newID = GenerateCustomerID();
        INSERT INTO khachhang (MaKH, HoTen, NgaySinh, Sdt, Email, DiaChi, Username)
        VALUES (@newID, @hoten, @ngaysinh, @sdt, @email, @diachi, @username);
    END IF;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_addStaff` (IN `@id` VARCHAR(50) CHARSET utf8, IN `@fullname` VARCHAR(500) CHARSET utf8, IN `@phone` VARCHAR(15) CHARSET utf8, IN `@email` VARCHAR(20) CHARSET utf8, IN `@address` TEXT CHARSET utf8, IN `@username` VARCHAR(50) CHARSET utf8, IN `@dateCheckin` DATE, IN `@cccd` VARCHAR(50) CHARSET utf8, IN `@dateOfBirth` DATE, IN `@salary` FLOAT, IN `@role` INT)   BEGIN
    INSERT INTO NhanVien (MaNV, TenNV, Sdt, Email, NgaySinh, DiaChi, username, NgayVaoLam, Luong, Cccd, Role)
    VALUES (@id, @fullname, @phone, @email, @dateOfBirth, @address, @username, @dateCheckin, @salary, @cccd, @role);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_ChangeCustomer` (IN `@Cccd` VARCHAR(50) CHARSET utf8, IN `@hoten` VARCHAR(100) CHARSET utf8, IN `@ngaysinh` DATE, IN `@sdt` VARCHAR(12) CHARSET utf8, IN `@email` VARCHAR(100) CHARSET utf8, IN `@diachi` TEXT CHARSET utf8, OUT `@result` INT)   BEGIN
    DECLARE isUsername VARCHAR(50);
    SELECT isUsername = username FROM account WHERE account.MaKH = @MaKH;

    IF isUsername IS NULL THEN
        SET @result = -1;
    END IF;

    UPDATE khachhang
    SET HoTen = @hoten, NgaySinh = @ngaysinh, Sdt = @sdt, Email = @email, DiaChi = @diachi
    WHERE khachhang.Cccd = @Cccd;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_changePassword` (IN `@username` VARCHAR(20) CHARSET utf8, IN `@newPassword` VARCHAR(20) CHARSET utf8)   BEGIN
    DECLARE currentPassword VARCHAR(500);
    SELECT password INTO currentPassword FROM Account WHERE username = @username;

    IF currentPassword = @newPassword THEN
        SELECT -1 AS result; -- Return -1 as a result
    ELSE
        BEGIN
            UPDATE Account SET hashPassword = @newPassword WHERE username = @username;
        END;
    END IF;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_deleteBill` (IN `@id` VARCHAR(20) CHARSET utf8)   BEGIN
    DELETE FROM hoadon WHERE hoadon.MaHD = @id;
    DELETE FROM hoadonDV WHERE hoadonDV.MaHD = @id;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_DeleteCustomer` (IN `@Cccd` VARCHAR(50) CHARSET utf8, OUT `@result` INT)   BEGIN
    DECLARE makh VARCHAR(50);
    SELECT makh = khachhang.Cccd FROM khachhang WHERE khachhang.Cccd = @Cccd;

    IF makh IS NULL THEN
        SET @result = -1;
    ELSE
        DELETE FROM khachhang WHERE khachhang.Cccd = @Cccd;
        SET @result = 0; -- Success
    END IF;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_deleteRoom` (IN `@id` VARCHAR(50) CHARSET utf8)   BEGIN
		DELETE FROM Phong WHERE Phong.id = @id;
	END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_deleteStaff` (IN `@id` VARCHAR(50) CHARSET utf8)   BEGIN
			DELETE FROM NhanVien
			WHERE MaNV = @id;
		END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_getBillInfo` (IN `@id` VARCHAR(50) CHARSET utf8)   BEGIN
		SELECT * FROM hoadon, HoaDonPhong, HoaDonDV WHERE hoadon.MaHD = @id and hoadonphong.MaHD =  hoadon.MaHD and hoadonDV.MaHD =  hoadon.MaHD;
	END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_getCustomerInfo` (IN `@id` VARCHAR(50) CHARSET utf8)   BEGIN
		SELECT * FROM khachhang WHERE khachhang.MaKH = @id;
	END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_getManager` (IN `@id` VARCHAR(50) CHARSET utf8)   BEGIN
SELECT * FROM quanly, nhanvien WHERE quanly.MaNV = @id and quanly.MaNV = nhanvien.MaNV;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_getRoomInfo` (IN `@id` VARCHAR(50) CHARSET utf8)   BEGIN
		SELECT * FROM Phong WHERE Phong.id = @id;
	END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_updateBill` (IN `@MaHD` VARCHAR(20) CHARSET utf8, IN `@MaKH` VARCHAR(20) CHARSET utf8, IN `@MaNV` VARCHAR(20) CHARSET utf8, IN `@NgayTao` DATE, IN `@TongTien` DOUBLE)   BEGIN
    UPDATE hoadon
    SET MaKH = @MaKH, MaNV = @MaNV, NgayTao = @NgayTao, TongTien = @TongTien
    WHERE hoadon.MaHD = @MaHD;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `proc_updateStaff` (IN `@id` VARCHAR(50) CHARSET utf8, IN `@fullname` VARCHAR(20) CHARSET utf8, IN `@phone` VARCHAR(15) CHARSET utf8, IN `@email` VARCHAR(20) CHARSET utf8, IN `@address` VARCHAR(30) CHARSET utf8, IN `@username` VARCHAR(20) CHARSET utf8, IN `@dateCheckin` DATE, IN `@cccd` VARCHAR(50) CHARSET utf8, IN `@dateOfBirth` DATE, IN `@salary` FLOAT(50), IN `@role` INT)   BEGIN
    UPDATE NhanVien
    SET
        NhanVien.MaNV = @fullname,
        NhanVien.Sdt = @phone,
        NhanVien.Email = @email,
        NhanVien.DiaChi = @address,
        NhanVien.Username = @username,
        NhanVien.DateCheckin = @dateCheckin,
        NhanVien.DateOfBirth = @dateOfBirth,
        NhanVien.NgaySinh = @dateOfBirth,  -- You had a typo in the column name here
        NhanVien.cccd = @cccd,
        NhanVien.salary = @salary,
        nhanvien.role = @role
    WHERE NhanVien.ID = @id;  -- Added NhanVien. before ID to specify the table
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `pro_ComparePassword` (IN `@username` VARCHAR(50) CHARSET utf8, IN `@password` VARCHAR(500) CHARSET utf8)   BEGIN
    DECLARE currentUsername VARCHAR(50);
    DECLARE currentPassword VARCHAR(500);
    DECLARE lengthSearchAccount INT;

    SELECT COUNT(*) INTO lengthSearchAccount
    FROM ACCOUNT
    WHERE username = p_username;

    IF lengthSearchAccount <= 0 THEN
        SELECT -1 AS result;
    ELSE
        BEGIN
            SELECT password, username INTO currentPassword, currentUsername
            FROM ACCOUNT
            WHERE username = @username;

            IF currentPassword != @password OR currentUsername != @username THEN
                SELECT -1 AS result;
            ELSE
                SELECT 1 AS result;
            END IF;
        END;
    END IF;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `pro_searchRoomById` (IN `@id` VARCHAR(20) CHARSET utf8)   BEGIN
    DECLARE searchID VARCHAR(20);
    DECLARE lengthSearchRoom INT;

    SELECT COUNT(*) INTO lengthSearchRoom
    FROM Phong
    WHERE id like @id;

    IF lengthSearchRoom <= 0 THEN
        SELECT -1 AS result;
    ELSE
        BEGIN
            SELECT * FROM phong
            WHERE Phong.id like @id;
        END;
    END IF;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `pro_updateRoom` (IN `@id` VARCHAR(50) CHARSET utf8, IN `@LoaiPhong` VARCHAR(50) CHARSET utf8, IN `@TinhTrang` VARCHAR(40) CHARSET utf8, IN `@KieuGiuong` VARCHAR(40) CHARSET utf8, IN `@Gia` DOUBLE, IN `@SuaChua` BOOLEAN, IN `@DonDep` BOOLEAN)   BEGIN
    UPDATE Phong
    SET Phong.LoaiPhong = @LoaiPhong, Phong.TinhTrang = @TinhTrang, Phong.Gia = @Gia, phong.LoaiPhong = @LoaiPhong, phong.SuaChua = @SuaChua, phong.DonDep = @DonDep
    WHERE Phong.id = @id;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdateAccount` (IN `username` VARCHAR(255), IN `email` VARCHAR(255), IN `role` VARCHAR(255))   BEGIN
    UPDATE `account` SET `Email`=email,`Role`=role WHERE account.username = username;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `updateBill` (IN `MaHoaDon` VARCHAR(255), IN `MaKhachHang` VARCHAR(255), IN `MaNhanVien` VARCHAR(255), IN `DanhSachMaPhong` VARCHAR(255), IN `NgayTaoHoaDon` DATETIME, IN `TongTien` DOUBLE, IN `NgayCheckIn` DATETIME, IN `SoNgayThue` INT)   BEGIN
    UPDATE hoadon
    SET MaKhachHang = @MaKhachHang,
        MaNhanVien = @MaNhanVien,
        DanhSachMaPhong = @DanhSachMaPhong,
        NgayTao = @NgayTaoHoaDon,
        TongTien = @TongTien,
        NgayCheckIn = @NgayCheckIn,
        ThoiGianThue = @SoNgayThue
    WHERE MaHD = @MaHoaDon;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `updateBillState` (IN `MaHD` VARCHAR(255), IN `state` VARCHAR(255))   BEGIN
    UPDATE hoadon
    SET state = state
    WHERE hoadon.MaHD LIKE MaHD;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdateCustomer` (IN `id` VARCHAR(255), IN `name` VARCHAR(255), IN `dateOfBirth` DATE, IN `phoneNumber` VARCHAR(255), IN `email` VARCHAR(255), IN `address` VARCHAR(255))   BEGIN
    UPDATE khachhang
    SET HoTen = name,
        NgaySinh = dateOfBirth,
        Sdt = phoneNumber,
        Email = email,
        DiaChi = address
    WHERE khachhang.Cccd = id;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `updateMoneyById` (IN `MaHD` VARCHAR(255), IN `value` DOUBLE)   BEGIN
    UPDATE hoadon
    SET TongTien = value
    WHERE MaHD LIKE MaHD;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `account`
--

CREATE TABLE `account` (
  `username` varchar(50) NOT NULL,
  `password` varchar(500) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `create_at` datetime NOT NULL,
  `Role` varchar(20) NOT NULL DEFAULT 'employee'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `account`
--

INSERT INTO `account` (`username`, `password`, `Email`, `create_at`, `Role`) VALUES
('admintest', '$2a$12$K/UQm9MEgmXJPOpxxCHxBOxz3NsDylDPN4zgMtQ6M39UJN.JVh1lq', 'caodangtinh@gmail.com', '2023-11-29 16:15:36', 'employee'),
('buitamvien', '$2a$12$rm61IU7YcqqaaGatGGV9M.fjXVCoR9l1nGycNqgLAbQZpilE4RlL2', 'bui.tam123@gmail.com', '0000-00-00 00:00:00', 'admin'),
('danglinh01', '$2a$12$P0gV2CNxgUZX6wYFZCO35em.grGOgBjbed75Jq8e3nCNnPPubIyA2', 'dang.linh123@gmail.com', '2023-10-28 00:00:00', 'employee'),
('gruhaha9', '$2a$12$FNZhHSZHxFQGFwpezOoTG.IwWJpZOHoSMdNU9tneNrJwCOY8ruFDG', '', '0000-00-00 00:00:00', 'employee'),
('haitran', '$2a$12$ZCISCW8KQRY5LN3orefsZeee/X0SSUE.x3gshv6VMOS8DyhtQI862', '', '0000-00-00 00:00:00', 'employee'),
('hoangson123', 'passwordhoangson123', 'hoang.son123@gmail.com', '2023-10-28 00:00:00', 'employee'),
('huynhngoc123', 'passwordhuynhngoc123', 'huynh.ngoc123@gmail.com', '2023-10-28 00:00:00', 'employee'),
('lethaohien', 'passwordlethaohien', 'le.thao123@gmail.com', '2023-10-28 00:00:00', 'employee'),
('longdunguyen', 'passwordlongdunguyen', 'bui.tamHaiLong@gmail.com', '2023-10-28 00:00:00', 'employee'),
('oanh1234', 'passwordoanh1234', 'bui.tamOanh@gmail.com', '2023-10-28 00:00:00', 'employee'),
('phamquanqchien', 'passwordphamquanqchien', 'pham.quan123@gmail.com', '2023-10-28 00:00:00', 'employee'),
('quanghuytest', '$2a$12$1aOthlOb40TWjNbLOq3CKeCvg.5vyGwNmXkCfHpbJcnLmNftzbBPW', 'huyquangvo11.2000@gmail.com', '2023-11-21 16:31:22', 'employee'),
('tinhdangcao', 'passwordtinhdangcao', 'bui.tamHai@gmail.com', '2023-10-28 00:00:00', 'employee'),
('trannamthnh01', 'trannamthnh01', 'tran.nam123@gmail.com', '2023-10-28 00:00:00', 'employee'),
('tvh050423', 'passwordtvh050423', 'bui.tamHai@gmail.com', '2023-10-28 00:00:00', 'employee'),
('voquanghuy', 'passwordvoquanghuy', 'bui.tamHai@gmail.com', '2023-10-28 00:00:00', 'employee'),
('vothanht', 'passwordvothanht', 'vo.thanh123@gmail.com', '2023-10-28 00:00:00', 'employee');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `datphong`
--

CREATE TABLE `datphong` (
  `Id` varchar(50) NOT NULL,
  `NgayDat` date NOT NULL DEFAULT current_timestamp(),
  `DSMaPhong` varchar(50) NOT NULL,
  `MaKH` varchar(50) NOT NULL,
  `NgayCheckInDuKien` date NOT NULL,
  `SoNgayThue` int(11) NOT NULL,
  `SoNguoiThue` int(11) NOT NULL,
  `TinhTrang` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `datphong`
--

INSERT INTO `datphong` (`Id`, `NgayDat`, `DSMaPhong`, `MaKH`, `NgayCheckInDuKien`, `SoNgayThue`, `SoNguoiThue`, `TinhTrang`) VALUES
('DP001', '2023-11-28', 'P01,P02,P03', '099898888888', '2023-11-28', 1, 2, 'Đã xử lý'),
('DP002', '2023-11-28', 'P01,P02,P03', '077898778675', '2023-11-28', 1, 2, 'Đã xử lý'),
('DP003', '2023-11-28', 'P01,P02,P03,P05,P04', '098098098098', '2023-11-28', 1, 2, 'Đã xử lý'),
('DP004', '2023-11-28', 'P03,P02', '098765342536', '2023-11-28', 1, 2, 'Đã xử lý'),
('DP005', '2023-12-10', 'P01,P02,P04,P06', '098098098098', '2023-12-10', 1, 2, 'Đã xử lý'),
('DP006', '2023-12-11', 'P03,P05', '098098098098', '2023-12-11', 1, 2, 'Đã xử lý');

--
-- Bẫy `datphong`
--
DELIMITER $$
CREATE TRIGGER `Add_new_order` BEFORE INSERT ON `datphong` FOR EACH ROW BEGIN
    DECLARE nextID INT;
    DECLARE newID VARCHAR(10);

    -- Tìm ID lớn nhất hiện có trong bảng KhachHang
    SELECT MAX(CAST(SUBSTRING(datphong.Id, 3) AS SIGNED)) INTO nextID FROM datphong;

    -- Nếu không tìm thấy ID nào, thì gán giá trị đầu tiên
    IF nextID IS NULL THEN
        SET newID = 'DP001';
    ELSE
        -- Tạo ID mới bằng cách tăng số sau 'KH' lên 1 đơn vị và định dạng lại
        SET nextID = nextID + 1;
        SET newID = CONCAT('DP', LPAD(nextID, 3, '0'));
    END IF;

	SET NEW.Id = newID;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `dichvu`
--

CREATE TABLE `dichvu` (
  `MaDV` varchar(50) NOT NULL,
  `TenDV` text CHARACTER SET utf8mb4 COLLATE utf8mb4_vietnamese_ci NOT NULL,
  `LoaiDV` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_vietnamese_ci NOT NULL,
  `ChiTietDichVu` text CHARACTER SET utf8mb4 COLLATE utf8mb4_vietnamese_ci NOT NULL,
  `Gia` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `dichvu`
--

INSERT INTO `dichvu` (`MaDV`, `TenDV`, `LoaiDV`, `ChiTietDichVu`, `Gia`) VALUES
('DV01', 'Dọn Phòng', 'Khác', 'Nhân viên sẽ tiến hành lên phòng của bạn để dọn dẹp lại phòng như lúc mới.', 200000),
('DV02', 'Wifi', 'Khác', 'Cung cấp thẻ truy cập wifi cho một phòng, tối đa dùng được 4 người', 80000),
('DV03', 'Sting dâu', 'Đồ uống', '', 12000),
('DV04', 'Bò húc', 'Đồ uống', '', 15000),
('DV05', 'Coca', 'Đồ uống', '', 10000),
('DV06', 'Bia 333', 'Đồ uống', '', 15000),
('DV07', 'Bia Saigon', 'Đồ uống', '', 15000),
('DV08', 'Nước suối', 'Đồ uống', '', 5000),
('DV09', 'Rượu vang đỏ nhập khẩu', 'Đồ uống', '', 230000),
('DV10', 'C2', 'Đồ uống', '', 10000),
('DV11', 'Tea Plus', 'Đồ uống', '', 11000),
('DV12', 'Sprite', 'Đồ uống', '', 12000),
('DV13', 'Trà đào', 'Đồ uống', '', 15000),
('DV14', 'Trà Vải', 'Đồ uống', '', 15000),
('DV15', 'Sâm Dừa', 'Đồ uống', '', 25000),
('DV16', 'Pocari', 'Đồ uống', '', 8000),
('DV17', 'Vodka', 'Đồ uống', '', 160000),
('DV18', 'Mì xào', 'Đồ Ăn', '', 15000),
('DV19', 'Cơm bò', 'Đồ Ăn', '', 25000),
('DV20', 'Cơm gà', 'Đồ Ăn', '', 25000),
('DV21', 'Cơm chiên hải sản', 'Đồ Ăn', '', 25000),
('DV22', 'Bánh mì thịt', 'Đồ Ăn', '', 15000),
('DV23', 'Pizza', 'Đồ Ăn', '', 55000),
('DV24', 'Bún riêu', 'Đồ Ăn', '', 35000),
('DV25', 'Bún bò', 'Đồ Ăn', '', 35000),
('DV26', 'Cơm nắm', 'Đồ Ăn', '', 15000),
('DV27', 'Tokbokki', 'Đồ Ăn', '', 35000),
('DV28', 'Chuyển đồ', 'Vận Chuyển', '', 100000),
('DV29', 'Đưa đón sân bay', 'Vận Chuyển', '', 200000);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `hoadon`
--

CREATE TABLE `hoadon` (
  `MaHD` varchar(50) NOT NULL,
  `MaKH` varchar(50) NOT NULL,
  `MaNV` varchar(50) NOT NULL,
  `DSMaPhong` varchar(50) NOT NULL,
  `NgayTao` date NOT NULL DEFAULT current_timestamp(),
  `TongTien` double NOT NULL,
  `NgayCheckIn` date NOT NULL,
  `ThoiGianThue` int(11) NOT NULL,
  `state` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `hoadon`
--

INSERT INTO `hoadon` (`MaHD`, `MaKH`, `MaNV`, `DSMaPhong`, `NgayTao`, `TongTien`, `NgayCheckIn`, `ThoiGianThue`, `state`) VALUES
('4854', '077203997867', 'NV08', 'P01,P02,P03', '2023-11-28', 900000, '2023-11-28', 1, 'paid'),
('5211', '077898778675', 'NV08', 'P01,P02,P03', '2023-11-28', 900000, '2023-11-28', 1, 'paid'),
('5275', '786765665456', 'NV08', 'P01,P02,P03', '2023-11-27', 900000, '2023-11-27', 1, 'paid'),
('5997', '077203998878', 'NV08', 'P01,P02,P03', '2023-11-28', 900000, '2023-11-28', 1, 'paid'),
('6761', '098765342536', 'NV08', 'P03,P02', '2023-11-29', 697000, '2023-11-28', 1, 'paid'),
('6964', '077878776565', 'NV08', 'P01,P02,P03', '2023-11-27', 900000, '2023-11-27', 1, 'paid'),
('7194', '051222222222', 'NV08', 'P01,P02,P03', '2023-11-28', 1180000, '2023-11-28', 1, 'paid'),
('8425', '098098098098', 'NV08', 'P03,P05', '2023-12-11', 700000, '2023-12-11', 1, 'paid'),
('8947', '098098098098', 'NV08', 'P01,P02,P04,P06', '2023-12-10', 1320000, '2023-12-10', 1, 'paid'),
('9619', '088987667876', 'NV08', 'P02,P03,P04', '2023-11-28', 900000, '2023-11-28', 1, 'paid'),
('9981', '077777777878', 'NV08', 'P04,P05', '2023-11-27', 775000, '2023-11-27', 1, 'paid');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `hoadondichvu`
--

CREATE TABLE `hoadondichvu` (
  `MaHD` varchar(50) NOT NULL,
  `MaDichVu` varchar(50) NOT NULL,
  `Soluong` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `hoadondichvu`
--

INSERT INTO `hoadondichvu` (`MaHD`, `MaDichVu`, `Soluong`) VALUES
('3384', 'DV01', 1),
('3384', 'DV03', 1),
('1291', 'DV07', 1),
('1291', 'DV09', 1),
('1291', 'DV11', 1),
('4979', 'DV18', 3),
('4979', 'DV20', 1),
('4979', 'DV19', 2),
('1699', 'DV18', 5),
('1699', 'DV04', 3),
('1699', 'DV29', 1),
('9981', 'DV19', 3),
('7194', 'DV01', 1),
('7194', 'DV02', 1),
('6761', 'DV03', 1),
('6761', 'DV04', 5),
('6761', 'DV05', 1);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `hoadon_voucher`
--

CREATE TABLE `hoadon_voucher` (
  `MaHD` varchar(50) NOT NULL,
  `MaVoucher` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `khachhang`
--

CREATE TABLE `khachhang` (
  `Cccd` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `HoTen` varchar(100) NOT NULL,
  `NgaySinh` date NOT NULL,
  `Sdt` varchar(12) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `Email` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `DiaChi` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_vietnamese_ci;

--
-- Đang đổ dữ liệu cho bảng `khachhang`
--

INSERT INTO `khachhang` (`Cccd`, `HoTen`, `NgaySinh`, `Sdt`, `Email`, `DiaChi`) VALUES
('957148804165', 'Lê Thảo', '1995-04-19', '0703456789', 'le.thao@gmail.com', '456 Đường Hà Huy Tập, Phường An Hòa, Quận Ninh Kiều, Cần Thơ'),
('880733023390', 'Phạm Quân', '1986-03-03', '0604567890', 'pham.quan@gmail.com', '789 Đường Trần Hưng Đạo, Phường Hòa Xuân, Quận Cẩm Lệ, Đà Nẵng'),
('962058984365', 'Huỳnh Ngọc', '1991-10-09', '0901234568', 'huynh.ngoc@gmail.com', '321 Đường Lê Thánh Tôn, Phường 2, Quận 10, TP. Hồ Chí Minh'),
('191993224016', 'Hoàng Sơn', '1994-03-13', '0802345679', 'hoang.son@gmail.com', '654 Đường Đống Đa, Phường Trần Phú, Thành phố Bắc Giang, Bắc Giang'),
('766209300097', 'Võ Thanh', '1989-09-14', '0703456780', 'vo.thanh@gmail.com', '987 Đường Lê Lai, Phường Ngô Mây, Quận Lê Chân, Hải Phòng'),
('300778827807', 'Đặng Linh', '2004-06-10', '0604567891', 'dang.linh@gmail.com', '234 Đường Phạm Văn Đồng, Phường Bình Trưng Đông, Quận 2, TP. Hồ Chí Minh'),
('026930400336', 'Bùi Tâm', '1992-06-07', '0901234569', 'bui.tam@gmail.com', '567 Đường Lê Duẩn, Phường Hải Châu 1, Quận Hải Châu, Đà Nẵng'),
('985900471380', 'Đỗ Tuấn', '2003-04-29', '0802345680', 'do.tuan@gmail.com', '876 Đường Trần Phú, Phường Hoà Cường Bắc, Quận Hải Châu, Đà Nẵng'),
('504976001895', 'Trần Văn Quang', '1984-05-27', '0703456781', 'tran.van.quang@gmail.com', '432 Đường Hoàng Hoa Thám, Phường 3, Quận Tân Bình, TP. Hồ Chí Minh'),
('541753431373', 'Lê Thanh Thuỳ', '2002-11-17', '0604567892', 'le.thanh.thuy@gmail.com', '123 Đường Bà Triệu, Phường Lê Lợi, Quận Vinh, Nghệ An'),
('196781061033', 'Phạm Đức Minh', '1990-05-14', '0901234570', 'pham.duc.minh@gmail.com', '789 Đường Hàm Nghi, Phường Nghĩa Đô, Quận Cầu Giấy, Hà Nội'),
('420467478814', 'Huỳnh Quỳnh Nhi', '1987-01-19', '0802345681', 'huynh.quynh.nhi@gmail.com', '345 Đường Lê Lợi, Phường Hòa Khánh Nam, Quận Liên Chiểu, Đà Nẵng'),
('874530338671', 'Hoàng Thanh Hà', '2002-03-21', '0703456782', 'hoang.thanh.ha@gmail.com', '678 Đường Hoàng Diệu, Phường Vĩnh Ninh, TP. Huế, Thừa Thiên/Huế'),
('304765830112', 'Võ Xuân Đức', '2003-12-29', '0604567893', 'vo.xuan.duc@gmail.com', '987 Đường Quang Trung, Phường Phước Long, Quận Ninh Kiều, Cần Thơ'),
('303046750198', 'Đặng Công Tuấn', '1980-11-21', '0901234571', 'dang.cong.tuan@gmail.com', '543 Đường Điện Biên Phủ, Phường Tân An, TP. Buôn Ma Thuột, Đắk Lắk'),
('431651171577', 'Bùi Thị Ngọc Phượng', '1998-10-27', '0802345682', 'bui.thi.ngoc.phuong@gmail.com', '321 Đường Hùng Vương, Phường Mỹ An, Quận Ngũ Hành Sơn, Đà Nẵng'),
('099115175250', 'Đỗ Hoàng Sơn', '1994-11-10', '0703456783', 'do.hoang.son@gmail.com', '654 Đường 30 Tháng 4, Phường Ninh Xá, TP. Bắc Ninh, Bắc Ninh'),
('132726284209', 'Hồ Thị Mai Linh', '1993-07-16', '0604567894', 'ho.thi.mai.linh@gmail.com', '789 Đường Hồ Xuân Hương, Phường Nghĩa An, TP. Quy Nhơn, Bình Định'),
('843086861597', 'Ngô Thành Huy', '2000-08-04', '0901234572', 'ngo.thanh.huy@gmail.com', '234 Đường Lê Duẩn, Phường Nghĩa Lộ, TP. Yên Bái, Yên Bái'),
('076601287039', 'Dương Thúy Vy', '1981-10-03', '0802345683', 'duong.thuy.vy@gmail.com', '123 Đường Lê Lợi, Phường Võ Thị Sáu, Quận 1, TP. Hồ Chí Minh'),
('992176259453', 'Lý Hoàng Nam', '1997-07-01', '0703456784', 'ly.hoang.nam@gmail.com', '456 Đường Hà Huy Tập, Phường Cái Khế, Quận Ninh Kiều, Cần Thơ'),
('810391315494', 'Đào Thị Thúy Trang', '1991-04-01', '0604567895', 'dao.thi.thuy.trang@gmail.com', '789 Đường Trần Phú, Phường Thanh Khê Đông, Quận Thanh Khê, Đà Nẵng'),
('050141394078', 'Đinh Minh Khai', '1999-09-15', '0901234573', 'dinh.minh.khai@gmail.com', '321 Đường Lê Thánh Tôn, Phường Cô Giang, Quận 1, TP. Hồ Chí Minh'),
('517390135707', 'Mai Thị Quỳnh Anh', '2001-04-03', '0802345684', 'mai.thi.quynh.anh@gmail.com', '654 Đường Hùng Vương, Phường Hà Huy Tập, Thành phố Hạ Long, Quảng Ninh'),
('857557609092', 'Trịnh Ngọc Trường', '2004-11-19', '0703456785', 'trinh.ngoc.truong@gmail.com', '987 Đường Lê Lai, Phường Phường Ngô Quyền, Quận Hồng Bàng, Hải Phòng'),
('807044006623', 'Đoàn Văn Quân', '1987-06-29', '0604567896', 'doan.van.quan@gmail.com', '234 Đường Phạm Văn Đồng, Phường An Khê, Quận Thanh Khê, Đà Nẵng'),
('497003697050', 'Đặng Hà My', '1980-08-26', '0901234574', 'dang.ha.my@gmail.com', '567 Đường Lê Duẩn, Phường Xuân Hà, Quận Thanh Khê, Đà Nẵng'),
('708744110089', 'Phan Thị Thảo', '1985-07-05', '0802345685', 'phan.thi.thao@gmail.com', '876 Đường Trần Phú, Phường Trần Phú, Thành phố Biên Hòa, Đồng Nai'),
('085810827221', 'Lương Hoàng Đức', '2004-03-18', '0703456786', 'luong.hoang.duc@gmail.com', '432 Đường Hoàng Hoa Thám, Phường 4, Quận Tân Bình, TP. Hồ Chí Minh'),
('042023008791', 'Vũ Thị Lan Anh', '1991-01-11', '0604567897', 'vu.thi.lan.anh@gmail.com', '123 Đường Bà Triệu, Phường Hàm Rồng, Thành phố Thanh Hóa, Thanh Hóa'),
('908106796028', 'Tô Văn Tuấn', '2003-07-19', '0901234575', 'to.van.tuan@gmail.com', '789 Đường Hàm Nghi, Phường Trúc Bạch, Quận Ba Đình, Hà Nội'),
('323755797881', 'Trương Thanh Thảo', '1988-02-26', '0802345686', 'truong.thanh.thao@gmail.com', '345 Đường Lê Lợi, Phường Tân Thành, Quận Tân Phú, TP. Hồ Chí Minh'),
('957021710737', 'Lục Hữu Hùng', '2005-04-03', '0703456787', 'luc.huu.hung@gmail.com', '678 Đường Đào Duy Anh, Phường Phương Sài, TP. Nha Trang, Khánh Hòa'),
('545665635809', 'Thái Đức Khôi', '1982-06-01', '0604567898', 'thai.duc.khoi@gmail.com', '987 Đường Bạch Đằng, Phường An Cựu, TP. Huế, Thừa Thiên/Huế'),
('629728605025', 'Kim Thị Hồng Ngọc', '2005-09-12', '0901234576', 'kim.thi.hong.ngoc@gmail.com', '543 Đường Hồ Thị Kỷ, Phường Tân Lập, TP. Bà Rịa / Vũng Tàu, Bà Rịa / Vũng Tàu'),
('984550760134', 'Cao Văn Long', '1999-01-15', '0802345687', 'cao.van.long@gmail.com', '321 Đường Nguyễn Huệ, Phường Trà An, TP. Vũng Tàu, Bà Rịa / Vũng Tàu'),
('711449389013', 'Chu Thị Thu Hằng', '2000-05-15', '0703456788', 'chu.thi.thu.hang@gmail.com', '654 Đường Nguyễn Đình Chính, Phường Phú Lâm, Quận Tân Phú, TP. Hồ Chí Minh'),
('304088802921', 'Lâm Văn Hưng', '1998-05-19', '0604567899', 'lam.van.hung@gmail.com', '789 Đường Trần Hưng Đạo, Phường Phước Long, TP. Nha Trang, Khánh Hòa'),
('653650100805', 'Quách Văn Khải', '1983-01-29', '0901234577', 'quach.van.khai@gmail.com', '234 Đường Võ Thị Sáu, Phường Cái Khế, Quận Ninh Kiều, Cần Thơ'),
('980705583895', 'Lưu Thị Diệu Linh', '2000-02-22', '0802345688', 'luu.thi.dieu.linh@gmail.com', '123 Đường Nguyễn Huệ, Phường Vĩnh Ninh, TP. Huế, Thừa Thiên/Huế'),
('534536567491', 'Kiều Thị Hạnh', '1996-03-05', '0703456789', 'kieu.thi.hanh@gmail.com', '456 Đường Hoàng Hoa Thám, Phường Lê Đại Hành, TP. Hải Dương, Hải Dương'),
('905563083377', 'Khương Văn Tuấn', '1993-12-23', '0604567801', 'khuong.van.tuan@gmail.com', '789 Đường Hàm Nghi, Phường Trung Hòa, Quận Cầu Giấy, Hà Nội'),
('108918554290', 'Tăng Thị Linh Chi', '1990-10-23', '0901234578', 'tang.thi.linh.chi@gmail.com', '321 Đường Lê Thánh Tôn, Phường Thanh Khê Tây, Quận Thanh Khê, Đà Nẵng'),
('117753009055', 'Hà Văn Minh', '1996-08-14', '0802345689', 'ha.van.minh@gmail.com', '654 Đường Hồ Xuân Hương, Phường Võ Cường, TP. Bắc Ninh, Bắc Ninh'),
('072545609629', 'Triệu Thanh Tùng', '1982-08-20', '0703456790', 'trieu.thanh.tung@gmail.com', '987 Đường Lê Lai, Phường Vĩnh Tân, Quận Ninh Kiều, Cần Thơ'),
('715727403647', 'Lư Văn Hoàng', '1995-09-27', '0604567802', 'lu.van.hoang@gmail.com', '234 Đường Điện Biên Phủ, Phường Xuân Hà, TP. Quy Nhơn, Bình Định'),
('080042419019', 'Đoàn Văn Nhân', '1981-02-03', '0901234579', 'doan.van.nhan@gmail.com', '567 Đường Lê Duẩn, Phường Nghĩa Phương, TP. Quảng Ngãi, Quảng Ngãi'),
('801662371371', 'Lại Thị Huyền Trang', '1993-04-26', '0802345690', 'lai.thi.huyen.trang@gmail.com', '876 Đường Trần Phú, Phường Hòa Cường Nam, Quận Hải Châu, Đà Nẵng'),
('405193458571', 'Lục Văn Tuấn', '1984-11-05', '0703456791', 'luc.van.tuan@gmail.com', '432 Đường Phạm Văn Đồng, Phường Mỹ Đình, Quận Nam Từ Liêm, Hà Nội'),
('788412421051', 'Tạ Thị Thảo Ngân', '1990-08-03', '0604567803', 'ta.thi.thao.ngan@gmail.com', '123 Đường Bà Triệu, Phường Ngọc Trạo, TP. Thanh Hóa, Thanh Hóa'),
('629225107693', 'Quyền Đức Hoàng', '1992-11-15', '0901234580', 'quyen.duc.hoang@gmail.com', '789 Đường Hàm Nghi, Phường Hòa An, Quận Cẩm Lệ, Đà Nẵng'),
('021101408600', 'Tống Thị Thanh Hà', '1998-08-07', '0802345691', 'tong.thi.thanh.ha@gmail.com', '345 Đường Lê Lợi, Phường Điện Ngọc, TP. Điện Biên Phủ, Điện Biên'),
('266314980267', 'Nghiêm Văn Hùng', '1984-08-16', '0703456792', 'nghiem.van.hung@gmail.com', '678 Đường Đào Duy Anh, Phường Lê Lợi, TP. Hải Dương, Hải Dương'),
('386082363888', 'Tôn Đức Bảo', '2001-07-23', '0604567804', 'ton.duc.bao@gmail.com', '987 Đường Bạch Đằng, Phường Hà An, TP. Hạ Long, Quảng Ninh'),
('255394620310', 'Thân Văn Tuấn', '1997-04-12', '0901234581', 'than.van.tuan@gmail.com', '543 Đường Hồ Thị Kỷ, Phường An Cựu, TP. Huế, Thừa Thiên/Huế'),
('807153040038', 'Hứa Đình Hoàng', '1985-12-13', '0802345692', 'hua.dinh.hoang@gmail.com', '321 Đường Nguyễn Huệ, Phường Tân Phong, Quận 7, TP. Hồ Chí Minh'),
('100023666204', 'Khuất Thị Bảo Yến', '1995-01-29', '0703456793', 'khuat.thi.bao.yen@gmail.com', '654 Đường Nguyễn Đình Chính, Phường Phú Hòa, TP. Thủ Dầu Một, Bình Dương'),
('430016040770', 'Trần Thanh Minh Hòa', '1983-09-28', '0604567805', 'tran.thanh.minh.hoa@gmail.com', '789 Đường Trần Hưng Đạo, Phường Thanh Bình, TP. Hải Dương, Hải Dương'),
('835245869041', 'Lê Văn Hữu Duy', '1991-07-21', '0901234582', 'le.van.huu.duy@gmail.com', '234 Đường Võ Thị Sáu, Phường Mỹ Phước, TP. Long Xuyên, An Giang'),
('959807718517', 'Phạm Đình Công Tâm', '1999-06-26', '0802345693', 'pham.dinh.cong.tam@gmail.com', '321 Đường Nguyễn Huệ, Phường Trà An, TP. Vũng Tàu, Bà Rịa / Vũng Tàu'),
('009757245041', 'Huỳnh Minh Tuấn Đức', '1986-08-11', '0703456794', 'huynh.minh.tuan.duc@gmail.com', '654 Đường Nguyễn Đình Chính, Phường Phú Lâm, Quận Tân Phú, TP. Hồ Chí Minh'),
('969200195727', 'Hoàng Công Minh Thanh', '1980-06-06', '0604567806', 'hoang.cong.minh.thanh@gmail.com', '789 Đường Trần Hưng Đạo, Phường Phước Long, TP. Nha Trang, Khánh Hòa'),
('865824150715', 'Võ Đức Thành Duy', '1996-05-25', '0901234583', 'vo.duc.thanh.duy@gmail.com', '234 Đường Võ Thị Sáu, Phường Cái Khế, Quận Ninh Kiều, Cần Thơ'),
('840184014890', 'Đặng Công Bình Phúc', '1985-01-25', '0802345694', 'dang.cong.binh.phuc@gmail.com', '123 Đường Nguyễn Huệ, Phường Vĩnh Ninh, TP. Huế, Thừa Thiên/Huế'),
('079723707980', 'Bùi Văn Công Văn', '1987-04-09', '0703456795', 'bui.van.cong.van@gmail.com', '456 Đường Hoàng Hoa Thám, Phường Lê Đại Hành, TP. Hải Dương, Hải Dương'),
('200062400707', 'Đỗ Đình Thanh Hoàng', '1992-03-18', '0604567807', 'do.dinh.thanh.hoang@gmail.com', '789 Đường Hàm Nghi, Phường Trung Hòa, Quận Cầu Giấy, Hà Nội'),
('589186675020', 'Hồ Minh Thanh Duy', '1998-11-09', '0901234584', 'ho.minh.thanh.duy@gmail.com', '321 Đường Lê Thánh Tôn, Phường Thanh Khê Tây, Quận Thanh Khê, Đà Nẵng'),
('107336985409', 'Ngô Đức Tuấn Huy', '1984-03-07', '0802345695', 'ngo.duc.tuan.huy@gmail.com', '654 Đường Hồ Xuân Hương, Phường Võ Cường, TP. Bắc Ninh, Bắc Ninh'),
('828581646323', 'Dương Đình Minh Thông', '1997-01-16', '0703456796', 'duong.dinh.minh.thong@gmail.com', '987 Đường Lê Lai, Phường Vĩnh Tân, Quận Ninh Kiều, Cần Thơ'),
('626596562408', 'Lý Thanh Nhân Bảo', '2005-07-25', '0604567808', 'ly.thanh.nhan.bao@gmail.com', '234 Đường Điện Biên Phủ, Phường Xuân Hà, TP. Quy Nhơn, Bình Định'),
('810380804012', 'Đào Thị Đức Thùy', '1981-04-24', '0901234585', 'dao.thi.duc.thuy@gmail.com', '567 Đường Lê Duẩn, Phường Nghĩa Phương, TP. Quảng Ngãi, Quảng Ngãi'),
('706364119924', 'Đinh Công Huy Bá', '2003-10-08', '0802345696', 'dinh.cong.huy.ba@gmail.com', '876 Đường Trần Phú, Phường Hòa Cường Nam, Quận Hải Châu, Đà Nẵng'),
('878275669148', 'Mai Minh Hữu Hòa', '1988-05-18', '0703456797', 'mai.minh.huu.hoa@gmail.com', '432 Đường Phạm Văn Đồng, Phường Mỹ Đình, Quận Nam Từ Liêm, Hà Nội'),
('824009497549', 'Trịnh Thị Thanh Như', '1993-10-04', '0604567809', 'trinh.thi.thanh.nhu@gmail.com', '123 Đường Bà Triệu, Phường Ngọc Trạo, TP. Thanh Hóa, Thanh Hóa'),
('324867645707', 'Đoàn Văn Phúc Đức', '2002-08-29', '0901234586', 'doan.van.phuc.duc@gmail.com', '789 Đường Hàm Nghi, Phường Hòa An, Quận Cẩm Lệ, Đà Nẵng'),
('509155505030', 'Đặng Đức Văn Đạt', '1989-01-15', '0802345697', 'dang.duc.van.dat@gmail.com', '345 Đường Lê Lợi, Phường Điện Ngọc, TP. Điện Biên Phủ, Điện Biên'),
('700676527910', 'Phan Thị Thanh Tú', '2003-02-07', '0703456798', 'phan.thi.thanh.tu@gmail.com', '678 Đường Đào Duy Anh, Phường Lê Lợi, TP. Hải Dương, Hải Dương'),
('663029067348', 'Lương Minh Quyên Quốc', '1997-09-20', '0604567810', 'luong.minh.quyen.quoc@gmail.com', '987 Đường Bạch Đằng, Phường Hà An, TP. Hạ Long, Quảng Ninh'),
('330103202587', 'Vũ Thị Ngọc Thảo', '1985-04-15', '0901234587', 'vu.thi.ngoc.thao@gmail.com', '543 Đường Hồ Thị Kỷ, Phường An Cựu, TP. Huế, Thừa Thiên/Huế'),
('408970885250', 'Tô Thị Minh Huyền', '2001-10-11', '0802345698', 'to.thi.minh.huyen@gmail.com', '321 Đường Nguyễn Huệ, Phường Tân Phong, Quận 7, TP. Hồ Chí Minh'),
('335987900938', 'Trương Văn Minh Quang', '1989-06-25', '0703456799', 'truong.van.minh.quang@gmail.com', '654 Đường Nguyễn Đình Chính, Phường Phú Hòa, TP. Thủ Dầu Một, Bình Dương'),
('855435427109', 'Lục Văn Thanh Hà', '1994-08-21', '0604567811', 'luc.van.thanh.ha@gmail.com', '789 Đường Trần Hưng Đạo, Phường Thanh Bình, TP. Hải Dương, Hải Dương'),
('205337756125', 'Thái Đình Huy Minh', '1986-10-31', '0901234588', 'thai.dinh.huy.minh@gmail.com', '234 Đường Võ Thị Sáu, Phường Mỹ Phước, TP. Long Xuyên, An Giang'),
('804108491348', 'Kim Văn Đức Khải', '1991-12-29', '0802345699', 'kim.van.duc.khai@gmail.com', '654 Đường Nguyễn Đình Chính, Phường Phú Hòa, TP. Thủ Dầu Một, Bình Dương'),
('240205333536', 'Cao Thị Khôi Hạnh', '1994-06-01', '0703456800', 'cao.thi.khoi.hanh@gmail.com', '789 Đường Trần Hưng Đạo, Phường Thanh Bình, TP. Hải Dương, Hải Dương'),
('971013109833', 'Chu Đình Quang Khôi', '1986-05-23', '0604567812', 'chu.dinh.quang.khoi@gmail.com', '234 Đường Võ Thị Sáu, Phường Mỹ Phước, TP. Long Xuyên, An Giang'),
('087203017606', 'Trương Thái Đan Hy', '2003-06-22', '0939726205', 'hy@gmail.com', 'hcm'),
('777777777777', 'cao dang tinh', '2000-02-02', '0876252452', 'cdt@gmail.com', 'hcm'),
('066000000000', 'cao hoang oanh', '2000-02-02', '0866666666', 'oanh@gmail.com', 'hcm'),
('077282888888', 'cao dnag tinhbn', '2000-02-02', '0862040542', 'hcm@gmail.com', 'hcm'),
('111111111111', 'cao dang tinh', '2000-02-02', '0822222222', 'hcm@gmail.com', 'hcm'),
('077777777777', 'cao dang tinh', '2000-02-02', '0888888888', 'cain@gmail.com', 'hcm'),
('077203007853', 'cao đăng tình', '2003-02-05', '0862040542', 'hcm@gmail.com', 'hcm'),
('123456789999', 'Quang Huy', '2000-02-01', '0847727477', 'huy@gmail.com', 'sSD'),
('077209000000', 'cao dang tinh', '2000-02-02', '0876777777', 'hcm@gmail.com', 'chcm'),
('077777777878', 'cao dang tinh', '2000-02-02', '0862040542', 'hcm@gmail.com', 'hcm'),
('077878776565', 'cao dang tinh', '2000-03-01', '0862040542', 'hcm@gmail.com', 'hcm'),
('786765665456', 'casohjiu', '2000-02-02', '0876765654', 'ghcn@gmail.com', 'hcm'),
('090000000000', 'cao dang tinh', '2000-02-02', '0862567654', 'hcm@gmail.com', 'hcm'),
('090989887676', 'cao dang tinh', '2000-02-02', '0862040542', 'hcm@gmail.com', 'hcm'),
('051222222222', 'cadas tinh', '2000-02-02', '0521452356', 'hcm@gmail.com', 'hcm'),
('088987667876', 'cao dang tinh', '2000-02-02', '0862040542', 'hcm@gmail.com', 'hcm'),
('088798667564', 'cao dang tinh', '2000-02-02', '0862040542', 'hcm@gmail.com', 'hcm'),
('077203997867', 'cao dang tinh', '2000-02-02', '0862040542', 'hcm@gmail.com', 'hcm'),
('999999999999', 'dhlkjas', '2000-02-02', '0899999999', 'gcn@gmail.com', 'hcm'),
('077203998878', 'cao dang tinh', '2000-02-03', '0876786756', 'hcm@gmail.com', 'hcm'),
('099898888888', 'cao dang tinh', '2000-02-02', '0876767876', 'gcn@gmail.com', 'hcm'),
('077898778675', 'cao dang tinh', '2000-02-02', '0897876765', 'hcm@gmail.com', 'hcm'),
('098765342536', 'nguyen van a', '2000-02-02', '0862040523', 'hcm@gmail.com', 'hcm'),
('098098098098', 'cao dang tinh', '2000-02-29', '0862040542', 'hcm@gmail.com', 'hcm');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `nhanvien`
--

CREATE TABLE `nhanvien` (
  `MaNV` varchar(50) NOT NULL,
  `TenNV` varchar(100) NOT NULL,
  `Sdt` varchar(13) NOT NULL,
  `Email` varchar(30) NOT NULL,
  `NgaySinh` date NOT NULL,
  `DiaChi` text NOT NULL,
  `Cccd` varchar(20) NOT NULL,
  `Luong` double NOT NULL,
  `NgayVaoLam` date NOT NULL DEFAULT current_timestamp(),
  `username` varchar(50) NOT NULL,
  `role` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `nhanvien`
--

INSERT INTO `nhanvien` (`MaNV`, `TenNV`, `Sdt`, `Email`, `NgaySinh`, `DiaChi`, `Cccd`, `Luong`, `NgayVaoLam`, `username`, `role`) VALUES
('NV01', 'Trần Nam Thanh', '0802345678', 'tran.nam123@gmail.com', '1983-12-07', '123 Đường Lê Lợi, Phường 1, Quận 1, Thành phố Hồ Chí Minh', '0918734', 10000000, '2020-09-13', 'trannamthnh01', 1),
('NV02', 'Lê Thảo Hiền', '0703456789', 'le.thao123@gmail.com', '1995-04-19', '456 Đường Hà Huy Tập, Phường An Hòa, Quận Ninh Kiều, Cần Thơ', '124152', 12000000, '2020-09-13', 'lethaohien', 2),
('NV03', 'Phạm Quân Quốc Chiến', '0604567890', 'pham.quan123@gmail.com', '1986-03-03', '789 Đường Trần Hưng Đạo, Phường Hòa Xuân, Quận Cẩm Lệ, Đà Nẵng', '6314651', 16000000, '2020-09-13', 'phamquanqchien', 1),
('NV04', 'Huỳnh Ngọc Kim', '0901234568', 'huynh.ngoc123@gmail.com', '1991-09-13', '321 Đường Lê Thánh Tôn, Phường 2, Quận 10, TP. Hồ Chí Minh', '372346', 11000000, '2020-09-13', 'huynhngoc123', 2),
('NV05', 'Hoàng Sơn Hỏa', '0802345679', 'hoang.son123@gmail.com', '1994-03-13', '654 Đường Đống Đa, Phường Trần Phú, Thành phố Bắc Giang, Bắc Giang', '6327234', 11000000, '2020-09-13', 'hoangson123', 2),
('NV06', 'Võ Thanh Thanh', '0703456780', 'vo.thanh123@gmail.com', '1989-09-14', '987 Đường Lê Lai, Phường Ngô Mây, Quận Lê Chân, Hải Phòng', '2347234', 11000000, '2020-09-13', 'vothanht', 2),
('NV07', 'Đặng Linh Hoa', '0604567891', 'dang.linh123@gmail.com', '2004-10-06', '234 Đường Phạm Văn Đồng, Phường Bình Trưng Đông, Quận 2, TP. Hồ Chí Minh', '2372345', 13000000, '2020-09-13', 'danglinh01', 2),
('NV08', 'Bùi Tâm Viên', '0901234569', 'bui.tam123@gmail.com', '1992-07-06', '567 Đường Lê Duẩn, Phường Hải Châu 1, Quận Hải Châu, Đà Nẵng', '1624553', 12000000, '2020-09-13', 'buitamvien', 0),
('NV09', 'Trần Văn Hải', '0901234569', 'bui.tamHai@gmail.com', '2003-04-05', '567 Đường Lê Duẩn, Phường Hải Châu 1, Quận Hải Châu, Đà Nẵng', '1346721', 20000000, '2020-09-13', 'tvh050423', 2),
('NV10', 'Cao Hoàng Oanh', '0901234569', 'bui.tamOanh@gmail.com', '2003-07-12', '567 Đường Lê Duẩn, Phường Hải Châu 1, Quận Hải Châu, Đà Lạt', '8423451', 20000000, '2020-09-13', 'oanh1234', 1),
('NV11', 'Nguyễn Dư Thành Long', '0901234569', 'bui.tamHaiLong@gmail.com', '2003-12-12', '567 Đường Lê Duẩn, Phường Hải Châu 1, Quận Hải Châu, Hà Giang', '6812415', 360000000, '2020-09-13', 'longdunguyen', 1),
('NV12', 'Cao Đăng Tình', '0901234569', 'bui.tamHai@gmail.com', '2003-09-16', '567 Đường Lê Duẩn, Phường Hải Châu 1, Quận Hải Châu, Đà Nẵng', '1621414', 20000000, '2020-09-13', 'tinhdangcao', 0),
('NV13', 'Võ Quang Huy', '0901234569', 'bui.tamHai@gmail.com', '2003-03-18', '567 Đường Lê Duẩn, Phường Hải Châu 1, Quận Hải Châu, Đà Nẵng', '1625726', 40000000, '2020-09-13', 'voquanghuy', 0);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `phong`
--

CREATE TABLE `phong` (
  `Id` varchar(50) NOT NULL,
  `LoaiPhong` varchar(50) NOT NULL,
  `KieuGiuong` varchar(30) NOT NULL,
  `TinhTrang` varchar(20) NOT NULL,
  `Gia` double NOT NULL,
  `DonDep` tinyint(1) NOT NULL DEFAULT 1,
  `SuaChua` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `phong`
--

INSERT INTO `phong` (`Id`, `LoaiPhong`, `KieuGiuong`, `TinhTrang`, `Gia`, `DonDep`, `SuaChua`) VALUES
('P01', 'standard', 'single', 'avaiable', 300000, 1, 0),
('P02', 'standard', 'single', 'avaiable', 300000, 1, 0),
('P03', 'standard', 'single', 'occupied', 300000, 1, 0),
('P04', 'standard', 'single', 'avaiable', 300000, 1, 0),
('P05', 'standard', 'twin', 'occupied', 400000, 1, 0),
('P06', 'superior', 'twin', 'avaiable', 420000, 1, 0),
('P07', 'superior', 'twin', 'avaiable', 420000, 1, 0),
('P08', 'superior', 'double', 'avaiable', 450000, 1, 0),
('P09', 'superior', 'double', 'avaiable', 450000, 1, 0),
('P10', 'superior', 'double', 'avaiable', 450000, 1, 0),
('P11', 'superior', 'quad', 'avaiable', 490000, 1, 0),
('P12', 'superior', 'quad', 'avaiable', 490000, 1, 0),
('P13', 'superior', 'triple', 'avaiable', 450000, 1, 0),
('P14', 'superior', 'quad', 'avaiable', 490000, 1, 0),
('P15', 'deluxe', 'single', 'avaiable', 520000, 1, 0),
('P16', 'deluxe', 'double', 'avaiable', 600000, 1, 0),
('P17', 'deluxe', 'double', 'avaiable', 600000, 1, 0),
('P18', 'deluxe', 'triple', 'avaiable', 650000, 1, 0),
('P19', 'deluxe', 'quad', 'avaiable', 680000, 1, 0),
('P20', 'executive', 'double', 'avaiable', 750000, 1, 0),
('P21', 'executive', 'double', 'avaiable', 750000, 1, 0),
('P22', 'standard', 'twin', 'avaiable', 400000, 1, 0),
('P23', 'standard', 'double', 'avaiable', 320000, 1, 0),
('P24', 'superior', 'single', 'avaiable', 400000, 1, 0),
('P25', 'superior', 'quad', 'avaiable', 490000, 1, 1);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `voucher`
--

CREATE TABLE `voucher` (
  `MaVoucher` varchar(50) NOT NULL,
  `GiamGia` float NOT NULL,
  `StartDate` date NOT NULL,
  `EndDate` date NOT NULL,
  `State` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Chỉ mục cho các bảng đã đổ
--

--
-- Chỉ mục cho bảng `account`
--
ALTER TABLE `account`
  ADD PRIMARY KEY (`username`);

--
-- Chỉ mục cho bảng `datphong`
--
ALTER TABLE `datphong`
  ADD PRIMARY KEY (`Id`);

--
-- Chỉ mục cho bảng `dichvu`
--
ALTER TABLE `dichvu`
  ADD PRIMARY KEY (`MaDV`);

--
-- Chỉ mục cho bảng `hoadon`
--
ALTER TABLE `hoadon`
  ADD PRIMARY KEY (`MaHD`);

--
-- Chỉ mục cho bảng `nhanvien`
--
ALTER TABLE `nhanvien`
  ADD PRIMARY KEY (`MaNV`);

--
-- Chỉ mục cho bảng `phong`
--
ALTER TABLE `phong`
  ADD PRIMARY KEY (`Id`);

--
-- Chỉ mục cho bảng `voucher`
--
ALTER TABLE `voucher`
  ADD PRIMARY KEY (`MaVoucher`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
