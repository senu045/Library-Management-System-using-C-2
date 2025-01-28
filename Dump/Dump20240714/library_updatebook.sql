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
-- Table structure for table `updatebook`
--

DROP TABLE IF EXISTS `updatebook`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `updatebook` (
  `bid` int NOT NULL AUTO_INCREMENT,
  `bName` varchar(256) DEFAULT NULL,
  `bAuthor` varchar(256) DEFAULT NULL,
  `bPubl` varchar(256) DEFAULT NULL,
  `bDate` varchar(45) DEFAULT NULL,
  `bPrice` decimal(20,0) DEFAULT NULL,
  `bQuan` decimal(20,0) DEFAULT NULL,
  PRIMARY KEY (`bid`)
) ENGINE=InnoDB AUTO_INCREMENT=54 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `updatebook`
--

LOCK TABLES `updatebook` WRITE;
/*!40000 ALTER TABLE `updatebook` DISABLE KEYS */;
INSERT INTO `updatebook` VALUES (1,'The Great Gatsby','F. Scott Fitzgerald','Scribner','1925-04-10',1500,50),(2,'To Kill a Mockingbird','Harper Lee','J.B. Lippincott & Co.','1960-07-11',1800,39),(3,'1984','George Orwell','Secker & Warburg','1949-06-08',2000,35),(4,'Pride and Prejudice','Jane Austen','T. Egerton','1813-01-28',1600,45),(5,'The Catcher in the Rye','J.D. Salinger','Little, Brown and Company','1951-07-16',1700,50),(6,'The Hobbit','J.R.R. Tolkien','George Allen & Unwin','1937-09-21',1900,60),(7,'Fahrenheit 451','Ray Bradbury','Ballantine Books','1953-10-19',1400,55),(8,'Jane Eyre','Charlotte Brontë','Smith, Elder & Co.','1847-10-16',1300,65),(9,'Moby-Dick','Herman Melville','Harper & Brothers','1851-10-18',2000,30),(10,'War and Peace','Leo Tolstoy','The Russian Messenger','1869-01-01',2500,20),(11,'Crime and Punishment','Fyodor Dostoevsky','The Russian Messenger','1866-01-01',1800,40),(12,'Brave New World','Aldous Huxley','Chatto & Windus','1932-08-30',1600,50),(13,'Wuthering Heights','Emily Brontë','Thomas Cautley Newby','1847-12-01',1400,55),(14,'The Odyssey','Homer','Various','800-01-01 BC',1200,70),(15,'The Iliad','Homer','Various','750-01-01 BC',1200,70),(16,'Great Expectations','Charles Dickens','Chapman & Hall','1861-01-01',1500,60),(17,'Little Women','Louisa May Alcott','Roberts Brothers','1868-09-30',1700,45),(18,'Frankenstein','Mary Shelley','Lackington, Hughes, Harding, Mavor & Jones','1818-01-01',1300,65),(19,'Dracula','Bram Stoker','Archibald Constable and Company','1897-05-26',1600,50),(20,'The Adventures of Huckleberry Finn','Mark Twain','Chatto & Windus / Charles L. Webster And Company','1884-12-10',1500,55),(21,'The Grapes of Wrath','John Steinbeck','The Viking Press-James Lloyd','1939-04-14',1800,40),(22,'Alice\'s Adventures in Wonderland','Lewis Carroll','Macmillan','1865-11-26',1400,60),(23,'The Lord of the Rings','J.R.R. Tolkien','George Allen & Unwin','1954-07-29',3000,20),(24,'Anna Karenina','Leo Tolstoy','The Russian Messenger','1878-01-01',2000,30),(25,'Don Quixote','Miguel de Cervantes','Francisco de Robles','1605-01-01',2500,24),(26,'The Picture of Dorian Gray','Oscar Wilde','Lippincott\'s Monthly Magazine','1890-06-20',1400,50),(27,'The Count of Monte Cristo','Alexandre Dumas','Émile Deschamps','1844-01-01',2200,30),(28,'Ulysses','James Joyce','Sylvia Beach','1922-02-02',2400,19),(29,'The Brothers Karamazov','Fyodor Dostoevsky','The Russian Messenger','1880-01-01',2000,30),(30,'Les Misérables','Victor Hugo','A. Lacroix, Verboeckhoven & Cie.','1862-01-01',2300,25),(31,'A Tale of Two Cities','Charles Dickens','Chapman & Hall','1859-04-30',1700,45),(32,'Heart of Darkness','Joseph Conrad','Blackwood\'s Magazine','1899-01-01',1400,50),(33,'Sense and Sensibility','Jane Austen','Thomas Egerton','1811-01-01',1600,45),(34,'David Copperfield','Charles Dickens','Bradbury & Evans','1850-01-01',1700,40),(35,'Madame Bovary','Gustave Flaubert','Revue de Paris','1856-01-01',1500,50),(36,'The Scarlet Letter','Nathaniel Hawthorne','Ticknor, Reed & Fields','1850-03-16',1300,55),(37,'One Hundred Years of Solitude','Gabriel Garcia Marquez','Harper & Row','1967-06-05',2000,35),(38,'The Stranger','Albert Camus','Gallimard','1942-01-01',1400,60),(39,'Catch-22','Joseph Heller','Simon & Schuster','1961-11-10',1800,40),(40,'The Sound and the Fury','William Faulkner','Jonathan Cape and Harrison Smith','1929-10-07',1700,50),(41,'On the Road','Jack Kerouac','Viking Press','1957-09-05',1600,45),(42,'Gone with the Wind','Margaret Mitchell','Macmillan Publishers','1936-06-30',1900,35),(43,'Slaughterhouse-Five','Kurt Vonnegut','Delacorte','1969-03-31',1500,50),(44,'The Sun Also Rises','Ernest Hemingway','Scribner\'s','1926-10-22',1600,40),(45,'Beloved','Toni Morrison','Alfred A. Knopf','1987-09-16',2000,30),(46,'The Divine Comedy','Dante Alighieri','Various','1320-01-01',2500,20),(47,'Moby-Dick','Herman Melville','Harper & Brothers','1851-10-18',2000,30),(48,'The Catcher in the Rye','J.D. Salinger','Little, Brown and Company','1951-07-16',1700,50),(49,'The Hobbit','J.R.R. Tolkien','George Allen & Unwin','1937-09-21',1900,60),(50,'Fahrenheit 451','Ray Bradbury','Ballantine Books','1953-10-19',1400,55),(52,'java fundermentals','CM','sd','Sunday, December 27, 1959',23452,35);
/*!40000 ALTER TABLE `updatebook` ENABLE KEYS */;
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
