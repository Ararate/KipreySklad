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
    public partial class AddStorage : Form
    {
        public AddStorage()
        {
            InitializeComponent();
        }
        public Button BtnUndo;
        private static DataTable dtTypes = new DataTable();
        public static string codeType, adress;

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (TBAdress.Text == "")
            {
                MessageBox.Show("Поля должны быть заполнены", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (TBAdress.Text == adress && 
                CBType.SelectedValue.ToString() == codeType)
            {
                Close();
                return;
            }
            if (DBStorages.AlreadyExists(TBAdress.Text, "adress"))
            {
                MessageBox.Show("Склад с таким адресом был добавлен ранее",
                    "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataBase.Export("storages");
            BtnUndo.Enabled = true;

            if (FormStorages.editing)
            {
                DBStorages.Edit(CBType.SelectedValue.ToString(), 
                    TBAdress.Text);
            }
            else
            {
                DBStorages.Add(CBType.SelectedValue.ToString(),
                    TBAdress.Text);
            }
            DBStorages.Get("");
            Close();
            return;

        }

        private void AddStorage_Load(object sender, EventArgs e)
        {
            dtTypes = DBTypes.Combo();
            CBType.DataSource = dtTypes;
            CBType.DisplayMember = "type";
            CBType.ValueMember = "codeType";

            if (FormStorages.editing)
                CBType.SelectedValue = codeType;
            TBAdress.Text = adress;
        }
    }
}
