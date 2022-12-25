
namespace KipreySklad.Forms
{
    partial class Progress
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
            this.DocProgress = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // DocProgress
            // 
            this.DocProgress.Location = new System.Drawing.Point(12, 59);
            this.DocProgress.Maximum = 1000;
            this.DocProgress.Name = "DocProgress";
            this.DocProgress.Size = new System.Drawing.Size(438, 23);
            this.DocProgress.Step = 1;
            this.DocProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.DocProgress.TabIndex = 0;
            // 
            // Progress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 94);
            this.Controls.Add(this.DocProgress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Progress";
            this.ShowInTaskbar = false;
            this.Text = "Создание документа";
            this.Load += new System.EventHandler(this.Progress_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ProgressBar DocProgress;
    }
}