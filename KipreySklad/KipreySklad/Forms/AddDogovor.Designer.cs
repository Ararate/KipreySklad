
namespace KipreySklad.Forms
{
    partial class AddDogovor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDogovor));
            this.panel4 = new System.Windows.Forms.Panel();
            this.DPBegin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CBClient = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DPEnd = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.RBUrclient = new System.Windows.Forms.RadioButton();
            this.RBphysClient = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TBSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel4.Controls.Add(this.DPBegin);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel4.Location = new System.Drawing.Point(53, 167);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(296, 26);
            this.panel4.TabIndex = 73;
            // 
            // DPBegin
            // 
            this.DPBegin.CustomFormat = "yyyy-MM-dd";
            this.DPBegin.Location = new System.Drawing.Point(-1, -1);
            this.DPBegin.Name = "DPBegin";
            this.DPBegin.Size = new System.Drawing.Size(298, 26);
            this.DPBegin.TabIndex = 0;
            this.DPBegin.ValueChanged += new System.EventHandler(this.DPBegin_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(40, 20, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 72;
            this.label3.Text = "Дата начала";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Controls.Add(this.CBClient);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel3.Location = new System.Drawing.Point(53, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(298, 30);
            this.panel3.TabIndex = 69;
            // 
            // CBClient
            // 
            this.CBClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CBClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBClient.FormattingEnabled = true;
            this.CBClient.Location = new System.Drawing.Point(0, 0);
            this.CBClient.MaxDropDownItems = 100;
            this.CBClient.Name = "CBClient";
            this.CBClient.Size = new System.Drawing.Size(298, 28);
            this.CBClient.TabIndex = 0;
            this.CBClient.SelectedIndexChanged += new System.EventHandler(this.CBClient_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(40, 20, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 68;
            this.label2.Text = "Клиент";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.DPEnd);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(370, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 26);
            this.panel2.TabIndex = 67;
            // 
            // DPEnd
            // 
            this.DPEnd.CustomFormat = "yyyy-MM-dd";
            this.DPEnd.Location = new System.Drawing.Point(-1, -1);
            this.DPEnd.Name = "DPEnd";
            this.DPEnd.Size = new System.Drawing.Size(298, 26);
            this.DPEnd.TabIndex = 0;
            this.DPEnd.ValueChanged += new System.EventHandler(this.DPEnd_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 131);
            this.label5.Margin = new System.Windows.Forms.Padding(40, 20, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 66;
            this.label5.Text = "Дата конца";
            // 
            // BtnBack
            // 
            this.BtnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnBack.Location = new System.Drawing.Point(373, 213);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(108, 31);
            this.BtnBack.TabIndex = 75;
            this.BtnBack.Text = "Отмена";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(241, 213);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(40, 3, 3, 3);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(108, 31);
            this.BtnSave.TabIndex = 74;
            this.BtnSave.Text = "Сохранить";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // RBUrclient
            // 
            this.RBUrclient.AutoSize = true;
            this.RBUrclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RBUrclient.Location = new System.Drawing.Point(233, 41);
            this.RBUrclient.Name = "RBUrclient";
            this.RBUrclient.Size = new System.Drawing.Size(88, 21);
            this.RBUrclient.TabIndex = 77;
            this.RBUrclient.Text = "Юр. лицо";
            this.RBUrclient.UseVisualStyleBackColor = true;
            this.RBUrclient.Click += new System.EventHandler(this.RBUrclient_Click);
            // 
            // RBphysClient
            // 
            this.RBphysClient.AutoSize = true;
            this.RBphysClient.Checked = true;
            this.RBphysClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RBphysClient.Location = new System.Drawing.Point(120, 41);
            this.RBphysClient.Name = "RBphysClient";
            this.RBphysClient.Size = new System.Drawing.Size(94, 21);
            this.RBphysClient.TabIndex = 76;
            this.RBphysClient.TabStop = true;
            this.RBphysClient.Text = "Физ. лицо";
            this.RBphysClient.UseVisualStyleBackColor = true;
            this.RBphysClient.Click += new System.EventHandler(this.RBphysClient_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.TBSearch);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(370, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 21);
            this.panel1.TabIndex = 79;
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
            this.label1.Location = new System.Drawing.Point(366, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 78;
            this.label1.Text = "Найти";
            // 
            // AddDogovor
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.BtnBack;
            this.ClientSize = new System.Drawing.Size(752, 261);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RBUrclient);
            this.Controls.Add(this.RBphysClient);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddDogovor";
            this.Text = "AddDogovor";
            this.Load += new System.EventHandler(this.AddDogovor_Load);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.DateTimePicker DPBegin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.ComboBox CBClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DateTimePicker DPEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.RadioButton RBUrclient;
        private System.Windows.Forms.RadioButton RBphysClient;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox TBSearch;
        private System.Windows.Forms.Label label1;
    }
}