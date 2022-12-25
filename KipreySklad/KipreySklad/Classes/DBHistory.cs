using KipreySklad.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KipreySklad.Forms
{
    class DBHistory
    {
        static public int lastId;
        /// <summary>
        /// Получение таблицы clients
        /// </summary>
        static public DataTable Get(string where)
        {
            DataTable dtHistory = new DataTable();
            try
            {
                dtHistory.Clear();
                DataBase.msCommand.CommandText = $"SELECT * " +
                    $"from pricehistory {where};";
                DataBase.msCommand.ExecuteNonQuery();
                DataBase.msDataAdapter.Fill(dtHistory);
                return dtHistory;
            }
            catch
            {
                MessageBox.Show("Произошла ошибка во" +
                " время загрузки", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dtHistory;
            }
        }
    }
}
