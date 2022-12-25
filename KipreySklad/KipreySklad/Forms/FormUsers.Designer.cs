
namespace KipreySklad.Forms
{
    partial class FormUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TBSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelHeader = new System.Windows.Forms.Label();
            this.CBField = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.CBRole = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnReset = new System.Windows.Forms.Button();
            this.DGWArchive = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeRole1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUser1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdManager1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBArchive = new System.Windows.Forms.CheckBox();
            this.BtnRestore = new System.Windows.Forms.Button();
            this.BtnResetPass = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BtnUndo = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGWArchive)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.TBSearch);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(614, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 21);
            this.panel2.TabIndex = 68;
            // 
            // TBSearch
            // 
            this.TBSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBSearch.Location = new System.Drawing.Point(0, 0);
            this.TBSearch.Margin = new System.Windows.Forms.Padding(6);
            this.TBSearch.Name = "TBSearch";
            this.TBSearch.Size = new System.Drawing.Size(249, 19);
            this.TBSearch.TabIndex = 15;
            this.TBSearch.TextChanged += new System.EventHandler(this.TBSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(604, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 67;
            this.label1.Text = "Поиск по:";
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
            this.login,
            this.codeRole,
            this.idUser,
            this.fio,
            this.password,
            this.phone,
            this.role});
            this.DataGridView.Location = new System.Drawing.Point(13, 88);
            this.DataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataGridView.MultiSelect = false;
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView.RowTemplate.Height = 25;
            this.DataGridView.Size = new System.Drawing.Size(584, 397);
            this.DataGridView.TabIndex = 63;
            this.DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellClick);
            // 
            // login
            // 
            this.login.DataPropertyName = "login";
            this.login.HeaderText = "Логин";
            this.login.Name = "login";
            this.login.ReadOnly = true;
            this.login.Width = 80;
            // 
            // codeRole
            // 
            this.codeRole.DataPropertyName = "codeRole";
            this.codeRole.HeaderText = "codeRole";
            this.codeRole.Name = "codeRole";
            this.codeRole.ReadOnly = true;
            this.codeRole.Visible = false;
            this.codeRole.Width = 102;
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
            // fio
            // 
            this.fio.DataPropertyName = "fio";
            this.fio.HeaderText = "ФИО";
            this.fio.Name = "fio";
            this.fio.ReadOnly = true;
            this.fio.Width = 72;
            // 
            // password
            // 
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "Пароль";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.Visible = false;
            this.password.Width = 92;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "Телефон";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.Width = 104;
            // 
            // role
            // 
            this.role.DataPropertyName = "role";
            this.role.HeaderText = "Должность";
            this.role.Name = "role";
            this.role.ReadOnly = true;
            this.role.Width = 120;
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
            // BtnBack
            // 
            this.BtnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBack.Image = ((System.Drawing.Image)(resources.GetObject("BtnBack.Image")));
            this.BtnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBack.Location = new System.Drawing.Point(614, 450);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(249, 35);
            this.BtnBack.TabIndex = 77;
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
            this.panel1.Size = new System.Drawing.Size(875, 35);
            this.panel1.TabIndex = 79;
            // 
            // LabelHeader
            // 
            this.LabelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelHeader.Location = new System.Drawing.Point(0, 0);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(875, 35);
            this.LabelHeader.TabIndex = 0;
            this.LabelHeader.Text = "Пользователи";
            this.LabelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBField
            // 
            this.CBField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CBField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBField.FormattingEnabled = true;
            this.CBField.Items.AddRange(new object[] {
            "Номеру телефона",
            "ФИО"});
            this.CBField.Location = new System.Drawing.Point(682, 85);
            this.CBField.MaxDropDownItems = 100;
            this.CBField.Name = "CBField";
            this.CBField.Size = new System.Drawing.Size(181, 28);
            this.CBField.TabIndex = 0;
            this.CBField.SelectedIndexChanged += new System.EventHandler(this.CBRole_SelectedIndexChanged);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel6.Controls.Add(this.CBRole);
            this.panel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel6.Location = new System.Drawing.Point(614, 175);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(249, 30);
            this.panel6.TabIndex = 80;
            // 
            // CBRole
            // 
            this.CBRole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CBRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBRole.FormattingEnabled = true;
            this.CBRole.Location = new System.Drawing.Point(0, 0);
            this.CBRole.MaxDropDownItems = 100;
            this.CBRole.Name = "CBRole";
            this.CBRole.Size = new System.Drawing.Size(249, 28);
            this.CBRole.TabIndex = 0;
            this.CBRole.SelectionChangeCommitted += new System.EventHandler(this.CBRole_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(604, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 81;
            this.label2.Text = "Должность:";
            // 
            // BtnReset
            // 
            this.BtnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReset.Location = new System.Drawing.Point(614, 230);
            this.BtnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(249, 35);
            this.BtnReset.TabIndex = 82;
            this.BtnReset.Text = "Показать всё";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // DGWArchive
            // 
            this.DGWArchive.AllowUserToAddRows = false;
            this.DGWArchive.AllowUserToDeleteRows = false;
            this.DGWArchive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGWArchive.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGWArchive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGWArchive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.codeRole1,
            this.idUser1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.IdManager1,
            this.dataGridViewTextBoxColumn2,
            this.role1,
            this.dataGridViewTextBoxColumn6});
            this.DGWArchive.Location = new System.Drawing.Point(13, 267);
            this.DGWArchive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGWArchive.Name = "DGWArchive";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGWArchive.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGWArchive.RowTemplate.Height = 25;
            this.DGWArchive.Size = new System.Drawing.Size(584, 218);
            this.DGWArchive.TabIndex = 83;
            this.DGWArchive.Visible = false;
            this.DGWArchive.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGWArchive_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Login";
            this.dataGridViewTextBoxColumn1.HeaderText = "Логин";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // codeRole1
            // 
            this.codeRole1.DataPropertyName = "codeRole";
            this.codeRole1.HeaderText = "codeRole";
            this.codeRole1.Name = "codeRole1";
            this.codeRole1.ReadOnly = true;
            this.codeRole1.Visible = false;
            this.codeRole1.Width = 102;
            // 
            // idUser1
            // 
            this.idUser1.DataPropertyName = "idUser";
            this.idUser1.HeaderText = "idUser";
            this.idUser1.Name = "idUser1";
            this.idUser1.ReadOnly = true;
            this.idUser1.Visible = false;
            this.idUser1.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FIO";
            this.dataGridViewTextBoxColumn4.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 72;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn5.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 104;
            // 
            // IdManager1
            // 
            this.IdManager1.DataPropertyName = "IdManager";
            this.IdManager1.HeaderText = "IdManager1";
            this.IdManager1.Name = "IdManager1";
            this.IdManager1.ReadOnly = true;
            this.IdManager1.Visible = false;
            this.IdManager1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn2.HeaderText = "Password";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 103;
            // 
            // role1
            // 
            this.role1.DataPropertyName = "role";
            this.role1.HeaderText = "Должность";
            this.role1.Name = "role1";
            this.role1.ReadOnly = true;
            this.role1.Width = 120;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "IsDeleted";
            this.dataGridViewTextBoxColumn6.HeaderText = "IsDeleted";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            this.dataGridViewTextBoxColumn6.Width = 103;
            // 
            // CBArchive
            // 
            this.CBArchive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CBArchive.AutoSize = true;
            this.CBArchive.Location = new System.Drawing.Point(614, 378);
            this.CBArchive.Margin = new System.Windows.Forms.Padding(4);
            this.CBArchive.Name = "CBArchive";
            this.CBArchive.Size = new System.Drawing.Size(148, 24);
            this.CBArchive.TabIndex = 84;
            this.CBArchive.Text = "Показать архив";
            this.CBArchive.UseVisualStyleBackColor = true;
            this.CBArchive.CheckedChanged += new System.EventHandler(this.CBArchive_CheckedChanged);
            // 
            // BtnRestore
            // 
            this.BtnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRestore.Enabled = false;
            this.BtnRestore.Location = new System.Drawing.Point(614, 409);
            this.BtnRestore.Name = "BtnRestore";
            this.BtnRestore.Size = new System.Drawing.Size(249, 32);
            this.BtnRestore.TabIndex = 85;
            this.BtnRestore.Text = "Восстановить";
            this.BtnRestore.UseVisualStyleBackColor = true;
            this.BtnRestore.Visible = false;
            this.BtnRestore.Click += new System.EventHandler(this.BtnRestore_Click);
            // 
            // BtnResetPass
            // 
            this.BtnResetPass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnResetPass.Location = new System.Drawing.Point(568, 43);
            this.BtnResetPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnResetPass.Name = "BtnResetPass";
            this.BtnResetPass.Size = new System.Drawing.Size(249, 35);
            this.BtnResetPass.TabIndex = 86;
            this.BtnResetPass.Text = "Сброс пароля";
            this.BtnResetPass.UseVisualStyleBackColor = true;
            this.BtnResetPass.Click += new System.EventHandler(this.BtnResetPass_Click);
            // 
            // BtnUndo
            // 
            this.BtnUndo.Enabled = false;
            this.BtnUndo.Image = ((System.Drawing.Image)(resources.GetObject("BtnUndo.Image")));
            this.BtnUndo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUndo.Location = new System.Drawing.Point(837, 43);
            this.BtnUndo.Margin = new System.Windows.Forms.Padding(16, 5, 4, 5);
            this.BtnUndo.Name = "BtnUndo";
            this.BtnUndo.Size = new System.Drawing.Size(29, 35);
            this.BtnUndo.TabIndex = 87;
            this.toolTip1.SetToolTip(this.BtnUndo, "Отменить действие");
            this.BtnUndo.UseVisualStyleBackColor = true;
            this.BtnUndo.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(875, 499);
            this.Controls.Add(this.BtnUndo);
            this.Controls.Add(this.BtnResetPass);
            this.Controls.Add(this.BtnRestore);
            this.Controls.Add(this.CBArchive);
            this.Controls.Add(this.DGWArchive);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.CBField);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.BtnAdd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(813, 462);
            this.Name = "FormUsers";
            this.Text = "Пользователи";
            this.Load += new System.EventHandler(this.FormUsers_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGWArchive)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox TBSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn login;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn fio;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        public System.Windows.Forms.ComboBox CBField;
        private System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.ComboBox CBRole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.DataGridView DGWArchive;
        private System.Windows.Forms.CheckBox CBArchive;
        private System.Windows.Forms.Button BtnRestore;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeRole1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUser1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdManager1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn role1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button BtnResetPass;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.Button BtnUndo;
    }
}