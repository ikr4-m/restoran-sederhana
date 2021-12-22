-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Dec 22, 2021 at 04:31 AM
-- Server version: 5.7.33
-- PHP Version: 7.4.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `tugas_rpl`
--

-- --------------------------------------------------------

--
-- Table structure for table `list_pesanan`
--

CREATE TABLE `list_pesanan` (
  `id` bigint(20) UNSIGNED NOT NULL,
  `pesanan_id` bigint(20) UNSIGNED NOT NULL,
  `menu_id` bigint(20) UNSIGNED NOT NULL,
  `qty` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `menu`
--

CREATE TABLE `menu` (
  `id` bigint(20) UNSIGNED NOT NULL,
  `nama_menu` varchar(100) NOT NULL,
  `jenis_menu` enum('Makanan','Minuman') NOT NULL,
  `harga` bigint(20) NOT NULL,
  `status_menu` tinyint(1) NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `pesanan`
--

CREATE TABLE `pesanan` (
  `id` bigint(20) UNSIGNED NOT NULL,
  `user_id` bigint(20) UNSIGNED NOT NULL,
  `nama_pemesan` varchar(100) NOT NULL,
  `nomor_meja` int(11) NOT NULL,
  `tanggal_pemesan` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `status_pesanan` enum('Menunggu','Masak','Dikirim','Selesai') NOT NULL DEFAULT 'Menunggu'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `id` bigint(20) UNSIGNED NOT NULL,
  `username` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `role` enum('Admin','Kasir','Waiter','Koki') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Stand-in structure for view `v_receipt`
-- (See below for the actual view)
--
CREATE TABLE `v_receipt` (
`pesananID` bigint(20) unsigned
,`invoiceID` varchar(14)
,`nama` varchar(100)
,`nama_pemesan` varchar(100)
,`nomor_meja` int(11)
,`tanggal_pemesan` datetime
,`liPesanID` bigint(20) unsigned
,`nama_menu` varchar(100)
,`harga` bigint(20)
,`qty` int(11)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `v_report`
-- (See below for the actual view)
--
CREATE TABLE `v_report` (
`tanggal_pemesan` datetime
,`invoiceID` varchar(14)
,`totalQty` decimal(32,0)
,`totalAmount` decimal(51,0)
);

-- --------------------------------------------------------

--
-- Structure for view `v_receipt`
--
DROP TABLE IF EXISTS `v_receipt`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_receipt`  AS SELECT `pesanan`.`id` AS `pesananID`, concat(lpad(`pesanan`.`id`,5,'0'),'/KSR/',year(`pesanan`.`tanggal_pemesan`)) AS `invoiceID`, `user`.`nama` AS `nama`, `pesanan`.`nama_pemesan` AS `nama_pemesan`, `pesanan`.`nomor_meja` AS `nomor_meja`, `pesanan`.`tanggal_pemesan` AS `tanggal_pemesan`, `list_pesanan`.`id` AS `liPesanID`, `menu`.`nama_menu` AS `nama_menu`, `menu`.`harga` AS `harga`, `list_pesanan`.`qty` AS `qty` FROM (((`list_pesanan` join `pesanan` on((`list_pesanan`.`pesanan_id` = `pesanan`.`id`))) join `menu` on((`list_pesanan`.`menu_id` = `menu`.`id`))) join `user` on((`pesanan`.`user_id` = `user`.`id`))) ;

-- --------------------------------------------------------

--
-- Structure for view `v_report`
--
DROP TABLE IF EXISTS `v_report`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_report`  AS SELECT `p`.`tanggal_pemesan` AS `tanggal_pemesan`, concat(lpad(`p`.`id`,5,'0'),'/KSR/',year(`p`.`tanggal_pemesan`)) AS `invoiceID`, sum(`lp`.`qty`) AS `totalQty`, sum((`m`.`harga` * `lp`.`qty`)) AS `totalAmount` FROM ((`pesanan` `p` join `list_pesanan` `lp` on((`lp`.`pesanan_id` = `p`.`id`))) join `menu` `m` on((`m`.`id` = `lp`.`menu_id`))) GROUP BY `lp`.`pesanan_id` ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `list_pesanan`
--
ALTER TABLE `list_pesanan`
  ADD PRIMARY KEY (`id`),
  ADD KEY `list_pesanan_FK` (`pesanan_id`),
  ADD KEY `list_pesanan_FK_1` (`menu_id`);

--
-- Indexes for table `menu`
--
ALTER TABLE `menu`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `pesanan`
--
ALTER TABLE `pesanan`
  ADD PRIMARY KEY (`id`),
  ADD KEY `pesanan_FK` (`user_id`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `list_pesanan`
--
ALTER TABLE `list_pesanan`
  MODIFY `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `menu`
--
ALTER TABLE `menu`
  MODIFY `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `pesanan`
--
ALTER TABLE `pesanan`
  MODIFY `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `list_pesanan`
--
ALTER TABLE `list_pesanan`
  ADD CONSTRAINT `list_pesanan_FK` FOREIGN KEY (`pesanan_id`) REFERENCES `pesanan` (`id`),
  ADD CONSTRAINT `list_pesanan_FK_1` FOREIGN KEY (`menu_id`) REFERENCES `menu` (`id`);

--
-- Constraints for table `pesanan`
--
ALTER TABLE `pesanan`
  ADD CONSTRAINT `pesanan_FK` FOREIGN KEY (`user_id`) REFERENCES `user` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
