-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: localhost    Database: library
-- ------------------------------------------------------
-- Server version	8.0.34

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
-- Table structure for table `newstudent`
--

DROP TABLE IF EXISTS `newstudent`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `newstudent` (
  `stuid` varchar(20) NOT NULL,
  `sname` varchar(250) NOT NULL,
  `faculty` varchar(250) NOT NULL,
  `contactNo` varchar(250) NOT NULL,
  `email` varchar(250) NOT NULL,
  PRIMARY KEY (`stuid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `newstudent`
--

LOCK TABLES `newstudent` WRITE;
/*!40000 ALTER TABLE `newstudent` DISABLE KEYS */;
INSERT INTO `newstudent` VALUES ('CS/2020/022','Piyumi Nadeeralk','Faculty of Computing and Technology','077-8967899','NadeeraDlpStu@gamil.com'),('CS/2020/038','Mihitha Wanniarachchi','Computing and Technology','077-678364872','Stu@mihitha@gamil.com'),('CS/2020/041','Tharusha Kavindi','Faculty of Computing and Technology    ','079-98394893','wpt-cs2041kln.ac.lk'),('CS/2020/044','Dehemi Weerakoon','Computing and Technology','077-8936489','studehemi@gamil.com'),('CT/2019/008','senumi himaya','computing and technology','077-7865906','yash@gmail.com'),('MC/2021/042','Mashi Feranado','Faculty of Medicine','077-67896378','Mashi-mcstu.kln.ac.lk');
/*!40000 ALTER TABLE `newstudent` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-07-14 14:26:03
