-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- 主機: 127.0.0.1
-- 產生時間： 2016-06-15 14:59:06
-- 伺服器版本: 10.1.13-MariaDB
-- PHP 版本： 5.6.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- 資料庫： `tickettailor_db_group6`
--
CREATE DATABASE IF NOT EXISTS `tickettailor_db_group6` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `tickettailor_db_group6`;

-- --------------------------------------------------------

--
-- 資料表結構 `attraction`
--

CREATE TABLE `attraction` (
  `AttractName` varchar(40) NOT NULL,
  `Duration` varchar(10) DEFAULT NULL,
  `Cancellation` varchar(7) DEFAULT NULL,
  `AttractPhoto` varchar(40) DEFAULT NULL,
  `City` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- 資料表的匯出資料 `attraction`
--

INSERT INTO `attraction` (`AttractName`, `Duration`, `Cancellation`, `AttractPhoto`, `City`) VALUES
('AdventureCove Waterpark', '1d', 'Charged', 'AdventureCove.png', 'Singapore'),
('BlueMountain Day Tour', '9h', 'Free', 'BlueMountain.png', 'Syndey'),
('BridgeClimb Experience', '3h30m', 'Free', 'BridgeClimb.png', 'Syndey'),
('Disneyland Admission', '10h', 'Free', 'Disneyland.png', 'Tokyo'),
('DisneySea Admission', '10h', 'Free', 'DisneySea.png', 'Tokyo'),
('MountFuji Lake Ashi', '10h30m', 'Free', 'MountFuji.png', 'Tokyo'),
('NightSafari Adventure', '4h30m', 'Free', 'NightSafari.png', 'Singapore'),
('OperaHouse Guided Working Tour', '1h', 'Free', 'OperaHouse.png', 'Syndey'),
('SEAAquarium', '1d', 'Charged', 'SEAAquarium.png', 'Singapore'),
('ShrimpFishing Barbecue', '4h30m', 'Free', 'ShrimpFishing.png', 'Taipei'),
('SingaporeZoee Adventure', '4h30m', 'Free', 'SingaporeZoo.png', 'Singapore'),
('TaipeiTea Culture Day', '9h', 'Free', 'TaipeiTea.png', 'Taipei'),
('TokyoMorning Tour', '4h30m', 'Charged', 'TokyoMorning.png', 'Tokyo'),
('TraditionalChinese Performing Arts', '1h', 'Charged', 'TraditionalChinese.png', 'Taipei'),
('TraditionalJapanese Performing Arts', '2h', 'Free', 'TraditionalJapanese.png', 'Tokyo'),
('UniversalStudios Singapore', '1d', 'Charged', 'UniversalStudios.png', 'Singapore'),
('Yangmingshan National Park', '9h', 'Free', 'Yangmingshan.png', 'Taipei');

-- --------------------------------------------------------

--
-- 資料表結構 `attractionbooking`
--

CREATE TABLE `attractionbooking` (
  `AttractionBookingID` int(11) NOT NULL,
  `AttractName` varchar(40) DEFAULT NULL,
  `AdultNum` int(11) DEFAULT '1',
  `ChildNum` int(11) DEFAULT '0',
  `AdultPrice` int(11) DEFAULT '0',
  `ChildPrice` int(11) DEFAULT '0',
  `Status` varchar(20) DEFAULT NULL,
  `OrderDate` date DEFAULT NULL,
  `OrderBy` varchar(10) DEFAULT NULL,
  `CustID` char(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- 資料表的匯出資料 `attractionbooking`
--

INSERT INTO `attractionbooking` (`AttractionBookingID`, `AttractName`, `AdultNum`, `ChildNum`, `AdultPrice`, `ChildPrice`, `Status`, `OrderDate`, `OrderBy`, `CustID`) VALUES
(1, 'Disneyland Admission', 2, 3, 600, 600, 'Confirmed', '2015-11-14', 'fai1', 'C005'),
(2, 'Yangmingshan National Park', 4, 1, 2400, 400, 'Confirmed', '2016-06-25', 'admin', 'C005'),
(3, 'TokyoMorning Tour', 2, 1, 700, 350, 'Self Organized', '2016-06-28', 'admin', 'C003'),
(4, 'TraditionalChinese Performing Arts', 1, 0, 900, 0, 'Confirmed', '2016-06-28', 'admin', 'C011'),
(5, 'TraditionalChinese Performing Arts', 1, 5, 900, 4500, 'Self Organized', '2016-06-22', 'admin', 'C012'),
(6, 'UniversalStudios Singapore', 4, 1, 1600, 300, 'Confirmed', '2016-06-28', 'admin', 'C008');

-- --------------------------------------------------------

--
-- 資料表結構 `attractionprice`
--

CREATE TABLE `attractionprice` (
  `AttractName` varchar(40) NOT NULL,
  `Visitor` char(5) NOT NULL,
  `Price` int(11) DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- 資料表的匯出資料 `attractionprice`
--

INSERT INTO `attractionprice` (`AttractName`, `Visitor`, `Price`) VALUES
('AdventureCove Waterpark', 'Adult', 200),
('AdventureCove Waterpark', 'Child', 120),
('BlueMountain Day Tour', 'Adult', 1000),
('BlueMountain Day Tour', 'Child', 600),
('BridgeClimb Experience', 'Adult', 1300),
('BridgeClimb Experience', 'Child', 800),
('Disneyland Admission', 'Adult', 300),
('Disneyland Admission', 'Child', 200),
('DisneySea Admission', 'Adult', 400),
('DisneySea Admission', 'Child', 300),
('MountFuji Lake Ashi', 'Adult', 200),
('MountFuji Lake Ashi', 'Child', 130),
('NightSafari Adventure', 'Adult', 350),
('NightSafari Adventure', 'Child', 260),
('OperaHouse Guided Working Tour', 'Adult', 200),
('OperaHouse Guided Working Tour', 'Child', 100),
('SEAAquarium', 'Adult', 200),
('SEAAquarium', 'Child', 150),
('ShrimpFishing Barbecue', 'Adult', 600),
('ShrimpFishing Barbecue', 'Child', 600),
('SingaporeZoee Adventure', 'Adult', 300),
('SingaporeZoee Adventure', 'Child', 160),
('TaipeiTea Culture Day', 'Adult', 600),
('TaipeiTea Culture Day', 'Child', 300),
('TokyoMorning Tour', 'Adult', 350),
('TokyoMorning Tour', 'Child', 350),
('TraditionalChinese Performing Arts', 'Adult', 900),
('TraditionalChinese Performing Arts', 'Child', 900),
('TraditionalJapanese Performing Arts', 'Adult', 500),
('TraditionalJapanese Performing Arts', 'Child', 300),
('UniversalStudios Singapore', 'Adult', 400),
('UniversalStudios Singapore', 'Child', 300),
('Yangmingshan National Park', 'Adult', 600),
('Yangmingshan National Park', 'Child', 400);

-- --------------------------------------------------------

--
-- 資料表結構 `carrier`
--

CREATE TABLE `carrier` (
  `CID` int(11) NOT NULL DEFAULT '0',
  `CarrierName` varchar(20) NOT NULL,
  `CarrLogo` varchar(15) DEFAULT NULL,
  `IATA` char(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- 資料表的匯出資料 `carrier`
--

INSERT INTO `carrier` (`CID`, `CarrierName`, `CarrLogo`, `IATA`) VALUES
(1, '中華航空', 'Carrier1.png', 'CI'),
(2, '長榮航空', 'Carrier2.png', 'BR'),
(3, '國泰航空', 'Carrier3.png', 'CX'),
(4, '香港航空', 'Carrier4.png', 'HX'),
(5, '港龍航空', 'Carrier5.png', 'KA'),
(6, '全日空航空', 'Carrier6.png', 'NH'),
(7, '日本航空', 'Carrier7.png', 'JL'),
(8, '中國東方航空', 'Carrier8.png', 'MU'),
(9, '新加坡航空', 'Carrier9.png', 'SQ'),
(10, '美國聯合航空', 'Carrier10.png', 'UA'),
(11, '阿聯酋航空', 'Carrier11.png', 'EK'),
(12, '泰國國際航空', 'Carrier12.png', 'TG');

-- --------------------------------------------------------

--
-- 資料表結構 `corganizer`
--

CREATE TABLE `corganizer` (
  `OrganID` int(11) NOT NULL,
  `OrganizerE` varchar(20) DEFAULT NULL,
  `OrganizerC` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- 資料表的匯出資料 `corganizer`
--

INSERT INTO `corganizer` (`OrganID`, `OrganizerE`, `OrganizerC`) VALUES
(1, 'RCCI', '皇家加勒比海國際郵輪'),
(2, 'Costa', '歌詩達郵輪'),
(3, 'MSC', '地中海郵輪'),
(4, 'Star Cruise', '麗星郵輪');

-- --------------------------------------------------------

--
-- 資料表結構 `cruise`
--

CREATE TABLE `cruise` (
  `CruiseNo` char(6) NOT NULL,
  `CruiseName` varchar(100) DEFAULT NULL,
  `RefPrice` decimal(11,2) DEFAULT '0.00',
  `TourDay` int(11) DEFAULT '1',
  `OrganID` int(11) DEFAULT NULL,
  `Info` varchar(10) DEFAULT NULL,
  `StartDate` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- 資料表的匯出資料 `cruise`
--

INSERT INTO `cruise` (`CruiseNo`, `CruiseName`, `RefPrice`, `TourDay`, `OrganID`, `Info`, `StartDate`) VALUES
('EMM10A', '地中海郵輪集團~華麗號, 意大利(威尼斯、布林迪西)、, 希臘(卡塔科隆)、土耳其(伊茲密爾、伊斯坦堡)、克羅地亞, 10天豪華郵輪假期', '14800.00', 10, 3, 'EMM10A.pdf', '2015-06-07'),
('HCW85A', '2015年全球首個香港啟航環球郵輪, 跨越18個國家及地區，28個目的地，85天環遊世界瑰麗假期', '285899.00', 85, 2, 'HCW85A.pdf', '2015-08-25'),
('HRO08A', '香港啟德郵輪碼頭往返, 皇家加勒比國際遊輪~海洋航行者號, 香港、中國(廈門)、日本(長崎、沖繩), 8天豪華郵輪假期', '8999.00', 7, 2, 'HRO08A.pdf', '2015-07-21'),
('HRT04A', '香港啟德郵輪碼頭往返, 皇家加勒比國際遊輪~海洋航行者號, 香港、台灣(高雄)4天豪華郵輪假期', '2899.00', 4, 1, 'HRT04A.pdf', '2015-07-25'),
('HRX06A', '香港啟德郵輪碼頭往返, 皇家加勒比國際遊輪~海洋航行者號, 香港、中國(廈門)、日本(沖繩), 6天豪華郵輪假期', '5999.00', 6, 1, 'HRX06A.pdf', '2015-07-19'),
('HSC04A', '麗星郵輪～處女星號, 香港、台灣(高雄、台中)4天郵輪假期, 【香港尖沙咀海運碼頭往返】', '3988.00', 4, 4, 'HSC04A.pdf', '2015-06-26'),
('HSG04A', '麗星郵輪～處女星號, 香港、中國(三亞)、越南(下龍灣), 4天豪華郵輪假期, 【香港尖沙咀海運碼頭往返】', '4999.00', 4, 4, 'HSG04A.pdf', '2015-07-18'),
('HSH06A', '麗星郵輪～處女星號, 香港、台灣(高雄、台中、基隆), 6天郵輪假期', '6999.00', 6, 4, 'HSH06A.pdf', '2015-06-23'),
('JPD07A', '公主遊輪～鑽石公主號, 日本(東京、橫濱、長崎)、韓國(釜山), 7天深度日本豪華郵輪假期', '13099.00', 7, 3, 'JPD07A.pdf', '2015-08-15'),
('SSG06A', '麗星郵輪~雙子星號, 新加坡(Gardens by the Bay、環球影城)、, 馬來西亞(檳城、浮羅交怡)6天豪華郵輪假期', '5999.00', 6, 4, 'SSG06A.pdf', '2015-07-30'),
('TSA06A', '麗星郵輪～寶瓶星號, 台灣(台北、基隆)、日本(石垣島、沖繩島) 6天團', '6999.00', 6, 4, 'TSA06A.pdf', '2015-09-08'),
('URM12A', '環遊海上世界亞洲段12天豪華郵輪假期', '17999.00', 12, 1, 'URM12A.pdf', '2015-07-14');

-- --------------------------------------------------------

--
-- 資料表結構 `cruisebooking`
--

CREATE TABLE `cruisebooking` (
  `CruiseBookingID` int(11) NOT NULL,
  `CruiseNo` char(6) DEFAULT NULL,
  `AdultNum` int(11) DEFAULT '1',
  `ChildNum` int(11) DEFAULT '0',
  `AdultPrice` int(11) DEFAULT '0',
  `ChildPrice` int(11) DEFAULT '0',
  `OrderDate` date DEFAULT NULL,
  `OrderBy` varchar(10) DEFAULT NULL,
  `CustID` char(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- 資料表的匯出資料 `cruisebooking`
--

INSERT INTO `cruisebooking` (`CruiseBookingID`, `CruiseNo`, `AdultNum`, `ChildNum`, `AdultPrice`, `ChildPrice`, `OrderDate`, `OrderBy`, `CustID`) VALUES
(1, 'EMM10A', 3, 2, 44400, 29600, '2016-04-04', 'han1', 'C002'),
(2, 'HRO08A', 4, 6, 35996, 32394, '2016-06-28', 'admin', 'C009'),
(3, 'EMM10A', 6, 1, 88800, 8880, '2016-06-25', 'admin', 'C005'),
(4, 'HSH06A', 9, 0, 62991, 0, '2016-06-22', 'admin', 'C012');

-- --------------------------------------------------------

--
-- 資料表結構 `customer`
--

CREATE TABLE `customer` (
  `CustID` char(4) NOT NULL,
  `Surname` varchar(10) DEFAULT NULL,
  `GivenName` varchar(30) DEFAULT NULL,
  `DateOfBirth` date DEFAULT NULL,
  `Gender` char(1) DEFAULT NULL,
  `Passport` varchar(9) DEFAULT NULL,
  `Contact` char(8) DEFAULT NULL,
  `Nationality` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- 資料表的匯出資料 `customer`
--

INSERT INTO `customer` (`CustID`, `Surname`, `GivenName`, `DateOfBirth`, `Gender`, `Passport`, `Contact`, `Nationality`) VALUES
('C001', 'Chan', 'Chi Ming', '1982-03-15', 'M', 'F1842154', '95215852', 'Chinese'),
('C002', 'Wong', 'Chun Tin', '1991-03-31', 'F', 'G6645132', '96254685', 'Chinese'),
('C003', 'Tang', 'Tai Chi', '1979-09-24', 'M', 'T2165158', '91254854', 'Chinese'),
('C004', 'Man', 'Chi Kuen', '1952-01-18', 'M', 'G2514144', '92548475', 'Chinese'),
('C005', 'Lee', 'Man Tao', '1983-04-16', 'M', 'A1254855', '92165845', 'Chinese'),
('C006', 'Leung', 'Shun Yee', '1991-02-19', 'F', 'B1215485', '91236545', 'Chinese'),
('C007', 'Lee', 'Ka Man', '1998-06-05', 'F', 'R2315845', '92548548', 'Chinese'),
('C008', 'Lung', 'Chi Kin', '1985-12-06', 'M', 'R1254856', '97584254', 'Chinese'),
('C009', 'Chan', 'Siu Dong', '1973-08-19', 'M', 'G6584251', '94652514', 'Chinese'),
('C010', 'Cheung', 'Tai Tim', '1978-08-17', 'M', 'J56698452', '94521575', 'Chinese'),
('C011', 'Fung', 'Chi Tak', '1977-02-15', 'M', 'T15515155', '96251675', 'Chinese'),
('C012', 'Chan', 'Man Sheung', '1976-06-18', 'F', 'F21251515', '95462415', 'Chinese');

-- --------------------------------------------------------

--
-- 資料表結構 `driver`
--

CREATE TABLE `driver` (
  `DriverID` varchar(10) NOT NULL,
  `StaffName` varchar(30) DEFAULT NULL,
  `Gender` char(1) DEFAULT NULL,
  `Center` char(2) DEFAULT NULL,
  `Email` varchar(50) DEFAULT NULL,
  `Pass` char(40) DEFAULT NULL,
  `Position` varchar(30) DEFAULT NULL,
  `Salary` int(11) NOT NULL,
  `Ctype` varchar(10) DEFAULT NULL,
  `Late` int(3) DEFAULT '0',
  `SImage` varchar(10) DEFAULT NULL,
  `SparePass` varchar(40) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- 資料表的匯出資料 `driver`
--

INSERT INTO `driver` (`DriverID`, `StaffName`, `Gender`, `Center`, `Email`, `Pass`, `Position`, `Salary`, `Ctype`, `Late`, `SImage`, `SparePass`) VALUES
('ho1', 'Ho Yin', 'M', 'HQ', 'ho@tt.com', '7c4a8d09ca3762af61e59520943dc26494f8941b', 'Driver', 900, 'Driver', 5, 'Driver.jpg', null),
('kwong1', 'Kwong Johnny', 'M', 'HQ', 'kwong@tt.com', '7c4a8d09ca3762af61e59520943dc26494f8941b', 'Driver', 800, 'Driver', 1, 'Driver.jpg', null),
('lam1', 'Lam Sze Kit', 'M', 'HQ', 'lam@tt.com', '7c4a8d09ca3762af61e59520943dc26494f8941b', 'Driver', 750, 'Driver', 0, 'Driver.jpg', null),
('lam2', 'Lam Chris', 'M', 'HQ', 'chris@tt.com', '7c4a8d09ca3762af61e59520943dc26494f8941b', 'Driver', 650, 'Driver', 1, 'Driver.jpg', null),
('law1', 'Law Ming Fai', 'M', 'HQ', 'law@tt.com', '7c4a8d09ca3762af61e59520943dc26494f8941b', 'Driver', 800, 'Driver', 2, 'Driver.jpg', null),
('wu1', 'Wu Richard', 'M', 'HQ', 'weu@tt.com', '7c4a8d09ca3762af61e59520943dc26494f8941b', 'Driver', 850, 'Driver', 0, 'Driver.jpg', null);

-- --------------------------------------------------------

--
-- 資料表結構 `driverbooking`
--

CREATE TABLE `driverbooking` (
  `DriverRosterID` int(11) NOT NULL,
  `BookingDate` Date NOT NULL,
  `CustID` char(4) DEFAULT NULL,
  `VehicleBookingID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- 資料表的匯出資料 `driverbooking`
--

INSERT INTO `driverbooking` (`DriverRosterID`, `BookingDate`, `CustID`, `VehicleBookingID`) VALUES
(1, '2016-06-28', 'C008', 4),
(1, '2015-11-20', 'C005', 1),
(8, '2016-06-28', 'C011', 3),
(3, '2016-06-28', 'C011', 3),
(6, '2016-06-28', 'C008', 4),
(11, '2016-06-28', 'C011', 3),
(9, '2016-06-28', 'C008', 4);

-- --------------------------------------------------------

--
-- 資料表結構 `driverroster`
--

CREATE TABLE `driverroster` (
  `DriverRosterID` int(11) NOT NULL,
  `DriverID` varchar(10) NOT NULL,
  `TimeSlot` int(11) NOT NULL,
  `Available` char(7) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- 資料表的匯出資料 `driverroster`
--

INSERT INTO `driverroster` (`DriverRosterID`, `DriverID`, `TimeSlot`, `Available`) VALUES
(1, 'ho1', 3, 'Weekday'),
(2, 'ho1', 2, 'Weekend'),
(3, 'kwong1', 1, 'Weekday'),
(4, 'kwong1', 1, 'Weekend'),
(5, 'kwong1', 2, 'Weekend'),
(6, 'lam1', 2, 'Weekday'),
(7, 'lam1', 3, 'Weekend'),
(8, 'lam2', 2, 'Weekday'),
(9, 'law1', 1, 'Weekday'),
(10, 'law1', 2, 'Weekend'),
(11, 'wu1', 3, 'Weekday');

-- --------------------------------------------------------

--
-- 資料表結構 `equipment`
--

CREATE TABLE `equipment` (
  `EquipID` char(3) NOT NULL,
  `Equipment` varchar(50) DEFAULT NULL,
  `Suitable` varchar(10) DEFAULT NULL,
  `Price` decimal(11,2) DEFAULT '0.00',
  `EquipPhoto` char(7) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- 資料表的匯出資料 `equipment`
--

INSERT INTO `equipment` (`EquipID`, `Equipment`, `Suitable`, `Price`, `EquipPhoto`) VALUES
('e01', 'Booster seat', 'car', '28.60', 'e01.png'),
('e02', 'Additional driver', 'car', '71.60', 'e02.png'),
('e03', 'Baby seat', 'car', '78.80', 'e03.png'),
('e04', 'GPS', 'car', '100.30', 'e04.png'),
('e05', 'Drinking water', 'coach', '20.00', 'e05.png');

-- --------------------------------------------------------

--
-- 資料表結構 `equipmentlist`
--

CREATE TABLE `equipmentlist` (
  `VehicleBookingID` int(11) NOT NULL,
  `EquipID` char(3) NOT NULL,
  `EquipNum` int(11) NOT NULL,
  `EquipBookPrice` decimal(11,2) DEFAULT '0.00'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- 資料表的匯出資料 `equipmentlist`
--

INSERT INTO `equipmentlist` (`VehicleBookingID`, `EquipID`, `EquipNum`, `EquipBookPrice`) VALUES
(1, 'e03', 2, '157.60'),
(2, 'e01', 3, '85.80'),
(2, 'e02', 2, '143.20'),
(2, 'e03', 2, '157.60'),
(3, 'e05', 2, '40.00'),
(4, 'e05', 2, '40.00');

-- --------------------------------------------------------

--
-- 資料表結構 `flightbooking`
--

CREATE TABLE `flightbooking` (
  `FlightOrderID` int(11) NOT NULL,
  `FlightID` int(11) DEFAULT NULL,
  `FlightNo` varchar(6) DEFAULT NULL,
  `FlightClass` varchar(8) DEFAULT NULL,
  `FlightType` varchar(8) DEFAULT NULL,
  `AdultNum` int(11) DEFAULT '1',
  `ChildNum` int(11) DEFAULT '0',
  `InfantNum` int(11) DEFAULT '0',
  `AdultPrice` decimal(11,2) DEFAULT '0.00',
  `ChildPrice` decimal(11,2) DEFAULT '0.00',
  `InfantPrice` decimal(11,2) DEFAULT '0.00',
  `OrderDate` date DEFAULT NULL,
  `OrderBy` varchar(10) DEFAULT NULL,
  `CustID` char(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- 資料表的匯出資料 `flightbooking`
--

INSERT INTO `flightbooking` (`FlightOrderID`, `FlightID`, `FlightNo`, `FlightClass`, `FlightType`, `AdultNum`, `ChildNum`, `InfantNum`, `AdultPrice`, `ChildPrice`, `InfantPrice`, `OrderDate`, `OrderBy`, `CustID`) VALUES
(1, 47, 'MU702', 'Econ', 'Direct', 2, 0, 0, '5783.50', '0.00', '0.00', '2015-06-26', 'fai1', 'C001'),
(2, 2, 'CI680', 'Econ', 'Direct', 1, 0, 0, '1180.35', '0.00', '0.00', '2015-06-28', 'fai1', 'C001'),
(3, 4, 'BR856', 'Econ', 'Direct', 2, 1, 0, '2199.45', '832.05', '0.00', '2015-06-22', 'kuen1', 'C012'),
(4, 9, 'CX510', 'Econ', 'Direct', 2, 1, 1, '3341.10', '1198.63', '795.50', '2015-05-27', 'tak1', 'C003'),
(5, 22, 'JL7050', 'Business', 'Direct', 2, 0, 0, '23650.00', '0.00', '0.00', '2015-06-29', 'tak1', 'C003'),
(6, 24, 'JL7054', 'Econ', 'Direct', 1, 1, 0, '7644.33', '5805.00', '0.00', '2015-07-08', 'on1', 'C005'),
(7, 25, 'MU728', 'Econ', 'Indirect', 1, 2, 0, '1567.35', '2451.00', '0.00', '2015-07-08', 'on1', 'C005'),
(8, 25, 'MU728', 'Econ', 'Indirect', 1, 2, 0, '1567.35', '2451.00', '0.00', '2015-07-09', 'lung1', 'C011'),
(9, 29, 'CX659', 'Business', 'Direct', 3, 1, 0, '11287.50', '3762.50', '0.00', '2015-07-10', 'lung1', 'C009'),
(10, 31, 'CX735', 'Econ', 'Direct', 1, 0, 1, '2021.00', '0.00', '860.00', '2015-07-08', 'lung1', 'C009'),
(11, 32, 'SQ871', 'Econ', 'Direct', 2, 0, 0, '6450.00', '0.00', '0.00', '2015-05-18', 'han1', 'C008'),
(12, 32, 'SQ871', 'Econ', 'Direct', 3, 0, 0, '9675.00', '0.00', '0.00', '2015-05-20', 'yum1', 'C007'),
(13, 52, 'MU502', 'Econ', 'Direct', 5, 0, 0, '14458.75', '0.00', '0.00', '2015-05-21', 'fai1', 'C008'),
(14, 52, 'MU502', 'Econ', 'Direct', 4, 0, 0, '11567.00', '0.00', '0.00', '2015-05-29', 'fai1', 'C004'),
(15, 52, 'MU502', 'Econ', 'Direct', 2, 1, 1, '5783.50', '2580.00', '1075.00', '2015-06-18', 'fai1', 'C004'),
(16, 3, 'CX360', 'Business', 'Direct', 1, 0, 0, '6987.50', '0.00', '0.00', '2015-06-18', 'ning1', 'C001'),
(17, 3, 'CX360', 'Econ', 'Direct', 3, 1, 0, '12867.75', '3214.25', '0.00', '2015-06-20', 'kam1', 'C010'),
(18, 3, 'CX360', 'Business', 'Direct', 2, 1, 0, '13975.00', '6987.50', '0.00', '2015-06-29', 'kam1', 'C012'),
(19, 62, 'KA864', 'Econ', 'Direct', 3, 2, 0, '13222.50', '6557.50', '0.00', '2015-07-13', 'kam1', 'C010'),
(20, 62, 'KA864', 'Econ', 'Direct', 4, 0, 1, '17630.00', '0.00', '1075.00', '2015-07-01', 'kam1', 'C010'),
(21, 32, 'SQ871', 'Econ', 'Direct', 3, 0, 0, '9675.00', '0.00', '0.00', '2015-07-08', 'kuen1', 'C003'),
(23, 32, 'SQ871', 'Econ', 'Direct', 5, 1, 0, '16125.00', '3278.75', '0.00', '2015-07-01', 'kuen1', 'C003'),
(24, 33, 'SQ861', 'Business', 'Direct', 4, 0, 2, '27950.00', '0.00', '1720.00', '2015-05-24', 'kuen1', 'C003'),
(25, 33, 'SQ861', 'Business', 'Direct', 2, 2, 0, '13975.00', '13975.00', '0.00', '2015-05-15', 'kuen1', 'C007'),
(26, 7, 'CX406', 'Econ', 'Direct', 1, 0, 0, '1659.80', '86.62', '55.50', '2016-06-28', 'admin', 'C005');

-- --------------------------------------------------------

--
-- 資料表結構 `flightclass`
--

CREATE TABLE `flightclass` (
  `FlightNo` varchar(6) NOT NULL,
  `Class` varchar(8) NOT NULL,
  `FlightType` varchar(8) NOT NULL,
  `Price_Adult` decimal(11,2) DEFAULT '0.00',
  `Price_Children` decimal(11,2) DEFAULT '0.00',
  `Price_Infant` decimal(11,2) DEFAULT '0.00',
  `Tax` decimal(11,2) DEFAULT '0.00'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- 資料表的匯出資料 `flightclass`
--

INSERT INTO `flightclass` (`FlightNo`, `Class`, `FlightType`, `Price_Adult`, `Price_Children`, `Price_Infant`, `Tax`) VALUES
('BR856', 'Econ', 'Direct', '1023.00', '774.00', '596.00', '7.50'),
('BR858', 'Business', 'Direct', '3088.00', '3088.00', '3088.00', '7.50'),
('BR858', 'Econ', 'Direct', '1023.00', '774.00', '596.00', '7.50'),
('BR872', 'Econ', 'Direct', '1023.00', '774.00', '596.00', '7.50'),
('CI602', 'Business', 'Direct', '2999.00', '2999.00', '500.00', '7.50'),
('CI602', 'Econ', 'Direct', '999.00', '746.00', '500.00', '7.50'),
('CI614', 'Econ', 'Direct', '931.00', '694.00', '500.00', '7.50'),
('CI680', 'Business', 'Direct', '2977.00', '2977.00', '500.00', '7.50'),
('CI680', 'Econ', 'Direct', '1098.00', '792.00', '500.00', '7.50'),
('CX360', 'Business', 'Direct', '6500.00', '6500.00', '2000.00', '7.50'),
('CX360', 'Econ', 'Direct', '3990.00', '2990.00', '1500.00', '7.50'),
('CX364', 'Business', 'Direct', '6500.00', '6500.00', '2000.00', '7.50'),
('CX364', 'Econ', 'Direct', '3990.00', '2990.00', '1500.00', '7.50'),
('CX400', 'Econ', 'Direct', '1490.00', '1090.00', '740.00', '7.50'),
('CX406', 'Econ', 'Direct', '1544.00', '1155.00', '740.00', '7.50'),
('CX510', 'Econ', 'Direct', '1554.00', '1115.00', '740.00', '7.50'),
('CX564', 'Econ', 'Direct', '1305.00', '1174.00', '760.00', '7.50'),
('CX617', 'Econ', 'Direct', '4300.00', '3100.00', '1300.00', '7.50'),
('CX659', 'Business', 'Direct', '3500.00', '3500.00', '800.00', '7.50'),
('CX659', 'Econ', 'Direct', '1760.00', '1760.00', '800.00', '7.50'),
('CX703', 'Econ', 'Direct', '4300.00', '3100.00', '1300.00', '7.50'),
('CX713', 'Business', 'Direct', '7500.00', '7500.00', '2000.00', '7.50'),
('CX713', 'Econ', 'Direct', '4300.00', '3100.00', '1300.00', '7.50'),
('CX715', 'Business', 'Direct', '3500.00', '3500.00', '800.00', '7.50'),
('CX715', 'Econ', 'Direct', '1880.00', '1880.00', '800.00', '7.50'),
('CX735', 'Econ', 'Direct', '1880.00', '1880.00', '800.00', '7.50'),
('EK385', 'Econ', 'Direct', '2200.00', '1652.00', '600.00', '7.50'),
('EK386', 'Econ', 'Direct', '2200.00', '1652.00', '600.00', '7.50'),
('EK395', 'Econ', 'Direct', '2200.00', '1652.00', '600.00', '7.50'),
('HX232', 'Business', 'Direct', '5600.00', '5600.00', '3000.00', '7.50'),
('HX232', 'Econ', 'Direct', '2850.00', '1800.00', '1200.00', '7.50'),
('HX234', 'Econ', 'Direct', '2850.00', '1800.00', '1200.00', '7.50'),
('HX236', 'Econ', 'Direct', '27850.00', '1800.00', '1200.00', '7.50'),
('HX246', 'Business', 'Direct', '5600.00', '5600.00', '3000.00', '7.50'),
('HX246', 'Econ', 'Direct', '2850.00', '1800.00', '1200.00', '7.50'),
('HX252', 'Econ', 'Direct', '1584.00', '1152.00', '500.00', '7.50'),
('HX264', 'Econ', 'Direct', '1584.00', '1152.00', '500.00', '7.50'),
('HX282', 'Econ', 'Direct', '1584.00', '1152.00', '500.00', '7.50'),
('HX284', 'Business', 'Direct', '2499.00', '2499.00', '530.00', '7.50'),
('HX284', 'Econ', 'Direct', '1584.00', '1160.00', '530.00', '7.50'),
('JL7050', 'Business', 'Direct', '11000.00', '7111.00', '800.00', '7.50'),
('JL7050', 'Econ', 'Direct', '7111.00', '5400.00', '600.00', '7.50'),
('JL7054', 'Econ', 'Direct', '7111.00', '5400.00', '750.00', '7.50'),
('JL7060', 'Business', 'Direct', '11000.00', '7111.00', '800.00', '7.50'),
('JL7060', 'Econ', 'Direct', '7111.00', '5400.00', '750.00', '7.50'),
('KA482', 'Econ', 'Direct', '1699.00', '1140.00', '670.00', '7.50'),
('KA499', 'Econ', 'Direct', '1699.00', '1162.00', '970.00', '7.50'),
('KA565', 'Econ', 'Direct', '1069.00', '1254.00', '670.00', '7.50'),
('KA802', 'Business', 'Direct', '8000.00', '7900.00', '1200.00', '7.50'),
('KA802', 'Econ', 'Direct', '4100.00', '3050.00', '1000.00', '7.50'),
('KA858', 'Business', 'Direct', '8050.00', '7900.00', '1200.00', '7.50'),
('KA864', 'Econ', 'Direct', '4100.00', '3050.00', '1000.00', '7.50'),
('KA876', 'Econ', 'Direct', '4100.00', '3050.00', '1000.00', '7.50'),
('MU502', 'Econ', 'Direct', '2690.00', '2400.00', '1000.00', '7.50'),
('MU502', 'Econ', 'Indirect', '1990.00', '1190.00', '900.00', '7.50'),
('MU503', 'Econ', 'Indirect', '1688.00', '1550.00', '400.00', '7.50'),
('MU509', 'Econ', 'Indirect', '1658.00', '1550.00', '400.00', '7.50'),
('MU702', 'Econ', 'Direct', '2690.00', '2400.00', '1000.00', '7.50'),
('MU702', 'Econ', 'Indirect', '1990.00', '1190.00', '800.00', '7.50'),
('MU722', 'Econ', 'Indirect', '1893.00', '1140.00', '800.00', '7.50'),
('MU724', 'Econ', 'Direct', '2690.00', '2400.00', '1000.00', '7.50'),
('MU724', 'Econ', 'Indirect', '1762.00', '1145.00', '800.00', '7.50'),
('MU728', 'Econ', 'Indirect', '1458.00', '1140.00', '400.00', '7.50'),
('SQ857', 'Econ', 'Direct', '2950.00', '2950.00', '800.00', '7.50'),
('SQ861', 'Business', 'Direct', '6500.00', '6500.00', '800.00', '7.50'),
('SQ861', 'Econ', 'Direct', '3000.00', '3050.00', '800.00', '7.50'),
('SQ865', 'Business', 'Direct', '6500.00', '6500.00', '800.00', '7.50'),
('SQ865', 'Econ', 'Direct', '3050.00', '3050.00', '800.00', '7.50'),
('SQ871', 'Econ', 'Direct', '3000.00', '3050.00', '800.00', '7.50'),
('SQ891', 'Econ', 'Direct', '3010.00', '3010.00', '800.00', '7.50'),
('TG601', 'Business', 'Direct', '5600.00', '5600.00', '1200.00', '7.50'),
('TG601', 'Econ', 'Direct', '2400.00', '1850.00', '1000.00', '7.50'),
('TG603', 'Econ', 'Direct', '2400.00', '1850.00', '1000.00', '7.50'),
('TG607', 'Econ', 'Direct', '2400.00', '1850.00', '1000.00', '7.50'),
('TG639', 'Business', 'Direct', '5600.00', '5600.00', '1200.00', '7.50'),
('TG639', 'Econ', 'Direct', '2400.00', '1850.00', '1000.00', '7.50');

-- --------------------------------------------------------

--
-- 資料表結構 `flightschedule`
--

CREATE TABLE `flightschedule` (
  `FlightID` int(11) NOT NULL,
  `Carrier` int(11) DEFAULT NULL,
  `EDD` date DEFAULT NULL,
  `EDA` date DEFAULT NULL,
  `ETD` time DEFAULT NULL,
  `ETA` time DEFAULT NULL,
  `Origin` char(3) DEFAULT NULL,
  `Dest` char(3) DEFAULT NULL,
  `Aircraft` varchar(8) DEFAULT NULL,
  `TravelTime` int(11) DEFAULT NULL,
  `FlightNo` varchar(6) DEFAULT NULL,
  `FlightType` varchar(8) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- 資料表的匯出資料 `flightschedule`
--

INSERT INTO `flightschedule` (`FlightID`, `Carrier`, `EDD`, `EDA`, `ETD`, `ETA`, `Origin`, `Dest`, `Aircraft`, `TravelTime`, `FlightNo`, `FlightType`) VALUES
(1, 1, '2015-06-20', '2015-06-20', '10:15:00', '11:55:00', 'HKG', 'TPE', '747-400', 100, 'CI602', 'Direct'),
(2, 1, '2015-06-20', '2015-06-20', '13:25:00', '15:05:00', 'HKG', 'TPE', 'A330-300', 100, 'CI680', 'Direct'),
(3, 1, '2015-06-20', '2015-06-20', '17:35:00', '19:15:00', 'HKG', 'TPE', 'A330-300', 100, 'CI614', 'Direct'),
(4, 2, '2015-06-22', '2015-06-22', '17:00:00', '18:45:00', 'HKG', 'TPE', 'A330-300', 105, 'BR856', 'Direct'),
(5, 2, '2015-06-22', '2015-06-22', '20:55:00', '22:40:00', 'HKG', 'TPE', 'A330-300', 105, 'BR858', 'Direct'),
(6, 2, '2015-06-23', '2015-06-23', '19:25:00', '21:10:00', 'HKG', 'TPE', 'A330-300', 105, 'BR872', 'Direct'),
(7, 3, '2015-06-20', '2015-06-20', '12:15:00', '14:15:00', 'HKG', 'TPE', 'A330-300', 120, 'CX406', 'Direct'),
(8, 3, '2015-06-20', '2015-06-20', '13:10:00', '15:05:00', 'HKG', 'TPE', 'A330-300', 115, 'CX564', 'Direct'),
(9, 3, '2015-06-22', '2015-06-22', '14:55:00', '16:45:00', 'HKG', 'TPE', 'A330-300', 110, 'CX510', 'Direct'),
(10, 3, '2015-06-22', '2015-06-22', '16:25:00', '18:15:00', 'HKG', 'TPE', 'A330-300', 110, 'CX400', 'Direct'),
(11, 4, '2015-06-23', '2015-06-24', '22:50:00', '00:40:00', 'HKG', 'TPE', 'A330-300', 110, 'HX284', 'Direct'),
(12, 4, '2015-06-20', '2015-06-20', '17:40:00', '19:30:00', 'HKG', 'TPE', 'A330-300', 110, 'HX282', 'Direct'),
(13, 4, '2015-06-20', '2015-06-20', '12:10:00', '13:50:00', 'HKG', 'TPE', 'A330-300', 100, 'HX264', 'Direct'),
(14, 4, '2015-06-21', '2015-06-21', '09:30:00', '11:25:00', 'HKG', 'TPE', 'A330-300', 115, 'HX252', 'Direct'),
(15, 5, '2015-06-20', '2015-06-20', '18:25:00', '20:15:00', 'HKG', 'TPE', 'A330-300', 115, 'KA482', 'Direct'),
(16, 5, '2015-06-21', '2015-06-21', '14:55:00', '16:45:00', 'HKG', 'TPE', 'A330-300', 110, 'KA499', 'Direct'),
(17, 5, '2015-06-24', '2015-06-24', '17:00:00', '18:45:00', 'HKG', 'TPE', 'A330-300', 105, 'KA565', 'Direct'),
(18, 6, '2015-06-18', '2015-06-19', '09:35:00', '13:15:00', 'HKG', 'KIX', 'A320', 1595, 'MU724', 'Indirect'),
(19, 6, '2016-06-18', '2016-06-19', '12:05:00', '13:10:00', 'HKG', 'KIX', 'A321', 1445, 'MU722', 'Indirect'),
(20, 6, '2016-06-24', '2016-06-25', '12:50:00', '13:10:00', 'HKG', 'KIX', 'A321', 1445, 'MU502', 'Indirect'),
(21, 6, '2016-06-25', '2016-06-26', '12:50:00', '21:30:00', 'HKG', 'KIX', 'A321', 460, 'MU702', 'Indirect'),
(22, 7, '2015-06-23', '2015-06-23', '01:45:00', '06:25:00', 'HKG', 'KIX', 'A320', 220, 'JL7050', 'Direct'),
(23, 7, '2015-06-23', '2015-06-23', '07:55:00', '12:45:00', 'HKG', 'KIX', 'A320', 230, 'JL7060', 'Direct'),
(24, 7, '2015-06-25', '2015-06-25', '13:10:00', '20:00:00', 'HKG', 'KIX', 'A320', 350, 'JL7054', 'Direct'),
(25, 8, '2015-06-19', '2015-06-20', '09:35:00', '13:10:00', 'HKG', 'KIX', 'A330-300', 1445, 'MU728', 'Indirect'),
(26, 8, '2015-06-19', '2015-06-20', '12:05:00', '13:10:00', 'HKG', 'KIX', 'A330-300', 1445, 'MU503', 'Indirect'),
(27, 8, '2015-06-19', '2015-06-20', '12:50:00', '13:10:00', 'HKG', 'KIX', 'A330-300', 1400, 'MU509', 'Indirect'),
(28, 3, '2015-07-28', '2015-07-28', '20:25:00', '00:15:00', 'HKG', 'SIN', '777-300', 230, 'CX715', 'Direct'),
(29, 3, '2015-07-28', '2015-07-28', '01:45:00', '05:25:00', 'HKG', 'SIN', 'A330-300', 220, 'CX659', 'Direct'),
(30, 3, '2015-07-29', '2015-07-29', '20:25:00', '00:15:00', 'HKG', 'SIN', '777-300', 230, 'CX715', 'Direct'),
(31, 3, '2015-07-30', '2015-07-30', '14:30:00', '18:20:00', 'HKG', 'SIN', 'A340-300', 230, 'CX735', 'Direct'),
(32, 9, '2015-07-26', '2015-07-26', '19:55:00', '23:40:00', 'HKG', 'SIN', '777-200', 225, 'SQ871', 'Direct'),
(33, 9, '2015-07-26', '2015-07-26', '15:20:00', '19:10:00', 'HKG', 'SIN', 'A380-800', 230, 'SQ861', 'Direct'),
(34, 9, '2015-07-26', '2015-07-26', '18:50:00', '22:35:00', 'HKG', 'SIN', '777-300', 225, 'SQ865', 'Direct'),
(35, 9, '2015-07-28', '2015-07-28', '09:05:00', '12:50:00', 'HKG', 'SIN', '777-300', 225, 'SQ857', 'Direct'),
(36, 9, '2015-07-30', '2015-07-30', '12:30:00', '16:15:00', 'HKG', 'SIN', 'A380-800', 225, 'SQ891', 'Direct'),
(37, 10, '2015-07-22', '2015-07-23', '20:25:00', '00:20:00', 'HKG', 'SIN', '777-300', 235, 'UA895', 'Direct'),
(38, 10, '2015-07-23', '2015-07-24', '20:25:00', '00:20:00', 'HKG', 'SIN', '777-300', 235, 'UA895', 'Direct'),
(39, 10, '2015-07-24', '2015-07-25', '20:25:00', '00:20:00', 'HKG', 'SIN', '777-300', 235, 'UA895', 'Direct'),
(40, 11, '2015-07-22', '2015-07-22', '21:50:00', '23:45:00', 'HKG', 'BKK', 'A380-800', 175, 'EK385', 'Direct'),
(41, 11, '2015-07-23', '2015-07-23', '21:50:00', '23:45:00', 'HKG', 'BKK', 'A380-800', 175, 'EK385', 'Direct'),
(42, 11, '2015-07-24', '2015-07-24', '19:50:00', '21:45:00', 'HKG', 'BKK', 'A380-800', 175, 'EK386', 'Direct'),
(43, 11, '2016-07-25', '2016-07-25', '17:50:00', '19:45:00', 'HKG', 'BKK', 'A380-800', 175, 'EK395', 'Direct'),
(44, 12, '2015-07-22', '2015-07-22', '19:05:00', '20:45:00', 'HKG', 'BKK', 'A330-300', 160, 'TG639', 'Direct'),
(45, 12, '2015-07-22', '2015-07-22', '20:45:00', '22:25:00', 'HKG', 'BKK', '747-400', 160, 'TG607', 'Direct'),
(46, 12, '2015-07-24', '2015-07-24', '13:25:00', '15:05:00', 'HKG', 'BKK', 'A380-800', 160, 'TG601', 'Direct'),
(47, 12, '2016-07-25', '2016-07-25', '07:45:00', '09:25:00', 'HKG', 'BKK', 'A330-300', 160, 'TG603', 'Direct'),
(48, 3, '2015-07-22', '2015-07-22', '08:50:00', '10:40:00', 'HKG', 'BKK', 'A330-300', 170, 'CX713', 'Direct'),
(49, 3, '2015-07-23', '2015-07-23', '17:05:00', '19:00:00', 'HKG', 'BKK', 'A330-300', 170, 'CX703', 'Direct'),
(50, 3, '2015-07-24', '2015-07-24', '21:20:00', '23:10:00', 'HKG', 'BKK', '777-300', 175, 'CX617', 'Direct'),
(51, 8, '2015-06-25', '2015-06-25', '09:35:00', '11:45:00', 'HKG', 'PVG', 'A321', 130, 'MU724', 'Direct'),
(52, 8, '2015-06-25', '2015-06-25', '12:50:00', '15:25:00', 'HKG', 'PVG', 'A321', 155, 'MU502', 'Direct'),
(53, 8, '2015-06-26', '2015-06-26', '13:55:00', '16:25:00', 'HKG', 'PVG', 'A320', 150, 'MU702', 'Direct'),
(54, 4, '2015-06-28', '2015-06-28', '13:15:00', '15:45:00', 'HKG', 'PVG', 'A330-200', 150, 'HX246', 'Direct'),
(55, 4, '2015-06-29', '2015-06-29', '21:00:00', '23:25:00', 'HKG', 'PVG', 'A330-200', 145, 'HX234', 'Direct'),
(56, 4, '2015-06-29', '2015-06-29', '17:25:00', '19:55:00', 'HKG', 'PVG', 'A330-200', 150, 'HX232', 'Direct'),
(57, 4, '2015-06-30', '2015-06-30', '08:15:00', '10:50:00', 'HKG', 'PVG', 'A330-200', 155, 'HX236', 'Direct'),
(58, 3, '2015-06-24', '2015-06-24', '17:35:00', '20:10:00', 'HKG', 'PVG', '777-300', 150, 'CX364', 'Direct'),
(59, 3, '2015-06-25', '2015-06-25', '13:55:00', '16:25:00', 'HKG', 'PVG', 'A330-200', 150, 'CX360', 'Direct'),
(60, 5, '2015-06-22', '2015-06-22', '09:55:00', '12:30:00', 'HKG', 'PVG', 'A321', 155, 'KA876', 'Direct'),
(61, 5, '2015-06-24', '2015-06-24', '08:00:00', '10:30:00', 'HKG', 'PVG', 'A330-200', 150, 'KA802', 'Direct'),
(62, 5, '2015-07-15', '2015-07-15', '09:25:00', '12:00:00', 'HKG', 'SHA', 'A330-200', 155, 'KA864', 'Direct'),
(63, 5, '2015-09-30', '2015-09-30', '10:00:00', '12:20:00', 'HKG', 'SHA', 'A330-200', 140, 'KA858', 'Direct');

-- --------------------------------------------------------

--
-- 資料表結構 `hotel`
--

CREATE TABLE `hotel` (
  `HotelID` int(11) NOT NULL,
  `Hotel_chi_name` varchar(20) DEFAULT NULL,
  `Hotel_en_name` varchar(60) DEFAULT NULL,
  `Star` decimal(2,1) DEFAULT NULL,
  `Rating` decimal(2,1) DEFAULT NULL,
  `Region` varchar(50) DEFAULT NULL,
  `Address` varchar(100) DEFAULT NULL,
  `Tel` char(8) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- 資料表的匯出資料 `hotel`
--

INSERT INTO `hotel` (`HotelID`, `Hotel_chi_name`, `Hotel_en_name`, `Star`, `Rating`, `Region`, `Address`, `Tel`) VALUES
(1, '台北君悅酒店', 'Grand Hyatt Taipei', '4.5', '4.3', 'Taipei(XinYi)', '2 SongShou Road Taipei 11051 台灣 ', '30774857'),
(2, '台北凱撒大飯店', 'Caesar Park Taipei', '4.0', '3.9', 'Taipei(ZhongZheng)', '38 Chung Hsiao West Road Section 1 Zhongzheng Taipei 100 台灣', '30774857'),
(3, '台北福華大飯店', 'The Howard Plaza Hotel Taipei', '4.0', '3.9', 'Taipei(DaAn)', '160, Sec.3, Ren Ai Rd Taipei 10657 台灣 ', '30774857'),
(4, '台北中山意舍酒店', 'amba Taipei Zhongshan', '3.5', '4.0', 'Taipei(ZhongShan)', '57-1 Zhongshan North Road Section 2 Taipei 10412 台灣 ', '30774857'),
(5, '台北晶華酒店', 'Regent Taipei', '5.0', '4.4', 'Taipei(ZhongShan)', 'No 3, Lane 39, Section 2 ZhongShan North, Road Taipei 104 台灣 ', '30774857'),
(6, '台北西華飯店', 'The Sherwood Taipei', '4.5', '4.5', 'Taipei(SongShan)', '111 Min Sheng East Road Taipei 104 台灣 ', '30774857'),
(7, '黑部觀光酒店', 'Kurobe Kanko Hotel', '3.0', '3.9', 'Japan(Omachi)', '2822 Taira Omachi Nagano-ken 398-0001 日本 ', '30774857'),
(8, '落葉松莊酒店', 'Hotel Karamatsuso', '3.0', '3.0', 'Japan(Omachi)', '2884-109 Taira Omachi Nagano-ken 398-0001 日本 ', '30774857'),
(9, '東根拉雪酒店', 'Hotel La Neige Higashi-kan', '5.0', '4.5', 'Japan(Hakuba)', 'Happo Wadanonomori Hakuba Nagano-ken 399-9301 日本', '30774857'),
(10, '松本多米酒店', 'Dormy Inn Matsumoto', '4.0', '4.6', 'Japan(Matsumoto)', '2-2-1 Fukashi Matsumoto Nagano-ken 390-0815 日本 ', '30774857'),
(11, '新加坡唐購物中心萬豪酒店', 'Singapore Marriott Tang Plaza Hotel', '5.0', '4.4', 'Singapore(Orchard Road)', '320 Orchard Road Singapore 238865 新加坡', NULL),
(12, '新加坡瑞士史丹福酒店', 'Swissotel The Stamford, Singapore', '5.0', '4.3', 'Singapore(殖民區 - 美芝路)', '2 Stamford Road Singapore 178882 新加坡 ', NULL),
(13, '克萊蒙梭公園大道酒店', 'Park Avenue Clemenceau', '4.0', '3.8', 'Singapore(新加坡河)', '81A Clemenceau Avenue # 05 - 18 UE Square Singapore 239918 新加坡', NULL),
(14, '新加坡國敦河畔大酒店', 'Grand Copthorne Waterfront Hotel Singapore', '4.0', '4.1', 'Singapore(新加坡河)', '392 Havelock Road Singapore 169663 新加坡', NULL),
(15, '聖里吉斯曼谷酒店', 'The St. Regis Bangkok', '5.0', '4.6', 'Bangkok(市中心 - 暹邏廣場)', '159 Rajadamri Road Bangkok Bangkok 10330 泰國', NULL),
(16, '帕色哇公主飯店', 'Pathumwan Princess Hotel', '4.5', '4.5', 'Bangkok(市中心 - 暹邏廣場)', '444 MBK Center, Phayathai Rd., Wangmai Pathumwan Bangkok Bangkok 10330 泰國', NULL),
(17, '曼谷悅榕莊', 'Banyan Tree Bangkok', '5.0', '4.6', 'Bangkok(是隆路 - 沙吞)', '21/100 South Sathon Road Bangkok Bangkok 10120 泰國 ', NULL),
(18, 'D&D 旅館', 'D&D Inn', '3.0', '4.1', 'Bangkok(舊城)', '68-70 Khaosan Road, Pranakorn Bangkok 10200 泰國 ', NULL),
(19, '曼谷東方公寓', 'Oriental Residence Bangkok', '5.0', '4.7', 'Bangkok(素坤逸路)', '110 Wireless Road, Lumpini, Pathumwan Bangkok Bangkok 10330 泰國 ', NULL),
(20, '上海虹橋元一希爾頓酒店', 'Hilton Shanghai Hongqiao', '5.0', '4.2', 'Shanghai(Minhang)', 'No.1116 Hong Song East Road Minhang Shanghai 201103 中國', NULL),
(21, '和平飯店', 'Fairmont Peace Hotel', '5.0', '4.7', 'Shanghai(黃浦 - 外灘)', '20 Nanjing Road East, Huang Pu District Shanghai Shanghai 200002 中國', NULL),
(22, '上海世茂皇家艾美酒店', 'Le Royal Meridien Shanghai', '5.0', '4.3', 'Shanghai(黃浦 - 外灘)', '789 Nanjing Road East Shanghai Shanghai 200001 中國 ', NULL),
(23, '華亨賓館', 'Jin Jiang Hua Ting Hotel & Towers', '4.0', '3.6', 'Shanghai(徐匯)', '1200 Cao Xi Bei Road Shanghai Shanghai 200030 中國', NULL),
(24, '上海靜安香格里拉大酒店', 'Jing An Shangri-La, West Shanghai', '4.5', '4.7', 'Shanghai(長寧)', '1218 Middle Yan''an Road Jing An Kerry Centre, West Nanjing Shanghai Shanghai 200040 中國', NULL);

-- --------------------------------------------------------

--
-- 資料表結構 `hotel_room`
--

CREATE TABLE `hotel_room` (
  `Hotel_roomID` int(11) NOT NULL,
  `Hotel_chi_name` varchar(20) DEFAULT NULL,
  `Hotel_room_name` varchar(60) DEFAULT NULL,
  `Hotel room size` varchar(7) DEFAULT NULL,
  `Max_adult` int(11) DEFAULT NULL,
  `Max_child` int(11) DEFAULT NULL,
  `Hotel_room_description` varchar(20) DEFAULT NULL,
  `Fare` decimal(11,2) DEFAULT '0.00',
  `HotelID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- 資料表的匯出資料 `hotel_room`
--

INSERT INTO `hotel_room` (`Hotel_roomID`, `Hotel_chi_name`, `Hotel_room_name`, `Hotel room size`, `Max_adult`, `Max_child`, `Hotel_room_description`, `Fare`, `HotelID`) VALUES
(1, '台北君悅酒店', '君悅客房 - 一大床', '24 平方米', 3, 2, '1 張特大雙人床', '2343.61', 1),
(2, '台北君悅酒店', '頂級標準客房', '36 平方米', 3, 2, '2 張單人床', '2343.61', 1),
(3, '台北君悅酒店', '君悅豪華客房', '40 平方米', 3, 2, '1 張特大雙人床', '2493.20', 1),
(4, '台北君悅酒店', '君悅豪華客房 - 二小床', '40 平方米', 3, 2, '2 張單人床', '2493.20', 1),
(5, '台北君悅酒店', '嘉賓軒客房 一大床', '56 平方米', 3, 2, '1 張特大雙人床', '3241.16', 1),
(6, '台北君悅酒店', '君悅行政套房 - 一大床', '70 平方米', 3, 2, '1 張特大雙人床', '5485.04', 1),
(7, '台北君悅酒店', '頂級套房, 1 張特大雙人床', '80 平方米', 3, 2, '1 張特大雙人床', '3989.12', 1),
(8, '台北凱撒大飯店', '高級客房', '30 平方米', 3, 2, '1 張雙人床', '947.97', 2),
(9, '台北凱撒大飯店', '高級雙人房', '30 平方米', 3, 2, '2 張單人床', '1007.22', 2),
(10, '台北凱撒大飯店', 'Metro Room', '30 平方米', 2, 2, '1 張雙人床', '1141.75', 2),
(11, '台北凱撒大飯店', '四人房', '45 平方米', 4, 2, '2 張床', '1655.20', 2),
(12, '台北凱撒大飯店', '套房', '30 平方米', 3, 2, '1 張雙人床', '1363.90', 2),
(13, '台北福華大飯店', '豪華雙人房', '32 平方米', 3, 2, '1 張雙人床', '905.98', 3),
(14, '台北福華大飯店', '標準單人房', '23 平方米', 2, 1, '1 張單人床', '990.92', 3),
(15, '台北福華大飯店', '尊爵高級雙人單床房', '26 平方米', 3, 2, '1 張特大雙人床', '1392.11', 3),
(16, '台北福華大飯店', '尊爵高級套房', '26 平方米', 3, 2, '1 張特大雙人床', '1397.99', 3),
(17, '台北中山意舍酒店', '中房一中床', '34 平方米', 3, 2, '1 張加大雙人床', '758.46', 4),
(18, '台北中山意舍酒店', '酷景房一中床', '35 平方米', 3, 2, '1 張加大雙人床', '970.70', 4),
(19, '台北中山意舍酒店', '陽台房二單床', '35 平方米', 3, 2, '2 張單人床', '1112.26', 4),
(20, '台北中山意舍酒店', '標準客房', '35 平方米', 3, 2, '1 張特大雙人床', '1645.50', 4),
(21, '台北晶華酒店', '高級客房', '45 平方米', 3, 2, '1 張特大雙人床', '1634.83', 5),
(22, '台北晶華酒店', '豪華客房一特大床客房', '55 平方米', 3, 2, '1 張特大雙人床', '1747.02', 5),
(23, '台北晶華酒店', '寰宇客房一大床', '60 平方米', 3, 2, '1 張特大雙人床', '2016.28', 5),
(24, '台北晶華酒店', '精緻套房', '60 平方米', 3, 2, '1 張特大雙人床', '3747.28', 5),
(25, '台北西華飯店', '豪華標準客房', '70 平方米', 3, 2, '1 張特大雙人床', '1221.02', 6),
(26, '台北西華飯店', '豪華雙人房', '30 平方米', 3, 2, '2 張單人床', '1259.18', 6),
(27, '台北西華飯店', '豪華三人房', '39 平方米', 4, 2, '3 張單人床', '1459.50', 6),
(28, '台北西華飯店', '行政標準客房', '60 平方米', 3, 2, '1 張特大雙人床', '1602.59', 6),
(29, '台北西華飯店', '普通套房', '25 平方米', 3, 2, '1 張特大雙人床', '1907.84', 6),
(30, '黑部觀光酒店', '傳統客房 (8 Tatami mat)', '30 平方米', 3, 2, '1 張日式床墊', '706.03', 7),
(31, '黑部觀光酒店', '傳統客房', '30 平方米', 3, 2, '1 張日式床墊', '724.28', 7),
(32, '落葉松莊酒店', '傳統客房 (Japanese Style Room)', '60 平方米', 6, 2, '4 張日式床墊', '917.52', 8),
(33, '落葉松莊酒店', '傳統客房 (Run of the House Japanese Style Room)', '35 平方米', 3, 2, '1 張日式床墊', '965.40', 8),
(34, '東根拉雪酒店', '豪華標準客房, 非吸煙房 (A Type)', '50 平方米', 3, 2, '2 張單人床', '2658.16', 9),
(35, '東根拉雪酒店', '普通套房, 非吸煙房 (B Type)', '50 平方米', 3, 2, '2 張單人床', '3175.24', 9),
(36, '東根拉雪酒店', '豪華標準客房, 非吸煙房, 轉角', '50 平方米', 3, 2, '2 張單人床', '3521.50', 9),
(37, '東根拉雪酒店', '標準小木屋, 非吸煙房', '70 平方米', 6, 2, '4 張床', '3685.50', 9),
(38, '松本多米酒店', '雙人房, 1 張雙人床, 非吸煙房', '16 平方米', 2, 1, '1 張雙人床', '680.41', 10),
(39, '松本多米酒店', '雙人房, 2 張單人床, 非吸煙房', '22 平方米', 3, 1, '2 張單人床', '780.77', 10),
(40, '新加坡唐購物中心萬豪酒店', '豪華標準客房', '56 平方米', 3, 2, '1 張特大雙人床 或 2 張單人床', '2079.24', 11),
(41, '新加坡唐購物中心萬豪酒店', '開放式客房', '60 平方米', 3, 2, '1 張特大雙人床', '2858.96', 11),
(42, '新加坡唐購物中心萬豪酒店', '行政標準客房', '60 平方米', 3, 2, '1 張特大雙人床 或 2 張單人床', '3089.98', 11),
(43, '新加坡唐購物中心萬豪酒店', '標準客房, 露台', '60 平方米', 3, 2, '1 張特大雙人床', '4452.24', 11),
(44, '新加坡瑞士史丹福酒店', '經典標準客房', '61 平方米', 3, 2, '1 張特大雙人床 或 2 張單人床', '1423.70', 12),
(45, '新加坡瑞士史丹福酒店', '標準客房 (Swiss Advantage)', '366 平方呎', 3, 2, '1 張雙人床或 1 張單人床', '1570.98', 12),
(46, '新加坡瑞士史丹福酒店', '頂級標準客房, 1 張特大雙人床', '50 平方米', 3, 2, '1 張特大雙人床', '1865.54', 12),
(47, '新加坡瑞士史丹福酒店', 'Swiss, 行政標準客房', '34 平方米', 3, 2, '1 張特大雙人床 或 2 張單人床', '1914.63', 12),
(48, '克萊蒙梭公園大道酒店', '公寓, 1 間臥室, 廚房', '43 平方米', 3, 2, '1 張加大雙人床', '1328.40', 13),
(49, '克萊蒙梭公園大道酒店', '公寓, 2 間臥室, 廚房', '57 平方米', 3, 2, '1 張加大雙人床 或 1 張單人床', '1732.70', 13),
(50, '新加坡國敦河畔大酒店', '高級客房, 海灣景', '32 平方米', 3, 2, '1 張特大雙人床', '1181.54', 14),
(51, '新加坡國敦河畔大酒店', '豪華標準客房', '28 平方米', 3, 2, '1 張特大雙人床 或 2 張單人床', '1273.95', 14),
(52, '新加坡國敦河畔大酒店', '俱樂部標準客房', '28 平方米', 3, 2, '1 張特大雙人床 或 2 張單人床', '2285.49', 14),
(53, '新加坡國敦河畔大酒店', '行政套房, 1 張特大雙人床', '55 平方米', 3, 2, '1 張特大雙人床', '2633.71', 14),
(54, '聖里吉斯曼谷酒店', '豪華標準客房, 1 張特大雙人床', '45 平方米', 3, 2, '1 張特大雙人床', '1545.54', 15),
(55, '聖里吉斯曼谷酒店', '頂級標準客房, 1 張特大雙人床', '55 平方米', 3, 2, '1 張特大雙人床', '1897.69', 15),
(56, '聖里吉斯曼谷酒店', 'St. Regis Suite, 1 King Bed', '100 平方米', 3, 2, '1 張特大雙人床', '2882.78', 15),
(57, '聖里吉斯曼谷酒店', 'Caroline Astor Suite, 1 King bed', '90 平方米', 3, 2, '1 張特大雙人床', '4732.14', 15),
(58, '帕色哇公主飯店', '高級雙人房', '34 平方米', 3, 2, '1 張雙人床 或 2 張單人床', '705.28', 16),
(59, '帕色哇公主飯店', 'Execuplus Suite, 1 Double or 2 Single Beds', '64 平方米', 3, 2, '1 張雙人床 或 2 張單人床', '1136.84', 16),
(60, '帕色哇公主飯店', '高級單人房', '34 平方米', 3, 2, '1 張雙人床 或 2 張單人床', '767.90', 16),
(61, '曼谷悅榕莊', '豪華標準客房, 1 張特大雙人床', '48 平方米', 3, 2, '1 張特大雙人床', '1006.14', 17),
(62, '曼谷悅榕莊', '套房, 1 間臥室', '59 平方米', 3, 2, '1 張特大雙人床', '1280.69', 17),
(63, '曼谷悅榕莊', '尊貴標準客房, 1 張特大雙人床', '48 平方米', 3, 2, '1 張特大雙人床', '2120.00', 17),
(64, '曼谷悅榕莊', '套房, 2 間臥室', '119 平方米', 3, 2, '2 張特大雙人床', '2870.46', 17),
(65, 'D&D 旅館', '豪華標準客房, 1 張單人床', '19 平方米', 1, 1, '1 張單人床', '176.00', 18),
(66, 'D&D 旅館', '標準客房, 2 張單人床', '21 平方米', 2, 2, '2 張單人床', '195.55', 18),
(67, 'D&D 旅館', '豪華標準客房, 1 張雙人床', '23 平方米', 2, 1, '1 張雙人床', '244.44', 18),
(68, 'D&D 旅館', 'Family with Balcony', '28 平方米', 4, 2, '2 張雙人床', '371.54', 18),
(69, 'D&D 旅館', '豪華標準客房, 3 張單人床', '26 平方米', 4, 2, '3 張單人床', '303.10', 18),
(70, '曼谷東方公寓', 'Grand Deluxe', '40 平方米', 3, 2, '1 張特大雙人床 或 2 張單人床', '939.06', 19),
(71, '曼谷東方公寓', '套房', '120 平方米', 3, 2, '1 張特大雙人床及 1 張加大雙人床', '2504.17', 19),
(72, '曼谷東方公寓', '套房, 2 間臥室', '120 平方米', 3, 2, '1 張特大雙人床及 2 張單人床', '3452.44', 19),
(73, '上海虹橋元一希爾頓酒店', '二單人床客房', '46 平方米', 2, 1, '2 張單人床', '1163.50', 20),
(74, '上海虹橋元一希爾頓酒店', '一特大床客房', '46 平方米', 3, 2, '1 張特大雙人床', '1163.50', 20),
(75, '上海虹橋元一希爾頓酒店', '豪華標準客房', '46 平方米', 3, 2, '1 張特大雙人床', '2684.55', 20),
(76, '上海虹橋元一希爾頓酒店', '一樓客房', '86 平方米', 3, 2, '1 張特大雙人床', '3302.66', 20),
(77, '和平飯店', '費爾蒙房', '49 平方米', 3, 2, '1 張特大雙人床 或 2 張加大雙人床', '1872.94', 21),
(78, '和平飯店', '費爾蒙金尊客房', '49 平方米', 3, 2, '1 張特大雙人床', '2110.18', 21),
(79, '和平飯店', '一卧室套房', '89 平方米', 3, 2, '1 張特大雙人床', '3277.64', 21),
(80, '和平飯店', '特色江景套房', '178 平方米', 3, 2, '1 張特大雙人床', '5618.82', 21),
(81, '上海世茂皇家艾美酒店', '豪華客房', '38 平方米', 3, 2, '1 張特大雙人床 或 2 張單人床', '1153.37', 22),
(82, '上海世茂皇家艾美酒店', '高級豪華房', '38 平方米', 3, 2, '1 張特大雙人床 或 2 張單人床', '1278.23', 22),
(83, '上海世茂皇家艾美酒店', '纯净客房', '38 平方米', 3, 2, '1 張特大雙人床', '1340.66', 22),
(84, '上海世茂皇家艾美酒店', '艾美房', '48 平方米', 3, 2, '1 張特大雙人床', '1403.09', 22),
(85, '上海世茂皇家艾美酒店', '帝皇套房', '72 平方米', 3, 2, '1 張特大雙人床', '11035.36', 22),
(86, '上海世茂皇家艾美酒店', '皇家套房', '92 平方米', 4, 2, '1 張特大雙人床', '48494.17', 22),
(87, '華亨賓館', '豪華大床房', '28 平方米', 3, 2, '1 張特大雙人床', '637.81', 23),
(88, '華亨賓館', '行政標準客房', '30 平方米', 3, 2, '1 張特大雙人床 或 2 張單人床', '910.69', 23),
(89, '華亨賓館', '行政豪华房', '45 平方米', 3, 2, '1 張特大雙人床', '1041.06', 23),
(90, '上海靜安香格里拉大酒店', '標準客房', '28 平方米', 3, 2, '2 張單人床', '2731.73', 24),
(91, '上海靜安香格里拉大酒店', '豪華套房, 1 張特大雙人床', '45 平方米', 3, 2, '1 張特大雙人床', '5343.59', 24),
(92, '上海靜安香格里拉大酒店', '尊貴套房', '45 平方米', 3, 2, '1 張特大雙人床', '5343.59', 24);

-- --------------------------------------------------------

--
-- 資料表結構 `hotelbooking`
--

CREATE TABLE `hotelbooking` (
  `HotelRoomID` int(11) NOT NULL,
  `Checkin` date NOT NULL,
  `Checkout` date NOT NULL,
  `CustID` char(4) NOT NULL,
  `NumNight` int(11) DEFAULT '1',
  `NumRoom` int(11) DEFAULT NULL,
  `Price` decimal(11,2) DEFAULT NULL,
  `OrderDate` date DEFAULT NULL,
  `OrderBy` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- 資料表的匯出資料 `hotelbooking`
--

INSERT INTO `hotelbooking` (`HotelRoomID`, `Checkin`, `Checkout`, `CustID`, `NumNight`, `NumRoom`, `Price`, `OrderDate`, `OrderBy`) VALUES
(1, '2016-07-01', '2016-07-04', 'C001', 3, 1, '7030.83', '2016-06-02', 'fai1'),
(3, '2016-07-11', '2016-07-12', 'C003', 1, 1, '2493.20', '2016-05-13', 'han1'),
(6, '2016-07-22', '2016-07-26', 'C003', 4, 1, '21940.16', '2016-05-12', 'fan1'),
(11, '2016-08-01', '2016-08-11', 'C006', 10, 1, '16552.00', '2016-06-01', 'cheong1'),
(16, '2016-07-21', '2016-07-22', 'C007', 1, 1, '1397.99', '2016-05-22', 'cheong1'),
(19, '2016-06-28', '2016-06-29', 'C010', 1, 1, '1112.26', '2016-06-28', 'admin'),
(20, '2016-07-14', '2016-07-17', 'C007', 3, 1, '4936.50', '2016-04-24', 'tak1'),
(24, '2016-06-28', '2016-06-29', 'C005', 1, 1, '3747.28', '2016-06-28', 'admin'),
(25, '2016-06-21', '2016-06-24', 'C007', 3, 1, '3663.06', '2016-04-08', 'yum1'),
(30, '2016-06-28', '2016-06-29', 'C001', 1, 1, '706.03', '2016-06-28', 'admin');

-- --------------------------------------------------------

--
-- 資料表結構 `indirect`
--

CREATE TABLE `indirect` (
  `FlightID` int(11) NOT NULL,
  `StopNo` int(11) NOT NULL DEFAULT '0',
  `Stop` char(3) DEFAULT NULL,
  `EDD` date DEFAULT NULL,
  `ETD` time(5) DEFAULT NULL,
  `EDA` date DEFAULT NULL,
  `ETA` time(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- 資料表的匯出資料 `indirect`
--

INSERT INTO `indirect` (`FlightID`, `StopNo`, `Stop`, `EDD`, `ETD`, `EDA`, `ETA`) VALUES
(18, 1, 'PVG', '2015-06-18', '11:45:00.00000', '2015-06-19', '09:55:00.00000'),
(18, 2, 'KIX', '2015-06-19', '13:10:00.00000', NULL, NULL),
(19, 1, 'SHA', '2015-06-18', '14:40:00.00000', '2015-06-19', '09:55:00.00000'),
(19, 2, 'PVG', '2015-06-19', '13:10:00.00000', NULL, NULL),
(20, 1, 'PVG', '2015-06-24', '15:25:00.00000', '2015-06-25', '09:55:00.00000'),
(20, 2, 'KIX', '2015-06-25', '13:10:00.00000', NULL, NULL),
(21, 1, 'PVG', '2015-06-24', '16:25:00.00000', '2015-06-25', '09:55:00.00000'),
(21, 2, 'KIX', '2015-06-25', '13:10:00.00000', NULL, NULL),
(25, 1, 'PVG', '2015-06-19', '11:45:00.00000', '2015-06-20', '09:55:00.00000'),
(25, 2, 'KIX', '2015-06-20', '13:10:00.00000', NULL, NULL),
(26, 1, 'SHA', '2015-06-19', '15:25:00.00000', '2015-06-20', '09:55:00.00000'),
(26, 2, 'KIX', '2015-06-20', '13:10:00.00000', NULL, NULL),
(27, 1, 'PVG', '2015-06-18', '14:40:00.00000', '2015-06-20', '09:55:00.00000'),
(27, 2, 'KIX', '2015-06-20', '13:10:00.00000', NULL, NULL);

-- --------------------------------------------------------

--
-- 資料表結構 `package`
--

CREATE TABLE `package` (
  `PackageNo` int(11) NOT NULL,
  `Attaction` varchar(40) DEFAULT NULL,
  `Package` varchar(15) DEFAULT NULL,
  `Adult_price` int(11) DEFAULT '0',
  `Child_price` int(11) DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- 資料表的匯出資料 `package`
--

INSERT INTO `package` (`PackageNo`, `Attaction`, `Package`, `Adult_price`, `Child_price`) VALUES
(1, 'Yangmingshan National Park', 'Star	', 800, 600),
(2, 'UniversalStudios Singapore', 'World-Class', 1200, 900),
(3, 'NightSafari Adventure', 'Gold Pass', 880, 650),
(4, 'DisneySea Admission', 'Premium', 650, 350),
(5, 'DisneyLand Admission', 'Premium', 800, 400),
(6, 'BlueMountain Day Tour', 'President', 2200, 1400);

-- --------------------------------------------------------

--
-- 資料表結構 `staff`
--

CREATE TABLE `staff` (
  `StaffID` varchar(10) NOT NULL,
  `StaffName` varchar(30) DEFAULT NULL,
  `Gender` char(1) DEFAULT NULL,
  `Center` char(4) DEFAULT NULL,
  `Email` varchar(50) DEFAULT NULL,
  `Pass` char(40) DEFAULT NULL,
  `Position` varchar(30) DEFAULT NULL,
  `Salary` decimal(11,2) DEFAULT NULL,
  `Ctype` varchar(10) DEFAULT NULL,
  `Late` int(11) DEFAULT NULL,
  `SImage` varchar(10) DEFAULT NULL,
  `SparePass` varchar(40) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- 資料表的匯出資料 `staff`
--

INSERT INTO `staff` (`StaffID`, `StaffName`, `Gender`, `Center`, `Email`, `Pass`, `Position`, `Salary`, `Ctype`, `Late`, `SImage`, `SparePass`) VALUES
('admin', 'Chan Siu Ming', 'M', 'AM01', 'ming@tt.com', 'd033e22ae348aeb5660fc2140aec35850c4da997', 'Administrator', '10000.00', 'Admin', 1, 'SMing.jpg', null),
('cheong1', 'Lam Sin Cheong', 'M', 'ST02', 'cheong@tt.com', '7c4a8d09ca3762af61e59520943dc26494f8941b', 'Customer Service Officer', '13500.00', 'Officer', 3, 'Cheong.jpg', null),
('fai1', 'Siu Yao Fai', 'M', 'MK01', 'fai@tt.com', '7c4a8d09ca3762af61e59520943dc26494f8941b', 'Customer Service Officer', '18800.00', 'Officer', 5, 'Fai.jpg', null),
('fan1', 'Tang Cheuk Fan', 'M', 'ST01', 'fan@tt.com', '7c4a8d09ca3762af61e59520943dc26494f8941b', 'Customer Service Officer', '23000.00', 'Officer', 20, 'Fan.jpg', null),
('han1', 'Chan Yuen Han', 'F', 'TS01', 'han@tt.com', '7c4a8d09ca3762af61e59520943dc26494f8941b', 'Customer Service Officer', '22500.00', 'Officer', 3, 'Han.jpg', null),
('kam1', 'Yuk Siu Kam', 'F', 'ST01', 'kam@tt.com', '7c4a8d09ca3762af61e59520943dc26494f8941b', 'Center Manager', '29000.00', 'Officer', 5, 'Kam.jpg', null),
('kuen1', 'Leung Siu Kuen', 'M', 'TW01', 'kuen@tt.com', '7c4a8d09ca3762af61e59520943dc26494f8941b', 'Center Manager', '30000.00', 'Officer', 5, 'Kuen.jpg', null),
('lung1', 'Kam Hiu Lung', 'M', 'TS01', 'lung@tt.com', '7c4a8d09ca3762af61e59520943dc26494f8941b', 'Customer Service Officer', '16600.00', 'Officer', 8, 'Lung.jpg', null),
('ming1', 'Cheung Ming', 'M', 'MK01', 'ming@tt.com', '7c4a8d09ca3762af61e59520943dc26494f8941b', 'Customer Service Officer', '12500.00', 'Officer', 10, 'Ming.jpg', null),
('ning1', 'Leung Chin Ning', 'F', 'TW01', 'ning@tt.com', '7c4a8d09ca3762af61e59520943dc26494f8941b', 'Customer Service Officer', '18200.00', 'Officer', 25, 'Ning.jpg', null),
('on1', 'Lam Hin On', 'M', 'ST02', 'on@tt.com', '7c4a8d09ca3762af61e59520943dc26494f8941b', 'Center Manager', '28500.00', 'Officer', 4, 'On.jpg', null),
('shun1', 'Chan Tai Shun', 'M', 'TS01', 'shun@tt.com', '7c4a8d09ca3762af61e59520943dc26494f8941b', 'Customer Service Officer', '22000.00', 'Officer', 6, 'Shun.jpg', null),
('tak1', 'Au Siu Tak', 'M', 'MK01', 'tak@tt.com', '7c4a8d09ca3762af61e59520943dc26494f8941b', 'Customer Service Officer', '12800.00', 'Officer', 6, 'Tak.jpg', null),
('yum1', 'Chan See Yum', 'F', 'ST01', 'yum@tt.com', '7c4a8d09ca3762af61e59520943dc26494f8941b', 'Customer Service Officer', '14000.00', 'Officer', 2, 'yum.jpg', null);

-- --------------------------------------------------------

--
-- 資料表結構 `tag`
--

CREATE TABLE `tag` (
  `Tag` int(11) NOT NULL,
  `TagTypeID` int(11) NOT NULL,
  `TagType` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- 資料表的匯出資料 `tag`
--

INSERT INTO `tag` (`Tag`, `TagTypeID`, `TagType`) VALUES
(1, 3, 'Ticket-CI614-Econ-Direct'),
(1, 20, 'Hotel'),
(2, 24, 'Hotel'),
(2, 41, 'Ticket-EK385-Econ-Direct'),
(3, 16, 'Hotel'),
(4, 62, 'Ticket-KA864-Econ-Direct'),
(5, 41, 'Ticket-EK385-Econ-Direct'),
(6, 23, 'Hotel'),
(6, 24, 'Hotel'),
(6, 60, 'Ticket-KA876-Econ-Direct');

-- --------------------------------------------------------

--
-- 資料表結構 `vehicle`
--

CREATE TABLE `vehicle` (
  `VehicleID` char(5) NOT NULL,
  `VehicleName` varchar(60) NOT NULL,
  `Price` decimal(11,2) DEFAULT NULL,
  `VehicleType` varchar(10) DEFAULT NULL,
  `Capacity` int(11) DEFAULT NULL,
  `Gear` varchar(5) DEFAULT NULL,
  `Color` varchar(30) DEFAULT NULL,
  `VehiclePhoto` char(9) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- 資料表的匯出資料 `vehicle`
--

INSERT INTO `vehicle` (`VehicleID`, `VehicleName`, `Price`, `VehicleType`, `Capacity`, `Gear`, `Color`, `VehiclePhoto`) VALUES
('car01', 'Mini (Manual)', '26.94', 'car', 4, 'AT', 'blue', 'car01.png'),
('car02', 'Economy (Manual)', '27.18', 'car', 4, 'AT', 'blue', 'car02.png'),
('car03', 'Compact', '51.09', 'car', 4, 'AT/MT', 'blue', 'car03.png'),
('car04', 'Midsize (Manual)', '29.69', 'car', 4, 'MT', 'red', 'car04.png'),
('car05', 'Midsize SUV', '104.60', 'car', 5, 'MT', 'silver', 'car05.png'),
('car06', 'Standard Wagon', '60.39', 'car', 5, 'AT/MT', 'silver', 'car06.png'),
('car07', 'Airport Shuttle Bus', '98.00', 'coach', 49, 'AT', 'pink, orange, white', 'car07.jpg'),
('car08', 'Coach Bus', '150.00', 'coach', 60, 'AT/MT', 'white', 'car08.jpg'),
('car09', '23 Seaters Deluxe Shuttle Bus', '134.00', 'coach', 23, 'AT', 'green, white', 'car09.jpg'),
('car10', '29 Seaters Shuttle Bus', '100.00', 'coach', 29, 'MT', 'green, white', 'car10.jpg'),
('car11', '49 Seaters Shuttle Bus', '130.00', 'coach', 49, 'AT/MT', 'green, white', 'car11.jpg'),
('car12', '20-28 Seaters Shuttle Bus', '100.00', 'coach', 28, 'AT', 'green, white', 'car12.jpg');

-- --------------------------------------------------------

--
-- 資料表結構 `vehiclebooking`
--

CREATE TABLE `vehiclebooking` (
  `VehicleBookingID` int(11) NOT NULL,
  `VehicleID` char(5) DEFAULT NULL,
  `AttractionBookingID` int(11) DEFAULT NULL,
  `BookDay` int(11) DEFAULT '1',
  `OrderDate` date DEFAULT NULL,
  `OrderBy` varchar(10) DEFAULT NULL,
  `PickupDate` date DEFAULT NULL,
  `DropoffDate` date DEFAULT NULL,
  `DriverCost` decimal(11,2) DEFAULT '0.00',
  `VehicleBookPrice` decimal(11,2) DEFAULT '0.00'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- 資料表的匯出資料 `vehiclebooking`
--

INSERT INTO `vehiclebooking` (`VehicleBookingID`, `VehicleID`, `AttractionBookingID`, `BookDay`, `OrderDate`, `OrderBy`, `PickupDate`, `DropoffDate`, `DriverCost`, `VehicleBookPrice`) VALUES
(1, 'car07', 1, 1, '2015-11-14', 'fai1', '2015-11-20', '2015-11-20', '900.00', '998.00'),
(2, 'car01', 2, 1, '2016-06-28', 'admin', '2016-06-28', '2016-06-28', '0.00', '26.94'),
(3, 'car08', 4, 1, '2016-06-28', 'admin', '2016-06-28', '2016-06-28', '2400.00', '150.00'),
(4, 'car12', 6, 3, '2016-06-28', 'admin', '2016-06-28', '2016-06-30', '2500.00', '300.00');

--
-- 已匯出資料表的索引
--

--
-- 資料表索引 `attraction`
--
ALTER TABLE `attraction`
  ADD PRIMARY KEY (`AttractName`);

--
-- 資料表索引 `attractionbooking`
--
ALTER TABLE `attractionbooking`
  ADD PRIMARY KEY (`AttractionBookingID`),
  ADD KEY `attractionbooking_fk1` (`AttractName`);

--
-- 資料表索引 `attractionprice`
--
ALTER TABLE `attractionprice`
  ADD PRIMARY KEY (`AttractName`,`Visitor`);

--
-- 資料表索引 `carrier`
--
ALTER TABLE `carrier`
  ADD PRIMARY KEY (`CID`);

--
-- 資料表索引 `corganizer`
--
ALTER TABLE `corganizer`
  ADD PRIMARY KEY (`OrganID`);

--
-- 資料表索引 `cruise`
--
ALTER TABLE `cruise`
  ADD PRIMARY KEY (`CruiseNo`),
  ADD KEY `fk1_idx` (`OrganID`);

--
-- 資料表索引 `cruisebooking`
--
ALTER TABLE `cruisebooking`
  ADD PRIMARY KEY (`CruiseBookingID`),
  ADD KEY `cruisebooking_fk1` (`CruiseNo`),
  ADD KEY `cruisebooking_fk2` (`OrderBy`),
  ADD KEY `cruisebooking_fk3` (`CustID`);

--
-- 資料表索引 `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`CustID`);

--
-- 資料表索引 `driver`
--
ALTER TABLE `driver`
  ADD PRIMARY KEY (`DriverID`);
  
--
-- 資料表索引 `driverbooking`
--
ALTER TABLE `driverbooking`
  ADD PRIMARY KEY (`DriverRosterID`, `BookingDate`),
  ADD KEY `driverbooking_fk1` (`DriverRosterID`),
  ADD KEY `driverbooking_fk2` (`CustID`),
  ADD KEY `driverbooking_fk3` (`VehicleBookingID`);

--
-- 資料表索引 `driverroster`
--
ALTER TABLE `driverroster`
  ADD PRIMARY KEY (`DriverRosterID`),
  ADD KEY `driverroster_fk1` (`DriverID`);

--
-- 資料表索引 `equipment`
--
ALTER TABLE `equipment`
  ADD PRIMARY KEY (`EquipID`);

--
-- 資料表索引 `equipmentlist`
--
ALTER TABLE `equipmentlist`
  ADD PRIMARY KEY (`VehicleBookingID`,`EquipID`),
  ADD KEY `equipmentlist_fk1` (`EquipID`);

--
-- 資料表索引 `flightbooking`
--
ALTER TABLE `flightbooking`
  ADD PRIMARY KEY (`FlightOrderID`),
  ADD KEY `flightbooking_fk1` (`FlightID`),
  ADD KEY `flightbooking_fk2` (`CustID`),
  ADD KEY `flightbooking_fk3` (`OrderBy`),
  ADD KEY `flightbooking_fk4` (`FlightNo`,`FlightClass`,`FlightType`);

--
-- 資料表索引 `flightclass`
--
ALTER TABLE `flightclass`
  ADD PRIMARY KEY (`FlightNo`,`Class`,`FlightType`);

--
-- 資料表索引 `flightschedule`
--
ALTER TABLE `flightschedule`
  ADD PRIMARY KEY (`FlightID`),
  ADD KEY `flightschedul_fk1` (`Carrier`);

--
-- 資料表索引 `hotel`
--
ALTER TABLE `hotel`
  ADD PRIMARY KEY (`HotelID`);

--
-- 資料表索引 `hotel_room`
--
ALTER TABLE `hotel_room`
  ADD PRIMARY KEY (`Hotel_roomID`),
  ADD KEY `hotel_room_fk1` (`HotelID`);

--
-- 資料表索引 `hotelbooking`
--
ALTER TABLE `hotelbooking`
  ADD PRIMARY KEY (`HotelRoomID`, `Checkin`, `Checkout`),
  ADD KEY `hotelbooking_fk1` (`OrderBy`),
  ADD KEY `hotelbooking_fk2` (`CustID`);

--
-- 資料表索引 `indirect`
--
ALTER TABLE `indirect`
  ADD PRIMARY KEY (`FlightID`,`StopNo`);

--
-- 資料表索引 `package`
--
ALTER TABLE `package`
  ADD PRIMARY KEY (`PackageNo`),
  ADD KEY `package_fk1` (`Attaction`);

--
-- 資料表索引 `staff`
--
ALTER TABLE `staff`
  ADD PRIMARY KEY (`StaffID`);

--
-- 資料表索引 `tag`
--
ALTER TABLE `tag`
  ADD PRIMARY KEY (`Tag`,`TagTypeID`,`TagType`);

--
-- 資料表索引 `vehicle`
--
ALTER TABLE `vehicle`
  ADD PRIMARY KEY (`VehicleID`);

--
-- 資料表索引 `vehiclebooking`
--
ALTER TABLE `vehiclebooking`
  ADD PRIMARY KEY (`VehicleBookingID`),
  ADD KEY `vehiclebooking_fk1` (`VehicleID`),
  ADD KEY `vehiclebooking_fk2` (`AttractionBookingID`),
  ADD KEY `vehiclebooking_fk3` (`OrderBy`);

--
-- 已匯出資料表的限制(Constraint)
--

--
-- 資料表的 Constraints `attractionbooking`
--
ALTER TABLE `attractionbooking`
  ADD CONSTRAINT `attractionbooking_fk1` FOREIGN KEY (`AttractName`) REFERENCES `attraction` (`AttractName`),
  ADD CONSTRAINT `attractionbooking_fk2` FOREIGN KEY (`OrderBy`) REFERENCES `staff` (`StaffID`),
  ADD CONSTRAINT `attractionbooking_fk3` FOREIGN KEY (`CustID`) REFERENCES `customer` (`CustID`);

--
-- 資料表的 Constraints `attractionprice`
--
ALTER TABLE `attractionprice`
  ADD CONSTRAINT `attractionprice_fk1` FOREIGN KEY (`AttractName`) REFERENCES `attraction` (`AttractName`);

--
-- 資料表的 Constraints `cruise`
--
ALTER TABLE `cruise`
  ADD CONSTRAINT `cruise_fk1` FOREIGN KEY (`OrganID`) REFERENCES `corganizer` (`OrganID`);

--
-- 資料表的 Constraints `cruisebooking`
--
ALTER TABLE `cruisebooking`
  ADD CONSTRAINT `cruisebooking_fk1` FOREIGN KEY (`CruiseNo`) REFERENCES `cruise` (`CruiseNo`),
  ADD CONSTRAINT `cruisebooking_fk2` FOREIGN KEY (`OrderBy`) REFERENCES `staff` (`StaffID`),
  ADD CONSTRAINT `cruisebooking_fk3` FOREIGN KEY (`CustID`) REFERENCES `customer` (`CustID`);

--
-- 資料表的 Constraints `driverbooking`
--
ALTER TABLE `driverbooking`
  ADD CONSTRAINT `driverbooking_fk1` FOREIGN KEY (`DriverRosterID`) REFERENCES `driverroster` (`DriverRosterID`),
  ADD CONSTRAINT `driverbooking_fk2` FOREIGN KEY (`CustID`) REFERENCES `customer` (`CustID`),
  ADD CONSTRAINT `driverbooking_fk3` FOREIGN KEY (`VehicleBookingID`) REFERENCES `vehiclebooking` (`VehicleBookingID`);

--
-- 資料表的 Constraints `driverroster`
--
ALTER TABLE `driverroster`
  ADD CONSTRAINT `driverroster_fk1` FOREIGN KEY (`DriverID`) REFERENCES `driver` (`DriverID`);

--
-- 資料表的 Constraints `equipmentlist`
--
ALTER TABLE `equipmentlist`
  ADD CONSTRAINT `equipmentlist_fk1` FOREIGN KEY (`EquipID`) REFERENCES `equipment` (`EquipID`),
  ADD CONSTRAINT `equipmentlist_fk2` FOREIGN KEY (`VehicleBookingID`) REFERENCES `vehiclebooking` (`VehicleBookingID`);

--
-- 資料表的 Constraints `flightbooking`
--
ALTER TABLE `flightbooking`
  ADD CONSTRAINT `flightbooking_fk1` FOREIGN KEY (`FlightID`) REFERENCES `flightschedule` (`FlightID`),
  ADD CONSTRAINT `flightbooking_fk2` FOREIGN KEY (`CustID`) REFERENCES `customer` (`CustID`),
  ADD CONSTRAINT `flightbooking_fk3` FOREIGN KEY (`OrderBy`) REFERENCES `staff` (`StaffID`),
  ADD CONSTRAINT `flightbooking_fk4` FOREIGN KEY (`FlightNo`,`FlightClass`,`FlightType`) REFERENCES `flightclass` (`FlightNo`, `Class`, `FlightType`);

--
-- 資料表的 Constraints `flightschedule`
--
ALTER TABLE `flightschedule`
  ADD CONSTRAINT `flightschedul_fk1` FOREIGN KEY (`Carrier`) REFERENCES `carrier` (`CID`);

--
-- 資料表的 Constraints `hotel_room`
--
ALTER TABLE `hotel_room`
  ADD CONSTRAINT `hotel_room_fk1` FOREIGN KEY (`HotelID`) REFERENCES `hotel` (`HotelID`);

--
-- 資料表的 Constraints `hotelbooking`
--
ALTER TABLE `hotelbooking`
  ADD CONSTRAINT `hotelbooking_fk1` FOREIGN KEY (`HotelRoomID`) REFERENCES `hotel_room` (`Hotel_roomID`),
  ADD CONSTRAINT `hotelbooking_fk2` FOREIGN KEY (`CustID`) REFERENCES `customer` (`CustID`),
  ADD CONSTRAINT `hotelbooking_fk3` FOREIGN KEY (`OrderBy`) REFERENCES `staff` (`StaffID`);

--
-- 資料表的 Constraints `indirect`
--
ALTER TABLE `indirect`
  ADD CONSTRAINT `indirect_fk1` FOREIGN KEY (`FlightID`) REFERENCES `flightschedule` (`FlightID`);

--
-- 資料表的 Constraints `package`
--
ALTER TABLE `package`
  ADD CONSTRAINT `package_fk1` FOREIGN KEY (`Attaction`) REFERENCES `attraction` (`AttractName`);

--
-- 資料表的 Constraints `vehiclebooking`
--
ALTER TABLE `vehiclebooking`
  ADD CONSTRAINT `vehiclebooking_fk1` FOREIGN KEY (`VehicleID`) REFERENCES `vehicle` (`VehicleID`),
  ADD CONSTRAINT `vehiclebooking_fk2` FOREIGN KEY (`AttractionBookingID`) REFERENCES `attractionbooking` (`AttractionBookingID`),
  ADD CONSTRAINT `vehiclebooking_fk3` FOREIGN KEY (`OrderBy`) REFERENCES `staff` (`StaffID`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
