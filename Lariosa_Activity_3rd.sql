-- MySQL dump 10.13  Distrib 8.0.20, for Win64 (x86_64)
--
-- Host: localhost    Database: bsit3c_edp
-- ------------------------------------------------------
-- Server version	8.1.0

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
-- Temporary view structure for view ` topvarietiesbysales`
--

DROP TABLE IF EXISTS ` topvarietiesbysales`;
/*!50001 DROP VIEW IF EXISTS ` topvarietiesbysales`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW ` topvarietiesbysales` AS SELECT 
 1 AS `VarietyID`,
 1 AS `VarietyName`,
 1 AS `TotalSalesQuantity`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `credential`
--

DROP TABLE IF EXISTS `credential`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `credential` (
  `idCredential` int NOT NULL AUTO_INCREMENT,
  `username` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  `name` varchar(45) NOT NULL,
  `email` varchar(45) NOT NULL,
  `isActive` bit(1) DEFAULT NULL,
  `position` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idCredential`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `credential`
--

LOCK TABLES `credential` WRITE;
/*!40000 ALTER TABLE `credential` DISABLE KEYS */;
INSERT INTO `credential` VALUES (1,'jobelle','jobelle','Jobelle','lariosajobelle@gmail.com',_binary '','General Manager'),(2,'lariosa','lariosa','Lariosa','lariosajobellemercado@gmail.com',_binary '','General Manager'),(3,'angelo','angelo','Angelo','angelomansion@gmail.com',_binary '','Stock Manager'),(4,'mark','mark','Mark','mark@gmail.com',_binary '','Sales Representative'),(5,'marky','maky','Marky','Marky@gmail.com',_binary '','Sales Representative'),(6,'pink','pink','Pink','Pink@gmail.com',_binary '','Cashier'),(7,'angelle','angelle','Angelle','Angelle@gmail.com',_binary '','Sales Representative'),(8,'louie','louie','Louie','Louie@gmail.com',_binary '','Sales Representative'),(9,'mariella','mariella','Mariella','Mariella@gmail.com',_binary '','Cashier'),(10,'@jobelle','@jobelle','Jobelle Lariosa','jobelle@gmail.com',_binary '','Sales Representative'),(11,'@maamangelle','@maamangelle','Angelle Mansion','angellelariosamansion@gmail.com',_binary '','Sales Representative'),(12,'@sirMarkie','@sirMarkie','Marcky Jushuable Lariosa','marckyjusuable@gmail.com',_binary '','Inventory Manager'),(13,'@MackyJushuable','@MackyJushuable','Marcky Jushuable Lariosa','markyjushuable@gmail.com',_binary '','Inventory Manager'),(14,'@maambelle','lariosa','Jobelle Lariosa','JobelleLariosa@gmail.com',_binary '','General Manager');
/*!40000 ALTER TABLE `credential` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customers`
--

DROP TABLE IF EXISTS `customers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customers` (
  `CustomerID` int NOT NULL,
  `CustomerName` varchar(255) NOT NULL,
  `ContactNumber` varchar(15) NOT NULL,
  `Location` varchar(45) NOT NULL,
  `Payment` varchar(45) NOT NULL,
  `Email` varchar(45) NOT NULL,
  PRIMARY KEY (`CustomerID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customers`
--

LOCK TABLES `customers` WRITE;
/*!40000 ALTER TABLE `customers` DISABLE KEYS */;
INSERT INTO `customers` VALUES (1,'Jobelle Lariosa','+484187687','Casiguran Sorsogon','Cash on Delivery','lariosajobellemercado@gmail.com'),(2,'Juan Dela Cruz','09123456789','Manila','Cash','juan@example.com'),(3,'Maria Santos','09234567890','Quezon City','Credit Card','maria@example.com'),(4,'Pedro Reyes','09345678901','Cebu City','Cash','pedro@example.com'),(5,'Ana Lim','09456789012','Davao City','Cash','ana@example.com'),(6,'Ramon Garcia','09567890123','Makati','Cash','ramon@example.com'),(7,'Sofia Cruz','09678901234','Manila','Credit Card','sofia@example.com'),(8,'Eduardo Santos','09789012345','Quezon City','Cash','eduardo@example.com'),(9,'Luz Reyes','09890123456','Cebu City','Cash','luz@example.com'),(10,'Josefa Lim','09901234567','Davao City','Credit Card','josefa@example.com'),(11,'Felipe Garcia','09123456789','Makati','Cash','felipe@example.com'),(12,'Angelica Cruz','09234567890','Manila','Cash','angelica@example.com'),(13,'Gabriel Santos','09345678901','Quezon City','Credit Card','gabriel@example.com'),(14,'Rosa Reyes','09456789012','Cebu City','Cash','rosa@example.com'),(15,'Daniel Lim','09567890123','Davao City','Cash','daniel@example.com'),(16,'Carmen Garcia','09678901234','Makati','Credit Card','carmen@example.com'),(17,'Fernando Cruz','09789012345','Manila','Cash','fernando@example.com'),(18,'Aurora Santos','09890123456','Quezon City','Cash','aurora@example.com'),(19,'Pablo Reyes','09901234567','Cebu City','Credit Card','pablo@example.com'),(20,'Isabela Lim','09123456789','Davao City','Cash','isabela@example.com'),(21,'Carlos Garcia','09234567890','Makati','Cash','carlos@example.com'),(25,'Jolie Brits','091534541','Location','Cash','Email'),(27,'Justine Joyce Hije','092167517546','Location','Cash on Delivery','justine@gmail.com'),(28,'May Mayola','0951574575','Location','Cash','maymayola@gmail.com'),(30,'Josephine Andertoney','+2165423457','Location','Cash on Delivery','josephine@gmail.com'),(32,'Emmie Castillo','095501714500','Location','Gcash','castiloo@gmail.com'),(35,'Josephine Andertoney','+2165423457','Location','Cash on Delivery','josephine@gmail.com');
/*!40000 ALTER TABLE `customers` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `customers_AFTER_INSERT` AFTER INSERT ON `customers` FOR EACH ROW BEGIN
-- Check if the new customer exists in the sales table
    IF EXISTS (SELECT 1 FROM sales WHERE CustomerID = NEW.CustomerID) THEN
        -- Update the customerID in the sales table for the new customer
        UPDATE sales
        SET CustomerID = NEW.CustomerID
        WHERE CustomerID IS NULL; -- Assuming customerID is NULL for new customers in sales table
    END IF;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `payment`
--

DROP TABLE IF EXISTS `payment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `payment` (
  `paymentID` int NOT NULL,
  `CustomerID` int DEFAULT NULL,
  `transactionID` varchar(100) DEFAULT NULL,
  `Status` varchar(50) DEFAULT NULL,
  `paymentmethod` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`paymentID`),
  KEY `payment_customers_idx` (`CustomerID`),
  CONSTRAINT `payment_customers` FOREIGN KEY (`CustomerID`) REFERENCES `customers` (`CustomerID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `payment`
--

LOCK TABLES `payment` WRITE;
/*!40000 ALTER TABLE `payment` DISABLE KEYS */;
INSERT INTO `payment` VALUES (1,1,'CC123456','Completed','Credit Card'),(2,2,'C123456','Completed','Cash'),(3,3,'DC123456','Completed','Debit Card'),(4,4,'BT123456','Completed','Bank Transfer'),(5,5,'CC654321','Completed','Credit Card'),(6,6,'C654321','Completed','Cash'),(7,7,'CC789012','Completed','Credit Card'),(8,8,'DC789012','Completed','Debit Card'),(9,9,'C789012','Completed','Cash'),(10,10,'CC567890','Completed','Credit Card'),(11,11,'DC567890','Completed','Debit Card'),(12,12,'BT567890','Completed','Bank Transfer'),(13,13,'C567890','Completed','Cash'),(14,14,'CC234567','Completed','Credit Card'),(15,15,'DC234567','Completed','Debit Card'),(16,16,'C234567','Completed','Cash'),(17,17,'CC901234','Completed','Credit Card'),(18,18,'DC901234','Completed','Debit Card'),(19,19,'C901234','Completed','Cash'),(20,20,'CC345678','Completed','Credit Card');
/*!40000 ALTER TABLE `payment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `prices_stock_varieties`
--

DROP TABLE IF EXISTS `prices_stock_varieties`;
/*!50001 DROP VIEW IF EXISTS `prices_stock_varieties`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `prices_stock_varieties` AS SELECT 
 1 AS `VarietyName`,
 1 AS `SupplierName`,
 1 AS `Price`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `ricestock`
--

DROP TABLE IF EXISTS `ricestock`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ricestock` (
  `StockID` int NOT NULL,
  `VarietyID` int DEFAULT NULL,
  `SupplierID` int DEFAULT NULL,
  `Quantity` int DEFAULT NULL,
  `Price` decimal(10,2) DEFAULT NULL,
  `Total_value` decimal(10,2) DEFAULT '0.00',
  `PurchaseDate` date DEFAULT NULL,
  PRIMARY KEY (`StockID`),
  KEY `ricestock_idx` (`SupplierID`),
  CONSTRAINT `ricestock` FOREIGN KEY (`StockID`) REFERENCES `ricevarieties` (`VarietyID`),
  CONSTRAINT `ricestock1` FOREIGN KEY (`SupplierID`) REFERENCES `suppliers` (`SupplierID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ricestock`
--

LOCK TABLES `ricestock` WRITE;
/*!40000 ALTER TABLE `ricestock` DISABLE KEYS */;
INSERT INTO `ricestock` VALUES (1,1,1,1300,50.50,65650.00,'2024-04-07'),(2,2,2,400,43.50,17400.00,'2024-01-02'),(3,3,3,950,35.75,0.00,'2024-01-03'),(4,4,4,925,45.80,0.00,'2024-01-04'),(5,5,5,875,58.25,0.00,'2024-01-05'),(6,6,6,945,68.50,0.00,'2024-01-06'),(7,7,7,895,35.00,0.00,'2024-01-07'),(8,8,8,885,30.25,0.00,'2024-01-08'),(9,9,9,730,38.75,0.00,'2024-01-09'),(10,10,10,880,48.25,0.00,'2024-01-10'),(11,11,11,880,59.25,0.00,'2024-01-11'),(12,12,12,850,48.25,0.00,'2024-01-12'),(13,13,13,880,40.15,0.00,'2024-01-13'),(14,14,14,870,45.25,0.00,'2024-01-14'),(15,15,15,700,40.65,0.00,'2024-02-15'),(16,16,16,725,48.25,0.00,'2024-02-18'),(17,17,17,870,55.25,0.00,'2024-09-23'),(18,18,18,875,48.25,0.00,'2024-09-23'),(19,19,19,828,52.25,0.00,'2024-09-24'),(20,21,20,900,53.75,0.00,'2024-09-24'),(22,22,22,1000,60.15,0.00,'2024-04-01'),(23,2,2,500,43.50,21750.00,'2024-04-05'),(24,24,30,1000,68.50,0.00,'2024-04-05'),(25,25,25,2500,65.50,163750.00,'2024-04-15');
/*!40000 ALTER TABLE `ricestock` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `ricestock_BEFORE_UPDATE` BEFORE UPDATE ON `ricestock` FOR EACH ROW BEGIN
-- Declare variables to store the updated quantity and price
    DECLARE updatedQuantity INT;
    DECLARE updatedPrice DECIMAL(10, 2);

    -- Get the updated quantity and price
    SET updatedQuantity = NEW.Quantity;
    SET updatedPrice = NEW.Price;

    -- Calculate the updated total value
    SET NEW.Total_value = updatedQuantity * updatedPrice;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `ricevarieties`
--

DROP TABLE IF EXISTS `ricevarieties`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ricevarieties` (
  `VarietyID` int NOT NULL,
  `VarietyName` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`VarietyID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ricevarieties`
--

LOCK TABLES `ricevarieties` WRITE;
/*!40000 ALTER TABLE `ricevarieties` DISABLE KEYS */;
INSERT INTO `ricevarieties` VALUES (1,'Basmati'),(2,'Jasmine'),(3,'Long Grain White'),(4,'Short Grain White'),(5,'Brown Rice'),(6,'Arborio'),(7,'Black Rice'),(8,'Red Rice'),(9,'Sushi Rice'),(10,'Wild Rice'),(11,'White Rice'),(12,'Parboiled Rice'),(13,'Sticky Rice'),(14,'Bomba Rice'),(15,'Carnaroli Rice'),(16,'Calrose Rice'),(17,'Medium Grain Rice'),(18,'Himalayan Red Rice'),(19,'Bhutanese Red Rice'),(20,'Thai Red Rice'),(21,'Golden Rice'),(22,'Thai Jasmine Rice'),(23,'Original Rice'),(24,'Malagkit Rice'),(25,'Chinese Rice HighBreed');
/*!40000 ALTER TABLE `ricevarieties` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sales`
--

DROP TABLE IF EXISTS `sales`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sales` (
  `SaleID` int NOT NULL AUTO_INCREMENT,
  `VarietyID` int DEFAULT NULL,
  `CustomerID` int DEFAULT NULL,
  `Quantity` int NOT NULL,
  `SaleDate` date NOT NULL,
  PRIMARY KEY (`SaleID`),
  KEY `sales_idx` (`VarietyID`),
  KEY `sales1_idx` (`CustomerID`),
  CONSTRAINT `sales` FOREIGN KEY (`VarietyID`) REFERENCES `ricevarieties` (`VarietyID`) ON DELETE RESTRICT,
  CONSTRAINT `sales1` FOREIGN KEY (`CustomerID`) REFERENCES `customers` (`CustomerID`)
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sales`
--

LOCK TABLES `sales` WRITE;
/*!40000 ALTER TABLE `sales` DISABLE KEYS */;
INSERT INTO `sales` VALUES (1,1,1,50,'2024-02-15'),(2,2,2,100,'2024-02-15'),(3,3,3,50,'2024-02-16'),(4,4,4,75,'2024-02-14'),(5,5,5,25,'2024-02-17'),(6,6,6,55,'2024-02-18'),(7,7,7,105,'2024-02-13'),(8,8,8,115,'2024-02-12'),(9,9,9,120,'2024-02-10'),(10,10,10,120,'2024-02-18'),(11,11,11,120,'2024-03-01'),(12,12,12,150,'2024-03-01'),(13,13,13,120,'2024-03-01'),(14,14,14,130,'2024-03-01'),(15,15,15,120,'2024-03-01'),(16,16,16,175,'2024-03-01'),(17,17,17,130,'2024-03-02'),(18,18,18,125,'2024-02-02'),(19,19,19,172,'2024-03-01'),(20,20,20,55,'2024-02-04'),(21,15,15,20,'2024-03-22'),(22,15,15,30,'2024-03-22'),(23,15,15,30,'2024-03-22'),(25,16,1,50,'2024-03-25'),(26,5,15,100,'2024-03-25'),(27,9,25,100,'2024-03-26'),(28,9,1,50,'2024-03-26'),(30,16,2,50,'2024-03-27'),(31,15,1,100,'2024-03-27'),(32,21,2,100,'2024-04-01'),(33,23,5,100,'2024-04-02'),(34,1,27,200,'2024-04-05'),(35,2,32,500,'2024-04-15');
/*!40000 ALTER TABLE `sales` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `sales_AFTER_INSERT` AFTER INSERT ON `sales` FOR EACH ROW BEGIN
    -- Update the quantity of rice variation in RiceStock table
    UPDATE ricestock
    SET Quantity = Quantity - NEW.Quantity
    WHERE VarietyID = NEW.VarietyID;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `sales_AFTER_DELETE` AFTER DELETE ON `sales` FOR EACH ROW BEGIN
    DELETE FROM customers WHERE CustomerID = OLD.CustomerID;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Temporary view structure for view `salespercustomer`
--

DROP TABLE IF EXISTS `salespercustomer`;
/*!50001 DROP VIEW IF EXISTS `salespercustomer`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `salespercustomer` AS SELECT 
 1 AS `CustomerID`,
 1 AS `CustomerName`,
 1 AS `VarietyName`,
 1 AS `PurchasePrice`,
 1 AS `TotalSalesQuantity`,
 1 AS `TotalRevenue_Profit`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `salessummary`
--

DROP TABLE IF EXISTS `salessummary`;
/*!50001 DROP VIEW IF EXISTS `salessummary`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `salessummary` AS SELECT 
 1 AS `SaleID`,
 1 AS `VarietyID`,
 1 AS `VarietyName`,
 1 AS `Price`,
 1 AS `Quantity`,
 1 AS `SaleDate`,
 1 AS `TotalRevenue`,
 1 AS `PurchasePrice`,
 1 AS `Profit`,
 1 AS `TotalRevenue_Profit`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `supplier_view`
--

DROP TABLE IF EXISTS `supplier_view`;
/*!50001 DROP VIEW IF EXISTS `supplier_view`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `supplier_view` AS SELECT 
 1 AS `SupplierID`,
 1 AS `VarietyID`,
 1 AS `SupplierName`,
 1 AS `ContactPerson`,
 1 AS `ContactNumber`,
 1 AS `VarietyName`,
 1 AS `Quantity`,
 1 AS `Price`,
 1 AS `TotalValue`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `suppliers`
--

DROP TABLE IF EXISTS `suppliers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `suppliers` (
  `SupplierID` int NOT NULL,
  `SupplierName` varchar(255) DEFAULT NULL,
  `ContactPerson` varchar(255) DEFAULT NULL,
  `ContactNumber` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`SupplierID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `suppliers`
--

LOCK TABLES `suppliers` WRITE;
/*!40000 ALTER TABLE `suppliers` DISABLE KEYS */;
INSERT INTO `suppliers` VALUES (1,'ABC Rice Supplier','John Doe','+1234567890'),(2,'XYZ Grain Co.','Jane Smith','+9876543210'),(3,'Best Rice Farms','Mike Johnson','+1112233445'),(4,'Golden Fields','Anna Lee','+5556667777'),(5,'Harvest Foods','Robert Brown','+9998887777'),(6,'Sunrise Grains','Emma White','+4443332222'),(7,'Organic Rice Producers','David Green','+7778889999'),(8,'Nature\'s Bounty Rice','Sophia Taylor','+3332221111'),(9,'Green Valley Harvest','William Davis','+6667778888'),(10,'Fresh Crops Suppliers','Olivia Turner','+2221113333'),(11,'Lariosa Prime Corporation','Jobelle Lariosa','+4632657256'),(12,'Mansion Prime Corporation','Angelle Lariosa','+4635745667'),(13,'Mansion Prime Inc','Bery Pink','+4635745667'),(14,'Inocencio Prime Inc','Pink Joseph','+6379256275'),(15,'Pink Corp','Josephine Bobly','+4632458755'),(16,'PRice Corporation','Mark Jonson','+4657645745'),(17,'Violet Corp Inc','Rachelle Sin','+6478561857'),(18,'Jon GiveSon','John Rtyruty','+3647936574'),(19,'Jekr euytr','Pink etertityr','+5646589986'),(20,'Lariosa Cooperative','Jobelle Anderson','+5178648675'),(22,'XYZ Intern Cooperation','Jobelle Lariosa','09501714500'),(25,'Jobelle Washington Coop','Jobelle Washington','091354654657'),(30,'Malanyaon Corporation','Princess Malayaon','09501714500');
/*!40000 ALTER TABLE `suppliers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `top_varietiessales`
--

DROP TABLE IF EXISTS `top_varietiessales`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `top_varietiessales` (
  `VarietyID` int DEFAULT NULL,
  `VarietyName` varchar(255) DEFAULT NULL,
  `TotalSalesQuantity` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `top_varietiessales`
--

LOCK TABLES `top_varietiessales` WRITE;
/*!40000 ALTER TABLE `top_varietiessales` DISABLE KEYS */;
INSERT INTO `top_varietiessales` VALUES (1,'Basmati',50),(2,'Jasmine',100),(3,'Long Grain White',50),(4,'Short Grain White',75),(5,'Brown Rice',25),(6,'Arborio',55),(7,'Black Rice',105),(8,'Red Rice',115),(9,'Sushi Rice',120),(10,'Wild Rice',120),(11,'Moonyfied',120),(12,'Pink Rice',150),(13,'Brown Rice',120),(14,'Black Rice',130),(15,'Chorus Rice',170),(16,'Gumamela Rice',175),(17,'Medium Grain Rice',130),(18,'Calrose Rice',125),(19,'Bhutanese Red Rice',172),(20,'Carnaroli Rice',55);
/*!40000 ALTER TABLE `top_varietiessales` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `totalricevarieties`
--

DROP TABLE IF EXISTS `totalricevarieties`;
/*!50001 DROP VIEW IF EXISTS `totalricevarieties`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `totalricevarieties` AS SELECT 
 1 AS `VarietyID`,
 1 AS `VarietyName`*/;
