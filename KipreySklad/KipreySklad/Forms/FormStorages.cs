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

namespace KipreySklad.Forms
{
    public partial class FormStorages : Form
    {
        public FormStorages()
        {
            InitializeComponent();
        }
        private static DataTable dtStorages = new DataTable();
        public static bool editing = false;
        private static bool check = false;
        public void OpenChildForm(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Controls.Add(childForm);
            Tag = childForm;
            LabelHeader.Text = $"Склад  " +
                $"{DataGridView.CurrentRow.Cells["adress"].Value}";
            childForm.BringToFront();
            childForm.Show();
        }

        private void FormStorages_Load(object sender, EventArgs e)
        {
            check = false;
            dtStorages = DBStorages.Get("");
            DataGridView.DataSource = dtStorages;
            if (DataBase.role == 1 || DataBase.role == 2)
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

        private void DataGridView_CellClick
            (object sender, DataGridViewCellEventArgs e)
        {
            check = true;
        }

        private void TBSearch_TextChanged
            (object sender, EventArgs e)
        {
            dtStorages = DBStorages.Get
                ($"and storages.adress LIKE '%{TBSearch.Text}%'");
            if (TBSearch.Text == "")
            {
                dtStorages = DBStorages.Get("");
            }
            DataGridView.DataSource = dtStorages;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            DBStorages.lastId = -1;
            editing = false;
            AddStorage.codeType = null;
            AddStorage.adress = null;
            AddStorage addty = new AddStorage
            {
                Text = "Новая запись",
                BtnUndo = BtnCancel
            };
            addty.ShowDialog();
            dtStorages = DBStorages.Get("");
            DataGridView.DataSource = dtStorages;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (!check)
            {
                MessageBox.Show("Запись не выбрана...", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DBStorages.lastId = Convert.ToInt32(DataGridView.CurrentRow.
                Cells["idStorage"].Value.ToString());
            editing = true;
            AddStorage addU = new AddStorage
            {
                Text = "Изменение данных",
                BtnUndo = BtnCancel
            };

            AddStorage.codeType = DataGridView.CurrentRow.
                Cells["codeType"].Value.ToString();

            AddStorage.adress = DataGridView.CurrentRow.
                Cells["adress"].Value.ToString();

            addU.ShowDialog();
            dtStorages = DBStorages.Get("");
            DataGridView.DataSource = dtStorages;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (!check)
            {
                MessageBox.Show("Запись не выбрана...", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Удалить запись?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                DataBase.Export("storages");
                BtnCancel.Enabled = true;
                DBStorages.lastId = Convert.ToInt32(DataGridView.CurrentRow.
                Cells["idStorage"].Value.ToString());
                DBStorages.Delete();
                DataGridView.DataSource = DBStorages.Get("");
                check = false;
            }
        }

        private void BtnBack_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }

        private void DataGridView_CellDoubleClick
            (object sender, DataGridViewCellEventArgs e)
        {
            FormPlaces fd = new FormPlaces();
            FormPlaces.linked = $" and places.idStorage = " +
                $"'{DataGridView.CurrentRow.Cells["idStorage"].Value}'";
            OpenChildForm(fd);
        }

        private void BtnBack_MouseEnter(object sender, EventArgs e)
        {
            LabelHeader.Text = "Склады";
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DataBase.Import("storages");
            DataGridView.DataSource = DBStorages.Get("");
            BtnCancel.Enabled = false;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
