using System;
using System.Collections.Generic;
using System.Windows.Forms;
using IT_Log.Business_Layer;
using IT_Log.Model;
using IT_Log.Data_Layer;
using Microsoft.Reporting.WinForms;
using System.Collections;
using System.Data;
using System.Reflection;
using System.Linq;

namespace IT_Log
{
    public partial class mainForm : Form
    {
        List<it_log_all> value { get; set; }

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            refreshList();
            dataGridViewITLog.Columns[0].Width = 20;
            dataGridViewITLog.Columns[1].Width = 120;
            dataGridViewITLog.Columns[2].Width = 40;
            dataGridViewITLog.Columns[3].Width = 60;
            dataGridViewITLog.Columns[4].Width = 60;
            dataGridViewITLog.Columns[5].Width = 170;
            dataGridViewITLog.Columns[6].Width = 120;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dataGridViewITLog.SelectedCells.Count > 0)
                {
                    int selectedrowindex = dataGridViewITLog.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridViewITLog.Rows[selectedrowindex];

                    int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                    ITLogServices.Delete(id);

                    refreshList();
                    disableEditButton();
                }
            }
        }

        private void dataGridViewITLog_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (FormAddEdit frm = new FormAddEdit(null))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    refreshList();
                    disableEditButton();
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to edit this?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dataGridViewITLog.SelectedCells.Count > 0)
                {
                    int selectedrowindex = dataGridViewITLog.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridViewITLog.Rows[selectedrowindex];

                    int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                    using (FormAddEdit frm = new FormAddEdit(id))
                    {
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            refreshList();
                            disableEditButton();
                        }
                    }
                }
            }
        }

        private void disableEditButton() {

            if (dataGridViewITLog.SelectedRows.Count == 1)
            {
                buttonEdit.Enabled = true;
                buttonDelete.Enabled = true;
            }
            else
            {
                buttonEdit.Enabled = false;
                buttonDelete.Enabled = false;
            }
        }

        private void dataGridViewITLog_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                if (dataGridViewITLog.HitTest(e.X, e.Y) == DataGridView.HitTestInfo.Nowhere) {

                    dataGridViewITLog.ClearSelection();
                }
            }
            disableEditButton();
        }

        private void mainForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dataGridViewITLog.ClearSelection();
            }

            disableEditButton();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var searchText = textBoxSearch.Text;
 
            value = ITLogServices.Search(searchText);
            dataGridViewITLog.DataSource = value;
            dataGridViewITLog.ClearSelection();
        }

        private void buttonSearchDate_Click(object sender, EventArgs e)
        {
            DateTime from = dateTimePickerFromSearch.Value;
            DateTime to = dateTimePickerToSearch.Value;

            value = ITLogServices.SearchByDate(from, to);
            dataGridViewITLog.DataSource = value;
            dataGridViewITLog.ClearSelection();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            refreshList();
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            FormReport frm = new FormReport();

            ReportDataSource rds = new ReportDataSource();

            rds.Name = "DataSetIT_Log_All";
            rds.Value = value;
            frm.reportViewerIT_Log.LocalReport.DataSources.Clear();
            frm.reportViewerIT_Log.LocalReport.DataSources.Add(rds);
            frm.reportViewerIT_Log.LocalReport.ReportEmbeddedResource = "IT_Log.ReportIT_Log.rdlc";
            frm.ShowDialog();
        }

        private void refreshList()
        {
            value = ITLogServices.GetAll();
            dataGridViewITLog.DataSource = value;
            dataGridViewITLog.ClearSelection();
        }
    }
}
