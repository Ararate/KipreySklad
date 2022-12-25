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
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }
        public Button BtnUndo;
        public static string fio, phone, passport;

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TBName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }

            if (Char.IsLetter(e.KeyChar) && TBName.Text.Length == 0)
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
            }
        }

        private void TBSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }

            if (Char.IsLetter(e.KeyChar) && TBSurname.Text.Length == 0)
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
            }
        }

        private void TBOtch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }

            if (Char.IsLetter(e.KeyChar) && TBOtch.Text.Length == 0)
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            if (TBName.Text == "" || TBSurname.Text == "" ||
                TBOtch.Text == "" || TBPhone.Text.Length != 18 || 
                TBPassport.Text.Length != 11)
            {
                MessageBox.Show("Поля должны быть заполнены", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ((TBSurname.Text + TBName.Text + TBOtch.Text) ==
                fio && TBPhone.Text == phone && 
                TBPassport.Text == passport)
            {
                Close();
                return;
            }

            if (DBClients.AlreadyExists(TBPhone.Text, "phone") ||
                DBClients.AlreadyExists(TBPassport.Text, "passport"))
            {
                MessageBox.Show("Не должны повторяться:" +
                    " телефон, паспорт", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataBase.Export("clients");
            BtnUndo.Enabled = true;
            if (FormClients.editing)
            {
                DBClients.Edit(TBSurname.Text + ' ' + TBName.Text + ' ' +
                    TBOtch.Text, TBPhone.Text, TBPassport.Text);
            }
            else
            {
                DBClients.Add(TBSurname.Text + ' ' + TBName.Text + ' ' +
                    TBOtch.Text, TBPhone.Text, TBPassport.Text);
            }
            Close();
            return;

        }

        private void AddClient_Load(object sender, EventArgs e)
        {
            if (FormClients.editing)
            {
                TBName.Text = fio.Split(' ')[1];
                TBSurname.Text = fio.Split(' ')[0];
                TBOtch.Text = fio.Split(' ')[2];
            }
            TBPassport.Text = passport;
            TBPhone.Text = phone;
        }
    }
}
