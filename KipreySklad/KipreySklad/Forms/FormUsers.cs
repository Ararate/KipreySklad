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
    public partial class FormUsers : Form
    {
        public FormUsers()
        {
            InitializeComponent();
        }
        public static DataTable dtUsers = new DataTable();
        private static DataTable dtRoles = new DataTable();
        private static string wRole, wSearch;
        public static bool editing = false;
        private static bool check = false;
        private void FormUsers_Load(object sender, EventArgs e)
        {
            dtRoles = DBRoles.Get();
            CBRole.DataSource = dtRoles;
            CBRole.DisplayMember = "role";
            CBRole.ValueMember = "codeRole";
            CBField.SelectedItem = "Номеру телефона";
            BtnEdit.Enabled = true;
            BtnAdd.Enabled = true;
            BtnDelete.Enabled = true;
            TBSearch.Enabled = true;
            switch (DataBase.role)
            {
                case 1:
                    BtnAdd.Enabled = false;
                    BtnEdit.Enabled = false;
                    BtnDelete.Enabled = false;
                    TBSearch.Enabled = false;
                    break;
                case 2:
                    BtnEdit.Enabled = false;
                    BtnAdd.Enabled = false;
                    BtnDelete.Enabled = false;
                    TBSearch.Enabled = false;
                    break;
                case 3:
                    break;
                case 0:
                    break;
            }
            check = false;
            dtUsers = DBUsers.Get($"and isDeleted = '0' {wSearch} {wRole}");
            DGWArchive.DataSource =
                DBUsers.Get($"and isDeleted = '1' {wSearch} {wRole}");
            DataGridView.DataSource = dtUsers;
        }

        private void TBSearch_TextChanged(object sender, EventArgs e)
        {
            if (CBField.Text == "Номеру телефона")
                wSearch = $"AND phone LIKE '%{TBSearch.Text}%'";
            else
                wSearch = $"AND fio LIKE '%{TBSearch.Text}%'";
            dtUsers = DBUsers.Get($"and isDeleted = '0' {wSearch} {wRole}");
            DGWArchive.DataSource =
            DBUsers.Get($"and isDeleted = '1' {wSearch} {wRole}");
            DataGridView.DataSource = dtUsers;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DBUsers.lastId = -1;
                editing = false;
                AddUser.login = null;
                AddUser.fio = null;
                AddUser.phone = null;
                AddUser addop = new AddUser
                {
                    Text = "Новая запись",
                    BtnUndo = BtnUndo
                };
                addop.ShowDialog();
                DataGridView.DataSource = DBUsers.Get
                    ($"and isDeleted = '0' {wSearch} {wRole}");
            }
            catch
            {

            }
            
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!check)
                {
                    MessageBox.Show("Запись не выбрана...", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (DBUsers.HasDogovor(DataGridView.CurrentRow.
                    Cells["idUser"].Value.ToString()))
                {
                    MessageBox.Show("Невозможно выполнить, так как" +
                        " с данным менеджером заключен договор", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DBUsers.lastId = Convert.ToInt32(DataGridView.CurrentRow.
                    Cells["idUser"].Value.ToString());
                editing = true;
                AddUser addU = new AddUser
                {
                    Text = "Изменение данных",
                    BtnUndo = BtnUndo
                };

                AddUser.login = DataGridView.CurrentRow.
                    Cells["login"].Value.ToString();

                AddUser.codeRole = DataGridView.CurrentRow.
                    Cells["codeRole"].Value.ToString();

                AddUser.fio = DataGridView.CurrentRow.
                    Cells["fio"].Value.ToString();

                AddUser.phone = DataGridView.CurrentRow.
                    Cells["phone"].Value.ToString();


                addU.ShowDialog();
                dtUsers = DBUsers.Get($"and isDeleted = '0' {wSearch} {wRole}");
                DataGridView.DataSource = dtUsers;
            }
            catch
            {

            }


        }

        private void DataGridView_CellClick
            (object sender, DataGridViewCellEventArgs e)
        {
            check = true;
            BtnRestore.Enabled = false;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!check)
                {
                    MessageBox.Show("Запись не выбрана...", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (DataGridView.CurrentRow.
                Cells["idUser"].Value.ToString()
                == DataBase.userId.ToString())
                {
                    MessageBox.Show("Запрещено удалять директора", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (DBUsers.HasDogovor(DataGridView.CurrentRow.
                    Cells["idUser"].Value.ToString()))
                {
                    MessageBox.Show("Невозможно выполнить, так как" +
                        " с данным менеджером заключен договор", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (MessageBox.Show("Удалить запись?", "",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    DataBase.Export("users");
                    BtnUndo.Enabled = true;
                    DBUsers.lastId = Convert.ToInt32(DataGridView.CurrentRow.
                    Cells["idUser"].Value.ToString());
                    DBUsers.Delete();
                    check = false;
                }
                dtUsers = DBUsers.Get($"and isDeleted = '0' {wSearch} {wRole}");
                DataGridView.DataSource = dtUsers;
                DGWArchive.DataSource =
                DBUsers.Get($"and isDeleted = '1' {wSearch} {wRole}");
                if (DBUsers.lastId == DataBase.userId)
                {
                    Main.closeAppWithoutConfirm = true;
                    Application.Restart();
                }
            }
            catch
            {

            }

        }

        private void BtnBack_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }

        private void CBRole_SelectedIndexChanged
            (object sender, EventArgs e)
        {
            TBSearch.Text = "";
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            TBSearch.Text = "";
            wSearch = "";
            wRole = "";
            DataGridView.DataSource = DBUsers.Get
                ($"and isDeleted = '0' {wSearch} {wRole}");
            DGWArchive.DataSource =
            DBUsers.Get($"and isDeleted = '1' {wSearch} {wRole}");
        }

        private void CBArchive_CheckedChanged(object sender, EventArgs e)
        {
            DGWArchive.Visible = CBArchive.Checked;
            BtnRestore.Visible = CBArchive.Checked;
        }

        private void BtnRestore_Click(object sender, EventArgs e)
        {
            DataBase.Export("users");
            BtnUndo.Enabled = true;
            DBUsers.lastId = Convert.ToInt32(DGWArchive.CurrentRow.
                Cells["idUser1"].Value.ToString());
            DBUsers.Restore();
            DataGridView.DataSource = DBUsers.Get
                ($"and isDeleted = '0' {wSearch} {wRole}");
            DGWArchive.DataSource =
            DBUsers.Get($"and isDeleted = '1' {wSearch} {wRole}");
        }

        private void BtnResetPass_Click(object sender, EventArgs e)
        {
            try
            {
                if (!check)
                {
                    MessageBox.Show("Запись не выбрана...", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DataBase.Export("users");
                BtnUndo.Enabled = true;
                DBUsers.lastId = Convert.ToInt32(DataGridView.CurrentRow.
                    Cells["idUser"].Value.ToString());
                DBUsers.PassReset(DataGridView.CurrentRow.
                    Cells["fio"].Value.ToString());
            }
            catch
            {

            }
            
        }

        private void DGWArchive_CellClick
            (object sender, DataGridViewCellEventArgs e)
        {
            check = false;
            BtnRestore.Enabled = true;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DataBase.Import("users");
            DataGridView.DataSource =
                DBUsers.Get($"and isDeleted = '0' {wSearch} {wRole}");
            DGWArchive.DataSource =
            DBUsers.Get($"and isDeleted = '1' {wSearch} {wRole}");
            BtnUndo.Enabled = false;
        }

        private void CBRole_SelectionChangeCommitted
            (object sender, EventArgs e)
        {
            wRole = $"AND users.codeRole = '{CBRole.SelectedValue}'";
            DataGridView.DataSource = 
                DBUsers.Get($"and isDeleted = '0' {wSearch} {wRole}");
            DGWArchive.DataSource =
            DBUsers.Get($"and isDeleted = '1' {wSearch} {wRole}");
        }
    }
}
