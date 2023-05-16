-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 16 Bulan Mei 2023 pada 12.38
-- Versi server: 10.4.28-MariaDB
-- Versi PHP: 8.0.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `makanan`
--

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
  `berat` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `makanan`
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

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `makanan`
--
ALTER TABLE `makanan`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `makanan`
--
ALTER TABLE `makanan`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
