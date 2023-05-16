-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 12 Bulan Mei 2023 pada 15.48
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
  `id` int(100) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `kalori` varchar(100) NOT NULL,
  `lemak` varchar(100) NOT NULL,
  `protein` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `makanan`
--

INSERT INTO `makanan` (`id`, `nama`, `kalori`, `lemak`, `protein`) VALUES
(1, 'Tahu', '144', '8', '16'),
(2, 'Nasi Putih', '130', '0,2', '2,7'),
(1, 'Tahu Goreng', '273', '19', '18'),
(2, 'Nasi Putih', '130', '0,2', '2,7'),
(3, 'Ayam Panggang Tanpa Kulit', '165', '3,6', '3,1'),
(4, 'Roti Tawar Putih', '265', '3,6', '9,4'),
(5, 'Tempe Goreng', '216', '12', '19'),
(6, 'Nasi Merah', '111', '0,9', '2,6'),
(7, 'Kentang Rebus', '77', '0,1', '2'),
(8, 'Roti Gandum', '265', '2,5', '9'),
(9, 'Telur Rebus', '156', '10', '12'),
(10, 'Salmon Panggang', '206', '13', '26');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