SET character_set_client = @saved_cs_client;

--
-- Dumping events for database 'bsit3c_edp'
--

--
-- Dumping routines for database 'bsit3c_edp'
--
/*!50003 DROP FUNCTION IF EXISTS `GetAverageRiceStockPrice` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `GetAverageRiceStockPrice`() RETURNS decimal(10,2)
    READS SQL DATA
BEGIN
	DECLARE avgPrice DECIMAL(10, 2);

    SELECT AVG(Price) INTO avgPrice
    FROM RiceStock;

    RETURN avgPrice;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetAllRiceStockQuantities` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetAllRiceStockQuantities`()
BEGIN
	 SELECT rv.VarietyName, SUM(rs.Quantity) AS TotalQuantity
    FROM RiceVarieties rv
    LEFT JOIN RiceStock rs ON rv.VarietyID = rs.VarietyID
    GROUP BY rv.VarietyID, rv.VarietyName;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetRiceStockDetails1` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetRiceStockDetails1`()
BEGIN
	SELECT
        s.SupplierName,
        rv.VarietyName,
        c.CustomerName
    FROM RiceStock rs
    INNER JOIN Suppliers s ON rs.SupplierID = s.SupplierID
    INNER JOIN RiceVarieties rv ON rs.VarietyID = rv.VarietyID
    INNER JOIN Customers c ON rs.CustomerID = c.CustomerID
    LIMIT 10;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetTotalRiceStockQuantity` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetTotalRiceStockQuantity`(IN p_VarietyID INT)
BEGIN

  SELECT SUM(Quantity) AS TotalQuantity
    FROM RiceStock
    WHERE VarietyID = p_VarietyID;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Final view structure for view ` topvarietiesbysales`
--

/*!50001 DROP VIEW IF EXISTS ` topvarietiesbysales`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW ` topvarietiesbysales` AS select `rv`.`VarietyID` AS `VarietyID`,`rv`.`VarietyName` AS `VarietyName`,sum(`s`.`Quantity`) AS `TotalSalesQuantity` from (`ricevarieties` `rv` join `sales` `s` on((`rv`.`VarietyID` = `s`.`VarietyID`))) group by `rv`.`VarietyID`,`rv`.`VarietyName` order by `TotalSalesQuantity` desc */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `prices_stock_varieties`
--

