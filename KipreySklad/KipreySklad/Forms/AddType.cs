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
    public partial class AddType : Form
    {
        public AddType()
        {
            InitializeComponent();
        }
        public static string type;
        public Button BtnUndo;

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (TBName.Text == "")
            {
                MessageBox.Show("Поля должны быть заполнены", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (TBName.Text == type)
            {
                Close();
                return;
            }
            if (DBTypes.AlreadyExists(TBName.Text, "type"))
            {
                MessageBox.Show("Данный тип был добавлен ранее", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataBase.Export("types");
            BtnUndo.Enabled = true;

            if (FormTypes.editing)
            {
                DBTypes.Edit(TBName.Text);
            }
            else
            {
                DBTypes.Add(TBName.Text);
            }
            DBTypes.Get("");
            Close();
            return;

        }

        private void TBCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void AddType_Load(object sender, EventArgs e)
        {
            TBName.Text = type;
        }

        private void TBName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }
        }
    }
}
