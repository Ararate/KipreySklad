using KipreySklad.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KipreySklad.Forms;

namespace KipreySklad.Forms
{
    public partial class FormClients : Form
    {
        public FormClients()
        {
            InitializeComponent();
        }
        private static DataTable dtClients = new DataTable();
        public static bool editing = false;
        private static bool check = false;

        private void FormClients_Load(object sender, EventArgs e)
        {
            check = false;
            dtClients = DBClients.Get("");
            DataGridView.DataSource = dtClients;
            if (DataBase.role == 2 || DataBase.role == 3)
            {
                BtnEdit.Enabled = false;
                BtnAdd.Enabled = false;
                BtnDelete.Enabled = false;
            }
            else
            {
                BtnEdit.Enabled = true;
                BtnAdd.Enabled = true;
                BtnDelete.Enabled = true;
            }
        }

        private void TBSearch_TextChanged(object sender, EventArgs e)
        {
            dtClients = DBClients.Get($"WHERE fio LIKE '%{TBSearch.Text}%'");
            DataGridView.DataSource = dtClients;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            DBClients.lastId = -1;
            editing = false;
            AddClient.phone = null;
            AddClient.fio = null;
            AddClient.passport = null;
            AddClient addop = new AddClient
            {
                Text = "Новые данные",
                BtnUndo = BtnCancel
            };
            addop.ShowDialog();
            dtClients = DBClients.Get("");
            DataGridView.DataSource = dtClients;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (!check)
            {
                MessageBox.Show("Клиент не выбран...", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DBClients.lastId = Convert.ToInt32(DataGridView.CurrentRow.
                Cells["idClient"].Value.ToString());
            editing = true;
            AddClient addU = new AddClient
            {
                Text = "Изменение данных",
                BtnUndo = BtnCancel
            };

            AddClient.fio = DataGridView.CurrentRow.
                Cells["fio"].Value.ToString();

            AddClient.phone = DataGridView.CurrentRow.
                Cells["phone"].Value.ToString();

            AddClient.passport = DataGridView.CurrentRow.
                Cells["passport"].Value.ToString();

            addU.ShowDialog();
            dtClients = DBClients.Get("");
            DataGridView.DataSource = dtClients;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (!check)
            {
                MessageBox.Show("Запись не выбрана...", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (DBClients.InDogovor(DataGridView.CurrentRow.
                Cells["idClient"].Value.ToString()))
            {
                MessageBox.Show("Невозможно выполнить, удалите " +
                    "соответствующий договор", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Удалить запись?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                DataBase.Export("clients");
                BtnCancel.Enabled = true;
                DBClients.lastId = Convert.ToInt32(DataGridView.CurrentRow.
                Cells["idClient"].Value.ToString());
                DBClients.Delete();
                DataGridView.DataSource = DBClients.Get("");
                check = false;
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DataGridView_CellClick
            (object sender, DataGridViewCellEventArgs e)
        {
            check = true;
        }

        private void BtnBack_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DataBase.Import("clients");
            DataGridView.DataSource = DBClients.Get("");
            BtnCancel.Enabled = false;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
