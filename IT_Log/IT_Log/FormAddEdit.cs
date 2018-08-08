using IT_Log.Model;
using IT_Log.Business_Layer;
using IT_Log.Data_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_Log
{
    public partial class FormAddEdit : Form
    {
        bool IsNew;

        public FormAddEdit(int? id)
        {
            InitializeComponent();

            if (id == null)
            {
                IsNew = true;
            }
            else {

                IsNew = false;
            }
        }

        private void FormAddEdit_Load(object sender, EventArgs e)
        {
            comboBoxITPersonnel.SelectedIndex = 0;
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

                var log = new it_log()
                {

                    name = textBoxName.Text.ToString(),
                    office = textBoxOffice.Text.ToString(),
                    date = Convert.ToDateTime(dateTimePickerDate.Text),
                    time = TimeSpan.Parse(dateTimePickerTime.Text),
                    service_request = textBoxServiceRequest.Text.ToString(),
                    it_personnel_id = comboBoxITPersonnel.SelectedIndex
                };

                if (IsNew)
                {
                    ITLogServices.Insert(log);
                    MessageBox.Show("Added!");
                }else
                {
                    //EmployeeInfoServices.Update(employeeinfoBindingSource.Current as employee_info);
                    MessageBox.Show("Saved!");
                }

            }
        }
    }
}
