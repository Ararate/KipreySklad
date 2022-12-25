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
    public partial class FormPlaces : Form
    {
        public FormPlaces()
        {
            InitializeComponent();
        }
        private static DataTable dtCombo = new DataTable();
        public static bool editing = false;
        private static bool check = false;
        public static string linked;


        private void FormPlaces_Load(object sender, EventArgs e)
        {
            DataGridView.DataSource = DBPlaces.Get($"{linked}");
            
            dtCombo = DBStorages.Get("");
            CBStorage.DataSource = dtCombo;
            CBStorage.DisplayMember = "adress";
            CBStorage.ValueMember = "idStorage";

            PanelSearch.Visible = (linked == "");
            check = false;


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

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DataBase.Export("places");
                DataBase.Export("storaging");
                //DBPlaces.lastId = Convert.ToInt32(DataGridView.CurrentRow.
                //    Cells["idPlace"].Value.ToString());
                editing = false;
                AddPlace.idStorage = null;
                AddPlace.cX = null;
                AddPlace.cY = null;
                AddPlace.cZ = null;
                AddPlace addty = new AddPlace
                {
                    Text = "Новая запись",
                    BtnUndo = BtnCancel
                };
                addty.ShowDialog();
                DataGridView.DataSource = DBPlaces.Get($"{linked}");
            }
            catch
            {

            }
        }

        private void DataGridView_CellClick
            (object sender, DataGridViewCellEventArgs e)
        {
            check = true;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (!check)
            {
                MessageBox.Show("Запись не выбрана...", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DBPlaces.lastId = Convert.ToInt32(DataGridView.CurrentRow.
                Cells["idPlace"].Value.ToString());
            editing = true;
            AddPlace addU = new AddPlace
            {
                Text = "Изменение данных",
                BtnUndo = BtnCancel
            };

            AddPlace.idStorage = DataGridView.CurrentRow.
                Cells["idStorage"].Value.ToString();

            AddPlace.cX = DataGridView.CurrentRow.
                Cells["placeX"].Value.ToString();

            AddPlace.cY = DataGridView.CurrentRow.
                Cells["placeY"].Value.ToString();

            AddPlace.cZ = DataGridView.CurrentRow.
                Cells["placeZ"].Value.ToString();

            AddPlace.cost = DataGridView.CurrentRow.
                Cells["cost"].Value.ToString();

            addU.ShowDialog();
            DataGridView.DataSource = DBPlaces.Get($"{linked}");
        }

        private void CBType_SelectionChangeCommitted
            (object sender, EventArgs e)
        {
            DataGridView.DataSource = DBPlaces.Get
                ($"AND places.idStorage =" +
                $" '{CBStorage.SelectedValue}'");
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            DataGridView.DataSource = DBPlaces.Get("");
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
                DataBase.Export("places");
                BtnCancel.Enabled = true;
                DBPlaces.lastId = Convert.ToInt32(DataGridView.CurrentRow.
                Cells["idPlace"].Value.ToString());
                DBPlaces.Delete();
                DataGridView.DataSource = DBPlaces.Get($"{linked}");
                check = false;
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnBack_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DataBase.Import("places");
            DataGridView.DataSource = DBPlaces.Get($"{linked}");
            BtnCancel.Enabled = false;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (!check)
            {
                MessageBox.Show("Запись не выбрана...", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            FormHistory fd = new FormHistory
            {
                linked = $" where idPlace = " +
                $"'{DataGridView.CurrentRow.Cells["idPlace"].Value}'",
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            Controls.Add(fd);
            Tag = fd;
            LabelHeader.Text = $"Место № " +
                $"{DataGridView.CurrentRow.Cells["idPlace"].Value} ";

            fd.BringToFront();
            fd.Show();
        }

        private void BtnBack_MouseEnter(object sender, EventArgs e)
        {
            LabelHeader.Text = "Места";
        }

        private void DataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in DataGridView.Rows)
            {
                if (DBPlaces.IsNowUsed(row.Cells["idPlace"].Value.ToString()))
                {
                    row.DefaultCellStyle.BackColor =
                    Color.FromArgb(255, 254, 181);
                }
            }
        }
    }
}
