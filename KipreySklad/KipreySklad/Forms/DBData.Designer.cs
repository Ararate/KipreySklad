
namespace KipreySklad.Classes
{
    partial class DBData
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
            this.DSBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EncBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.UserBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CBShow = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // DSBox
            // 
            this.DSBox.Location = new System.Drawing.Point(152, 45);
            this.DSBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DSBox.Name = "DSBox";
            this.DSBox.Size = new System.Drawing.Size(225, 26);
            this.DSBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "DataSource";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Charset";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password";
            // 
            // EncBox
            // 
            this.EncBox.Location = new System.Drawing.Point(152, 182);
            this.EncBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EncBox.Name = "EncBox";
            this.EncBox.Size = new System.Drawing.Size(225, 26);
            this.EncBox.TabIndex = 5;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(152, 132);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(225, 26);
            this.PasswordBox.TabIndex = 6;
            this.PasswordBox.UseSystemPasswordChar = true;
            // 
            // UserBox
            // 
            this.UserBox.Location = new System.Drawing.Point(152, 87);
            this.UserBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(225, 26);
            this.UserBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 55);
            this.button1.TabIndex = 8;
            this.button1.Text = "Проверить подключение";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CBShow
            // 
            this.CBShow.AutoSize = true;
            this.CBShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBShow.Location = new System.Drawing.Point(152, 158);
            this.CBShow.Margin = new System.Windows.Forms.Padding(6);
            this.CBShow.Name = "CBShow";
            this.CBShow.Size = new System.Drawing.Size(89, 21);
            this.CBShow.TabIndex = 31;
            this.CBShow.Text = "Показать";
            this.CBShow.UseVisualStyleBackColor = true;
            this.CBShow.CheckedChanged += new System.EventHandler(this.CBShow_CheckedChanged);
            // 
            // DBData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(390, 355);
            this.Controls.Add(this.CBShow);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UserBox);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.EncBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DSBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DBData";
            this.Text = "Данные сервера";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DBData_FormClosing);
            this.Load += new System.EventHandler(this.DBData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DSBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EncBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox UserBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox CBShow;
    }
}