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
    public partial class NewPassword : Form
    {
        public NewPassword()
        {
            InitializeComponent();
        }

        private void NewPassword_Load(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (DBUsers.Get($"and users.password = md5('{TBPass.Text}') " +
                $"and users.idUser = '{DataBase.userId}'").Rows.Count == 0)
            {
                MessageBox.Show("Текущий " +
                    "пароль введён неверно", "",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (TBPass1.Text != TBPass2.Text)
            {
                MessageBox.Show("Пароли не совпадают", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DBUsers.lastId = DataBase.userId;
            DBUsers.EditPassw(TBPass2.Text);
            Close();
        }

        private void CBShow_CheckedChanged(object sender, EventArgs e)
        {
            TBPass.UseSystemPasswordChar = !CBShow.Checked;
            TBPass1.UseSystemPasswordChar = !CBShow.Checked;
            TBPass2.UseSystemPasswordChar = !CBShow.Checked;
        }
    }
}
