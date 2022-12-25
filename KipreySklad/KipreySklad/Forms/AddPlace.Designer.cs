
namespace KipreySklad.Forms
{
    partial class AddPlace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPlace));
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.CBStorage = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.TBZ = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TBY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TBX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TBCost = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnBack.Location = new System.Drawing.Point(185, 298);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(108, 31);
            this.BtnBack.TabIndex = 75;
            this.BtnBack.Text = "Отмена";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(53, 298);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(40, 3, 3, 3);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(108, 31);
            this.BtnSave.TabIndex = 74;
            this.BtnSave.Text = "Сохранить";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-4, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(40, 20, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 72;
            this.label3.Text = "Макс объём";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(40, 20, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 70;
            this.label1.Text = "Склад";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel5.Controls.Add(this.CBStorage);
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel5.Location = new System.Drawing.Point(0, 27);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(240, 30);
            this.panel5.TabIndex = 76;
            // 
            // CBStorage
            // 
            this.CBStorage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CBStorage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBStorage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBStorage.FormattingEnabled = true;
            this.CBStorage.Location = new System.Drawing.Point(0, 0);
            this.CBStorage.MaxDropDownItems = 100;
            this.CBStorage.Name = "CBStorage";
            this.CBStorage.Size = new System.Drawing.Size(240, 28);
            this.CBStorage.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel6.Controls.Add(this.TBZ);
            this.panel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel6.Location = new System.Drawing.Point(173, 116);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(58, 21);
            this.panel6.TabIndex = 2;
            // 
            // TBZ
            // 
            this.TBZ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBZ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBZ.Location = new System.Drawing.Point(0, 0);
            this.TBZ.Margin = new System.Windows.Forms.Padding(6);
            this.TBZ.MaxLength = 9;
            this.TBZ.Name = "TBZ";
            this.TBZ.Size = new System.Drawing.Size(58, 19);
            this.TBZ.TabIndex = 15;
            this.TBZ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBZ_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 116);
            this.label6.Margin = new System.Windows.Forms.Padding(40, 20, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 20);
            this.label6.TabIndex = 73;
            this.label6.Text = "Х";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel4.Controls.Add(this.TBY);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel4.Location = new System.Drawing.Point(87, 116);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(58, 21);
            this.panel4.TabIndex = 1;
            // 
            // TBY
            // 
            this.TBY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBY.Location = new System.Drawing.Point(0, 0);
            this.TBY.Margin = new System.Windows.Forms.Padding(6);
            this.TBY.MaxLength = 9;
            this.TBY.Name = "TBY";
            this.TBY.Size = new System.Drawing.Size(58, 19);
            this.TBY.TabIndex = 15;
            this.TBY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBY_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(40, 20, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 71;
            this.label2.Text = "Х";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.TBX);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(58, 21);
            this.panel1.TabIndex = 0;
            // 
            // TBX
            // 
            this.TBX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBX.Location = new System.Drawing.Point(0, 0);
            this.TBX.Margin = new System.Windows.Forms.Padding(6);
            this.TBX.MaxLength = 9;
            this.TBX.Name = "TBX";
            this.TBX.Size = new System.Drawing.Size(58, 19);
            this.TBX.TabIndex = 0;
            this.TBX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBX_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 196);
            this.label4.Margin = new System.Windows.Forms.Padding(40, 20, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 78;
            this.label4.Text = "Цена";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.TBCost);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(53, 232);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 21);
            this.panel2.TabIndex = 3;
            // 
            // TBCost
            // 
            this.TBCost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBCost.Location = new System.Drawing.Point(0, 0);
            this.TBCost.Margin = new System.Windows.Forms.Padding(6);
            this.TBCost.MaxLength = 9;
            this.TBCost.Name = "TBCost";
            this.TBCost.Size = new System.Drawing.Size(240, 19);
            this.TBCost.TabIndex = 15;
            this.TBCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBCost_KeyPress);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(53, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(266, 144);
            this.panel3.TabIndex = 79;
            // 
            // AddPlace
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.BtnBack;
            this.ClientSize = new System.Drawing.Size(342, 372);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BtnSave);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddPlace";
            this.Text = "AddPlace";
            this.Load += new System.EventHandler(this.AddPlace_Load);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.ComboBox CBStorage;
        private System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.TextBox TBZ;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.TextBox TBY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox TBX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox TBCost;
        private System.Windows.Forms.Panel panel3;
    }
}