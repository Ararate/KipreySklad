using KipreySklad.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KipreySklad.Classes
{
    class DBPlaces
    {
        static public int lastId;
        /// <summary>
        /// Получение таблицы places для combobox
        /// </summary>
        /// <param name="and"></param>
        /// <param name="perBegin"></param>
        /// <param name="perEnd"></param>
        /// <returns></returns>
        static public DataTable Combo
            (string and, string perBegin, string perEnd)
        {
            DataTable dtCombo = new DataTable();
            try
            {
                DataBase.msCommand.CommandText =
                    $"SELECT distinct places.idPlace, " +
                    $"CONCAT(places.idPlace,' (',places.placeX,'x', " +
                    $"places.placeY,'x',places.placeZ, ')" +
                    $" ',types.type) as size " +
                    $"FROM places,storages,types " +
                    $"WHERE places.idStorage=storages.idStorage " +
                    $"and storages.codeType = types.codeType " +
                    $"and places.idPlace not in (" +
                    $"select storaging.idPlace " +
                    $"from storaging " +
                    $"where ( storaging.perBegin <= '{perEnd}' " +
                    $"AND storaging.perEnd >= '{perBegin}') and " +
                    $"storaging.idStoraging <> '{DBStoraging.lastId}') " +
                    $"{and} ";
                DataBase.msCommand.ExecuteNonQuery();
                DataBase.msDataAdapter.Fill(dtCombo);
                return dtCombo;
            }
            catch
            {
                MessageBox.Show("Произошла ошибка во" +
                " время загрузки", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dtCombo;
            }
        }

        /// <summary>
        /// Получение таблицы places
        /// </summary>
        static public DataTable Get(string and)
        {
            DataTable dtPlaces = new DataTable();
            try
            {
                DataBase.msCommand.CommandText =
                    $"SELECT places.cost, places.idPlace, " +
                    $"storages.idStorage," +
                    $" places.placeX,places.placeY" +
                    $",places.placeZ,storages.adress FROM " +
                    $"places,storages WHERE places.idStorage=" +
                    $"storages.idStorage {and};";
                DataBase.msCommand.ExecuteNonQuery();
                DataBase.msDataAdapter.Fill(dtPlaces);
                return dtPlaces;
            }
            catch
            {
                MessageBox.Show("Произошла ошибка во" +
                " время загрузки", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dtPlaces;
            }
        }

        /// <summary>
        /// Добавление записи в таблицу places
        /// </summary>
        /// <param name="idStorage"></param>
        /// <param name="placeX"></param>
        /// <param name="placeY"></param>
        /// <param name="placeZ"></param>
        /// <param name="cost"></param>
        static public void Add(string idStorage, string placeX, 
            string placeY, string placeZ, string cost)
        {
            try
            {
                DataBase.msCommand.CommandText = $"INSERT INTO `sklad`" +
                    $".`places` (`idStorage`, `placeX`, " +
                    $"`placeY`, `placeZ`, `cost`)" +
                    $" VALUES ('{idStorage}', '{placeX}', " +
                    $"'{placeY}', '{placeZ}', '{cost}');";
                DataBase.msCommand.ExecuteNonQuery();

                DataBase.msCommand.CommandText = $"INSERT INTO `sklad`." +
                    $"`pricehistory` (`price`, `idPlace`, `priceDate`)" +
                    $" VALUES ('{cost}', '{lastId}', '{DateTime.Today.Year}-" +
                    $"{DateTime.Today.Month}-{DateTime.Today.Day}');";
                DataBase.msCommand.ExecuteNonQuery();
                MessageBox.Show("Данные успешно добавлены", "",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Произошла ошибка во" +
                    " время добавления записи", "Error",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Удаление записи из таблицы places
        /// </summary>
        static public bool Delete()
        {
            try
            {
                DataBase.msCommand.CommandText = $"DELETE " +
                    $"FROM pricehistory WHERE (`idPlace` = '{lastId}');" +
                    $"DELETE FROM " +
                    $"`sklad`.`places` WHERE (`idPlace` = '{lastId}');";
                DataBase.msCommand.ExecuteNonQuery();
                MessageBox.Show("Данные удалены", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch
            {
                return false;
            }

        }

        /// <summary>
        /// Редактирование записи в таблице places
        /// </summary>
        /// <param name="idStorage"></param>
        /// <param name="placeX"></param>
        /// <param name="placeY"></param>
        /// <param name="placeZ"></param>
        /// <param name="cost"></param>
        static public void Edit(string idStorage, string placeX,
            string placeY, string placeZ, string cost)
        {
            try
            {
                DataBase.msCommand.CommandText = $"UPDATE `sklad`.`places`" +
                    $" SET `idStorage` = '{idStorage}', " +
                    $"`placeX` = '{placeX}', `cost` = '{cost}'," +
                    $"`placeY` = '{placeY}', `placeZ` = '{placeZ}' " +
                    $"WHERE (`idPlace` = '{lastId}');";
                DataBase.msCommand.ExecuteNonQuery();
                DataBase.msCommand.CommandText = $"UPDATE `sklad`." +
                    $"`pricehistory` SET `price` = '{cost}' WHERE " +
                    $"(`idPlace` = '{lastId}') and (priceDate = " +
                    $"'{DateTime.Today.Year}-{DateTime.Today.Month}" +
                    $"-{DateTime.Today.Day}');";
                if (DataBase.msCommand.ExecuteNonQuery() == 0)
                {
                    DataBase.msCommand.CommandText = $"INSERT INTO `sklad`." +
                    $"`pricehistory` (`price`, `idPlace`, `priceDate`)" +
                    $" VALUES ('{cost}', '{lastId}', '{DateTime.Today.Year}" +
                    $"-{DateTime.Today.Month}-{DateTime.Today.Day}');";
                    DataBase.msCommand.ExecuteNonQuery();
                }

                MessageBox.Show("Данные успешно изменены", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Произошла ошибка во" +
                    " время редактирования данных", "Error",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Проверяет, занято ли сегодня место
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        static public bool IsNowUsed(string id)
        {
            try
            {
                DataBase.msCommand.CommandText =
                    $@"SELECT * from storaging where idPlace = "+
                    $"'{id}' and storaging.perBegin < '{DateTime.Today.Year}" +
                    $"-{DateTime.Today.Month}-{DateTime.Today.Day}' and " +
                    $"storaging.perEnd > '{DateTime.Today.Year}" +
                    $"-{DateTime.Today.Month}-{DateTime.Today.Day}';";
                Object result = DataBase.msCommand.ExecuteScalar();
                return (result != null);
            }
            catch
            {
                MessageBox.Show("Произошла ошибка", "Error",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}
