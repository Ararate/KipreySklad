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
    public partial class AddPlace : Form
    {
        public AddPlace()
        {
            InitializeComponent();
        }
        public Button BtnUndo;
        public static string idStorage, cX, cY, cZ, cost;
        private static DataTable dtStorages = new DataTable();

        private void TBX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void TBY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void TBCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void TBZ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (TBX.Text == "" || 
                TBZ.Text == "" || TBY.Text == "" || TBCost.Text == "")
            {
                MessageBox.Show("Поля должны быть заполнены", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (TBX.Text == cX &&
                TBZ.Text == cZ && TBY.Text == cY && TBCost.Text == cost && 
                CBStorage.SelectedValue.ToString() == idStorage)
            {
                Close();
                return;
            }
            if (Convert.ToInt32(TBX.Text) == 0 ||
                Convert.ToInt32(TBY.Text) == 0 || 
                Convert.ToInt32(TBZ.Text) == 0)
            {
                MessageBox.Show("Введены некорректные значения", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataBase.Export("places");
            DataBase.Export("storaging");
            BtnUndo.Enabled = true;

            if (FormPlaces.editing)
            {
                DBPlaces.Edit(CBStorage.SelectedValue.ToString(),
                    TBX.Text, TBY.Text, TBZ.Text, TBCost.Text);
            }
            else
            {
                DBPlaces.Add(CBStorage.SelectedValue.ToString(),
                    TBX.Text, TBY.Text, TBZ.Text, TBCost.Text);
            }
            DBPlaces.Get("");
            Close();
        }

        private void AddPlace_Load(object sender, EventArgs e)
        {
            dtStorages = DBStorages.Get("");
            CBStorage.DataSource = dtStorages;
            CBStorage.DisplayMember = "adress";
            CBStorage.ValueMember = "idStorage";


            if (FormPlaces.editing)
                CBStorage.SelectedValue = idStorage;
            TBX.Text = cX;
            TBZ.Text = cZ;
            TBY.Text = cY;
            TBCost.Text = cost;
            if (FormPlaces.linked != "")
                CBStorage.SelectedValue =idStorage;
            if (DBPlaces.IsNowUsed(DBPlaces.lastId.ToString())
                && FormPlaces.editing)
            {
                panel3.Enabled = false;
            }
            else
                panel3.Enabled = true;
        }
    }
}
