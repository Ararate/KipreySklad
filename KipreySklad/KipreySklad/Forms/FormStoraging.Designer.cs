
namespace KipreySklad.Forms
{
    partial class FormStoraging
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStoraging));
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.DPBegin = new System.Windows.Forms.DateTimePicker();
            this.DPEnd = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TBSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelHeader = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BtnCancel = new System.Windows.Forms.Button();
            this.PanelDate = new System.Windows.Forms.Panel();
            this.PanelBtn = new System.Windows.Forms.Panel();
            this.IdStoraging = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perBegin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataBegin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDogovor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idStorage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PanelDate.SuspendLayout();
            this.PanelBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnEdit
            // 
            this.BtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("BtnEdit.Image")));
            this.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEdit.Location = new System.Drawing.Point(184, 0);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(166, 35);
            this.BtnEdit.TabIndex = 72;
            this.BtnEdit.Text = "Изменить";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.Image")));
            this.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDelete.Location = new System.Drawing.Point(369, 0);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(166, 35);
            this.BtnDelete.TabIndex = 71;
            this.BtnDelete.Text = "Удалить";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.AllowUserToResizeRows = false;
            this.DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdStoraging,
            this.desc,
            this.perBegin,
            this.perEnd,
            this.storeCost,
            this.dataBegin,
            this.dataEnd,
            this.size,
            this.cargoX,
            this.cargoY,
            this.cargoZ,
            this.weight,
            this.IdDogovor,
            this.idPlace,
            this.adress,
            this.idStorage});
            this.DataGridView.Location = new System.Drawing.Point(13, 88);
            this.DataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataGridView.MultiSelect = false;
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.RowTemplate.Height = 25;
            this.DataGridView.Size = new System.Drawing.Size(1157, 492);
            this.DataGridView.TabIndex = 70;
            this.DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellClick);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdd.Image")));
            this.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdd.Location = new System.Drawing.Point(0, 0);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(166, 35);
            this.BtnAdd.TabIndex = 69;
            this.BtnAdd.Text = "Добавить";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnReset.Location = new System.Drawing.Point(1187, 159);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(220, 34);
            this.BtnReset.TabIndex = 81;
            this.BtnReset.Text = "Сбросить";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // DPBegin
            // 
            this.DPBegin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DPBegin.CustomFormat = "yyyy-MM-dd";
            this.DPBegin.Location = new System.Drawing.Point(36, 51);
            this.DPBegin.Name = "DPBegin";
            this.DPBegin.Size = new System.Drawing.Size(193, 26);
            this.DPBegin.TabIndex = 74;
            this.DPBegin.ValueChanged += new System.EventHandler(this.DPBegin_ValueChanged);
            // 
            // DPEnd
            // 
            this.DPEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DPEnd.CustomFormat = "yyyy-MM-dd";
            this.DPEnd.Location = new System.Drawing.Point(36, 96);
            this.DPEnd.Name = "DPEnd";
            this.DPEnd.Size = new System.Drawing.Size(193, 26);
            this.DPEnd.TabIndex = 75;
            this.DPEnd.ValueChanged += new System.EventHandler(this.DPEnd_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(40, 20, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 20);
            this.label3.TabIndex = 80;
            this.label3.Text = "До";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(40, 20, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 79;
            this.label2.Text = "От";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(40, 20, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 78;
            this.label5.Text = "Дата начала";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.TBSearch);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(1187, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 21);
            this.panel2.TabIndex = 77;
            // 
            // TBSearch
            // 
            this.TBSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBSearch.Location = new System.Drawing.Point(0, 0);
            this.TBSearch.Margin = new System.Windows.Forms.Padding(6);
            this.TBSearch.MaxLength = 45;
            this.TBSearch.Name = "TBSearch";
            this.TBSearch.Size = new System.Drawing.Size(220, 19);
            this.TBSearch.TabIndex = 15;
            this.TBSearch.TextChanged += new System.EventHandler(this.TBSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1183, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 76;
            this.label1.Text = "Описание";
            // 
            // BtnBack
            // 
            this.BtnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBack.Image = ((System.Drawing.Image)(resources.GetObject("BtnBack.Image")));
            this.BtnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBack.Location = new System.Drawing.Point(1187, 545);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(220, 35);
            this.BtnBack.TabIndex = 82;
            this.BtnBack.Text = "Назад";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.LabelHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1420, 35);
            this.panel1.TabIndex = 83;
            // 
            // LabelHeader
            // 
            this.LabelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelHeader.Location = new System.Drawing.Point(0, 0);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(1420, 35);
            this.LabelHeader.TabIndex = 0;
            this.LabelHeader.Text = "Хранение грузов";
            this.LabelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Enabled = false;
            this.BtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancel.Image")));
            this.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancel.Location = new System.Drawing.Point(555, 0);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(16, 5, 4, 5);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(29, 35);
            this.BtnCancel.TabIndex = 84;
            this.toolTip1.SetToolTip(this.BtnCancel, "Отменить действие");
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // PanelDate
            // 
            this.PanelDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelDate.Controls.Add(this.label5);
            this.PanelDate.Controls.Add(this.label2);
            this.PanelDate.Controls.Add(this.label3);
            this.PanelDate.Controls.Add(this.DPEnd);
            this.PanelDate.Controls.Add(this.DPBegin);
            this.PanelDate.Location = new System.Drawing.Point(1178, 200);
            this.PanelDate.Name = "PanelDate";
            this.PanelDate.Size = new System.Drawing.Size(242, 123);
            this.PanelDate.TabIndex = 85;
            // 
            // PanelBtn
            // 
            this.PanelBtn.Controls.Add(this.BtnAdd);
            this.PanelBtn.Controls.Add(this.BtnDelete);
            this.PanelBtn.Controls.Add(this.BtnCancel);
            this.PanelBtn.Controls.Add(this.BtnEdit);
            this.PanelBtn.Location = new System.Drawing.Point(13, 43);
            this.PanelBtn.Name = "PanelBtn";
            this.PanelBtn.Size = new System.Drawing.Size(587, 45);
            this.PanelBtn.TabIndex = 86;
            // 
            // IdStoraging
            // 
            this.IdStoraging.DataPropertyName = "IdStoraging";
            this.IdStoraging.HeaderText = "IdStoraging";
            this.IdStoraging.Name = "IdStoraging";
            this.IdStoraging.ReadOnly = true;
            this.IdStoraging.Visible = false;
            this.IdStoraging.Width = 117;
            // 
            // desc
            // 
            this.desc.DataPropertyName = "desc";
            this.desc.HeaderText = "Описание";
            this.desc.Name = "desc";
            this.desc.ReadOnly = true;
            this.desc.Width = 108;
            // 
            // perBegin
            // 
            this.perBegin.DataPropertyName = "perBegin";
            this.perBegin.HeaderText = "Начало хранения";
            this.perBegin.Name = "perBegin";
            this.perBegin.ReadOnly = true;
            this.perBegin.Width = 151;
            // 
            // perEnd
            // 
            this.perEnd.DataPropertyName = "perEnd";
            this.perEnd.HeaderText = "Конец хранения";
            this.perEnd.Name = "perEnd";
            this.perEnd.ReadOnly = true;
            this.perEnd.Width = 141;
            // 
            // storeCost
            // 
            this.storeCost.DataPropertyName = "storeCost";
            this.storeCost.HeaderText = "Стоимость хранения(руб)";
            this.storeCost.Name = "storeCost";
            this.storeCost.ReadOnly = true;
            this.storeCost.Width = 206;
            // 
            // dataBegin
            // 
            this.dataBegin.DataPropertyName = "dataBegin";
            this.dataBegin.HeaderText = "dataBegin";
            this.dataBegin.Name = "dataBegin";
            this.dataBegin.ReadOnly = true;
            this.dataBegin.Visible = false;
            this.dataBegin.Width = 107;
            // 
            // dataEnd
            // 
            this.dataEnd.DataPropertyName = "dataEnd";
            this.dataEnd.HeaderText = "dataEnd";
            this.dataEnd.Name = "dataEnd";
            this.dataEnd.ReadOnly = true;
            this.dataEnd.Visible = false;
            this.dataEnd.Width = 95;
            // 
            // size
            // 
            this.size.DataPropertyName = "Размер";
            this.size.HeaderText = "Размер(см)";
            this.size.Name = "size";
            this.size.ReadOnly = true;
            this.size.Width = 119;
            // 
            // cargoX
            // 
            this.cargoX.DataPropertyName = "cargoX";
            this.cargoX.HeaderText = "Длина груза(см)";
            this.cargoX.Name = "cargoX";
            this.cargoX.ReadOnly = true;
            this.cargoX.Visible = false;
            this.cargoX.Width = 142;
            // 
            // cargoY
            // 
            this.cargoY.DataPropertyName = "cargoY";
            this.cargoY.HeaderText = "Высота груза(см)";
            this.cargoY.Name = "cargoY";
            this.cargoY.ReadOnly = true;
            this.cargoY.Visible = false;
            this.cargoY.Width = 150;
            // 
            // cargoZ
            // 
            this.cargoZ.DataPropertyName = "cargoZ";
            this.cargoZ.HeaderText = "Ширина груза(см)";
            this.cargoZ.Name = "cargoZ";
            this.cargoZ.ReadOnly = true;
            this.cargoZ.Visible = false;
            this.cargoZ.Width = 150;
            // 
            // weight
            // 
            this.weight.DataPropertyName = "weight";
            this.weight.HeaderText = "Вес(кг)";
            this.weight.Name = "weight";
            this.weight.ReadOnly = true;
            this.weight.Width = 87;
            // 
            // IdDogovor
            // 
            this.IdDogovor.DataPropertyName = "IdDogovor";
            this.IdDogovor.HeaderText = "Номер договора";
            this.IdDogovor.Name = "IdDogovor";
            this.IdDogovor.ReadOnly = true;
            this.IdDogovor.Visible = false;
            this.IdDogovor.Width = 146;
            // 
            // idPlace
            // 
            this.idPlace.DataPropertyName = "idPlace";
            this.idPlace.HeaderText = "Номер места";
            this.idPlace.Name = "idPlace";
            this.idPlace.ReadOnly = true;
            this.idPlace.Width = 123;
            // 
            // adress
            // 
            this.adress.DataPropertyName = "adress";
            this.adress.HeaderText = "adress";
            this.adress.Name = "adress";
            this.adress.ReadOnly = true;
            this.adress.Visible = false;
            this.adress.Width = 82;
            // 
            // idStorage
            // 
            this.idStorage.DataPropertyName = "idStorage";
            this.idStorage.HeaderText = "Номер склада";
            this.idStorage.Name = "idStorage";
            this.idStorage.ReadOnly = true;
            this.idStorage.Width = 131;
            // 
            // FormStoraging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1420, 594);
            this.Controls.Add(this.PanelBtn);
            this.Controls.Add(this.PanelDate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(813, 462);
            this.Name = "FormStoraging";
            this.Text = "Хранение";
            this.Load += new System.EventHandler(this.FormStoraging_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.PanelDate.ResumeLayout(false);
            this.PanelDate.PerformLayout();
            this.PanelBtn.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnReset;
        public System.Windows.Forms.DateTimePicker DPBegin;
        public System.Windows.Forms.DateTimePicker DPEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox TBSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Panel PanelDate;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
        public System.Windows.Forms.Panel PanelBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdStoraging;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn perBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn perEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoX;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoY;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDogovor;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStorage;
    }
}