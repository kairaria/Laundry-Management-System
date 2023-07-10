CREATE DATABASE  IF NOT EXISTS `gaillard_woms` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci */;
USE `gaillard_woms`;
-- MySQL dump 10.13  Distrib 8.0.20, for Win64 (x86_64)
--
-- Host: localhost    Database: gaillard_woms
-- ------------------------------------------------------
-- Server version	5.7.30-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `customer`
--

DROP TABLE IF EXISTS `customer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customer` (
  `custID` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `phone` varchar(13) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `valid` tinyint(1) unsigned NOT NULL DEFAULT '1',
  `datecreated` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `datemodified` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`custID`),
  UNIQUE KEY `phone` (`phone`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer`
--

LOCK TABLES `customer` WRITE;
/*!40000 ALTER TABLE `customer` DISABLE KEYS */;
INSERT INTO `customer` VALUES (1,'Kennedy Kairaria','0724615232',1,'2023-04-24 20:20:22','2023-04-24 20:20:22'),(2,'Joycarol Wanjiru','0724643788',1,'2023-04-25 19:30:15','2023-04-25 19:30:15'),(3,'Bianca Mwendwa','',1,'2023-04-25 20:02:28','2023-04-25 20:02:28'),(4,'Felix Gitonga','0722322684',1,'2023-05-13 10:00:17','2023-05-13 10:00:17'),(5,'Test Customer','0722123456',1,'2023-06-04 18:42:30','2023-06-04 18:42:30');
/*!40000 ALTER TABLE `customer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `expense_made`
--

DROP TABLE IF EXISTS `expense_made`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `expense_made` (
  `expid` int(11) NOT NULL AUTO_INCREMENT,
  `description` longtext COLLATE utf8mb4_unicode_ci NOT NULL,
  `mode` varchar(6) COLLATE utf8mb4_unicode_ci NOT NULL DEFAULT '',
  `reference` varchar(20) COLLATE utf8mb4_unicode_ci DEFAULT '',
  `amount` decimal(20,6) NOT NULL,
  `valid` tinyint(1) unsigned NOT NULL DEFAULT '1',
  `datecreated` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `datemodified` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`expid`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `expense_made`
--

LOCK TABLES `expense_made` WRITE;
/*!40000 ALTER TABLE `expense_made` DISABLE KEYS */;
INSERT INTO `expense_made` VALUES (1,'Test','Cash','',10.000000,1,'2023-05-26 06:47:48','2023-05-26 06:47:48');
/*!40000 ALTER TABLE `expense_made` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `invoice`
--

DROP TABLE IF EXISTS `invoice`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `invoice` (
  `invoiceId` int(11) NOT NULL AUTO_INCREMENT,
  `workorderId` int(11) NOT NULL,
  `customerid` int(11) NOT NULL,
  `invoice_no` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `amount` decimal(20,6) NOT NULL DEFAULT '0.000000',
  `valid` tinyint(1) unsigned NOT NULL DEFAULT '1',
  `datecreated` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `datemodified` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`invoiceId`),
  KEY `invoice_workorderid_FK` (`workorderId`),
  KEY `invoice_custid_FK` (`customerid`) USING BTREE,
  CONSTRAINT `invoice_customerid_FK` FOREIGN KEY (`customerid`) REFERENCES `customer` (`custID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `invoice_workorderid_FK` FOREIGN KEY (`workorderId`) REFERENCES `workorder` (`workorderId`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `invoice`
--

LOCK TABLES `invoice` WRITE;
/*!40000 ALTER TABLE `invoice` DISABLE KEYS */;
/*!40000 ALTER TABLE `invoice` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `payment_received`
--

DROP TABLE IF EXISTS `payment_received`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `payment_received` (
  `payId` int(11) NOT NULL AUTO_INCREMENT,
  `workorderid` int(11) NOT NULL,
  `mode` varchar(6) COLLATE utf8mb4_unicode_ci NOT NULL,
  `reference` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `amount` double NOT NULL DEFAULT '0',
  `invoice_no` varchar(20) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `comments` varchar(254) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `valid` tinyint(1) unsigned NOT NULL DEFAULT '1',
  `datecreated` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `datemodified` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`payId`),
  KEY `payment_workorderid_FK` (`workorderid`),
  CONSTRAINT `payment_workorderid_FK` FOREIGN KEY (`workorderid`) REFERENCES `workorder` (`workorderId`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `payment_received`
--

LOCK TABLES `payment_received` WRITE;
/*!40000 ALTER TABLE `payment_received` DISABLE KEYS */;
INSERT INTO `payment_received` VALUES (1,12,'Cash','',1000,'',NULL,1,'2023-05-03 20:08:45','2023-05-03 20:08:45'),(2,13,'Cash','',200,'',NULL,1,'2023-05-13 10:10:44','2023-05-13 10:10:44'),(3,13,'M-Pesa','ASDFG',50,'',NULL,1,'2023-05-13 10:11:29','2023-05-13 10:11:29'),(4,13,'Cash','',100,'',NULL,1,'2023-05-13 12:20:57','2023-05-13 12:20:57'),(5,14,'Cash','',100,'',NULL,1,'2023-05-13 13:49:20','2023-05-13 13:49:20'),(6,14,'M-Pesa','DRTYUIOJKL',250,'',NULL,1,'2023-05-13 13:50:01','2023-05-13 13:50:01'),(7,14,'Cash','DRTYUIOJKL',300,'',NULL,1,'2023-05-13 13:50:53','2023-05-13 13:50:53'),(8,18,'M-Pesa','XYZ',225,'',NULL,1,'2023-05-26 02:01:40','2023-05-26 02:01:40'),(9,19,'Cash','',150,'',NULL,1,'2023-05-26 02:06:33','2023-05-26 02:06:33'),(10,23,'Cash','',120,'',NULL,1,'2023-05-26 03:53:11','2023-05-26 03:53:11'),(11,23,'Cash','',105,'',NULL,1,'2023-05-26 03:53:28','2023-05-26 03:53:28'),(12,24,'Cash','',200,'',NULL,1,'2023-05-26 03:57:30','2023-05-26 03:57:30'),(13,24,'Cash','',175,'',NULL,1,'2023-05-26 03:57:36','2023-05-26 03:57:36'),(14,22,'Cash','',270,'',NULL,1,'2023-05-26 06:44:21','2023-05-26 06:44:21'),(15,22,'Cash','',5,'',NULL,1,'2023-05-26 06:44:47','2023-05-26 06:44:47'),(16,25,'Cash','',150,'',NULL,1,'2023-06-04 18:43:41','2023-06-04 18:43:41'),(17,25,'Cash','',100,'',NULL,1,'2023-06-04 18:44:32','2023-06-04 18:44:32');
/*!40000 ALTER TABLE `payment_received` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `serviceitem`
--

DROP TABLE IF EXISTS `serviceitem`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `serviceitem` (
  `serviceItemID` int(11) NOT NULL AUTO_INCREMENT,
  `serviceitemName` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `price` double NOT NULL DEFAULT '0',
  `valid` int(1) NOT NULL DEFAULT '1',
  `datecreated` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `datemodified` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`serviceItemID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `serviceitem`
--

LOCK TABLES `serviceitem` WRITE;
/*!40000 ALTER TABLE `serviceitem` DISABLE KEYS */;
INSERT INTO `serviceitem` VALUES (1,'General Laundry By KG',100,1,'2023-04-24 23:33:07','2023-04-24 23:33:07'),(2,'General Laundry By Bucket',150,1,'2023-04-24 23:33:07','2023-04-24 23:33:07');
/*!40000 ALTER TABLE `serviceitem` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `workorder`
--

DROP TABLE IF EXISTS `workorder`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `workorder` (
  `workorderId` int(11) NOT NULL AUTO_INCREMENT,
  `customerId` int(11) NOT NULL,
  `valid` tinyint(1) unsigned NOT NULL DEFAULT '1',
  `datecreated` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `datemodified` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `datecollected` timestamp NULL DEFAULT NULL,
  PRIMARY KEY (`workorderId`),
  KEY `workorder_customerId_FK` (`customerId`),
  CONSTRAINT `workorder_customerId_FK` FOREIGN KEY (`customerId`) REFERENCES `customer` (`custID`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `workorder`
--

LOCK TABLES `workorder` WRITE;
/*!40000 ALTER TABLE `workorder` DISABLE KEYS */;
INSERT INTO `workorder` VALUES (1,2,0,'2023-04-25 19:30:47','2023-04-29 19:50:12',NULL),(2,1,0,'2023-04-25 19:48:55','2023-04-29 19:50:54',NULL),(3,1,1,'2023-04-29 20:39:10','2023-04-29 20:39:10',NULL),(4,1,1,'2023-04-29 20:58:37','2023-04-29 20:58:37',NULL),(5,1,1,'2023-05-01 05:08:49','2023-05-01 05:08:49',NULL),(6,1,1,'2023-05-01 05:52:41','2023-05-01 05:52:41',NULL),(7,1,0,'2023-05-01 06:01:32','2023-05-01 06:15:03',NULL),(8,1,1,'2023-05-01 06:13:19','2023-05-01 06:13:19',NULL),(9,1,1,'2023-05-01 06:15:44','2023-05-01 06:15:44',NULL),(10,1,1,'2023-05-01 06:24:21','2023-05-01 06:24:21',NULL),(11,1,1,'2023-05-01 07:27:25','2023-05-01 07:27:25',NULL),(12,2,1,'2023-05-03 19:29:48','2023-05-03 19:29:48',NULL),(13,4,1,'2023-05-13 10:00:36','2023-05-13 10:00:36',NULL),(14,1,1,'2023-05-13 13:46:39','2023-05-13 13:46:39',NULL),(15,1,1,'2023-05-26 01:27:36','2023-05-26 01:27:36',NULL),(16,3,1,'2023-05-26 01:49:15','2023-05-26 01:49:15',NULL),(17,4,1,'2023-05-26 01:57:04','2023-05-26 01:57:04',NULL),(18,4,1,'2023-05-26 02:00:37','2023-05-26 02:00:37',NULL),(19,4,1,'2023-05-26 02:05:52','2023-05-26 02:05:52',NULL),(20,2,1,'2023-05-26 03:10:43','2023-05-26 03:10:43',NULL),(21,2,1,'2023-05-26 03:13:05','2023-05-26 03:13:05',NULL),(22,1,0,'2023-05-26 03:48:29','2023-05-26 06:45:01','2023-05-26 06:45:01'),(23,2,1,'2023-05-26 03:52:43','2023-05-26 03:52:43',NULL),(24,1,0,'2023-05-26 03:56:51','2023-05-26 06:43:30','2023-05-26 06:43:30'),(25,5,0,'2023-06-04 18:42:44','2023-06-04 18:45:01','2023-06-04 18:45:01');
/*!40000 ALTER TABLE `workorder` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `workorderitem`
--

DROP TABLE IF EXISTS `workorderitem`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `workorderitem` (
  `workorderitemId` int(11) NOT NULL AUTO_INCREMENT,
  `workorderId` int(11) NOT NULL,
  `serviceitemID` int(11) NOT NULL DEFAULT '0',
  `quantity` int(11) NOT NULL,
  `charge` double NOT NULL,
  `comments` longtext COLLATE utf8mb4_unicode_ci,
  `colour` int(8) NOT NULL DEFAULT '0',
  `valid` tinyint(1) unsigned NOT NULL DEFAULT '1',
  `datecreated` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `datemodified` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `datecollected` timestamp NULL DEFAULT NULL,
  `servicechargefactor` int(1) unsigned DEFAULT '1',
  PRIMARY KEY (`workorderitemId`),
  KEY `workorderitem_workorderId_FK` (`workorderId`),
  KEY `workorderitem_serviceitemId_FK` (`serviceitemID`),
  CONSTRAINT `workorderitem_serviceitemId_FK` FOREIGN KEY (`serviceitemID`) REFERENCES `serviceitem` (`serviceItemID`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `workorderitem_workorderId_FK` FOREIGN KEY (`workorderId`) REFERENCES `workorder` (`workorderId`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=60 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `workorderitem`
--

LOCK TABLES `workorderitem` WRITE;
/*!40000 ALTER TABLE `workorderitem` DISABLE KEYS */;
INSERT INTO `workorderitem` VALUES (2,4,2,2,300,'Test 1',-1,1,'2023-04-29 20:58:37','2023-04-29 20:58:37',NULL,1),(3,5,2,1,150,'Test 1',-16777216,1,'2023-05-01 05:08:52','2023-05-01 05:08:52',NULL,1),(4,5,1,2,200,'Test 1',-16711681,1,'2023-05-01 05:09:29','2023-05-01 05:09:29',NULL,1),(5,6,2,1,150,'',-1,1,'2023-05-01 05:52:41','2023-05-01 05:52:41',NULL,1),(6,6,1,2,200,'',-16777216,1,'2023-05-01 05:53:01','2023-05-01 05:53:01',NULL,1),(7,7,2,3,450,'Test 1',-1,1,'2023-05-01 06:01:32','2023-05-01 06:01:32',NULL,1),(8,7,1,4,400,'Test 1',-16777216,1,'2023-05-01 06:02:28','2023-05-01 06:02:28',NULL,1),(9,8,2,2,300,'',-16711681,1,'2023-05-01 06:13:19','2023-05-01 06:13:19',NULL,1),(10,8,1,1,100,'',-16744384,1,'2023-05-01 06:14:01','2023-05-01 06:14:01',NULL,1),(11,9,2,3,450,'',-16711681,1,'2023-05-01 06:15:44','2023-05-01 06:15:44',NULL,1),(12,9,1,3,300,'',-16760768,1,'2023-05-01 06:16:13','2023-05-01 06:16:13',NULL,1),(13,10,1,6,600,'',-65536,1,'2023-05-01 06:24:21','2023-05-01 06:27:09',NULL,1),(14,10,2,4,600,'',-16711872,1,'2023-05-01 06:24:37','2023-05-01 06:28:10',NULL,1),(15,10,2,1,150,'',-256,1,'2023-05-01 06:27:41','2023-05-01 06:27:41',NULL,1),(16,11,2,5,750,'',-16711808,1,'2023-05-01 07:27:25','2023-05-03 19:51:14',NULL,1),(17,12,2,1,150,'Test 1',-16711936,1,'2023-05-03 19:29:48','2023-05-03 19:29:48',NULL,1),(18,12,1,4,400,'',-8355840,1,'2023-05-03 19:30:08','2023-05-03 19:30:08',NULL,1),(19,13,2,1,150,'',-1,1,'2023-05-13 10:00:36','2023-05-13 10:00:36',NULL,1),(20,13,1,2,200,'',-16777216,1,'2023-05-13 10:07:03','2023-05-13 10:07:03',NULL,1),(21,14,2,3,450,'Requires repair. Missing Button',-5656697,1,'2023-05-13 13:46:39','2023-05-13 13:47:46',NULL,1),(22,14,1,2,200,'test',-4144960,0,'2023-05-13 13:47:09','2023-05-13 13:48:00',NULL,1),(23,15,2,2,300,'Test',-1,1,'2023-05-26 01:27:36','2023-05-26 02:07:19',NULL,1),(24,15,2,3,225,'Test Press',-1,1,'2023-05-26 01:27:56','2023-05-26 02:07:49',NULL,1),(25,15,2,1,0,'Test Repeat',-1,1,'2023-05-26 01:28:19','2023-05-26 01:28:19',NULL,1),(26,16,2,1,150,'',-1,1,'2023-05-26 01:49:15','2023-05-26 01:49:15',NULL,1),(27,16,2,1,75,'',-1,1,'2023-05-26 01:49:21','2023-05-26 01:49:21',NULL,1),(28,16,2,1,0,'',-1,1,'2023-05-26 01:49:28','2023-05-26 01:49:28',NULL,1),(29,17,2,1,150,'',-1,1,'2023-05-26 01:57:04','2023-05-26 01:57:04',NULL,1),(30,17,2,1,75,'',-1,1,'2023-05-26 01:57:10','2023-05-26 01:57:10',NULL,1),(31,17,2,1,0,' Repeat Regular Service for an item from WorkOrder: 1',-1,1,'2023-05-26 01:57:21','2023-05-26 01:57:21',NULL,1),(32,18,2,1,150,'',-1,1,'2023-05-26 02:00:37','2023-05-26 02:00:37',NULL,1),(33,18,2,1,75,'',-1,1,'2023-05-26 02:00:44','2023-05-26 02:00:44',NULL,1),(34,18,2,1,0,' Repeat Regular Service for an item from WorkOrder: ',-1,1,'2023-05-26 02:00:50','2023-05-26 02:00:50',NULL,1),(35,18,2,1,0,' Repeat Press for an item from WorkOrder: ',-1,1,'2023-05-26 02:00:58','2023-05-26 02:00:58',NULL,1),(36,19,2,1,150,'',-1,1,'2023-05-26 02:05:52','2023-05-26 02:05:52',NULL,1),(37,19,2,1,0,' Repeat Press for an item from WorkOrder: 1',-1,1,'2023-05-26 02:06:01','2023-05-26 02:06:01',NULL,1),(38,20,2,1,150,'',-1,1,'2023-05-26 03:10:43','2023-05-26 03:10:43',NULL,1),(39,20,2,1,0,'',-1,1,'2023-05-26 03:10:48','2023-05-26 03:10:48',NULL,2),(40,20,2,1,0,'',-1,1,'2023-05-26 03:11:01','2023-05-26 03:11:01',NULL,2),(41,20,2,1,0,' Repeat Regular Service for an item from WorkOrder: ',-1,1,'2023-05-26 03:11:11','2023-05-26 03:11:11',NULL,3),(42,20,2,1,0,' Repeat Press for an item from WorkOrder: ',-1,1,'2023-05-26 03:11:19','2023-05-26 03:11:19',NULL,4),(43,21,1,1,100,'',-1,1,'2023-05-26 03:13:05','2023-05-26 03:13:05',NULL,1),(44,21,2,1,75,'',-1,1,'2023-05-26 03:43:27','2023-05-26 03:43:27',NULL,2),(45,21,1,1,50,'',-1,1,'2023-05-26 03:43:37','2023-05-26 03:43:37',NULL,2),(46,22,2,1,150,'',-1,1,'2023-05-26 03:48:29','2023-05-26 03:48:29',NULL,1),(47,22,2,1,75,'',-1,1,'2023-05-26 03:48:34','2023-05-26 03:48:34',NULL,2),(48,22,1,1,50,'',-1,1,'2023-05-26 03:48:39','2023-05-26 03:48:39',NULL,2),(49,22,2,1,0,' Repeat Regular Service for an item from WorkOrder: ',-1,1,'2023-05-26 03:48:43','2023-05-26 03:48:43',NULL,3),(50,22,1,1,0,' Repeat Press for an item from WorkOrder: ',-1,1,'2023-05-26 03:48:49','2023-05-26 03:48:49',NULL,4),(51,23,2,1,150,'',-1,1,'2023-05-26 03:52:43','2023-05-26 03:52:43',NULL,1),(52,23,2,1,75,'',-1,1,'2023-05-26 03:52:48','2023-05-26 03:52:48',NULL,2),(53,24,2,1,150,'',-1,1,'2023-05-26 03:56:51','2023-05-26 03:56:51',NULL,1),(54,24,1,1,100,'',-1,1,'2023-05-26 03:56:56','2023-05-26 03:56:56',NULL,1),(55,24,2,1,75,'',-1,1,'2023-05-26 03:57:01','2023-05-26 03:57:01',NULL,2),(56,24,1,1,50,'',-1,1,'2023-05-26 03:57:06','2023-05-26 03:57:06',NULL,2),(57,24,2,1,0,' Repeat Regular Service for an item from WorkOrder: ',-1,1,'2023-05-26 03:57:11','2023-05-26 03:57:11',NULL,3),(58,25,2,1,150,'',-1,1,'2023-06-04 18:42:44','2023-06-04 18:42:44',NULL,1),(59,25,1,1,50,'',-1,1,'2023-06-04 18:43:03','2023-06-04 18:43:03',NULL,2);
/*!40000 ALTER TABLE `workorderitem` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'gaillard_woms'
--

--
-- Dumping routines for database 'gaillard_woms'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-07-10 14:41:45
