# MySQL-Front 3.2  (Build 6.11)

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES 'latin1' */;

# Host: localhost    Database: restaurant_billing
# ------------------------------------------------------
# Server version 5.1.49-community

#
# Table structure for table billing
#

DROP TABLE IF EXISTS `billing`;
CREATE TABLE `billing` (
  `BillNo` bigint(20) NOT NULL AUTO_INCREMENT,
  `Dte` datetime DEFAULT NULL,
  `BillType` varchar(15) DEFAULT NULL,
  `NOP` int(4) DEFAULT NULL,
  `TableNo` varchar(15) DEFAULT NULL,
  `TableType` varchar(15) DEFAULT NULL,
  `WaiterCode` bigint(20) DEFAULT NULL,
  `WaiterName` varchar(30) DEFAULT NULL,
  `Guest` varchar(40) DEFAULT NULL,
  `Mobile` bigint(13) DEFAULT NULL,
  `SubTotal` decimal(10,2) DEFAULT NULL,
  `Qtys` int(5) DEFAULT NULL,
  `DisType` tinyint(4) DEFAULT NULL,
  `Dis` decimal(10,2) DEFAULT NULL,
  `SGST` decimal(10,2) DEFAULT NULL,
  `CGST` decimal(10,2) DEFAULT NULL,
  `sCharge` decimal(8,2) DEFAULT NULL,
  `Total` decimal(12,2) NOT NULL DEFAULT '0.00',
  `PayMode` varchar(20) DEFAULT NULL,
  `Paid` decimal(10,2) DEFAULT NULL,
  `Balance` decimal(10,2) DEFAULT NULL,
  `Received` tinyint(3) NOT NULL DEFAULT '1',
  PRIMARY KEY (`BillNo`)
) ENGINE=InnoDB AUTO_INCREMENT=32 DEFAULT CHARSET=latin1;

#
# Dumping data for table billing
#

