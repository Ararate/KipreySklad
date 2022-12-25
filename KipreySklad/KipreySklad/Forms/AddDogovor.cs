using KipreySklad.Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace KipreySklad.Forms
{
    public partial class AddDogovor : Form
    {
        public AddDogovor()
        {
            InitializeComponent();
        }
        public Button BtnUndo;
        public static string idClient, dataBegin, dataEnd;
        private static DataTable dtClients = new DataTable();

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (CBClient.Text == "")
            {
                return;
            }
            if (CBClient.SelectedValue.ToString() == idClient &&
                DPBegin.Value == Convert.ToDateTime(dataBegin) &&
                DPEnd.Value == Convert.ToDateTime(dataEnd))
            {
                Close();
                return;
            }
            int enti;
            if (RBphysClient.Checked)
                enti = 0;
            else
                enti = 1;
            DataBase.Export("dogovori");
            BtnUndo.Enabled = true;
            if (FormDogovori.editing)
            {
                DBDogovori.Edit(DataBase.userId.ToString(),
                    CBClient.SelectedValue.ToString(),
                    DPBegin.Value.ToString("yyyy-MM-dd"), 
                    DPEnd.Value.ToString("yyyy-MM-dd"),enti);
            }
            else
            {
                DBDogovori.Add(DataBase.userId.ToString(),
                    CBClient.SelectedValue.ToString(), 
                    DPBegin.Value.ToString("yyyy-MM-dd"),
                    DPEnd.Value.ToString("yyyy-MM-dd"),enti);
            }
            Close();
        }

        private void RBphysClient_Click(object sender, EventArgs e)
        {
            dtClients = DBClients.Get("");
            CBClient.DataSource = dtClients;
            CBClient.DisplayMember = "fio";
            CBClient.ValueMember = "idClient";
        }

        private void RBUrclient_Click(object sender, EventArgs e)
        {
            TBSearch.Text = "";
            dtClients = DBUrClients.Get("");
            CBClient.DataSource = dtClients;
            CBClient.DisplayMember = "firmName";
            CBClient.ValueMember = "okpo";
        }

        private void DPBegin_ValueChanged(object sender, EventArgs e)
        {
            if (DPBegin.Value > DPEnd.Value)
            {
                DPEnd.Value = DPBegin.Value;
            }
        }

        private void DPEnd_ValueChanged(object sender, EventArgs e)
        {
            if (DPEnd.Value < DPBegin.Value)
            {
                DPBegin.Value = DPEnd.Value;
            }
        }

        private void CBClient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TBSearch_TextChanged(object sender, EventArgs e)
        {
            if (RBphysClient.Checked)
                CBClient.DataSource = DBClients.Get($" WHERE " +
                $"fio LIKE '%{TBSearch.Text}%'");
            else
                CBClient.DataSource = DBUrClients.Get($" WHERE " +
                $"firmName LIKE '%{TBSearch.Text}%'");
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddDogovor_Load(object sender, EventArgs e)
        {
            if (!FormDogovori.enti)
            {
                RBphysClient.Checked = true;
                CBClient.DataSource = DBClients.Get("");
                CBClient.DisplayMember = "fio";
                CBClient.ValueMember = "idClient";
            }
            else
            {
                RBUrclient.Checked = true;
                CBClient.DataSource = DBUrClients.Get("");
                CBClient.DisplayMember = "firmName";
                CBClient.ValueMember = "okpo";
            }
            if (FormDogovori.editing)
            {
                CBClient.SelectedValue = idClient;
            }
            DPBegin.Value = Convert.ToDateTime(dataBegin);
            DPEnd.Value = Convert.ToDateTime(dataEnd);
            DPBegin.MinDate = DateTime.Today;
            DPEnd.MinDate = DateTime.Today;
        }
    }
}
