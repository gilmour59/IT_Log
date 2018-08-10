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
            dataGridViewITLog.Columns[3].Width = 50;
            dataGridViewITLog.Columns[4].Width = 50;
            dataGridViewITLog.Columns[5].Width = 170;
            dataGridViewITLog.Columns[6].Width = 120;

            list = ITLogServices.GetAll();
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
 
            dataGridViewITLog.DataSource = ITLogServices.Search(searchText);
            dataGridViewITLog.ClearSelection();
        }

        private void buttonSearchDate_Click(object sender, EventArgs e)
        {
            DateTime from = dateTimePickerFromSearch.Value;
            DateTime to = dateTimePickerToSearch.Value;

            dataGridViewITLog.DataSource = ITLogServices.SearchByDate(from, to);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            dataGridViewITLog.DataSource = ITLogServices.GetAll();
            dataGridViewITLog.ClearSelection();
        }

        private IList list { get; set; }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            using (ittransactionlogEntities db = new ittransactionlogEntities())
            {
                FormReport frm = new FormReport();

                frm.it_logBindingSource.DataSource = list; //USE THIS TO HAVE A GETTER AND SETTER FOR DYNAMIC BINDING SOURCE
                frm.ShowDialog();
            }
        }

        private void refreshList()
        {
            dataGridViewITLog.DataSource = ITLogServices.GetAll();
            dataGridViewITLog.ClearSelection();
        }
    }
}
