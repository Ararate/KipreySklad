
namespace KipreySklad.Forms
{
    partial class FormDogovori
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDogovori));
            this.panel2 = new System.Windows.Forms.Panel();
            this.TBSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.DGW = new System.Windows.Forms.DataGridView();
            this.idDogovor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fio1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataBegin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.RBphysClient = new System.Windows.Forms.RadioButton();
            this.RBUrclient = new System.Windows.Forms.RadioButton();
            this.BtnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelHeader = new System.Windows.Forms.Label();
            this.BtnOutput = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BtnCancel = new System.Windows.Forms.Button();
            this.CBMyDogs = new System.Windows.Forms.CheckBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGW)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.TBSearch);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(762, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 21);
            this.panel2.TabIndex = 68;
            // 
            // TBSearch
            // 
            this.TBSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TBSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBSearch.Location = new System.Drawing.Point(0, 0);
            this.TBSearch.Margin = new System.Windows.Forms.Padding(6);
            this.TBSearch.Name = "TBSearch";
            this.TBSearch.Size = new System.Drawing.Size(220, 19);
            this.TBSearch.TabIndex = 15;
            this.TBSearch.TextChanged += new System.EventHandler(this.TBSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(758, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 67;
            this.label1.Text = "Поиск по клиенту";
            // 
            // BtnEdit
            // 
            this.BtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("BtnEdit.Image")));
            this.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEdit.Location = new System.Drawing.Point(197, 43);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(166, 35);
            this.BtnEdit.TabIndex = 65;
            this.BtnEdit.Text = "Изменить";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.Image")));
            this.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDelete.Location = new System.Drawing.Point(382, 43);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(166, 35);
            this.BtnDelete.TabIndex = 64;
            this.BtnDelete.Text = "Удалить";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // DGW
            // 
            this.DGW.AllowDrop = true;
            this.DGW.AllowUserToAddRows = false;
            this.DGW.AllowUserToDeleteRows = false;
            this.DGW.AllowUserToResizeRows = false;
            this.DGW.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDogovor,
            this.entity,
            this.idUser,
            this.idClient,
            this.firmName,
            this.fio1,
            this.fio,
            this.dataBegin,
            this.dataEnd});
            this.DGW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGW.Location = new System.Drawing.Point(13, 88);
            this.DGW.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGW.MultiSelect = false;
            this.DGW.Name = "DGW";
            this.DGW.ReadOnly = true;
            this.DGW.RowTemplate.Height = 25;
            this.DGW.Size = new System.Drawing.Size(732, 371);
            this.DGW.TabIndex = 63;
            this.DGW.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellClick);
            this.DGW.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellDoubleClick);
            this.DGW.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DGW_DataBindingComplete);
            // 
            // idDogovor
            // 
            this.idDogovor.DataPropertyName = "idDogovor";
            this.idDogovor.HeaderText = "Номер";
            this.idDogovor.Name = "idDogovor";
            this.idDogovor.ReadOnly = true;
            this.idDogovor.Width = 84;
            // 
            // entity
            // 
            this.entity.DataPropertyName = "entity";
            this.entity.HeaderText = "entity";
            this.entity.Name = "entity";
            this.entity.ReadOnly = true;
            this.entity.Visible = false;
            this.entity.Width = 72;
            // 
            // idUser
            // 
            this.idUser.DataPropertyName = "idUser";
            this.idUser.HeaderText = "idUser";
            this.idUser.Name = "idUser";
            this.idUser.ReadOnly = true;
            this.idUser.Visible = false;
            this.idUser.Width = 80;
            // 
            // idClient
            // 
            this.idClient.DataPropertyName = "idClient";
            this.idClient.HeaderText = "idClient";
            this.idClient.Name = "idClient";
            this.idClient.ReadOnly = true;
            this.idClient.Visible = false;
            this.idClient.Width = 86;
            // 
            // firmName
            // 
            this.firmName.DataPropertyName = "firmName";
            this.firmName.HeaderText = "Название";
            this.firmName.Name = "firmName";
            this.firmName.ReadOnly = true;
            this.firmName.Visible = false;
            this.firmName.Width = 108;
            // 
            // fio1
            // 
            this.fio1.DataPropertyName = "fio1";
            this.fio1.HeaderText = "Клиент";
            this.fio1.Name = "fio1";
            this.fio1.ReadOnly = true;
            this.fio1.Width = 90;
            // 
            // fio
            // 
            this.fio.DataPropertyName = "fio";
            this.fio.HeaderText = "Менеджер";
            this.fio.Name = "fio";
            this.fio.ReadOnly = true;
            this.fio.Width = 114;
            // 
            // dataBegin
            // 
            this.dataBegin.DataPropertyName = "dataBegin";
            this.dataBegin.HeaderText = "Дата начала";
            this.dataBegin.Name = "dataBegin";
            this.dataBegin.ReadOnly = true;
            this.dataBegin.Width = 132;
            // 
            // dataEnd
            // 
            this.dataEnd.DataPropertyName = "dataEnd";
            this.dataEnd.HeaderText = "Дата конца";
            this.dataEnd.Name = "dataEnd";
            this.dataEnd.ReadOnly = true;
            this.dataEnd.Width = 121;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdd.Image")));
            this.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdd.Location = new System.Drawing.Point(13, 43);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(166, 35);
            this.BtnAdd.TabIndex = 62;
            this.BtnAdd.Text = "Добавить";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // RBphysClient
            // 
            this.RBphysClient.AutoSize = true;
            this.RBphysClient.Checked = true;
            this.RBphysClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RBphysClient.Location = new System.Drawing.Point(565, 51);
            this.RBphysClient.Name = "RBphysClient";
            this.RBphysClient.Size = new System.Drawing.Size(94, 21);
            this.RBphysClient.TabIndex = 69;
            this.RBphysClient.TabStop = true;
            this.RBphysClient.Text = "Физ. лица";
            this.RBphysClient.UseVisualStyleBackColor = true;
            this.RBphysClient.Click += new System.EventHandler(this.RBphysClient_Click);
            // 
            // RBUrclient
            // 
            this.RBUrclient.AutoSize = true;
            this.RBUrclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RBUrclient.Location = new System.Drawing.Point(678, 51);
            this.RBUrclient.Name = "RBUrclient";
            this.RBUrclient.Size = new System.Drawing.Size(88, 21);
            this.RBUrclient.TabIndex = 70;
            this.RBUrclient.Text = "Юр. лица";
            this.RBUrclient.UseVisualStyleBackColor = true;
            this.RBUrclient.Click += new System.EventHandler(this.RBUrclient_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBack.Image = ((System.Drawing.Image)(resources.GetObject("BtnBack.Image")));
            this.BtnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBack.Location = new System.Drawing.Point(762, 424);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(220, 35);
            this.BtnBack.TabIndex = 77;
            this.BtnBack.Text = "Назад";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click_1);
            this.BtnBack.MouseEnter += new System.EventHandler(this.BtnBack_MouseEnter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.LabelHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 35);
            this.panel1.TabIndex = 78;
            // 
            // LabelHeader
            // 
            this.LabelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelHeader.Location = new System.Drawing.Point(0, 0);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(995, 35);
            this.LabelHeader.TabIndex = 0;
            this.LabelHeader.Text = "Договоры";
            this.LabelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnOutput
            // 
            this.BtnOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOutput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOutput.Location = new System.Drawing.Point(762, 357);
            this.BtnOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnOutput.Name = "BtnOutput";
            this.BtnOutput.Size = new System.Drawing.Size(220, 35);
            this.BtnOutput.TabIndex = 79;
            this.BtnOutput.Text = "Сформировать счёт";
            this.BtnOutput.UseVisualStyleBackColor = true;
            this.BtnOutput.Click += new System.EventHandler(this.BtnOutput_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Enabled = false;
            this.BtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancel.Image")));
            this.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancel.Location = new System.Drawing.Point(785, 43);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(16, 5, 4, 5);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(29, 35);
            this.BtnCancel.TabIndex = 84;
            this.toolTip1.SetToolTip(this.BtnCancel, "Отменить действие");
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // CBMyDogs
            // 
            this.CBMyDogs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CBMyDogs.AutoSize = true;
            this.CBMyDogs.Location = new System.Drawing.Point(762, 170);
            this.CBMyDogs.Name = "CBMyDogs";
            this.CBMyDogs.Size = new System.Drawing.Size(199, 24);
            this.CBMyDogs.TabIndex = 85;
            this.CBMyDogs.Text = "Только свои договоры";
            this.CBMyDogs.UseVisualStyleBackColor = true;
            this.CBMyDogs.CheckedChanged += new System.EventHandler(this.CBMyDogs_CheckedChanged);
            // 
            // FormDogovori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(995, 473);
            this.Controls.Add(this.CBMyDogs);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOutput);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.RBUrclient);
            this.Controls.Add(this.RBphysClient);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.DGW);
            this.Controls.Add(this.BtnAdd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(813, 462);
            this.Name = "FormDogovori";
            this.Text = "Договоры";
            this.Load += new System.EventHandler(this.FormDogovori_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGW)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox TBSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.DataGridView DGW;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.RadioButton RBphysClient;
        private System.Windows.Forms.RadioButton RBUrclient;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDogovor;
        private System.Windows.Forms.DataGridViewTextBoxColumn entity;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn fio1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEnd;
        private System.Windows.Forms.Button BtnOutput;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.CheckBox CBMyDogs;
    }
}