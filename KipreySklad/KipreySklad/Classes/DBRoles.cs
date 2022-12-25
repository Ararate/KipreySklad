using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KipreySklad.Classes
{
    class DBRoles
    {
        /// <summary>
        /// Получение таблицы roles
        /// </summary>
        static public DataTable Get()
        {
            DataTable dtRoles = new DataTable();
            try
            {
                dtRoles.Clear();
                DataBase.msCommand.CommandText = $"SELECT * from s_roles;";
                DataBase.msCommand.ExecuteNonQuery();
                DataBase.msDataAdapter.Fill(dtRoles);
                return dtRoles;
            }
            catch
            {
                MessageBox.Show("Произошла ошибка во" +
                " время загрузки", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dtRoles;
            }
        }

    }
}
