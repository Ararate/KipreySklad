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
	public partial class AddUrClient : Form
	{
		public AddUrClient()
		{
			InitializeComponent();
		}
		public static string adress, fio, phone, name, inn, bank, bik;
		public Button BtnUndo;


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
			if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
			{
				e.Handled = true;
				return;
			}

			if (char.IsLetter(e.KeyChar) && TBName.Text.Length == 0)
			{
				e.KeyChar = char.ToUpper(e.KeyChar);
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

        private void TBInn_KeyPress(object sender, KeyPressEventArgs e)
        {
			if (!(Char.IsDigit(e.KeyChar)))
			{
				if (e.KeyChar != (char)Keys.Back)
				{
					e.Handled = true;
				}
			}
		}

        private void TBokpo_KeyPress(object sender, KeyPressEventArgs e)
        {
			if (!(Char.IsDigit(e.KeyChar)))
			{
				if (e.KeyChar != (char)Keys.Back)
				{
					e.Handled = true;
				}
			}
		}

        private void AddUrClient_Load(object sender, EventArgs e)
        {
			if (FormUrClients.editing)
            {
				TBName.Text = fio.Split(' ')[1];
				TBSurname.Text = fio.Split(' ')[0];
				TBOtch.Text = fio.Split(' ')[2];
				TBokpo.Visible = false;
				label1.Visible = false;
			}
			else
            {
				label1.Visible = true;
				TBokpo.Enabled = true;
			}
			TBAdress.Text = adress;
			TBPhone.Text = phone;
			TBcompName.Text = name;
			TBBank.Text = bank; 
			TBBik.Text = bik; 
			TBInn.Text = inn;
		}

        private void BtnSave_Click(object sender, EventArgs e)
		{
			if (TBName.Text == "" || TBSurname.Text == "" ||
				TBOtch.Text == "" || TBAdress.Text == "" ||
				TBPhone.Text.Length != 18 || TBcompName.Text == "" ||
				TBBank.Text == "" || TBBik.Text.Length != 9 || 
				TBInn.Text.Length != 12 || (TBokpo.Text.Length != 8 
				&& TBokpo.Text.Length != 10 && !FormUrClients.editing))
			{
				MessageBox.Show("Поля должны быть правильно заполнены",
					"Ошибка",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if ((TBSurname.Text + TBName.Text + TBOtch.Text) ==
				fio && TBAdress.Text == adress &&
				TBPhone.Text == phone && TBcompName.Text == name && 
				TBBank.Text == bank && TBBik.Text == bik && TBInn.Text == inn)
			{
				Close();
				return;
			}
			if ((DBUrClients.AlreadyExists(TBokpo.Text, "okpo") &&
				!FormUrClients.editing) ||
				DBUrClients.AlreadyExists(TBPhone.Text, "firmPhone") ||
				DBUrClients.AlreadyExists(TBcompName.Text, "firmName") ||
				DBUrClients.AlreadyExists(TBAdress.Text, "urArdes") ||
				DBUrClients.AlreadyExists(TBBik.Text, "bik") ||
				DBUrClients.AlreadyExists(TBInn.Text, "inn"))
			{
				MessageBox.Show("Не должны повторяться:" +
					" название, адрес, телефон, ОКПО, БИК, ИНН", "Ошибка",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			DataBase.Export("uridclients");
			BtnUndo.Enabled = true;
			if (FormUrClients.editing)
			{
				DBUrClients.Edit(TBAdress.Text,
				TBSurname.Text + ' ' + TBName.Text + ' ' +
				TBOtch.Text, TBPhone.Text, TBcompName.Text, TBBik.Text,
				TBInn.Text, TBBank.Text);
			}
			else
			{
				DBUrClients.Add(TBokpo.Text, TBAdress.Text,
				TBSurname.Text + ' ' + TBName.Text + ' ' + 
				TBOtch.Text, TBPhone.Text, TBcompName.Text, TBBik.Text,
				TBInn.Text, TBBank.Text);
			}
			Close();
			return;
		}

		private void BtnBack_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