/*!50001 DROP VIEW IF EXISTS `prices_stock_varieties`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `prices_stock_varieties` AS select `rv`.`VarietyName` AS `VarietyName`,`s`.`SupplierName` AS `SupplierName`,`rs`.`Price` AS `Price` from ((((`sales` `sa` join `ricevarieties` `rv` on((`sa`.`VarietyID` = `rv`.`VarietyID`))) join `ricestock` `rs` on((`sa`.`VarietyID` = `rs`.`VarietyID`))) join `customers` `c` on((`sa`.`CustomerID` = `c`.`CustomerID`))) join `suppliers` `s` on((`rs`.`SupplierID` = `s`.`SupplierID`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `salespercustomer`
--

/*!50001 DROP VIEW IF EXISTS `salespercustomer`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `salespercustomer` AS select `c`.`CustomerID` AS `CustomerID`,`c`.`CustomerName` AS `CustomerName`,`r`.`VarietyName` AS `VarietyName`,(`rs`.`Price` + 5.0) AS `PurchasePrice`,coalesce(sum(`s`.`Quantity`),0) AS `TotalSalesQuantity`,((`rs`.`Price` + 5.0) * coalesce(sum(`s`.`Quantity`),0)) AS `TotalRevenue_Profit` from (((`customers` `c` left join `sales` `s` on((`c`.`CustomerID` = `s`.`CustomerID`))) join `ricestock` `rs` on((`s`.`VarietyID` = `rs`.`VarietyID`))) join `ricevarieties` `r` on((`s`.`VarietyID` = `r`.`VarietyID`))) group by `c`.`CustomerID`,`c`.`CustomerName`,`r`.`VarietyName`,`rs`.`Price` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `salessummary`
--

/*!50001 DROP VIEW IF EXISTS `salessummary`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `salessummary` AS select `s`.`SaleID` AS `SaleID`,`s`.`VarietyID` AS `VarietyID`,`r`.`VarietyName` AS `VarietyName`,`rs`.`Price` AS `Price`,`s`.`Quantity` AS `Quantity`,`s`.`SaleDate` AS `SaleDate`,(`rs`.`Price` * `s`.`Quantity`) AS `TotalRevenue`,(`rs`.`Price` + 5.0) AS `PurchasePrice`,(((`rs`.`Price` + 5.0) - `rs`.`Price`) * `s`.`Quantity`) AS `Profit`,((`rs`.`Price` + 5.0) * `s`.`Quantity`) AS `TotalRevenue_Profit` from ((`sales` `s` join `ricestock` `rs` on((`s`.`VarietyID` = `rs`.`VarietyID`))) join `ricevarieties` `r` on((`s`.`VarietyID` = `r`.`VarietyID`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `supplier_view`
--

/*!50001 DROP VIEW IF EXISTS `supplier_view`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `supplier_view` AS select `s`.`SupplierID` AS `SupplierID`,`rs`.`VarietyID` AS `VarietyID`,`s`.`SupplierName` AS `SupplierName`,`s`.`ContactPerson` AS `ContactPerson`,`s`.`ContactNumber` AS `ContactNumber`,`rv`.`VarietyName` AS `VarietyName`,`rs`.`Quantity` AS `Quantity`,`rs`.`Price` AS `Price`,(`rs`.`Quantity` * `rs`.`Price`) AS `TotalValue` from ((`suppliers` `s` left join `ricestock` `rs` on((`s`.`SupplierID` = `rs`.`SupplierID`))) left join `ricevarieties` `rv` on((`rs`.`VarietyID` = `rv`.`VarietyID`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `totalricevarieties`
--

/*!50001 DROP VIEW IF EXISTS `totalricevarieties`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `totalricevarieties` AS select `ricevarieties`.`VarietyID` AS `VarietyID`,`ricevarieties`.`VarietyName` AS `VarietyName` from `ricevarieties` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-09-18 17:03:16