INSERT INTO `billing` (`BillNo`,`Dte`,`BillType`,`NOP`,`TableNo`,`TableType`,`WaiterCode`,`WaiterName`,`Guest`,`Mobile`,`SubTotal`,`Qtys`,`DisType`,`Dis`,`SGST`,`CGST`,`sCharge`,`Total`,`PayMode`,`Paid`,`Balance`,`Received`) VALUES (1,'2021-03-17 11:55:19','Take Away',NULL,'','',NULL,'','',NULL,5510,110,0,0,275.5,275.5,0,0,'Cash',7000,939,1);
INSERT INTO `billing` (`BillNo`,`Dte`,`BillType`,`NOP`,`TableNo`,`TableType`,`WaiterCode`,`WaiterName`,`Guest`,`Mobile`,`SubTotal`,`Qtys`,`DisType`,`Dis`,`SGST`,`CGST`,`sCharge`,`Total`,`PayMode`,`Paid`,`Balance`,`Received`) VALUES (2,'2021-03-17 11:56:14','Dine In',NULL,'Table-7','General',10,'Ashar','',NULL,5510,110,0,0,275.5,275.5,0,0,'Cash',7000,939,1);
INSERT INTO `billing` (`BillNo`,`Dte`,`BillType`,`NOP`,`TableNo`,`TableType`,`WaiterCode`,`WaiterName`,`Guest`,`Mobile`,`SubTotal`,`Qtys`,`DisType`,`Dis`,`SGST`,`CGST`,`sCharge`,`Total`,`PayMode`,`Paid`,`Balance`,`Received`) VALUES (3,'2021-03-17 11:57:39','Take Away',NULL,'','',NULL,'','',NULL,130,2,0,0,6.5,6.5,0,0,'Cash',150,7,1);
INSERT INTO `billing` (`BillNo`,`Dte`,`BillType`,`NOP`,`TableNo`,`TableType`,`WaiterCode`,`WaiterName`,`Guest`,`Mobile`,`SubTotal`,`Qtys`,`DisType`,`Dis`,`SGST`,`CGST`,`sCharge`,`Total`,`PayMode`,`Paid`,`Balance`,`Received`) VALUES (4,'2021-03-17 11:59:02','Dine In',NULL,'Table-4','General',10,'Ashar','',NULL,130,2,0,0,6.5,6.5,0,0,'Cash',150,7,1);
INSERT INTO `billing` (`BillNo`,`Dte`,`BillType`,`NOP`,`TableNo`,`TableType`,`WaiterCode`,`WaiterName`,`Guest`,`Mobile`,`SubTotal`,`Qtys`,`DisType`,`Dis`,`SGST`,`CGST`,`sCharge`,`Total`,`PayMode`,`Paid`,`Balance`,`Received`) VALUES (5,'2021-03-18 12:00:52','Take Away',NULL,'','',NULL,'','',NULL,250,4,0,0,12.5,12.5,0,0,'Cash',1253,978,1);
INSERT INTO `billing` (`BillNo`,`Dte`,`BillType`,`NOP`,`TableNo`,`TableType`,`WaiterCode`,`WaiterName`,`Guest`,`Mobile`,`SubTotal`,`Qtys`,`DisType`,`Dis`,`SGST`,`CGST`,`sCharge`,`Total`,`PayMode`,`Paid`,`Balance`,`Received`) VALUES (6,'2021-03-18 12:01:38','Take Away',NULL,'','',NULL,'','',NULL,180,3,0,0,9,9,0,0,'Cash',122,-76,1);
INSERT INTO `billing` (`BillNo`,`Dte`,`BillType`,`NOP`,`TableNo`,`TableType`,`WaiterCode`,`WaiterName`,`Guest`,`Mobile`,`SubTotal`,`Qtys`,`DisType`,`Dis`,`SGST`,`CGST`,`sCharge`,`Total`,`PayMode`,`Paid`,`Balance`,`Received`) VALUES (7,'2021-03-18 12:01:49','Dine In',NULL,'Table-3','General',10,'Ashar','',NULL,900,19,0,0,45,45,0,0,'Cash',1000,10,1);
INSERT INTO `billing` (`BillNo`,`Dte`,`BillType`,`NOP`,`TableNo`,`TableType`,`WaiterCode`,`WaiterName`,`Guest`,`Mobile`,`SubTotal`,`Qtys`,`DisType`,`Dis`,`SGST`,`CGST`,`sCharge`,`Total`,`PayMode`,`Paid`,`Balance`,`Received`) VALUES (8,'2021-03-18 01:21:16','Dine In',NULL,'Table-2','A/C Room',8,'Velan','',NULL,120,2,0,0,6,6,12,0,'UPI',0,-144,1);
INSERT INTO `billing` (`BillNo`,`Dte`,`BillType`,`NOP`,`TableNo`,`TableType`,`WaiterCode`,`WaiterName`,`Guest`,`Mobile`,`SubTotal`,`Qtys`,`DisType`,`Dis`,`SGST`,`CGST`,`sCharge`,`Total`,`PayMode`,`Paid`,`Balance`,`Received`) VALUES (9,'2021-03-18 01:23:31','Dine In',NULL,'Table-2','A/C Room',8,'Velan','',NULL,320,5,0,0,16,16,32,0,'UPI',0,0,1);
INSERT INTO `billing` (`BillNo`,`Dte`,`BillType`,`NOP`,`TableNo`,`TableType`,`WaiterCode`,`WaiterName`,`Guest`,`Mobile`,`SubTotal`,`Qtys`,`DisType`,`Dis`,`SGST`,`CGST`,`sCharge`,`Total`,`PayMode`,`Paid`,`Balance`,`Received`) VALUES (10,'2021-03-18 01:24:43','Home Delivery',NULL,'','',NULL,'','',NULL,140,3,0,0,7,7,14,0,'Credit Card',0,0,1);
INSERT INTO `billing` (`BillNo`,`Dte`,`BillType`,`NOP`,`TableNo`,`TableType`,`WaiterCode`,`WaiterName`,`Guest`,`Mobile`,`SubTotal`,`Qtys`,`DisType`,`Dis`,`SGST`,`CGST`,`sCharge`,`Total`,`PayMode`,`Paid`,`Balance`,`Received`) VALUES (11,'2021-03-18 01:25:38','Take Away',NULL,'','',NULL,'','',NULL,240,4,1,10,12,12,24,0,'Debit Card',0,0,0);
INSERT INTO `billing` (`BillNo`,`Dte`,`BillType`,`NOP`,`TableNo`,`TableType`,`WaiterCode`,`WaiterName`,`Guest`,`Mobile`,`SubTotal`,`Qtys`,`DisType`,`Dis`,`SGST`,`CGST`,`sCharge`,`Total`,`PayMode`,`Paid`,`Balance`,`Received`) VALUES (12,'2021-03-18 01:29:36','Dine In',NULL,'Table-1','General',9,'Arsath','Arsath',789456123,300,6,0,0,15,15,0,0,'Cash',500,170,0);
INSERT INTO `billing` (`BillNo`,`Dte`,`BillType`,`NOP`,`TableNo`,`TableType`,`WaiterCode`,`WaiterName`,`Guest`,`Mobile`,`SubTotal`,`Qtys`,`DisType`,`Dis`,`SGST`,`CGST`,`sCharge`,`Total`,`PayMode`,`Paid`,`Balance`,`Received`) VALUES (13,'2021-03-18 01:32:10','Dine In',NULL,'Table-2','A/C Room',8,'Velan','velan',79544054,680,11,0,0,34,34,0,748,'Cash',1000,252,0);
INSERT INTO `billing` (`BillNo`,`Dte`,`BillType`,`NOP`,`TableNo`,`TableType`,`WaiterCode`,`WaiterName`,`Guest`,`Mobile`,`SubTotal`,`Qtys`,`DisType`,`Dis`,`SGST`,`CGST`,`sCharge`,`Total`,`PayMode`,`Paid`,`Balance`,`Received`) VALUES (14,'2021-03-18 01:34:51','Take Away',NULL,'','',NULL,'','',NULL,190,4,0,0,9.5,9.5,19,228,'Credit Card',0,0,0);
INSERT INTO `billing` (`BillNo`,`Dte`,`BillType`,`NOP`,`TableNo`,`TableType`,`WaiterCode`,`WaiterName`,`Guest`,`Mobile`,`SubTotal`,`Qtys`,`DisType`,`Dis`,`SGST`,`CGST`,`sCharge`,`Total`,`PayMode`,`Paid`,`Balance`,`Received`) VALUES (15,'2021-03-18 01:37:19','Take Away',NULL,'','',NULL,'','',NULL,190,3,0,0,9.5,9.5,19,228,'Credit Card',0,-228,1);
INSERT INTO `billing` (`BillNo`,`Dte`,`BillType`,`NOP`,`TableNo`,`TableType`,`WaiterCode`,`WaiterName`,`Guest`,`Mobile`,`SubTotal`,`Qtys`,`DisType`,`Dis`,`SGST`,`CGST`,`sCharge`,`Total`,`PayMode`,`Paid`,`Balance`,`Received`) VALUES (16,'2021-03-18 01:38:09','Take Away',NULL,'','',NULL,'','',NULL,220,3,0,0,11,11,22,264,'UPI',0,0,1);
INSERT INTO `billing` (`BillNo`,`Dte`,`BillType`,`NOP`,`TableNo`,`TableType`,`WaiterCode`,`WaiterName`,`Guest`,`Mobile`,`SubTotal`,`Qtys`,`DisType`,`Dis`,`SGST`,`CGST`,`sCharge`,`Total`,`PayMode`,`Paid`,`Balance`,`Received`) VALUES (17,'2021-03-18 01:38:46','Take Away',NULL,'','',NULL,'','',NULL,190,3,0,0,9.5,9.5,19,228,'Credit Card',0,0,1);
INSERT INTO `billing` (`BillNo`,`Dte`,`BillType`,`NOP`,`TableNo`,`TableType`,`WaiterCode`,`WaiterName`,`Guest`,`Mobile`,`SubTotal`,`Qtys`,`DisType`,`Dis`,`SGST`,`CGST`,`sCharge`,`Total`,`PayMode`,`Paid`,`Balance`,`Received`) VALUES (18,'2021-03-18 01:39:40','Home Delivery',NULL,'','',NULL,'','',NULL,190,4,0,0,9.5,9.5,19,228,'UPI',0,0,1);
INSERT INTO `billing` (`BillNo`,`Dte`,`BillType`,`NOP`,`TableNo`,`TableType`,`WaiterCode`,`WaiterName`,`Guest`,`Mobile`,`SubTotal`,`Qtys`,`DisType`,`Dis`,`SGST`,`CGST`,`sCharge`,`Total`,`PayMode`,`Paid`,`Balance`,`Received`) VALUES (19,'2021-03-18 01:41:17','Take Away',NULL,'','',NULL,'','',NULL,180,3,0,0,9,9,18,216,'UPI',0,0,1);
INSERT INTO `billing` (`BillNo`,`Dte`,`BillType`,`NOP`,`TableNo`,`TableType`,`WaiterCode`,`WaiterName`,`Guest`,`Mobile`,`SubTotal`,`Qtys`,`DisType`,`Dis`,`SGST`,`CGST`,`sCharge`,`Total`,`PayMode`,`Paid`,`Balance`,`Received`) VALUES (20,'2021-03-18 01:41:51','Dine In',NULL,'Table-1','General',10,'Ashar','',NULL,670,10,0,0,33.5,33.5,67,804,'UPI',0,0,1);
INSERT INTO `billing` (`BillNo`,`Dte`,`BillType`,`NOP`,`TableNo`,`TableType`,`WaiterCode`,`WaiterName`,`Guest`,`Mobile`,`SubTotal`,`Qtys`,`DisType`,`Dis`,`SGST`,`CGST`,`sCharge`,`Total`,`PayMode`,`Paid`,`Balance`,`Received`) VALUES (21,'2021-03-18 01:42:56','Dine In',NULL,'Table-2','A/C Room',7,'Chandru','',NULL,410,6,0,0,20.5,20.5,41,492,'UPI',0,0,1);
INSERT INTO `billing` (`BillNo`,`Dte`,`BillType`,`NOP`,`TableNo`,`TableType`,`WaiterCode`,`WaiterName`,`Guest`,`Mobile`,`SubTotal`,`Qtys`,`DisType`,`Dis`,`SGST`,`CGST`,`sCharge`,`Total`,`PayMode`,`Paid`,`Balance`,`Received`) VALUES (22,'2021-03-18 01:44:04','Take Away',NULL,'','',NULL,'','',NULL,200,3,0,0,10,10,0,220,'Cash',300,80,1);
INSERT INTO `billing` (`BillNo`,`Dte`,`BillType`,`NOP`,`TableNo`,`TableType`,`WaiterCode`,`WaiterName`,`Guest`,`Mobile`,`SubTotal`,`Qtys`,`DisType`,`Dis`,`SGST`,`CGST`,`sCharge`,`Total`,`PayMode`,`Paid`,`Balance`,`Received`) VALUES (23,'2021-03-18 01:45:12','Take Away',NULL,'','',NULL,'','',NULL,270,4,0,0,13.5,13.5,0,297,'Cash',0,-297,0);
INSERT INTO `billing` (`BillNo`,`Dte`,`BillType`,`NOP`,`TableNo`,`TableType`,`WaiterCode`,`WaiterName`,`Guest`,`Mobile`,`SubTotal`,`Qtys`,`DisType`,`Dis`,`SGST`,`CGST`,`sCharge`,`Total`,`PayMode`,`Paid`,`Balance`,`Received`) VALUES (24,'2021-03-18 01:47:43','Take Away',NULL,'','',NULL,'','',NULL,170,3,0,0,8.5,8.5,17,204,'Credit Card',0,0,0);
INSERT INTO `billing` (`BillNo`,`Dte`,`BillType`,`NOP`,`TableNo`,`TableType`,`WaiterCode`,`WaiterName`,`Guest`,`Mobile`,`SubTotal`,`Qtys`,`DisType`,`Dis`,`SGST`,`CGST`,`sCharge`,`Total`,`PayMode`,`Paid`,`Balance`,`Received`) VALUES (25,'2021-03-18 01:48:34','Take Away',NULL,'','',NULL,'','',NULL,300,5,0,0,15,15,30,360,'Debit Card',0,0,1);
INSERT INTO `billing` (`BillNo`,`Dte`,`BillType`,`NOP`,`TableNo`,`TableType`,`WaiterCode`,`WaiterName`,`Guest`,`Mobile`,`SubTotal`,`Qtys`,`DisType`,`Dis`,`SGST`,`CGST`,`sCharge`,`Total`,`PayMode`,`Paid`,`Balance`,`Received`) VALUES (26,'2021-03-18 01:49:48','Home Delivery',NULL,'','',NULL,'','',NULL,320,5,0,100,16,16,32,284,'Debit Card',0,0,0);
INSERT INTO `billing` (`BillNo`,`Dte`,`BillType`,`NOP`,`TableNo`,`TableType`,`WaiterCode`,`WaiterName`,`Guest`,`Mobile`,`SubTotal`,`Qtys`,`DisType`,`Dis`,`SGST`,`CGST`,`sCharge`,`Total`,`PayMode`,`Paid`,`Balance`,`Received`) VALUES (27,'2021-03-18 01:50:48','Take Away',NULL,'','',NULL,'','',NULL,320,5,1,10,16,16,32,352,'UPI',0,0,1);
INSERT INTO `billing` (`BillNo`,`Dte`,`BillType`,`NOP`,`TableNo`,`TableType`,`WaiterCode`,`WaiterName`,`Guest`,`Mobile`,`SubTotal`,`Qtys`,`DisType`,`Dis`,`SGST`,`CGST`,`sCharge`,`Total`,`PayMode`,`Paid`,`Balance`,`Received`) VALUES (28,'2021-03-18 01:54:59','Dine In',NULL,'Table-3','General',12,'Musthaffa','',NULL,130,2,0,0,6.5,6.5,13,156,'Credit Card',0,0,1);
INSERT INTO `billing` (`BillNo`,`Dte`,`BillType`,`NOP`,`TableNo`,`TableType`,`WaiterCode`,`WaiterName`,`Guest`,`Mobile`,`SubTotal`,`Qtys`,`DisType`,`Dis`,`SGST`,`CGST`,`sCharge`,`Total`,`PayMode`,`Paid`,`Balance`,`Received`) VALUES (29,'2021-03-18 01:55:46','Dine In',NULL,'Table-3','General',9,'Arsath','',NULL,190,3,0,0,9.5,9.5,19,228,'Credit Card',0,0,1);
INSERT INTO `billing` (`BillNo`,`Dte`,`BillType`,`NOP`,`TableNo`,`TableType`,`WaiterCode`,`WaiterName`,`Guest`,`Mobile`,`SubTotal`,`Qtys`,`DisType`,`Dis`,`SGST`,`CGST`,`sCharge`,`Total`,`PayMode`,`Paid`,`Balance`,`Received`) VALUES (30,'2021-03-18 01:55:55','Dine In',NULL,'Table-3','General',12,'Musthaffa','',NULL,140,3,0,0,7,7,14,168,'UPI',0,0,1);
INSERT INTO `billing` (`BillNo`,`Dte`,`BillType`,`NOP`,`TableNo`,`TableType`,`WaiterCode`,`WaiterName`,`Guest`,`Mobile`,`SubTotal`,`Qtys`,`DisType`,`Dis`,`SGST`,`CGST`,`sCharge`,`Total`,`PayMode`,`Paid`,`Balance`,`Received`) VALUES (31,'2021-03-18 01:56:49','Dine In',NULL,'Table-3','General',12,'Musthaffa','',NULL,250,4,0,0,12.5,12.5,25,300,'Credit Card',0,0,1);

