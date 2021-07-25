-- phpMyAdmin SQL Dump
-- version 4.2.11
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Apr 15, 2019 at 02:21 AM
-- Server version: 5.5.40
-- PHP Version: 5.5.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `bilaal_pln`
--

-- --------------------------------------------------------

--
-- Table structure for table `pelanggan`
--

CREATE TABLE IF NOT EXISTS `pelanggan` (
  `idPelanggan` int(20) NOT NULL,
  `kdPelanggan` varchar(20) NOT NULL,
  `nama` varchar(35) NOT NULL,
  `alamat` varchar(35) NOT NULL,
  `kdTarif` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pelanggan`
--

INSERT INTO `pelanggan` (`idPelanggan`, `kdPelanggan`, `nama`, `alamat`, `kdTarif`) VALUES
(1, 'PL0001', 'Kiko', 'Jl. Karang Tinggal no. 17', '3'),
(2, 'PL0002', 'Muhamad Bilaal Kunaefi', 'Jl. Kasuari XII, Blok HB16, No. 2', '2'),
(3, 'PL0003', 'Daffa Anargya Sardjono', 'Pondok Kacang', '1'),
(4, 'PL0004', 'Aksyarialdi Bayhaki Alli usrman', 'Tangerang', '2'),
(5, 'PL0005', 'Nizar Fadilah Zalda', 'Duta Bintaro', '4'),
(6, 'PL0006', 'Agil', 'SMK BI Bintaro', '2');

-- --------------------------------------------------------

--
-- Table structure for table `pemakaian`
--

CREATE TABLE IF NOT EXISTS `pemakaian` (
  `id_pemakai` int(11) NOT NULL,
  `kd_pemakai` varchar(24) NOT NULL,
  `kdpelanggan` varchar(24) NOT NULL,
  `meter_awal` int(11) NOT NULL,
  `meter_akhir` int(11) NOT NULL,
  `pemakaian` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pemakaian`
--

INSERT INTO `pemakaian` (`id_pemakai`, `kd_pemakai`, `kdpelanggan`, `meter_awal`, `meter_akhir`, `pemakaian`) VALUES
(1, 'PK0001', 'PL0004', 600, 1500, 900),
(2, 'PK0002', 'PL0004', 500, 1300, 800),
(3, 'PK0003', 'PL0002', 500, 700, 200);

-- --------------------------------------------------------

--
-- Table structure for table `pembayaran`
--

CREATE TABLE IF NOT EXISTS `pembayaran` (
`id_bayar` int(11) NOT NULL,
  `kd_bayar` varchar(20) NOT NULL,
  `tgl_bayar` varchar(20) NOT NULL,
  `kdTagih` varchar(20) NOT NULL,
  `jumlah_tagihan` int(11) NOT NULL,
  `biaya_denda` int(11) NOT NULL,
  `biaya_admin` int(11) NOT NULL,
  `status` varchar(20) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pembayaran`
--

INSERT INTO `pembayaran` (`id_bayar`, `kd_bayar`, `tgl_bayar`, `kdTagih`, `jumlah_tagihan`, `biaya_denda`, `biaya_admin`, `status`) VALUES
(1, 'BY0001', '11/15/2018 1:17:30 P', 'TG0001', 4600, 100, 2500, 'Lunas'),
(2, 'BY0002', '11/15/2018 1:20:41 P', 'TG0002', 4600, 100, 2500, 'Lunas'),
(3, 'BY0003', '11/15/2018 3:43:57 P', 'TG0001', 4600, 100, 2500, 'Lunas'),
(4, 'BY0004', '1/30/2019 11:51:37 P', 'TG0002', 2100, 100, 0, 'Lunas'),
(5, 'BY0005', '3/2/2019 10:25:33 AM', 'TG0005', 2605, 5, 2500, 'Lunas');

-- --------------------------------------------------------

--
-- Table structure for table `tagihan`
--

CREATE TABLE IF NOT EXISTS `tagihan` (
  `id_tagihan` int(11) NOT NULL,
  `kdTagih` varchar(30) NOT NULL,
  `thTagih` varchar(30) NOT NULL,
  `blnTagih` varchar(30) NOT NULL,
  `kdTarif` varchar(20) NOT NULL,
  `pemakaian` varchar(30) NOT NULL,
  `status` varchar(30) NOT NULL,
  `kdPelanggan` varchar(30) NOT NULL,
  `total` int(55) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tagihan`
--

INSERT INTO `tagihan` (`id_tagihan`, `kdTagih`, `thTagih`, `blnTagih`, `kdTarif`, `pemakaian`, `status`, `kdPelanggan`, `total`) VALUES
(1, 'TG0001', '2019', '3', '4', '900', 'Belum Lunas', 'PL0006', 1530000),
(2, 'TG0002', '2019', '3', '2', '900', 'Belum Lunas', 'PL0004', 810000),
(3, 'TG0003', '2019', '3', '5', '900', 'Belum Lunas', 'PL0004', 1890000),
(4, 'TG0004', '2019', '3', '2', '900', 'Belum Lunas', 'PL0003', 810000);

-- --------------------------------------------------------

--
-- Table structure for table `tarif`
--

CREATE TABLE IF NOT EXISTS `tarif` (
  `kdTarif` varchar(20) NOT NULL,
  `daya` varchar(35) NOT NULL,
  `tarif_perkwh` varchar(35) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tarif`
--

INSERT INTO `tarif` (`kdTarif`, `daya`, `tarif_perkwh`) VALUES
('1', '450', '400'),
('2', '900', '1200'),
('3', '1300', '1600'),
('4', '2200', '2000'),
('5', '2750', '3100'),
('6', '3450', '3550');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE IF NOT EXISTS `user` (
  `username` varchar(20) NOT NULL,
  `password` varchar(255) NOT NULL,
  `nama` varchar(20) NOT NULL,
  `alamat` varchar(30) NOT NULL,
  `level` varchar(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`username`, `password`, `nama`, `alamat`, `level`) VALUES
('user', 'ee11cbb19052e40b07aac0ca060c23ee', 'Kiko', 'Jl. Karang Tinggal', ''),
('admin', '21232f297a57a5a743894a0e4a801fc3', 'Bilaal', 'Jl. Kasuari', '1'),
('operator', '4b583376b2767b923c3e1da60d10de59', 'Namae', 'Alamat', '2'),
('kiko', 'baa80ec4e76734d710c5084558bc2d5f', 'Nama', 'Alamat', '3'),
('pelanggan', '7f78f06d2d1262a0a222ca9834b15d9d', 'Billal Kunaefi', 'Jl. Kasuari XII', '3'),
('bank', 'bd5af1f610a12434c9128e4a399cef8a', 'Kunaefi', 'Jl. Mahagoni', '4');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `pelanggan`
--
ALTER TABLE `pelanggan`
 ADD PRIMARY KEY (`idPelanggan`);

--
-- Indexes for table `pemakaian`
--
ALTER TABLE `pemakaian`
 ADD PRIMARY KEY (`kd_pemakai`);

--
-- Indexes for table `pembayaran`
--
ALTER TABLE `pembayaran`
 ADD PRIMARY KEY (`id_bayar`);

--
-- Indexes for table `tagihan`
--
ALTER TABLE `tagihan`
 ADD PRIMARY KEY (`id_tagihan`);

--
-- Indexes for table `tarif`
--
ALTER TABLE `tarif`
 ADD PRIMARY KEY (`kdTarif`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `pembayaran`
--
ALTER TABLE `pembayaran`
MODIFY `id_bayar` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=6;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
