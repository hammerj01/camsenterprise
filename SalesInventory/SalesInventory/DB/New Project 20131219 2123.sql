-- MySQL Administrator dump 1.4
--
-- ------------------------------------------------------
-- Server version	5.1.59-community


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


--
-- Create schema dbcams_inventory
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ dbcams_inventory;
USE dbcams_inventory;

--
-- Table structure for table `dbcams_inventory`.`tcategory`
--

DROP TABLE IF EXISTS `tcategory`;
CREATE TABLE `tcategory` (
  `category_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `category_name` varchar(50) NOT NULL,
  PRIMARY KEY (`category_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `dbcams_inventory`.`tcategory`
--

/*!40000 ALTER TABLE `tcategory` DISABLE KEYS */;
/*!40000 ALTER TABLE `tcategory` ENABLE KEYS */;


--
-- Table structure for table `dbcams_inventory`.`tconverted_item`
--

DROP TABLE IF EXISTS `tconverted_item`;
CREATE TABLE `tconverted_item` (
  `converted_item_id` double NOT NULL AUTO_INCREMENT,
  `item_id` double DEFAULT NULL,
  `quantity` int(10) unsigned DEFAULT NULL,
  `date_converted` datetime DEFAULT NULL,
  PRIMARY KEY (`converted_item_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `dbcams_inventory`.`tconverted_item`
--

/*!40000 ALTER TABLE `tconverted_item` DISABLE KEYS */;
/*!40000 ALTER TABLE `tconverted_item` ENABLE KEYS */;


--
-- Table structure for table `dbcams_inventory`.`tcustomers`
--

DROP TABLE IF EXISTS `tcustomers`;
CREATE TABLE `tcustomers` (
  `customers_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `fname` varchar(45) DEFAULT NULL,
  `lname` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`customers_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `dbcams_inventory`.`tcustomers`
--

/*!40000 ALTER TABLE `tcustomers` DISABLE KEYS */;
/*!40000 ALTER TABLE `tcustomers` ENABLE KEYS */;


--
-- Table structure for table `dbcams_inventory`.`tdamage`
--

DROP TABLE IF EXISTS `tdamage`;
CREATE TABLE `tdamage` (
  `damage_id` double NOT NULL AUTO_INCREMENT,
  `item_id` double DEFAULT NULL,
  `quantity` int(10) unsigned DEFAULT NULL,
  `date_damage` datetime DEFAULT NULL,
  `status_damage` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`damage_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `dbcams_inventory`.`tdamage`
--

/*!40000 ALTER TABLE `tdamage` DISABLE KEYS */;
/*!40000 ALTER TABLE `tdamage` ENABLE KEYS */;


--
-- Table structure for table `dbcams_inventory`.`tids`
--

DROP TABLE IF EXISTS `tids`;
CREATE TABLE `tids` (
  `item_id` double NOT NULL,
  `category_id` int(10) unsigned DEFAULT NULL,
  `unit_measure_id` int(10) unsigned DEFAULT NULL,
  PRIMARY KEY (`item_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `dbcams_inventory`.`tids`
--

/*!40000 ALTER TABLE `tids` DISABLE KEYS */;
/*!40000 ALTER TABLE `tids` ENABLE KEYS */;


--
-- Table structure for table `dbcams_inventory`.`titems`
--

DROP TABLE IF EXISTS `titems`;
CREATE TABLE `titems` (
  `item_id` double NOT NULL AUTO_INCREMENT,
  `item_name` varchar(100) DEFAULT NULL,
  `item_description` varchar(100) DEFAULT NULL,
  `item_qty` int(10) unsigned DEFAULT NULL,
  `m_price` double(10,2) DEFAULT NULL,
  `srp_price` double(10,2) DEFAULT NULL,
  `reorder` int(10) unsigned DEFAULT NULL,
  PRIMARY KEY (`item_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `dbcams_inventory`.`titems`
--

/*!40000 ALTER TABLE `titems` DISABLE KEYS */;
/*!40000 ALTER TABLE `titems` ENABLE KEYS */;


--
-- Table structure for table `dbcams_inventory`.`torders`
--

DROP TABLE IF EXISTS `torders`;
CREATE TABLE `torders` (
  `order_id` double NOT NULL AUTO_INCREMENT,
  `item_id` double NOT NULL,
  `quantity` int(10) unsigned NOT NULL,
  `date_order` datetime NOT NULL,
  PRIMARY KEY (`order_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `dbcams_inventory`.`torders`
--

/*!40000 ALTER TABLE `torders` DISABLE KEYS */;
/*!40000 ALTER TABLE `torders` ENABLE KEYS */;


--
-- Table structure for table `dbcams_inventory`.`treturn`
--

DROP TABLE IF EXISTS `treturn`;
CREATE TABLE `treturn` (
  `return_id` double NOT NULL AUTO_INCREMENT,
  `item_id` double DEFAULT NULL,
  `quantity` int(10) unsigned DEFAULT NULL,
  `date_return` datetime DEFAULT NULL,
  `status` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`return_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `dbcams_inventory`.`treturn`
--

/*!40000 ALTER TABLE `treturn` DISABLE KEYS */;
/*!40000 ALTER TABLE `treturn` ENABLE KEYS */;


--
-- Table structure for table `dbcams_inventory`.`tsales`
--

DROP TABLE IF EXISTS `tsales`;
CREATE TABLE `tsales` (
  `sales_id` double NOT NULL AUTO_INCREMENT,
  `item_id` double DEFAULT NULL,
  `qty` int(10) unsigned DEFAULT NULL,
  `price` double(10,2) DEFAULT NULL,
  `date_sold` datetime DEFAULT NULL,
  PRIMARY KEY (`sales_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `dbcams_inventory`.`tsales`
--

/*!40000 ALTER TABLE `tsales` DISABLE KEYS */;
/*!40000 ALTER TABLE `tsales` ENABLE KEYS */;


--
-- Table structure for table `dbcams_inventory`.`tstockin`
--

DROP TABLE IF EXISTS `tstockin`;
CREATE TABLE `tstockin` (
  `stock_id` double NOT NULL AUTO_INCREMENT,
  `item_id` double DEFAULT NULL,
  `quantity` int(10) unsigned DEFAULT NULL,
  `price` double(10,2) DEFAULT NULL,
  `stockin_date` datetime DEFAULT NULL,
  PRIMARY KEY (`stock_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `dbcams_inventory`.`tstockin`
--

/*!40000 ALTER TABLE `tstockin` DISABLE KEYS */;
/*!40000 ALTER TABLE `tstockin` ENABLE KEYS */;


--
-- Table structure for table `dbcams_inventory`.`tsupplier`
--

DROP TABLE IF EXISTS `tsupplier`;
CREATE TABLE `tsupplier` (
  `supplier_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `supplier_name` varchar(50) NOT NULL,
  `address` varchar(100) NOT NULL,
  `contact_no` varchar(45) NOT NULL,
  PRIMARY KEY (`supplier_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `dbcams_inventory`.`tsupplier`
--

/*!40000 ALTER TABLE `tsupplier` DISABLE KEYS */;
/*!40000 ALTER TABLE `tsupplier` ENABLE KEYS */;


--
-- Table structure for table `dbcams_inventory`.`tsuppliers_order`
--

DROP TABLE IF EXISTS `tsuppliers_order`;
CREATE TABLE `tsuppliers_order` (
  `suppliers_order_id` double NOT NULL AUTO_INCREMENT,
  `item_id` double NOT NULL,
  `supplier_id` int(10) unsigned NOT NULL,
  `quantity` int(10) unsigned NOT NULL,
  `order_price` double(10,2) NOT NULL,
  `date_order` datetime NOT NULL,
  PRIMARY KEY (`suppliers_order_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `dbcams_inventory`.`tsuppliers_order`
--

/*!40000 ALTER TABLE `tsuppliers_order` DISABLE KEYS */;
/*!40000 ALTER TABLE `tsuppliers_order` ENABLE KEYS */;


--
-- Table structure for table `dbcams_inventory`.`tunit_measure`
--

DROP TABLE IF EXISTS `tunit_measure`;
CREATE TABLE `tunit_measure` (
  `unit_measure_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `unit_name` varchar(45) DEFAULT NULL,
  `unit_description` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`unit_measure_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `dbcams_inventory`.`tunit_measure`
--

/*!40000 ALTER TABLE `tunit_measure` DISABLE KEYS */;
/*!40000 ALTER TABLE `tunit_measure` ENABLE KEYS */;


--
-- Table structure for table `dbcams_inventory`.`tuser`
--

DROP TABLE IF EXISTS `tuser`;
CREATE TABLE `tuser` (
  `user_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `username` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  `user_type` varchar(45) NOT NULL,
  PRIMARY KEY (`user_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `dbcams_inventory`.`tuser`
--

/*!40000 ALTER TABLE `tuser` DISABLE KEYS */;
/*!40000 ALTER TABLE `tuser` ENABLE KEYS */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
