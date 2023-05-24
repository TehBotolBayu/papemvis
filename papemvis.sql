-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 24 Bulan Mei 2023 pada 17.45
-- Versi server: 10.4.24-MariaDB
-- Versi PHP: 7.4.29

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
-- Struktur dari tabel `akun`
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
  `berat` double NOT NULL,
  `aktivitas` int(11) NOT NULL,
  `img` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `akun`
--

INSERT INTO `akun` (`id`, `nama`, `email`, `tanggal`, `password`, `kelamin`, `status`, `kalori`, `tinggi`, `berat`, `aktivitas`, `img`) VALUES
(16, 'admin', 'a', '2023-04-05', 'a', 'Laki-Laki', 'admin', 'NA', 163, 50, 1, ''),
(35, 'admin', 'admin2@gmail.com', '2013-05-15', '1', 'Laki-Laki', 'admin', '1200', 165, 50, -1, 'C:\\Users\\USER\\Pictures\\1papemvis\\miegoreng.jpg'),
(36, 'ilham', 'ilham@gmail.com', '2002-05-24', '1', 'Laki-Laki', 'user', '1893,265', 165, 55, 1, 'C:\\Users\\USER\\Pictures\\1papemvis\\miegoreng.jpg'),
(37, 'bayu', 'bayu@gmail.com', '1994-11-21', '123', 'Laki-Laki', 'user', '2231,616', 180, 80, 0, 'C:\\Users\\acer\\Pictures\\poster reference\\331240389_1255480845042892_1499288932454683895_n.jpg'),
(38, 'bram', 'bram@gmail.com', '2013-05-01', '123', 'Perempuan', 'user', '1988,03', 150, 40, 2, 'C:\\Users\\acer\\Pictures\\download (2).jpg'),
(40, 'dani', 'dani@gmail.com', '2002-05-24', '123', 'Laki-Laki', 'user', '2417,88075', 170, 56, 3, ''),
(41, 'ayu', 'ayu@gmail.com', '2004-05-24', '123', 'Perempuan', 'user', '1849,82875', 155, 54, 1, 'C:\\Users\\USER\\Pictures\\1papemvis\\sate.jpg'),
(42, 'ardi', 'ardi@gmail.com', '2003-01-24', '123', 'Laki-Laki', 'user', '2189,84', 160, 50, 2, ''),
(43, 'hadi', 'hadi@gmail.com', '2013-05-24', '123', 'Laki-Laki', 'user', '2020,7', 160, 50, 1, 'C:\\Users\\USER\\Pictures\\1papemvis\\miegoreng.jpg'),
(44, 'fani', 'fani@gmai.com', '2000-05-24', '123', 'Perempuan', 'user', '1626,63875', 150, 40, 1, 'C:\\Users\\USER\\Pictures\\1papemvis\\sate.jpg'),
(45, 'Mr Bram', 'brm.boxer@gmail.com', '2003-08-07', 'cashless', 'Laki-Laki', 'user', '2949,94', 164, 59, 4, 'C:\\Users\\Bramantyo\\Pictures\\20220530_215926.jpg');

-- --------------------------------------------------------

--
-- Struktur dari tabel `catatan`
--

