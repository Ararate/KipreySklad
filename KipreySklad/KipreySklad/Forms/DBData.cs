using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KipreySklad.Classes
{
    public partial class DBData : Form
    {
        public DBData()
        {
            InitializeComponent();
        }
        public Form auth;
        private bool userClose = true;
        private void DBData_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("ServerData.txt");
            DSBox.Text = sr.ReadLine();
            UserBox.Text = sr.ReadLine();
            PasswordBox.Text = sr.ReadLine();
            EncBox.Text = sr.ReadLine();
            sr.Close();
        }

        private void DBData_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (userClose)
            if (MessageBox.Show("Завершить работу?", "Подтвердите действие",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) 
                == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sr = new StreamWriter("ServerData.txt");
            sr.WriteLine(DSBox.Text);
            sr.WriteLine(UserBox.Text);
            sr.WriteLine(PasswordBox.Text);
            sr.WriteLine(EncBox.Text);
            sr.Close();
            if (DataBase.Connect())
            {
                MessageBox.Show
                    ($"Подключение успешно установлено", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                auth.Visible = true;
                auth.ShowInTaskbar = true;
                auth.Opacity = 1;
                userClose = false;
                Close();
                auth.BringToFront();
            }
            else
            {
                MessageBox.Show
                    ($"Не удалось подключиться к базе данных", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CBShow_CheckedChanged(object sender, EventArgs e)
        {
            PasswordBox.UseSystemPasswordChar = !CBShow.Checked;
        }
    }
}
