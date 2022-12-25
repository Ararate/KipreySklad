using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KipreySklad.Classes
{
    /// <summary>
    /// Работа с таблицей users
    /// </summary>
    class DBUsers
    {
        static public int lastId;
        /// <summary>
        /// Получение таблицы Users для comboBox
        /// </summary>
        static public DataTable Combo()
        {
            DataTable dtCombo = new DataTable();
            try
            {
                if (DataBase.role == 1)
                DataBase.msCommand.CommandText = $"SELECT " +
                    $"* from users where idUser = '{DataBase.userId}'";
                else
                    DataBase.msCommand.CommandText = $"SELECT " +
                    $"* from users";
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
        /// Получение таблицы Users
        /// </summary>
        static public DataTable Get(string and)
        {
            DataTable dtUsers = new DataTable();
            try
            {
                DataBase.msCommand.CommandText = $"SELECT " +
                    $"users.idUser,users.login,users.password" +
                    $",users.fio,users.phone,s_roles.codeRole" +
                    $",s_roles.role from users, s_roles" +
                    $" where users.codeRole = s_roles.codeRole {and} " +
                    $"ORDER BY users.fio DESC;";
                DataBase.msCommand.ExecuteNonQuery();
                DataBase.msDataAdapter.Fill(dtUsers);
                return dtUsers;
            }
            catch
            {
                MessageBox.Show("Произошла ошибка во" +
                " время загрузки", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dtUsers;
            }
        }

        /// <summary>
        /// Добавление записи в таблицу users
        /// </summary>
        /// <param name="codeRole"></param>
        /// <param name="fio"></param>
        /// <param name="phone"></param>
        /// <param name="login"></param>
        static public void Add(string codeRole, string fio,
            string phone, string login)
        {
            try
            {
                DataBase.msCommand.CommandText = $"INSERT INTO `sklad`." +
                    $"`users` (`codeRole`, `fio`, `phone`, " +
                    $"`login`, `password`, `isDeleted`) " +
                    $"VALUES ('{codeRole}', '{fio}', " +
                    $" '{phone}', '{login}', md5('1'), '0');";
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
        /// Удаление записи из таблицы users
        /// </summary>
        static public void Delete()
        {
            try
            {
                DataBase.msCommand.CommandText = $"UPDATE `sklad`.`users` " +
                    $"SET `isDeleted` = '1' WHERE (`idUser` = '{lastId}');";
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
        /// Сброс пароля пользователя из таблицы users
        /// </summary>
        static public void PassReset(string name)
        {
            try
            {
                DataBase.msCommand.CommandText = $"UPDATE `sklad`.`users` " +
                    $"SET `password` = md5('1') WHERE (`idUser` = '{lastId}');";
                DataBase.msCommand.ExecuteNonQuery();
                MessageBox.Show($"Пароль пользователя {name} - \"1\"", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка при сбросе пароля", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Редактирование записи в таблице users
        /// </summary>
        /// <param name="codeRole"></param>
        /// <param name="fio"></param>
        /// <param name="phone"></param>
        /// <param name="login"></param>
        static public void Edit(string codeRole, string fio,
            string phone, string login)
        {
            try
            {
                DataBase.msCommand.CommandText = $"UPDATE `sklad`.`users` " +
                    $"SET `login` = '{login}', " +
                    $"`codeRole` = '{codeRole}', `fio` = '{fio}', " +
                    $"`phone` = '{phone}' " +
                    $"WHERE (`idUser` = '{lastId}');";
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
        /// Редактирование пароля пользователя
        /// </summary>

        static public void EditPassw(string password)
        {
            try
            {
                DataBase.msCommand.CommandText = $"UPDATE `sklad`.`users` " +
                    $"SET `password` = md5('{password}') " +
                    $"WHERE (`idUser` = '{lastId}');";
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
        /// Проверяет выбранное поле на наличие выбранного значения
        /// </summary>
        /// <param name="val"></param>
        /// <param name="field"></param>
        /// <returns></returns>
        static public bool AlreadyExists(string val, string field)
        {
            try
            {
                DataBase.msCommand.CommandText =
                    $@"SELECT * from users where 
                    ({field} = '{val}')
                    AND (idUser <> '{lastId}');";
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
        /// Проверяет наличие активных договоров у пользователя
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        static public bool HasDogovor(string id)
        {
            try
            {
                DataBase.msCommand.CommandText =
                    $@"SELECT * from dogovori where 
                    (idUser = '{id}')";
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
        /// Возврат пользователя из архива
        /// </summary>
        static public void Restore()
        {
            try
            {
                DataBase.msCommand.CommandText = $"UPDATE `sklad`.`users` " +
                    $"SET `isDeleted` = '0' WHERE (`idUser` = '{lastId}');";
                DataBase.msCommand.ExecuteNonQuery();
                MessageBox.Show("Пользователь восстановлен", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Невозможно выполнить, так как с данным менеджером заключен договор", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
