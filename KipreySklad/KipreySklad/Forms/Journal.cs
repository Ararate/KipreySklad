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

namespace KipreySklad.Forms
{
    public partial class Journal : Form
    {
        public Journal()
        {
            InitializeComponent();
        }

        private void Journal_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("Log.txt");
                string line = sr.ReadLine();
                while (line != null)
                {
                    textBox1.AppendText($"{line}");
                    textBox1.AppendText(Environment.NewLine);
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch
            {

            }
            
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