#
# Table structure for table billing_items
#

DROP TABLE IF EXISTS `billing_items`;
CREATE TABLE `billing_items` (
  `BillNo` bigint(20) NOT NULL,
  `Code` bigint(20) DEFAULT NULL,
  `Name` varchar(50) DEFAULT NULL,
  `Qty` int(3) DEFAULT NULL,
  `Unit` varchar(30) DEFAULT NULL,
  `Price` decimal(10,2) DEFAULT NULL,
  `Amount` decimal(10,2) DEFAULT NULL,
  KEY `BillNo` (`BillNo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Dumping data for table billing_items
#

INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (2,31,'Tomato Uttapam',1,'Nos',60,60);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (2,32,'Onion Tomato Uttapam',1,'Nos',70,70);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (2,14,'Rava Pongal',1,'Plate',50,50);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (2,15,'Pori Set',1,'Plate',80,80);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (2,9,'Vada 2pcs',1,'Plate',30,30);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (2,12,'Sambar Vadai',1,'Plate',30,30);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (2,16,'Onion Pakoda',1,'Plate',60,60);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (2,17,'Onion Baji',1,'Plate',50,50);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (2,18,'Potato Baji',100,'Plate',50,5000);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (2,19,'Aaloo Bonda 2 Pcs',1,'Plate',50,50);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (2,20,'Bread Pakoda',1,'Plate',30,30);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (3,32,'Onion Tomato Uttapam',1,'Nos',70,70);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (3,31,'Tomato Uttapam',1,'Nos',60,60);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (4,31,'Tomato Uttapam',1,'Nos',60,60);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (4,32,'Onion Tomato Uttapam',1,'Nos',70,70);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (5,31,'Tomato Uttapam',3,'Nos',60,180);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (5,32,'Onion Tomato Uttapam',1,'Nos',70,70);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (6,31,'Tomato Uttapam',3,'Nos',60,180);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (7,31,'Tomato Uttapam',3,'Nos',60,180);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (7,32,'Onion Tomato Uttapam',2,'Nos',70,140);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (7,14,'Rava Pongal',1,'Plate',50,50);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (7,15,'Pori Set',1,'Plate',80,80);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (7,7,'Lassi',2,'Nos',40,80);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (7,1,'Cutting Chai',1,'cup',10,10);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (7,2,'Tea Full',2,'cup',20,40);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (7,3,'Coffee',2,'cup',20,40);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (7,4,'Filter Coffee',2,'cup',40,80);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (7,5,'Special Filter Coffee',1,'cup',80,80);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (7,10,'Mini Idli Half',1,'Plate',50,50);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (7,13,'Idli Fry',1,'Plate',70,70);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (8,31,'Tomato Uttapam',1,'Nos',60,60);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (8,30,'Onion  Uttapam',1,'Nos',60,60);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (9,25,'Tomato Dosa',1,'Nos',60,60);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (9,34,'Dosa Butter',1,'Nos',60,60);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (9,23,'Onion Dosa',1,'Nos',50,50);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (9,26,'Chilli Gharlic Dosa',1,'Nos',70,70);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (9,27,'Cheese Dosa',1,'Nos',80,80);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (10,12,'Sambar Vadai',1,'Plate',30,30);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (10,19,'Aaloo Bonda 2 Pcs',1,'Plate',50,50);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (10,16,'Onion Pakoda',1,'Plate',60,60);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (11,30,'Onion  Uttapam',2,'Nos',60,120);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (11,32,'Onion Tomato Uttapam',1,'Nos',70,70);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (11,29,'Plain Uttapam',1,'Nos',50,50);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (12,12,'Sambar Vadai',1,'Plate',30,30);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (12,17,'Onion Baji',1,'Plate',50,50);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (12,18,'Potato Baji',1,'Plate',50,50);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (12,16,'Onion Pakoda',2,'Plate',60,120);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (12,19,'Aaloo Bonda 2 Pcs',1,'Plate',50,50);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (13,21,'Plain Dosa',1,'Nos',40,40);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (13,24,'Podi Dosa',3,'Nos',60,180);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (13,26,'Chilli Gharlic Dosa',2,'Nos',70,140);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (13,33,'Rava Dosa plain',1,'Nos',50,50);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (13,28,'Chocolate Dosa',1,'Nos',90,90);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (13,25,'Tomato Dosa',3,'Nos',60,180);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (14,9,'Vada 2pcs',1,'Plate',30,30);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (14,16,'Onion Pakoda',1,'Plate',60,60);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (14,18,'Potato Baji',1,'Plate',50,50);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (14,17,'Onion Baji',1,'Plate',50,50);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (15,32,'Onion Tomato Uttapam',1,'Nos',70,70);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (15,30,'Onion  Uttapam',1,'Nos',60,60);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (15,31,'Tomato Uttapam',1,'Nos',60,60);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (16,26,'Chilli Gharlic Dosa',1,'Nos',70,70);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (16,28,'Chocolate Dosa',1,'Nos',90,90);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (16,24,'Podi Dosa',1,'Nos',60,60);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (17,22,'Masal Dosa',1,'Nos',50,50);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (17,27,'Cheese Dosa',1,'Nos',80,80);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (17,25,'Tomato Dosa',1,'Nos',60,60);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (18,16,'Onion Pakoda',1,'Plate',60,60);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (18,19,'Aaloo Bonda 2 Pcs',1,'Plate',50,50);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (18,12,'Sambar Vadai',1,'Plate',30,30);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (18,18,'Potato Baji',1,'Plate',50,50);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (19,32,'Onion Tomato Uttapam',1,'Nos',70,70);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (19,30,'Onion  Uttapam',1,'Nos',60,60);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (19,29,'Plain Uttapam',1,'Nos',50,50);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (20,13,'Idli Fry',3,'Plate',70,210);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (20,11,'Mini Idli Full ',3,'Plate',90,270);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (20,10,'Mini Idli Half',3,'Plate',50,150);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (20,21,'Plain Dosa',1,'Nos',40,40);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (21,23,'Onion Dosa',1,'Nos',50,50);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (21,26,'Chilli Gharlic Dosa',1,'Nos',70,70);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (21,28,'Chocolate Dosa',1,'Nos',90,90);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (21,24,'Podi Dosa',2,'Nos',60,120);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (21,5,'Special Filter Coffee',1,'cup',80,80);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (22,27,'Cheese Dosa',1,'Nos',80,80);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (22,23,'Onion Dosa',1,'Nos',50,50);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (22,26,'Chilli Gharlic Dosa',1,'Nos',70,70);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (23,25,'Tomato Dosa',1,'Nos',60,60);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (23,28,'Chocolate Dosa',1,'Nos',90,90);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (23,22,'Masal Dosa',1,'Nos',50,50);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (23,26,'Chilli Gharlic Dosa',1,'Nos',70,70);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (24,30,'Onion  Uttapam',1,'Nos',60,60);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (24,31,'Tomato Uttapam',1,'Nos',60,60);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (24,29,'Plain Uttapam',1,'Nos',50,50);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (25,22,'Masal Dosa',1,'Nos',50,50);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (25,26,'Chilli Gharlic Dosa',1,'Nos',70,70);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (25,23,'Onion Dosa',1,'Nos',50,50);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (25,27,'Cheese Dosa',1,'Nos',80,80);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (25,33,'Rava Dosa plain',1,'Nos',50,50);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (26,23,'Onion Dosa',2,'Nos',50,100);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (26,28,'Chocolate Dosa',1,'Nos',90,90);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (26,27,'Cheese Dosa',1,'Nos',80,80);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (26,33,'Rava Dosa plain',1,'Nos',50,50);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (27,24,'Podi Dosa',2,'Nos',60,120);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (27,27,'Cheese Dosa',1,'Nos',80,80);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (27,33,'Rava Dosa plain',1,'Nos',50,50);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (27,26,'Chilli Gharlic Dosa',1,'Nos',70,70);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (28,32,'Onion Tomato Uttapam',1,'Nos',70,70);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (28,30,'Onion  Uttapam',1,'Nos',60,60);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (29,30,'Onion  Uttapam',2,'Nos',60,120);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (29,32,'Onion Tomato Uttapam',1,'Nos',70,70);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (30,16,'Onion Pakoda',1,'Plate',60,60);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (30,17,'Onion Baji',1,'Plate',50,50);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (30,12,'Sambar Vadai',1,'Plate',30,30);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (31,22,'Masal Dosa',1,'Nos',50,50);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (31,33,'Rava Dosa plain',1,'Nos',50,50);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (31,28,'Chocolate Dosa',1,'Nos',90,90);
INSERT INTO `billing_items` (`BillNo`,`Code`,`Name`,`Qty`,`Unit`,`Price`,`Amount`) VALUES (31,25,'Tomato Dosa',1,'Nos',60,60);

#
# Table structure for table guest
#

DROP TABLE IF EXISTS `guest`;
CREATE TABLE `guest` (
  `Code` bigint(20) NOT NULL AUTO_INCREMENT,
  `Name` varchar(30) DEFAULT NULL,
  `Phone` bigint(12) DEFAULT NULL,
  `Address` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Code`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

#
# Dumping data for table guest
#

INSERT INTO `guest` (`Code`,`Name`,`Phone`,`Address`) VALUES (1,'Chandru',9874563212,'Hi chandru');
INSERT INTO `guest` (`Code`,`Name`,`Phone`,`Address`) VALUES (2,'velan',79544054,'hi');
INSERT INTO `guest` (`Code`,`Name`,`Phone`,`Address`) VALUES (8,'Arsath',789456123,'dfefgdgedfd');

#
# Table structure for table item_category
#

DROP TABLE IF EXISTS `item_category`;
CREATE TABLE `item_category` (
  `Code` int(11) NOT NULL AUTO_INCREMENT,
  `Category` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Code`)
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=latin1;

#
# Dumping data for table item_category
#

INSERT INTO `item_category` (`Code`,`Category`) VALUES (1,'Beverages');
INSERT INTO `item_category` (`Code`,`Category`) VALUES (2,'Tiffen');
INSERT INTO `item_category` (`Code`,`Category`) VALUES (3,'Snacks');
INSERT INTO `item_category` (`Code`,`Category`) VALUES (4,'Dosa');
INSERT INTO `item_category` (`Code`,`Category`) VALUES (5,'Uttapam');
INSERT INTO `item_category` (`Code`,`Category`) VALUES (6,'Idly');
INSERT INTO `item_category` (`Code`,`Category`) VALUES (26,'Birayani');
INSERT INTO `item_category` (`Code`,`Category`) VALUES (27,'vada');

#
# Table structure for table item_division
#

DROP TABLE IF EXISTS `item_division`;
CREATE TABLE `item_division` (
  `Code` int(11) NOT NULL AUTO_INCREMENT,
  `Division` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Code`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

#
# Dumping data for table item_division
#

INSERT INTO `item_division` (`Code`,`Division`) VALUES (1,'Breakfast');
INSERT INTO `item_division` (`Code`,`Division`) VALUES (2,'Lunch');
INSERT INTO `item_division` (`Code`,`Division`) VALUES (3,'Dinner');
INSERT INTO `item_division` (`Code`,`Division`) VALUES (4,'Breakfast / Dinner');
INSERT INTO `item_division` (`Code`,`Division`) VALUES (5,'All');
INSERT INTO `item_division` (`Code`,`Division`) VALUES (6,'Breakfast / Lunch');
INSERT INTO `item_division` (`Code`,`Division`) VALUES (7,'Lunch / Dinner');

#
# Table structure for table item_unit
#

DROP TABLE IF EXISTS `item_unit`;
CREATE TABLE `item_unit` (
  `Code` int(11) NOT NULL AUTO_INCREMENT,
  `Unit` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Code`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;

#
# Dumping data for table item_unit
#

INSERT INTO `item_unit` (`Code`,`Unit`) VALUES (1,'Plate');
INSERT INTO `item_unit` (`Code`,`Unit`) VALUES (2,'item');
INSERT INTO `item_unit` (`Code`,`Unit`) VALUES (3,'Nos');
INSERT INTO `item_unit` (`Code`,`Unit`) VALUES (12,'cup');

#
# Table structure for table kot
#

DROP TABLE IF EXISTS `kot`;
CREATE TABLE `kot` (
  `kot_no` bigint(20) NOT NULL AUTO_INCREMENT,
  `table_name` varchar(10) DEFAULT NULL,
  `table_type` varchar(30) DEFAULT NULL,
  `Nop` int(3) DEFAULT NULL,
  `waiterCode` int(11) DEFAULT NULL,
  `waiterName` varchar(40) DEFAULT NULL,
  `Remark` varchar(50) DEFAULT NULL,
  `DateTime` datetime DEFAULT NULL,
  PRIMARY KEY (`kot_no`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=latin1;

#
# Dumping data for table kot
#

INSERT INTO `kot` (`kot_no`,`table_name`,`table_type`,`Nop`,`waiterCode`,`waiterName`,`Remark`,`DateTime`) VALUES (12,'Table-2','A/C Room',NULL,10,'Ashar','','2021-03-17 16:08:21');
INSERT INTO `kot` (`kot_no`,`table_name`,`table_type`,`Nop`,`waiterCode`,`waiterName`,`Remark`,`DateTime`) VALUES (21,'Table-1','General',NULL,9,'Arsath','','2021-03-17 15:41:28');
INSERT INTO `kot` (`kot_no`,`table_name`,`table_type`,`Nop`,`waiterCode`,`waiterName`,`Remark`,`DateTime`) VALUES (24,'Table-3','General',NULL,12,'Musthaffa','','2021-03-18 10:29:06');
INSERT INTO `kot` (`kot_no`,`table_name`,`table_type`,`Nop`,`waiterCode`,`waiterName`,`Remark`,`DateTime`) VALUES (29,'Table-3','General',NULL,10,'Ashar','','2021-03-18 10:39:19');
INSERT INTO `kot` (`kot_no`,`table_name`,`table_type`,`Nop`,`waiterCode`,`waiterName`,`Remark`,`DateTime`) VALUES (30,'Table-4','General',NULL,10,'Ashar','','2021-03-18 01:57:59');

#
# Table structure for table kot_item
#

DROP TABLE IF EXISTS `kot_item`;
CREATE TABLE `kot_item` (
  `kot_no` bigint(20) DEFAULT NULL,
  `item_code` bigint(20) DEFAULT NULL,
  `item_name` varchar(50) DEFAULT NULL,
  `qty` int(5) DEFAULT NULL,
  `unit` varchar(20) DEFAULT NULL,
  `price` decimal(10,2) DEFAULT NULL,
  `Amount` decimal(10,2) DEFAULT NULL,
  `Status` tinyint(3) NOT NULL DEFAULT '0',
  KEY `kot_no` (`kot_no`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Dumping data for table kot_item
#

INSERT INTO `kot_item` (`kot_no`,`item_code`,`item_name`,`qty`,`unit`,`price`,`Amount`,`Status`) VALUES (21,26,'Chilli Gharlic Dosa',1,'Nos',70,70,1);
INSERT INTO `kot_item` (`kot_no`,`item_code`,`item_name`,`qty`,`unit`,`price`,`Amount`,`Status`) VALUES (12,21,'Plain Dosa',11,'Nos',40,440,1);
INSERT INTO `kot_item` (`kot_no`,`item_code`,`item_name`,`qty`,`unit`,`price`,`Amount`,`Status`) VALUES (30,15,'Pori Set',2,'Plate',80,160,0);
INSERT INTO `kot_item` (`kot_no`,`item_code`,`item_name`,`qty`,`unit`,`price`,`Amount`,`Status`) VALUES (30,14,'Rava Pongal',2,'Plate',50,100,0);
INSERT INTO `kot_item` (`kot_no`,`item_code`,`item_name`,`qty`,`unit`,`price`,`Amount`,`Status`) VALUES (24,21,'Plain Dosa',1,'Nos',40,40,1);
INSERT INTO `kot_item` (`kot_no`,`item_code`,`item_name`,`qty`,`unit`,`price`,`Amount`,`Status`) VALUES (24,22,'Masal Dosa',1,'Nos',50,50,1);
INSERT INTO `kot_item` (`kot_no`,`item_code`,`item_name`,`qty`,`unit`,`price`,`Amount`,`Status`) VALUES (24,23,'Onion Dosa',1,'Nos',50,50,0);
INSERT INTO `kot_item` (`kot_no`,`item_code`,`item_name`,`qty`,`unit`,`price`,`Amount`,`Status`) VALUES (24,24,'Podi Dosa',1,'Nos',60,60,0);
INSERT INTO `kot_item` (`kot_no`,`item_code`,`item_name`,`qty`,`unit`,`price`,`Amount`,`Status`) VALUES (29,24,'Podi Dosa',2,'Nos',60,120,1);
INSERT INTO `kot_item` (`kot_no`,`item_code`,`item_name`,`qty`,`unit`,`price`,`Amount`,`Status`) VALUES (29,28,'Chocolate Dosa',1,'Nos',90,90,1);
INSERT INTO `kot_item` (`kot_no`,`item_code`,`item_name`,`qty`,`unit`,`price`,`Amount`,`Status`) VALUES (29,25,'Tomato Dosa',1,'Nos',60,60,1);
INSERT INTO `kot_item` (`kot_no`,`item_code`,`item_name`,`qty`,`unit`,`price`,`Amount`,`Status`) VALUES (29,33,'Rava Dosa plain',1,'Nos',50,50,0);
INSERT INTO `kot_item` (`kot_no`,`item_code`,`item_name`,`qty`,`unit`,`price`,`Amount`,`Status`) VALUES (29,8,'Idli 2pcs',4,'Plate',30,120,0);

#
# Table structure for table menu_item
#

DROP TABLE IF EXISTS `menu_item`;
CREATE TABLE `menu_item` (
  `Code` bigint(20) NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) DEFAULT NULL,
  `PrintName` varchar(40) DEFAULT NULL,
  `Category` int(11) DEFAULT NULL,
  `Unit` int(11) DEFAULT NULL,
  `Division` int(11) DEFAULT NULL,
  `Price` decimal(10,2) DEFAULT '0.00',
  PRIMARY KEY (`Code`),
  KEY `Category` (`Category`),
  KEY `Unit` (`Unit`),
  KEY `Division` (`Division`)
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=latin1;

#
# Dumping data for table menu_item
#

INSERT INTO `menu_item` (`Code`,`Name`,`PrintName`,`Category`,`Unit`,`Division`,`Price`) VALUES (1,'Cutting Chai','Cutting Chai',1,12,5,10);
INSERT INTO `menu_item` (`Code`,`Name`,`PrintName`,`Category`,`Unit`,`Division`,`Price`) VALUES (2,'Tea Full','Tea Full',1,12,5,20);
INSERT INTO `menu_item` (`Code`,`Name`,`PrintName`,`Category`,`Unit`,`Division`,`Price`) VALUES (3,'Coffee','Coffee',1,12,5,20);
INSERT INTO `menu_item` (`Code`,`Name`,`PrintName`,`Category`,`Unit`,`Division`,`Price`) VALUES (4,'Filter Coffee','Filter Coffee',1,12,4,40);
INSERT INTO `menu_item` (`Code`,`Name`,`PrintName`,`Category`,`Unit`,`Division`,`Price`) VALUES (5,'Special Filter Coffee','Sp.Fil,Coffee',1,12,4,80);
INSERT INTO `menu_item` (`Code`,`Name`,`PrintName`,`Category`,`Unit`,`Division`,`Price`) VALUES (6,'Butter Milk','But.Milk',1,3,7,20);
INSERT INTO `menu_item` (`Code`,`Name`,`PrintName`,`Category`,`Unit`,`Division`,`Price`) VALUES (7,'Lassi','Lassi',1,3,6,40);
INSERT INTO `menu_item` (`Code`,`Name`,`PrintName`,`Category`,`Unit`,`Division`,`Price`) VALUES (8,'Idli 2pcs','Idli',6,1,4,30);
INSERT INTO `menu_item` (`Code`,`Name`,`PrintName`,`Category`,`Unit`,`Division`,`Price`) VALUES (9,'Vada 2pcs','Vada plate',3,1,4,30);
INSERT INTO `menu_item` (`Code`,`Name`,`PrintName`,`Category`,`Unit`,`Division`,`Price`) VALUES (10,'Mini Idli Half','M.Idli.Half',6,1,4,50);
INSERT INTO `menu_item` (`Code`,`Name`,`PrintName`,`Category`,`Unit`,`Division`,`Price`) VALUES (11,'Mini Idli Full ','M.Idli.Full',6,1,4,90);
INSERT INTO `menu_item` (`Code`,`Name`,`PrintName`,`Category`,`Unit`,`Division`,`Price`) VALUES (12,'Sambar Vadai','Sambar Vada',3,1,4,30);
INSERT INTO `menu_item` (`Code`,`Name`,`PrintName`,`Category`,`Unit`,`Division`,`Price`) VALUES (13,'Idli Fry','Idli Fry',6,1,4,70);
INSERT INTO `menu_item` (`Code`,`Name`,`PrintName`,`Category`,`Unit`,`Division`,`Price`) VALUES (14,'Rava Pongal','Rava Pongal',2,1,4,50);
INSERT INTO `menu_item` (`Code`,`Name`,`PrintName`,`Category`,`Unit`,`Division`,`Price`) VALUES (15,'Pori Set','Pori',2,1,4,80);
INSERT INTO `menu_item` (`Code`,`Name`,`PrintName`,`Category`,`Unit`,`Division`,`Price`) VALUES (16,'Onion Pakoda','Oni.Pakoda',3,1,3,60);
INSERT INTO `menu_item` (`Code`,`Name`,`PrintName`,`Category`,`Unit`,`Division`,`Price`) VALUES (17,'Onion Baji','Oni.Baji',3,1,4,50);
INSERT INTO `menu_item` (`Code`,`Name`,`PrintName`,`Category`,`Unit`,`Division`,`Price`) VALUES (18,'Potato Baji','Pot.Baji',3,1,4,50);
INSERT INTO `menu_item` (`Code`,`Name`,`PrintName`,`Category`,`Unit`,`Division`,`Price`) VALUES (19,'Aaloo Bonda 2 Pcs','Aal.Bonda',3,1,4,50);
INSERT INTO `menu_item` (`Code`,`Name`,`PrintName`,`Category`,`Unit`,`Division`,`Price`) VALUES (20,'Bread Pakoda','Bre.Pakoda',3,1,4,30);
INSERT INTO `menu_item` (`Code`,`Name`,`PrintName`,`Category`,`Unit`,`Division`,`Price`) VALUES (21,'Plain Dosa','Pl.Dosa',4,3,5,40);
INSERT INTO `menu_item` (`Code`,`Name`,`PrintName`,`Category`,`Unit`,`Division`,`Price`) VALUES (22,'Masal Dosa','Mas.Dosa',4,3,5,50);
INSERT INTO `menu_item` (`Code`,`Name`,`PrintName`,`Category`,`Unit`,`Division`,`Price`) VALUES (23,'Onion Dosa','Oni.Dosa',4,3,4,50);
INSERT INTO `menu_item` (`Code`,`Name`,`PrintName`,`Category`,`Unit`,`Division`,`Price`) VALUES (24,'Podi Dosa','Podi Dosa',4,3,4,60);
INSERT INTO `menu_item` (`Code`,`Name`,`PrintName`,`Category`,`Unit`,`Division`,`Price`) VALUES (25,'Tomato Dosa','Tomato Dosa',4,3,4,60);
INSERT INTO `menu_item` (`Code`,`Name`,`PrintName`,`Category`,`Unit`,`Division`,`Price`) VALUES (26,'Chilli Gharlic Dosa','Chi,Ghar.Dosa',4,3,4,70);
INSERT INTO `menu_item` (`Code`,`Name`,`PrintName`,`Category`,`Unit`,`Division`,`Price`) VALUES (27,'Cheese Dosa','Cheese Dosa',4,3,4,80);
INSERT INTO `menu_item` (`Code`,`Name`,`PrintName`,`Category`,`Unit`,`Division`,`Price`) VALUES (28,'Chocolate Dosa','Choco.Dosa',4,3,4,90);
INSERT INTO `menu_item` (`Code`,`Name`,`PrintName`,`Category`,`Unit`,`Division`,`Price`) VALUES (29,'Plain Uttapam','Plain Uttapam',5,3,4,50);
INSERT INTO `menu_item` (`Code`,`Name`,`PrintName`,`Category`,`Unit`,`Division`,`Price`) VALUES (30,'Onion  Uttapam','Oni.Uttapam',5,3,4,60);
INSERT INTO `menu_item` (`Code`,`Name`,`PrintName`,`Category`,`Unit`,`Division`,`Price`) VALUES (31,'Tomato Uttapam','Tom.Uttapam',5,3,4,60);
INSERT INTO `menu_item` (`Code`,`Name`,`PrintName`,`Category`,`Unit`,`Division`,`Price`) VALUES (32,'Onion Tomato Uttapam','Oni.TomUttapam',5,3,4,70);
INSERT INTO `menu_item` (`Code`,`Name`,`PrintName`,`Category`,`Unit`,`Division`,`Price`) VALUES (33,'Rava Dosa plain','Ra.Dosa plain',4,3,4,50);
INSERT INTO `menu_item` (`Code`,`Name`,`PrintName`,`Category`,`Unit`,`Division`,`Price`) VALUES (34,'Dosa Butter','Dosa Butter',4,3,4,60);
INSERT INTO `menu_item` (`Code`,`Name`,`PrintName`,`Category`,`Unit`,`Division`,`Price`) VALUES (35,'Onion Rava Dosa ','Oni.Rava.Dosa ',4,3,4,70);

#
# Table structure for table printer
#

DROP TABLE IF EXISTS `printer`;
CREATE TABLE `printer` (
  `PrinterName` varchar(50) DEFAULT NULL,
  `Enable` tinyint(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Dumping data for table printer
#

INSERT INTO `printer` (`PrinterName`,`Enable`) VALUES ('Send To OneNote 16',1);
INSERT INTO `printer` (`PrinterName`,`Enable`) VALUES ('Microsoft XPS Document Writer',0);

#
# Table structure for table table_master
#

DROP TABLE IF EXISTS `table_master`;
CREATE TABLE `table_master` (
  `Code` int(11) NOT NULL AUTO_INCREMENT,
  `TableNo` int(11) DEFAULT NULL,
  `Location` varchar(20) DEFAULT NULL,
  `status` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`Code`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

#
# Dumping data for table table_master
#

INSERT INTO `table_master` (`Code`,`TableNo`,`Location`,`status`) VALUES (1,7,'General','Service Available');
INSERT INTO `table_master` (`Code`,`TableNo`,`Location`,`status`) VALUES (2,2,'A/C Room','Service Available');
INSERT INTO `table_master` (`Code`,`TableNo`,`Location`,`status`) VALUES (3,3,'General','Service Available');
INSERT INTO `table_master` (`Code`,`TableNo`,`Location`,`status`) VALUES (6,6,'A/C Room','Service Available');
INSERT INTO `table_master` (`Code`,`TableNo`,`Location`,`status`) VALUES (8,4,'General','Service Available');
INSERT INTO `table_master` (`Code`,`TableNo`,`Location`,`status`) VALUES (9,5,'A/C Room','Service Available');
INSERT INTO `table_master` (`Code`,`TableNo`,`Location`,`status`) VALUES (10,1,'General','Service Available');

#
# Table structure for table tax
#

DROP TABLE IF EXISTS `tax`;
CREATE TABLE `tax` (
  `SGST` decimal(5,2) DEFAULT '0.00',
  `CGST` decimal(5,2) DEFAULT '0.00',
  `S_Charge` decimal(5,2) DEFAULT '0.00',
  `Date` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Dumping data for table tax
#

INSERT INTO `tax` (`SGST`,`CGST`,`S_Charge`,`Date`) VALUES (5,5,10,'2021-03-14 14:18:00');

#
# Table structure for table waiter
#

DROP TABLE IF EXISTS `waiter`;
CREATE TABLE `waiter` (
  `Code` bigint(20) NOT NULL AUTO_INCREMENT,
  `Name` varchar(40) DEFAULT NULL,
  `Phone` varchar(12) DEFAULT NULL,
  `available` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`Code`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;

#
# Dumping data for table waiter
#

INSERT INTO `waiter` (`Code`,`Name`,`Phone`,`available`) VALUES (7,'Chandru','98686952626',1);
INSERT INTO `waiter` (`Code`,`Name`,`Phone`,`available`) VALUES (8,'Velan','65135131322',1);
INSERT INTO `waiter` (`Code`,`Name`,`Phone`,`available`) VALUES (9,'Arsath','789123456',1);
INSERT INTO `waiter` (`Code`,`Name`,`Phone`,`available`) VALUES (10,'Ashar','321456987',1);
INSERT INTO `waiter` (`Code`,`Name`,`Phone`,`available`) VALUES (11,'Arsath1','131546879',0);
INSERT INTO `waiter` (`Code`,`Name`,`Phone`,`available`) VALUES (12,'Musthaffa','123456789',1);

#
#  Foreign keys for table billing_items
#

ALTER TABLE `billing_items`
  ADD FOREIGN KEY (`BillNo`) REFERENCES `billing` (`BillNo`);

#
#  Foreign keys for table kot_item
#

ALTER TABLE `kot_item`
  ADD FOREIGN KEY (`kot_no`) REFERENCES `kot` (`kot_no`);

#
#  Foreign keys for table menu_item
#

ALTER TABLE `menu_item`
  ADD FOREIGN KEY (`Category`) REFERENCES `item_category` (`Code`),
  ADD FOREIGN KEY (`Unit`) REFERENCES `item_unit` (`Code`),
  ADD FOREIGN KEY (`Division`) REFERENCES `item_division` (`Code`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
