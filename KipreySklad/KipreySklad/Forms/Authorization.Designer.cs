
namespace KipreySklad
{
    partial class Authorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.BtnLogin = new System.Windows.Forms.Button();
            this.CBShow = new System.Windows.Forms.CheckBox();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.TBlogin = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TBpassword = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnLogin.Location = new System.Drawing.Point(125, 222);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(109, 43);
            this.BtnLogin.TabIndex = 31;
            this.BtnLogin.Text = "Войти";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // CBShow
            // 
            this.CBShow.AutoSize = true;
            this.CBShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBShow.Location = new System.Drawing.Point(53, 176);
            this.CBShow.Margin = new System.Windows.Forms.Padding(6);
            this.CBShow.Name = "CBShow";
            this.CBShow.Size = new System.Drawing.Size(160, 24);
            this.CBShow.TabIndex = 30;
            this.CBShow.Text = "Показать пароль";
            this.CBShow.UseVisualStyleBackColor = true;
            this.CBShow.CheckedChanged += new System.EventHandler(this.CBShow_CheckedChanged);
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPassword.Location = new System.Drawing.Point(49, 122);
            this.LabelPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(67, 20);
            this.LabelPassword.TabIndex = 29;
            this.LabelPassword.Text = "Пароль";
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelLogin.Location = new System.Drawing.Point(49, 48);
            this.LabelLogin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(55, 20);
            this.LabelLogin.TabIndex = 28;
            this.LabelLogin.Text = "Логин";
            // 
            // TBlogin
            // 
            this.TBlogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBlogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBlogin.Location = new System.Drawing.Point(0, 0);
            this.TBlogin.Margin = new System.Windows.Forms.Padding(6);
            this.TBlogin.Name = "TBlogin";
            this.TBlogin.Size = new System.Drawing.Size(265, 19);
            this.TBlogin.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.TBlogin);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(53, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 21);
            this.panel1.TabIndex = 32;
            // 
            // TBpassword
            // 
            this.TBpassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBpassword.Location = new System.Drawing.Point(0, 0);
            this.TBpassword.Margin = new System.Windows.Forms.Padding(6);
            this.TBpassword.Name = "TBpassword";
            this.TBpassword.Size = new System.Drawing.Size(265, 19);
            this.TBpassword.TabIndex = 15;
            this.TBpassword.UseSystemPasswordChar = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.TBpassword);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(53, 145);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 21);
            this.panel2.TabIndex = 33;
            // 
            // Authorization
            // 
            this.AcceptButton = this.BtnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(372, 311);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.CBShow);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.LabelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Authorization";
            this.Text = "Вход в систему";
            this.Load += new System.EventHandler(this.Authorization_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.CheckBox CBShow;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.TextBox TBlogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TBpassword;
        private System.Windows.Forms.Panel panel2;
    }
}

