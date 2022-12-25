-- MySqlBackup.NET 2.3.6
-- Dump Time: 2022-06-07 16:17:50
-- --------------------------------------
-- Server version 8.0.24 MySQL Community Server - GPL


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- 
-- Definition of clients
-- 
CREATE DATABASE IF NOT EXISTS sklad;
USE sklad;
DROP TABLE IF EXISTS `clients`;
CREATE TABLE IF NOT EXISTS `clients` (
  `idClient` int NOT NULL AUTO_INCREMENT,
  `fio` varchar(45) DEFAULT NULL,
  `phone` varchar(45) DEFAULT NULL,
  `passport` varchar(12) DEFAULT NULL,
  PRIMARY KEY (`idClient`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- 
-- Dumping data for table clients
-- 

/*!40000 ALTER TABLE `clients` DISABLE KEYS */;
INSERT INTO `clients`(`idClient`,`fio`,`phone`,`passport`) VALUES(1,'Екимов Всеволод Геннадиевич','+7 (905) 539-12-97','6736 6737'),(2,'Эльдарович Аверян Бородин','+7 (951) 819-29-91','6643 645463'),(3,'Ржевская Любава Сергеевна','+7 (917) 742-18-25','4234 323232'),(4,'Тверская Елизавета Дмитриевна','+7 (911) 269-21-85','4233 323232'),(8,'Канаев Мокей Николаевич','+7 (981) 711-39-42','3763 567763'),(9,'Якубович Муза Даниловна','+7 (333) 333-44-44','5234 534523'),(15,'Лебедев Павел Андреевич','+7 (524) 534-54-44','2345 324523'),(18,'Латышев Евгений Петрович','+7 (343) 434-43-43','4334 434343');
/*!40000 ALTER TABLE `clients` ENABLE KEYS */;

-- 
-- Definition of s_roles
-- 

DROP TABLE IF EXISTS `s_roles`;
CREATE TABLE IF NOT EXISTS `s_roles` (
  `codeRole` int NOT NULL AUTO_INCREMENT,
  `role` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`codeRole`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- 
-- Dumping data for table s_roles
-- 

/*!40000 ALTER TABLE `s_roles` DISABLE KEYS */;
INSERT INTO `s_roles`(`codeRole`,`role`) VALUES(1,'Менеджер'),(2,'Кладовщик'),(3,'Директор');
/*!40000 ALTER TABLE `s_roles` ENABLE KEYS */;

-- 
-- Definition of types
-- 

DROP TABLE IF EXISTS `types`;
CREATE TABLE IF NOT EXISTS `types` (
  `codeType` int NOT NULL AUTO_INCREMENT,
  `type` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`codeType`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- 
-- Dumping data for table types
-- 

/*!40000 ALTER TABLE `types` DISABLE KEYS */;
INSERT INTO `types`(`codeType`,`type`) VALUES(1,'Хрупкий'),(2,'Опасный'),(3,'Насыпной '),(4,'Скоропортящийся ');
/*!40000 ALTER TABLE `types` ENABLE KEYS */;

-- 
-- Definition of storages
-- 

DROP TABLE IF EXISTS `storages`;
CREATE TABLE IF NOT EXISTS `storages` (
  `idStorage` int NOT NULL AUTO_INCREMENT,
  `codeType` int NOT NULL,
  `adress` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idStorage`),
  KEY `codeType_idx` (`codeType`),
  CONSTRAINT `codeType` FOREIGN KEY (`codeType`) REFERENCES `types` (`codeType`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- 
-- Dumping data for table storages
-- 

/*!40000 ALTER TABLE `storages` DISABLE KEYS */;
INSERT INTO `storages`(`idStorage`,`codeType`,`adress`) VALUES(1,1,'ул. Военного городка тер, дом 128'),(2,2,'ул. Жидков пер, дом 124'),(3,3,'ул. Подбельского 7-й проезд, дом 116'),(10,1,'ул. Военного городка'),(11,1,' ул. Набережная (Кунцево), дом 93'),(14,1,'ул. Подбельского 7-й');
/*!40000 ALTER TABLE `storages` ENABLE KEYS */;

-- 
-- Definition of places
-- 

DROP TABLE IF EXISTS `places`;
CREATE TABLE IF NOT EXISTS `places` (
  `idPlace` int NOT NULL AUTO_INCREMENT,
  `idStorage` int NOT NULL,
  `placeX` int DEFAULT NULL,
  `placeY` int DEFAULT NULL,
  `placeZ` int DEFAULT NULL,
  `cost` int DEFAULT NULL,
  PRIMARY KEY (`idPlace`),
  KEY `idStorage_idx` (`idStorage`),
  CONSTRAINT `idStorage` FOREIGN KEY (`idStorage`) REFERENCES `storages` (`idStorage`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- 
-- Dumping data for table places
-- 

/*!40000 ALTER TABLE `places` DISABLE KEYS */;
INSERT INTO `places`(`idPlace`,`idStorage`,`placeX`,`placeY`,`placeZ`,`cost`) VALUES(2,1,30,45,24,800),(3,2,23,22,66,790),(4,3,666,33,77,560),(7,1,44,44,44,670),(14,14,77,77,77,450);
/*!40000 ALTER TABLE `places` ENABLE KEYS */;

-- 
-- Definition of pricehistory
-- 

DROP TABLE IF EXISTS `pricehistory`;
CREATE TABLE IF NOT EXISTS `pricehistory` (
  `price` int DEFAULT NULL,
  `idPlace` int NOT NULL,
  `priceDate` date DEFAULT NULL,
  KEY `idPlace_idx` (`idPlace`),
  KEY `idPlace_idxx` (`idPlace`),
  CONSTRAINT `idPlace1` FOREIGN KEY (`idPlace`) REFERENCES `places` (`idPlace`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- 
-- Dumping data for table pricehistory
-- 

/*!40000 ALTER TABLE `pricehistory` DISABLE KEYS */;
INSERT INTO `pricehistory`(`price`,`idPlace`,`priceDate`) VALUES(1,7,'2023-01-01 00:00:00'),(1000,7,'2024-01-01 00:00:00'),(666,7,'2022-01-01 00:00:00'),(12,2,'2022-05-06 00:00:00'),(810,2,'2022-05-16 00:00:00'),(790,3,'2022-05-16 00:00:00'),(560,4,'2022-05-16 00:00:00'),(450,14,'2022-05-16 00:00:00'),(670,7,'2022-05-16 00:00:00');
/*!40000 ALTER TABLE `pricehistory` ENABLE KEYS */;

-- 
-- Definition of storaging
-- 

DROP TABLE IF EXISTS `storaging`;
CREATE TABLE IF NOT EXISTS `storaging` (
  `idStoraging` int NOT NULL AUTO_INCREMENT,
  `idDogovor` int NOT NULL,
  `idPlace` int NOT NULL,
  `weight` int DEFAULT NULL,
  `storeCost` int DEFAULT NULL,
  `cargoX` int DEFAULT NULL,
  `cargoY` int DEFAULT NULL,
  `cargoZ` int DEFAULT NULL,
  `desc` varchar(90) DEFAULT NULL,
  `perBegin` date DEFAULT NULL,
  `perEnd` date DEFAULT NULL,
  PRIMARY KEY (`idStoraging`),
  KEY `idDogovor_idx` (`idDogovor`),
  KEY `idPlace_idx` (`idPlace`),
  CONSTRAINT `idDogovor` FOREIGN KEY (`idDogovor`) REFERENCES `dogovori` (`idDogovor`),
  CONSTRAINT `idPlace` FOREIGN KEY (`idPlace`) REFERENCES `places` (`idPlace`)
) ENGINE=InnoDB AUTO_INCREMENT=99 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- 
-- Dumping data for table storaging
-- 

/*!40000 ALTER TABLE `storaging` DISABLE KEYS */;
INSERT INTO `storaging`(`idStoraging`,`idDogovor`,`idPlace`,`weight`,`storeCost`,`cargoX`,`cargoY`,`cargoZ`,`desc`,`perBegin`,`perEnd`) VALUES(87,12,2,1,1620,1,1,1,'12','2022-04-14 00:00:00','2022-04-15 00:00:00'),(91,27,7,12,39530,12,12,21,'12','2022-05-17 00:00:00','2022-07-14 00:00:00'),(92,27,7,12,1,12,12,12,'11','2023-01-06 00:00:00','2023-01-06 00:00:00'),(97,32,2,12,12960,12,12,12,'12','2022-06-07 00:00:00','2022-06-22 00:00:00'),(98,32,2,12,2430,12,12,12,'12','2022-06-24 00:00:00','2022-06-26 00:00:00');
/*!40000 ALTER TABLE `storaging` ENABLE KEYS */;

-- 
-- Definition of uridclients
-- 

DROP TABLE IF EXISTS `uridclients`;
CREATE TABLE IF NOT EXISTS `uridclients` (
  `okpo` varchar(45) NOT NULL,
  `urArdes` varchar(90) DEFAULT NULL,
  `directorFio` varchar(45) DEFAULT NULL,
  `firmPhone` varchar(45) DEFAULT NULL,
  `firmName` varchar(45) DEFAULT NULL,
  `bik` varchar(45) DEFAULT NULL,
  `inn` varchar(45) DEFAULT NULL,
  `bank` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`okpo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- 
-- Dumping data for table uridclients
-- 

/*!40000 ALTER TABLE `uridclients` DISABLE KEYS */;
INSERT INTO `uridclients`(`okpo`,`urArdes`,`directorFio`,`firmPhone`,`firmName`,`bik`,`inn`,`bank`) VALUES('01348195',' г. Маяковское, ул. Кубинка, дом 103','Виноградов Амадеус Святославович','+7 (939) 020 82 63','Стрекоза','238875679','023857239570','Сбербанк'),('01578992','673008, г. Линево, ул. Ангелов пер, дом 82','Маслова Римма Иосифовна','+7 (982) 288 53 81','Грек','146885689','235972365899','Сбербанк'),('01957593','368730, г. Тигиль, ул. Тупиковая, дом 49','Братиславская Амина Яковлевна','+7 (432) 424 23 33','Янтарь','378076743','109812309750','Сбербанк'),('09245879',' г. Южноуральск, ул. Норильская, дом 101','Тихомирова Инга Юрьевна','+7 ( 31) 331 31 21','Сартанау','896265784','925757579320','Сбербанк'),('12093798','301543, г. Кадом, ул. Цандера, дом 37','ааааа аааа ааааа','+7 (432) 334-23-44','Ализар','444444444','019385717578','Сбербанк'),('25635464','г. Фершампенуаз, ул. Псковская, дом 160','Галицын Устин Валентинович','+7 (985) 981 27 76','Сартана','256729238','928928345687','Тинькофф');
/*!40000 ALTER TABLE `uridclients` ENABLE KEYS */;

-- 
-- Definition of users
-- 

DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `idUser` int NOT NULL AUTO_INCREMENT,
  `login` varchar(45) DEFAULT NULL,
  `password` varchar(45) DEFAULT NULL,
  `codeRole` int NOT NULL,
  `fio` varchar(45) DEFAULT NULL,
  `phone` varchar(45) DEFAULT NULL,
  `isDeleted` int DEFAULT NULL,
  PRIMARY KEY (`idUser`),
  KEY `codeRole_idx` (`codeRole`),
  CONSTRAINT `codeRole` FOREIGN KEY (`codeRole`) REFERENCES `s_roles` (`codeRole`)
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- 
-- Dumping data for table users
-- 

/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users`(`idUser`,`login`,`password`,`codeRole`,`fio`,`phone`,`isDeleted`) VALUES(1,'IzabellaSoloveva829','c2b04df7d265189375f7064a82782c61',1,'Соловьева Изабелла Петровна','+7 (937) 692-47-86',0),(2,'ProhorChernyshov312','3c2d661ecbb0c74159ab2e8ab24e7f7a',1,'Чернышов Прохор Миронович','+7 (976) 260-62-27',0),(3,'AfinogenArtimovich188','1a8c7e71928f0118b0a739aa8e4a0f6b',1,'Артимович Афиноген Антонович','+7 (965) 415-90-90',0),(4,'PlatonLenin817','7abd187711f7b60aadef021ceec933e5',2,'Ленин Платон Константинович','+7 (969) 367-30-29',0),(6,'ValeryanBartel956','c4ca4238a0b923820dcc509a6f75849b',3,'Бартель Валерьян Тимурович','+7 (978) 255-66-66',0),(23,'уууу','c4ca4238a0b923820dcc509a6f75849b',1,'Уууу Уууу Уууу','+7 (323) 233-23-23',1),(24,'wewe','c4ca4238a0b923820dcc509a6f75849b',1,'Wewee Wewe Weewee','+7 (323) 432-24-42',1);
/*!40000 ALTER TABLE `users` ENABLE KEYS */;

-- 
-- Definition of dogovori
-- 

DROP TABLE IF EXISTS `dogovori`;
CREATE TABLE IF NOT EXISTS `dogovori` (
  `idDogovor` int NOT NULL AUTO_INCREMENT,
  `idUser` int NOT NULL,
  `idClient` int NOT NULL,
  `dataBegin` date DEFAULT NULL,
  `dataEnd` date DEFAULT NULL,
  `entity` int DEFAULT NULL,
  PRIMARY KEY (`idDogovor`),
  KEY `idUser_idx` (`idUser`),
  CONSTRAINT `idUser` FOREIGN KEY (`idUser`) REFERENCES `users` (`idUser`)
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- 
-- Dumping data for table dogovori
-- 

/*!40000 ALTER TABLE `dogovori` DISABLE KEYS */;
INSERT INTO `dogovori`(`idDogovor`,`idUser`,`idClient`,`dataBegin`,`dataEnd`,`entity`) VALUES(1,1,1348195,'2022-04-14 00:00:00','2022-05-20 00:00:00',1),(3,3,3,'2022-01-10 00:00:00','2022-12-10 00:00:00',0),(5,1,1957593,'2022-12-10 00:00:00','2023-12-10 00:00:00',1),(7,3,12093798,'2019-10-10 00:00:00','2019-12-10 00:00:00',1),(12,1,1,'2022-04-14 00:00:00','2022-12-02 00:00:00',0),(15,1,8,'2022-05-06 00:00:00','2023-02-01 00:00:00',0),(19,1,1,'2024-01-31 00:00:00','2024-07-18 00:00:00',0),(26,2,9,'2022-05-10 00:00:00','2022-05-24 00:00:00',0),(27,2,1,'2022-05-17 00:00:00','2029-03-01 00:00:00',0),(32,2,1348195,'2022-06-07 00:00:00','2022-07-02 00:00:00',1);
/*!40000 ALTER TABLE `dogovori` ENABLE KEYS */;


/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;


-- Dump completed on 2022-06-07 16:17:50
-- Total time: 0:0:0:0:114 (d:h:m:s:ms)
