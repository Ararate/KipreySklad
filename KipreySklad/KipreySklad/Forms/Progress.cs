using KipreySklad.Classes;
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
using excel = Microsoft.Office.Interop.Excel;
using word = Microsoft.Office.Interop.Word;

namespace KipreySklad.Forms
{
	public partial class Progress : Form
	{
		public Progress()
		{
			InitializeComponent();
		}

		private void Progress_Load(object sender, EventArgs e)
		{

		}

		public async void DogovorPdf(string idDog)
		{
			await Task.Run(() =>
			{
				word.Document doc;
				var app = new word.Application
				{
					Visible = false
				};
				doc = app.Documents.Open($@"{Environment.CurrentDirectory}\" +
						"счёт.doc");
				try
				{
					DataBase.msCommand.CommandText =
						"SELECT storaging.perBegin, storaging.perEnd, " +
						"Storaging.storeCost, places.cost ,CONCAT" +
						"(Storaging.cargoX,'x',Storaging.cargoY,'x'," +
						"Storaging.cargoZ) as size, CONCAT(clients.fio, " +
						"' тел.',clients.phone ) as client from " +
						"storaging,places,clients,dogovori where" +
						" (storaging.idPlace = places.idPlace) and" +
						" (dogovori.idDogovor = storaging.idDogovor) and " +
						"(clients.idClient = dogovori.idClient)and dogovori." +
						$"idDogovor = '{idDog}'" +
						$" and dogovori.entity = '0';";
					DataBase.msCommand.ExecuteNonQuery();
					System.Data.DataTable dt = new System.Data.DataTable();
					DataBase.msDataAdapter.Fill(dt);
					DataBase.msCommand.CommandText =
						"SELECT storaging.perBegin, storaging.perEnd, " +
						"Storaging.storeCost, places.cost,CONCAT" +
						"(Storaging.cargoX,'x',Storaging.cargoY,'x',Storaging." +
						"cargoZ) as size, CONCAT(uridclients.firmName, ' '," +
						"uridclients.urArdes, ' тел.',uridclients.firmPhone)" +
						" as client" +
						" from storaging," +
						"places,uridclients,dogovori where (storaging.idPlace =" +
						" places.idPlace) and (dogovori.idDogovor = storaging." +
						"idDogovor) and (uridclients.okpo = dogovori.idClient)" +
						$"and dogovori.idDogovor = '{idDog}'" +
						$" and dogovori.entity = '1';";
					DataBase.msCommand.ExecuteNonQuery();
					System.Data.DataTable d1 = new System.Data.DataTable();
					DataBase.msDataAdapter.Fill(d1);
					dt.Merge(d1);

					Show();
					DocProgress.Maximum = dt.Rows.Count + 1;

					if (dt.Rows.Count == 0)
					{
						MessageBox.Show("Нет записей",
						"", MessageBoxButtons.OK,
						MessageBoxIcon.Information);
						doc.Close();
						app.Quit();
						File.Delete($@"{Environment.CurrentDirectory}\счёт.doc");
						File.Copy($@"{Environment.CurrentDirectory}\d\счёт.doc",
							$@"{Environment.CurrentDirectory}\счёт.doc");
						Close();
						return;
					};
					DataBase.msCommand.CommandText =
						$"SELECT users.fio" +
							$" from users, dogovori where users.idUser =" +
							$" dogovori.idUser and " +
							$"dogovori.idDogovor = '{idDog}';";
					DataBase.msCommand.ExecuteNonQuery();
					System.Data.DataTable usr = new System.Data.DataTable();
					DataBase.msDataAdapter.Fill(usr);
					doc.Activate();
					doc.Bookmarks["date"].Range.Text =
						DateTime.Today.ToString("D");
					doc.Bookmarks["managerFio"].Range.Text =
						usr.Rows[0]["fio"].ToString();
					doc.Bookmarks["clientName"].Range.Text =
						dt.Rows[0]["client"].ToString();
					word.Table tbl = doc.Tables[4];
					int itog, i;
					itog = 0;
					DocProgress.PerformStep();
					for (i = 0; i <= dt.Rows.Count - 1; i++)
					{
						tbl.Cell(i + 2, 1).Range.Text = (i + 1).ToString();
						tbl.Cell(i + 2, 2).Range.Text =
						$"Хранение груза размером " +
							$"{dt.Rows[i]["size"]} ";
						tbl.Cell(i + 2, 3).Range.Text = ((Convert.ToDateTime
							(dt.Rows[i]["perEnd"]) -
							Convert.ToDateTime(dt.Rows[i]["perBegin"]))
							.Days + 1).ToString();
						tbl.Cell(i + 2, 4).Range.Text = "Дней";
						tbl.Cell(i + 2, 5).Range.Text = (Convert.ToInt32(dt.Rows[i]
							["storeCost"]) / ((Convert.ToDateTime
							(dt.Rows[i]["perEnd"]) -
							Convert.ToDateTime(dt.Rows[i]["perBegin"]))
							.Days + 1)).ToString();
						tbl.Cell(i + 2, 6).Range.Text = dt.Rows[i]
							["storeCost"].ToString();
						itog += Convert.ToInt32(dt.Rows[i]
							["storeCost"]);
						if (i < dt.Rows.Count - 1)
							tbl.Rows.Add();
						DocProgress.PerformStep();
					}
					doc.Bookmarks["itog"].Range.Text = itog.ToString();
					doc.Bookmarks["nds"].Range.Text = (itog * 0.1).ToString();
					doc.Bookmarks["itog1"].Range.Text = (itog * 1.1).ToString();
					doc.Bookmarks["n"].Range.Text = i.ToString();
					doc.Bookmarks["itog2"].Range.Text = (itog * 1.1).ToString();
					doc.SaveAs2($@"Счёт договор номер {idDog}.pdf",
						word.WdSaveFormat.wdFormatPDF);
					MessageBox.Show("Документ сформирован",
					"", MessageBoxButtons.OK,
					MessageBoxIcon.Information);
					
				}
				catch
				{
					MessageBox.Show
						("Ошибка, закройте word или попробуйте снова",
					"Information", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				}
				doc.Close();
				app.Quit();
				File.Delete($@"{Environment.CurrentDirectory}\счёт.doc");
				File.Copy($@"{Environment.CurrentDirectory}\d\счёт.doc",
					$@"{Environment.CurrentDirectory}\счёт.doc");
				Close();
			});

		}


		public async void DogovorDoc(string idDog)
		{
			await Task.Run(() =>
			{
				word.Document doc = null;
				var app = new word.Application
				{
					Visible = false
				};
				doc = app.Documents.Open($@"{Environment.CurrentDirectory}\" +
						"счёт.doc");
				try
				{
					DataBase.msCommand.CommandText =
						"SELECT storaging.perBegin, storaging.perEnd, " +
						"Storaging.storeCost, places.cost ,CONCAT" +
						"(Storaging.cargoX,'x',Storaging.cargoY,'x'," +
						"Storaging.cargoZ) as size, CONCAT(clients.fio, " +
						"' тел.',clients.phone ) as client from " +
						"storaging,places,clients,dogovori where" +
						" (storaging.idPlace = places.idPlace) and" +
						" (dogovori.idDogovor = storaging.idDogovor) and " +
						"(clients.idClient = dogovori.idClient)and dogovori." +
						$"idDogovor = '{idDog}'" +
						$" and dogovori.entity = '0';";
					DataBase.msCommand.ExecuteNonQuery();
					System.Data.DataTable dt = new System.Data.DataTable();
					DataBase.msDataAdapter.Fill(dt);
					DataBase.msCommand.CommandText =
						"SELECT storaging.perBegin, storaging.perEnd, " +
						"Storaging.storeCost, places.cost,CONCAT" +
						"(Storaging.cargoX,'x',Storaging.cargoY,'x',Storaging." +
						"cargoZ) as size, CONCAT(uridclients.firmName, ' '," +
						"uridclients.urArdes, ' тел.',uridclients.firmPhone)" +
						" as client" +
						" from storaging," +
						"places,uridclients,dogovori where (storaging.idPlace =" +
						" places.idPlace) and (dogovori.idDogovor = storaging." +
						"idDogovor) and (uridclients.okpo = dogovori.idClient)" +
						$"and dogovori.idDogovor = '{idDog}'" +
						$" and dogovori.entity = '1';";
					DataBase.msCommand.ExecuteNonQuery();
					System.Data.DataTable d1 = new System.Data.DataTable();
					DataBase.msDataAdapter.Fill(d1);
					dt.Merge(d1);

					Show();
					DocProgress.Maximum = dt.Rows.Count + 1;

					if (dt.Rows.Count == 0)
					{
						MessageBox.Show("Нет записей",
						"", MessageBoxButtons.OK,
						MessageBoxIcon.Information);
						doc.Close();
						app.Quit();
						Close();
						return;
					};
					DataBase.msCommand.CommandText =
						$"SELECT users.fio" +
							$" from users, dogovori where users.idUser =" +
							$" dogovori.idUser and " +
							$"dogovori.idDogovor = '{idDog}';";
					DataBase.msCommand.ExecuteNonQuery();
					System.Data.DataTable usr = new System.Data.DataTable();
					DataBase.msDataAdapter.Fill(usr);
					doc.Activate();
					doc.Bookmarks["date"].Range.Text =
						DateTime.Today.ToString("D");
					doc.Bookmarks["managerFio"].Range.Text =
						usr.Rows[0]["fio"].ToString();
					doc.Bookmarks["clientName"].Range.Text =
						dt.Rows[0]["client"].ToString();
					word.Table tbl = doc.Tables[4];
					int itog, i;
					itog = 0;
					DocProgress.PerformStep();
					for (i = 0; i <= dt.Rows.Count - 1; i++)
					{
						tbl.Cell(i + 2, 1).Range.Text = (i + 1).ToString();
						tbl.Cell(i + 2, 2).Range.Text =
						$"Хранение груза размером " +
							$"{dt.Rows[i]["size"]} ";
						tbl.Cell(i + 2, 3).Range.Text = ((Convert.ToDateTime
							(dt.Rows[i]["perEnd"]) -
							Convert.ToDateTime(dt.Rows[i]["perBegin"]))
							.Days + 1).ToString();
						tbl.Cell(i + 2, 4).Range.Text = "Дней";
						tbl.Cell(i + 2, 5).Range.Text = (Convert.ToInt32(dt.Rows[i]
							["storeCost"]) / ((Convert.ToDateTime
							(dt.Rows[i]["perEnd"]) -
							Convert.ToDateTime(dt.Rows[i]["perBegin"]))
							.Days + 1)).ToString();
						tbl.Cell(i + 2, 6).Range.Text = dt.Rows[i]
							["storeCost"].ToString();
						itog += Convert.ToInt32(dt.Rows[i]
							["storeCost"]);
						if (i < dt.Rows.Count - 1)
							tbl.Rows.Add();
						DocProgress.PerformStep();
					}
					doc.Bookmarks["itog"].Range.Text = itog.ToString();
					doc.Bookmarks["nds"].Range.Text = (itog * 0.1).ToString();
					doc.Bookmarks["itog1"].Range.Text = (itog * 1.1).ToString();
					doc.Bookmarks["n"].Range.Text = i.ToString();
					doc.Bookmarks["itog2"].Range.Text = (itog * 1.1).ToString();

					doc.SaveAs2($@"Счёт договор номер {idDog}.doc");
					MessageBox.Show("Документ сформирован",
					"", MessageBoxButtons.OK,
					MessageBoxIcon.Information);
				}
				catch
				{
					MessageBox.Show("Ошибка, закройте word или попробуйте снова",
					"Information", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				}
				doc.Close();
				app.Quit();
				Close();
			});

		}

		public async void TarifDoc()
		{
			await Task.Run(() =>
			{
				word.Document doc = null;
				var app = new word.Application
				{
					Visible = false
				};
				try
				{

					doc = app.Documents.Open($@"{Environment.CurrentDirectory}\" +
				"тариф.docx");
					DataBase.msCommand.CommandText =
					"SELECT * from storages, types WHERE storages.codeType = " +
					"types.codeType order by storages.idStorage asc";
					DataBase.msCommand.ExecuteNonQuery();
					DataTable dtStorages = new DataTable();
					DataBase.msDataAdapter.Fill(dtStorages);

					Show();
					DocProgress.Maximum = dtStorages.Rows.Count;

					if (dtStorages.Rows.Count == 0)
					{
						MessageBox.Show("Нет записей",
						"", MessageBoxButtons.OK,
						MessageBoxIcon.Information);
						doc.Close();
						app.Quit();
						Close();
						return;
					};
					doc.Activate();
					word.Table tbl = doc.Tables[1];
					DataTable dtPlaces = new DataTable();
					tbl.AllowAutoFit = false;
					foreach (DataRow row in dtStorages.Rows)
					{
						DocProgress.PerformStep();
						DataBase.msCommand.CommandText =
						$"SELECT cost, idPlace, " +
							$"CONCAT(places.placeX,'x', " +
							$"places.placeY,'x',places.placeZ) as size " +
							$"FROM places where places.idStorage = '{row["idStorage"]}'";
						DataBase.msCommand.ExecuteNonQuery();
						dtPlaces.Clear();
						DataBase.msDataAdapter.Fill(dtPlaces);
                        if (dtPlaces.Rows.Count == 0)
                            continue;
                        tbl.Rows.Add();
						tbl.Cell(tbl.Rows.Count, 1).Merge(tbl.Cell(tbl.Rows.Count, 2));
						tbl.Cell(tbl.Rows.Count, 1).Borders[word.WdBorderType.
							wdBorderLeft].LineStyle = word.WdLineStyle.wdLineStyleNone;
						tbl.Cell(tbl.Rows.Count, 1).Borders[word.WdBorderType.wdBorderRight]
							.LineStyle = word.WdLineStyle.wdLineStyleNone;
						tbl.Rows.Add();
						tbl.Cell(tbl.Rows.Count, 1).Borders[word.WdBorderType.wdBorderTop]
							.LineStyle = word.WdLineStyle.wdLineStyleNone;
						tbl.Cell(tbl.Rows.Count, 1).Borders[word.WdBorderType.wdBorderBottom]
							.LineStyle = word.WdLineStyle.wdLineStyleNone;
						tbl.Cell(tbl.Rows.Count, 1).Range.Text = row["adress"].
							ToString() + $" ({row["type"]})";
						tbl.Rows.Add();
						tbl.Rows.Add();
						tbl.Cell(tbl.Rows.Count, 1).Borders[word.WdBorderType.
							wdBorderTop].LineStyle = word.WdLineStyle.wdLineStyleSingle;
						tbl.Cell(tbl.Rows.Count, 1).Borders[word.WdBorderType.
							wdBorderBottom].LineStyle = word.WdLineStyle.wdLineStyleSingle;
						tbl.Cell(tbl.Rows.Count, 1).Borders[word.WdBorderType.
							wdBorderLeft].LineStyle = word.WdLineStyle.wdLineStyleSingle;
						tbl.Cell(tbl.Rows.Count, 1).Borders[word.WdBorderType.
							wdBorderRight].LineStyle = word.WdLineStyle.wdLineStyleSingle;
						tbl.Cell(tbl.Rows.Count, 1).Split(1, 2);
						tbl.Cell(tbl.Rows.Count, 1).Range.Text = "Размер";
						tbl.Cell(tbl.Rows.Count, 2).Range.Text = "Стоимость в день";

						for (int j = 0; j <= dtPlaces.Rows.Count - 1; j++)
						{
							tbl.Rows.Add();
							tbl.Cell(tbl.Rows.Count, 1).Range.Text =
								dtPlaces.Rows[j]["size"].ToString();
							tbl.Cell(tbl.Rows.Count, 2).Range.Text =
								dtPlaces.Rows[j]["cost"].ToString();
						}
					}
					doc.Bookmarks["date"].Range.Text = DateTime.Today.ToString("dd.MM.yyyy");
					doc.Bookmarks["fio"].Range.Text = DataBase.fio;

					doc.SaveAs2($@"Прайс лист Кипрей {DateTime.Today:dd-MM-yyyy}.docx");
					MessageBox.Show("Документ сформирован",
					"", MessageBoxButtons.OK,
					MessageBoxIcon.Information);
				}
				catch
				{
					MessageBox.Show("Ошибка, закройте word и попробуйте снова",
					"Information", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				}
				doc.Close();
				app.Quit();
				Close();
			});

		}
		public async void TarifPdf()
		{
			
			await Task.Run(() =>
			{
				word.Document doc = null;
				var app = new word.Application
				{
					Visible = false
				};
            try
            {
                doc = app.Documents.Open($@"{Environment.CurrentDirectory}\" +
						"тариф.docx");
					DataBase.msCommand.CommandText =
						"SELECT * from storages, types WHERE storages.codeType = " +
						"types.codeType order by storages.idStorage asc";
					DataBase.msCommand.ExecuteNonQuery();
					DataTable dtStorages = new DataTable();
					DataBase.msDataAdapter.Fill(dtStorages);
					DocProgress.Maximum = dtStorages.Rows.Count;
					if (dtStorages.Rows.Count == 0)
					{
						MessageBox.Show("Нет записей",
						"", MessageBoxButtons.OK,
						MessageBoxIcon.Information);
						doc.Close();
						app.Quit();
						Close();
						return;
					};
					doc.Activate();
					word.Table tbl = doc.Tables[1];
					DataTable dtPlaces = new DataTable();
					tbl.AllowAutoFit = false;
					foreach (DataRow row in dtStorages.Rows)
					{
						DocProgress.PerformStep();
						DataBase.msCommand.CommandText =
						$"SELECT cost, idPlace, " +
							$"CONCAT(places.placeX,'x', " +
							$"places.placeY,'x',places.placeZ) as size " +
							$"FROM places where places.idStorage = '{row["idStorage"]}'";
						DataBase.msCommand.ExecuteNonQuery();
						dtPlaces.Clear();
						DataBase.msDataAdapter.Fill(dtPlaces);
						if (dtPlaces.Rows.Count == 0)
							continue;
						tbl.Rows.Add();
						tbl.Cell(tbl.Rows.Count, 1).Merge(tbl.Cell(tbl.Rows.Count, 2));
						tbl.Cell(tbl.Rows.Count, 1).Borders[word.WdBorderType.
							wdBorderLeft].LineStyle = word.WdLineStyle.wdLineStyleNone;
						tbl.Cell(tbl.Rows.Count, 1).Borders[word.WdBorderType.wdBorderRight]
							.LineStyle = word.WdLineStyle.wdLineStyleNone;
						tbl.Rows.Add();
						tbl.Cell(tbl.Rows.Count, 1).Borders[word.WdBorderType.wdBorderTop]
							.LineStyle = word.WdLineStyle.wdLineStyleNone;
						tbl.Cell(tbl.Rows.Count, 1).Borders[word.WdBorderType.wdBorderBottom]
							.LineStyle = word.WdLineStyle.wdLineStyleNone;
						tbl.Cell(tbl.Rows.Count, 1).Range.Text = row["adress"].
							ToString() + " " + row["type"].ToString();
						tbl.Rows.Add();
						tbl.Rows.Add();
						tbl.Cell(tbl.Rows.Count, 1).Borders[word.WdBorderType.
							wdBorderTop].LineStyle = word.WdLineStyle.wdLineStyleSingle;
						tbl.Cell(tbl.Rows.Count, 1).Borders[word.WdBorderType.
							wdBorderBottom].LineStyle = word.WdLineStyle.wdLineStyleSingle;
						tbl.Cell(tbl.Rows.Count, 1).Borders[word.WdBorderType.
							wdBorderLeft].LineStyle = word.WdLineStyle.wdLineStyleSingle;
						tbl.Cell(tbl.Rows.Count, 1).Borders[word.WdBorderType.
							wdBorderRight].LineStyle = word.WdLineStyle.wdLineStyleSingle;
						tbl.Cell(tbl.Rows.Count, 1).Split(1, 2);

						tbl.Cell(tbl.Rows.Count, 1).Range.Text = "Размер";
						tbl.Cell(tbl.Rows.Count, 2).Range.Text = "Стоимость в день";

						for (int j = 0; j <= dtPlaces.Rows.Count - 1; j++)
						{
							tbl.Rows.Add();
							tbl.Cell(tbl.Rows.Count, 1).Range.Text =
								dtPlaces.Rows[j]["size"].ToString();
							tbl.Cell(tbl.Rows.Count, 2).Range.Text =
								dtPlaces.Rows[j]["cost"].ToString();
						}
					}
					doc.Bookmarks["date"].Range.Text = DateTime.Today.ToString("dd.MM.yyyy");
					doc.Bookmarks["fio"].Range.Text = DataBase.fio;

					doc.SaveAs2($@"Прайс лист Кипрей {DateTime.Today:dd-MM-yyyy}.pdf",
							word.WdSaveFormat.wdFormatPDF);
					MessageBox.Show("Документ сформирован",
					"", MessageBoxButtons.OK,
					MessageBoxIcon.Information);
					doc.Close();
					app.Quit();
					File.Delete($@"{Environment.CurrentDirectory}\тариф.docx");
					File.Copy($@"{Environment.CurrentDirectory}\d\тариф.docx",
						$@"{Environment.CurrentDirectory}\тариф.docx");
                }
                catch
                {
                    MessageBox.Show("Ошибка, закройте word и попробуйте снова",
                    "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    doc.Close();
                    app.Quit();
                }
				Close();
			});
			
		}
	}
}
