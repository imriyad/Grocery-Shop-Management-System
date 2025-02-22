
namespace LoginAndRegistrationForm
{
    partial class ReportInfo
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
            this.SName = new System.Windows.Forms.Label();
            this.TbReportShow = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SName
            // 
            this.SName.AutoSize = true;
            this.SName.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SName.ForeColor = System.Drawing.Color.IndianRed;
            this.SName.Location = new System.Drawing.Point(31, 67);
            this.SName.Name = "SName";
            this.SName.Size = new System.Drawing.Size(109, 29);
            this.SName.TabIndex = 16;
            this.SName.Text = "Report :";
            // 
            // TbReportShow
            // 
            this.TbReportShow.Location = new System.Drawing.Point(62, 124);
            this.TbReportShow.Multiline = true;
            this.TbReportShow.Name = "TbReportShow";
            this.TbReportShow.Size = new System.Drawing.Size(560, 431);
            this.TbReportShow.TabIndex = 17;
            // 
            // ReportInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 690);
            this.Controls.Add(this.TbReportShow);
            this.Controls.Add(this.SName);
            this.Name = "ReportInfo";
            this.Text = "ReportInfo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label SName;
        private System.Windows.Forms.TextBox TbReportShow;
    }
}