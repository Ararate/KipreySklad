using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KipreySklad.Classes
{
    class DBClients
    {
        static public int lastId;

        /// <summary>
        /// Получение таблицы clients для comboBox
        /// </summary>
        /// <param name="where"></param>
        static public DataTable Combo(string where)
        {
            DataTable dtCombo = new DataTable();
            try
            {
                DataBase.msCommand.CommandText = $"SELECT * " +
                    $"from clients {where};";
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
        /// Получение таблицы clients
        /// </summary>
        static public DataTable Get(string where)
        {
            DataTable dtClients = new DataTable();
            try
            {
                dtClients.Clear();
                DataBase.msCommand.CommandText = $"SELECT * " +
                    $"from clients {where};";
                DataBase.msCommand.ExecuteNonQuery();
                DataBase.msDataAdapter.Fill(dtClients);
                return dtClients;
            }
            catch
            {
                MessageBox.Show("Произошла ошибка во" +
                " время загрузки", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dtClients;
            }
        }

        /// <summary>
        /// Добавление записи в таблицу clients
        /// </summary>
        /// <param name="fio"></param>
        /// <param name="phone"></param>
        /// <param name="passport"></param>
        static public void Add(string fio, string phone, string passport)
        {
            try
            {
                DataBase.msCommand.CommandText = $"INSERT " +
                    $"INTO `sklad`.`clients` (`fio`, " +
                    $"`phone`,`passport`) VALUES ('{fio}'," +
                    $"  '{phone}', '{passport}' );";
                DataBase.msCommand.ExecuteNonQuery();
                MessageBox.Show("Данные успешно добавлена", "",
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
        /// Удаление записи из таблицы clients
        /// </summary>
        static public void Delete()
        {
            try
            {
                DataBase.msCommand.CommandText = $"DELETE FROM " +
                    $"`sklad`.`clients` WHERE (`idClient` = '{lastId}');";
                DataBase.msCommand.ExecuteNonQuery();
                MessageBox.Show("Данные удалены", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Невозможно выполнить пока с данным клиентом заключен договор", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Редактирование записи в таблице clients
        /// </summary>
        /// <param name="fio"></param>
        /// <param name="phone"></param>
        /// <param name="passport"></param>
        static public void Edit(string fio, string phone, string passport)
        {
            try
            {
                DataBase.msCommand.CommandText =
                    $"UPDATE `sklad`.`clients` " +
                    $"SET `fio` = '{fio}', `passport` = '{passport}'," +
                    $" `phone` = '{phone}'" +
                    $" WHERE (`idClient` = '{lastId}');";
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
                    '{id}' and entity = '0';";
                Object result = DataBase.msCommand.ExecuteScalar();
                return (result != null);
            }
            catch
            {
                MessageBox.Show("Произошла ошибка InDogovor", "Error",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
        }
        /// <summary>
        /// Проверяет значение выбранного поля на наличие выбранного значения
        /// </summary>
        /// <param name="val"></param>
        /// <param name="field"></param>
        /// <returns></returns>
        static public bool AlreadyExists(string val, string field)
        {
            //try
            //{
                DataBase.msCommand.CommandText =
                    $@"SELECT * from clients where  
                    ({field} = '{val}')
                    AND (idClient <> '{lastId}');";
                Object result = DataBase.msCommand.ExecuteScalar();
                return (result != null);
            //}
            //catch
            //{
            //    MessageBox.Show("Произошла ошибка", "Error",
            //     MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return true;
            //}
        }
    }
}
