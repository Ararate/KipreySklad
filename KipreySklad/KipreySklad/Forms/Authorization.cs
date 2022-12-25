using KipreySklad.Classes;
using KipreySklad.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KipreySklad
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }
        private void CBShow_CheckedChanged(object sender, EventArgs e)
        {
            TBpassword.UseSystemPasswordChar = !CBShow.Checked;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (DataBase.Authorization(TBlogin.Text, TBpassword.Text))
            {
                Main mm = new Main();
                mm.Show();
                Hide();
            }
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            if (!DataBase.Connect())
            {
                MessageBox.Show($"Ошибка при подключении к базе данных," +
                    $" необходимо изменить данные для подключения", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Visible = false; 
                ShowInTaskbar = false; 
                Opacity = 0;

                DBData dbd = new DBData();
                dbd.auth = this;
                dbd.Show();
            }
        }
    }
}
