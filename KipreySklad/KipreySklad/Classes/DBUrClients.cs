using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KipreySklad.Classes
{
    class DBUrClients
    {
        static public string lastId;
        /// <summary>
        /// Получение таблицы uridclients для comboBox
        /// </summary>
        static public DataTable Combo()
        {
            DataTable dtCombo = new DataTable();
            try
            {
                dtCombo.Clear();
                DataBase.msCommand.CommandText = $"SELECT * " +
                    $"from uridclients;";
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
        /// Получение таблицы uridclients
        /// </summary>
        static public DataTable Get(string where)
        {
            DataTable dtUrClients = new DataTable();
            try
            {
                dtUrClients.Clear();
                DataBase.msCommand.CommandText = $"SELECT * " +
                    $"from uridclients {where};";
                DataBase.msCommand.ExecuteNonQuery();
                DataBase.msDataAdapter.Fill(dtUrClients);
                return dtUrClients;
            }
            catch
            {
                MessageBox.Show("Произошла ошибка во" +
                " время загрузки", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dtUrClients;
            }
        }

        /// <summary>
        /// Добавление записи в таблицу uridclients
        /// </summary>
        /// <param name="okpo"></param>
        /// <param name="urArdes"></param>
        /// <param name="directorFio"></param>
        /// <param name="firmPhone"></param>
        /// <param name="firmName"></param>
        /// <param name="bik"></param>
        /// <param name="inn"></param>
        /// <param name="bank"></param>
        static public void Add(string okpo, string urArdes, string
            directorFio, string firmPhone, string firmName,
            string bik, string inn, string bank)
        {
            try
            {
                DataBase.msCommand.CommandText = $"INSERT INTO " +
                    $"`sklad`.`uridclients` (`okpo`,`urArdes`," +
                    $" `directorFio`," +
                    $" `firmPhone`, `firmName`, `bik`, `inn`, `bank`) " +
                    $"VALUES ('{okpo}','{urArdes}', '{directorFio}'," +
                    $" '{firmPhone}', '{firmName}'," +
                    $"'{bik}','{inn}','{bank}');";
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
        /// Удаление записи из таблицы uridclients
        /// </summary>
        static public void Delete()
        {
            try
            {
                DataBase.msCommand.CommandText = $"DELETE FROM " +
                    $"`sklad`.`uridclients` WHERE (`okpo` = '{lastId}');";
                DataBase.msCommand.ExecuteNonQuery();
                MessageBox.Show("Данные удалены", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Невозможно выполнить," +
                    " так как с данным клиентом заключен договор", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Редактирование записи в таблице uridclients
        /// </summary>
        /// <param name="urArdes"></param>
        /// <param name="directorFio"></param>
        /// <param name="firmPhone"></param>
        /// <param name="firmName"></param>
        /// <param name="bik"></param>
        /// <param name="inn"></param>
        /// <param name="bank"></param>
        static public void Edit(string
            urArdes, string directorFio, string firmPhone, string firmName,
            string bik, string inn, string bank)
        {
            try
            {
                DataBase.msCommand.CommandText =
                    $"UPDATE `sklad`.`uridclients` " +
                    $"SET `urArdes` = '{urArdes}', " +
                    $"`directorFio` = '{directorFio}'," +
                    $" `firmPhone` = '{firmPhone}'," +
                    $" `firmName` = '{firmName}'," +
                    $" `bik` = '{bik}'," +
                    $"`inn` = '{inn}'," +
                    $"`bank` = '{bank}'" +
                    $"WHERE (`okpo` = '{lastId}');";
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
        static public bool InDogovor(string id)
        {
            try
            {
                DataBase.msCommand.CommandText =
                    $@"SELECT * from dogovori where idClient =
                    '{id}' and entity = '1';";
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
        /// <summary>
        /// Проверяет поле на наличие значения
        /// </summary>
        /// <param name="val"></param>
        /// <param name="field"></param>
        /// <returns></returns>
        static public bool AlreadyExists(string val, string field)
        {
            try
            {
                DataBase.msCommand.CommandText =
                    $@"SELECT * from uridclients where 
                    ({field} = '{val}')
                    AND (okpo <> '{lastId}');";
                object result = DataBase.msCommand.ExecuteScalar();
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
