
namespace KipreySklad.Forms
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.учётныеЗаписиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.договорыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.хранениеГрузовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.договорыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.компанииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.складыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.местаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.складыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.типыГрузаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сервисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.журналПосещенийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выгрузитьБазуДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьБазуДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.формированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.счётПоДоговоруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тарифНаМестаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.личныйКабинетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LabelAOKiprey = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.HelpProvider1 = new System.Windows.Forms.HelpProvider();
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.MenuStrip.SuspendLayout();
            this.panelDesktopPane.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.SystemColors.GrayText;
            this.MenuStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuStrip.Font = new System.Drawing.Font("Gadugi", 14F);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.учётныеЗаписиToolStripMenuItem,
            this.договорыToolStripMenuItem,
            this.складыToolStripMenuItem,
            this.сервисToolStripMenuItem,
            this.формированиеToolStripMenuItem,
            this.личныйКабинетToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.MenuStrip.Size = new System.Drawing.Size(216, 620);
            this.MenuStrip.TabIndex = 3;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // учётныеЗаписиToolStripMenuItem
            // 
            this.учётныеЗаписиToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.учётныеЗаписиToolStripMenuItem.Name = "учётныеЗаписиToolStripMenuItem";
            this.учётныеЗаписиToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.учётныеЗаписиToolStripMenuItem.Size = new System.Drawing.Size(215, 36);
            this.учётныеЗаписиToolStripMenuItem.Text = "Пользователи";
            this.учётныеЗаписиToolStripMenuItem.Click += new System.EventHandler(this.учётныеЗаписиToolStripMenuItem_Click);
            // 
            // договорыToolStripMenuItem
            // 
            this.договорыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.хранениеГрузовToolStripMenuItem,
            this.клиентыToolStripMenuItem,
            this.договорыToolStripMenuItem1,
            this.компанииToolStripMenuItem});
            this.договорыToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.договорыToolStripMenuItem.Name = "договорыToolStripMenuItem";
            this.договорыToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.договорыToolStripMenuItem.Size = new System.Drawing.Size(215, 36);
            this.договорыToolStripMenuItem.Text = "Работа с клиентами";
            this.договорыToolStripMenuItem.DropDownClosed += new System.EventHandler(this.договорыToolStripMenuItem_DropDownClosed);
            this.договорыToolStripMenuItem.DropDownOpened += new System.EventHandler(this.договорыToolStripMenuItem_DropDownOpened);
            // 
            // хранениеГрузовToolStripMenuItem
            // 
            this.хранениеГрузовToolStripMenuItem.Name = "хранениеГрузовToolStripMenuItem";
            this.хранениеГрузовToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.хранениеГрузовToolStripMenuItem.Text = "Хранение грузов";
            this.хранениеГрузовToolStripMenuItem.Click += new System.EventHandler(this.хранениеГрузовToolStripMenuItem_Click);
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.клиентыToolStripMenuItem.Text = "Физические клиенты";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // договорыToolStripMenuItem1
            // 
            this.договорыToolStripMenuItem1.Name = "договорыToolStripMenuItem1";
            this.договорыToolStripMenuItem1.Size = new System.Drawing.Size(243, 26);
            this.договорыToolStripMenuItem1.Text = "Договоры";
            this.договорыToolStripMenuItem1.Click += new System.EventHandler(this.договорыToolStripMenuItem1_Click);
            // 
            // компанииToolStripMenuItem
            // 
            this.компанииToolStripMenuItem.Name = "компанииToolStripMenuItem";
            this.компанииToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.компанииToolStripMenuItem.Text = "Юрид. клиенты";
            this.компанииToolStripMenuItem.Click += new System.EventHandler(this.компанииToolStripMenuItem_Click);
            // 
            // складыToolStripMenuItem
            // 
            this.складыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.местаToolStripMenuItem,
            this.складыToolStripMenuItem1,
            this.типыГрузаToolStripMenuItem});
            this.складыToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.складыToolStripMenuItem.Name = "складыToolStripMenuItem";
            this.складыToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.складыToolStripMenuItem.Size = new System.Drawing.Size(215, 36);
            this.складыToolStripMenuItem.Text = "Хранилище";
            this.складыToolStripMenuItem.DropDownClosed += new System.EventHandler(this.складыToolStripMenuItem_DropDownClosed);
            this.складыToolStripMenuItem.DropDownOpened += new System.EventHandler(this.складыToolStripMenuItem_DropDownOpened);
            // 
            // местаToolStripMenuItem
            // 
            this.местаToolStripMenuItem.Name = "местаToolStripMenuItem";
            this.местаToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.местаToolStripMenuItem.Text = "Места";
            this.местаToolStripMenuItem.Click += new System.EventHandler(this.местаToolStripMenuItem_Click);
            // 
            // складыToolStripMenuItem1
            // 
            this.складыToolStripMenuItem1.Name = "складыToolStripMenuItem1";
            this.складыToolStripMenuItem1.Size = new System.Drawing.Size(163, 26);
            this.складыToolStripMenuItem1.Text = "Склады";
            this.складыToolStripMenuItem1.Click += new System.EventHandler(this.складыToolStripMenuItem1_Click);
            // 
            // типыГрузаToolStripMenuItem
            // 
            this.типыГрузаToolStripMenuItem.Name = "типыГрузаToolStripMenuItem";
            this.типыГрузаToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.типыГрузаToolStripMenuItem.Text = "Типы груза";
            this.типыГрузаToolStripMenuItem.Click += new System.EventHandler(this.типыГрузаToolStripMenuItem_Click);
            // 
            // сервисToolStripMenuItem
            // 
            this.сервисToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.журналПосещенийToolStripMenuItem,
            this.выгрузитьБазуДанныхToolStripMenuItem,
            this.загрузитьБазуДанныхToolStripMenuItem});
            this.сервисToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.сервисToolStripMenuItem.Name = "сервисToolStripMenuItem";
            this.сервисToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.сервисToolStripMenuItem.Size = new System.Drawing.Size(215, 36);
            this.сервисToolStripMenuItem.Text = "Сервис";
            this.сервисToolStripMenuItem.DropDownClosed += new System.EventHandler(this.сервисToolStripMenuItem_DropDownClosed);
            this.сервисToolStripMenuItem.DropDownOpened += new System.EventHandler(this.сервисToolStripMenuItem_DropDownOpened);
            // 
            // журналПосещенийToolStripMenuItem
            // 
            this.журналПосещенийToolStripMenuItem.Name = "журналПосещенийToolStripMenuItem";
            this.журналПосещенийToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.журналПосещенийToolStripMenuItem.Text = "Журнал посещений";
            this.журналПосещенийToolStripMenuItem.Click += new System.EventHandler(this.журналПосещенийToolStripMenuItem_Click);
            // 
            // выгрузитьБазуДанныхToolStripMenuItem
            // 
            this.выгрузитьБазуДанныхToolStripMenuItem.Name = "выгрузитьБазуДанныхToolStripMenuItem";
            this.выгрузитьБазуДанныхToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.выгрузитьБазуДанныхToolStripMenuItem.Text = "Выгрузить базу данных";
            this.выгрузитьБазуДанныхToolStripMenuItem.Click += new System.EventHandler(this.выгрузитьБазуДанныхToolStripMenuItem_Click);
            // 
            // загрузитьБазуДанныхToolStripMenuItem
            // 
            this.загрузитьБазуДанныхToolStripMenuItem.Name = "загрузитьБазуДанныхToolStripMenuItem";
            this.загрузитьБазуДанныхToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.загрузитьБазуДанныхToolStripMenuItem.Text = "Загрузить базу данных";
            this.загрузитьБазуДанныхToolStripMenuItem.Click += new System.EventHandler(this.загрузитьБазуДанныхToolStripMenuItem_Click);
            // 
            // формированиеToolStripMenuItem
            // 
            this.формированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.счётПоДоговоруToolStripMenuItem,
            this.тарифНаМестаToolStripMenuItem});
            this.формированиеToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.формированиеToolStripMenuItem.Name = "формированиеToolStripMenuItem";
            this.формированиеToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.формированиеToolStripMenuItem.Size = new System.Drawing.Size(215, 36);
            this.формированиеToolStripMenuItem.Text = "Документы";
            this.формированиеToolStripMenuItem.DropDownClosed += new System.EventHandler(this.формированиеToolStripMenuItem_DropDownClosed);
            this.формированиеToolStripMenuItem.DropDownOpened += new System.EventHandler(this.формированиеToolStripMenuItem_DropDownOpened);
            // 
            // счётПоДоговоруToolStripMenuItem
            // 
            this.счётПоДоговоруToolStripMenuItem.Name = "счётПоДоговоруToolStripMenuItem";
            this.счётПоДоговоруToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.счётПоДоговоруToolStripMenuItem.Text = "Счёт по договору";
            this.счётПоДоговоруToolStripMenuItem.Click += new System.EventHandler(this.счётПоДоговоруToolStripMenuItem_Click);
            // 
            // тарифНаМестаToolStripMenuItem
            // 
            this.тарифНаМестаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.docToolStripMenuItem,
            this.pdfToolStripMenuItem});
            this.тарифНаМестаToolStripMenuItem.Name = "тарифНаМестаToolStripMenuItem";
            this.тарифНаМестаToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.тарифНаМестаToolStripMenuItem.Text = "Прайс лист";
            // 
            // docToolStripMenuItem
            // 
            this.docToolStripMenuItem.Name = "docToolStripMenuItem";
            this.docToolStripMenuItem.Size = new System.Drawing.Size(111, 26);
            this.docToolStripMenuItem.Text = "doc";
            this.docToolStripMenuItem.Click += new System.EventHandler(this.docToolStripMenuItem_Click);
            // 
            // pdfToolStripMenuItem
            // 
            this.pdfToolStripMenuItem.Name = "pdfToolStripMenuItem";
            this.pdfToolStripMenuItem.Size = new System.Drawing.Size(111, 26);
            this.pdfToolStripMenuItem.Text = "pdf";
            this.pdfToolStripMenuItem.Click += new System.EventHandler(this.pdfToolStripMenuItem_Click);
            // 
            // личныйКабинетToolStripMenuItem
            // 
            this.личныйКабинетToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.личныйКабинетToolStripMenuItem.Name = "личныйКабинетToolStripMenuItem";
            this.личныйКабинетToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.личныйКабинетToolStripMenuItem.Size = new System.Drawing.Size(215, 36);
            this.личныйКабинетToolStripMenuItem.Text = "Личные данные";
            this.личныйКабинетToolStripMenuItem.Click += new System.EventHandler(this.личныйКабинетToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Font = new System.Drawing.Font("Gadugi", 14F);
            this.выходToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(215, 36);
            this.выходToolStripMenuItem.Text = "Выйти из учётной записи";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // LabelAOKiprey
            // 
            this.LabelAOKiprey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelAOKiprey.AutoSize = true;
            this.LabelAOKiprey.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAOKiprey.Location = new System.Drawing.Point(434, 248);
            this.LabelAOKiprey.Name = "LabelAOKiprey";
            this.LabelAOKiprey.Size = new System.Drawing.Size(210, 38);
            this.LabelAOKiprey.TabIndex = 4;
            this.LabelAOKiprey.Text = "АО \"Кипрей\"";
            // 
            // LabelName
            // 
            this.LabelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelName.Location = new System.Drawing.Point(158, 591);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(47, 20);
            this.LabelName.TabIndex = 7;
            this.LabelName.Text = "label";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 591);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Добро пожаловать, ";
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDesktopPane.BackColor = System.Drawing.Color.White;
            this.panelDesktopPane.Controls.Add(this.label2);
            this.panelDesktopPane.Controls.Add(this.LabelAOKiprey);
            this.panelDesktopPane.Controls.Add(this.LabelName);
            this.panelDesktopPane.Controls.Add(this.label1);
            this.panelDesktopPane.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelDesktopPane.Location = new System.Drawing.Point(216, 0);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(1096, 620);
            this.panelDesktopPane.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(903, 591);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Вызов помощи: F1";
            // 
            // HelpProvider1
            // 
            this.HelpProvider1.HelpNamespace = "C:\\Users\\User\\Desktop\\Sklad\\KipreySklad\\KipreySklad\\bin\\Debug\\Help\\Help.html";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 620);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.MenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(857, 294);
            this.Name = "Main";
            this.HelpProvider1.SetShowHelp(this, true);
            this.Text = "Кипрей склад";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.panelDesktopPane.ResumeLayout(false);
            this.panelDesktopPane.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem сервисToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem формированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem учётныеЗаписиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem договорыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem складыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem хранениеГрузовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem договорыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem местаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem складыToolStripMenuItem1;
        private System.Windows.Forms.Label LabelAOKiprey;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem компанииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem счётПоДоговоруToolStripMenuItem;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.ToolStripMenuItem личныйКабинетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тарифНаМестаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pdfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem журналПосещенийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выгрузитьБазуДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьБазуДанныхToolStripMenuItem;
        public System.Windows.Forms.HelpProvider HelpProvider1;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
        private System.Windows.Forms.ToolStripMenuItem типыГрузаToolStripMenuItem;
        private System.Windows.Forms.Label label2;
    }
}