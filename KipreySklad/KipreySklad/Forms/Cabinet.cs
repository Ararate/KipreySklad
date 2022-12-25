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
    public partial class Cabinet : Form
    {
        private static DataTable dtUser = new DataTable();
        public Cabinet()
        {
            InitializeComponent();
        }

        private void Cabinet_Load(object sender, EventArgs e)
        {
            dtUser = DBUsers.Get($"and users.idUser = '{DataBase.userId}'");
            LabFio.Text = dtUser.Rows[0]["fio"].ToString();
            LabLogin.Text = dtUser.Rows[0]["login"].ToString();
            LabRole.Text = dtUser.Rows[0]["role"].ToString();
            LabPhone.Text = dtUser.Rows[0]["phone"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBUsers.lastId = DataBase.userId;
            FormUsers.editing = true;
            AddUser addU = new AddUser
            {
                Text = "Изменение данных",
                BtnUndo = BtnUndo
            };

            AddUser.login = dtUser.Rows[0]["login"].ToString();

            AddUser.codeRole = dtUser.Rows[0]["codeRole"].ToString();

            AddUser.fio = dtUser.Rows[0]["fio"].ToString();

            AddUser.phone = dtUser.Rows[0]["phone"].ToString();


            addU.ShowDialog();
            dtUser = DBUsers.Get($"and users.idUser = '{DataBase.userId}'");
            LabFio.Text = dtUser.Rows[0]["fio"].ToString();
            LabLogin.Text = dtUser.Rows[0]["login"].ToString();
            LabRole.Text = dtUser.Rows[0]["role"].ToString();
            LabPhone.Text = dtUser.Rows[0]["phone"].ToString();
        }

        private void EditPass_Click(object sender, EventArgs e)
        {
            NewPassword np = new NewPassword();
            np.ShowDialog();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DataBase.Import("users");
            BtnUndo.Enabled = false;
            dtUser = DBUsers.Get($"and users.idUser = '{DataBase.userId}'");
            LabFio.Text = dtUser.Rows[0]["fio"].ToString();
            LabLogin.Text = dtUser.Rows[0]["login"].ToString();
            LabRole.Text = dtUser.Rows[0]["role"].ToString();
            LabPhone.Text = dtUser.Rows[0]["phone"].ToString();
        }
    }
}
