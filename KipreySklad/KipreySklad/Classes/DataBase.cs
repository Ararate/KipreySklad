using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace KipreySklad.Classes
{
    static class DataBase
    {
        static MySqlConnection myConnect;
        
        static public MySqlCommand msCommand;
        static public DataTable auth = new DataTable();
        static public string fio;
        static public MySqlDataAdapter msDataAdapter;
        static public int userId, role;
        static private string[,] buf = { { "clients",
                "dogovori", "places", "storages", "storaging",
                "types", "uridclients", "users" } , { "",
                "", "", "", "",
                "", "", "" }};

        /// <summary>
        /// Соединение с БД
        /// </summary>
        /// <returns></returns>
        static public bool Connect()
        {
            try
            {
                StreamReader sr = new StreamReader("ServerData.txt");
                string DataSource = sr.ReadLine();
                string User = sr.ReadLine();
                string Password = sr.ReadLine();
                string Charset = sr.ReadLine();
                myConnect = new MySqlConnection
                    ($@"DataSource = {DataSource}; " +
                 $@"User = {User}; Password = {Password}; Charset = {Charset};");
                sr.Close();
                myConnect.Open();
                msCommand = new MySqlCommand
                {
                    Connection = myConnect
                };
                msDataAdapter = new MySqlDataAdapter(msCommand);
                msCommand.CommandText = "USE sklad;";
                msCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Unable to connect" +
                    " to any of the specified MySQL hosts"))
                {
                    MessageBox.Show
                        ($"Нет соединения с сервером.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (ex.Message.Contains("Unknown database 'sklad'"))
                {
                    msCommand = new MySqlCommand
                    {
                        Connection = myConnect
                    };
                    msDataAdapter = new MySqlDataAdapter(msCommand);
                    MySqlBackup msBackup = new MySqlBackup(msCommand);
                    msBackup.ImportFromString($@"-- MySqlBackup.NET 2.3.6
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

INSERT INTO `sklad`.`users` (`login`, `password`, `codeRole`, `fio`, `phone`, `isDeleted`) VALUES ('dir', md5('1'), '3', 'Имя Фамилия Отчество', '+7 (000) 000 00-00', '0');
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



/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;


-- Dump completed on 2022-06-07 16:17:50
-- Total time: 0:0:0:0:114 (d:h:m:s:ms)
");
                    MessageBox.Show
                        ($"Не обнаружено никаких данных," +
                        $" создана учётная запись \n" +
                        $"Логин: dir \n" +
                        $"Пароль: 1", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        /// <summary>
        /// Авторизация
        /// </summary>
        /// <param name="Login"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        static public bool Authorization(string Login, string Password)
        {
            try
            {
                auth.Clear();
                StreamWriter sw = new StreamWriter("Log.txt", true);
                msCommand.CommandText = @"SELECT s_roles.role, users.fio,
				users.codeRole,users.idUser
				FROM users, s_roles
				WHERE Login = '"
                    + Login + "' AND Password = MD5('" + Password + "') " +
                    "AND users.codeRole = s_roles.codeRole and isDeleted = '0';";
                Object result = msCommand.ExecuteScalar();
                if (result != null)
                {

                    msDataAdapter.Fill(auth);
                    sw.WriteLine($"{DateTime.Now} " +
                        $"{auth.Rows[0].Field<string>("role")} " +
                        $"{auth.Rows[0].Field<string>("fio")}");
                    sw.Close();
                    role = auth.Rows[0].
                        Field<int>("codeRole");
                    fio = auth.Rows[0].Field<string>("fio");
                    userId = auth.Rows[0].Field<int>("idUser");
                    return true;
                }

                //if ((Login == "admin") && (Password == "admin"))
                //{
                //	role = 0;
                //	sw.Close();
                //	fio = "admin";
                //	return true;
                //}

                else
                {
                    MessageBox.Show("Неверный пароль или логин," +
                        " повторите попытку", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sw.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                role = 0;
                MessageBox.Show($"Ошибка при авторизации... \n {ex.Message}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        /// <summary>
        /// Экспорт БД
        /// </summary>
        /// <returns></returns>
        static public bool Export()
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.DefaultExt = "sql";
                sfd.Filter = "SQL Text File (.sql)|*.sql";
                MySqlBackup msBackup = new MySqlBackup(msCommand);
                if (sfd.ShowDialog() != DialogResult.OK)
                    return false;
                File.Create(sfd.FileName).Close();
                msBackup.ExportToFile(sfd.FileName);
                MessageBox.Show("Резервная копия создана", "",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch
            {
                MessageBox.Show("Ошибка во время экспортирования", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        /// <summary>
        /// Импорт БД
        /// </summary>
        /// <returns></returns>
        static public bool Import()
        {
            try
            {
                MySqlBackup msBackup = new MySqlBackup(msCommand);
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "SQL Text File (.sql)|*.sql";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if (!File.ReadLines(ofd.FileName).
                        Any(line => line.Contains("pricehistory")) ||
                        !File.ReadLines(ofd.FileName).
                        Any(line => line.Contains("uridclients")) ||
                        !File.ReadLines(ofd.FileName).
                        Any(line => line.Contains("storaging")))
                    {
                        MessageBox.Show("Выбран неверный файл", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    msBackup.ImportFromFile(ofd.FileName);
                }
                else
                {
                    return false;
                }
                MessageBox.Show("Резервная копия загружена", "",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch
            {
                MessageBox.Show("Ошибка во время импортирования", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        /// <summary>
        /// Выгрузка таблицы из буфера
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        static public bool Import(string table)
        {
            try
            {
                MySqlBackup msBackup = new MySqlBackup(msCommand);
                int aaaaa = CoordinatesOf(buf, table);
                msBackup.ImportFromString(buf[1, CoordinatesOf(buf, table)]);
                return true;
            }
            catch
            {
                MessageBox.Show("Ошибка во время импортирования", "",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        /// <summary>
        /// Поиск элемента в двумерной матрице
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="matrix"></param>
        /// <param name="value"></param>
        /// <returns></returns>
            public static int CoordinatesOf(string[,] matrix, string value)
            {

                for (int i = 0; i < 8; i++)
                {
                        string a = matrix[0, i];
                        if (matrix[0, i] == value)
                            return i;
                }
                return -1;
            }
            /// <summary>
            /// Сохранение таблицы в буфер
            /// </summary>
            /// <param name="table"></param>
            /// <returns></returns>
            static public bool Export(string table)
            {
            try
            {
                MySqlBackup msBackup = new MySqlBackup(msCommand);
                List<string> li = new List<string> { table };
                if (table == "dogovori")
                    li.Add("storaging");
                msBackup.ExportInfo.TablesToBeExportedList = li;

                int aaaaa = CoordinatesOf(buf, table);
                buf[1, CoordinatesOf(buf, table)] = msBackup.ExportToString();
                return true;
            }
            catch
            {
                MessageBox.Show("Ошибка во время экспортирования", "",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        }
    }
