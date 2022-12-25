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
    public partial class FormDogovori : Form
    {
        public FormDogovori()
        {
            InitializeComponent();
        }
        public static bool editing = false;
        private static bool check = false;
        public static bool enti;
        private string searchCol, andMyDogs, searchText;

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            DBDogovori.lastId = -1;
            AddDogovor.dataBegin = Convert.ToString(DateTime.Today);
            AddDogovor.dataEnd = Convert.ToString(DateTime.Today);
            AddDogovor addty = new AddDogovor
            {
                Text = "Новый договор",
                BtnUndo = BtnCancel
            };
            addty.ShowDialog();
            DGW.DataSource = DBDogovori.Get(searchText + andMyDogs, enti);

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (!check)
            {
                MessageBox.Show("Договор не выбран...", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DBDogovori.lastId = Convert.ToInt32(DGW.CurrentRow.
                Cells["idDogovor"].Value.ToString());
            editing = true;
            AddDogovor addU = new AddDogovor
            {
                Text = "Изменение данных",
                BtnUndo = BtnCancel
            };

            AddDogovor.idClient = DGW.CurrentRow.
                Cells["idClient"].Value.ToString();

            AddDogovor.dataBegin = DGW.CurrentRow.
                Cells["dataBegin"].Value.ToString();

            AddDogovor.dataEnd = DGW.CurrentRow.
                Cells["dataEnd"].Value.ToString();

            addU.ShowDialog();
            DGW.DataSource = DBDogovori.Get(searchText + andMyDogs, enti);

        }

        private void FormDogovori_Load(object sender, EventArgs e)
        {
            check = false;
            searchCol = "clients.fio";
            enti = false;
            RBphysClient.Checked = true;

            if (DataBase.role == 2 || DataBase.role == 3)
            {
                BtnEdit.Enabled = false;
                BtnAdd.Enabled = false;
                BtnDelete.Enabled = false;
                CBMyDogs.Visible = false;
            }
            DGW.DataSource = DBDogovori.Get(searchText + andMyDogs, enti);
            int diff;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (!check)
            {
                MessageBox.Show("Договор не выбран...", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DBDogovori.HasStoraging(DGW.CurrentRow.
                Cells["idDogovor"].Value.ToString()))
            {
                if (MessageBox.Show("В договоре есть данные, удалить?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.No)
                    return;
            }
            else
            if (MessageBox.Show("Удалить договор?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.No)
            {
                
            }
            DataBase.Export("dogovori");
            BtnCancel.Enabled = true;
            DBDogovori.lastId = Convert.ToInt32(DGW.CurrentRow.
            Cells["idDogovor"].Value.ToString());
            DBDogovori.Delete();
            DGW.DataSource = DBDogovori.Get(searchText + andMyDogs, enti);
            check = false;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TBSearch_TextChanged(object sender, EventArgs e)
        {
            check = false;
            if (TBSearch.Text != "")
                searchText = $" AND {searchCol} LIKE '%{TBSearch.Text}%' ";
            else
                searchText = "";
            DGW.DataSource = DBDogovori.Get(searchText + andMyDogs, enti);

        }

        private void RBphysClient_Click(object sender, EventArgs e)
        {
            try
            {
                TBSearch.Text = "";
                searchCol = "clients.fio";
                enti = false;
                DGW.DataSource = DBDogovori.Get(searchText + andMyDogs, enti);

            }
            catch
            {

            }

        }

        private void RBUrclient_Click(object sender, EventArgs e)
        {
            try
            {
                TBSearch.Text = "";
                searchCol = "uridclients.firmName";
                check = false;

                enti = true;
                DGW.DataSource = DBDogovori.Get(searchText + andMyDogs, enti);

            }
            catch
            {

            }
        }

        private void DataGridView_CellDoubleClick
            (object sender, DataGridViewCellEventArgs e)
        {

            FormStoraging fd = new FormStoraging
            {
                linked = $" and dogovori.idDogovor = " +
                $"'{DGW.CurrentRow.Cells["idDogovor"].Value}'",
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            Controls.Add(fd);
            Tag = fd;
            LabelHeader.Text = $"Договор № " +
                $"{DGW.CurrentRow.Cells["idDogovor"].Value} " +
                $"({Convert.ToDateTime(DGW.CurrentRow.Cells["dataBegin"].Value):dd.MM.yyyy}" +
                $" - {Convert.ToDateTime(DGW.CurrentRow.Cells["dataEnd"].Value):dd.MM.yyyy})";

            fd.BringToFront();
            fd.Show();
            if (!BtnEdit.Enabled)
            {
                fd.PanelBtn.Enabled = false;
            }
        }

        private void BtnBack_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BtnBack_MouseEnter(object sender, EventArgs e)
        {
            LabelHeader.Text = "Договоры";
        }

        private void BtnOutput_Click(object sender, EventArgs e)
        {
            if (!check)
                return;
            ChooseDogovor fd = new ChooseDogovor();
            ChooseDogovor.linked =
                $"{DGW.CurrentRow.Cells["idDogovor"].Value}";
            fd.ShowDialog();
        }

        private void DataGridView_CellClick
            (object sender, DataGridViewCellEventArgs e)
        {
            check = true;
            if (Convert.ToInt32(DGW.CurrentRow.Cells
                ["idUser"].Value) == DataBase.userId)
            {
                BtnEdit.Enabled = true;
                BtnDelete.Enabled = true;
            }
            else
            {
                BtnEdit.Enabled = false;
                BtnDelete.Enabled = false;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DataBase.Import("dogovori");
            DGW.DataSource = DBDogovori.Get(searchText + andMyDogs, enti);
            BtnCancel.Enabled = false;

        }


        private void DGW_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            int diff;
            foreach (DataGridViewRow row in DGW.Rows)
            {
                diff = (DateTime.Today - Convert.ToDateTime(row.
                    Cells["dataEnd"].Value)).Duration().Days;
                if (diff < 14 && diff > 0)
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                }
                if (DateTime.Today > Convert.ToDateTime(row.
                    Cells["dataEnd"].Value))
                {
                    row.DefaultCellStyle.BackColor =
                        Color.FromArgb(255, 107, 107);
                }
                if (Convert.ToInt32(row.Cells["idUser"].Value)
                    == DataBase.userId)
                {
                    row.Cells["fio"].Style.BackColor
                        = Color.FromArgb(150, 154, 255);
                }
            }
        }


        private void CBMyDogs_CheckedChanged(object sender, EventArgs e)
        {
            if (CBMyDogs.Checked)
                andMyDogs = $" AND users.idUser = '{DataBase.userId}' ";
            else
                andMyDogs = " ";
            DGW.DataSource = DBDogovori.Get(searchText + andMyDogs, enti);
        }
    }
}
