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
    public partial class FormStoraging : Form
    {
        public FormStoraging()
        {
            InitializeComponent();
        }
        private static DataTable dtStoraging = new DataTable();
        public static bool editing = false;
        private bool check = false;
        private static string whereDesc, whereDate;
        public string linked;

        private void BtnReset_Click(object sender, EventArgs e)
        {
            whereDate = "";
            whereDesc = "";
            TBSearch.Text = "";
            dtStoraging = DBStoraging.Get($"{linked}");
            DataGridView.DataSource = dtStoraging;
        }

        private void TBSearch_TextChanged(object sender, EventArgs e)
        {
            whereDesc = $"AND storaging.desc LIKE '%{TBSearch.Text}%'";
            dtStoraging = DBStoraging.
                Get($"{whereDesc} {whereDate} {linked}");
            DataGridView.DataSource = dtStoraging;
        }

        private void DPBegin_ValueChanged(object sender, EventArgs e)
        {
            if (DPBegin.Value > DPEnd.Value)
            {
                DPBegin.Value = DPEnd.Value;
            }
            whereDate = $"AND (dogovori.dataBegin BETWEEN " +
                $"'{DPBegin.Value:yyyy-MM-dd}' AND " +
                $"'{DPEnd.Value:yyyy-MM-dd}')";
            dtStoraging = DBStoraging.
                Get($"{whereDesc} {whereDate} {linked}");
            DataGridView.DataSource = dtStoraging;
        }

        private void DPEnd_ValueChanged(object sender, EventArgs e)
        {
            if (DPEnd.Value < DPBegin.Value)
            {
                DPEnd.Value = DPBegin.Value;
            }
            whereDate = $"AND (dogovori.dataBegin BETWEEN" +
                $" '{DPBegin.Value:yyyy-MM-dd}' " +
                $"AND '{DPEnd.Value:yyyy-MM-dd}')";
            dtStoraging = DBStoraging.
                Get($"{whereDesc} {whereDate} {linked}");
            DataGridView.DataSource = dtStoraging;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            DataBase.Export("storaging");
            DBStoraging.lastId = -1;
            editing = false;

            AddStoraging addop = new AddStoraging
            {
                Text = "Новая запись",
                BtnUndo = BtnCancel,
                linked = linked,
                idDogovor = linked.Split('\'')[1],
                weight = null,
                cX = null,
                cZ = null,
                cY = null,
                idPlace = "0",
                desc = null,
                perBegin = Convert.ToString(DateTime.Today),
                perEnd = Convert.ToString(DateTime.Today)
            };
            //if (linked != "")
            //    addop.CBDogovor.Enabled = false;
            addop.ShowDialog();
            dtStoraging = DBStoraging.Get($"{linked}");
            DataGridView.DataSource = dtStoraging;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (!check)
            {
                MessageBox.Show("Запись не выбрана...", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataBase.Export("storaging");
            DBStoraging.lastId = Convert.ToInt32(DataGridView.CurrentRow.
                Cells["idStoraging"].Value.ToString());
            editing = true;
            AddStoraging addU = new AddStoraging
            {
                Text = "Изменение данных",
                BtnUndo = BtnCancel,
                linked = linked
            };
            addU.idDogovor = DataGridView.CurrentRow.
                Cells["idDogovor"].Value.ToString();

            addU.idPlace = DataGridView.CurrentRow.
                Cells["idPlace"].Value.ToString();

            addU.cX = DataGridView.CurrentRow.
                Cells["cargoX"].Value.ToString();

            addU.cY = DataGridView.CurrentRow.
                Cells["cargoY"].Value.ToString();

            addU.cZ = DataGridView.CurrentRow.
                Cells["cargoZ"].Value.ToString();

            addU.weight = DataGridView.CurrentRow.
                Cells["weight"].Value.ToString();

            addU.desc = DataGridView.CurrentRow.
                Cells["desc"].Value.ToString();

            addU.perBegin = DataGridView.CurrentRow.
                Cells["perBegin"].Value.ToString();

            addU.perEnd = DataGridView.CurrentRow.
                Cells["perEnd"].Value.ToString();

            addU.ShowDialog();
            dtStoraging = DBStoraging.Get($"{linked}");
            DataGridView.DataSource = dtStoraging;

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
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
                DataBase.Export("storaging");
                BtnCancel.Enabled = true;
                DBStoraging.lastId = Convert.ToInt32(DataGridView.CurrentRow.
                Cells["idStoraging"].Value.ToString());
                DBStoraging.Delete();
                dtStoraging = DBStoraging.Get($"{linked}");
                DataGridView.DataSource = dtStoraging;
                check = false;
            }
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
            DataBase.Import("storaging");
            DataGridView.DataSource = DBStoraging.Get($"{linked}");
            BtnCancel.Enabled = false;
        }

        private void FormStoraging_Load(object sender, EventArgs e)
        {
            DataGridView.DataSource = DBStoraging.Get($"{linked}");
            if (linked != "")
            {
                PanelDate.Visible = false;
            }
            else
                PanelBtn.Visible = false;
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
    }
}
