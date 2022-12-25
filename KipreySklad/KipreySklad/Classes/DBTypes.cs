using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KipreySklad.Classes
{
    class DBTypes
    {
        static public int lastId;
        /// <summary>
        /// Получение таблицы types для comboBox
        /// </summary>
        static public DataTable Combo()
        {
            DataTable dtCombo = new DataTable();
            try
            {
                dtCombo.Clear();
                DataBase.msCommand.CommandText =
                    $"SELECT * FROM sklad.types;";
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
        /// Получение таблицы types
        /// </summary>
        static public DataTable Get(string where)
        {
            DataTable dtTypes = new DataTable();
            try
            {
                dtTypes.Clear();
                DataBase.msCommand.CommandText =
                    $"SELECT * FROM sklad.types {where};";
                DataBase.msCommand.ExecuteNonQuery();
                DataBase.msDataAdapter.Fill(dtTypes);
                return dtTypes;
            }
            catch
            {
                MessageBox.Show("Произошла ошибка во" +
                   " время загрузки", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dtTypes;
            }
        }

        /// <summary>
        /// Добавление записи в таблицу types
        /// </summary>
        /// <param name="type"></param>
        static public void Add
            (string type)
        {
            try
            {
                DataBase.msCommand.CommandText =
                    $"INSERT INTO `sklad`.`types` (`type`) " +
                    $"VALUES ('{type}');";
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
        /// Удаление записи из таблицы types
        /// </summary>
        static public void Delete()
        {
            try
            {
                DataBase.msCommand.CommandText = $"DELETE FROM " +
                    $"`sklad`.`types` WHERE (`codeType` = '{lastId}');";
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
        /// Редактирование записи в таблицу types
        /// </summary>
        /// <param name="type"></param>
        static public void Edit
            (string type)
        {
            try
            {
                DataBase.msCommand.CommandText =
                    $"UPDATE `sklad`.`types` SET `type` = '{type}' " +
                    $" WHERE (`codeType` = '{lastId}');";
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
                    $@"SELECT * from types where 
                    ({field} = '{val}')
                    AND (codeType <> '{lastId}');";
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
        /// Проверяет, существует ли связанная запись
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        static public bool HasStorage(string id)
        {
            DataBase.msCommand.CommandText =
                $"SELECT * FROM storages WHERE codeType = '{id}'";
            if (DataBase.msCommand.ExecuteScalar() == null)
            {
                return false;
            }
            else
                return true;
        }
    }
}
