-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 10, 2023 at 12:38 PM
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
-- Database: `posttest4`
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
  `kalori` varchar(255) NOT NULL DEFAULT 'NA'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `akun`
--

INSERT INTO `akun` (`id`, `nama`, `email`, `tanggal`, `password`, `kelamin`, `status`, `kalori`) VALUES
(16, 'admin', 'admin@yahoo.com', '2023-04-05', '123', 'Laki-Laki', 'admin', 'NA'),
(18, 'kjn', 'kjhj@y.com', '2005-04-03', '90', 'Perempuan', 'user', 'NA'),
(19, 'bayu', 'dasdasd', '2003-01-10', '123', 'Perempuan', 'user', '1288,5'),
(20, 'Fikri', 'dasasd', '2003-04-24', 'a', 'Laki-Laki', 'user', 'NA'),
(21, '12', '12', '2023-04-16', '12', 'Laki-Laki', 'user', '1639,4'),
(22, '11', '11', '2023-04-16', '11', 'Laki-Laki', 'user', 'NA'),
(23, 'Bayu Abdurrosyid', '123@g.com', '2022-12-20', '123', 'Laki-Laki', 'user', 'NA'),
(24, 'aaaaa', 'abd@h.com', '2013-02-01', '123', 'Laki-Laki', 'user', 'NA'),
(25, 'a', 'a', '2023-04-16', '123', 'Perempuan', 'user', 'NA'),
(26, 'qqq', 'q', '2023-04-16', 'q', 'Laki-Laki', 'user', '1478,4'),
(27, 'Bayuu', '123', '2023-04-21', '123', 'Laki-Laki', 'user', 'NA'),
(28, 'zz', 'zz', '2005-05-16', 'zz', 'Laki-Laki', 'user', 'NA');

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
  `berat` float NOT NULL,
  `kalori` float NOT NULL,
  `unit` float NOT NULL,
  `jenis` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `makanan`
--

INSERT INTO `makanan` (`id`, `nama`, `berat`, `kalori`, `unit`, `jenis`) VALUES
(24, 'Kentang Rebus', 200, 166, 2, 'Pokok'),
(25, 'Nasi Merah', 100, 175, 2, 'Pokok'),
(26, 'Ayam Goreng', 100, 245, 1, 'Lauk'),
(27, 'Telur Ayam Rebus', 60, 97, 1.25, 'Lauk'),
(28, 'Udang Rebus', 100, 91, 1.25, 'Lauk'),
(29, 'Sayur Bening', 50, 18, 0.5, 'Sayur'),
(30, 'Sayur Asam', 100, 88, 1, 'Sayur'),
(31, 'Sop Ayam', 100, 95, 1.25, 'Sayur'),
(32, 'Teh', 1, 0.4, 2.8, 'Minuman'),
(33, 'Kopi', 1, 18, 0.25, 'Minuman'),
(34, 'Pisang Ambon', 100, 74.2, 1, 'Buah'),
(35, 'tempe', 100, 192, 1, 'Lauk-pauk'),
(36, 'Tahu', 100, 120, 1, 'Lauk-pauk');

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
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;

--
-- AUTO_INCREMENT for table `diet`
--
ALTER TABLE `diet`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=63;

--
-- AUTO_INCREMENT for table `makanan`
--
ALTER TABLE `makanan`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=42;

--
-- AUTO_INCREMENT for table `setdiet`
--
ALTER TABLE `setdiet`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
