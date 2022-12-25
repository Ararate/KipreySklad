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
    public partial class AddStoraging : Form
    {
        public AddStoraging()
        {
            InitializeComponent();
        }
        private bool isProgramChange;
        public Button BtnUndo;
        private static DataTable dtDogovori = new DataTable();
        public string idDogovor, idPlace, cX,cY,cZ, weight,
            desc, dateBegin, dateEnd, andAdress, andType, perBegin,perEnd;
        public string linked;

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

        private void CBAdress_SelectionChangeCommitted
            (object sender, EventArgs e)
        {
            andAdress = 
                $" and places.idStorage  = '{CBAdress.SelectedValue}' ";
            CBPlace.DataSource = DBPlaces.Combo
                (andAdress + andType, dateBegin, dateEnd);
            CBPlace.DropDownWidth = DropDownWidth(CBPlace);
        }

        private void CBType_SelectionChangeCommitted
            (object sender, EventArgs e)
        {
            andType = $" and types.codeType = '{CBType.SelectedValue}' ";
            CBPlace.DataSource = DBPlaces.Combo
                (andAdress + andType, dateBegin, dateEnd);
            CBAdress.DataSource = DBStorages.Get
                ($" AND storages.codeType = '{CBType.SelectedValue}'");
        }

        private void DPEnd_ValueChanged(object sender, EventArgs e)
        {
            if (isProgramChange)
                return;
            if (DPEnd.Value < DPBegin.Value)
            {
                isProgramChange = true;
                DPBegin.Value = DPEnd.Value;
                isProgramChange = false;
            }
            dateEnd = DPEnd.Value.ToString("yyyy-MM-dd");
            CBPlace.DataSource = DBPlaces.Combo
                (andAdress + andType, dateBegin, dateEnd);
            try
            {
                if (FormStoraging.editing)
                CBPlace.SelectedValue = idPlace;
            }
            catch
            {
            }
        }

        private void DPBegin_ValueChanged(object sender, EventArgs e)
        {
            if (isProgramChange)
                return;
            if (DPBegin.Value > DPEnd.Value)
            {
                isProgramChange = true;
                DPEnd.Value = DPBegin.Value;
                isProgramChange = false;
            }
            dateBegin = DPBegin.Value.ToString("yyyy-MM-dd");
            CBPlace.DataSource = DBPlaces.Combo
                (andAdress + andType, dateBegin, dateEnd);
            try
            {
                if (FormStoraging.editing)
                    CBPlace.SelectedValue = idPlace;
            }
            catch
            {
            }
        }

        private void CBPlace_SelectionChangeCommitted
            (object sender, EventArgs e)
        {
            DataBase.msCommand.CommandText = $"SELECT idStorage FROM" +
                $" places WHERE idPlace = '{CBPlace.SelectedValue}';";
            CBAdress.SelectedValue = Convert.ToInt32
                (DataBase.msCommand.ExecuteScalar());
            CBAdress.DropDownWidth = DropDownWidth(CBAdress);
        }

        private void LabelShowAll_Click(object sender, EventArgs e)
        {
            CBAdress.DataSource = DBStorages.Get("");
            andType = "";
            andAdress = "";
            CBPlace.DataSource = DBPlaces.Combo
                (andAdress + andType, dateBegin, dateEnd);
            CBPlace.DropDownWidth = DropDownWidth(CBPlace);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TBWeight_KeyPress(object sender, KeyPressEventArgs e)
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

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (TBX.Text == "" ||
                TBZ.Text == "" || TBY.Text == "" || TBWeight.Text == ""
                || CBPlace.Text == "" || CBAdress.Text == ""
                || TBDesc.Text == "")
            {
                MessageBox.Show("Поля должны быть заполнены", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 

            if (CBPlace.SelectedValue.ToString() == idPlace &&
            TBX.Text == cX && TBZ.Text == cZ &&
            TBY.Text == cY && TBWeight.Text == weight
            && TBDesc.Text == desc &&
            DPBegin.Value == Convert.ToDateTime(perEnd) &&
            DPEnd.Value == Convert.ToDateTime(perBegin))
            {
                Close();
                return;
            }
            
            if (!DBStoraging.Fits(TBX.Text, TBY.Text, 
                TBZ.Text, CBPlace.SelectedValue.ToString()))
            {
                MessageBox.Show("Груз не подходит по размерам", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataBase.Export("storaging");
            BtnUndo.Enabled = true;

            if (FormStoraging.editing)
            {
                DBStoraging.Edit(idDogovor,
                    CBPlace.SelectedValue.ToString(),
                    TBX.Text, TBY.Text, TBZ.Text, TBWeight.Text, TBDesc.Text,
                    DPBegin.Value.ToString("yyyy-MM-dd"),
                    DPEnd.Value.ToString("yyyy-MM-dd"));
            }
            else
            {
                DBStoraging.Add(idDogovor,
                    CBPlace.SelectedValue.ToString(),
                    TBX.Text, TBY.Text, TBZ.Text, TBWeight.Text, TBDesc.Text, 
                    DPBegin.Value.ToString("yyyy-MM-dd"),
                    DPEnd.Value.ToString("yyyy-MM-dd"));
            }
            Close();
        }

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

        private void AddStoraging_Load(object sender, EventArgs e)
        {
            CBType.DataSource = DBTypes.Combo();
            CBType.DisplayMember = "type";
            CBType.ValueMember = "codeType";

            CBAdress.DataSource = DBStorages.Get("");
            CBAdress.DisplayMember = "adress";
            CBAdress.ValueMember = "idStorage";


            isProgramChange = true;
            dtDogovori = DBDogovori.Get();
            DPBegin.MinDate = Convert.ToDateTime
                (dtDogovori.Select($"idDogovor = " +
                $"{idDogovor}")
                [0]["dataBegin"]);
            DPBegin.MaxDate = Convert.ToDateTime
                (dtDogovori.Select($"idDogovor = " +
                $"{idDogovor}")
                [0]["dataEnd"]);
            DPEnd.MinDate = DPBegin.MinDate;
            DPEnd.MaxDate = DPBegin.MaxDate;

            if (FormStoraging.editing)
            {
                DPBegin.Value = Convert.ToDateTime(perBegin);
                DPEnd.Value = Convert.ToDateTime(perEnd);
            }
            else
            {
                DPBegin.Value = DPBegin.MinDate;
                DPEnd.Value = DPBegin.MinDate;
            }
            isProgramChange = false;
            dateEnd = DPEnd.Value.ToString("yyyy-MM-dd");
            dateBegin = DPBegin.Value.ToString("yyyy-MM-dd");

            CBPlace.DataSource = DBPlaces.Combo
                ("", dateBegin, dateEnd);
            CBPlace.DisplayMember = "size";
            CBPlace.ValueMember = "idPlace";
            CBPlace.SelectedValue = idPlace;

            CBAdress.DropDownWidth = DropDownWidth(CBAdress);
            CBType.DropDownWidth = DropDownWidth(CBType);

            TBX.Text = cX;
            TBZ.Text = cZ;
            TBY.Text = cY;
            TBWeight.Text = weight;
            TBDesc.Text = desc;
            
        }

        static public int DropDownWidth(ComboBox myCombo)
        {
            int maxWidth = myCombo.Width, temp;
            DataRowView rowView;
            foreach (var obj in myCombo.Items)
            {
                rowView = obj as DataRowView;
                if (rowView != null)
                {
                    temp = TextRenderer.MeasureText
                        (rowView[myCombo.DisplayMember].
                        ToString(), myCombo.Font).Width;
                    if (temp > maxWidth)
                    {
                        maxWidth = temp;
                    }
                }
            }
            return maxWidth;
        }
    }
}
