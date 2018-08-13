namespace IT_Log
{
    partial class FormReport
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
            this.reportViewerIT_Log = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerIT_Log
            // 
            this.reportViewerIT_Log.Location = new System.Drawing.Point(12, 12);
            this.reportViewerIT_Log.Name = "reportViewerIT_Log";
            this.reportViewerIT_Log.ServerReport.BearerToken = null;
            this.reportViewerIT_Log.Size = new System.Drawing.Size(809, 426);
            this.reportViewerIT_Log.TabIndex = 0;
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 450);
            this.Controls.Add(this.reportViewerIT_Log);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FormReport";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.FormReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer reportViewerIT_Log;
    }
}