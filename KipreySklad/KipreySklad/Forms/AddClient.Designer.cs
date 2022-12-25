
namespace KipreySklad.Forms
{
    partial class AddClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddClient));
            this.panel5 = new System.Windows.Forms.Panel();
            this.TBPhone = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TBPassport = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TBOtch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TBSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.TBName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel5.Controls.Add(this.TBPhone);
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel5.Location = new System.Drawing.Point(185, 145);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(240, 21);
            this.panel5.TabIndex = 3;
            // 
            // TBPhone
            // 
            this.TBPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBPhone.Location = new System.Drawing.Point(0, 0);
            this.TBPhone.Mask = "+7 (000) 000-00-00";
            this.TBPhone.Name = "TBPhone";
            this.TBPhone.Size = new System.Drawing.Size(240, 19);
            this.TBPhone.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(40, 20, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 77;
            this.label5.Text = "Телефон";
            // 
            // BtnBack
            // 
            this.BtnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnBack.Location = new System.Drawing.Point(455, 208);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(108, 31);
            this.BtnBack.TabIndex = 74;
            this.BtnBack.Text = "Отмена";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(317, 208);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(40, 3, 3, 3);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(108, 31);
            this.BtnSave.TabIndex = 73;
            this.BtnSave.Text = "Сохранить";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.TBPassport);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(455, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 21);
            this.panel1.TabIndex = 4;
            // 
            // TBPassport
            // 
            this.TBPassport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBPassport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBPassport.Location = new System.Drawing.Point(0, 0);
            this.TBPassport.Mask = "0000 000000";
            this.TBPassport.Name = "TBPassport";
            this.TBPassport.Size = new System.Drawing.Size(240, 19);
            this.TBPassport.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(40, 20, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 79;
            this.label1.Text = "Паспорт";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel4.Controls.Add(this.TBOtch);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel4.Location = new System.Drawing.Point(584, 65);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(240, 21);
            this.panel4.TabIndex = 2;
            // 
            // TBOtch
            // 
            this.TBOtch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBOtch.Location = new System.Drawing.Point(0, 0);
            this.TBOtch.Margin = new System.Windows.Forms.Padding(6);
            this.TBOtch.MaxLength = 15;
            this.TBOtch.Name = "TBOtch";
            this.TBOtch.Size = new System.Drawing.Size(240, 19);
            this.TBOtch.TabIndex = 15;
            this.TBOtch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBOtch_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(580, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(40, 20, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 76;
            this.label3.Text = "Отчество";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Controls.Add(this.TBSurname);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel3.Location = new System.Drawing.Point(320, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 21);
            this.panel3.TabIndex = 1;
            // 
            // TBSurname
            // 
            this.TBSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBSurname.Location = new System.Drawing.Point(0, 0);
            this.TBSurname.Margin = new System.Windows.Forms.Padding(6);
            this.TBSurname.MaxLength = 15;
            this.TBSurname.Name = "TBSurname";
            this.TBSurname.Size = new System.Drawing.Size(240, 19);
            this.TBSurname.TabIndex = 15;
            this.TBSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBSurname_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(40, 20, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 74;
            this.label2.Text = "Фамилия";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel6.Controls.Add(this.TBName);
            this.panel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel6.Location = new System.Drawing.Point(53, 65);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(240, 21);
            this.panel6.TabIndex = 0;
            // 
            // TBName
            // 
            this.TBName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBName.Location = new System.Drawing.Point(0, 0);
            this.TBName.Margin = new System.Windows.Forms.Padding(6);
            this.TBName.MaxLength = 15;
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(240, 19);
            this.TBName.TabIndex = 15;
            this.TBName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBName_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 29);
            this.label6.Margin = new System.Windows.Forms.Padding(40, 20, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 72;
            this.label6.Text = "Имя";
            // 
            // AddClient
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.BtnBack;
            this.ClientSize = new System.Drawing.Size(901, 276);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnSave);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddClient";
            this.Text = "AddClient";
            this.Load += new System.EventHandler(this.AddClient_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.MaskedTextBox TBPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox TBPassport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.TextBox TBOtch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox TBSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.Label label6;
    }
}