using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KipreySklad.Classes
{
    class DBStoraging
    {
        static public int lastId;
        /// <summary>
        /// Получение таблицы storaging
        /// </summary>
        /// <param name="and"></param>
        static public DataTable Get(string and)
        {
            DataTable dtStoraging = new DataTable();
            try
            {
                dtStoraging.Clear();
                DataBase.msCommand.CommandText =
                    "SELECT storaging.perBegin, storaging.perEnd," +
                    " storages.idStorage, CONCAT(Storaging.cargoX,'x'," +
                    "Storaging.cargoY,'x',Storaging.cargoZ)" +
                    " as Размер, Storaging.weight,Storaging.IdStoraging, " +
                    "Storaging.IdDogovor," +
                    " Storaging.storeCost, " +
                    "Storaging.cargoX,Storaging.cargoY,Storaging.cargoZ, " +
                    "dogovori.dataBegin,dogovori.dataEnd," +
                    " places.idPlace, storages.adress, Storaging.desc " +
                    "from storaging,places,storages,dogovori " +
                    "where (storaging.idPlace = places.idPlace) " +
                    $"and (places.idStorage = storages.idStorage)" +
                    $"and (dogovori.idDogovor = storaging.idDogovor) {and};";
                DataBase.msCommand.ExecuteNonQuery();
                DataBase.msDataAdapter.Fill(dtStoraging);
                return dtStoraging;
            }
            catch
            {
                MessageBox.Show("Произошла ошибка во" +
                   " время загрузки", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dtStoraging;
            }
        }

        /// <summary>
        /// Добавление записи в таблицу Storaging
        /// </summary>
        /// <param name="idDogovor"></param>
        /// <param name="idPlace"></param>
        /// <param name="cargoX"></param>
        /// <param name="cargoY"></param>
        /// <param name="cargoZ"></param>
        /// <param name="weight"></param>
        /// <param name="desc"></param>
        /// <param name="perBegin"></param>
        /// <param name="perEnd"></param>
        static public void Add(string idDogovor, string idPlace,
            string cargoX,
            string cargoY, string cargoZ, string weight, 
            string desc, string perBegin,string perEnd)
        {
            try
            {
                DataTable count = new DataTable();
                DataBase.msCommand.CommandText = $"SELECT pricehistory." +
                $"price, pricehistory.priceDate, places.idPlace, places.cost" +
                $" from pricehistory, places WHERE" +
                $" pricehistory.idPlace = places.idPlace " +
                $" and places.idPlace = '{idPlace}'" +
                $" and pricehistory.priceDate <= '{perBegin}' ORDER" +
                $" BY pricehistory.priceDate DESC LIMIT 1;";
                DataBase.msCommand.ExecuteNonQuery();
                DataBase.msDataAdapter.Fill(count);
                if (count.Rows.Count == 0)
                {
                    DataBase.msCommand.CommandText =
                    $"SELECT pricehistory." +
                    $"price, pricehistory.priceDate, " +
                    $"places.idPlace, places.cost" +
                    $" from pricehistory, places WHERE" +
                    $" pricehistory.idPlace = places.idPlace " +
                    $" and places.idPlace = '{idPlace}' and " +
                    $"pricehistory.priceDate >= '{perBegin}' " +
                    $"ORDER BY pricehistory.priceDate ASC LIMIT 1;";
                    DataBase.msCommand.ExecuteNonQuery();
                    DataBase.msDataAdapter.Fill(count);
                }
                int cost = ((Convert.ToDateTime(perEnd) -
                    Convert.ToDateTime(perBegin)).Days + 1) * Convert.ToInt32
                        (count.Rows[0]["price"].ToString());

                DataBase.msCommand.CommandText = $"INSERT INTO " +
                    $"`sklad`.`storaging` (`idDogovor`, `idPlace`," +
                    $" `weight`, `cargoX`, `cargoY`, " +
                    $"`cargoZ`,`desc`, `perBegin`, `perEnd`, `storeCost`) " +
                    $"VALUES ('{idDogovor}', '{idPlace}', '{weight}'," +
                    $" '{cargoX}', '{cargoY}', '{cargoZ}', '{desc}'," +
                    $" '{perBegin}', '{perEnd}', '{cost}');";
                DataBase.msCommand.ExecuteNonQuery();



                MessageBox.Show("Данные успешно добавлены", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Произошла ошибка во" +
                " время добавления данных", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Удаление записи из таблицы Storaging
        /// </summary>
        static public void Delete()
        {
            try
            {
                DataBase.msCommand.CommandText = $"DELETE FROM " +
                    $"`sklad`.`storaging` " +
                    $"WHERE (`idStoraging` = '{lastId}');";
                DataBase.msCommand.ExecuteNonQuery();
                MessageBox.Show("Данные удалены", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Произошла ошибка во" +
                " время удаления данных", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Редактирование записи в таблице Storaging
        /// </summary>
        /// <param name="idDogovor"></param>
        /// <param name="idPlace"></param>
        /// <param name="cargoX"></param>
        /// <param name="cargoY"></param>
        /// <param name="cargoZ"></param>
        /// <param name="weight"></param>
        /// <param name="desc"></param>
        /// <param name="perBegin"></param>
        /// <param name="perEnd"></param>
        static public void Edit
            (string idDogovor, string idPlace,string cargoX,
            string cargoY, string cargoZ, string weight, string desc,
            string perBegin, string perEnd)
        {
            try
            {
                DataTable count = new DataTable();
                DataBase.msCommand.CommandText = $"SELECT pricehistory." +
                $"price, pricehistory.priceDate, places.idPlace, places.cost" +
                $" from pricehistory, places WHERE" +
                $" pricehistory.idPlace = places.idPlace " +
                $" and places.idPlace = '{idPlace}'" +
                $" and pricehistory.priceDate <= '{perBegin}' " +
                $" ORDER BY pricehistory.priceDate DESC LIMIT 1;";
                DataBase.msCommand.ExecuteNonQuery();
                DataBase.msDataAdapter.Fill(count);
                if (count.Rows.Count == 0)
                {
                    DataBase.msCommand.CommandText =
                    $"SELECT pricehistory." +
                    $"price, pricehistory.priceDate, " +
                    $"places.idPlace, places.cost" +
                    $" from pricehistory, places WHERE" +
                    $" pricehistory.idPlace = places.idPlace " +
                    $" and places.idPlace = '{idPlace}' and " +
                    $"pricehistory.priceDate >= '{perBegin}' " +
                    $"ORDER BY pricehistory.priceDate ASC LIMIT 1;";
                    DataBase.msCommand.ExecuteNonQuery();
                    DataBase.msDataAdapter.Fill(count);
                }
                int cost = ((Convert.ToDateTime(perEnd) -
                    Convert.ToDateTime(perBegin)).Days + 1) * Convert.ToInt32
                        (count.Rows[0]["price"].ToString());

                DataBase.msCommand.CommandText =
                        $"UPDATE `sklad`.`storaging` SET " +
                        $"`idDogovor` = '{idDogovor}', " +
                        $"`idPlace` = '{idPlace}', " +
                        $"`weight` = '{weight}', " +
                        $"`cargoX` = '{cargoX}', " +
                        $"`cargoY` = '{cargoY}', " +
                        $"`cargoZ` = '{cargoZ}', " +
                        $"`desc` = '{desc}', " +
                        $"`perBegin` = '{perBegin}', " +
                        $"`perEnd` = '{perEnd}'," +
                        $"`storeCost` = '{cost}' " +
                        $"WHERE (`idStoraging` = '{lastId}');";
                DataBase.msCommand.ExecuteNonQuery();


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
        /// Определяет, вместится ли груз в место на складе 
        /// </summary>
        /// <param name="cargoY"></param>
        /// <param name="cargoZ"></param>
        /// <param name="cargoX"></param>
        /// <param name="idPlace"></param>
        /// <returns></returns>
        static public bool Fits
            (string cargoX, string cargoY, string cargoZ, string idPlace)
        {
            try
            {
                DataTable place = new DataTable();
                DataBase.msCommand.CommandText = $"SELECT * FROM " +
                    $"sklad.places where idPlace = {idPlace}";
                DataBase.msDataAdapter.Fill(place);
                if (Convert.ToInt32(place.Rows[0]["placeX"].ToString())
                    >= Convert.ToInt32(cargoX) && Convert.ToInt32(place.
                    Rows[0]["placeY"].ToString())
                    >= Convert.ToInt32(cargoY) && Convert.ToInt32(place.
                    Rows[0]["placeZ"].ToString())
                    >= Convert.ToInt32(cargoZ))
                {
                    return true;
                }
                else
                    return false;
            }
            catch
            {
                MessageBox.Show("Произошла ошибка во" +
                    " время редактирования данных", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
    }
}
