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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }
        public Button BtnUndo;
        public static string login, codeRole, fio, phone;
        private static DataTable dtRoles = new DataTable();

        private void TBFio_KeyPress(object sender, KeyPressEventArgs e)
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

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (TBName.Text == "" || TBSurname.Text == "" ||
                TBOtch.Text == "" || TBLogin.Text == "" 
                 || TBPhone.Text.Length != 18)
            {
                MessageBox.Show("Поля должны быть заполнены", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ((TBSurname.Text + TBName.Text + TBOtch.Text) ==
                fio && TBLogin.Text == login 
                 && TBPhone.Text == phone &&
                CBRole.SelectedValue.ToString() == codeRole)
            {
                Close();
                return;
            }

            if (DBUsers.AlreadyExists(TBLogin.Text, "login"))
            {
                MessageBox.Show("Не должны повторяться: логины, телефоны", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DBUsers.AlreadyExists(TBPhone.Text, "phone"))
            {
                MessageBox.Show("Повторение логинов не допускается", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataBase.Export("users");
            BtnUndo.Enabled = true;
            if (FormUsers.editing)
            {
                DBUsers.Edit(CBRole.SelectedValue.ToString(),
                TBSurname.Text + ' ' + TBName.Text + ' ' + TBOtch.Text,
                TBPhone.Text, TBLogin.Text);
            }
            else
            {
                DBUsers.Add(CBRole.SelectedValue.ToString(),
                TBSurname.Text + ' ' + TBName.Text + ' ' + TBOtch.Text,
                TBPhone.Text, TBLogin.Text);
            }
            if (DBUsers.lastId == DataBase.userId &&
                CBRole.SelectedValue.ToString() != "3")
            {
                Main.closeAppWithoutConfirm = true;
                Application.Restart();
            }    
            Close();
            return;

        }


        private void AddUser_Load(object sender, EventArgs e)
        {
            int rc = DBUsers.Get($"and isDeleted = 0 and users.codeRole = '3' and users.idUser <> " +
                $"{DBUsers.lastId}").Rows.Count;
            if (rc == 0 && codeRole == "3")
                CBRole.Enabled = false;
            else
                CBRole.Enabled = true;
            dtRoles = DBRoles.Get();
            CBRole.DataSource = dtRoles;
            CBRole.DisplayMember = "role";
            CBRole.ValueMember = "codeRole";
            if (FormUsers.editing)
            {
                TBName.Text = fio.Split(' ')[1];
                TBSurname.Text = fio.Split(' ')[0];
                TBOtch.Text = fio.Split(' ')[2];
                CBRole.SelectedValue = codeRole;
            }
                
            if (DataBase.role != 0 && DataBase.role != 3)
            {
                panel6.Visible = false;
                label6.Visible = false;
            }
            TBPhone.Text = phone; 
            TBLogin.Text = login;
        }
    }
}
