
namespace KipreySklad.Forms
{
    partial class Cabinet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cabinet));
            this.LabFio = new System.Windows.Forms.Label();
            this.LabLogin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.EditPass = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LabRole = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LabPhone = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnUndo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabFio
            // 
            this.LabFio.AutoSize = true;
            this.LabFio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabFio.Location = new System.Drawing.Point(13, 41);
            this.LabFio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabFio.Name = "LabFio";
            this.LabFio.Size = new System.Drawing.Size(88, 29);
            this.LabFio.TabIndex = 0;
            this.LabFio.Text = "LabFio";
            // 
            // LabLogin
            // 
            this.LabLogin.AutoSize = true;
            this.LabLogin.Location = new System.Drawing.Point(14, 70);
            this.LabLogin.Name = "LabLogin";
            this.LabLogin.Size = new System.Drawing.Size(75, 20);
            this.LabLogin.TabIndex = 1;
            this.LabLogin.Text = "LabLogin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Должность:";
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(12, 231);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(170, 35);
            this.BtnEdit.TabIndex = 4;
            this.BtnEdit.Text = "Изменить данные";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditPass
            // 
            this.EditPass.Location = new System.Drawing.Point(232, 231);
            this.EditPass.Name = "EditPass";
            this.EditPass.Size = new System.Drawing.Size(170, 35);
            this.EditPass.TabIndex = 5;
            this.EditPass.Text = "Сменить пароль";
            this.EditPass.UseVisualStyleBackColor = true;
            this.EditPass.Click += new System.EventHandler(this.EditPass_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 22);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.LabRole);
            this.panel2.Location = new System.Drawing.Point(166, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 22);
            this.panel2.TabIndex = 9;
            // 
            // LabRole
            // 
            this.LabRole.AutoSize = true;
            this.LabRole.Location = new System.Drawing.Point(2, 1);
            this.LabRole.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LabRole.Name = "LabRole";
            this.LabRole.Size = new System.Drawing.Size(69, 20);
            this.LabRole.TabIndex = 2;
            this.LabRole.Text = "LabRole";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.LabPhone);
            this.panel3.Location = new System.Drawing.Point(166, 138);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(296, 22);
            this.panel3.TabIndex = 11;
            // 
            // LabPhone
            // 
            this.LabPhone.AutoSize = true;
            this.LabPhone.Location = new System.Drawing.Point(2, 1);
            this.LabPhone.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LabPhone.Name = "LabPhone";
            this.LabPhone.Size = new System.Drawing.Size(82, 20);
            this.LabPhone.TabIndex = 2;
            this.LabPhone.Text = "LabPhone";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(-2, 138);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(169, 22);
            this.panel4.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, -1);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Номер телефона:";
            // 
            // BtnBack
            // 
            this.BtnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBack.Image = ((System.Drawing.Image)(resources.GetObject("BtnBack.Image")));
            this.BtnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBack.Location = new System.Drawing.Point(535, 374);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(249, 35);
            this.BtnBack.TabIndex = 78;
            this.BtnBack.Text = "Назад";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnUndo
            // 
            this.BtnUndo.Enabled = false;
            this.BtnUndo.Image = ((System.Drawing.Image)(resources.GetObject("BtnUndo.Image")));
            this.BtnUndo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUndo.Location = new System.Drawing.Point(433, 231);
            this.BtnUndo.Margin = new System.Windows.Forms.Padding(16, 5, 4, 5);
            this.BtnUndo.Name = "BtnUndo";
            this.BtnUndo.Size = new System.Drawing.Size(29, 35);
            this.BtnUndo.TabIndex = 88;
            this.BtnUndo.UseVisualStyleBackColor = true;
            this.BtnUndo.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // Cabinet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(797, 423);
            this.Controls.Add(this.BtnUndo);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EditPass);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.LabLogin);
            this.Controls.Add(this.LabFio);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Cabinet";
            this.Text = "Личный кабинет";
            this.Load += new System.EventHandler(this.Cabinet_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabFio;
        private System.Windows.Forms.Label LabLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button EditPass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LabRole;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LabPhone;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnBack;
        public System.Windows.Forms.Button BtnUndo;
    }
}