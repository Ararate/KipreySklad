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
    public partial class FormUrClients : Form
    {
        public FormUrClients()
        {
            InitializeComponent();
        }
        public static DataTable dtUrClients = new DataTable();
        public static bool editing = false;
        private static bool check = false;

        private void FormUrClients_Load(object sender, EventArgs e)
        {

            check = false;
            dtUrClients = DBUrClients.Get("");
            DataGridView.DataSource = dtUrClients;
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
            dtUrClients = DBUrClients.Get
                ($"WHERE firmName LIKE '%{TBSearch.Text}%'");
            DataGridView.DataSource = dtUrClients;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DBUrClients.lastId = "-1";
                editing = false;
                AddUrClient.phone = null;
                AddUrClient.fio = null;
                AddUrClient.name = null;
                AddUrClient.adress = null;
                AddUrClient.bik = null;
                AddUrClient.inn = null;
                AddUrClient.bank = null;
                AddUrClient addop = new AddUrClient
                {
                    Text = "Новая запись",
                    BtnUndo = BtnCancel
                };
                addop.ShowDialog();
                dtUrClients = DBUrClients.Get("");
                DataGridView.DataSource = dtUrClients;

            }
            catch
            {

            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (!check)
            {
                MessageBox.Show("Запись не выбрана...", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DBUrClients.lastId = DataGridView.CurrentRow.
                Cells["okpo"].Value.ToString();
            editing = true;
            AddUrClient addU = new AddUrClient
            {
                Text = "Изменение данных",
                BtnUndo = BtnCancel
            };

            AddUrClient.fio = DataGridView.CurrentRow.
                Cells["directorFio"].Value.ToString();

            AddUrClient.phone = DataGridView.CurrentRow.
                Cells["firmPhone"].Value.ToString();

            AddUrClient.name = DataGridView.CurrentRow.
                Cells["firmName"].Value.ToString();

            AddUrClient.adress = DataGridView.CurrentRow.
                Cells["urArdes"].Value.ToString();

            AddUrClient.bik = DataGridView.CurrentRow.
                Cells["bik"].Value.ToString();

            AddUrClient.inn = DataGridView.CurrentRow.
                Cells["inn"].Value.ToString();

            AddUrClient.bank = DataGridView.CurrentRow.
                Cells["bank"].Value.ToString();
            addU.ShowDialog();
            dtUrClients = DBUrClients.Get("");
            DataGridView.DataSource = dtUrClients;
        }

        private void DataGridView_CellClick
            (object sender, DataGridViewCellEventArgs e)
        {
            check = true;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (!check)
            {
                MessageBox.Show("Запись не выбрана...", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (DBUrClients.InDogovor(DataGridView.CurrentRow.
                Cells["okpo"].Value.ToString()))
            {
                MessageBox.Show("Невозможно выполнить, удалите " +
                    "соответствующий договор", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Удалить запись?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                DataBase.Export("uridclients");
                BtnCancel.Enabled = true;
                DBUrClients.lastId = DataGridView.CurrentRow.
                Cells["okpo"].Value.ToString();
                DBUrClients.Delete();
                DataGridView.DataSource = DBUrClients.Get("");
                check = false;
            }
        }

        private void BtnBack_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DataBase.Import("uridclients");
            DataGridView.DataSource = DBUrClients.Get("");
            BtnCancel.Enabled = false;
        }
    }
}
