
namespace KipreySklad.Forms
{
    partial class NewPassword
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TBPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TBPass1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TBPass2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.CBShow = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.TBPass);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(53, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 21);
            this.panel1.TabIndex = 55;
            // 
            // TBPass
            // 
            this.TBPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBPass.Location = new System.Drawing.Point(0, 0);
            this.TBPass.Margin = new System.Windows.Forms.Padding(6);
            this.TBPass.MaxLength = 45;
            this.TBPass.Name = "TBPass";
            this.TBPass.Size = new System.Drawing.Size(240, 19);
            this.TBPass.TabIndex = 15;
            this.TBPass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(40, 20, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 54;
            this.label1.Text = "Текущий пароль";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.TBPass1);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(53, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 21);
            this.panel2.TabIndex = 57;
            // 
            // TBPass1
            // 
            this.TBPass1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBPass1.Location = new System.Drawing.Point(0, 0);
            this.TBPass1.Margin = new System.Windows.Forms.Padding(6);
            this.TBPass1.MaxLength = 45;
            this.TBPass1.Name = "TBPass1";
            this.TBPass1.Size = new System.Drawing.Size(240, 19);
            this.TBPass1.TabIndex = 15;
            this.TBPass1.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(40, 20, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 56;
            this.label2.Text = "Новый пароль";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Controls.Add(this.TBPass2);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel3.Location = new System.Drawing.Point(53, 227);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 21);
            this.panel3.TabIndex = 59;
            // 
            // TBPass2
            // 
            this.TBPass2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBPass2.Location = new System.Drawing.Point(0, 0);
            this.TBPass2.Margin = new System.Windows.Forms.Padding(6);
            this.TBPass2.MaxLength = 45;
            this.TBPass2.Name = "TBPass2";
            this.TBPass2.Size = new System.Drawing.Size(240, 19);
            this.TBPass2.TabIndex = 15;
            this.TBPass2.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(40, 20, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 58;
            this.label3.Text = "Повторите";
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(185, 301);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(108, 31);
            this.BtnBack.TabIndex = 61;
            this.BtnBack.Text = "Отмена";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(53, 301);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(40, 3, 3, 3);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(108, 31);
            this.BtnSave.TabIndex = 60;
            this.BtnSave.Text = "Сохранить";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // CBShow
            // 
            this.CBShow.AutoSize = true;
            this.CBShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBShow.Location = new System.Drawing.Point(53, 257);
            this.CBShow.Margin = new System.Windows.Forms.Padding(6);
            this.CBShow.Name = "CBShow";
            this.CBShow.Size = new System.Drawing.Size(101, 24);
            this.CBShow.TabIndex = 62;
            this.CBShow.Text = "Показать";
            this.CBShow.UseVisualStyleBackColor = true;
            this.CBShow.CheckedChanged += new System.EventHandler(this.CBShow_CheckedChanged);
            // 
            // NewPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(350, 354);
            this.Controls.Add(this.CBShow);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NewPassword";
            this.Text = "Смена пароля";
            this.Load += new System.EventHandler(this.NewPassword_Load);
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

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox TBPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox TBPass1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox TBPass2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.CheckBox CBShow;
    }
}