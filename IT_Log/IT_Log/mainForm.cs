using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IT_Log.Business_Layer;
using IT_Log.Model;
using IT_Log.Data_Layer;

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
            dataGridViewITLog.DataSource = ITLogServices.GetAll();
        }

        private void refreshList() {

            dataGridViewITLog.DataSource = ITLogServices.GetAll();
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
                }
            }
        }

        private void dataGridViewITLog_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (FormAddEdit frm = new FormAddEdit())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    refreshList();
                }
            }
        }
    }
}
