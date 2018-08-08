using IT_Log.Model;
using IT_Log.Business_Layer;
using IT_Log.Data_Layer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IT_Log
{
    public partial class FormAddEdit : Form
    {
        bool IsNew;
        it_log updateObj;

        public FormAddEdit(int? id)
        {
            InitializeComponent();

            if (id == null)
            {
                IsNew = true;
            }
            else {
                this.updateObj = ITLogServices.GetById((int)id);
                IsNew = false;

                textBoxName.Text = updateObj.name;
                textBoxOffice.Text = updateObj.office;
                dateTimePickerDate.Text = Convert.ToDateTime(updateObj.date).ToString();
                dateTimePickerTime.Text = updateObj.time.ToString();
                textBoxServiceRequest.Text = updateObj.service_request;
                comboBoxITPersonnel.SelectedIndex = (int)updateObj.it_personnel_id;
            }
        }

        private void FormAddEdit_Load(object sender, EventArgs e)
        {
            if (IsNew == true) {
                comboBoxITPersonnel.SelectedIndex = 0;
            } 
        }

        private void FormAddEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK) {

                if (string.IsNullOrEmpty(textBoxName.Text))
                {
                    MessageBox.Show("Please Enter Name!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxName.Focus();
                    e.Cancel = true;
                    return;
                }

                if (string.IsNullOrEmpty(textBoxOffice.Text))
                {
                    MessageBox.Show("Please Enter Office Name!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxOffice.Focus();
                    e.Cancel = true;
                    return;
                }

                if ((string.IsNullOrEmpty(dateTimePickerDate.Text)))
                {
                    MessageBox.Show("Please Enter the Date!");
                    dateTimePickerDate.Focus();
                    e.Cancel = true;
                    return;
                }

                if ((string.IsNullOrEmpty(dateTimePickerTime.Text)))
                {
                    MessageBox.Show("Please Enter the Date!");
                    dateTimePickerTime.Focus();
                    e.Cancel = true;
                    return;
                }

                if (string.IsNullOrEmpty(textBoxServiceRequest.Text))
                {
                    MessageBox.Show("Please Enter the Service Requested!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxServiceRequest.Focus();
                    e.Cancel = true;
                    return;
                }

                if (IsNew)
                {
                    var log = new it_log()
                    {
                        name = textBoxName.Text.ToString(),
                        office = textBoxOffice.Text.ToString(),
                        date = Convert.ToDateTime(dateTimePickerDate.Text),
                        time = TimeSpan.Parse(dateTimePickerTime.Text),
                        service_request = textBoxServiceRequest.Text.ToString(),
                        it_personnel_id = comboBoxITPersonnel.SelectedIndex
                    };

                    ITLogServices.Insert(log);
                    MessageBox.Show("Added!");
                }else
                {
                    updateObj.name = textBoxName.Text.ToString();
                    updateObj.office = textBoxOffice.Text.ToString();
                    updateObj.date = Convert.ToDateTime(dateTimePickerDate.Text);
                    updateObj.time = TimeSpan.Parse(dateTimePickerTime.Text);
                    updateObj.service_request = textBoxServiceRequest.Text.ToString();
                    updateObj.it_personnel_id = comboBoxITPersonnel.SelectedIndex;

                    ITLogServices.Update(updateObj);
                    MessageBox.Show("Saved!");
                }
            }
        }
    }
}
