
namespace KipreySklad.Forms
{
    partial class ChooseDogovor
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.CBDogovor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnPdf = new System.Windows.Forms.Button();
            this.BtnDoc = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel5.Controls.Add(this.CBDogovor);
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel5.Location = new System.Drawing.Point(122, 65);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(271, 30);
            this.panel5.TabIndex = 65;
            // 
            // CBDogovor
            // 
            this.CBDogovor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CBDogovor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBDogovor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBDogovor.FormattingEnabled = true;
            this.CBDogovor.Location = new System.Drawing.Point(0, 0);
            this.CBDogovor.Name = "CBDogovor";
            this.CBDogovor.Size = new System.Drawing.Size(271, 28);
            this.CBDogovor.TabIndex = 0;
            this.CBDogovor.SelectionChangeCommitted += new System.EventHandler(this.CBDogovor_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(40, 20, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 64;
            this.label4.Text = "Номер договора";
            // 
            // BtnPdf
            // 
            this.BtnPdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnPdf.Location = new System.Drawing.Point(270, 125);
            this.BtnPdf.Name = "BtnPdf";
            this.BtnPdf.Size = new System.Drawing.Size(75, 34);
            this.BtnPdf.TabIndex = 82;
            this.BtnPdf.Text = "pdf";
            this.BtnPdf.UseVisualStyleBackColor = true;
            this.BtnPdf.Click += new System.EventHandler(this.BtnPdf_Click);
            // 
            // BtnDoc
            // 
            this.BtnDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnDoc.Location = new System.Drawing.Point(152, 125);
            this.BtnDoc.Name = "BtnDoc";
            this.BtnDoc.Size = new System.Drawing.Size(75, 34);
            this.BtnDoc.TabIndex = 81;
            this.BtnDoc.Text = "docx";
            this.BtnDoc.UseVisualStyleBackColor = true;
            this.BtnDoc.Click += new System.EventHandler(this.BtnDoc_Click);
            // 
            // ChooseDogovor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(539, 187);
            this.Controls.Add(this.BtnPdf);
            this.Controls.Add(this.BtnDoc);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChooseDogovor";
            this.Text = "Номер договора";
            this.Load += new System.EventHandler(this.ChooseDogovor_Load);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.ComboBox CBDogovor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnPdf;
        private System.Windows.Forms.Button BtnDoc;
    }
}