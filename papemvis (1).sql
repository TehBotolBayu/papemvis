-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 19, 2023 at 02:18 PM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `papemvis`
--

-- --------------------------------------------------------

--
-- Table structure for table `akun`
--

CREATE TABLE `akun` (
  `id` int(11) NOT NULL,
  `nama` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `tanggal` date NOT NULL,
  `password` varchar(255) NOT NULL,
  `kelamin` varchar(11) NOT NULL,
  `status` varchar(11) NOT NULL,
  `kalori` varchar(255) NOT NULL DEFAULT 'NA',
  `tinggi` double NOT NULL,
  `berat` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `akun`
--

INSERT INTO `akun` (`id`, `nama`, `email`, `tanggal`, `password`, `kelamin`, `status`, `kalori`, `tinggi`, `berat`) VALUES
(16, 'admin', 'admin@yahoo.com', '2023-04-05', '123', 'Laki-Laki', 'admin', 'NA', 0, 0),
(18, 'kjn', 'kjhj@y.com', '2005-04-03', '90', 'Perempuan', 'user', 'NA', 0, 0),
(19, 'bayu', 'dasdasd', '2003-01-10', '123', 'Perempuan', 'user', '1288,5', 0, 0),
(20, 'Fikri', 'dasasd', '2003-04-24', 'a', 'Laki-Laki', 'user', 'NA', 0, 0),
(21, '12', '12', '2003-04-02', '12', 'Laki-Laki', 'user', '1639,4', 0, 0),
(22, '11', '11', '2023-04-16', '11', 'Laki-Laki', 'user', 'NA', 0, 0),
(23, 'Bayu Abdurrosyid', '123@g.com', '2022-12-20', '123', 'Laki-Laki', 'user', 'NA', 0, 0),
(24, 'aaaaa', 'abd@h.com', '2013-02-01', '123', 'Laki-Laki', 'user', 'NA', 0, 0),
(25, 'a', 'a', '2023-04-16', '123', 'Perempuan', 'user', 'NA', 0, 0),
(26, 'qqq', 'q', '2023-04-16', 'q', 'Laki-Laki', 'user', '1478,4', 0, 0),
(27, 'Bayuu', '123', '2023-04-21', '123', 'Laki-Laki', 'user', 'NA', 0, 0),
(28, 'zz', 'zz', '2005-05-16', 'zz', 'Laki-Laki', 'user', 'NA', 0, 0),
(29, 'baru', 'baru@gamil.com', '2023-05-16', '123', 'Laki-Laki', 'user', 'NA', 0, 0),
(30, 's', 's@m.com', '2023-05-16', '1', 'Laki-Laki', 'user', 'NA', 0, 0),
(31, '1', '1@g.com', '2023-05-16', '1', 'Laki-Laki', 'user', 'NA', 1, 1),
(34, 'ilhammm', '1', '2003-05-16', '1', 'Laki-Laki', 'user', '2164,9625', 170, 55);

-- --------------------------------------------------------

--
-- Table structure for table `diet`
--

CREATE TABLE `diet` (
  `id` int(11) NOT NULL,
  `idakun` int(11) NOT NULL,
  `idmakanan` int(11) NOT NULL,
  `waktu` time NOT NULL,
  `idsetdiet` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `diet`
--

INSERT INTO `diet` (`id`, `idakun`, `idmakanan`, `waktu`, `idsetdiet`) VALUES
(31, 21, 32, '03:00:00', '11'),
(32, 21, 32, '03:00:00', '11'),
(33, 21, 32, '03:00:00', '11'),
(34, 21, 32, '03:00:00', '11'),
(50, 21, 33, '16:30:00', '6'),
(51, 21, 30, '11:30:00', '6'),
(52, 21, 30, '23:30:00', '6'),
(57, 26, 27, '22:00:00', '13'),
(58, 26, 34, '22:00:00', '13'),
(59, 26, 32, '22:00:00', '13');

-- --------------------------------------------------------

--
-- Table structure for table `makanan`
--

CREATE TABLE `makanan` (
  `id` int(11) NOT NULL,
  `nama` varchar(255) NOT NULL,
  `kalori` float DEFAULT NULL,
  `lemak` float DEFAULT NULL,
  `protein` float DEFAULT NULL,
  `karbohidrat` float DEFAULT NULL,
  `berat` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `makanan`
--

INSERT INTO `makanan` (`id`, `nama`, `kalori`, `lemak`, `protein`, `karbohidrat`, `berat`) VALUES
(1, 'Nasi Goreng', 400, 15, 10, 50, 150),
(2, 'Ayam Goreng', 350, 20, 30, 5, 100),
(3, 'Mie Goreng', 450, 18, 8, 60, 120),
(4, 'Sate Ayam', 250, 12, 20, 8, 80),
(5, 'Bakso', 300, 15, 20, 10, 150),
(6, 'Gado-gado', 200, 10, 8, 25, 200),
(7, 'Soto Ayam', 350, 12, 15, 30, 180),
(8, 'Rendang', 400, 25, 40, 10, 200),
(9, 'Nasi Padang', 500, 20, 30, 60, 250),
(10, 'Sushi', 350, 10, 15, 40, 100),
(11, 'Burger', 400, 22, 18, 35, 120),
(12, 'Pizza', 450, 20, 15, 40, 200),
(13, 'Spaghetti Bolognese', 550, 25, 20, 60, 180),
(14, 'Mie Ayam', 350, 15, 20, 40, 120),
(15, 'Nasi Uduk', 300, 10, 8, 45, 150),
(16, 'Pecel Lele', 400, 18, 25, 15, 200),
(17, 'Ikan Bakar', 300, 12, 25, 5, 180),
(18, 'Sop Buntut', 450, 30, 20, 15, 250),
(19, 'Kebab', 400, 15, 20, 30, 150),
(20, 'Lontong Sayur', 350, 10, 8, 40, 200);

-- --------------------------------------------------------

--
-- Table structure for table `nutrisi`
--

CREATE TABLE `nutrisi` (
  `id` int(11) NOT NULL,
  `kalori` double NOT NULL,
  `protein` double NOT NULL,
  `lemak` double NOT NULL,
  `karbohidrat` double NOT NULL,
  `tanggal` date NOT NULL,
  `idakun` varchar(11) NOT NULL,
  `kalorimax` double NOT NULL,
  `lemakmax` double NOT NULL,
  `proteinmax` double NOT NULL,
  `karbomax` double NOT NULL,
  `idmakanan` varchar(11) NOT NULL,
  `porsi` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `nutrisi`
--

INSERT INTO `nutrisi` (`id`, `kalori`, `protein`, `lemak`, `karbohidrat`, `tanggal`, `idakun`, `kalorimax`, `lemakmax`, `proteinmax`, `karbomax`, `idmakanan`, `porsi`) VALUES
(5, 500, 40, 24, 16, '2023-05-17', '34', 2164, 541, 541, 1082, '1', 0),
(6, 450, 8, 18, 60, '2023-05-17', '34', 2164, 541, 541, 1082, '1', 0),
(7, 200, 8, 10, 25, '2023-05-17', '34', 2164, 541, 541, 1082, '1', 0),
(8, 450, 20, 30, 15, '2023-05-17', '34', 2164, 541, 541, 1082, '1', 0),
(9, 400, 16, 20, 50, '2023-05-17', '34', 2164, 541, 541, 1082, '6', 2),
(10, 6600, 240, 300, 720, '2023-05-18', '34', 2164, 541, 541, 1082, '13', 12),
(11, 52850, 2265, 1812, 4530, '2023-05-18', '34', 2164, 541, 541, 1082, '7', 151),
(14, 400, 10, 15, 50, '2023-05-20', '34', 2164, 541, 541, 1082, '1', 1),
(15, 450, 8, 18, 60, '2023-05-20', '34', 2164, 541, 541, 1082, '3', 1);

-- --------------------------------------------------------

--
-- Table structure for table `setdiet`
--

CREATE TABLE `setdiet` (
  `id` int(11) NOT NULL,
  `nama` text NOT NULL,
  `idakun` varchar(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `setdiet`
--

INSERT INTO `setdiet` (`id`, `nama`, `idakun`) VALUES
(6, 'baru', '21'),
(7, 'baru', '22'),
(12, 'Senin', '24'),
(13, 'Hari Senin', '26'),
(15, 'Kamis', '');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `akun`
--
ALTER TABLE `akun`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `diet`
--
ALTER TABLE `diet`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `makanan`
--
ALTER TABLE `makanan`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `nutrisi`
--
ALTER TABLE `nutrisi`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `setdiet`
--
ALTER TABLE `setdiet`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `akun`
--
ALTER TABLE `akun`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=35;

--
-- AUTO_INCREMENT for table `diet`
--
ALTER TABLE `diet`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=63;

--
-- AUTO_INCREMENT for table `makanan`
--
ALTER TABLE `makanan`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `nutrisi`
--
ALTER TABLE `nutrisi`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `setdiet`
--
ALTER TABLE `setdiet`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
