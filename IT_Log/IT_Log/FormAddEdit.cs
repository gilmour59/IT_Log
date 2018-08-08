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

        public FormAddEdit()
        {
            InitializeComponent();
        }

        private void FormAddEdit_Load(object sender, EventArgs e)
        {
            comboBoxITPersonnel.SelectedIndex = 0;
        }
    }
}
