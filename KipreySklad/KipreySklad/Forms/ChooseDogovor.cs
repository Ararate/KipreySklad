using KipreySklad.Classes;
using KipreySklad.Forms;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using excel = Microsoft.Office.Interop.Excel;
using word = Microsoft.Office.Interop.Word;

namespace KipreySklad.Forms
{
    public partial class ChooseDogovor : Form
    {
        public ChooseDogovor()
        {
            InitializeComponent();
        }
        public static string linked;
        private static System.Data.DataTable dtDogovori 
            = new System.Data.DataTable();
        private void ChooseDogovor_Load(object sender, EventArgs e)
        {
            dtDogovori = DBDogovori.Get();
            CBDogovor.DataSource = dtDogovori;
            CBDogovor.DisplayMember = "idDogovor";
            CBDogovor.ValueMember = "idDogovor";
            if (linked != "")
                CBDogovor.SelectedValue = linked;
        }

        private void BtnDoc_Click(object sender, EventArgs e)
        {
            if (CBDogovor.Items.Count == 0)
            {
                MessageBox.Show
                        ($"Нет данных", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CheckForIllegalCrossThreadCalls = false;
            Progress p = new Progress();
            p.Show();
            p.DogovorDoc(CBDogovor.SelectedValue.ToString());
        }

        private void BtnPdf_Click(object sender, EventArgs e)
        {
            if (CBDogovor.Items.Count == 0)
            {
                MessageBox.Show
                        ($"Нет данных", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CheckForIllegalCrossThreadCalls = false;
            Progress p = new Progress();
            p.Show();
            p.DogovorPdf(CBDogovor.SelectedValue.ToString());
        }

        private void BtnCsv_Click(object sender, EventArgs e)
        {
            int itog = 0;
            string idDogovor = CBDogovor.SelectedValue.ToString();
            excel.Application exl = new excel.Application();
            excel.Workbook wb;
            excel.Worksheet sh;
            wb = exl.Workbooks.Add(System.Reflection.Missing.Value);
            sh = (excel.Worksheet)wb.Sheets[1];
            sh.Name = $"Счёт договор номер {idDogovor}";
            int i = 3;

            DataBase.msCommand.CommandText =
               $"SELECT types.type, types.cost, storages.adress," +
                    " Storaging.storeCost" +
                    " from Storaging,places,storages,dogovori, types " +
                    " where (storaging.idPlace = places.idPlace) " +
                    $" and (places.idStorage = storages.idStorage)" +
                    $" and (dogovori.idDogovor = storaging.idDogovor)" +
                    $" and (types.codeType = storages.codeType)" +
                    $" and dogovori.idDogovor = {idDogovor};";
            var reader_list = DataBase.msCommand.ExecuteReader();
            if (!reader_list.HasRows)
            {
                MessageBox.Show("Нет данных", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                reader_list.Close();
                wb.Close(false);
                return;
            }
            sh.Columns["A"].ColumnWidth = 15;
                sh.Columns["B"].ColumnWidth = 50;
                sh.Columns["C"].ColumnWidth = 25;
                sh.Columns["D"].ColumnWidth = 20;

                sh.Cells[1, "A"] = $"Счёт договор номер {idDogovor}";
                sh.Range[sh.Cells[1, "A"], sh.Cells[1, "D"]].Merge();
                sh.Cells[1, "A"].HorizontalAlignment = -4108;
                sh.Cells[1, "A"].Font.Name = "Arial";
                sh.Cells[1, "A"].Font.Size = 12;
                sh.Cells[1, "A"].Font.Bold = true;

                sh.Cells[2, "A"] = "Тип груза";
                sh.Cells[2, "B"] = "Цена руб/день";
                sh.Cells[2, "C"] = "Адрес склада";
                sh.Cells[2, "D"] = "Стоимость хранения";

                sh.Cells[2, "A"].HorizontalAlignment = -4108;
                sh.Cells[2, "A"].Font.Name = "Arial";
                sh.Cells[2, "A"].Font.Size = 12;
                sh.Cells[2, "A"].Font.Bold = true;

                sh.Cells[2, "A"].Font.Name = "Arial";
                sh.Cells[2, "A"].Font.Size = 10;

                sh.Cells[2, "B"].Font.Name = "Arial";
                sh.Cells[2, "B"].Font.Size = 10;

                sh.Cells[2, "A"].HorizontalAlignment = -4108;
                sh.Cells[2, "A"].Font.Name = "Arial";
                sh.Cells[2, "A"].Font.Size = 10;
                sh.Cells[2, "A"].Font.Bold = true;

                sh.Cells[2, "B"].HorizontalAlignment = -4108;
                sh.Cells[2, "B"].Font.Name = "Arial";
                sh.Cells[2, "B"].Font.Size = 10;
                sh.Cells[2, "B"].Font.Bold = true;

                sh.Cells[2, "C"].HorizontalAlignment = -4108;
                sh.Cells[2, "C"].Font.Name = "Arial";
                sh.Cells[2, "C"].Font.Size = 10;
                sh.Cells[2, "C"].Font.Bold = true;

                sh.Cells[2, "D"].HorizontalAlignment = -4108;
                sh.Cells[2, "D"].Font.Name = "Arial";
                sh.Cells[2, "D"].Font.Size = 10;
                sh.Cells[2, "D"].Font.Bold = true;

                while (reader_list.Read())
                {


                    sh.Cells[i, "A"] = reader_list.GetString(0);
                    sh.Cells[i, "B"] = reader_list.GetString(1);
                    sh.Cells[i, "C"] = reader_list.GetString(2);
                    sh.Cells[i, "D"] = reader_list.GetString(3);

                    sh.Cells[i, "A"].Font.Name = "Arial";
                    sh.Cells[i, "A"].Font.Size = 10;

                    sh.Cells[i, "B"].Font.Name = "Arial";
                    sh.Cells[i, "B"].Font.Size = 10;

                    sh.Cells[i, "C"].Font.Name = "Arial";
                    sh.Cells[i, "C"].Font.Size = 10;

                    sh.Cells[i, "D"].Font.Name = "Arial";
                    sh.Cells[i, "D"].Font.Size = 10;
                    itog += Convert.ToInt32( reader_list.GetString(3));
                    i++;
                }

                sh.get_Range("A3", $"D{i - 1}").Cells.Borders.Weight =
                    excel.XlBorderWeight.xlThin;
                sh.get_Range($"C{i}", $"D{i}").Cells.Borders.Weight =
                    excel.XlBorderWeight.xlThin;
                sh.Cells[i, "D"] = itog;
                sh.Cells[i, "C"] = "Итого:";
                sh.Cells[i, "C"].Font.Bold = true;
                sh.Cells[i, "D"].Font.Bold = true;
                sh.Cells[i, "C"].HorizontalAlignment = XlHAlign.xlHAlignRight; ;
                reader_list.Close();
                wb.Close(true);


        }

        private void CBDogovor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            BtnPdf.Enabled = true;
            BtnDoc.Enabled = true;
        }
    }
}
