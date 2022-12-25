using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KipreySklad.Classes
{
    class DBDogovori
    {

        static public int lastId;
        /// <summary>
        /// Получение списка для вывода в comboBox
        /// </summary>
        /// <returns></returns>
        static public DataTable Combo()
        {
            DataTable dtCombo = new DataTable();
            try
            {
                DataTable t1 = new DataTable();
                dtCombo.Clear();
                DataBase.msCommand.CommandText = $"SELECT " +
                    $"dogovori.idDogovor, CONCAT(dogovori.idDogovor " +
                    $", ' (' , clients.fio,') '" +
                    $" , dogovori.dataBegin,' по ', dogovori.dataEnd)" +
                    $" as client, dogovori.dataBegin, dogovori.dataEnd" +
                    $" from clients, dogovori " +
                $" where clients.idClient = " +
                $"dogovori.idClient and dogovori.entity = '0';";
                DataBase.msCommand.ExecuteNonQuery();
                DataBase.msDataAdapter.Fill(t1);

                DataBase.msCommand.CommandText = $"SELECT " +
                        $"dogovori.idDogovor, CONCAT(dogovori.idDogovor " +
                        $", ' (', uridclients." +
                        $"firmName, ') ', dogovori.dataBegin,' по '," +
                        $" dogovori.dataEnd) as client,dogovori.dataBegin," +
                        $" dogovori.dataEnd from" +
                        $" uridclients, dogovori where" +
                        $" uridclients.okpo = dogovori." +
                        $"idClient and dogovori.entity = '1';";
                DataBase.msCommand.ExecuteNonQuery();
                DataBase.msDataAdapter.Fill(dtCombo);
                dtCombo.Merge(t1);
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
        /// Получение таблицы dogovori
        /// </summary>
        static public DataTable Get(string and, bool entity)
        {
            DataTable dtDogovori = new DataTable();
            try
            {
                if (!entity)
                {
                    DataBase.msCommand.CommandText = $"SELECT " +
                        $"dogovori.idUser,dogovori.idClient," +
                        $" dogovori.idDogovor, users.fio, " +
                    $"clients.fio, dogovori.dataBegin, dogovori.dataEnd" +
                    $" from users, clients, dogovori where users.idUser " +
                    $"= dogovori.idUser and clients.idClient = " +
                    $"dogovori.idClient and dogovori.entity = '0' {and};";
                }
                else
                {
                    DataBase.msCommand.CommandText = $"SELECT " +
                        $"dogovori.idUser,dogovori.idClient," +
                        $"dogovori.idDogovor, users.fio, " +
                        $"dogovori.dataBegin, dogovori.dataEnd," +
                        $" uridclients.firmName as fio1" +
                        $" from users," +
                        $" uridclients, dogovori where users.idUser =" +
                        $" dogovori.idUser and uridclients.okpo = dogovori." +
                        $"idClient and dogovori.entity = '1' {and};";
                }

                DataBase.msCommand.ExecuteNonQuery();
                DataBase.msDataAdapter.Fill(dtDogovori);
                return dtDogovori;
            }
            catch
            {
                MessageBox.Show("Произошла ошибка во" +
                " время загрузки", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dtDogovori;
            }
        }
        /// <summary>
        /// Получение "сырой" таблицы dogovori
        /// </summary>
        static public DataTable Get()
        {
            DataTable dtDogovori = new DataTable();
            try
            {
                dtDogovori.Clear();

                    DataBase.msCommand.CommandText = 
                    $"SELECT *" +
                    $" from dogovori ;";
                DataBase.msCommand.ExecuteNonQuery();
                DataBase.msDataAdapter.Fill(dtDogovori);
                return dtDogovori;
            }
            catch
            {
                MessageBox.Show("Произошла ошибка во" +
                " время загрузки", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dtDogovori;
            }
        }

        /// <summary>
        /// Добавление записи в таблицу dogovori
        /// </summary>
        /// <param name="idUser"></param>
        /// <param name="idClient"></param>
        /// <param name="dataBegin"></param>
        /// <param name="dataEnd"></param>
        /// <param name="entity"></param>
        static public void Add(string idUser, string idClient,
            string dataBegin, string dataEnd, int entity)
        {
            try
            {
                DataBase.msCommand.CommandText = $"INSERT INTO " +
                    $"`sklad`.`dogovori` (`idUser`, `idClient`," +
                    $" `dataBegin`, `dataEnd`, `entity`) " +
                    $"VALUES ('{idUser}', " +
                    $"'{idClient}', '{dataBegin}','{dataEnd}','{entity}');";
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
        /// Удаление записи из таблицы dogovori
        /// </summary>
        static public void Delete()
        {
            try
            {
                DataBase.msCommand.CommandText = $"DELETE FROM " +
                    $"`sklad`.`storaging` WHERE (`idDogovor` = '{lastId}');";
                DataBase.msCommand.ExecuteNonQuery();
                DataBase.msCommand.CommandText = $"DELETE FROM " +
                    $"`sklad`.`dogovori` WHERE (`idDogovor` = '{lastId}');";
                DataBase.msCommand.ExecuteNonQuery();
                MessageBox.Show("Данные удалены", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка во время удаления", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Редактирование записи в таблице dogovori
        /// </summary>
        /// <param name="idUser"></param>
        /// <param name="idClient"></param>
        /// <param name="dataBegin"></param>
        /// <param name="dataEnd"></param>
        /// <param name="entity"></param>
        static public void Edit(string idUser, string idClient,
            string dataBegin, string dataEnd, int entity)
        {
            try
            {
                DataBase.msCommand.CommandText = $"UPDATE " +
                    $"`sklad`.`dogovori` SET `idUser` = '{idUser}'," +
                    $"`entity` = '{entity}', `idClient` = '{idClient}'," +
                    $" `dataBegin` = '{dataBegin}', " +
                    $"`dataEnd` = '{dataEnd}' WHERE " +
                    $"(`idDogovor` = '{lastId}');";
                DataBase.msCommand.ExecuteNonQuery();
                DataTable count = new DataTable();
                DataBase.msCommand.CommandText = $"SELECT types.cost, " +
                    $" dogovori.dataEnd,dogovori.dataBegin from" +
                    $" places, storaging, dogovori, storages, types WHERE" +
                    $" types.codeType = storages.codeType " +
                    $" and dogovori.idDogovor = storaging.idDogovor" +
                    $" and storages.idStorage = places.idStorage and" +
                    $" places.idPlace = storaging.idPlace" +
                    $" and dogovori.idDogovor = '{lastId}'";
                DataBase.msCommand.ExecuteNonQuery();
                DataBase.msDataAdapter.Fill(count);
                int cost = Convert.ToInt32(count.Rows[0]["cost"].ToString())
                * (Convert.ToDateTime(count.Rows[0]["dataEnd"].ToString())
                - Convert.
                ToDateTime(count.Rows[0]["dataBegin"].ToString())).Days;
                DataBase.msCommand.CommandText =
                    $"UPDATE storaging SET" +
                    $" storeCost = {cost} ORDER BY idStoraging DESC limit 1;";
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
        /// Проверяет, существует ли связанная запись
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        static public bool HasStoraging(string id)
        {
            try
            {
                DataBase.msCommand.CommandText =
                    $@"SELECT * from storaging where 
                    (idDogovor = '{id}')";
                Object result = DataBase.msCommand.ExecuteScalar();
                return (result != null);
            }
            catch
            {
                MessageBox.Show("Произошла ошибка", "Error",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
        }

    }
}
