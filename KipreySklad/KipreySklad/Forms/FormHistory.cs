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
    public partial class FormHistory : Form
    {
        public FormHistory()
        {
            InitializeComponent();
        }
        public string idPlace, linked;

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void DPBegin_ValueChanged(object sender, EventArgs e)
        {
            DataGridView.DataSource = DBHistory.Get($"{linked} and" +
                $" pricehistory.priceDate <= " +
                $"'{DPPriceDate.Value:yyyy-MM-dd}'" +
                $" ORDER BY pricehistory.priceDate DESC LIMIT 1 ");
            if (DataGridView.Rows.Count == 0)
                DataGridView.DataSource = DBHistory.Get($"{linked} " +
                    $"and pricehistory.priceDate >=" +
                    $" '{DPPriceDate.Value:yyyy-MM-dd}'" +
                    $" ORDER BY pricehistory.priceDate ASC LIMIT 1");
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            DataGridView.DataSource = 
                DBHistory.Get(linked + "ORDER BY priceDate DESC");
        }

        private void FormHistory_Load(object sender, EventArgs e)
        {
            DataGridView.DataSource = 
                DBHistory.Get(linked + "ORDER BY priceDate DESC");
        }
    }
}
