using KipreySklad.Classes;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using excel = Microsoft.Office.Interop.Excel;
using word = Microsoft.Office.Interop.Word;

namespace KipreySklad.Forms
{
	public partial class Main : Form
	{
		public static bool closeAppWithoutConfirm = false;
		public Main()
		{
			InitializeComponent();
		}
		public void OpenChildForm(Form childForm)
		{
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			panelDesktopPane.Controls.Add(childForm);
			panelDesktopPane.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
		}
		private void выходToolStripMenuItem_Click
			(object sender, EventArgs e)
		{
			closeAppWithoutConfirm = true;
			Application.Restart();
		}

		private void учётныеЗаписиToolStripMenuItem_Click
			(object sender, EventArgs e)
		{
			OpenChildForm(new FormUsers());
		}

		private void хранениеГрузовToolStripMenuItem_Click
			(object sender, EventArgs e)
		{
			FormStoraging fs = new FormStoraging
			{
				linked = ""
			};
			OpenChildForm(fs);
		}

		private void клиентыToolStripMenuItem_Click
			(object sender, EventArgs e)
		{
			OpenChildForm(new FormClients());
		}

		private void договорыToolStripMenuItem1_Click
			(object sender, EventArgs e)
		{
			OpenChildForm(new FormDogovori());
		}

		private void местаToolStripMenuItem_Click
			(object sender, EventArgs e)
		{
			FormPlaces.linked = "";
			OpenChildForm(new FormPlaces());
		}

		private void складыToolStripMenuItem1_Click
			(object sender, EventArgs e)
		{
			OpenChildForm(new FormStorages());
		}

		private void типГрузаToolStripMenuItem_Click
			(object sender, EventArgs e)
		{
			OpenChildForm(new FormTypes());
		}

		private void Main_Load(object sender, EventArgs e)
		{
			HelpProvider1.HelpNamespace = $@"{Environment.CurrentDirectory}\Help\Help.html";
			формированиеToolStripMenuItem.Visible = true;
			клиентыToolStripMenuItem.Visible = true;
			договорыToolStripMenuItem1.Visible = true;
			компанииToolStripMenuItem.Visible = true;
			сервисToolStripMenuItem.Visible = true;
			личныйКабинетToolStripMenuItem.Visible = true;
			учётныеЗаписиToolStripMenuItem.Visible = true;
			LabelName.Text = DataBase.fio;
			switch (DataBase.role)
			{
				case 1:
					формированиеToolStripMenuItem.Visible = false;
					сервисToolStripMenuItem.Visible = false;
					учётныеЗаписиToolStripMenuItem.Visible = false;
					break;
				case 2:
					формированиеToolStripMenuItem.Visible = false;
					клиентыToolStripMenuItem.Visible = false;
					договорыToolStripMenuItem1.Visible = false;
					компанииToolStripMenuItem.Visible = false;
					сервисToolStripMenuItem.Visible = false;
					учётныеЗаписиToolStripMenuItem.Visible = false;
					break;
				case 3:
					break;
				case 0:
					личныйКабинетToolStripMenuItem.Visible = false;
					break;
			}
		}

		private void компанииToolStripMenuItem_Click
			(object sender, EventArgs e)
		{
			OpenChildForm(new FormUrClients());
		}


		private void счётПоДоговоруToolStripMenuItem_Click
			(object sender, EventArgs e)
		{
			ChooseDogovor.linked = "";
			ChooseDogovor form = new ChooseDogovor();
			form.ShowDialog();
		}

		private void Main_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (closeAppWithoutConfirm)
				return;
			if (MessageBox.Show("Завершить работу?", "Подтвердите действие",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
			{
				e.Cancel = true;
				closeAppWithoutConfirm = false;
			}
			else
			{
				closeAppWithoutConfirm = true;
				Controls.Clear();
				Application.Exit();
			}
		}

		private void личныйКабинетToolStripMenuItem_Click
			(object sender, EventArgs e)
		{
			OpenChildForm(new Cabinet());
		}

		private void docToolStripMenuItem_Click(object sender, EventArgs e)
		{			
			CheckForIllegalCrossThreadCalls = false;
			Progress p = new Progress();
			p.Show();
			p.TarifDoc();
		}

		private void журналПосещенийToolStripMenuItem_Click
			(object sender, EventArgs e)
		{
			OpenChildForm(new Journal());
		}

		private void выгрузитьБазуДанныхToolStripMenuItem_Click
			(object sender, EventArgs e)
		{
			DataBase.Export();
		}

		private void загрузитьБазуДанныхToolStripMenuItem_Click
			(object sender, EventArgs e)
		{
			if (MessageBox.Show("Несохранённые данные" +
				" будут потеряны без возможности восстановления. Продолжить?", "",
			MessageBoxButtons.YesNo, MessageBoxIcon.Question)
			== DialogResult.Yes)
				DataBase.Import();
		}

		private void pdfToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CheckForIllegalCrossThreadCalls = false;
			Progress p = new Progress();
			p.Show();
			p.TarifPdf();
		}

		private void формированиеToolStripMenuItem_DropDownOpened
			(object sender, EventArgs e)
		{
			формированиеToolStripMenuItem.ForeColor = Color.Black;

		}

		private void формированиеToolStripMenuItem_DropDownClosed
			(object sender, EventArgs e)
		{
			формированиеToolStripMenuItem.ForeColor = Color.White;
		}

		private void договорыToolStripMenuItem_DropDownOpened
			(object sender, EventArgs e)
		{
			договорыToolStripMenuItem.ForeColor = Color.Black;
		}

		private void договорыToolStripMenuItem_DropDownClosed
			(object sender, EventArgs e)
		{
			договорыToolStripMenuItem.ForeColor = Color.White;
		}

		private void складыToolStripMenuItem_DropDownClosed
			(object sender, EventArgs e)
		{
			складыToolStripMenuItem.ForeColor = Color.White;
		}

		private void складыToolStripMenuItem_DropDownOpened
			(object sender, EventArgs e)
		{
			складыToolStripMenuItem.ForeColor = Color.Black;
		}

		private void типыГрузаToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenChildForm(new FormTypes());
		}

		private void сервисToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
		{
			сервисToolStripMenuItem.ForeColor = Color.White;
		}

		private void сервисToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
		{
			сервисToolStripMenuItem.ForeColor = Color.Black;
		}
	}

}
