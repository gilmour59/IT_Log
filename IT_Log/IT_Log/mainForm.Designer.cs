namespace IT_Log
{
    partial class mainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewITLog = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dateTimePickerFromSearch = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerToSearch = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSearchDate = new System.Windows.Forms.Button();
            this.groupBoxSearchDate = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSearchPersonnel = new System.Windows.Forms.Button();
            this.comboBoxPersonnel = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewITLog)).BeginInit();
            this.groupBoxSearchDate.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewITLog
            // 
            this.dataGridViewITLog.AllowUserToAddRows = false;
            this.dataGridViewITLog.AllowUserToDeleteRows = false;
            this.dataGridViewITLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewITLog.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewITLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewITLog.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewITLog.Location = new System.Drawing.Point(31, 118);
            this.dataGridViewITLog.Name = "dataGridViewITLog";
            this.dataGridViewITLog.ReadOnly = true;
            this.dataGridViewITLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewITLog.Size = new System.Drawing.Size(797, 245);
            this.dataGridViewITLog.TabIndex = 0;
            this.dataGridViewITLog.SelectionChanged += new System.EventHandler(this.dataGridViewITLog_SelectionChanged);
            this.dataGridViewITLog.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridViewITLog_MouseUp);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(847, 183);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(82, 42);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Enabled = false;
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(847, 251);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(82, 42);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(847, 321);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(82, 42);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dateTimePickerFromSearch
            // 
            this.dateTimePickerFromSearch.CustomFormat = "MM-dd-yyyy";
            this.dateTimePickerFromSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFromSearch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFromSearch.Location = new System.Drawing.Point(19, 40);
            this.dateTimePickerFromSearch.Name = "dateTimePickerFromSearch";
            this.dateTimePickerFromSearch.Size = new System.Drawing.Size(107, 21);
            this.dateTimePickerFromSearch.TabIndex = 3;
            this.dateTimePickerFromSearch.ValueChanged += new System.EventHandler(this.dateTimePickerFromSearch_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "From:   (MM/DD/YYYY)";
            // 
            // dateTimePickerToSearch
            // 
            this.dateTimePickerToSearch.CustomFormat = "MM-dd-yyyy";
            this.dateTimePickerToSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerToSearch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerToSearch.Location = new System.Drawing.Point(153, 42);
            this.dateTimePickerToSearch.Name = "dateTimePickerToSearch";
            this.dateTimePickerToSearch.Size = new System.Drawing.Size(107, 21);
            this.dateTimePickerToSearch.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "To:   (MM/DD/YYYY)";
            // 
            // buttonSearchDate
            // 
            this.buttonSearchDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchDate.Location = new System.Drawing.Point(276, 40);
            this.buttonSearchDate.Name = "buttonSearchDate";
            this.buttonSearchDate.Size = new System.Drawing.Size(60, 23);
            this.buttonSearchDate.TabIndex = 5;
            this.buttonSearchDate.Text = "Search";
            this.buttonSearchDate.UseVisualStyleBackColor = true;
            this.buttonSearchDate.Click += new System.EventHandler(this.buttonSearchDate_Click);
            // 
            // groupBoxSearchDate
            // 
            this.groupBoxSearchDate.Controls.Add(this.buttonSearchDate);
            this.groupBoxSearchDate.Controls.Add(this.dateTimePickerFromSearch);
            this.groupBoxSearchDate.Controls.Add(this.label2);
            this.groupBoxSearchDate.Controls.Add(this.label1);
            this.groupBoxSearchDate.Controls.Add(this.dateTimePickerToSearch);
            this.groupBoxSearchDate.Location = new System.Drawing.Point(31, 21);
            this.groupBoxSearchDate.Name = "groupBoxSearchDate";
            this.groupBoxSearchDate.Size = new System.Drawing.Size(354, 76);
            this.groupBoxSearchDate.TabIndex = 6;
            this.groupBoxSearchDate.TabStop = false;
            this.groupBoxSearchDate.Text = "Search by Date";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.textBoxSearch);
            this.groupBox1.Location = new System.Drawing.Point(402, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 76);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(110, 39);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(63, 23);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(12, 40);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(92, 21);
            this.textBoxSearch.TabIndex = 0;
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(847, 37);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(82, 47);
            this.buttonReset.TabIndex = 8;
            this.buttonReset.Text = "Reset Data";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonReport
            // 
            this.buttonReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReport.Location = new System.Drawing.Point(847, 118);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(82, 44);
            this.buttonReport.TabIndex = 9;
            this.buttonReport.Text = "Generate Report";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonSearchPersonnel);
            this.groupBox2.Controls.Add(this.comboBoxPersonnel);
            this.groupBox2.Location = new System.Drawing.Point(604, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 76);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personnel";
            // 
            // buttonSearchPersonnel
            // 
            this.buttonSearchPersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchPersonnel.Location = new System.Drawing.Point(154, 38);
            this.buttonSearchPersonnel.Name = "buttonSearchPersonnel";
            this.buttonSearchPersonnel.Size = new System.Drawing.Size(57, 23);
            this.buttonSearchPersonnel.TabIndex = 2;
            this.buttonSearchPersonnel.Text = "Search";
            this.buttonSearchPersonnel.UseVisualStyleBackColor = true;
            this.buttonSearchPersonnel.Click += new System.EventHandler(this.buttonSearchPersonnel_Click);
            // 
            // comboBoxPersonnel
            // 
            this.comboBoxPersonnel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPersonnel.FormattingEnabled = true;
            this.comboBoxPersonnel.Items.AddRange(new object[] {
            "Felixberto Baguyo Jr.",
            "Henden Alimen",
            "Gzid Ann Camporaso",
            "Klark Bofill",
            "Gilmour Almalbis"});
            this.comboBoxPersonnel.Location = new System.Drawing.Point(10, 40);
            this.comboBoxPersonnel.Name = "comboBoxPersonnel";
            this.comboBoxPersonnel.Size = new System.Drawing.Size(136, 21);
            this.comboBoxPersonnel.TabIndex = 0;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 454);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxSearchDate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewITLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IT Transaction Log";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewITLog)).EndInit();
            this.groupBoxSearchDate.ResumeLayout(false);
            this.groupBoxSearchDate.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewITLog;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerToSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSearchDate;
        private System.Windows.Forms.GroupBox groupBoxSearchDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxPersonnel;
        private System.Windows.Forms.Button buttonSearchPersonnel;
    }
}

