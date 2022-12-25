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
    public partial class FormTypes : Form
    {
        public FormTypes()
        {
            InitializeComponent();
        }
        public static DataTable dtTypes = new DataTable();
        public static bool editing = false;
        private static bool check = false;

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            DBTypes.lastId = -1;
            editing = false;
            AddType.type = null;
            AddType addty = new AddType
            {
                Text = "Новая запись",
                BtnUndo = BtnCancel
            };
            addty.ShowDialog();
            dtTypes = DBTypes.Get("");
            DataGridView.DataSource = dtTypes;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (!check)
            {
                MessageBox.Show("Запись не выбрана...", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DBTypes.lastId = Convert.ToInt32(DataGridView.CurrentRow.
                Cells["codeType"].Value.ToString());
            editing = true;
            AddType addU = new AddType
            {
                Text = "Изменение данных",
                BtnUndo = BtnCancel
            };

            AddType.type = DataGridView.CurrentRow.
                Cells["type"].Value.ToString();

            addU.ShowDialog();
            dtTypes = DBTypes.Get("");
            DataGridView.DataSource = dtTypes;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (!check)
            {
                MessageBox.Show("Запись не выбрана...", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (DBTypes.HasStorage(
            DataGridView.CurrentRow.
            Cells["codeType"].Value.ToString()))
            {
                MessageBox.Show("Невозможно выполнить, так как " +
                    "данный тип привязан к одному из складов", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Удалить запись?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                DataBase.Export("types");
                BtnCancel.Enabled = true;
                DBTypes.lastId = Convert.ToInt32(DataGridView.CurrentRow.
                Cells["codeType"].Value.ToString());
                DBTypes.Delete();
                DataGridView.DataSource = DBTypes.Get("");
                check = false;
            }
        }

        private void FormTypes_Load(object sender, EventArgs e)
        {
            check = false;
            DataGridView.DataSource = DBTypes.Get("");
            if (DataBase.role == 2 || DataBase.role == 1)
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
            dtTypes = DBTypes.Get($"WHERE type LIKE '%{TBSearch.Text}%'");
            if (TBSearch.Text == "")
            {
                dtTypes = DBTypes.Get("");
            }
            DataGridView.DataSource = dtTypes;
        }

        private void DataGridView_CellClick
            (object sender, DataGridViewCellEventArgs e)
        {
            check = true;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DataBase.Import("types");
            DataGridView.DataSource = DBTypes.Get("");
            BtnCancel.Enabled = false;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
