using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KipreySklad.Classes
{
    class DBStorages
    {
        static public int lastId;

        /// <summary>
        /// Получение таблицы Users
        /// </summary>
        static public DataTable Get(string and)
        {
            DataTable dtStorages = new DataTable();
            //try
            //{
                dtStorages.Clear();
                DataBase.msCommand.CommandText = $"SELECT " +
                    $"storages.adress, " +
                    $"types.type,storages.codeType," +
                    $"  storages.idStorage " +
                    $"from storages, types where types.codeType =" +
                    $" storages.codeType {and};";
                DataBase.msCommand.ExecuteNonQuery();
                DataBase.msDataAdapter.Fill(dtStorages);
                return dtStorages;
            //}
            //catch
            //{
            //    MessageBox.Show("Произошла ошибка во" +
            //    " время загрузки", "Error",
            //    MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return dtStorages;
            //}
        }
        /// <summary>
        /// Добавление записи в таблицу Storages
        /// </summary>
        /// <param name="codeType"></param>
        /// <param name="adress"></param>
        static public void Add(string codeType, string adress)
        {
            try
            {
                DataBase.msCommand.CommandText = $"INSERT INTO" +
                    $" `sklad`.`storages` (`codeType`, `adress`)" +
                    $" VALUES ('{codeType}', '{adress}');";
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
        /// Удаление записи из таблицы Storages
        /// </summary>
        static public void Delete()
        {
            try
            {
                DataBase.msCommand.CommandText = $"DELETE FROM " +
                    $"`sklad`.`storages` WHERE (`idStorage` = '{lastId}');";
                DataBase.msCommand.ExecuteNonQuery();
                MessageBox.Show("Данные удалены", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Невозможно выполнить, так" +
                    " как на складе есть места", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Редактирование записи в таблице storages
        /// </summary>
        /// <param name="codeType"></param>
        /// <param name="adress"></param>
        static public void Edit(string codeType, string adress)
        {
            try
            {
                DataBase.msCommand.CommandText = $"UPDATE `sklad`." +
                    $"`storages` SET `codeType` = '{codeType}', " +
                    $"`adress` = '{adress}'" +
                    $" WHERE (`idStorage` = '{lastId}');";
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
                    $@"SELECT * from storages where 
                    ({field} = '{val}')
                    AND (idStorage <> '{lastId}');";
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
