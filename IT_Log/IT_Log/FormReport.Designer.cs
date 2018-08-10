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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewerIT_Log = new Microsoft.Reporting.WinForms.ReportViewer();
            this.it_logBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.it_logBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerIT_Log
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.it_logBindingSource;
            this.reportViewerIT_Log.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerIT_Log.LocalReport.ReportEmbeddedResource = "IT_Log.ReportIT_Log.rdlc";
            this.reportViewerIT_Log.Location = new System.Drawing.Point(12, 12);
            this.reportViewerIT_Log.Name = "reportViewerIT_Log";
            this.reportViewerIT_Log.ServerReport.BearerToken = null;
            this.reportViewerIT_Log.Size = new System.Drawing.Size(776, 247);
            this.reportViewerIT_Log.TabIndex = 0;
            // 
            // it_logBindingSource
            // 
            this.it_logBindingSource.DataSource = typeof(IT_Log.Model.it_log);
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewerIT_Log);
            this.Name = "FormReport";
            this.Text = "FormReport";
            this.Load += new System.EventHandler(this.FormReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.it_logBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public Microsoft.Reporting.WinForms.ReportViewer reportViewerIT_Log;
        public System.Windows.Forms.BindingSource it_logBindingSource;
    }
}