CREATE TABLE `catatan` (
  `id` int(11) NOT NULL,
  `idakun` int(11) NOT NULL,
  `isi` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktur dari tabel `makanan`
--

CREATE TABLE `makanan` (
  `id` int(11) NOT NULL,
  `nama` varchar(255) NOT NULL,
  `kalori` float DEFAULT NULL,
  `lemak` float DEFAULT NULL,
  `protein` float DEFAULT NULL,
  `karbohidrat` float DEFAULT NULL,
  `berat` float DEFAULT NULL,
  `img` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `makanan`
--

INSERT INTO `makanan` (`id`, `nama`, `kalori`, `lemak`, `protein`, `karbohidrat`, `berat`, `img`) VALUES
(2, 'Ayam Goreng   ', 320, 22, 30, 5, 100, 'C:\\Users\\USER\\Pictures\\1papemvis\\ayamgoreng.jpg'),
(3, 'Mie Goreng', 450, 18, 8, 60, 120, ''),
(4, 'Sate Ayam', 250, 12, 20, 8, 80, ''),
(5, 'Bakso', 300, 15, 20, 10, 150, ''),
(6, 'Gado-gado', 200, 10, 8, 25, 200, ''),
(7, 'Soto Ayam', 350, 12, 15, 30, 180, ''),
(9, 'Nasi Padang', 500, 20, 30, 60, 250, ''),
(10, 'Sushi', 350, 10, 15, 40, 100, ''),
(11, 'Burger', 400, 22, 18, 35, 120, ''),
(12, 'Pizza', 450, 20, 15, 40, 200, ''),
(13, 'Spaghetti Bolognese', 550, 25, 20, 60, 180, ''),
(14, 'Mie Ayam', 350, 15, 20, 40, 120, ''),
(15, 'Nasi Uduk', 300, 10, 8, 45, 150, ''),
(16, 'Pecel Lele', 400, 18, 25, 15, 200, ''),
(17, 'Ikan Bakar', 300, 12, 25, 5, 180, ''),
(18, 'Sop Buntut', 450, 30, 20, 15, 250, ''),
(19, 'Kebab', 400, 15, 20, 30, 150, ''),
(20, 'Lontong Sayur', 350, 10, 8, 40, 200, ''),
(21, 'Nasi Goreng ', 400, 15, 10, 0, 150, ''),
(22, 'Burger ', 400, 22, 18, 0, 120, ''),
(24, 'Nasi Goreng  ', 400, 15, 10, 50, 15000, ''),
(26, 'Nasi Goreng  eee ', 400, 15, 10, 50, 12, ''),
(38, 'sate bali', 300, 30, 10, 10, 250, '');

-- --------------------------------------------------------

--
-- Struktur dari tabel `nutrisi`
--

CREATE TABLE `nutrisi` (
  `id` int(11) NOT NULL,
  `kalori` double NOT NULL,
  `protein` double NOT NULL,
  `lemak` double NOT NULL,
  `karbohidrat` double NOT NULL,
  `tanggal` date NOT NULL,
  `idakun` int(11) NOT NULL,
  `kalorimax` double NOT NULL,
  `lemakmax` double NOT NULL,
  `proteinmax` double NOT NULL,
  `karbomax` double NOT NULL,
  `idmakanan` int(11) NOT NULL,
  `porsi` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `nutrisi`
--

INSERT INTO `nutrisi` (`id`, `kalori`, `protein`, `lemak`, `karbohidrat`, `tanggal`, `idakun`, `kalorimax`, `lemakmax`, `proteinmax`, `karbomax`, `idmakanan`, `porsi`) VALUES
(29, 6000, 150, 225, 750, '2023-05-22', 37, 3253, 813, 813, 1626, 1, 15),
(30, 400, 10, 15, 50, '2023-05-24', 38, 1988, 695, 298, 994, 1, 1),
(31, 700, 60, 40, 10, '2023-05-24', 38, 1988, 695, 298, 994, 2, 2),
(32, 300, 25, 12, 5, '2023-05-24', 37, 1462, 365, 365, 731, 17, 1),
(33, 800, 80, 50, 20, '2023-05-24', 39, 1847, 461, 461, 923, 8, 2),
(34, 350, 30, 20, 5, '2023-05-24', 36, 1784, 624, 267, 892, 2, 1),
(35, 350, 30, 20, 5, '2023-05-24', 37, 1462, 365, 365, 731, 2, 1),
(36, 350, 30, 20, 5, '2023-05-24', 37, 1462, 365, 365, 731, 2, 1),
(37, 450, 8, 18, 60, '2023-05-24', 36, 1893, 624, 267, 892, 3, 1),
(38, 1250, 100, 60, 40, '2023-05-24', 36, 1893, 624, 267, 892, 4, 5),
(39, 250000, 15000, 10000, 30000, '2023-05-24', 37, 1462, 365, 365, 731, 9, 500),
(40, 20000, 900, 1100, 0, '2023-05-24', 37, 1462, 365, 365, 731, 22, 50),
(41, 350, 30, 20, 5, '2023-05-24', 41, 1849, 462, 462, 924, 2, 1),
(42, 350, 30, 20, 5, '2023-05-24', 41, 1849, 462, 462, 924, 41, 1),
(43, 350, 30, 20, 5, '2023-05-24', 41, 1849, 462, 462, 924, 41, 1),
(44, 350, 30, 20, 5, '2023-05-24', 41, 1849, 462, 462, 924, 41, 1),
(45, 350, 30, 20, 5, '2023-05-24', 41, 1849, 462, 462, 924, 41, 1),
(46, 350, 30, 20, 5, '2023-05-24', 42, 2189, 617, 617, 1235, 2, 1),
(47, 1350, 24, 54, 180, '2023-05-24', 42, 2189, 617, 617, 1235, 3, 3),
(48, 350, 30, 20, 5, '2023-05-24', 42, 2189, 617, 617, 1235, 2, 1),
(49, 700, 60, 40, 10, '2023-05-24', 42, 2189, 547, 547, 1094, 2, 2),
(50, 700, 60, 40, 10, '2023-05-24', 42, 2189, 547, 547, 1094, 2, 2),
(51, 700, 60, 40, 10, '2023-05-23', 42, 2189, 547, 547, 1094, 2, 2),
(52, 700, 60, 40, 10, '2023-05-23', 42, 2189, 547, 547, 1094, 2, 2),
(53, 1500, 100, 75, 50, '2023-05-23', 42, 2189, 547, 547, 1094, 5, 5),
(54, 600, 40, 30, 20, '2023-05-23', 42, 2189, 547, 547, 1094, 5, 2),
(55, 700, 66, 40, 10, '2023-05-24', 44, 1626, 474, 474, 949, 2, 2),
(56, 750, 60, 36, 24, '2023-05-24', 44, 1626, 474, 474, 949, 4, 3);

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `akun`
--
ALTER TABLE `akun`
  ADD PRIMARY KEY (`id`);

--
-- Indeks untuk tabel `catatan`
--
ALTER TABLE `catatan`
  ADD PRIMARY KEY (`id`),
  ADD KEY `idakun` (`idakun`);

--
-- Indeks untuk tabel `makanan`
--
ALTER TABLE `makanan`
  ADD PRIMARY KEY (`id`);

--
-- Indeks untuk tabel `nutrisi`
--
ALTER TABLE `nutrisi`
  ADD PRIMARY KEY (`id`),
  ADD KEY `idakun` (`idakun`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `akun`
--
ALTER TABLE `akun`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=46;

--
-- AUTO_INCREMENT untuk tabel `catatan`
--
ALTER TABLE `catatan`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT untuk tabel `makanan`
--
ALTER TABLE `makanan`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=39;

--
-- AUTO_INCREMENT untuk tabel `nutrisi`
--
ALTER TABLE `nutrisi`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=57;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
